using MyBox;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAimCanvas : Singleton<PlayerAimCanvas>
{
	[SerializeField]
	private GameObject m_AimIndicator;

	private Image aim;

	public bool EnableAimIndicator
	{
		set
		{
		}
	}

	public Color Color
	{
		set
		{
		}
	}

	private void Start()
	{
	}
}
