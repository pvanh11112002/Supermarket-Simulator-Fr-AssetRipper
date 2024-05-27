using UnityEngine;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	[RequireComponent(typeof(AITrafficCar))]
	public class BrakeLight : MonoBehaviour
	{
		public Light[] brakeLights;

		private AITrafficCar car;

		private bool isBraking;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
