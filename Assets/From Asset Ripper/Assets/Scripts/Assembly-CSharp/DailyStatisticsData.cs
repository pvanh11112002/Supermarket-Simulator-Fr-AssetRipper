using System;

[Serializable]
public class DailyStatisticsData
{
	public int SatisfiedCustomerCount;

	public int CouldntFindProduct;

	public int ExpensiveProducts;

	public int ShortChangeAmount;

	public int TotalCustomerCount;

	public int StorePoint;

	public float CheckoutIncome;

	public float SupplyCosts;

	public float UpgradeCosts;

	public float BillCosts;

	public float RentCosts;

	public void Clear()
	{
	}
}
