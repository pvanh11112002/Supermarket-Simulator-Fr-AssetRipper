using UnityEngine;
using UnityEngine.UI;

public class HoldingInteractionIndicator : MonoBehaviour
{
	[SerializeField]
	private Image m_Indicator;

	[SerializeField]
	private CanvasGroup m_IndicatorCanvasGroup;

	[SerializeField]
	private float m_MinHoldingPercentageToShowIndicator;

	private void Start()
	{
	}

	private void OnStateChanged(bool started)
	{
	}

	private void OnHolding(float percentage)
	{
	}

	private void OnInteractionDisabled()
	{
	}
}
