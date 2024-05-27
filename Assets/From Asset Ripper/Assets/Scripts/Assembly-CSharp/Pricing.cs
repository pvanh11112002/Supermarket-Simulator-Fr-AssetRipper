using System;

[Serializable]
public class Pricing
{
	public int ProductID;

	public float Price;

	public Pricing(Pricing pricing)
	{
	}

	public Pricing(int id, float price)
	{
	}
}
