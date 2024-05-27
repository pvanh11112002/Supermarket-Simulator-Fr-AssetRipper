using System;

public class ComputerInteraction : Interaction
{
	public static ComputerInteraction Instance;

	private Computer m_Computer;

	private bool m_PlacingMode;

	public Action onComputerInteractionStopped;

	public Action onDestroyed;

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

	public bool PlacingMode
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

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnUse(bool down)
	{
	}

	private void OnCancel()
	{
	}

	private void OnRotate(bool clockvise)
	{
	}

	private void PlaceComputer()
	{
	}

	private void DefaultHint(bool show)
	{
	}

	public void MovingHints(bool show)
	{
	}
}
