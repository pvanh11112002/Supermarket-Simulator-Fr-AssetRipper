using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BlinkController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CResetBlink_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BlinkController _003C_003E4__this;

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
		public _003CResetBlink_003Ed__12(int _003C_003E1__state)
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

	public GameObject faceType;

	public SkinnedMeshRenderer skinnedMeshRenderer;

	public float timeBetweenBlinks;

	private float initialScoredTime;

	private float blendshapeWeight;

	private bool blinked;

	public bool isDead;

	private float blinkAcceleration;

	private float maxBlendshapeWeight;

	private CharacterCustomize customizeScript;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CResetBlink_003Ed__12))]
	private IEnumerator ResetBlink()
	{
		return null;
	}

	private void Blink()
	{
	}
}
