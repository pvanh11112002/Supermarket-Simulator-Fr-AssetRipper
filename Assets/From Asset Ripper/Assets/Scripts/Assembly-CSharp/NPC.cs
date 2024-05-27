using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMoveTo_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NPC _003C_003E4__this;

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
		public _003CMoveTo_003Ed__10(int _003C_003E1__state)
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

	[SerializeField]
	private Animator m_Animator;

	[SerializeField]
	private NavMeshAgent m_Agent;

	private WaypointNavigator m_WaypointNavigator;

	public WaypointNavigator WaypointNavigator
	{
		set
		{
		}
	}

	public float Speed
	{
		set
		{
		}
	}

	private void Update()
	{
	}

	public void SetDestination(Vector3 target)
	{
	}

	[IteratorStateMachine(typeof(_003CMoveTo_003Ed__10))]
	private IEnumerator MoveTo(Vector3 target)
	{
		return null;
	}
}
