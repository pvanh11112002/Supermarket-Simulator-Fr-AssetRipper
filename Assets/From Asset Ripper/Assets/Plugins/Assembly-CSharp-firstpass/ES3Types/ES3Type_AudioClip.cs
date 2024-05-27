using UnityEngine.Scripting;

namespace ES3Types
{
	[ES3Properties(new string[] { "name", "samples", "channels", "frequency", "sampleData" })]
	[Preserve]
	public class ES3Type_AudioClip : ES3UnityObjectType
	{
		public static ES3Type Instance;

		public ES3Type_AudioClip()
			: base(null)
		{
		}

		protected override void WriteUnityObject(object obj, ES3Writer writer)
		{
		}

		protected override void ReadUnityObject<T>(ES3Reader reader, object obj)
		{
		}

		protected override object ReadUnityObject<T>(ES3Reader reader)
		{
			return null;
		}
	}
}
