using UnityEngine;

[CreateAssetMenu(fileName = "New Expenses Settings", menuName = "Scriptable Objects/Expenses Settings")]
public class ExpensesSO : ScriptableObject
{
	public float IndoorLightExpensePerSecond;

	public float SmallFridgeExpensePerSecond;

	public float LargeFridgeExpensePerSecond;

	public float FreezerExpensePerSecond;

	[Space]
	public float DefaultDailyRent;

	[Space]
	public int BillPaymentDueDate;
}
