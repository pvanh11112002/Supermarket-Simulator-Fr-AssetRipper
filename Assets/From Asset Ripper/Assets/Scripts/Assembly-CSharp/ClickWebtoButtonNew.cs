using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using OldMoatGames;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ClickWebtoButtonNew : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDownLoadNewPicture_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public ClickWebtoButtonNew _003C_003E4__this;

		private WWW _003CtW_003E5__2;

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
		public _003CDownLoadNewPicture_003Ed__39(int _003C_003E1__state)
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
	private sealed class _003CGetUriData_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public ClickWebtoButtonNew _003C_003E4__this;

		private UnityWebRequest _003Cwww_003E5__2;

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
		public _003CGetUriData_003Ed__44(int _003C_003E1__state)
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
	private sealed class _003CLoadCacheImage_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public ClickWebtoButtonNew _003C_003E4__this;

		private WWW _003CtW_003E5__2;

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
		public _003CLoadCacheImage_003Ed__40(int _003C_003E1__state)
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
	private sealed class _003CLoadTeture_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public Action<Texture2D> cb;

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
		public _003CLoadTeture_003Ed__32(int _003C_003E1__state)
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
	private sealed class _003CdownloadRoutine_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string url;

		public ClickWebtoButtonNew _003C_003E4__this;

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
		public _003CdownloadRoutine_003Ed__29(int _003C_003E1__state)
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

	private AnimatedGifPlayer AnimatedGifPlayer;

	public string linkValue;

	public string pictureValue;

	private int AnimationStatus;

	public Button buttonCloseWeb;

	public Image buttonWebImage;

	private Button button;

	private Animator buttonAnim;

	public GameObject gifWindow;

	private string desPath;

	public string path;

	public int GamePanelCount;

	public Text NoticeText;

	public Text MsgText;

	public string PicLinkStr;

	private int PicsNum;

	private List<string> PicLink;

	private List<string> Pics;

	private List<string> Links;

	private List<int> Pros;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void DelayGetControl()
	{
	}

	private void OnChangeBtnAnim()
	{
	}

	public void OpenLinkUrl()
	{
	}

	private void openAPPinMarket(string appid)
	{
	}

	public void CloseButton()
	{
	}

	public void GetTitleData_picture()
	{
	}

	public void GetTitleData_link()
	{
	}

	[IteratorStateMachine(typeof(_003CdownloadRoutine_003Ed__29))]
	public IEnumerator downloadRoutine(string url)
	{
		return null;
	}

	public void LoadPicJob(string value)
	{
	}

	public void LoadImage(Image image, string url)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadTeture_003Ed__32))]
	private IEnumerator LoadTeture(string url, Action<Texture2D> cb)
	{
		return null;
	}

	private void OnGetTitleSuccess_gif(string msg)
	{
	}

	public void OnGetTitleSuccess_link(string msg)
	{
	}

	public void getGifString(string strurl)
	{
	}

	private void OnGifLoaded()
	{
	}

	private void OnGifLoadError()
	{
	}

	private void ASyncLoadImage(string picUrl)
	{
	}

	[IteratorStateMachine(typeof(_003CDownLoadNewPicture_003Ed__39))]
	private IEnumerator DownLoadNewPicture(string url)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CLoadCacheImage_003Ed__40))]
	private IEnumerator LoadCacheImage(string url)
	{
		return null;
	}

	private Sprite GetSprite(Texture2D tex)
	{
		return null;
	}

	public void DecodeUriData(string url)
	{
	}

	public void ShowAdLoop()
	{
	}

	[IteratorStateMachine(typeof(_003CGetUriData_003Ed__44))]
	private IEnumerator GetUriData(string url)
	{
		return null;
	}

	public void ShowAdPicFromJson()
	{
	}

	private void setAdsTimerInterval()
	{
	}

	private void OnDisable()
	{
	}
}
