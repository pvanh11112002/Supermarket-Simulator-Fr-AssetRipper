using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CheckoutInteraction : Interaction
{
	[CompilerGenerated]
	private sealed class _003C_003CStartRaycastingMoney_003Eg__RaycastingMoney_007C39_0_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CheckoutInteraction _003C_003E4__this;

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
		public _003C_003CStartRaycastingMoney_003Eg__RaycastingMoney_007C39_0_003Ed__54(int _003C_003E1__state)
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
	private sealed class _003C_003CStartRaycastingPosTerminal_003Eg__RaycastingPosTerminal_007C40_0_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CheckoutInteraction _003C_003E4__this;

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
		public _003C_003CStartRaycastingPosTerminal_003Eg__RaycastingPosTerminal_007C40_0_003Ed__55(int _003C_003E1__state)
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
	private sealed class _003C_003CStartScanning_003Eg__Scanning_007C38_0_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CheckoutInteraction _003C_003E4__this;

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
		public _003C_003CStartScanning_003Eg__Scanning_007C38_0_003Ed__53(int _003C_003E1__state)
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

	public static CheckoutInteraction Instance;

	[SerializeField]
	private float m_MaxRaycastDistance_ForScanning;

	[SerializeField]
	private LayerMask m_ProductLayer;

	[SerializeField]
	private LayerMask m_MoneyLayer;

	[SerializeField]
	private LayerMask m_PosTerminalLayer;

	private Checkout m_Checkout;

	private Checkout.State m_State;

	private Product m_CurrentProduct;

	private MoneyPack m_CurrentMoney;

	private PosTerminal m_CurrentPosTerminal;

	private Camera m_MainCamera;

	private RaycastHit m_Hit;

	private Ray m_Ray;

	private bool m_PlacingMode;

	public Action<Checkout> onCheckoutBoxed;

	public Action<Checkout> onCheckoutMoved;

	public override IInteractable Interactable
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override bool Enable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool PlacingMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool CollectingChange => false;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public void CheckoutStateChanged()
	{
	}

	private void OnUse(bool down)
	{
	}

	private void OnTake(bool down)
	{
	}

	private void OnApproveCheckout()
	{
	}

	private void OnCancel()
	{
	}

	private void OnRotate(bool clockvise)
	{
	}

	private void OnClose()
	{
	}

	private void StartScanning()
	{
	}

	private void StartRaycastingMoney()
	{
	}

	private void StartRaycastingPosTerminal()
	{
	}

	private void InteractWithProduct()
	{
	}

	private void InteractWithMoney(bool add)
	{
	}

	private void InteractWithPosTerminal()
	{
	}

	private void InteractWithCustomerPayment()
	{
	}

	private void PlaceCheckout()
	{
	}

	public void DefaultHint(bool show)
	{
	}

	public void ScanningHint(bool show)
	{
	}

	public void PosTerminalHint(bool show)
	{
	}

	public void TakingPaymentHint(bool show)
	{
	}

	public void ChangeHints(bool show)
	{
	}

	public void ApproveHint(bool show)
	{
	}

	public void MovingHints(bool show)
	{
	}

	[IteratorStateMachine(typeof(_003C_003CStartScanning_003Eg__Scanning_007C38_0_003Ed__53))]
	[CompilerGenerated]
	private IEnumerator _003CStartScanning_003Eg__Scanning_007C38_0()
	{
		return null;
	}

	[CompilerGenerated]
	[IteratorStateMachine(typeof(_003C_003CStartRaycastingMoney_003Eg__RaycastingMoney_007C39_0_003Ed__54))]
	private IEnumerator _003CStartRaycastingMoney_003Eg__RaycastingMoney_007C39_0()
	{
		return null;
	}

	[CompilerGenerated]
	[IteratorStateMachine(typeof(_003C_003CStartRaycastingPosTerminal_003Eg__RaycastingPosTerminal_007C40_0_003Ed__55))]
	private IEnumerator _003CStartRaycastingPosTerminal_003Eg__RaycastingPosTerminal_007C40_0()
	{
		return null;
	}
}
