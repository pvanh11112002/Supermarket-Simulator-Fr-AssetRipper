using System;
using System.Collections.Generic;
using MyBox;

public class RackManager : Singleton<RackManager>
{
	private List<RackData> m_RackDatas;

	private List<Rack> m_Racks;

	private Dictionary<int, List<RackSlot>> m_RackSlots;

	public Action OnRackCountChanged;

	public List<RackData> Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<int> ProductsInRacks => null;

	private void Start()
	{
	}

	public void AddRackSlot(int productID, RackSlot newSlot)
	{
	}

	public void RemoveRackSlot(int productID, RackSlot slot)
	{
	}

	public void AddRack(Rack rack)
	{
	}

	public void RemoveRack(Rack rack)
	{
	}

	public RackSlot GetRackSlotThatHas(int productID)
	{
		return null;
	}

	public RackSlot GetRackSlotThatHasSpaceFor(int productID, int boxID)
	{
		return null;
	}

	private void LoadRackData()
	{
	}
}
