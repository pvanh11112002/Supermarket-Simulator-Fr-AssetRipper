using System;

[Serializable]
public class BoxData
{
	public BoxSize Size;

	public TransformData Transform;

	public bool IsOpen;

	public int ProductID;

	public int ProductCount;

	public ProductSO Product => null;
}
