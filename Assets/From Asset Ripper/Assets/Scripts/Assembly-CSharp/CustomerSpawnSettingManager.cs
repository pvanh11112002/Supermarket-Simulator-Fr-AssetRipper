using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawnSettingManager : MonoBehaviour
{
	[SerializeField]
	private List<CustomerSpawnSettingSO> m_SpawnSettings;

	public float GetCustomerSpawningTime()
	{
		return 0f;
	}
}
