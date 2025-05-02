/*
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Layouts;

namespace CodeSmile.Luny.Tanks
{
	// A On Screen joystick that emulate a gamepad joystick for the Input System
	public sealed class LunyUIVirtualJoystick : LunyScript //  : OnScreenControl, IPointerDownHandler, IDragHandler, IPointerUpHandler
	{
		[Header("Rect References")]
        public RectTransform containerRect;
        public RectTransform handleRect;

        [Header("Settings")]
        public float joystickRange = 50f;
        public float magnitudeMultiplier = 1f;
        public bool invertXOutputValue;
        public bool invertYOutputValue;

        [InputControl(layout = "Vector2")]
        [SerializeField]
        private string m_ControlPath;

        void Start()
        {
            SetupHandle();
        }

        private void SetupHandle()
        {
            if(handleRect)
            {
                UpdateHandleRectPosition(Vector2.zero);
            }
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            OnDrag(eventData);
        }

        public void OnDrag(PointerEventData eventData)
        {

            RectTransformUtility.ScreenPointToLocalPointInRectangle(containerRect, eventData.position, eventData.pressEventCamera, out Vector2 position);

            position = ApplySizeDelta(position);

            Vector2 clampedPosition = ClampValuesToMagnitude(position);

            Vector2 outputPosition = ApplyInversionFilter(position);

            OutputPointerEventValue(outputPosition * magnitudeMultiplier);

            if(handleRect)
            {
                UpdateHandleRectPosition(clampedPosition * joystickRange);
            }

        }

        public void OnPointerUp(PointerEventData eventData)
        {
            OutputPointerEventValue(Vector2.zero);

            if(handleRect)
            {
                UpdateHandleRectPosition(Vector2.zero);
            }
        }

        private void OutputPointerEventValue(Vector2 pointerPosition)
        {
            SendValueToControl(pointerPosition);
        }

        private void UpdateHandleRectPosition(Vector2 newPosition)
        {
            handleRect.anchoredPosition = newPosition;
        }

        Vector2 ApplySizeDelta(Vector2 position)
        {
            float x = (position.x/containerRect.sizeDelta.x) * 2.5f;
            float y = (position.y/containerRect.sizeDelta.y) * 2.5f;
            return new Vector2(x, y);
        }

        Vector2 ClampValuesToMagnitude(Vector2 position)
        {
            return Vector2.ClampMagnitude(position, 1);
        }

        Vector2 ApplyInversionFilter(Vector2 position)
        {
            if(invertXOutputValue)
            {
                position.x = InvertValue(position.x);
            }

            if(invertYOutputValue)
            {
                position.y = InvertValue(position.y);
            }

            return position;
        }

        float InvertValue(float value)
        {
            return -value;
        }

        protected override string controlPathInternal { get => m_ControlPath; set => m_ControlPath = value; }


		// Awake cannot be overridden, use OnAwake instead. The script has not been loaded at this point!
		protected override void OnAwake() {}

		// Script was run and returned a LuaTable. Script's Awake() function has not been called yet.
		// You may want to get/set initial script variables before script's Awake():
		protected override void OnBeforeScriptAwake()
		{
			// Variables are set to the script table (commonly named 'script'): 'print(script.ImportantMessage)'
			SetString("ImportantMessage", "Testing One-Two-Three ..");

			// If you need the value of 'script.OhWowThatsCoolBool' assigned by the Lua script:
			var datBool = GetBool("OhWowThatsCoolBool");
		}
	}
}
*/
