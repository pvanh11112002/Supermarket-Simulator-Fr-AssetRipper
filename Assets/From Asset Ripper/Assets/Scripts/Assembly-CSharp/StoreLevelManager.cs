using System;
using MyBox;
using UnityEngine;

public class StoreLevelManager : Singleton<StoreLevelManager>
{
	[Serializable]
	public class LevelRequirement
	{
		public int RequiredPoints;
	}

	[SerializeField]
	private LevelRequirement[] m_LevelRequirements;

	public Action<int, bool> onPointChanged;

	public Action<bool> onLevelChanged;

	public Action onDisabled;

	public int CurrentPoint
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int CurrentLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool MaxLevel => false;

	public bool IsLastLevel => false;

	public bool IsFirstLevel => false;

	public int NextLevelRequirement => 0;

	private void OnDisable()
	{
	}

	public void AddPoint(int amount)
	{
	}

	public void RemovePoint(int amount)
	{
	}

	private void CheckLevelChange()
	{
	}
}
