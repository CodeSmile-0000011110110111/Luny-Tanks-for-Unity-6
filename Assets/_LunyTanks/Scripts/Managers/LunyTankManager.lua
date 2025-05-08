-- NOTE: This script is assigned to the Luny component. It is not a LunyScript (MonoBehaviour) class.

-- This script is to manage various settings on a tank.
-- It works with the GameManager class to control how the tanks behave
-- and whether or not players have control of their tank in the
-- different phases of the game.

-- this must be a global table, therefore the 'local' keyword is omitted
LunyTankManager =
{
    PlayerColor = nil,          -- This is the color this tank will be tinted.
    PlayerNumber = 0,           -- This specifies which player this the manager for.
    ColoredPlayerText = "",     -- A string that represents the player with their number colored to match their tank.
    Instance = nil,             -- A reference to the instance of the tank when it is created.
    Wins = 0,                   -- The number of wins this player has so far.
    ComputerControlled = false, -- Is that tank computer controlled

    Movement = nil,             -- Reference to tank's movement script, used to disable and enable control.
    Shooting = nil,             -- Reference to tank's shooting script, used to disable and enable control.
    CanvasGameObject = nil,     -- Used to disable the world space UI during the Starting and Ending phases of each round.
    AI = nil,                   -- The Tank AI script that let a tank be a bot controlled by the computer
    --InputUser = nil,            -- The Input user link to that tank. Input user identify a single player in the Input system
}

function LunyTankManager.Setup(tank, gameManager)
    -- Get references to the components.
    tank.Movement = tank.Instance:GetComponent(lunytankmovement).script
    tank.Shooting = tank.Instance:GetComponent(lunytankshooting).script
    tank.AI = tank.Instance:GetComponent(lunytankai)
    tank.CanvasGameObject = tank.Instance:GetComponentInChildren(canvas).gameObject

    -- Assign the Input User of that Tank to the script controlling input system binding, so the move/fire actions
    -- get only triggered by the right input for that users (e.g. arrow doesn't trigger move if that input user use WASD)
    -- CS: The two lines below have no effect and thus are commented.
    -- See: https://discussions.unity.com/t/official-unity-learn-event-learn-along-featuring-tanks-remastered-for-unity-6-on-unity-learn/1633869/23
    --local inputUser = tank.Instance:GetComponent(lunytankinputuser)
    --inputUser.script.SetNewInputUser(tank.InputUser)

    -- Toggle computer controlled on the movement/firing if this tank was tagged as being computer controlled
    tank.Movement.IsComputerControlled = tank.ComputerControlled
    tank.Shooting.IsComputerControlled = tank.ComputerControlled

    -- Pass along the player number and control index to the movement components. See the TankMovement script for
    -- hose those are used to decided which input the movement respond to.
    tank.Movement.PlayerNumber = tank.PlayerNumber
    tank.Movement.ControlIndex = tank.ControlIndex

    -- If this tank is computer controlled, add a TankAI component that take care of controlling the behavior
    if tank.ComputerControlled then
        tank.AI = tank.Instance:AddComponent(lunytankai).script
        tank.AI.Setup(gameManager)
    end

    -- Create a string using the correct color that says 'PLAYER 1' etc based on the tank's color and the player's number.
    local rgb = colorutility.ToHtmlStringRGB(tank.PlayerColor)
    tank.ColoredPlayerText = "<color=#" .. rgb .. ">PLAYER " .. tank.PlayerNumber .. "</color>"

    -- Get all of the renderers of the tank.
    local renderers = tank.Instance:GetComponentsInChildren(meshrenderer)

    -- Go through all the renderers...
    for _, renderer in ipairs(renderers) do
        for _, material in ipairs(renderer.materials) do
            -- If the material is the tank color one...
            if string.find(material.name, "TankColor") then
                -- change its color to the player color
                material.color = tank.PlayerColor
            end
        end
    end
end

-- Used during the phases of the game where the player should (not) be able to control their tank.
function LunyTankManager.EnableControl(tank, enable)
    tank.Movement.enabled = enable
    tank.Shooting.enabled = enable
    if tank.ComputerControlled then
        tank.AI.enabled = enable
    end

    tank.CanvasGameObject:SetActive(enable)
end

-- Used at the start of each round to put the tank into it's default state.
function LunyTankManager.Reset(tank)
    tank.Instance.transform.position = tank.SpawnPoint.position
    tank.Instance.transform.rotation = tank.SpawnPoint.rotation

    tank.Instance:SetActive(false)
    tank.Instance:SetActive(true)
end
