using Unity.Burst;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	[BurstCompile]
	public struct AITrafficCarJob : IJobParallelForTransform
	{
		public NativeArray<int> currentRoutePointIndexArray;

		public NativeArray<int> waypointDataListCountArray;

		public NativeArray<bool> isDrivingArray;

		public NativeArray<bool> isActiveArray;

		public NativeArray<bool> overrideInputArray;

		public NativeArray<bool> isBrakingArray;

		public NativeArray<bool> frontHit;

		public NativeArray<bool> leftHit;

		public NativeArray<bool> rightHit;

		public NativeArray<bool> stopForTrafficLight;

		public NativeArray<bool> routeIsActive;

		public NativeArray<float> speedArray;

		public NativeArray<float> routeProgressArray;

		public NativeArray<float> targetSpeedArray;

		public NativeArray<float> speedLimitArray;

		public NativeArray<float> accelArray;

		public NativeArray<float> targetAngleArray;

		public NativeArray<float> moveSteerArray;

		public NativeArray<float> moveAccelArray;

		public NativeArray<float> moveFootBrakeArray;

		public NativeArray<float> movehandBrakeArray;

		public NativeArray<float> overrideAccelerationPowerArray;

		public NativeArray<float> overrideBrakePowerArray;

		public NativeArray<float> frontHitDistance;

		public NativeArray<float> leftHitDistance;

		public NativeArray<float> rightHitDistance;

		public NativeArray<float3> routePointPositionArray;

		public NativeArray<Vector3> carTransformPreviousPositionArray;

		public NativeArray<Vector3> carTransformPositionArray;

		public NativeArray<Vector3> localTargetArray;

		public NativeArray<float> topSpeedArray;

		public float deltaTime;

		public float maxSteerAngle;

		public float accelerationPower;

		public float speedMultiplier;

		public float steerSensitivity;

		public float stopThreshold;

		public float frontSensorLength;

		public void Execute(int index, TransformAccess driveTargetTransformAccessArray)
		{
		}
	}
}
