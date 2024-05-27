using MyBox;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

public class SettingPriceCanvas : Singleton<SettingPriceCanvas>
{
	[SerializeField]
	private PricingInteraction m_PricingInteraction;

	[SerializeField]
	private GameObject m_Menu;

	[Separator("UI", false)]
	[SerializeField]
	private Image m_ProductIcon;

	[SerializeField]
	private TMP_Text m_ProductName;

	[SerializeField]
	private TMP_Text m_AvgCostText;

	[SerializeField]
	private LocalizeStringEvent m_MarketPrice;

	[SerializeField]
	private TMP_Text m_MarketPriceText;

	[SerializeField]
	private TMP_Text m_ProfitText;

	[SerializeField]
	private Color m_ProfitColor;

	[SerializeField]
	private Color m_LossColor;

	[SerializeField]
	private TMP_InputField m_PriceInput;

	[SerializeField]
	private TMP_Text m_PriceText;

	private PriceTag m_CurrentPriceTag;

	private int m_CurrentProductID;

	public bool Enable
	{
		set
		{
		}
	}

	private void Start()
	{
	}

	public void OpenMenu(PriceTag priceTag)
	{
	}

	public void CloseMenu()
	{
	}

	private void StartSetPrice(string input)
	{
	}

	private void SetPrice(string input)
	{
	}

	private void UpdateProfit(float newPrice = -1f)
	{
	}
}
