using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

public class AutoPaidBillsCanvas : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003CShowAutoPaidBills_003Eg__WaitForNextFrame_007C10_0_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AutoPaidBillsCanvas _003C_003E4__this;

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
		public _003C_003CShowAutoPaidBills_003Eg__WaitForNextFrame_007C10_0_003Ed__12(int _003C_003E1__state)
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
	private CanvasGroup m_CanvasGroup;

	[SerializeField]
	private LocalizeStringEvent m_BillInfoLocalizedText;

	[SerializeField]
	private TMP_Text m_BillInfoText;

	[SerializeField]
	private ContentSizeFitter m_BillsContent;

	[SerializeField]
	private ContentSizeFitter m_Window;

	[Space]
	[SerializeField]
	private float m_FadeInDuration;

	[SerializeField]
	private float m_FadeOutDuration;

	[SerializeField]
	private float m_LifetimeDuration;

	[SerializeField]
	[Space]
	private Color m_NegativeTextColor;

	private List<LocalizeStringEvent> m_BillTexts;

	public void ShowAutoPaidBills(List<PlayerPaymentData> bills)
	{
	}

	private void RemoveExtraTexts()
	{
	}

	[IteratorStateMachine(typeof(_003C_003CShowAutoPaidBills_003Eg__WaitForNextFrame_007C10_0_003Ed__12))]
	[CompilerGenerated]
	private IEnumerator _003CShowAutoPaidBills_003Eg__WaitForNextFrame_007C10_0()
	{
		return null;
	}
}
