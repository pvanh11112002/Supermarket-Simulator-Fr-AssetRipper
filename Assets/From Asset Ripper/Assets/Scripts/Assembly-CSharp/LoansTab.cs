using System.Collections.Generic;
using UnityEngine;

public class LoansTab : MonoBehaviour
{
	[SerializeField]
	private LoanItem m_LoanItemPrefab;

	[SerializeField]
	private Transform m_LoanItemsContent;

	private List<LoanItem> m_LoanItems;

	private void Start()
	{
	}

	private void SpawnLoanItems()
	{
	}

	private void UpdateActiveLoanItems()
	{
	}

	private void OnLoanTaken(int loanID)
	{
	}

	private void OnLoanCompleted(int loanID)
	{
	}

	private void OnBillDataChanged(PlayerPaymentData _billData, bool _isAdded)
	{
	}

	private void UnsubscribeOnBillDataChanged()
	{
	}
}
