using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.Jobs;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	[BurstCompile]
	public struct AITrafficDistanceJob : IJobParallelForTransform
	{
		public float3 playerPosition;

		public NativeArray<float> distanceToPlayerArray;

		public float cullDistance;

		public float actizeZone;

		public float spawnZone;

		public NativeArray<bool> withinLimitArray;

		public NativeArray<bool> isVisibleArray;

		public NativeArray<bool> lightIsActiveArray;

		public NativeArray<bool> outOfBoundsArray;

		public NativeArray<bool> isDisabledArray;

		public void Execute(int index, TransformAccess carTransformAccessArray)
		{
		}
	}
}
