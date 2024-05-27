using System.Collections.Generic;
using UnityEngine;

public class Display : MonoBehaviour, IInteractable
{
	[SerializeField]
	private DisplayType m_Type;

	[SerializeField]
	private FurniturePlacingMode m_PlacingMode;

	[SerializeField]
	private int m_ID;

	private DisplayData m_DisplayData;

	private DisplaySlot[] m_DisplaySlots;

	public InteractactableType Type => default(InteractactableType);

	public DisplayType DisplayType => default(DisplayType);

	public DisplayData Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public DisplaySlot RandomSlot => null;

	public bool ContinousInteraction => false;

	public InteractionType InteractionType => default(InteractionType);

	public string InstantInteractionHint => null;

	public string HoldingInteractionHint => null;

	public FurniturePlacingMode PlacingMode => null;

	public int ID => 0;

	private bool EnablePriceTagColliders
	{
		set
		{
		}
	}

	private bool EnableLabelColliders
	{
		set
		{
		}
	}

	private void Initialize()
	{
	}

	public void RemoveFromDisplayManagerWhileCarrying()
	{
	}

	public void AddBackToDisplayManagerAfterPlaced()
	{
	}

	public bool InstantInteract()
	{
		return false;
	}

	public bool HoldingInteract()
	{
		return false;
	}

	public void StartPlacingMode()
	{
	}

	public void BoxUp()
	{
	}

	public void Place()
	{
	}

	public void Despawn()
	{
	}

	public List<DisplaySlot> LabeledEmptySlots(int productID)
	{
		return null;
	}
}
