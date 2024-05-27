using System;
using MyBox;
using UnityEngine;

public class WarningSystem : Singleton<WarningSystem>
{
	public delegate void InteractionWarningRaisedDelegate(InteractionWarningType warningType, params string[] messages);

	[Separator("Customer Speech", false)]
	[SerializeField]
	private CustomerSpeech m_CustomerSpeechPrefab;

	[SerializeField]
	private float m_CustomerSpeechLifetime;

	public Action onCheckoutWarningRaised;

	public Action onNoProfitWarningRaised;

	public InteractionWarningRaisedDelegate onInteractionWarningRaised;

	public float CustomerSpeechFontSize => 0f;

	public void RaiseCheckoutWarning()
	{
	}

	public void RaiseNoProfitWarning()
	{
	}

	public void SpawnCustomerSpeech(CustomerSpeechType speechType, Transform customer, params string[] args)
	{
	}

	public void RaiseInteractionWarning(InteractionWarningType warningType, params string[] args)
	{
	}
}
