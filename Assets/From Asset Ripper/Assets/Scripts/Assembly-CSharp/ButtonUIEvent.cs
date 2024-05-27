using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ButtonUIEvent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CClearText_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CClearText_003Ed__8(int _003C_003E1__state)
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

	public Text downText;

	public Text pressText;

	public Text pressValueText;

	public Text upText;

	public void Down()
	{
	}

	public void Up()
	{
	}

	public void Press()
	{
	}

	public void PressValue(float value)
	{
	}

	[IteratorStateMachine(typeof(_003CClearText_003Ed__8))]
	private IEnumerator ClearText(Text textToCLead)
	{
		return null;
	}
}
