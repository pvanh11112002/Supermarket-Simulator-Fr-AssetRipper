using System;
using System.Collections.Generic;
using MyBox;

public class DisplayManager : Singleton<DisplayManager>
{
	private List<DisplayData> m_DisplayDatas;

	private List<Display> m_Displays;

	private Dictionary<int, List<DisplaySlot>> m_DisplayedProducts;

	public Action onPurchasedDisplay;

	public List<DisplayData> Data
	{
		set
		{
		}
	}

	public bool HasAnythingDisplayed => false;

	private void Start()
	{
	}

	public void AddDisplaySlot(int productID, DisplaySlot newSlot)
	{
	}

	public void RemoveDisplaySlot(int productID, DisplaySlot slot)
	{
	}

	public List<DisplaySlot> GetDisplaySlots(int productID, bool hasProduct)
	{
		return null;
	}

	public List<DisplaySlot> GetLabeledEmptyDisplaySlots(int productID)
	{
		return null;
	}

	public DisplaySlot GetRandomDisplaySlot()
	{
		return null;
	}

	public DisplaySlot GetRandomFilledDisplay()
	{
		return null;
	}

	public void AddDisplay(Display display)
	{
	}

	public void RemoveDisplay(Display display)
	{
	}

	public int GetDisplayedProductCount(int productID)
	{
		return 0;
	}

	private void LoadDisplayData()
	{
	}

	private void LoadFurnitureID(DisplayData displayData)
	{
	}
}
