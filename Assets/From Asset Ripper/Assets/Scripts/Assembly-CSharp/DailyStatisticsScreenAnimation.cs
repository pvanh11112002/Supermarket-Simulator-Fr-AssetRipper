using UnityEngine;

public class DailyStatisticsScreenAnimation : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup[] m_UIElements;

	[SerializeField]
	private float m_FadeInDurationPerElement;

	[SerializeField]
	private float m_IntervalBetweenElements;

	[SerializeField]
	private float m_FadeOutDurationOfTheScreen;

	public void Open()
	{
	}

	public void Close()
	{
	}
}
