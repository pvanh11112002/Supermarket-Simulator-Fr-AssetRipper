using System;

[Serializable]
public class PlayerPaymentData
{
	public int Date;

	public float Amount;

	public PlayerPaymentType PaymentType;

	public float LatePaymentFee;

	public float TotalAmount => 0f;
}
