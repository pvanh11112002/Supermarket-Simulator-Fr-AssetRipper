using UnityEngine;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	[CreateAssetMenu(fileName = "AITrafficPool", menuName = "SimpleTrafficSystem/AITrafficPool")]
	public class AITrafficPool : ScriptableObject
	{
		public GameObject[] trafficPrefabs;

		public int density;

		public float spawnRate;

		[Header("Zones")]
		public float minSpawnZone;

		public float cullHeadLight;

		public float actizeZone;

		public float spawnZone;

		[Header("Debug")]
		public bool hideSpawnPointsInEditMode;

		public bool showGizmos;

		public Color minSpawnZoneColor;

		public Color cullHeadLightZone;

		public Color activeZoneColor;

		public Color spawnZoneColor;

		public bool debugProcessTime;
	}
}
