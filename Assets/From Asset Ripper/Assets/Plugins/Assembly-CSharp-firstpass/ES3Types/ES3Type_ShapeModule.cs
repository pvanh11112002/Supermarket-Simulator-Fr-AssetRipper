using UnityEngine.Scripting;

namespace ES3Types
{
	[Preserve]
	[ES3Properties(new string[]
	{
		"enabled", "shapeType", "randomDirectionAmount", "sphericalDirectionAmount", "alignToDirection", "radius", "angle", "length", "box", "meshShapeType",
		"mesh", "meshRenderer", "skinnedMeshRenderer", "useMeshMaterialIndex", "meshMaterialIndex", "useMeshColors", "normalOffset", "meshScale", "arc"
	})]
	public class ES3Type_ShapeModule : ES3Type
	{
		public static ES3Type Instance;

		public ES3Type_ShapeModule()
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
