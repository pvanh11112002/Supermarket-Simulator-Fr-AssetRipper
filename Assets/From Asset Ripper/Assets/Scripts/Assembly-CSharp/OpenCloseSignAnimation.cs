using UnityEngine;

public class OpenCloseSignAnimation : MonoBehaviour
{
	[Header("Signs")]
	[SerializeField]
	private Transform m_OpenSign;

	[SerializeField]
	private Transform m_CloseSign;

	[Header("Animaton")]
	[SerializeField]
	private Vector3 m_DefaultScale;

	[SerializeField]
	private float m_PunchForce;

	[SerializeField]
	private float m_PunchDuration;

	[SerializeField]
	private float m_ScaleDuration;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void LoadStoreStatusSign()
	{
	}

	private void ChangeSign(bool opened)
	{
	}
}
