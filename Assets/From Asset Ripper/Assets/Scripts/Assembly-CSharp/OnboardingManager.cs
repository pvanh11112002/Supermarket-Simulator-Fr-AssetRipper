using System;
using MyBox;
using UnityEngine;

public class OnboardingManager : Singleton<OnboardingManager>
{
	public bool SkipOnboarding;

	public const int OrderGoods = 0;

	public const int PickUpBoxes = 1;

	public const int PlaceProducts = 2;

	public const int TrashBin = 3;

	public const int SetPrice = 4;

	public const int OpenStore = 5;

	public const int WaitForCustomer = 6;

	public const int InteractCheckout = 7;

	public const int Scan = 8;

	public const int TakePayment = 9;

	public const int CollectChange = 10;

	public const int ApproveCheckout = 11;

	public const int WaitForSecondCustomer = 12;

	public const int CompleteScanning = 13;

	public const int TakeCreditCard = 14;

	public const int InteractWithCardReader = 15;

	public const int EnterExactTotal = 16;

	public const int ApproveCardReader = 17;

	public const int StepCount = 18;

	[SerializeField]
	[Separator("Onboarding Indicators", false)]
	private GameObject[] m_OrderGoodsStep;

	[SerializeField]
	private GameObject[] m_PickUpBoxStep;

	[SerializeField]
	private GameObject[] m_PlaceProductsStep;

	[SerializeField]
	private GameObject[] m_TrashBinStep;

	[SerializeField]
	private GameObject[] m_SetPriceStep;

	[SerializeField]
	private GameObject[] m_OpenStoreStep;

	[SerializeField]
	private GameObject[] m_WaitForCustomerStep;

	[SerializeField]
	private GameObject[] m_InteractCheckoutStep;

	[Space]
	[SerializeField]
	private GameObject[] m_ScanStep;

	[SerializeField]
	private GameObject[] m_TakePaymentStep;

	[SerializeField]
	private GameObject[] m_CollectChangeStep;

	[SerializeField]
	private GameObject[] m_ApproveChecoputStep;

	[SerializeField]
	[Space]
	private GameObject[] m_WaitForSecondCustomerStep;

	[SerializeField]
	private GameObject[] m_CompleteScanningStep;

	[SerializeField]
	private GameObject[] m_TakeCreditCardStep;

	[SerializeField]
	private GameObject[] m_InteractWithCardReaderStep;

	[SerializeField]
	private GameObject[] m_EnterExactTotalStep;

	[SerializeField]
	private GameObject[] m_ApproveCardReaderStep;

	[Separator("Components", false)]
	[SerializeField]
	private Transform m_FirstCustomerPosition;

	[SerializeField]
	private Transform m_SetPriceIndicator;

	[SerializeField]
	private Vector3 m_SetPriceIndicatorOffset;

	[Separator("Lights Tutorial", false)]
	[SerializeField]
	private GameObject m_LightsTutorial;

	[SerializeField]
	private int m_TimeToShowLightsTutorial;

	[SerializeField]
	private bool m_AM;

	[Separator("Warning Screens", false)]
	[SerializeField]
	private WarningScreen m_WelcomeScreen;

	[SerializeField]
	private WarningScreen m_ExpensesScreen;

	[SerializeField]
	private WarningScreen m_OverChangeScreen;

	[SerializeField]
	private float m_DelayToShowOverChangeScreen;

	private bool m_ShowingLightsTutorial;

	public Action onOnboardingCompleted;

	public int Step
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool Lights
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool OverChange
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ShowingLights => false;

	public bool Completed => false;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public void NextStep(float waitForNextStep = 0f, bool calledFromLoad = false)
	{
	}

	public void FinishStep(int step)
	{
	}

	private void EnableIndicator(GameObject[] objects, bool enable)
	{
	}

	private void NewDayStarted()
	{
	}

	private void CheckForLightsTutorialTime()
	{
	}

	private void OnDayCycleDisabled()
	{
	}

	public void ShowLightsTutorial(bool show)
	{
	}

	public void ShowOverChangeWarning()
	{
	}
}
