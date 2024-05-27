using UnityEngine;

public class StoreStatusSign : MonoBehaviour, IInteractable
{
	public InteractactableType Type => default(InteractactableType);

	public bool ContinousInteraction => false;

	public InteractionType InteractionType => default(InteractionType);

	public string InstantInteractionHint => null;

	public string HoldingInteractionHint => null;

	public bool InstantInteract()
	{
		return false;
	}

	public bool HoldingInteract()
	{
		return false;
	}
}
