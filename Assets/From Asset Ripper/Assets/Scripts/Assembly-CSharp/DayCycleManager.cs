using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MyBox;
using UnityEngine;
using UnityEngine.Rendering;

public class DayCycleManager : Singleton<DayCycleManager>
{
	[CompilerGenerated]
	private sealed class _003CDayCycle_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DayCycleManager _003C_003E4__this;

		public bool newDay;

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
		public _003CDayCycle_003Ed__55(int _003C_003E1__state)
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
	private sealed class _003C_003Cset_LensFlare_003Eg__ReduceIntensity_007C42_0_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DayCycleManager _003C_003E4__this;

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
		public _003C_003Cset_LensFlare_003Eg__ReduceIntensity_007C42_0_003Ed__61(int _003C_003E1__state)
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

	[Separator("Day Length", false)]
	[SerializeField]
	private float m_DayDurationInRealtime;

	[SerializeField]
	private int m_DayDurationInGameTime;

	[Range(5f, 11f)]
	[SerializeField]
	private int m_DayStartingTime;

	[Separator("Lighting", false)]
	[SerializeField]
	private Light m_DirectionalLight;

	[SerializeField]
	private LightingPresetsSO m_LightingPreset;

	[Separator("Lens Flare", false)]
	[SerializeField]
	private LensFlareComponentSRP m_LensFlare;

	[SerializeField]
	private float m_DisablingLensFlarePercentage;

	[SerializeField]
	private float m_DisablingLensFlareSpeed;

	[Separator("Skybox", false)]
	[SerializeField]
	private Material m_SkyboxMaterial;

	[SerializeField]
	private float m_SkyboxRotationSpeed;

	[Separator("Components", false)]
	[SerializeField]
	private NextDayInteraction m_NextDayInteraction;

	private float m_DayDurationInGameTimeInSeconds;

	private float m_DayDurationInReelTimeInSeconds;

	private float m_GameTimeScale;

	private float m_CurrentTimeInFloat;

	private int m_CurrentTimeInSeconds;

	private int m_CurrentTimeInMinutes;

	private int m_CurrentTimeInHours;

	private float m_DayPercentage;

	private bool m_AM;

	private bool m_DayCycling;

	public Action OnTimeChanged;

	public Action OnFullHour;

	public Action OnDayFinished;

	public Action OnStartedNewDay;

	public Action OnDisabled;

	private readonly int tintHash;

	private readonly int exposureHash;

	public int CurrentMinute => 0;

	public int CurrentHour => 0;

	public bool AM => false;

	public int NumberOfDaysSinceLastPriceChange => 0;

	public int CurrentDay
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool EnableFinishingDay
	{
		set
		{
		}
	}

	public float DayPercentage => 0f;

	private bool LensFlare
	{
		set
		{
		}
	}

	private bool m_EndOfDay => false;

	private float CurrentTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	public void StartNextDay()
	{
	}

	public void FinishTheDay()
	{
	}

	public void StartDayCycle()
	{
	}

	private void SetupDay()
	{
	}

	[IteratorStateMachine(typeof(_003CDayCycle_003Ed__55))]
	private IEnumerator DayCycle(bool newDay)
	{
		return null;
	}

	private void UpdateTimer()
	{
	}

	private void UpdateGameTime()
	{
	}

	private void UpdateLighting()
	{
	}

	[IteratorStateMachine(typeof(_003C_003Cset_LensFlare_003Eg__ReduceIntensity_007C42_0_003Ed__61))]
	[CompilerGenerated]
	private IEnumerator _003Cset_LensFlare_003Eg__ReduceIntensity_007C42_0()
	{
		return null;
	}
}
