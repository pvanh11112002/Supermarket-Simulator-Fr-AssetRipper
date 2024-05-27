using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

public class RestockerItem : MonoBehaviour
{
	[SerializeField]
	[Header("Settings")]
	private RestockerSO m_RestockerSetup;

	[Header("Components")]
	[SerializeField]
	private LocalizeStringEvent m_RestockerName;

	[SerializeField]
	private LocalizeStringEvent m_LocalizedDailyWageText;

	[SerializeField]
	private TMP_Text m_DailyWageText;

	[SerializeField]
	private LocalizeStringEvent m_LocalizedHiringCostText;

	[SerializeField]
	private TMP_Text m_HiringCostText;

	[SerializeField]
	private LocalizeStringEvent m_LocalizedStorageObjectiveText;

	[SerializeField]
	private TMP_Text m_StorageObjectiveText;

	[SerializeField]
	private LocalizeStringEvent m_LocalizedRackObjectiveText;

	[SerializeField]
	private TMP_Text m_RackObjectiveText;

	[SerializeField]
	private LocalizeStringEvent m_LocalizedRequiredStoreLevelText;

	[SerializeField]
	private TMP_Text m_RequiredStoreLevelText;

	[SerializeField]
	private Button m_HireButton;

	[SerializeField]
	private Button m_FireButton;

	[Header("Colors")]
	[SerializeField]
	private Color m_CompletedRequirementColor;

	[SerializeField]
	private Color m_IncompletedRequirementColor;

	private bool m_Hired;

	private bool PurchasedRack => false;

	private bool ReachedRequiredLevel => false;

	private bool Hired
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void Hire()
	{
	}

	public void Fire()
	{
	}

	private void Setup()
	{
	}

	private void UpdateStorageObjective()
	{
	}

	private void UpdateRackObjective()
	{
	}

	private void UpdateRequiredStoreLevel(bool _)
	{
	}

	private void MoneyChanged(float _amount, MoneyManager.TransitionType _type)
	{
	}
}
