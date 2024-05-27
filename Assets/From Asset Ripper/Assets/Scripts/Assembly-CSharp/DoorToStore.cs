using UnityEngine;

public class DoorToStore : MonoBehaviour
{
	[SerializeField]
	private GameObject m_LockedText;

	[SerializeField]
	private Transform m_Door;

	[SerializeField]
	private float m_OpenDoorAngle;

	[SerializeField]
	private float m_DoorAnimationDuration;

	[SerializeField]
	private int m_SectionIndexToOpenDoor;

	private void Start()
	{
	}

	private void StoreSectionPurchased(int storageUpgradeLevel)
	{
	}

	private void Open(bool open, bool playAnimation)
	{
	}
}
