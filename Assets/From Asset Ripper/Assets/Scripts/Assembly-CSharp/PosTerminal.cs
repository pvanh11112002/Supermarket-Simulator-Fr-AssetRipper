using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PosTerminal : MonoBehaviour
{
	[SerializeField]
	private Checkout m_Checkout;

	[SerializeField]
	private GameObject m_PosCam;

	[SerializeField]
	private GraphicRaycaster m_Raycaster;

	[SerializeField]
	private TMP_Text m_InputText;

	[SerializeField]
	private int m_MaxCharLimit;

	[SerializeField]
	private int m_MaxFloatingPointCharLimit;

	[SerializeField]
	private Transform m_CreditCardPlacedPosition;

	[SerializeField]
	private Button[] m_Buttons;

	[Header("Animation")]
	[SerializeField]
	private float m_CreditCardPlacingAnimDuration;

	private float m_Total;

	private bool m_DeleteOnEdit;

	private GameObject m_CurrentCard;

	private bool m_CheckKeyInput;

	public bool EnablePosInteraction
	{
		set
		{
		}
	}

	private void Start()
	{
	}

	public void AddChar(string character)
	{
	}

	public void RemoveCharacter()
	{
	}

	public void Approve()
	{
	}

	public void PlaceCreditCard(GameObject card)
	{
	}

	public void RefreshTerminal()
	{
	}
}
