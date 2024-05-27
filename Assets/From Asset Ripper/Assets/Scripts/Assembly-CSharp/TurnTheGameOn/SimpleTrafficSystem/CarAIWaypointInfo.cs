using System;
using UnityEngine;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	[Serializable]
	public struct CarAIWaypointInfo
	{
		public string _name;

		public Transform _transform;

		public AITrafficWaypoint _waypoint;
	}
}
