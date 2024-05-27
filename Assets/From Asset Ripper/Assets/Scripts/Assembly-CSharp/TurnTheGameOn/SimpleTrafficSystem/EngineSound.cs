using UnityEngine;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	[RequireComponent(typeof(AudioSource))]
	public class EngineSound : MonoBehaviour
	{
		private AudioSource _audioSource;

		private AITrafficCar _AITrafficCar;

		private float topSpeed;

		private float currentSpeed;

		public float idlePitch;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
