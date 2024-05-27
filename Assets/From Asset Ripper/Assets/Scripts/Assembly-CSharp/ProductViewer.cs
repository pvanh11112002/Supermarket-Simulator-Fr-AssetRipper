using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ProductViewer : MonoBehaviour
{
	public enum FilterType
	{
		NAME = 0,
		STORAGE_TYPE = 1,
		PRODUCT_TYPE = 2
	}

	private class FilteredItem
	{
		public SalesItem Product;

		public bool FilteredByName;

		public bool FilteredByStorageType;

		public bool FilteredByProductType;

		public bool Filtered => false;
	}

	[Header("UI")]
	[SerializeField]
	private Transform m_ProductsContent;

	[SerializeField]
	private SalesItem m_SalesItemPrefab;

	[Header("Filtering")]
	[SerializeField]
	private TMP_InputField m_SearchBar;

	[SerializeField]
	private TMP_Dropdown m_StorageTypeDropdown;

	[SerializeField]
	private TMP_Dropdown m_ProductTypeDropdown;

	[SerializeField]
	private GameObject m_NoProductIndicator;

	[SerializeField]
	[Header("Components")]
	private MarketShoppingCart m_ShoppingCart;

	private List<SalesItem> m_SalesItems;

	private int m_CurrentStorageTypeFilter;

	private int m_CurrentProductTypeFilter;

	private List<FilteredItem> m_FilteredProducts;

	public MarketShoppingCart ShoppingCart => null;

	private void Start()
	{
	}

	private void Search(string text)
	{
	}

	private void FilterByStorageType(int index)
	{
	}

	private void FilterByProductType(int index)
	{
	}

	private FilteredItem IsFiltered(SalesItem salesItem)
	{
		return null;
	}

	private void AddFilter(SalesItem salesItem, FilterType filterType)
	{
	}

	private void RemoveFilter(SalesItem salesItem, FilterType filterType)
	{
	}

	private void SpawnUnlockedProducts()
	{
	}

	private void UpdateUnlockedProducts(int licenseID)
	{
	}
}
