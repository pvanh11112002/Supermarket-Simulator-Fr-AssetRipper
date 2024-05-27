using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_Text))]
public class MoneyText : MonoBehaviour
{
	private const float m_AnimationScale = 0.1f;

	private const float m_AnimationDuration = 0.4f;

	[SerializeField]
	private Color m_PositiveBalanceColor;

	[SerializeField]
	private Color m_NegativeBalanceColor;

	private TMP_Text m_MoneyText;

	[SerializeField]
	private InGameTextIndicator m_MoneyIndicator;

	[SerializeField]
	private Transform m_IndicatorPosition;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void UpdateText(float amount, MoneyManager.TransitionType _type)
	{
	}
}
