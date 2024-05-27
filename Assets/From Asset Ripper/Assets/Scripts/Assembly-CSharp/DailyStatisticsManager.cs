using MyBox;

public class DailyStatisticsManager : Singleton<DailyStatisticsManager>
{
	private DailyStatisticsData m_DailyStatisticsData;

	public DailyStatisticsData DailyStatisticsData => null;

	public float DailyProfit => 0f;

	private void Start()
	{
	}

	public void AddSatisfiedCustomer()
	{
	}

	public void AddCouldntFindProduct()
	{
	}

	public void AddExpensiveProducts()
	{
	}

	public void AddIncorrectChangeAmount()
	{
	}

	public void AddCustomer()
	{
	}

	private void OnMoneyTransition(float amount, MoneyManager.TransitionType transitionType)
	{
	}

	private void ResetStatistics()
	{
	}

	private void OnDayCycleDisabled()
	{
	}
}
