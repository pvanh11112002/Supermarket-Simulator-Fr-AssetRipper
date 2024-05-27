using System;
using MyBox;
using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
	[SerializeField]
	private Transform m_PlayerResetTransform;

	private bool m_Enabled;

	public Action<bool, bool> onControllerEnabled;

	public bool Enabled => false;

	private void OnEnable()
	{
	}

	private void OnDayFinished()
	{
	}

	private void OnNewDayStarted()
	{
	}

	public void EnableController(bool enable, bool includeCamera)
	{
	}

	private void OnDayCycleDisabled()
	{
	}
}
