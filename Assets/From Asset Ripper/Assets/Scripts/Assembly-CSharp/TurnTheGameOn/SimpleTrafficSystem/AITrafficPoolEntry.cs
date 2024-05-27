using System;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	[Serializable]
	public struct AITrafficPoolEntry
	{
		public string name;

		public int assignedIndex;

		public AITrafficCar trafficPrefab;
	}
}
