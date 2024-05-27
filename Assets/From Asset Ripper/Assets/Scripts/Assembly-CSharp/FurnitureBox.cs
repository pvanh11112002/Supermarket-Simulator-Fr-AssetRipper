using MyBox;
using UnityEngine;
using UnityEngine.UI;

public class FurnitureBox : MonoBehaviour, IInteractable
{
	[Separator("Components", false)]
	[SerializeField]
	private Image m_ShelfIconImage;

	[SerializeField]
	private BoxSize m_Size;

	[SerializeField]
	private Animation m_Animation;

	[SerializeField]
	[Separator("Carrying Settings", false)]
	private Vector3 m_PositionOffset;

	[SerializeField]
	private Vector3 m_RotationOffset;

	[SerializeField]
	private Transform m_FurnitureSpawnPosition;

	[SerializeField]
	[Separator("Animation Settings", false)]
	private float m_AnimationDuration;

	[SerializeField]
	private float m_ScalingDownTime;

	private FurnitureBoxData m_Data;

	private Collider m_Collider;

	public InteractactableType Type => default(InteractactableType);

	public bool ContinousInteraction => false;

	public string InstantInteractionHint => null;

	public string HoldingInteractionHint => null;

	public FurnitureBoxData Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BoxSize Size => default(BoxSize);

	public Vector3 FurnitureSpawnPosition => default(Vector3);

	public InteractionType InteractionType => default(InteractionType);

	private void Initialize()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Setup(int shelfID, bool newBox = false)
	{
	}

	public void OpenBox()
	{
	}

	public void PickUp()
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

	public void ResetBox()
	{
	}

	private void SetIdle()
	{
	}
}
