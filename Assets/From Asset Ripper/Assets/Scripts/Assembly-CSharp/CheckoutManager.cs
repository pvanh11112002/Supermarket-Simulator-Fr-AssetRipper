using System;
using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class CheckoutManager : Singleton<CheckoutManager>
{
	[HideInInspector]
	public List<Customer> m_CustomersAwaiting;

	private List<Checkout> m_Checkouts;

	private List<CheckoutData> m_CheckoutDatas;

	private List<Checkout> m_TempCheckouts;

	private List<Cashier> m_Cashiers;

	public Action onCheckoutCompleted;

	public List<CheckoutData> Data
	{
		set
		{
		}
	}

	public List<Cashier> Cashiers => null;

	public Checkout GetAvailableCheckout => null;

	public bool HasAvailableCashierSlot(int totalCashierCount)
	{
		return false;
	}

	private void Start()
	{
	}

	public List<Customer> GetAwaitingCustomer(int amount)
	{
		return null;
	}

	public void AddCheckout(Checkout checkout)
	{
	}

	public void RemoveCheckout(Checkout checkout)
	{
	}

	public void AddCashier(Cashier cashier)
	{
	}

	public void AddCashier(Checkout checkout, Cashier cashier)
	{
	}

	public void RemoveCashier(Cashier cashier)
	{
	}

	private void SetupCheckouts()
	{
	}

	private void LoadCheckoutData()
	{
	}
}
