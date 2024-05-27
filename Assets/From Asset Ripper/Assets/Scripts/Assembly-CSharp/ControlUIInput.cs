using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ControlUIInput : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CClearText_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Text textToCLead;

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
		public _003CClearText_003Ed__13(int _003C_003E1__state)
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

	public Text getAxisText;

	public Text getAxisSpeedText;

	public Text getAxisYText;

	public Text getAxisYSpeedText;

	public Text downRightText;

	public Text downDownText;

	public Text downLeftText;

	public Text downUpText;

	public Text rightText;

	public Text downText;

	public Text leftText;

	public Text upText;

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CClearText_003Ed__13))]
	private IEnumerator ClearText(Text textToCLead)
	{
		return null;
	}
}
