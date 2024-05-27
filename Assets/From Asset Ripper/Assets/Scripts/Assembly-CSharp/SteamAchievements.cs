using System;
using UnityEngine;

public class SteamAchievements : MonoBehaviour
{
	[Serializable]
	public class Achievement
	{
		public string AchievementName;

		public int goal;
	}

	[SerializeField]
	private Achievement m_50CheckoutAchievement;

	[SerializeField]
	private Achievement m_100CheckoutAchievement;

	[SerializeField]
	private Achievement m_PurchasedAllSectionsAchievement;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnCompletedCheckout()
	{
	}

	private void OnSectionPurchased(int id)
	{
	}
}
