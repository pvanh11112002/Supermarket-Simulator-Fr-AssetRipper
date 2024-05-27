using System;
using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class ProductLicenseManager : Singleton<ProductLicenseManager>
{
	[SerializeField]
	private List<ProductLicenseSO> m_Licenses;

	[SerializeField]
	private List<ProductLicenseSO> m_DefaultUnlockedLicenses;

	private List<int> m_UnlockedLicenses;

	private List<int> m_UnlockedProducts;

	private List<int> m_AllProducts;

	private List<int> m_ProductsExpectedByLevel;

	public Action<int> onLicensePurchased;

	public Action onDisabled;

	public List<int> UnlockedProducts => null;

	public List<int> AllPoducts => null;

	public List<int> ProductsExpectedByLevel => null;

	public int UnlockedLicenseCount => 0;

	public List<ProductLicenseSO> Licenses => null;

	public bool IsLicenseUnlocked(int id)
	{
		return false;
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public void PurchaseLicense(int licenseID)
	{
	}

	private void UpdateUnlockedProducts()
	{
	}

	private void UpdateExpectedProducts(bool levelUp)
	{
	}

	private void UnsubscribeStoreLevelManager()
	{
	}

	private void LoadAllProducts()
	{
	}

	private void LoadProductsExpectedByLevel()
	{
	}
}
