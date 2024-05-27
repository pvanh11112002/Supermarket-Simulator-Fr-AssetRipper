using System.Collections.Generic;
using UnityEngine;

public class Mop : MonoBehaviour, IInteractable
{
	public InteractactableType Type => default(InteractactableType);

	public bool ContinousInteraction => false;

	public List<Renderer> Renderers => null;

	public string InteractionHint => null;

	public InteractionType InteractionType => default(InteractionType);

	public string InstantInteractionHint => null;

	public string HoldingInteractionHint => null;

	public bool HoldingInteract()
	{
		return false;
	}

	public bool InstantInteract()
	{
		return false;
	}

	public bool Interact()
	{
		return false;
	}
}
