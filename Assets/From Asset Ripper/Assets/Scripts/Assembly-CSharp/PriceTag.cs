using TMPro;
using UnityEngine;

public class PriceTag : MonoBehaviour, IInteractable
{
	[SerializeField]
	private TMP_Text m_PriceText;

	private DisplaySlot m_DisplaySlot;

	public bool Enabled => false;

	public InteractactableType Type => default(InteractactableType);

	public bool ContinousInteraction => false;

	public DisplaySlot DisplaySlot => null;

	public string InstantInteractionHint => null;

	public string HoldingInteractionHint => null;

	public InteractionType InteractionType => default(InteractionType);

	public void EnableTag(DisplaySlot displaySlot)
	{
	}

	public void DisableTag()
	{
	}

	public void SetPrice(float price)
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
}
