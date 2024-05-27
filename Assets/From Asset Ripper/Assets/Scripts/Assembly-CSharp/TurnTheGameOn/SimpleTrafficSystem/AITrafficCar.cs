using UnityEngine;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	public class AITrafficCar : MonoBehaviour
	{
		public float topSpeed;

		public Transform frontSensorTransform;

		public Transform leftSensorTransform;

		public Transform rightSensorTransform;

		public AITrafficCarWheels[] _wheels;

		public Material brakeMaterial;

		public Light headLight;

		public bool goToStartOnStop;

		private AITrafficWaypointRoute startRoute;

		private Vector3 goToPointWhenStoppedVector3;

		private Rigidbody rb;

		public int assignedIndex { get; private set; }

		public void RegisterCar(AITrafficWaypointRoute route)
		{
		}

		public float AccelerationInput()
		{
			return 0f;
		}

		public float SteeringInput()
		{
			return 0f;
		}

		public float CurrentSpeed()
		{
			return 0f;
		}

		public bool IsBraking()
		{
			return false;
		}

		[ContextMenu("StartDriving")]
		public void StartDriving()
		{
		}

		[ContextMenu("StopDriving")]
		public void StopDriving()
		{
		}

		[ContextMenu("MoveCarToPool")]
		public void MoveCarToPool()
		{
		}

		public void OnReachedWaypoint(AITrafficCarOnReachWaypointInfo onReachWaypointSettings)
		{
		}

		public void ChangeToRouteWaypoint(AITrafficCarOnReachWaypointInfo onReachWaypointSettings)
		{
		}

		private void OnBecameInvisible()
		{
		}

		private void OnBecameVisible()
		{
		}
	}
}
