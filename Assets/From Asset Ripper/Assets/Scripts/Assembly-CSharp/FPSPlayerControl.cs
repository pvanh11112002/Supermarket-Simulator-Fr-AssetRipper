using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class FPSPlayerControl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CFlash_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FPSPlayerControl _003C_003E4__this;

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
		public _003CFlash_003Ed__18(int _003C_003E1__state)
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
	private sealed class _003CReload_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FPSPlayerControl _003C_003E4__this;

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
		public _003CReload_003Ed__19(int _003C_003E1__state)
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

	public AudioClip gunSound;

	public AudioClip reload;

	public AudioClip needReload;

	public ParticleSystem shellParticle;

	public GameObject muzzleEffect;

	public GameObject impactEffect;

	public Text armoText;

	private bool inFire;

	private bool inReload;

	private Animator anim;

	private int armoCount;

	private AudioSource audioSource;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void MoveStart()
	{
	}

	public void MoveStop()
	{
	}

	public void GunFire()
	{
	}

	public void TouchPadSwipe(bool value)
	{
	}

	[IteratorStateMachine(typeof(_003CFlash_003Ed__18))]
	private IEnumerator Flash()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CReload_003Ed__19))]
	private IEnumerator Reload()
	{
		return null;
	}
}
