using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[] { "mode", "gradientMax", "gradientMin", "colorMax", "colorMin", "color", "gradient" })]
	public class ES3Type_MinMaxGradient : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_MinMaxGradient()
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
	}
}
