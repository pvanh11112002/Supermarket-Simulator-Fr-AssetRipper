using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class CustomerStrategiesManager : Singleton<CustomerStrategiesManager>
{
	[SerializeField]
	private List<CustomerStrategySO> m_CustomerStrategies;

	public CustomerStrategySO CurrentStrategy => null;
}
