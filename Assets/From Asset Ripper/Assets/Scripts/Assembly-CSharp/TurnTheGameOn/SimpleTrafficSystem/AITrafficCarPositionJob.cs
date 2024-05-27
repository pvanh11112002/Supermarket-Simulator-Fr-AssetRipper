using Unity.Burst;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Jobs;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	[BurstCompile]
	public struct AITrafficCarPositionJob : IJobParallelForTransform
	{
		public NativeArray<Vector3> carTransformPositionArray;

		public NativeArray<Vector3> carTransformPreviousPositionArray;

		public void Execute(int index, TransformAccess carTransformAccessArray)
		{
		}
	}
}
