using System.Collections.Generic;
using UnityEngine;

public class GrowthTab : MonoBehaviour
{
	[SerializeField]
	[Header("Components")]
	private GrowthSectionItem m_GrowthSectionItemPrefab;

	[SerializeField]
	private Transform m_GrowthSectionsContent;

	[SerializeField]
	private List<GrowthSectionItem> m_GrowthSectionItems;

	[SerializeField]
	private GameObject m_PurchasedAllText;

	private void Start()
	{
	}

	private void OnPurchasedSection(int id)
	{
	}

	private void OnSectionManagerDisabled()
	{
	}

	private void CheckSecitonsCount()
	{
	}
}
