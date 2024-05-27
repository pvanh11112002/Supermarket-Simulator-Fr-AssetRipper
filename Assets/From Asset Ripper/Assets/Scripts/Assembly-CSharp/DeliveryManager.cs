using MyBox;
using UnityEngine;

public class DeliveryManager : Singleton<DeliveryManager>
{
	[Header("Test Settings")]
	public float space;

	[Header("Copmponents")]
	[SerializeField]
	private Transform m_DeliveryPosition;

	public void Delivery(MarketShoppingCart.CartData cartData)
	{
	}
}
