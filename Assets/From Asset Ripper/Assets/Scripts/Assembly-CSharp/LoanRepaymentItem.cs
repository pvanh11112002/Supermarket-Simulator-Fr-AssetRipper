using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoanRepaymentItem : MonoBehaviour
{
	private const int m_DaysForCloseDueDate = 0;

	[SerializeField]
	[Header("Components")]
	private TMP_Text m_BillDateText;

	[SerializeField]
	private TMP_Text m_DueDateText;

	[SerializeField]
	private TMP_Text m_DaysLeftToDueDateText;

	[SerializeField]
	private TMP_Text m_LatePaymentFeeText;

	[SerializeField]
	private TMP_Text m_BillAmountText;

	[Space]
	[SerializeField]
	private Button m_PayButton;

	[Space]
	[SerializeField]
	private Color m_DefaultDueDateColor;

	[SerializeField]
	private Color m_CloseDueDateColor;

	[SerializeField]
	private Color m_OverDueDateColor;

	private int m_PaymentDueDate;

	private int m_TimeToPaymentDueDate;

	private PlayerPaymentData m_Data;

	public PlayerPaymentData Data => null;

	private bool m_IsDueDateClose => false;

	private int m_DaysPastDue => 0;

	public void Setup(PlayerPaymentData data)
	{
	}

	public void Pay()
	{
	}

	public void CheckDueDate()
	{
	}

	public void UpdatePayButton()
	{
	}

	private void UpdateLatePaymentFee()
	{
	}
}
