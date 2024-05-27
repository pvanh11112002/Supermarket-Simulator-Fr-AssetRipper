using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TurnTheGameOn.SimpleTrafficSystem
{
	public class AITrafficSpawnPoint : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CRegisterSpawnPoint_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AITrafficSpawnPoint _003C_003E4__this;

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
			public _003CRegisterSpawnPoint_003Ed__20(int _003C_003E1__state)
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

		public AITrafficWaypoint waypoint;

		public Material runtimeMaterial;

		public bool isTrigger { get; private set; }

		public bool isVisible { get; private set; }

		public Transform transformCached { get; private set; }

		public int assignedIndex { get; private set; }

		private void OnEnable()
		{
		}

		private void Awake()
		{
		}

		[IteratorStateMachine(typeof(_003CRegisterSpawnPoint_003Ed__20))]
		private IEnumerator RegisterSpawnPoint()
		{
			return null;
		}

		private void OnBecameInvisible()
		{
		}

		private void OnBecameVisible()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		public bool CanSpawn()
		{
			return false;
		}
	}
}
