using TMPro;
using UnityEngine;

public class DailyStatisticsScreen : MonoBehaviour
{
	[Header("Animation")]
	[SerializeField]
	private DailyStatisticsScreenAnimation m_ScreenAnimation;

	[Header("Text Components")]
	[SerializeField]
	private TMP_Text m_DayText;

	[Space]
	[SerializeField]
	private TMP_Text m_SatisfiedCustomerText;

	[SerializeField]
	private TMP_Text m_ProductsNotFoundText;

	[SerializeField]
	private TMP_Text m_ProductsFoundExpensiveText;

	[SerializeField]
	private TMP_Text m_ShortChangeText;

	[SerializeField]
	private TMP_Text m_TotalCustomerText;

	[SerializeField]
	private TMP_Text m_StorePointText;

	[Space]
	[SerializeField]
	private TMP_Text m_CheckoutIncomeText;

	[SerializeField]
	private TMP_Text m_SupplyCostsText;

	[SerializeField]
	private TMP_Text m_UpgradeCostsText;

	[SerializeField]
	private TMP_Text m_RentText;

	[SerializeField]
	private TMP_Text m_BillsText;

	[SerializeField]
	private TMP_Text m_TotalProfitText;

	[SerializeField]
	[Space]
	private TMP_Text m_BalanceText;

	[Header("Settings")]
	[SerializeField]
	private Color m_PositiveTextColor;

	[SerializeField]
	private Color m_NeutralTextColor;

	[SerializeField]
	private Color m_NegativeTextColor;

	[SerializeField]
	[Header("Bankruptcy")]
	private BankruptcyManager m_BankruptcyManager;

	[SerializeField]
	private GameObject m_StartNextDayButton;

	[SerializeField]
	private GameObject m_StartNewGameButton;

	[SerializeField]
	private GameObject m_BankruptedText;

	private string m_PositiveColorCode;

	private string m_NegativeColorCode;

	private string m_NeutralColorCode;

	private bool EnableStatisticsScreen
	{
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void StartNextDay()
	{
	}

	public void StartNewGame()
	{
	}

	private void OnDayFinished()
	{
	}

	private void UpdateDailyStatistics()
	{
	}

	private void CheckBankruptcy()
	{
	}

	private void OnDayCycleDisabled()
	{
	}

	private string StatisticPreCode(float amount)
	{
		return null;
	}

	private string StatisticPreCode(int amount)
	{
		return null;
	}

	private string StatisticPreColorCode(int amount)
	{
		return null;
	}
}
