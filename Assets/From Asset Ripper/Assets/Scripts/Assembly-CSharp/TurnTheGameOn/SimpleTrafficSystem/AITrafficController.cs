using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Jobs;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	public class AITrafficController : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CInitialize_003Ed__156 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AITrafficController _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CInitialize_003Ed__156(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSpawnStartupTraffic_003Ed__182 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AITrafficController _003C_003E4__this;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSpawnStartupTraffic_003Ed__182(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public static AITrafficController Instance;

		public AITrafficDebug m_AITrafficDebug;

		[Header("Pooling")]
		public AITrafficPool _AITrafficPool;

		public Transform centerPoint;

		public bool usePooling;

		public bool useRouteLimit;

		private bool isInitialized;

		[Header("Detection Sensor")]
		public LayerMask layerMask;

		public Vector3 frontSensorSize;

		public float frontSensorLength;

		public Vector3 sideSensorSize;

		public float sideSensorLength;

		[Header("Car Settings")]
		public float speedMultiplier;

		public float accelerationPower;

		public float steerSensitivity;

		public float maxSteerAngle;

		public float stopThreshold;

		public float minDrag;

		public float minAngularDrag;

		[Header("Lane Changing")]
		public bool enableLaneChanging;

		public float changeLaneTrigger;

		public float minSpeedToChangeLanes;

		public float changeLaneCooldown;

		private List<float> changeLaneCooldownTimer;

		public List<AITrafficWaypointRoute> allWaypointRoutesList;

		private List<AITrafficWaypoint> currentWaypointList;

		private List<WheelCollider> frontRightWheelColliderList;

		private List<WheelCollider> frontLefttWheelColliderList;

		private List<WheelCollider> backRighttWheelColliderList;

		private List<WheelCollider> backLeftWheelColliderList;

		private List<Rigidbody> rigidbodyList;

		private List<Vector3> frontOriginList;

		private List<Vector3> frontDirectionList;

		private List<Quaternion> frontRotationList;

		private List<Transform> frontTransformCached;

		private List<Transform> frontHitTransform;

		private List<Transform> frontPreviousHitTransform;

		private List<Vector3> leftOriginList;

		private List<Vector3> leftDirectionList;

		private List<Quaternion> leftRotationList;

		private List<Transform> leftTransformCached;

		private List<Transform> leftHitTransform;

		private List<Transform> leftPreviousHitTransform;

		private List<Vector3> rightOriginList;

		private List<Vector3> rightDirectionList;

		private List<Quaternion> rightRotationList;

		private List<Transform> rightTransformCached;

		private List<Transform> rightHitTransform;

		private List<Transform> rightPreviousHitTransform;

		private List<AITrafficWaypointRouteInfo> carAIWaypointRouteInfo;

		private List<Material> brakeMaterial;

		private List<Light> headLight;

		private List<AITrafficSpawnPoint> trafficSpawnPoints;

		private List<AITrafficSpawnPoint> availableSpawnPoints;

		private List<AITrafficPoolEntry> trafficPool;

		public NativeArray<bool> isChangingLanes;

		public NativeArray<bool> canChangeLanes;

		public NativeArray<bool> frontHit;

		public NativeArray<bool> leftHit;

		public NativeArray<bool> rightHit;

		public NativeArray<bool> stopForTrafficLight;

		public NativeArray<bool> routeIsActive;

		public NativeArray<float> frontHitDistance;

		public NativeArray<float> leftHitDistance;

		public NativeArray<float> rightHitDistance;

		public NativeArray<float> topSpeedArray;

		public NativeArray<Vector3> carTransformPositionArray;

		public TransformAccessArray driveTargetTransformAccessArray;

		private NativeArray<int> currentRoutePointIndexArray;

		private NativeArray<int> waypointDataListCountArray;

		private NativeArray<bool> isActiveArray;

		private NativeArray<bool> isDrivingArray;

		private NativeArray<bool> overrideDragArray;

		private NativeArray<bool> overrideInputArray;

		private NativeArray<bool> isBrakingArray;

		private NativeArray<float> speedArray;

		private NativeArray<float> routeProgressArray;

		private NativeArray<float> targetSpeedArray;

		private NativeArray<float> accelArray;

		private NativeArray<float> speedLimitArray;

		private NativeArray<float> targetAngleArray;

		private NativeArray<float> dragArray;

		private NativeArray<float> angularDragArray;

		private NativeArray<float> moveSteerArray;

		private NativeArray<float> moveAccelArray;

		private NativeArray<float> moveFootBrakeArray;

		private NativeArray<float> movehandBrakeArray;

		private NativeArray<float> overrideAccelerationPowerArray;

		private NativeArray<float> overrideBrakePowerArray;

		private NativeArray<float3> routePointPositionArray;

		private NativeArray<float3> FRwheelPosition_CachedArray;

		private NativeArray<float3> FLwheelPosition_CachedArray;

		private NativeArray<float3> BRwheelPosition_CachedArray;

		private NativeArray<float3> BLwheelPosition_CachedArray;

		private NativeArray<Vector3> carTransformPreviousPositionArray;

		private NativeArray<Vector3> localTargetArray;

		private NativeArray<quaternion> FRwheelQuaternion_CachedArray;

		private NativeArray<quaternion> FLwheelQuaternion_CachedArray;

		private NativeArray<quaternion> BRwheelQuaternion_CachedArray;

		private NativeArray<quaternion> BLwheelQuaternion_CachedArray;

		public NativeArray<bool> isDisabledArray;

		private NativeArray<float> distanceToPlayerArray;

		private NativeArray<bool> withinLimitArray;

		private NativeArray<bool> isEnabledArray;

		private NativeArray<bool> outOfBoundsArray;

		private NativeArray<bool> lightIsActiveArray;

		private NativeArray<bool> isVisibleArray;

		private TransformAccessArray carTransformAccessArray;

		private TransformAccessArray frontRightWheelTransformList;

		private TransformAccessArray frontLeftWheelTransformList;

		private TransformAccessArray backRightWheelTransformList;

		private TransformAccessArray backLeftWheelTransformList;

		private JobHandle jobHandle;

		private AITrafficCarJob carAITrafficJob;

		private AITrafficCarWheelJob frAITrafficCarWheelJob;

		private AITrafficCarWheelJob flAITrafficCarWheelJob;

		private AITrafficCarWheelJob brAITrafficCarWheelJob;

		private AITrafficCarWheelJob blAITrafficCarWheelJob;

		private AITrafficCarPositionJob carTransformpositionJob;

		private AITrafficDistanceJob _AITrafficDistanceJob;

		private float spawnTimer;

		private float distanceToSpawnPoint;

		private float startTime;

		private float deltaTime;

		private int carCount;

		private int currentAmountToSpawn;

		private int randomSpawnPointIndex;

		private int currentDensity;

		private WheelCollider currentWheelCollider;

		private AITrafficCar spawncar;

		private AITrafficCar loadCar;

		private Vector3 wheelPosition_Cached;

		private Quaternion wheelQuaternion_Cached;

		private RaycastHit boxHit;

		private AITrafficWaypoint nextWaypoint;

		private List<float> changeLaneTriggerTimer;

		private bool canTurnLeft;

		private bool canTurnRight;

		private Vector3 relativePoint;

		private AITrafficPoolEntry newTrafficPoolEntry;

		private bool spawnPointsAreHidden;

		public List<AITrafficCar> carAIList { get; private set; }

		public List<AITrafficWaypointRoute> waypointRouteList { get; private set; }

		public float3 centerPosition { get; private set; }

		private int PossibleTargetDirection(Transform _from, Transform _to)
		{
			return 0;
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CInitialize_003Ed__156))]
		private IEnumerator Initialize()
		{
			return null;
		}

		private void FixedUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		private void DisposeArrays()
		{
		}

		public void Set_IsDrivingArray(int _index, bool _value)
		{
		}

		public void Set_RouteInfo(int _index, AITrafficWaypointRouteInfo routeInfo)
		{
		}

		public void Set_CurrentRoutePointIndexArray(int _index, int _value, AITrafficWaypoint _nextWaypoint)
		{
		}

		public void Set_RouteProgressArray(int _index, float _value)
		{
		}

		public void Set_SpeedLimitArray(int _index, float _value)
		{
		}

		public void Set_WaypointDataListCountArray(int _index)
		{
		}

		public void Set_RoutePointPositionArray(int _index)
		{
		}

		public void SetVisibleState(int _index, bool _isVisible)
		{
		}

		public void Set_WaypointRoute(int _index, AITrafficWaypointRoute _route)
		{
		}

		public float GetAccelerationInput(int _index)
		{
			return 0f;
		}

		public float GetSteeringInput(int _index)
		{
			return 0f;
		}

		public float GetCurrentSpeed(int _index)
		{
			return 0f;
		}

		public bool GetIsBraking(int _index)
		{
			return false;
		}

		public int RegisterCarAI(AITrafficCar carAI, AITrafficWaypointRoute route)
		{
			return 0;
		}

		public int RegisterSpawnPoint(AITrafficSpawnPoint _TrafficSpawnPoint)
		{
			return 0;
		}

		private void OnDrawGizmos()
		{
		}

		private void DrawCube(Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		public AITrafficCar GetCarFromPool(AITrafficWaypointRoute parentRoute)
		{
			return null;
		}

		public void EnableCar(int _index, AITrafficWaypointRoute parentRoute)
		{
		}

		public void MoveCarToPool(int _index)
		{
		}

		public void MoveAllCarsToPool()
		{
		}

		private void SpawnTraffic()
		{
		}

		[IteratorStateMachine(typeof(_003CSpawnStartupTraffic_003Ed__182))]
		private IEnumerator SpawnStartupTraffic()
		{
			return null;
		}
	}
}
