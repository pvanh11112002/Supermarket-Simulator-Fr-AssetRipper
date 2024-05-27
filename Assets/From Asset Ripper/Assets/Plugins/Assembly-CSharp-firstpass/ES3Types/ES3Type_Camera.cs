using UnityEngine.Scripting;

namespace ES3Types
{
	[ES3Properties(new string[]
	{
		"fieldOfView", "nearClipPlane", "farClipPlane", "renderingPath", "allowHDR", "orthographicSize", "orthographic", "opaqueSortMode", "transparencySortMode", "depth",
		"aspect", "cullingMask", "eventMask", "backgroundColor", "rect", "pixelRect", "worldToCameraMatrix", "projectionMatrix", "nonJitteredProjectionMatrix", "useJitteredProjectionMatrixForTransparentRendering",
		"clearFlags", "stereoSeparation", "stereoConvergence", "cameraType", "stereoTargetEye", "targetDisplay", "useOcclusionCulling", "cullingMatrix", "layerCullSpherical", "depthTextureMode",
		"clearStencilAfterLightingPass", "enabled", "hideFlags"
	})]
	[Preserve]
	public class ES3Type_Camera : ES3ComponentType
	{
		public static ES3Type Instance;

		public ES3Type_Camera()
			: base(null)
		{
		}

		protected override void WriteComponent(object obj, ES3Writer writer)
		{
		}

		protected override void ReadComponent<T>(ES3Reader reader, object obj)
		{
		}
	}
}
