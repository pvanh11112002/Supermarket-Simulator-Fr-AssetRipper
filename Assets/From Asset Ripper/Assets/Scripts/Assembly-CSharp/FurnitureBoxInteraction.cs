using MyBox;
using UnityEngine;

public class FurnitureBoxInteraction : Interaction
{
	[SerializeField]
	private float m_MaxRaycastDistance;

	[SerializeField]
	private LayerMask m_BoxInteractionLayer;

	[Separator("Furniture Spawn Animation", false)]
	[SerializeField]
	private float m_ScaleUpSpeed;

	[Separator("Furniture Selling", false)]
	[SerializeField]
	private float m_HoldingInteractionTime;

	private FurnitureBox m_Box;

	private bool m_PlacingMode;

	private TrashBin m_CurrentTrashBin;

	private Camera m_MainCamera;

	private RaycastHit m_Hit;

	private Ray m_Ray;

	private bool m_HoldingSellButton;

	private float m_HoldingTime;

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

	private void OnDrop()
	{
	}

	private void OnRotate(bool clockvise)
	{
	}

	private void OnCancel()
	{
	}

	private void OnSell(bool started)
	{
	}

	private void OnThrow()
	{
	}

	private void CheckForInteraction()
	{
	}

	private void CheckHoldingInteraction()
	{
	}

	private void OpenBox()
	{
	}

	private void DropBox()
	{
	}

	private void ThrowIntoTrashBin()
	{
	}

	private void SellFurniture()
	{
	}

	private void SetCurrentTrashBin(TrashBin trashBin)
	{
	}

	private void DefaultHints(bool show)
	{
	}

	private void PlacingModeHints(bool show)
	{
	}

	private void TrashBinHint(bool show)
	{
	}
}
