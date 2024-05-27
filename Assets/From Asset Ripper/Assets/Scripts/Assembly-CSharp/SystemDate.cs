using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class SystemDate : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003CStart_003Eg__UpdateTime_007C5_0_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SystemDate _003C_003E4__this;

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
		public _003C_003CStart_003Eg__UpdateTime_007C5_0_003Ed__7(int _003C_003E1__state)
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

	[SerializeField]
	private TMP_Text m_DateText;

	[SerializeField]
	private TMP_Text m_TimeText;

	[SerializeField]
	private float m_UpdateInterval;

	private WaitForSecondsRealtime m_Interval;

	private DateTime m_Time;

	private void Start()
	{
	}

	private void UpdateDate()
	{
	}

	[IteratorStateMachine(typeof(_003C_003CStart_003Eg__UpdateTime_007C5_0_003Ed__7))]
	[CompilerGenerated]
	private IEnumerator _003CStart_003Eg__UpdateTime_007C5_0()
	{
		return null;
	}
}
