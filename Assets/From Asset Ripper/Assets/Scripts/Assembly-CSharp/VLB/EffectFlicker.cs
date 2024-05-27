using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VLB
{
	[HelpURL("http://saladgamer.com/vlb-doc/comp-effect-flicker/")]
	[AddComponentMenu("VLB/Common/Effect Flicker")]
	public class EffectFlicker : EffectAbstractBase
	{
		[CompilerGenerated]
		private sealed class _003CCoChangeIntensity_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EffectFlicker _003C_003E4__this;

			public float nextIntensity;

			public float expectedDuration;

			private float _003Cvelocity_003E5__2;

			private float _003Ct_003E5__3;

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
			public _003CCoChangeIntensity_003Ed__13(int _003C_003E1__state)
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
		private sealed class _003CCoFlicker_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EffectFlicker _003C_003E4__this;

			private float _003CremainingDuration_003E5__2;

			private float _003CfreqDuration_003E5__3;

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
			public _003CCoFlicker_003Ed__12(int _003C_003E1__state)
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
		private sealed class _003CCoUpdate_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public EffectFlicker _003C_003E4__this;

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
			public _003CCoUpdate_003Ed__11(int _003C_003E1__state)
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

		public new const string ClassName = "EffectFlicker";

		[Range(1f, 60f)]
		public float frequency;

		public bool performPauses;

		[MinMaxRange(0f, 10f)]
		public MinMaxRangeFloat flickeringDuration;

		[MinMaxRange(0f, 10f)]
		public MinMaxRangeFloat pauseDuration;

		public bool restoreIntensityOnPause;

		[MinMaxRange(-5f, 5f)]
		public MinMaxRangeFloat intensityAmplitude;

		[Range(0f, 0.25f)]
		public float smoothing;

		private float m_CurrentAdditiveIntensity;

		public override void InitFrom(EffectAbstractBase source)
		{
		}

		protected override void OnEnable()
		{
		}

		[IteratorStateMachine(typeof(_003CCoUpdate_003Ed__11))]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoFlicker_003Ed__12))]
		private IEnumerator CoFlicker()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CCoChangeIntensity_003Ed__13))]
		private IEnumerator CoChangeIntensity(float expectedDuration, float nextIntensity)
		{
			return null;
		}
	}
}
