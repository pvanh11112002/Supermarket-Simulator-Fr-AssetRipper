using UnityEngine;

public class BoxInteraction : Interaction
{
	[SerializeField]
	private float m_MaxRaycastDistance;

	[SerializeField]
	private LayerMask m_BoxInteractionLayer;

	[SerializeField]
	private float m_ProductInteractionInterval;

	[SerializeField]
	private float m_MinTimeToStartPlacingAfterOpeningBox;

	private Box m_Box;

	private bool m_PlacingMode;

	private bool m_holdingUse;

	private bool m_IsBoxOpen;

	private float m_lastPlaceTime;

	private bool m_holdingTake;

	private float m_lastTakeTime;

	private DisplaySlot m_CurrentDisplaySlot;

	private RackSlot m_CurrentRackSlot;

	private TrashBin m_CurrentTrashBin;

	private Camera m_MainCamera;

	private RaycastHit m_Hit;

	private Ray m_Ray;

	public override bool Enable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public override IInteractable Interactable
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void OnUse(bool down)
	{
	}

	private void OnTake(bool down)
	{
	}

	private void OnDrop()
	{
	}

	private void OnRotate(bool clockvise)
	{
	}

	private void OnCancel()
	{
	}

	private void OnThrow()
	{
	}

	private void OnClose()
	{
	}

	private void CheckForInteraction()
	{
	}

	private void CheckForPlacingItem()
	{
	}

	private void CheckForTakingItem()
	{
	}

	private void DropBox()
	{
	}

	private void PlaceProductToDisplay()
	{
	}

	private void TakeProductFromDisplay()
	{
	}

	private void ThrowIntoTrashBin()
	{
	}

	private void PlaceBoxToRack()
	{
	}

	private void SetCurrentDisplaySlot(DisplaySlot displaySlot)
	{
	}

	private void SetCurrentRackSlot(RackSlot rackSlot)
	{
	}

	private void SetCurrentTrashBin(TrashBin trashBin)
	{
	}

	private void DefaultHints(bool show)
	{
	}

	private void UpdateOpeningBoxHint()
	{
	}

	private void PlacingModeHints(bool show)
	{
	}

	private void PlaceProductHints(bool show)
	{
	}

	private void TrashBinHint(bool show)
	{
	}

	private void RackHints(bool show)
	{
	}
}
