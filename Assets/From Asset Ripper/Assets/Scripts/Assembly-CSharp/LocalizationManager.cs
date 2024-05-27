using System.Collections.Generic;
using MyBox;
using UnityEngine;
using UnityEngine.Localization;

public class LocalizationManager : Singleton<LocalizationManager>
{
	[SerializeField]
	private DisplayTypeEntry[] m_DisplayTypeLocalizations;

	[SerializeField]
	private CustomerSpeechEntry[] m_CustomerSpeeches;

	[SerializeField]
	private InteractionWarningEntry[] m_InteractionWarnings;

	[SerializeField]
	private PlayerPaymentTypeEntry[] m_PlayerPayments;

	private Dictionary<int, string> m_LocalizedProductNames;

	private Dictionary<int, string> m_LocalizedFurnitureNames;

	private Dictionary<int, string> m_LocalizedProductLicenceNames;

	private Dictionary<int, string> m_LocalizedSectionNames;

	private Dictionary<int, string> m_LocalizedLoanNames;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public string LocalizedProductName(int productID)
	{
		return null;
	}

	public string LocalizedFurnitureName(int furnitureID)
	{
		return null;
	}

	public string LocalizedProductLicenceName(int licenceID)
	{
		return null;
	}

	public string LocalizedSectionName(int sectionID)
	{
		return null;
	}

	public string LocalizedLoanName(int loanID)
	{
		return null;
	}

	public LocalizationEntry LocalizedEntry(DisplayType displayType)
	{
		return null;
	}

	public LocalizationEntry LocalizedEntry(CustomerSpeechType speechType)
	{
		return null;
	}

	public LocalizationEntry LocalizedEntry(InteractionWarningType warningType)
	{
		return null;
	}

	public LocalizationEntry LocalizedEntry(PlayerPaymentType paymentType)
	{
		return null;
	}

	private void InitLocalization()
	{
	}

	private void OnLocaleChanged(Locale newLocale)
	{
	}

	private void UpdateLocalization()
	{
	}
}
