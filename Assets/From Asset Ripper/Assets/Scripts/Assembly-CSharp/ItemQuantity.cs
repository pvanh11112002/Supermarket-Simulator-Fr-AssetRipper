using System;
using System.Collections.Generic;

[Serializable]
public class ItemQuantity
{
	public Dictionary<int, int> Products;

	public Dictionary<int, float> ProductPrice;

	public int FirstItemID => 0;

	public bool HasProduct => false;

	public bool HasLabel => false;

	public int FirstItemCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public ItemQuantity(ItemQuantity ItemQuantity)
	{
	}

	public ItemQuantity()
	{
	}

	public ItemQuantity(int ItemID, float price)
	{
	}
}
