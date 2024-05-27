using System;
using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class PriceManager : Singleton<PriceManager>
{
	[SerializeField]
	private int m_MinDayToChangeBasePrice;

	[SerializeField]
	private int m_MaxDayToChangeBasePrice;

	[SerializeField]
	[Range(0f, 100f)]
	private float m_DailyChanceToChangeBasePrice;

	[SerializeField]
	private int m_MaxNumberOfProductsPerDayToChangeBasePrice;

	[SerializeField]
	private float m_NewPriceClampPercentage;

	private List<Pricing> m_CurrentCosts;

	private List<Pricing> m_PricesSetByPlayer;

	private List<Pricing> m_AveragePrices;

	private List<Pricing> m_DailyPriceChanges;

	private List<Pricing> m_PreviousPrices;

	public Action<int> onPriceSet;

	public Action<List<int>> onCostsChanged;

	public Action onDisabled;

	public bool HasPriceSetByPlayer(int productID)
	{
		return false;
	}

	public float SellingPrice(int productID)
	{
		return 0f;
	}

	public float AverageCost(int productID)
	{
		return 0f;
	}

	public float GetProfitRate(int productID)
	{
		return 0f;
	}

	public PricingState PricingState(int productID)
	{
		return default(PricingState);
	}

	public float PreviousCost(int productID)
	{
		return 0f;
	}

	public float CurrentCost(int productID)
	{
		return 0f;
	}

	public bool DidPriceIncreased(int productID)
	{
		return false;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public void PriceSet(Pricing pricing)
	{
	}

	public void UpdateAverageCost(int productID, int unitAmount, float costPerUnit)
	{
	}

	private void AddPricing(Pricing pricing)
	{
	}

	private Pricing GetPriceSetByPlayer(int productID)
	{
		return null;
	}

	private Pricing GetAverageCost(int productID)
	{
		return null;
	}

	private void TryChangingBasePrices()
	{
	}

	private void OnDayCycleDisabled()
	{
	}

	private void ChangeCurrentCost(int productID)
	{
	}

	private void LoadCurrentCosts()
	{
	}
}
