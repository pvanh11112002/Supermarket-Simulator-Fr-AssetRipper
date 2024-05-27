using System;
using MyBox;

public class MoneyManager : Singleton<MoneyManager>
{
	public enum TransitionType
	{
		NONE = 0,
		CHECKOUT_INCOME = 1,
		SUPPLY_COSTS = 2,
		UPGRADE_COSTS = 3,
		RENT = 4,
		BILLS = 5,
		LOAN_INCOME = 6,
		LOAN_PAYMENT = 7,
		STAFF = 8,
		FURNITURE_SALE = 9
	}

	public Action<float, TransitionType> onMoneyTransition;

	public Action onDisabled;

	public float Money
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool HasMoney(float amount)
	{
		return false;
	}

	private void OnDisable()
	{
	}

	public void MoneyTransition(float amount, TransitionType type)
	{
	}

	public void RecordMoneyTransitionAs(float amount, TransitionType type)
	{
	}
}
