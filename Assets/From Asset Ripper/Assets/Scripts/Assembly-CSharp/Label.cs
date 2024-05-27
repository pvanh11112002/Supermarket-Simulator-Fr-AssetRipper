using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Label : MonoBehaviour, IInteractable
{
	[SerializeField]
	private Image m_ProductIconImage;

	[SerializeField]
	private GameObject m_IconCanvas;

	[SerializeField]
	private TMP_Text m_ProductCount;

	private DisplaySlot m_DisplaySlot;

	private RackSlot m_RackSlot;

	public bool Enabled => false;

	public int ProductCount
	{
		set
		{
		}
	}

	public DisplaySlot DisplaySlot => null;

	public InteractactableType Type => default(InteractactableType);

	public bool ContinousInteraction => false;

	public InteractionType InteractionType => default(InteractionType);

	public string InstantInteractionHint => null;

	public string HoldingInteractionHint => null;

	public void DisplaySetup(DisplaySlot displaySlot)
	{
	}

	public void RackSetup(RackSlot rackSlot)
	{
	}

	public void DisableTag()
	{
	}

	public void SetProductIcon(int productID)
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

	private void ClearLabel()
	{
	}
}
