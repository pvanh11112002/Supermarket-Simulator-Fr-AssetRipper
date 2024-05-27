using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine.Jobs;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	[BurstCompile]
	public struct AITrafficCarWheelJob : IJobParallelForTransform
	{
		public NativeArray<float3> wheelPosition_CachedArray;

		public NativeArray<quaternion> wheelQuaternion_CachedArray;

		public void Execute(int index, TransformAccess carWheelTransformArray)
		{
		}
	}
}
