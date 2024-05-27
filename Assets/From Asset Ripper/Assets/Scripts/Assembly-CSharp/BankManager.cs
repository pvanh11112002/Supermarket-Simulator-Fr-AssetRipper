using System;
using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class BankManager : Singleton<BankManager>
{
	[SerializeField]
	private List<BankCreditSO> m_Loans;

	[SerializeField]
	private float m_LatePaymentFeePenaltyPercentage;

	[SerializeField]
	private int m_RepaymentsDueDate;

	[SerializeField]
	private int m_AutoPayingRepaymentsDueDate;

	private List<LoanData> m_LoanDatas;

	private List<PlayerPaymentData> m_LoanBillDatas;

	public Action<int> onTakenLoan;

	public Action<int> onCompletedLoan;

	public Action onDisabled;

	public Action<PlayerPaymentData, bool> OnLoanBillDataChanged;

	public List<LoanData> Loans => null;

	public float LatePaymentFeePenaltyPercentage => 0f;

	public List<PlayerPaymentData> OverdueRepayments => null;

	public int RepaymentDueDate => 0;

	public int TakenLoanCount => 0;

	public int PaymentsRemaining => 0;

	public float TotalLatePaymentFee => 0f;

	public float TotalDebt => 0f;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public void PayRepayment(PlayerPaymentData loanData, bool byForce = false)
	{
	}

	private void LoadLoanDatas()
	{
	}

	private void LoadLoanRepaymentDatas()
	{
	}

	private void RemoveBill(PlayerPaymentData loanData)
	{
	}

	public void CompleteLoan(LoanData loanData)
	{
	}

	private void TryAddingLoanBills()
	{
	}

	private void UnsubscribeDayCycle()
	{
	}
}
