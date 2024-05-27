using UnityEngine;

public class Cashier : MonoBehaviour
{
	[SerializeField]
	private Animator m_Animator;

	private int m_CashierID;

	public int CashierID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public void ScanAnimation()
	{
	}

	public void TakePaymentAnimation()
	{
	}
}
