using UnityEngine.Scripting;

namespace ES3Types
{
	[ES3Properties(new string[] { "enabled", "x", "xMultiplier", "y", "yMultiplier", "z", "zMultiplier", "separateAxes", "range" })]
	[Preserve]
	public class ES3Type_RotationBySpeedModule : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_RotationBySpeedModule()
			: base(null)
		{
		}

		public override void Write(object obj, ES3Writer writer)
		{
		}

		public override object Read<T>(ES3Reader reader)
		{
			return null;
		}

		public override void ReadInto<T>(ES3Reader reader, object obj)
		{
		}
	}
}
