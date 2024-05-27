using System.Collections.Generic;
using UnityEngine;

namespace EPOOutline
{
	[ExecuteAlways]
	public class TargetsHolder : MonoBehaviour
	{
		private static TargetsHolder instance;

		private Dictionary<string, RenderTexture> targets;

		public static TargetsHolder Instance => null;

		private void OnDestroy()
		{
		}

		public RenderTexture GetAllocatedTarget(string name)
		{
			return null;
		}

		public RenderTexture GetTarget(OutlineParameters parameters, string name)
		{
			return null;
		}

		private void ReleaseTargets()
		{
		}

		private void Update()
		{
		}
	}
}
