using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_InputField))]
public class MoneyInputRestrictor : MonoBehaviour
{
	private TMP_InputField m_InputField;

	private string lastText;

	private void Awake()
	{
	}

	private void OnSelect(string str)
	{
	}

	private void OnEndEdit(string text)
	{
	}
}
