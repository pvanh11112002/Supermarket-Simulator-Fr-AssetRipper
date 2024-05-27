using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class IDManager : Singleton<IDManager>
{
	[SerializeField]
	private List<ProductSO> m_Products;

	[SerializeField]
	private List<BankCreditSO> m_BankCredits;

	[SerializeField]
	private List<ProductLicenseSO> m_ProductLicenses;

	[SerializeField]
	private List<FurnitureSO> m_Furnitures;

	[SerializeField]
	private List<DisplaySO> m_Displays;

	[SerializeField]
	private List<SectionSO> m_Sections;

	[SerializeField]
	private List<StorageSO> m_StorageSections;

	[SerializeField]
	private List<CashierSO> m_Cashiers;

	[SerializeField]
	private List<RestockerSO> m_Restockers;

	[SerializeField]
	private List<BoxSO> m_Boxes;

	public List<ProductSO> Products => null;

	public List<FurnitureSO> Furnitures => null;

	public List<SectionSO> Sections => null;

	public List<BankCreditSO> Loans => null;

	public List<StorageSO> StorageSections => null;

	public List<BoxSO> Boxes => null;

	public int DisplayIDByType(DisplayType displayType)
	{
		return 0;
	}

	public ProductSO ProductSO(int id)
	{
		return null;
	}

	public ProductLicenseSO ProductLicenseSO(int id)
	{
		return null;
	}

	public FurnitureSO FurnitureSO(int id)
	{
		return null;
	}

	public SectionSO SectionSO(int id)
	{
		return null;
	}

	public StorageSO StorageSO(int id)
	{
		return null;
	}

	public BankCreditSO BankCreditSO(int id)
	{
		return null;
	}

	public CashierSO CashierSO(int id)
	{
		return null;
	}

	public RestockerSO RestockerSO(int id)
	{
		return null;
	}

	public BoxSO BoxSO(int id)
	{
		return null;
	}
}
