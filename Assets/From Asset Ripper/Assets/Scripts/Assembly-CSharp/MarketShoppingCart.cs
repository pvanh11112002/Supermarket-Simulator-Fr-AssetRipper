using System;
using System.Collections.Generic;
using MyBox;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MarketShoppingCart : MonoBehaviour
{
	[Serializable]
	public class CartData
	{
		public List<ItemQuantity> ProductInCarts;

		public List<ItemQuantity> FurnituresInCarts;
	}

	[Serializable]
	public class ShippingCost
	{
		public Vector2Int ItemCount;

		public float ShippingPrice;
	}

	[Separator("Components", false)]
	[SerializeField]
	private CartItem m_CartItemPrefab;

	[SerializeField]
	private Transform m_ContentParent;

	[SerializeField]
	[Separator("Shipping", false)]
	private List<ShippingCost> m_ShippingCosts;

	[SerializeField]
	private int m_MaxItemCount;

	[Separator("UI", false)]
	[SerializeField]
	private GameObject m_CartWindow;

	[SerializeField]
	private TMP_Text[] m_OrderTotalTexts;

	[SerializeField]
	private TMP_Text CurrentShippingCostText;

	[SerializeField]
	private TMP_Text[] m_TotalPriceTexts;

	[SerializeField]
	private TMP_Text m_BalanceText;

	[SerializeField]
	private TMP_Text m_RemainingMoneyText;

	[SerializeField]
	private TMP_Text m_CartItemCountText;

	[SerializeField]
	private Button m_PurchaseButton;

	[SerializeField]
	private GameObject m_CartMaxedIndicator;

	[SerializeField]
	private GameObject m_ClosedMarketText;

	[Separator("Total Price Colors", false)]
	[SerializeField]
	private Color m_EnoughMoneyTextColor;

	[SerializeField]
	private Color m_NotEnoughMoneyTextColor;

	[SerializeField]
	[Separator("Store Point", false)]
	private int m_StorePointPerEachItemPurchased;

	[Separator("Latest Time For Customer Spawn", false)]
	[SerializeField]
	private int m_LatestTimeForOrdering;

	[SerializeField]
	private bool m_AM;

	private List<CartItem> m_CartItems;

	private CartData m_CartData;

	private float m_OrderTotalPrice;

	private bool m_MarketClosed;

	public bool EnableCartWindow
	{
		set
		{
		}
	}

	public float CurrentShippingCost => 0f;

	public int ExcessItemsCount => 0;

	private int ItemCountInCart => 0;

	private bool TooLateToOrderGoods => false;

	private bool CloseMarket
	{
		set
		{
		}
	}

	public bool CartMaxed(bool willBeAddedMore = false)
	{
		return false;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Initialize()
	{
	}

	public bool TryAddProduct(ItemQuantity salesItem, SalesType salesType)
	{
		return false;
	}

	public void UpdateTotalPrice()
	{
	}

	public void RemoveProduct(ItemQuantity productData, SalesType salesType)
	{
	}

	public void Purchase()
	{
	}

	private void AddProduct(ItemQuantity salesItem, SalesType salesType)
	{
	}

	private void CleanCart()
	{
	}

	private void UpdateUI(bool hasMoney)
	{
	}

	private void UpdateBalance(float _amount, MoneyManager.TransitionType _type)
	{
	}

	private void UpdateAverageCosts()
	{
	}

	private void TimeCheck()
	{
	}

	private void OnDayCycleDisabled()
	{
	}

	private void OnCostsChanged(List<int> _)
	{
	}
}
