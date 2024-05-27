using UnityEngine.Scripting;

namespace ES3Types
{
	[ES3Properties(new string[] { "shader", "renderQueue", "shaderKeywords", "globalIlluminationFlags", "properties" })]
	[Preserve]
	public class ES3Type_Material : ES3UnityObjectType
	{
		public static ES3Type Instance;

		public ES3Type_Material()
			: base(null)
		{
		}

		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}

		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}
	}
}
