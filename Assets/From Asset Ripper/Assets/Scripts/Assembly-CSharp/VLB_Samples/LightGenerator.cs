using UnityEngine;

namespace VLB_Samples
{
	public class LightGenerator : MonoBehaviour
	{
		[Range(1f, 100f)]
		[SerializeField]
		private int CountX;

		[SerializeField]
		[Range(1f, 100f)]
		private int CountY;

		[SerializeField]
		private float OffsetUnits;

		[SerializeField]
		private float PositionY;

		[SerializeField]
		private bool NoiseEnabled;

		[SerializeField]
		private bool AddLight;

		public void Generate()
		{
		}
	}
}
