using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	public class AITrafficLightManager : MonoBehaviour
	{
		[Serializable]
		public struct TrafficLightCycle
		{
			public float greenTimer;

			public float yellowTimer;

			public float redtimer;

			public AITrafficLight[] trafficLights;
		}

		[CompilerGenerated]
		private sealed class _003CStartTrafficLightCycles_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AITrafficLightManager _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CStartTrafficLightCycles_003Ed__4(int _003C_003E1__state)
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

		public TrafficLightCycle[] trafficLightCycles;

		private void Start()
		{
		}

		private void EnableRedLights()
		{
		}

		[IteratorStateMachine(typeof(_003CStartTrafficLightCycles_003Ed__4))]
		private IEnumerator StartTrafficLightCycles()
		{
			return null;
		}
	}
}
