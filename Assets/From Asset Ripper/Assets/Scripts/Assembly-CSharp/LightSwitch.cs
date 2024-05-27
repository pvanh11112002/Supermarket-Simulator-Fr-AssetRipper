using UnityEngine;

public class LightSwitch : MonoBehaviour, IInteractable
{
	[SerializeField]
	private Animator m_Anim;

	public InteractactableType Type => default(InteractactableType);

	public bool ContinousInteraction => false;

	public string InstantInteractionHint => null;

	public string HoldingInteractionHint => null;

	public InteractionType InteractionType => default(InteractionType);

	public bool InstantInteract()
	{
		return false;
	}

	public bool HoldingInteract()
	{
		return false;
	}
}
