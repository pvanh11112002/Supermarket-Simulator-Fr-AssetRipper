using System.Collections.Generic;
using MyBox;
using UnityEngine;
using UnityEngine.Localization.Components;

public class InteractionHintsManager : Singleton<InteractionHintsManager>
{
	[SerializeField]
	private InputActionName m_InputActionName;

	[SerializeField]
	private Transform m_HintsWindow;

	[SerializeField]
	private LocalizeStringEvent m_HintTextPrefab;

	private Dictionary<int, LocalizeStringEvent> Hints;

	public void AddHint(InputActionID actionID, string actionName, string localizationEntryKey)
	{
	}

	public void RemoveHint(InputActionID actionID)
	{
	}

	public void Clear()
	{
	}

	private void UpdateVisibility()
	{
	}
}
