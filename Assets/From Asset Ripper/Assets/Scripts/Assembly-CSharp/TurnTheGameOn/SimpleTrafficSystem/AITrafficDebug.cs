using UnityEngine;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	[CreateAssetMenu(fileName = "AITrafficDebug", menuName = "SimpleTrafficSystem/AITrafficDebug")]
	public class AITrafficDebug : ScriptableObject
	{
		[Header("Waypoint Routes")]
		public bool alwaysDrawGizmos;

		public bool canUpdateGizmos;

		public bool alwaysSideSensorGizmos;

		public Color pathColor;

		public Color selectedPathColor;

		public Color junctionColor;

		public Color selectedJunctionColor;

		public float arrowHeadWidth;

		public float arrowHeadLength;

		public Vector3 arrowHeadScale;

		public float updateGizmoCoolDown;

		[Header("AI Cars")]
		public bool showCarGizmos;

		public Color detectColor;

		public Color normalColor;

		[Header("Job Controller")]
		public bool debugProcessTime;
	}
}
