using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class Checkout : MonoBehaviour, IInteractable
{
	public enum State
	{
		IDLE = 0,
		SCANNING = 1,
		CUSTOMER_HANDING_CASH = 2,
		CUSTOMER_HANDING_CARD = 3,
		PAYMENT_CREDIT_CARD = 4,
		PLACING = 5,
		PAYMENT_CASH = 6,
		CASHIER = 7
	}

	private const float m_MovingProductToBagTime = 1f;

	private const float m_ChangeTolerance = 0.5f;

	private const float m_MaxPercentageOfTotalPriceForMissingChange = 0.5f;

	[SerializeField]
	private Queue m_Queue;

	[SerializeField]
	private CheckoutBelt m_Belt;

	[SerializeField]
	private CheckoutScreen m_CheckoutScreen;

	[SerializeField]
	private CheckoutDrawer m_CheckoutDrawer;

	[SerializeField]
	private CheckoutChangeManager m_ChangeManager;

	[SerializeField]
	private Animator m_CashRegisterAnimator;

	[SerializeField]
	private Transform m_CheckoutPosition;

	[SerializeField]
	private Transform m_ShoppingBag;

	[SerializeField]
	private FurniturePlacingMode m_PlacingMode;

	[SerializeField]
	private int m_ID;

	[SerializeField]
	private AutomatedCheckout m_AutomatedCheckout;

	[SerializeField]
	[Separator("Cash Register", false)]
	private CashRegisterScreen m_RegisterScreen;

	[SerializeField]
	private Color m_CorrectChangeColor;

	[SerializeField]
	private Color m_WrongChangeColor;

	[SerializeField]
	private GameObject m_NoEnoughMoneyIndicator;

	[SerializeField]
	private float m_NoEnoughMoneyIndicatorLifetime;

	[Separator("Cash Register", false)]
	[SerializeField]
	private PosTerminal m_PosTerminal;

	[Separator("Store Point", false)]
	[SerializeField]
	private int m_StorePointPerCheckout;

	[SerializeField]
	private int m_PointPenaltyOnLowChange;

	[SerializeField]
	private float m_PointPenaltyChanceOnLowChange;

	private List<Customer> m_Customers;

	private ItemQuantity m_CurrentShoppingCart;

	private bool m_InInteraction;

	private State m_State;

	private float m_TotalPrice;

	private float m_ReceivedPayment;

	private float m_CorrectChange;

	private float m_CollectedChange;

	private bool m_CollectingChange;

	private CheckoutData m_CheckoutData;

	private State m_StateBeforeMoving;

	private bool m_PosInteraction;

	private bool m_HasCashier;

	private bool m_CanApproveChange => false;

	private bool m_ReachedMinChange => false;

	public int ID => 0;

	public InteractactableType Type => default(InteractactableType);

	public bool ContinousInteraction => false;

	public bool Full => false;

	public bool InInteraction
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public State CurrentState => default(State);

	public CheckoutBelt Belt => null;

	public float TotalPrice
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public string InstantInteractionHint => null;

	public string HoldingInteractionHint => null;

	public bool CollectingChange => false;

	public InteractionType InteractionType => default(InteractionType);

	public CheckoutData Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public FurniturePlacingMode PlacingMode => null;

	public bool PosInteraction
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasCashier => false;

	public int CashierID => 0;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	public void Subscribe(Customer customer)
	{
	}

	public void Unsubscribe(Customer customer)
	{
	}

	public bool InstantInteract()
	{
		return false;
	}

	public bool HoldingInteract()
	{
		return false;
	}

	public void StartCheckout(ItemQuantity shoppingCart)
	{
	}

	public void ProductScanned(Product product, bool cashier = false)
	{
	}

	public void FinishedScanning()
	{
	}

	public void TookCustomersCash(float payment)
	{
	}

	public void TookCustomersCard()
	{
	}

	public void AddOrRemoveChange(MoneyPack money, bool add)
	{
	}

	public bool TryFinishingCashPayment()
	{
		return false;
	}

	public bool TryFinishingCardPayment(float posTotal)
	{
		return false;
	}

	public void StartPlacingMode()
	{
	}

	public void BoxUp()
	{
	}

	public void PlaceCheckout()
	{
	}

	public void Despawn()
	{
	}

	public void AddCashier(Cashier cashier)
	{
	}

	public void RemoveCashier()
	{
	}

	public void CashierTookPayment(bool paymentViaCreditCard)
	{
	}

	public void CashierCompletedCheckout()
	{
	}

	private void AskForCustomer()
	{
	}

	private void ChangeState(State newState)
	{
	}

	private void UpdateQueue()
	{
	}

	private void ResetCashRegister()
	{
	}

	private void ClearCheckout()
	{
	}

	private void OnDayFinished()
	{
	}

	private void UnsubscribeDayCycle()
	{
	}

	private void RefreshCurrentCheckout()
	{
	}

	private void RequestCashier()
	{
	}
}
