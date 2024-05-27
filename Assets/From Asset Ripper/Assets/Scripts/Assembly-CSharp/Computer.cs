using UnityEngine;
using UnityEngine.UI;

public class Computer : MonoBehaviour, IInteractable
{
	[SerializeField]
	private GameObject m_PCCam;

	[SerializeField]
	private Transform m_PlayerPosition;

	[SerializeField]
	private FurniturePlacingMode m_PlacingMode;

	[SerializeField]
	private GraphicRaycaster[] m_Raycasters;

	private bool m_IsOpen;

	private TransformData m_TransformData;

	public InteractactableType Type => default(InteractactableType);

	public bool ContinousInteraction => false;

	public bool OpenPC
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string InstantInteractionHint => null;

	public string HoldingInteractionHint => null;

	public InteractionType InteractionType => default(InteractionType);

	private void Start()
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

	public void Back()
	{
	}

	public void StartPlacingMode()
	{
	}

	public void PlaceComputer()
	{
	}
}
