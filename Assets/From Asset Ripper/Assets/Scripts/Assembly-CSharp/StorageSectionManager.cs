using System;
using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class StorageSectionManager : Singleton<StorageSectionManager>
{
	[SerializeField]
	private float m_StorageSectionAnimationInterval;

	private StorageSection[] m_StorageSections;

	private Queue<int> m_StorageSectionAnimationQueue;

	public Action onStoragePurchased;

	public Action<int> onStorageSectionPurchased;

	public Action onDisabled;

	private int m_StorageUpgradeLevel
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
