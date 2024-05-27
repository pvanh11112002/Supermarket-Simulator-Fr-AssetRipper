using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Components;

public class PurchasedLicenseIndicator : MonoBehaviour
{
	[SerializeField]
	[Header("Components")]
	private CanvasGroup m_CanvasGroup;

	[SerializeField]
	private LocalizeStringEvent m_Text;

	[SerializeField]
	[Header("Animation")]
	private float m_FadeInDuration;

	[SerializeField]
	private float m_FadeOutDuration;

	[SerializeField]
	private float m_TextLifetime;

	[SerializeField]
	private float m_QueueInterval;

	private bool m_AlreadyEnabled;

	private Queue<int> m_PurchasedLicenseQueue;

	private void Start()
	{
	}

	private void OnPurchasedLicense(int id)
	{
	}

	private void FinishCanvasPopup()
	{
	}

	private void OnLicenseManagerDisabled()
	{
	}
}
