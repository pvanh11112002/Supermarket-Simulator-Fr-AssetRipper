using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LoanPaymentsTab : MonoBehaviour
{
	[Header("Components")]
	[SerializeField]
	private LoanRepaymentItem m_RepaymentItemPrefab;

	[SerializeField]
	private Transform m_RepaymentsContent;

	[SerializeField]
	private GameObject m_NoRepayments;

	[SerializeField]
	[Header("Loan Details")]
	private TMP_Text m_LoansTakenText;

	[SerializeField]
	private TMP_Text m_PaymentsRemainingText;

	[SerializeField]
	private TMP_Text m_LatePaymentFeeText;

	[SerializeField]
	private TMP_Text m_TotalDebtText;

	private List<LoanRepaymentItem> m_RepaymentItems;

	private void Start()
	{
	}

	private void LoadBillDatas()
	{
	}

	private void SpawnBillItem(PlayerPaymentData repaymentData)
	{
	}

	private void RemoveBillItem(PlayerPaymentData repaymentData)
	{
	}

	private void CheckIfAnyRepaymentsLeft()
	{
	}

	private void UpdateLoansTaken(int _)
	{
	}

	private void UpdatePaymentsRemaining(int _)
	{
	}

	private void UpdateLatePaymentFee()
	{
	}

	private void UpdateTotalDebt(int _)
	{
	}

	private void OnNewDayStarted()
	{
	}

	private void UnsubscribeDayCycle()
	{
	}

	private void OnBillDataChanged(PlayerPaymentData billData, bool isAdded)
	{
	}

	private void UnsubscribeBankManager()
	{
	}

	private void UpdatePayButtons(float _amount, MoneyManager.TransitionType _type)
	{
	}

	private void UnsubscribeMoneyTransition()
	{
	}
}
