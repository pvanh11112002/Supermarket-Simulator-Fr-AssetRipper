using System.Collections.Generic;
using MyBox;

public class InventoryManager : Singleton<InventoryManager>
{
	private List<BoxData> m_Boxes;

	private List<FurnitureBoxData> m_ShelfBoxes;

	private Dictionary<int, int> m_DisplayedProducts;

	public List<int> DisplayedProducts => null;

	public Dictionary<int, int> Products => null;

	public int ProductCount(int ProductId)
	{
		return 0;
	}

	private void Awake()
	{
	}

	private void LoadBoxDatas()
	{
	}

	public void AddBox(BoxData boxData)
	{
	}

	public void AddBox(FurnitureBoxData boxData)
	{
	}

	public void RemoveBox(BoxData boxData)
	{
	}

	public void RemoveBox(FurnitureBoxData boxData)
	{
	}

	public void AddProductToDisplay(ItemQuantity productData)
	{
	}

	public void RemoveProductFromDisplay(ItemQuantity productData)
	{
	}

	public bool IsProductDisplayed(int productID)
	{
		return false;
	}
}
