using MyBox;
using UnityEngine;

public class Furniture : MonoBehaviour, IInteractable
{
	[Separator("Placing Settings", false)]
	[SerializeField]
	private FurniturePlacingMode m_PlacingMode;

	[SerializeField]
	private int m_ID;

	private FurnitureData m_Data;

	public InteractactableType Type => default(InteractactableType);

	public bool ContinousInteraction => false;

	public string InstantInteractionHint => null;

	public string HoldingInteractionHint => null;

	public FurniturePlacingMode PlacingMode => null;

	public InteractionType InteractionType => default(InteractionType);

	public int ID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public FurnitureData Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void FixedUpdate()
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

	public void Despawn()
	{
	}
}
