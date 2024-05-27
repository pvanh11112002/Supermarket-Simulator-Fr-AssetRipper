using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MyBox;
using UnityEngine;

public class NPCTrafficManager : Singleton<NPCTrafficManager>
{
	[CompilerGenerated]
	private sealed class _003CNPCGeneration_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NPCTrafficManager _003C_003E4__this;

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
		public _003CNPCGeneration_003Ed__11(int _003C_003E1__state)
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
	[Header("Components")]
	private WaypointNavigator[] m_NPCPrefabs;

	[SerializeField]
	private GameObject m_BuildingEnterencesRoot;

	[Header("Settings")]
	[SerializeField]
	private Vector2 m_SpeedRange;

	[SerializeField]
	private AnimationCurve m_DailySpawnRate;

	[SerializeField]
	private Vector2Int m_TripLengthRange;

	private BuildingEnterence[] m_BuildingEnterences;

	private List<WaypointNavigator> m_ActiveNPCs;

	private float m_WaitBeforeSpawningNextNPC => 0f;

	private void Start()
	{
	}

	public void RemoveNPC(WaypointNavigator npc)
	{
	}

	[IteratorStateMachine(typeof(_003CNPCGeneration_003Ed__11))]
	private IEnumerator NPCGeneration()
	{
		return null;
	}

	private void SpawnNPC()
	{
	}
}
