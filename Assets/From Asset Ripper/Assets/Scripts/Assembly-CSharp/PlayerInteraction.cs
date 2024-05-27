using System;
using MyBox;
using UnityEngine;

public class PlayerInteraction : Singleton<PlayerInteraction>
{
	[SerializeField]
	private LayerMask m_InteractableLayer;

	[SerializeField]
	private float m_InteractionDistance;

	[SerializeField]
	private float m_InteractionRange;

	[SerializeField]
	private float m_HoldingInteractionTime;

	[SerializeField]
	private float m_MaxHoldingTimeForInstantInteraction;

	private Camera m_MainCamera;

	private RaycastHit m_Hit;

	private Ray m_Ray;

	private bool m_Use;

	private bool m_Holding;

	private float m_HoldingPercentage;

	private float m_HoldingTime;

	private bool m_InInteraction;

	private IInteractable m_CurrentInteractable;

	private IInteractable m_InteractableOnUseStarted;

	private Interaction[] m_Interactions;

	private bool m_Paused;

	public Action<bool> onUse;

	public Action<bool> onTake;

	public Action onApproveCheckout;

	public Action onFinishDay;

	public Action onDrop;

	public Action onCancel;

	public Action onThrow;

	public Action onClose;

	public Action<bool> onSell;

	public Action<bool> onRotate;

	public Action<bool> onHoldingStateChanged;

	public Action<float> onHolding;

	public Action onDisable;

	public Action<Display> onDisplayMoved;

	public Action<bool> onStartedMovingFurniture;

	public bool Use => false;

	public bool InInteraction => false;

	public bool Pause
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public IInteractable CurrentInteractable
	{
		set
		{
		}
	}

	private bool Holding
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void SetCurrentInteraction(InteractactableType type)
	{
	}

	public void InteractionEnd(Interaction interaction)
	{
	}

	private void Raycast()
	{
	}

	private void SetCurrentInteractable(IInteractable interactable)
	{
	}

	public void Interact(bool holdInteraction = false)
	{
	}

	private void CheckForHoldingInteraction()
	{
	}

	private void CheckForInstantInteractionAfterHold()
	{
	}
}
