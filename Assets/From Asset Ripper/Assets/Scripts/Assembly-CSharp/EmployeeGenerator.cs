using MyBox;
using UnityEngine;

public class EmployeeGenerator : Singleton<EmployeeGenerator>
{
	public Cashier SpawnCashier(Cashier prefab)
	{
		return null;
	}

	public Restocker SpawnRestocker(Restocker prefab, Vector3 position, Quaternion rotation)
	{
		return null;
	}
}
