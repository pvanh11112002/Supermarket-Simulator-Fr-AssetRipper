using System;
using System.Collections.Generic;

[Serializable]
public class RackSlotData
{
	public List<BoxData> RackedBoxDatas;

	public int ProductID;

	public int BoxID;

	public int TotalProductCount => 0;

	public int BoxCount => 0;

	public void Clear()
	{
	}

	public void Setup(int productID, int boxID)
	{
	}
}
