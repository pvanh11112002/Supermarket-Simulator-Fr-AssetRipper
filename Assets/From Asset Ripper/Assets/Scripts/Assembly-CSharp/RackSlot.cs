using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class RackSlot : MonoBehaviour, IInteractable
{
	[SerializeField]
	private Highlightable m_Highlightable;

	[SerializeField]
	private Transform m_InteractionPosition;

	[SerializeField]
	private Label m_Label;

	private List<Box> m_Boxes;

	private RackSlotData m_Data;

	private Tween m_ColliderEnabler;

	private Rack m_Rack;

	public bool Full => false;

	public int CurrentBoxID => 0;

	public RackSlotData Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector3 InteractionPosition => default(Vector3);

	public Quaternion InteractionRotation => default(Quaternion);

	public bool HasBox => false;

	private bool HasLabel => false;

	public bool HasProduct => false;

	public InteractactableType Type => default(InteractactableType);

	public bool ContinousInteraction => false;

	public InteractionType InteractionType => default(InteractionType);

	public string InstantInteractionHint => null;

	public string HoldingInteractionHint => null;

	public bool EnableBoxColliders
	{
		set
		{
		}
	}

	private void Start()
	{
	}

	private void Initialize()
	{
	}

	public void AddBox(int boxID, Box box)
	{
	}

	public Box TakeBoxFromRack()
	{
		return null;
	}

	public void RemoveFromRackManagerWhileCarrying()
	{
	}

	public void AddBackToRackManagerAfterPlaced()
	{
	}

	private void SetLabel()
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
