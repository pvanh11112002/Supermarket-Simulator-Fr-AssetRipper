using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ControlUIEvent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CClearText_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CClearText_003Ed__33(int _003C_003E1__state)
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

	public Text moveStartText;

	public Text moveText;

	public Text moveSpeedText;

	public Text moveEndText;

	public Text touchStartText;

	public Text touchUpText;

	public Text downRightText;

	public Text downDownText;

	public Text downLeftText;

	public Text downUpText;

	public Text rightText;

	public Text downText;

	public Text leftText;

	public Text upText;

	private bool isDown;

	private bool isLeft;

	private bool isUp;

	private bool isRight;

	private void Update()
	{
	}

	public void MoveStart()
	{
	}

	public void Move(Vector2 move)
	{
	}

	public void MoveSpeed(Vector2 move)
	{
	}

	public void MoveEnd()
	{
	}

	public void TouchStart()
	{
	}

	public void TouchUp()
	{
	}

	public void DownRight()
	{
	}

	public void DownDown()
	{
	}

	public void DownLeft()
	{
	}

	public void DownUp()
	{
	}

	public void Right()
	{
	}

	public void Down()
	{
	}

	public void Left()
	{
	}

	public void Up()
	{
	}

	[IteratorStateMachine(typeof(_003CClearText_003Ed__33))]
	private IEnumerator ClearText(Text textToCLead)
	{
		return null;
	}
}
