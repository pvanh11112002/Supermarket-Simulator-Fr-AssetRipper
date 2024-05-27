using TMPro;
using UnityEngine;

public class MissionSystem : MonoBehaviour
{
	[SerializeField]
	private GameObject m_CheckoutObjectiveCanvas;

	[SerializeField]
	private TMP_Text m_CheckoutObjectiveCounter;

	[SerializeField]
	private int m_CheckoutObjectiveGoal;

	[SerializeField]
	private GameObject m_ShelfObjectiveCanvas;

	[SerializeField]
	private TMP_Text m_ShelfObjectiveCounter;

	[SerializeField]
	private int m_ShelfObjectiveGoal;

	[SerializeField]
	private GameObject m_LicenseObjectiveCanvas;

	[SerializeField]
	private TMP_Text m_LicenseObjectiveCounter;

	[SerializeField]
	private int m_LicenseObjectiveGoal;

	[SerializeField]
	private GameObject m_SecitonObjectiveCanvas;

	[SerializeField]
	private TMP_Text m_SecitonObjectiveCounter;

	[SerializeField]
	private int m_SecitonObjectiveGoal;

	[Space]
	[SerializeField]
	private Color m_CompletedObjectiveTextColor;

	[SerializeField]
	private float m_CompletedObjectiveLifetime;

	public bool CompletedCheckoutObjective => false;

	public bool CompletedShelfObjective => false;

	public bool CompletedLicenseObjective => false;

	public bool CompletedSectionObjective => false;

	private void Start()
	{
	}

	private void StartCheckoutObjective()
	{
	}

	private void OnCheckoutCompleted()
	{
	}

	private void StartShelfObjective()
	{
	}

	private void OnShelfObjectiveCompleted()
	{
	}

	private void StartLicenseObjective()
	{
	}

	private void OnLicensePurchased(int _)
	{
	}

	private void StartSectionObjective()
	{
	}

	private void OnSectionPurchased(int _)
	{
	}

	private bool CheckIfObjectiveCompleted(int goal, int current, TMP_Text counterText)
	{
		return false;
	}

	private void OnObjectiveCompleted()
	{
	}

	public void LookForNewObjective()
	{
	}
}
