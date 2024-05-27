using System;
using MyBox;
using UnityEngine;
using UnityEngine.Localization;

[Serializable]
[CreateAssetMenu(fileName = "New Product", menuName = "Scriptable Objects/Product/Product")]
public class ProductSO : ScriptableObject
{
	[Serializable]
	public enum ProductCategory
	{
		EDIBLE = 0,
		DRINK = 1,
		CLEANING = 2,
		BOOK = 3
	}

	public int ID;

	[Separator("Product Info", false)]
	public string ProductName;

	public LocalizedString LocalizedName;

	public string ProductBrand;

	public Sprite ProductIcon;

	public DisplayType ProductDisplayType;

	public ProductCategory Category;

	public Product ProductPrefab;

	[Separator("Purchase Info", false)]
	public int ProductAmountOnPurchase;

	public float BasePrice;

	public float MinDynamicPrice;

	public float MaxDynamicPrice;

	[Separator("Pricing Settings", false)]
	public float OptimumProfitRate;

	public float MaxProfitRate;

	[Separator("3D Grid Layout", false)]
	public GridLayout3D.GridLayout GridLayoutInBox;

	public GridLayout3D.GridLayout GridLayoutInStorage;

	[Separator("Grid Size On Checkout", false)]
	public Vector2Int ItemGridSize;

	[Separator("Product Name Displaying Settings", false)]
	public Color ProductNameColor;

	public float ProductNameSizeRatio;

	public string TempProductName => null;

	public string ComplexName(float fontSize)
	{
		return null;
	}
}
