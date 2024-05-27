using System;
using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class ExpensesManager : Singleton<ExpensesManager>
{
	[Separator("Expenses Settings", false)]
	[SerializeField]
	private ExpensesSO m_ExpensesSettings;

	private float m_DailyRentAmount;

	private bool m_IncreaseBills;

	private List<PlayerPaymentData> m_BillDatas;

	private List<PlayerPaymentData> m_RentDatas;

	public Action<PlayerPaymentData, bool> OnBillDataChanged;

	public Action OnDisabled;

	public float BillAmount
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float RentAmount => 0f;

	public int BillPaymentDueDate => 0;

	public List<PlayerPaymentData> OverdueBills => null;

	private float m_CurrentBillAmount
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private bool TooLateToIncreaseBills => false;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void IncreaseDailyBill(ExpenseType type)
	{
	}

	public void PayBill(PlayerPaymentData billData, bool byForce = false)
	{
	}

	private void AddBill()
	{
	}

	private void RemoveBill(PlayerPaymentData billData)
	{
	}

	private void LoadDailyRentData()
	{
	}

	private void LoadBillDatas()
	{
	}

	public List<PlayerPaymentData> GetBills(PlayerPaymentType paymentType)
	{
		return null;
	}

	private void OnSectionPurchased(int id)
	{
	}

	private void OnSectionManagerDisabled()
	{
	}

	private void CheckIfDaysOver()
	{
	}

	private void CheckIfDayStarted(bool open)
	{
	}

	private void OnDayCycleDisabled()
	{
	}
}
