using UnityEngine;
using UnityEngine.UI;

public class FurnitureSalesItem : SalesUIElement
{
	[Header("Sales Item")]
	[SerializeField]
	private Image m_ProductIcon;

	private FurnituresViewer m_ShelvesViewer;

	public string ProductName => null;

	public void Setup(int productID, FurnituresViewer shelvesViewer)
	{
	}

	public void AddToCart()
	{
	}
}
