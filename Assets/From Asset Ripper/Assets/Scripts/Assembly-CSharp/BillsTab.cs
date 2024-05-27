using System.Collections.Generic;
using UnityEngine;

public class BillsTab : MonoBehaviour
{
	[SerializeField]
	[Header("Components")]
	private BillItem m_BillItemPrefab;

	[SerializeField]
	private Transform m_BillsContent;

	[SerializeField]
	private BillItem m_RentItemPrefab;

	[SerializeField]
	private Transform m_RentsContent;

	[SerializeField]
	private GameObject m_NoBills;

	[SerializeField]
	private GameObject m_NoRents;

	private List<BillItem> m_BillItems;

	private List<BillItem> m_RentItems;

	private void Start()
	{
	}

	private void OnBillDataChanged(PlayerPaymentData billData, bool isAdded)
	{
	}

	private void OnExpenseManagerDisabled()
	{
	}

	private void LoadBillDatas()
	{
	}

	private void SpawnBillItem(PlayerPaymentData billData)
	{
	}

	private void RemoveBillItem(PlayerPaymentData billData)
	{
	}

	private void CheckIfAnyBillsLeft()
	{
	}

	private void OnNewDayStarted()
	{
	}

	private void UnsubscribeDayCycle()
	{
	}

	private void UpdatePayButtons(float _amount, MoneyManager.TransitionType _type)
	{
	}

	private void UnsubscribeMoneyTransition()
	{
	}
}
