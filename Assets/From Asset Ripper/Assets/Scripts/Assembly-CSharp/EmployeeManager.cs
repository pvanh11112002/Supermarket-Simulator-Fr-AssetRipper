using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class EmployeeManager : Singleton<EmployeeManager>
{
	[SerializeField]
	private Transform[] m_RestockerSpawnPositions;

	private List<int> m_CashiersData;

	private List<int> m_RestockersData;

	private List<Cashier> m_ActiveCashiers;

	private List<Restocker> m_ActiveRestockers;

	private HashSet<int> m_OccupiedProductsByRestockers;

	public List<PlayerPaymentData> OverduePayments => null;

	private void Start()
	{
	}

	public void HireCashier(int cashierID, float hiringCost)
	{
	}

	public void FireCashier(int cashierID)
	{
	}

	public bool IsCashierHired(int cashierID)
	{
		return false;
	}

	public Cashier GetAvailableCashier()
	{
		return null;
	}

	public void PoolCashier(Cashier cashier)
	{
	}

	public void HireRestocker(int restockerID, float hiringCost)
	{
	}

	public void FireRestocker(int restockerID)
	{
	}

	public bool IsRestockerHired(int restockerID)
	{
		return false;
	}

	public Transform GetSpawnPosition(int restockerID)
	{
		return null;
	}

	public void OccupyProductID(int productID, bool occupy)
	{
	}

	public bool IsProductOccupied(int productID)
	{
		return false;
	}

	private void LoadData()
	{
	}

	private void SpawnCashier(int cashierID)
	{
	}

	public void DespawnCashier(int cashierID)
	{
	}

	private void SpawnRestocker(int restockerID)
	{
	}

	private void DespawnRestocker(int restockerID)
	{
	}
}
