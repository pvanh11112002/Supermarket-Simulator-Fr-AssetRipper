using UnityEngine;

public class AutomatedCheckout : MonoBehaviour
{
	[SerializeField]
	private Transform m_CashierPos;

	[SerializeField]
	private Checkout m_Checkout;

	[SerializeField]
	private GameObject m_ShoppingBag;

	[SerializeField]
	[Header("Settings")]
	private float m_ScanningInterval;

	[SerializeField]
	private float m_IntervalAfterScanningAll;

	[SerializeField]
	private float m_TakingPaymentInterval;

	[SerializeField]
	private float m_FinishingPaymentDuration;

	[SerializeField]
	[Header("SFX")]
	private SFXInstance m_CashierSFX;

	private Cashier m_Cashier;

	public int CurrentCashierID => 0;

	public Cashier Cashier => null;

	public void Setup(Cashier cashier)
	{
	}

	public void RemoveCashier()
	{
	}

	public void StartCashierCheckout()
	{
	}

	public void FinishCheckout(bool paymentViaCreditCard)
	{
	}

	public void UpdateCashiersPosition()
	{
	}
}
