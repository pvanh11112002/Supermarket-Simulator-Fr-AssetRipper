public class RackInteraction : Interaction
{
	private Rack m_Rack;

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
