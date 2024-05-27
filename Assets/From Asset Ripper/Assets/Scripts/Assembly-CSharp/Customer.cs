using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class Customer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CExitStore_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Customer _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CExitStore_003Ed__64(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CMoveTo_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Customer _003C_003E4__this;

		public Vector3 target;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CMoveTo_003Ed__61(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CProcessShoppingList_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Customer _003C_003E4__this;

		private List<int>.Enumerator _003C_003E7__wrap1;

		private int _003CproductID_003E5__3;

		private DisplaySlot _003CtargetDisplaySlot_003E5__4;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CProcessShoppingList_003Ed__66(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CShopping_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Customer _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CShopping_003Ed__60(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CTakeProductsFromDisplay_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Customer _003C_003E4__this;

		public DisplaySlot displaySlot;

		public int productID;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CTakeProductsFromDisplay_003Ed__62(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitForAvailableCheckout_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Customer _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWaitForAvailableCheckout_003Ed__65(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CWalkAroundIdle_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DisplaySlot displaySlot;

		public Customer _003C_003E4__this;

		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CWalkAroundIdle_003Ed__63(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	public const float m_CreditCardPaymentChance = 0.5f;

	private const float m_IdleWaitingDuration = 3f;

	private const float m_ExpensiveProductAnimationDuration = 2f;

	private const float m_RotatingToDisplayTime = 0.3f;

	private const float m_TakingProductTime = 0.2f;

	private const float m_RotationSmoothness = 5f;

	private readonly Vector2 m_ExtraPurchaseAmount;

	private readonly Vector2 m_WaitingIdleRange;

	[SerializeField]
	private CustomerAnimator m_Animator;

	[SerializeField]
	private NavMeshAgent m_Agent;

	[SerializeField]
	private Transform m_RightHand;

	[SerializeField]
	private GameObject m_ShoppingBag;

	[SerializeField]
	private float m_PickingProductAnimationDuration;

	[SerializeField]
	private int m_StorePointPenalty;

	private ItemQuantity m_ShoppingList;

	private ItemQuantity m_ShoppingCart;

	private Product m_CurrentItem;

	private bool m_IsPickingUp;

	private bool m_IsPlayingAnimation;

	private bool m_IsSatisfiedCustomer;

	private bool m_StartedShopping;

	private Checkout m_Checkout;

	private GameObject m_PaymentMoney;

	private GameObject m_PaymentCard;

	private Display m_TargetDisplay;

	private bool m_InCheckout;

	private bool m_HandingPayment;

	private bool m_PaymentViaCreditCard;

	public ItemQuantity ShoppingCart
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ItemQuantity ShoppingList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsSatisfied
	{
		set
		{
		}
	}

	public bool IsPlayingAnimation
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool PaymentViaCreditCard
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HandingPayment => false;

	private bool IsShopping
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool PurchasedProductOnce(int productID)
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void GoToStore(Vector3 doorPosition)
	{
	}

	public void StartShopping()
	{
	}

	public void HoldProduct()
	{
	}

	public void ReleaseProduct()
	{
	}

	public void MoveCheckoutPosition(Checkout checkout, TransformData queuePosition, bool firstCustomer)
	{
	}

	public void InteractWithCheckout()
	{
	}

	public void HandMoney(bool play)
	{
	}

	public GameObject HandCard(bool play)
	{
		return null;
	}

	public void DoPayment(bool viaCreditCard)
	{
	}

	public void FinishShopping(bool shortchange = false)
	{
	}

	[IteratorStateMachine(typeof(_003CShopping_003Ed__60))]
	private IEnumerator Shopping()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMoveTo_003Ed__61))]
	private IEnumerator MoveTo(Vector3 target)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CTakeProductsFromDisplay_003Ed__62))]
	private IEnumerator TakeProductsFromDisplay(DisplaySlot displaySlot, int productID)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWalkAroundIdle_003Ed__63))]
	private IEnumerator WalkAroundIdle(DisplaySlot displaySlot)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CExitStore_003Ed__64))]
	private IEnumerator ExitStore()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitForAvailableCheckout_003Ed__65))]
	private IEnumerator WaitForAvailableCheckout()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CProcessShoppingList_003Ed__66))]
	private IEnumerator ProcessShoppingList()
	{
		return null;
	}

	private bool TakeProduct(DisplaySlot displaySlot, int productID)
	{
		return false;
	}

	private void GoToCheckout()
	{
	}

	private void CheckForProductsMissing(bool shortchange)
	{
	}

	private void OnDisplayMoved(Display display)
	{
	}

	private void OnPlayerInteractionDisabled()
	{
	}

	private void OnCheckoutBoxed(Checkout boxedCheckout)
	{
	}

	private void OnCheckoutMoved(Checkout movedCheckout)
	{
	}
}
