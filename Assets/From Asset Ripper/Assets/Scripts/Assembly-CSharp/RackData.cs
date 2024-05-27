using System;
using System.Collections.Generic;

[Serializable]
public class RackData
{
	public TransformData Transform;

	public List<RackSlotData> RackSlots;

	public int FurnitureID;
}
