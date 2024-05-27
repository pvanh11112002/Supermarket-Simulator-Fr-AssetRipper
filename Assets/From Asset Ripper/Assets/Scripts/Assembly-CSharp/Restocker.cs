using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class Restocker : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDropBox_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Restocker _003C_003E4__this;

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
		public _003CDropBox_003Ed__30(int _003C_003E1__state)
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
	private sealed class _003CGoTo_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Restocker _003C_003E4__this;

		public Vector3 target;

		public Quaternion rotation;

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
		public _003CGoTo_003Ed__36(int _003C_003E1__state)
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
	private sealed class _003CGoToWaiting_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Restocker _003C_003E4__this;

		public RestockerState state;

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
		public _003CGoToWaiting_003Ed__42(int _003C_003E1__state)
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
	private sealed class _003CMoveTo_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Restocker _003C_003E4__this;

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
		public _003CMoveTo_003Ed__37(int _003C_003E1__state)
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
	private sealed class _003CPerformRestocking_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Restocker _003C_003E4__this;

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
		public _003CPerformRestocking_003Ed__31(int _003C_003E1__state)
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
	private sealed class _003CPickUpBox_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Restocker _003C_003E4__this;

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
		public _003CPickUpBox_003Ed__39(int _003C_003E1__state)
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
	private sealed class _003CPlaceBoxToRack_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Restocker _003C_003E4__this;

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
		public _003CPlaceBoxToRack_003Ed__32(int _003C_003E1__state)
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
	private sealed class _003CPlaceProducts_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Restocker _003C_003E4__this;

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
		public _003CPlaceProducts_003Ed__40(int _003C_003E1__state)
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
	private sealed class _003CRotateTo_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Restocker _003C_003E4__this;

		public Quaternion rotation;

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
		public _003CRotateTo_003Ed__38(int _003C_003E1__state)
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
	private sealed class _003CThrowBoxToTrashBin_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Restocker _003C_003E4__this;

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
		public _003CThrowBoxToTrashBin_003Ed__33(int _003C_003E1__state)
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
	private sealed class _003CTryRestocking_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Restocker _003C_003E4__this;

		private List<int> _003CproductsInInventory_003E5__2;

		private int _003Cj_003E5__3;

		private bool _003CfoundAvailableRack_003E5__4;

		private bool _003CfoundAvailableDisplaySlot_003E5__5;

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
		public _003CTryRestocking_003Ed__29(int _003C_003E1__state)
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
	private sealed class _003CTryRestockingWhileWaitingForEmptyRack_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Restocker _003C_003E4__this;

		private bool _003CfoundAvailableDisplaySlot_003E5__2;

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
		public _003CTryRestockingWhileWaitingForEmptyRack_003Ed__34(int _003C_003E1__state)
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

	private const float m_RotationSmoothness = 5f;

	private const float m_RotatingTime = 0.3f;

	private const float m_BoxTransitionTime = 0.3f;

	private const float m_PlacingProductsInterval = 0.2f;

	private const float m_TaskCheckInterval = 5f;

	private const float m_FullRacksWarningInterval = 20f;

	[SerializeField]
	private NavMeshAgent m_Agent;

	[SerializeField]
	private Transform m_BoxHolder;

	[SerializeField]
	private RestockerAnimationController m_Animation;

	[Range(0f, 1f)]
	[SerializeField]
	[Space]
	private float m_MinFillRateForDisplaySlotsToRestock;

	private int m_RestockerID;

	private int m_TargetProductID;

	private DisplaySlot m_TargetDisplaySlot;

	private RackSlot m_TargetRackSlot;

	private Box m_Box;

	private LayerMask m_CurrentBoxLayer;

	private bool m_CarryingBox;

	private RestockerState m_State;

	private bool m_CheckTasks;

	private float m_LastTaskCheckTime;

	private float m_LastFullRacksWarningTime;

	public int RestockerID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool CarryingBox
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Update()
	{
	}

	public void DropTheBox()
	{
	}

	[IteratorStateMachine(typeof(_003CTryRestocking_003Ed__29))]
	private IEnumerator TryRestocking()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDropBox_003Ed__30))]
	private IEnumerator DropBox()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPerformRestocking_003Ed__31))]
	private IEnumerator PerformRestocking()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlaceBoxToRack_003Ed__32))]
	private IEnumerator PlaceBoxToRack()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CThrowBoxToTrashBin_003Ed__33))]
	private IEnumerator ThrowBoxToTrashBin()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CTryRestockingWhileWaitingForEmptyRack_003Ed__34))]
	private IEnumerator TryRestockingWhileWaitingForEmptyRack()
	{
		return null;
	}

	private void ResetTargets()
	{
	}

	[IteratorStateMachine(typeof(_003CGoTo_003Ed__36))]
	private IEnumerator GoTo(Vector3 target, Quaternion rotation)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CMoveTo_003Ed__37))]
	private IEnumerator MoveTo(Vector3 target)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRotateTo_003Ed__38))]
	private IEnumerator RotateTo(Quaternion rotation)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPickUpBox_003Ed__39))]
	private IEnumerator PickUpBox()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CPlaceProducts_003Ed__40))]
	private IEnumerator PlaceProducts()
	{
		return null;
	}

	private void PlaceBox()
	{
	}

	[IteratorStateMachine(typeof(_003CGoToWaiting_003Ed__42))]
	private IEnumerator GoToWaiting(RestockerState state)
	{
		return null;
	}

	private bool GetAvailableDisplaySlotToRestock()
	{
		return false;
	}

	private bool IsDisplaySlotAvailableToRestock(DisplaySlot displaySlot)
	{
		return false;
	}

	private bool CheckForAvailableRackSlotToTakeBox()
	{
		return false;
	}

	private bool CheckForAvailableRackSlotToPlaceBox()
	{
		return false;
	}

	private bool IsRackSlotStillAvailable(RackSlot rackSlot, int targetProductID)
	{
		return false;
	}
}
