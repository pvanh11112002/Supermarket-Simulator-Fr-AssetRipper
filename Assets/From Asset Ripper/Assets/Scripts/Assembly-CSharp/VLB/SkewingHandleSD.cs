using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VLB
{
	[HelpURL("http://saladgamer.com/vlb-doc/comp-skewinghandle-sd/")]
	[ExecuteInEditMode]
	public class SkewingHandleSD : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCoUpdate_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SkewingHandleSD _003C_003E4__this;

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
			public _003CCoUpdate_003Ed__9(int _003C_003E1__state)
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

		public const string ClassName = "SkewingHandleSD";

		public VolumetricLightBeamSD volumetricLightBeam;

		public bool shouldUpdateEachFrame;

		public bool IsAttachedToSelf()
		{
			return false;
		}

		public bool CanSetSkewingVector()
		{
			return false;
		}

		public bool CanUpdateEachFrame()
		{
			return false;
		}

		private bool ShouldUpdateEachFrame()
		{
			return false;
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CCoUpdate_003Ed__9))]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		private void SetSkewingVector()
		{
		}
	}
}
