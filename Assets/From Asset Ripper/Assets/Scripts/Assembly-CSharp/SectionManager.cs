using System;
using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class SectionManager : Singleton<SectionManager>
{
	[SerializeField]
	private float m_SectionAnimationInterval;

	private Section[] m_Sections;

	private Queue<int> m_SectionAnimationQueue;

	public Action<int> onSectionPurchased;

	public Action onDisabled;

	private int m_StoreUpgradeLevel
	{
		get
		{
			return 0;
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

	private void OnDisable()
	{
	}

	public void UpgradeStore()
	{
	}

	private void PlayAnimations()
	{
	}

	private void LoadUpgrade()
	{
	}
}
