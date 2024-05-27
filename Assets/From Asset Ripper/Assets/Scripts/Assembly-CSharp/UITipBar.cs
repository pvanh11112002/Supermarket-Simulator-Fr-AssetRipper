using DG.Tweening;
using TMPro;
using UnityEngine;

public class UITipBar : MonoBehaviour
{
	[SerializeField]
	private TMP_Text m_TipTxt;

	[SerializeField]
	private CanvasGroup m_Group;

	[SerializeField]
	private float m_Height;

	private RectTransform m_Rect;

	private RectTransform m_Parent;

	private Sequence m_Tween1Sequence;

	private Sequence m_Tween2Sequence;

	private bool isEnable;

	private void Start()
	{
	}

	public void SetTip(string msg, float moveExtra = 0f, float start = 0.2f, float delay = 3f, float end = 0.2f)
	{
	}

	public void SetDisable()
	{
	}

	public void SetEnable()
	{
	}
}
