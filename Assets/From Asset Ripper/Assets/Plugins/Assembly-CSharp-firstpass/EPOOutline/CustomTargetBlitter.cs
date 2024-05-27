using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace EPOOutline
{
	[ExecuteAlways]
	public class CustomTargetBlitter : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CBlit_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CustomTargetBlitter _003C_003E4__this;

			private WaitForEndOfFrame _003CwaitForEndOfFrame_003E5__2;

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
			public _003CBlit_003Ed__9(int _003C_003E1__state)
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
		private string customTargetName;

		private CommandBuffer buffer;

		private Material blitMaterial;

		private Coroutine blitProcess;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void CheckMaterial()
		{
		}

		[IteratorStateMachine(typeof(_003CBlit_003Ed__9))]
		private IEnumerator Blit()
		{
			return null;
		}
	}
}
