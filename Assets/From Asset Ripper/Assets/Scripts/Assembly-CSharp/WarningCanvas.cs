using UnityEngine;
using UnityEngine.Localization.Components;

public class WarningCanvas : MonoBehaviour
{
	[Header("Checkout Warning")]
	[SerializeField]
	private CanvasGroup m_CheckoutNotification;

	[SerializeField]
	private CanvasGroup m_NoProfitNotification;

	[SerializeField]
	private float m_CheckoutWarning_FadeIn;

	[SerializeField]
	private float m_CheckoutWarning_FadeOut;

	[SerializeField]
	private float m_CheckoutWarning_Lifetime;

	[SerializeField]
	private float m_NoProfitWarning_Lifetime;

	[SerializeField]
	[Header("Interaction Warning")]
	private CanvasGroup m_InteractionWarningNotification;

	[SerializeField]
	private LocalizeStringEvent m_InteractionWarningLocalizedText;

	[SerializeField]
	private float m_InteractionWarning_FadeIn;

	[SerializeField]
	private float m_InteractionWarning_FadeOut;

	[SerializeField]
	private float m_InteractionWarning_Lifetime;

	[Header("Settings")]
	[SerializeField]
	private float m_MinTimeBetweenInteractionWarnings;

	[SerializeField]
	private float m_MinTimeBetweenCheckoutWarnings;

	[SerializeField]
	private float m_MinTimeBetweenNoProfitWarnings;

	[SerializeField]
	private float m_MinTimeBetweenWarnings;

	private float m_LastInteractionWarningTime;

	private float m_LastCheckoutWarningTime;

	private float m_LastNoProfitTime;

	private float m_LastWarningTime;

	private void Start()
	{
	}

	private void ShowCheckoutWarning()
	{
	}

	private void ShowNoProfitWarning()
	{
	}

	private void ShowInteractionWarning(InteractionWarningType warningType, params string[] args)
	{
	}
}
