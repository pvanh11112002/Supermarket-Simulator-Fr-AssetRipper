using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[]
	{
		"type", "color", "intensity", "bounceIntensity", "shadows", "shadowStrength", "shadowResolution", "shadowCustomResolution", "shadowBias", "shadowNormalBias",
		"shadowNearPlane", "range", "spotAngle", "cookieSize", "cookie", "flare", "renderMode", "cullingMask", "areaSize", "lightmappingMode",
		"enabled", "hideFlags"
	})]
	public class ES3Type_Light : ES3ComponentType
	{
		public static ES3Type Instance;

		public ES3Type_Light()
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
