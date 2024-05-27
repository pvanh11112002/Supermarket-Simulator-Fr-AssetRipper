using TMPro;
using UnityEngine;

public class SalesUIElement : MonoBehaviour
{
	[Header("Sales UI Element")]
	[SerializeField]
	protected TMP_Text m_ProductNameText;

	[SerializeField]
	protected TMP_Text m_ProductBrandText;

	[SerializeField]
	protected TMP_Text m_UnitPriceText;

	[SerializeField]
	protected TMP_Text m_TotalPriceText;

	[SerializeField]
	protected TMP_InputField m_ItemCountInput;

	protected int m_ProductID;

	protected ItemQuantity m_ProductQuantity;

	protected float m_TotalPrice;

	protected SalesType m_SalesType;

	public void Setup(int productID, SalesType salesType)
	{
	}

	public void Setup(ItemQuantity salesItem, SalesType salesType)
	{
	}

	public void UpdateTotalPrice()
	{
	}

	public void OnItemCountChangedByButtons(int amount)
	{
	}

	public virtual void OnItemCountChangedByInput(string input)
	{
	}
}
