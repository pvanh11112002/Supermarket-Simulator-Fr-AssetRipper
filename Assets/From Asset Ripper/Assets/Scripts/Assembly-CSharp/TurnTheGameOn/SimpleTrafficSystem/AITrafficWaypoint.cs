using System.Collections.Generic;
using UnityEngine;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	public class AITrafficWaypoint : MonoBehaviour
	{
		public AITrafficCarOnReachWaypointInfo onReachWaypointSettings;

		private Collider m_collider;

		private List<AITrafficWaypoint> newWaypointList;

		private void OnEnable()
		{
		}

		private void OnTriggerEnter(Collider col)
		{
		}

		public void TriggerNextWaypoint(AITrafficCar _AITrafficCar)
		{
		}

		private void OnDrawGizmos()
		{
		}

		public void RemoveMissingLaneChangePoints()
		{
		}

		public void RemoveMissingNewRoutePoints()
		{
		}
	}
}
