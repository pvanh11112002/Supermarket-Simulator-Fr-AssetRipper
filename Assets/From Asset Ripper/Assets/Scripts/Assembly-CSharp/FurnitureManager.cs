using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class FurnitureManager : Singleton<FurnitureManager>
{
	public Transform TrashBin;

	private List<FurnitureData> m_FurnituresDatas;

	private Furniture[] m_DefaultFurnitures;

	private void Start()
	{
	}

	public void AddFurniture(FurnitureData furnitureData)
	{
	}

	public void RemoveFurniture(FurnitureData furnitureData)
	{
	}

	private void LoadFurnitureDatas()
	{
	}
}
