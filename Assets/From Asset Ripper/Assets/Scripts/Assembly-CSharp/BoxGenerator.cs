using MyBox;
using UnityEngine;

public class BoxGenerator : Singleton<BoxGenerator>
{
	[SerializeField]
	private FurnitureBox[] m_ShelfBoxPrefabs;

	public Box SpawnBox(ProductSO product, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	public FurnitureBox SpawnBox(FurnitureSO shelf, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	public Box SpawnBox(ProductSO product, Vector3 position, Quaternion rotation, Transform parent)
	{
		return null;
	}

	public FurnitureBox SpawnBox(FurnitureSO shelf, Vector3 position, Quaternion rotation, Transform parent)
	{
		return null;
	}

	public Box SpawnBox(Vector3 position, Quaternion rotation, BoxData data)
	{
		return null;
	}

	public Box SpawnBox(Vector3 position, Quaternion rotation, BoxData data, Transform parent)
	{
		return null;
	}

	public FurnitureBox SpawnBox(Vector3 position, Quaternion rotation, FurnitureBoxData data)
	{
		return null;
	}

	private Box GetBoxBySize(BoxSize boxSize)
	{
		return null;
	}

	private FurnitureBox GetShelfBoxBySize(BoxSize boxSize)
	{
		return null;
	}
}
