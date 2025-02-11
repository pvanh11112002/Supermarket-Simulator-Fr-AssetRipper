using System;

[Serializable]
public enum InteractionWarningType
{
	INSUFFICIENT_CHANGE = 0,
	PRODUCT_PLACEMENT_DISPLAY_TYPE = 1,
	PRODUCTS_MUSTBE_SAME = 2,
	FULL_DISPLAY = 3,
	FULL_BOX = 4,
	BOX_DOESNT_MATCH = 5,
	CANT_THROW = 6,
	INCORRECT_PAYMENT_AMOUNT_ON_POS_TERMINAL = 7,
	FULL_RACK = 8,
	DISPLAY_HAS_PRODUCT = 9
}
