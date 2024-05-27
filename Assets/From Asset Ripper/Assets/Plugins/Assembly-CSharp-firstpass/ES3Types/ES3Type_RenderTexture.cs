using UnityEngine.Scripting;

namespace ES3Types
{
	[ES3Properties(new string[]
	{
		"width", "height", "dimension", "graphicsFormat", "useMipMap", "vrUsage", "memorylessMode", "format", "stencilFormat", "autoGenerateMips",
		"volumeDepth", "antiAliasing", "bindTextureMS", "enableRandomWrite", "useDynamicScale", "isPowerOfTwo", "depth", "descriptor", "masterTextureLimit", "anisotropicFiltering",
		"wrapMode", "wrapModeU", "wrapModeV", "wrapModeW", "filterMode", "anisoLevel", "mipMapBias", "imageContentsHash", "streamingTextureForceLoadAll", "streamingTextureDiscardUnusedMips",
		"allowThreadedTextureCreation", "name"
	})]
	[Preserve]
	public class ES3Type_RenderTexture : ES3ObjectType
	{
		public static ES3Type Instance;

		public ES3Type_RenderTexture()
			: base(null)
		{
		}

		protected override void WriteObject(object obj, ES3Writer writer)
		{
		}

		protected override void ReadObject<T>(ES3Reader reader, object obj)
		{
		}

		protected override object ReadObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
}
