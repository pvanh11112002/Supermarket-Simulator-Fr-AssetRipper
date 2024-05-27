using System;
using MyBox;

public class StoreStatus : Singleton<StoreStatus>
{
	public Action<bool> onStoreStatusChaned;

	private bool m_IsOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void NewDayStarted()
	{
	}

	private void DayCycleDisabled()
	{
	}
}
