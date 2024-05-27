using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

public class LoadImageMgr
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		public bool hasLoad;

		public Action<Texture2D> loadEnd;

		public LoadImageMgr _003C_003E4__this;

		public string url;

		internal void _003CLoadImage_003Eb__0(bool state, Texture2D localTexture)
		{
		}

		internal void _003CLoadImage_003Eb__1(bool state, Texture2D downloadTexture)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CDownloadImage_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public Action<bool, Texture2D> downloadEnd;

		private UnityWebRequest _003Crequest_003E5__2;

		private DownloadHandlerTexture _003CdownloadHandlerTexture_003E5__3;

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
		public _003CDownloadImage_003Ed__1(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CLoadImage_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Action<Texture2D> loadEnd;

		public LoadImageMgr _003C_003E4__this;

		public string url;

		private _003C_003Ec__DisplayClass0_0 _003C_003E8__1;

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
		public _003CLoadImage_003Ed__0(int _003C_003E1__state)
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

	private Dictionary<string, Texture2D> imageDic;

	public static LoadImageMgr instance { get; private set; }

	[IteratorStateMachine(typeof(_003CLoadImage_003Ed__0))]
	public IEnumerator LoadImage(string url, Action<Texture2D> loadEnd)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CDownloadImage_003Ed__1))]
	public IEnumerator DownloadImage(string url, Action<bool, Texture2D> downloadEnd)
	{
		return null;
	}

	public string GetMD5(string msg)
	{
		return null;
	}

	private void Save2LocalPath(string url, Texture2D texture)
	{
	}

	private string GetLocalPath()
	{
		return null;
	}
}
