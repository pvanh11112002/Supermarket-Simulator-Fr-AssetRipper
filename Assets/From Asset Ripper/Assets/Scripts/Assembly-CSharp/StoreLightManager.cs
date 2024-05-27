using System.Collections.Generic;
using MyBox;

public class StoreLightManager : Singleton<StoreLightManager>
{
	private List<InteriorSpotLight> m_InteriorLights;

	private bool m_IsOn;

	public bool TurnOn
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

	private void Start()
	{
	}

	public void AddLight(InteriorSpotLight light)
	{
	}
}
