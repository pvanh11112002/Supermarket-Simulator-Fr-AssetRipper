using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	public class ES3Type_ES3Ref : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_ES3Ref()
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
