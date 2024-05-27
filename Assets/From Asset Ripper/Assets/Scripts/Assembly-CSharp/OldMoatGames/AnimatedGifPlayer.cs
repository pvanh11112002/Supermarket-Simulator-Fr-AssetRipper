using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace OldMoatGames
{
	[AddComponentMenu("Miscellaneous/Animated GIF Player")]
	public class AnimatedGifPlayer : MonoBehaviour
	{
		public delegate void OnReadyAction();

		public delegate void OnLoadErrorAction();

		[CompilerGenerated]
		private sealed class _003CLoad_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AnimatedGifPlayer _003C_003E4__this;

			private WWW _003Cwww_003E5__2;

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
			public _003CLoad_003Ed__62(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public bool Loop;

		public bool AutoPlay;

		public string FileName;

		public GifPath Path;

		public bool CacheFrames;

		public bool BufferAllFrames;

		public bool UseThreadedDecoder;

		public bool OverrideTimeScale;

		public float TimeScale;

		public Texture2D GifTexture;

		private GifDecoder _gifDecoder;

		private bool _hasFirstFrameBeenShown;

		[SerializeField]
		private Component _targetComponent;

		[SerializeField]
		private int _targetMaterial;

		private bool _cacheFrames;

		private bool _bufferAllFrames;

		private bool _useThreadedDecoder;

		private float _secondsTillNextFrame;

		private List<GifDecoder.GifFrame> _cachedFrames;

		private Thread _decodeThread;

		private readonly EventWaitHandle _wh;

		private bool _threadIsCanceled;

		private bool _frameIsReady;

		private readonly object _locker;

		private float _editorPreviousUpdateTime;

		public int Width => 0;

		public int Height => 0;

		public Component TargetComponent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int TargetMaterialNumber
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public GifPlayerState State { get; private set; }

		private GifDecoder.GifFrame CurrentFrame { get; set; }

		private int CurrentFrameNumber { get; set; }

		public event OnReadyAction OnReady
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OnLoadErrorAction OnLoadError
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		public void Update()
		{
		}

		private void OnApplicationQuit()
		{
		}

		public void Init()
		{
		}

		public void Play()
		{
		}

		public void Pause()
		{
		}

		public int GetNumberOfFrames()
		{
			return 0;
		}

		[IteratorStateMachine(typeof(_003CLoad_003Ed__62))]
		private IEnumerator Load()
		{
			return null;
		}

		private void CreateTargetTexture()
		{
		}

		private void SetTexture()
		{
		}

		private Component GetTargetComponent()
		{
			return null;
		}

		private void SetTargetTexture()
		{
		}

		private static Texture2D CreateTexture(int width, int height)
		{
			return null;
		}

		private void BufferFrames()
		{
		}

		private void AddFrameToCache(GifDecoder.GifFrame frame)
		{
		}

		private void StartDecoder()
		{
		}

		private void SetNextFrameTime()
		{
		}

		private void UpdateFrameTime()
		{
		}

		private void UpdateFrame()
		{
		}

		private void CheckFrameChange()
		{
		}

		private void UpdateTexture()
		{
		}

		private void StartReadFrame()
		{
		}

		private void StartDecodeThread()
		{
		}

		private void EndDecodeThread()
		{
		}

		private void FrameDataThread(bool loopDecoder, bool readAllFrames)
		{
		}
	}
}
