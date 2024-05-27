using System;
using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class SaveManager : Singleton<SaveManager>
{
	[Serializable]
	public class ProgressionContainer
	{
		public List<int> UnlockedLicenses;

		public List<LoanData> LoanDatas;

		public float Money;

		public MarketShoppingCart.CartData CartData;

		public List<BoxData> BoxDatas;

		public List<FurnitureBoxData> FurnitureBoxDatas;

		public Dictionary<int, int> DisplayedProductData;

		public List<DisplayData> DisplayDatas;

		public List<RackData> RackDatas;

		public List<CheckoutData> CheckoutDatas;

		public DailyStatisticsData DailyStatisticsData;

		public List<FurnitureData> FurnitureDatas;

		public TransformData ComputerTransform;

		public float CurrentTime;

		public int CurrentDay;

		public int LastDayPricesChanged;

		public bool MysteryBox;

		public int CompletedCheckoutCount;

		public int CurrentStorePoint;

		public int CurrentStoreLevel;

		public int StoreUpgradeLevel;

		public bool IsStoreOpen;
	}

	[Serializable]
	public class PriceContainer
	{
		public List<Pricing> Prices;

		public List<Pricing> PricesSetByPlayer;

		public List<Pricing> AverageCosts;

		public List<Pricing> DailyPriceChanges;

		public List<Pricing> PreviousPrices;
	}

	[Serializable]
	public class SettingsContainer
	{
		public int QualitySetting;

		public int ResolutionSetting;

		public int LanguageSetting;

		public bool FullScreen;

		public float GameSound;

		public float MouseSensitivity;
	}

	[Serializable]
	public class OnboardingContaioner
	{
		public int Step;

		public bool LightsTutorial;

		public bool OverChange;

		public bool CompletedShelfObjective;

		public string Version;
	}

	[Serializable]
	public class ExpensesData
	{
		public float CurrentDayBillAmount;

		public List<PlayerPaymentData> Bills;

		public List<PlayerPaymentData> Rents;

		public List<PlayerPaymentData> LoanRepayments;
	}

	[Serializable]
	public class EmployeesData
	{
		public List<int> CashiersData;

		public List<int> RestockersData;
	}

	[Serializable]
	public class StorageData
	{
		public bool Purchased;

		public int StorageLevel;
	}

	[SerializeField]
	private bool m_RemoveOldVersionSaveData;

	public ProgressionContainer Progression;

	public SettingsContainer Settings;

	public OnboardingContaioner Onboarding;

	public PriceContainer Price;

	public ExpensesData Expenses;

	public EmployeesData Employees;

	public StorageData Storage;

	public bool HasSave => false;

	private void Awake()
	{
	}

	public void Save()
	{
	}

	public void Load()
	{
	}

	public void Clear()
	{
	}
}
