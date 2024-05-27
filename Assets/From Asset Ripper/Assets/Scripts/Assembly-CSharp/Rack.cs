using System.Collections.Generic;
using UnityEngine;

public class Rack : MonoBehaviour, IInteractable
{
	[SerializeField]
	private Highlightable m_Highlightable;

	[SerializeField]
	private FurniturePlacingMode m_PlacingMode;

	[SerializeField]
	private int m_ID;

	private RackData m_RackData;

	private RackSlot[] m_RackSlots;

	public InteractactableType Type => default(InteractactableType);

	public bool ContinousInteraction => false;

	public InteractionType InteractionType => default(InteractionType);

	public string InstantInteractionHint => null;

	public string HoldingInteractionHint => null;

	public FurniturePlacingMode PlacingMode => null;

	public int ID => 0;

	public RackData Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<RackSlot> RackSlots => null;

	public bool EnableBoxColliders
	{
		set
		{
		}
	}

	private void Initialize()
	{
	}

	public void RemoveFromRackManagerWhileCarrying()
	{
	}

	public void AddBackToRackManagerAfterPlaced()
	{
	}

	public bool HoldingInteract()
	{
		return false;
	}

	public bool InstantInteract()
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

	public void AddOrRemoveRenderer(Renderer[] renderers, bool add)
	{
	}
}
