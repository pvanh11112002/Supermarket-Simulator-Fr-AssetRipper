using System;
using System.Collections.Generic;
using UnityEngine;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	[Serializable]
	[RequireComponent(typeof(AITrafficWaypointRouteInfo))]
	public class AITrafficWaypointRoute : MonoBehaviour
	{
		public AITrafficDebug m_AITrafficGizmoSettings;

		public List<CarAIWaypointInfo> waypointDataList;

		public bool useSpawnPoints;

		public GameObject[] spawnTrafficVehicles;

		public AITrafficWaypointRouteInfo routeInfo;

		public int maxDensity;

		public int currentDensity;

		public int previousDensity;

		public List<AITrafficSpawnPoint> spawnpoints;

		[HideInInspector]
		private Transform arrowPointer;

		private Transform junctionPosition;

		private Matrix4x4 previousMatrix;

		private int lookAtIndex;

		private float updateGizmoTimer;

		public bool stopForTrafficLight { get; private set; }

		[ContextMenu("SetMaxToChildSpawnPointCount")]
		public void SetMaxToChildSpawnPointCount()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void StopForTrafficlight(bool _stop)
		{
		}

		public void SpawnTrafficVehicles()
		{
		}

		private bool IsCBetweenAB(Vector3 A, Vector3 B, Vector3 C)
		{
			return false;
		}

		public Transform ClickToSpawnNextWaypoint(Vector3 _position)
		{
			return null;
		}

		public void ClickToInsertSpawnNextWaypoint(Vector3 _position)
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void DrawGizmos(bool selected)
		{
		}

		[ContextMenu("ReversePoints")]
		public void ReversePoints()
		{
		}

		[ContextMenu("AlignPoints")]
		public void AlignPoints()
		{
		}

		[ContextMenu("RefreshPointIndexes")]
		public void RefreshPointIndexes()
		{
		}

		[ContextMenu("ClearAllLaneChangePoints")]
		public void ClearAllLaneChangePoints()
		{
		}

		[ContextMenu("ClearAllNewRoutePoints")]
		public void ClearAllNewRoutePoints()
		{
		}

		public void RemoveAllSpawnPoints()
		{
		}

		public void SetupRandomSpawnPoints()
		{
		}
	}
}
