using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class CustomerGenerator : Singleton<CustomerGenerator>
{
	[SerializeField]
	private List<Customer> m_CustomerPrefabs;

	[SerializeField]
	[Separator("Test", false)]
	public Transform[] SpawningTransforms;

	public Customer Spawn()
	{
		return null;
	}

	public Customer Spawn(Vector3 position)
	{
		return null;
	}

	public void DeSpawn(Customer customer)
	{
	}
}
