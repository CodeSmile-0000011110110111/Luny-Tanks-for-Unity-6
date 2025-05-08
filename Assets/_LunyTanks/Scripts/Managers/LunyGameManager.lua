local script = {...}

-- Which state the game is currently in
-- In Lua an 'enum' is best represented by a table.
-- Enum values can be functions to better represent a switch/case block.
local GameState =
{
    MainMenu = function() end, -- does nothing, ensures a call is legal
    Game = function() script.GameStart() end, -- wrapped in function because GameStart() is not yet declared here
}

-- Data about the selected tanks passed from the menu to the GameManager
local PlayerData =
{
    IsComputer = false,
    TankColor = nil,
    UsedPrefab = nil,
    ControlIndex = 0,
}

local m_CurrentState = nil

local m_RoundNumber = 0                 -- Which round the game is currently on.
local m_RoundWinner = nil               -- Reference to the winner of the current round.  Used to make an announcement of who won.
local m_GameWinner = nil                -- Reference to the winner of the game.  Used to make an announcement of who won.

local m_PlayerData = nil                  -- Data passed from the menu about each selected tank (at least 2, max 4)
local m_PlayerCount = 0                 -- The number of players (2 to 4), decided from the number of PlayerData passed by the menu
local m_TitleText = nil                 -- The text used to display game message. Automatically found as part of the Menu prefab


function script.CreateTank()
    -- unpack the default values into a new table to create a shallow copy (will not copy 'nil' values)
    local tank = {}
    for key, value in pairs(LunyTankManager) do
        print("tank" , key, value)
        tank[key] = value
    end
    return tank
end

function script.Start()
    m_CurrentState = GameState.MainMenu

    -- Find the text used to display game info. Need to look at inactive object too, as the Menu prefab (which contains it) may be
    -- disabled at the start when the user have a Title Screen which will enable the Menu.
    local textRef = gameobject.FindAnyObjectByType(lunymessagetextreference, true)

    -- If that text couldn't be found, we display an error and exit as it is required for the game manager to work
    if not textRef then
        error("You need to add the Menus prefab in the scene to use the GameManager!")
        return
    end

    m_TitleText = textRef.GetTextComponent()
    m_TitleText.text = ""

    -- The GameManager require 4 tanks prefabs, as the start menu have 4 fixed slot and need the 4 tanks to show there
    if not script.Tank1Prefab or not script.Tank2Prefab or not script.Tank3Prefab or not script.Tank4Prefab then
        error("You need to assign 4 tank prefabs in the GameManager!")
    end
end

function script.ChangeGameState(newState)
    m_CurrentState = newState

    -- emulate the use of a 'switch/case' by simply calling the function defined in GameState
    m_CurrentState()
end

-- Called by the menu, passing along the data from the selection made by the player in the menu
function script.StartGame(playerData)
    m_PlayerData = playerData
    m_PlayerCount = #m_PlayerData
    script.ChangeGameState(GameState.Game)
end

-- FIXME: it's super confusing to have both StartGame() and GameStart() ..
function script.GameStart()
    script.SpawnAllTanks()
    script.SetCameraTargets()

    -- Once the tanks have been created and the camera is using them as targets, start the game.
    script.component:StartCoroutine(script.GameLoop)
end

function script.SpawnAllTanks()
    -- For all the tanks...
    for i, playerData in ipairs(m_PlayerData) do
        local tank = script.SpawnPoints[i];

        -- ... create them, set their player number and references needed for control.
        local pos = tank.SpawnPoint.position
        local rot = tank.SpawnPoint.rotation
        tank.Instance = gameobject.Instantiate(playerData.UsedPrefab, pos, rot)

        --this guard against possible user error : if they created a prefab with Is Computer Control set to true
        --then all of those prefab would be bots. So we ensure it's to false (the IsComputer from player data
        --will re-enable this if needed when the game start)
        local movement = tank.Instance:GetComponent(lunytankmovement).script
        movement.IsComputerControlled = false

        tank.PlayerNumber = i
        tank.ControlIndex = playerData.ControlIndex
        tank.PlayerColor = playerData.TankColor
        tank.ComputerControlled = playerData.IsComputer
    end

    --we delayed setup after all tanks are created as they expect to have access to all other tanks in the manager
    for _, tank in ipairs(script.SpawnPoints) do
        if tank.Instance then
            LunyTankManager.Setup(tank, script)
        end
    end
end

function script.SetCameraTargets()
    -- Create a collection of transforms the same size as the number of tanks.
    local targets = {}

    -- For each of these transforms...
    for i = 1, m_PlayerCount do
        -- ... set it to the appropriate tank transform.
        targets[i] = script.SpawnPoints[i].Instance.transform
    end

    -- These are the targets the camera should follow.
    script.CameraControl.script.Targets = targets
end

-- This is called from start and will run each phase of the game one after another.
function script.GameLoop() -- coroutine
    -- Start off by running the 'RoundStarting' coroutine but don't return until it's finished.
    yield.StartCoroutine(script.RoundStarting)

    -- Once the 'RoundStarting' coroutine is finished, run the 'RoundPlaying' coroutine but don't return until it's finished.
    print("GameLoop - before playing")
    yield.StartCoroutine(script.RoundPlaying)

    -- Once execution has returned here, run the 'RoundEnding' coroutine, again don't return until it's finished.
    print("GameLoop - before ending")
    yield.StartCoroutine(script.RoundEnding)

    -- This code is not run until 'RoundEnding' has finished.  At which point, check if a game winner has been found.
    if m_GameWinner then
        -- If there is a game winner, restart the level.
        print("GameLoop - before loadscene")
        scenemanager.LoadScene(0)
    else
        -- If there isn't a winner yet, restart this coroutine so the loop continues.
        -- Note that this coroutine doesn't yield.  This means that the current version of the GameLoop will end.
        print("GameLoop - before restart GameLoop")
        script.component:StartCoroutine(script.GameLoop)
    end
