using UnityEngine;

public class Section : MonoBehaviour
{
	[Header("Objects")]
	[SerializeField]
	private GameObject[] m_ToBeDisabled;

	[SerializeField]
	private GameObject[] m_ToBeEnabled;

	[SerializeField]
	[Header("Animation")]
	private float m_AnimationHeightDifference;

	[SerializeField]
	private float m_Speed;

	public void OpenSection(bool playAnimation = true)
	{
	}
}
