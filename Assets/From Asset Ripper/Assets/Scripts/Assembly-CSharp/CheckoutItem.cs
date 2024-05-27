using TMPro;
using UnityEngine;

public class CheckoutItem : MonoBehaviour
{
	[SerializeField]
	private TMP_Text m_ProductNameText;

	[SerializeField]
	private TMP_Text m_UnitCountText;

	[SerializeField]
	private TMP_Text m_PriceText;

	[SerializeField]
	private TMP_Text m_TotalText;

	private ItemQuantity m_Product;

	public ItemQuantity Product
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private float m_Price => 0f;

	public void Setup(Product product)
	{
	}

	public void AddProduct(Product product)
	{
	}

	private void UpdateUI(bool setup)
	{
	}
}
