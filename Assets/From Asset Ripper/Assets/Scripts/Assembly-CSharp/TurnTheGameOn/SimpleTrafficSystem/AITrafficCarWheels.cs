using System;
using UnityEngine;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	[Serializable]
	public struct AITrafficCarWheels
	{
		public string name;

		public GameObject mesh;

		public Transform meshTransform;

		public WheelCollider collider;
	}
}
