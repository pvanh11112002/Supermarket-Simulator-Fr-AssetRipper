public class FurnitureInteraction : Interaction
{
	private Furniture m_Furniture;

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

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnUse(bool down)
	{
	}

	private void OnRotate(bool clockvise)
	{
	}

	private void OnClose()
	{
	}

	private void PlaceFurniture()
	{
	}

	private void DefaultHint(bool show)
	{
	}
}
