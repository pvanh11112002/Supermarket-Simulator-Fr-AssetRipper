public class CartItem : SalesUIElement
{
	private MarketShoppingCart m_ShoppingCart;

	public ItemQuantity SalesItem => null;

	public void Setup(ItemQuantity salesItemData, MarketShoppingCart shoppingCart, SalesType salesType)
	{
	}

	public new void OnItemCountChangedByButtons(int amount)
	{
	}

	public override void OnItemCountChangedByInput(string input)
	{
	}

	public void RemoveProductFromCart()
	{
	}

	public void UpdateUnitPrice()
	{
	}
}
