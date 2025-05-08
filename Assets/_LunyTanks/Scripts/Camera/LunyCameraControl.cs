using CodeSmile.Luny;
using UnityEngine;

namespace CodeSmile.Luny.Tanks
{
	public sealed class LunyCameraControl : LunyScript
	{
        public float m_DampTime = 0.2f;                 // Approximate time for the camera to refocus.
        public float m_ScreenEdgeBuffer = 4f;           // Space between the top/bottom most target and the screen edge.
        public float m_MinSize = 6.5f;                  // The smallest orthographic size the camera can be.

        protected override void OnBeforeScriptAwake()
        {
	        SetFloat(nameof(m_DampTime).Substring(2), m_DampTime);
	        SetFloat(nameof(m_ScreenEdgeBuffer).Substring(2), m_ScreenEdgeBuffer);
	        SetFloat(nameof(m_MinSize).Substring(2), m_MinSize);
        }
	}
}
