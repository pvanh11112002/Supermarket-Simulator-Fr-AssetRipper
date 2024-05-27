using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MyBox;
using UnityEngine;

public class CustomerManager : Singleton<CustomerManager>
{
	[CompilerGenerated]
	private sealed class _003CCustomerGeneration_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CustomerManager _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CCustomerGeneration_003Ed__19(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[SerializeField]
	private CustomerSpawnSettingManager m_SpawnSetting;

	[SerializeField]
	private Transform m_StoreDoor;

	[SerializeField]
	[Header("Latest Time For Customer Spawn")]
	private int m_LatestTimeToSpawnCustomer;

	[SerializeField]
	private bool m_AM;

	private ItemQuantity m_ShoppingList;

	private int m_TotalProductCount_ToBuy;

	private int m_ProductCount_ToBePickedFrom_DisplayedProducts;

	private int m_ProductCount_ToBePickedFrom_UnlockedProducts;

	private int m_ProductCount_ToBePickedFrom_ExpectedProducts;

	private CustomerStrategySO m_CurrentStrategy;

	private HashSet<int> m_ProductsToBuy;

	private bool m_SpawnCustomer;

	private List<Customer> m_ActiveCustomers;

	public bool CanSpawnCustomer
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool TooLateToSpawnCustomers => false;

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CCustomerGeneration_003Ed__19))]
	private IEnumerator CustomerGeneration()
	{
		return null;
	}

	public void SpawnCustomer()
	{
	}

	public void SpawnCustomer(Vector3 position)
	{
	}

	public ItemQuantity CreateShoppingList()
	{
		return null;
	}

	private HashSet<int> GetRandomProducts(List<int> productCountData, int amount)
	{
		return null;
	}

	private void FinishedTheDay()
	{
	}

	private void SpawnCustomersOnStoresOpened(bool open)
	{
	}

	private void StopSpawningCustomerAtNight()
	{
	}

	private void OnDayCycleManagerDisabled()
	{
	}
}
