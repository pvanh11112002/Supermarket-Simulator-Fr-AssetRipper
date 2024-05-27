using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[] { "enabled", "rateOverTime", "rateOverTimeMultiplier", "rateOverDistance", "rateOverDistanceMultiplier" })]
	public class ES3Type_EmissionModule : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_EmissionModule()
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