end

function script.RoundStarting() -- coroutine
    -- As soon as the round starts reset the tanks and make sure they can't move.
    script.ResetAllTanks()
    script.EnableTankControl(false)

    -- Snap the camera's zoom and position to something appropriate for the reset tanks.
    script.CameraControl.script.SetStartPositionAndSize()

    -- Increment the round number and display text showing the players what round it is.
    m_RoundNumber = m_RoundNumber + 1
    m_TitleText.text = "ROUND " .. m_RoundNumber

    -- Wait for the specified length of time until yielding control back to the game loop.
    yield.WaitForSeconds(script.StartDelay)
end

function script.RoundPlaying() -- coroutine
    print("RoundPlaying")
    -- As soon as the round begins playing let the players control the tanks.
    script.EnableTankControl(true)

    -- Clear the text from the screen.
    m_TitleText.text = ""

    -- While there is not one tank left...
    while not script.OneTankLeft() do
        -- ... return on the next frame.
        yield.null()
    end
    print("RoundPlaying ends")
end

function script.RoundEnding() -- coroutine
    print("RoundEnding")
    -- Stop tanks from moving.
    script.EnableTankControl(false)

    -- See if there is a winner now the round is over.
    m_RoundWinner = script.GetRoundWinner()
    print("winner", m_RoundWinner)
    print("wins", m_RoundWinner.Wins)

    -- If there is a winner, increment their score.
    if m_RoundWinner then
        m_RoundWinner.Wins = m_RoundWinner.Wins + 1
    end

    -- Now the winner's score has been incremented, see if someone has one the game.
    m_GameWinner = script.GetGameWinner()

    -- Get a message based on the scores and whether or not there is a game winner and display it.
    m_TitleText.text = script.EndMessage()

    -- Wait for the specified length of time until yielding control back to the game loop.
    yield.WaitForSeconds(script.EndDelay)
    print("RoundEnding ends")
end

-- This is used to check if there is one or fewer tanks remaining and thus the round should end.
function script.OneTankLeft()
    -- Start the count of tanks left at zero.
    local numTanksLeft = 0

    -- Go through all the tanks...
    for i = 1, m_PlayerCount do
        local tank = script.SpawnPoints[i];

        -- ... and if they are active, increment the counter.
        if tank.Instance.activeSelf then
            numTanksLeft = numTanksLeft + 1
        end
    end

    -- If there are one or fewer tanks remaining return true, otherwise return false.
    return numTanksLeft <= 1
end

-- This function is to find out if there is a winner of the round.
-- This function is called with the assumption that 1 or fewer tanks are currently active.
function script.GetRoundWinner()
    print("GetRoundWinner")
    -- Go through all the tanks...
    for i = 1, m_PlayerCount do
        local tank = script.SpawnPoints[i];

        -- ... and if one of them is active, it is the winner so return it.
        if tank.Instance.activeSelf then
            return tank
        end
    end

    -- If none of the tanks are active it is a draw so return null.
    return nil
end

-- This function is to find out if there is a winner of the game.
function script.GetGameWinner()
    print("GetGameWinner")
    -- Go through all the tanks...
    for i = 1, m_PlayerCount do
        -- ... and if one of them has enough rounds to win the game, return it.
        local tank = script.SpawnPoints[i];

        if tank.Wins == script.NumRoundsToWin then
            print("GetGameWinner returns", tank)
            return tank
        end
    end

    -- If no tanks have enough rounds to win, return null.
    print("GetGameWinner returns nil")
    return nil
end

-- Returns a string message to display at the end of each round.
function script.EndMessage()
    print("EndMessage")
    -- By default when a round ends there are no winners so the default end message is a draw.
    local message = "DRAW!"

    -- If there is a winner then change the message to reflect that.
    if m_RoundWinner then
        message = m_RoundWinner.ColoredPlayerText .. " WINS THE ROUND!"
    end

    -- Add some line breaks after the initial message.
    message = message .. "\n\n\n\n"

    -- Go through all the tanks and add each of their scores to the message.
    for i = 1, m_PlayerCount do
        local tank = script.SpawnPoints[i];
        local playerText = tank.ColoredPlayerText
        message = message .. playerText .. ": " .. tank.Wins .. " WINS\n"
    end

    -- If there is a game winner, change the entire message to reflect that.
    if m_GameWinner then
        message = m_GameWinner.ColoredPlayerText .. " WINS THE GAME!"
    end

    print("EndMessage returns", message)
    return message
end

-- This function is used to turn all the tanks back on and reset their positions and properties.
function script.ResetAllTanks()
    for i = 1, m_PlayerCount do
        LunyTankManager.Reset(script.SpawnPoints[i])
    end
end

function script.EnableTankControl(enable)
    for i = 1, m_PlayerCount do
        LunyTankManager.EnableControl(script.SpawnPoints[i], enable)
    end
end

return script
