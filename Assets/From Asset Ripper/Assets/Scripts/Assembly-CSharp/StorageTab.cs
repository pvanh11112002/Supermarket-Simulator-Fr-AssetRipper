using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StorageTab : MonoBehaviour
{
	[SerializeField]
	private GameObject m_LockedUI;

	[SerializeField]
	private GameObject m_UnlockedUI;

	[SerializeField]
	private TMP_Text m_CostText;

	[SerializeField]
	private Button m_PurchaseButton;

	[Space]
	[SerializeField]
	private float m_Cost;

	[Space]
	[SerializeField]
	private Transform m_Door;

	[SerializeField]
	[Header("Components")]
	private StorageSectionItem m_StorageSectionItemPrefab;

	[SerializeField]
	private Transform m_StorageSectionsContent;

	[SerializeField]
	private List<StorageSectionItem> m_StorageSectionItems;

	[SerializeField]
	private GameObject m_PurchasedAllText;

	private bool m_PurcasedStorage
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void Purchase()
	{
	}

	public void CheckStorageSections()
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdatePurchaseButton(float _amount, MoneyManager.TransitionType _type)
	{
	}

	private void UnsubscribeMoneyManager()
	{
	}

	private void OnPurchasedStorageSection(int id)
	{
	}

	private void OnSectionManagerDisabled()
	{
	}

	private void CheckStorageSecitonsCount()
	{
	}
}
