using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewProductLicenseCanvas : MonoBehaviour
{
	[SerializeField]
	[Header("Components")]
	private CanvasGroup m_NewProductsMenu;

	[SerializeField]
	private Transform m_NewProductsContent;

	[SerializeField]
	private TMP_Text m_FirstProductName;

	[SerializeField]
	[Header("Settings")]
	private float m_ProductTypeTextSize;

	[SerializeField]
	private Color m_ProductTypeColor;

	[SerializeField]
	[Header("Animation")]
	private float m_FadeInDuration;

	[SerializeField]
	private float m_WindowLifetime;

	[SerializeField]
	private float m_FadeOutDuration;

	[SerializeField]
	private float m_LicenseQueueInterval;

	private List<TMP_Text> m_ProductNames;

	private bool m_AlreadyEnabled;

	private Queue<int> m_PurchasedLicenseQueue;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnProductLicensePurchased(int id)
	{
	}

	private void ResetContent()
	{
	}

	private void OnLicenseManagerDisabled()
	{
	}
}
