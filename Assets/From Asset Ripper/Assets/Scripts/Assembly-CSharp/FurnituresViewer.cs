using System.Collections.Generic;
using UnityEngine;

public class FurnituresViewer : MonoBehaviour
{
	[Header("UI")]
	[SerializeField]
	private Transform m_ProductsContent;

	[SerializeField]
	private FurnitureSalesItem m_FurnitureSalesItemPrefab;

	[SerializeField]
	[Header("Components")]
	private MarketShoppingCart m_ShoppingCart;

	private List<FurnitureSalesItem> m_ShelvesSalesItems;

	public MarketShoppingCart ShoppingCart => null;

	private void Start()
	{
	}

	private void SpawnFurnitures()
	{
	}
}
