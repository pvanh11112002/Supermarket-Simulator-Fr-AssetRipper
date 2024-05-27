using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	[Serializable]
	public struct AITrafficCarOnReachWaypointInfo
	{
		public AITrafficWaypointRoute parentRoute;

		public AITrafficWaypoint waypoint;

		public int waypointIndexnumber;

		public float speedLimit;

		public bool stopDriving;

		public AITrafficWaypoint[] newRoutePoints;

		public List<AITrafficWaypoint> laneChangePoints;

		public UnityEvent OnReachWaypointEvent;

		[HideInInspector]
		public Vector3 position;
	}
}
