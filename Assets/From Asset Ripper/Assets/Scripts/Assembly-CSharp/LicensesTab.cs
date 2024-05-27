using System.Collections.Generic;
using UnityEngine;

public class LicensesTab : MonoBehaviour
{
	[Header("Components")]
	[SerializeField]
	private LicenseItem m_LicenseItemPrefab;

	[SerializeField]
	private Transform m_LicensesContent;

	[SerializeField]
	private GameObject m_PurchasedAllText;

	private List<LicenseItem> m_LicenseItems;

	private void Start()
	{
	}

	private void OnPurchasedLicense(int id)
	{
	}

	private void OnLicenseManagerDisabled()
	{
	}

	private void CheckLicenseCount()
	{
	}
}
