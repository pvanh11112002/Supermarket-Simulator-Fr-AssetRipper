using System;

[Serializable]
public class FurnitureBoxData
{
	public BoxSize Size;

	public TransformData Transform;

	public int FurnitureID;

	public FurnitureSO Furniture => null;
}
