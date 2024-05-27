using System;
using System.Collections.Generic;
using UnityEngine;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	[ExecuteInEditMode]
	public class AITrafficWaypointRouteCreator : MonoBehaviour
	{
		public enum Routes
		{
			One = 1,
			Two = 2,
			Three = 3,
			Four = 4,
			Five = 5,
			Six = 6,
			Seven = 7,
			Eight = 8,
			Nine = 9,
			Ten = 10
		}

		[Serializable]
		public class RouteSettings
		{
			public AITrafficWaypointRoute route;

			public Vector3 offset;
		}

		public Transform startControlPoint;

		public Transform endControlPoint;

		public List<Transform> controlPointsList;

		public Routes routes;

		public List<RouteSettings> routeSettings;

		public int spawnedPoints;

		public bool loopSpline;

		[Range(0.001f, 1f)]
		public float waypointFrequency;

		public bool requiresUpdate;

		public List<Vector3> previousOffset;

		public List<Vector3> defaultOffset;

		public bool isInitialized;

		private void Start()
		{
		}

		public void Initialize()
		{
		}

		public void AddWaypoint(Vector3 _position)
		{
		}

		public void InsertWaypoint(Vector3 position)
		{
		}

		private bool IsCBetweenAB(Vector3 A, Vector3 B, Vector3 C)
		{
			return false;
		}

		public void Refresh()
		{
		}

		private void UpdateRoutesEditorOnly()
		{
		}

		private void UpdateWaypoints()
		{
		}

		public static Vector3 GetPointOnSpline(float percentage, Vector3[] cPoints, Vector3 offset, Transform waypoint, Transform originalParent)
		{
			return default(Vector3);
		}

		public static Vector3 GetControlPointOnSpline(float percentage, Vector3[] cPoints)
		{
			return default(Vector3);
		}

		public static Vector3 GetPointOnSplineToLookAt(float percentage, Vector3[] cPoints)
		{
			return default(Vector3);
		}
	}
}
