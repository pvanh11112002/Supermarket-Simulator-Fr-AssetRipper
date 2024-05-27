using UnityEngine;

namespace XFrameEffect
{
	[ExecuteInEditMode]
	[AddComponentMenu(null)]
	[RequireComponent(typeof(Camera))]
	public class PostFrameCompositor : MonoBehaviour
	{
		[HideInInspector]
		public XFrameManager xFrameManager;

		private Material bMatDefault;

		private Material bMatSharp;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPostRender()
		{
		}
	}
}
