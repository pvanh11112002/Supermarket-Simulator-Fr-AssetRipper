using UnityEngine.Scripting;

namespace ES3Types
{
	[ES3Properties(new string[]
	{
		"sprite", "color", "flipX", "flipY", "enabled", "shadowCastingMode", "receiveShadows", "sharedMaterials", "lightmapIndex", "realtimeLightmapIndex",
		"lightmapScaleOffset", "motionVectorGenerationMode", "realtimeLightmapScaleOffset", "lightProbeUsage", "lightProbeProxyVolumeOverride", "probeAnchor", "reflectionProbeUsage", "sortingLayerName", "sortingLayerID", "sortingOrder"
	})]
	[Preserve]
	public class ES3Type_SpriteRenderer : ES3ComponentType
	{
		public static ES3Type Instance;

		public ES3Type_SpriteRenderer()
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
