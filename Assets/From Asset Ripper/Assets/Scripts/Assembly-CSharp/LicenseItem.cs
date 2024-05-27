using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

public class LicenseItem : MonoBehaviour
{
	[SerializeField]
	[Header("Components")]
	private TMP_Text m_LicenseName;

	[SerializeField]
	private TMP_Text m_ProductItem;

	[SerializeField]
	private TMP_Text m_CostText;

	[SerializeField]
	private Transform m_ProductListContent;

	[SerializeField]
	private float m_ProductTypeTextSize;

	[SerializeField]
	[Header("Required Level")]
	private LocalizeStringEvent m_RequiredLevelLocalizedText;

	[SerializeField]
	private TMP_Text m_RequiredLevelText;

	[SerializeField]
	private Color m_ReachedRequiredStoreLevelColor;

	[SerializeField]
	private Color m_NotReachedRequiredStoreLevelColor;

	[Header("Purchase Button")]
	[SerializeField]
	private Button m_PurchaseButton;

	[SerializeField]
	private TMP_Text m_PurchaseButtonText;

	private float m_Cost;

	private int m_licenseID;

	private ProductLicenseSO m_ProductLicense;

	private bool m_Purchased;

	public int LicenseID => 0;

	private bool m_AvailableStoreLevel => false;

	public void Setup(int licenseID, int idx)
	{
	}

	public void Purchase()
	{
	}

	private void SpawnProductsList()
	{
	}

	private void UpdatePurchaseButton(float _amount, MoneyManager.TransitionType _type)
	{
	}

	private void CheckIfReachedRequiredLevel(bool _)
	{
	}

	private void OnMoneyManagerDisabled()
	{
	}

	private void OnStoreLevelDisabled()
	{
	}
}
