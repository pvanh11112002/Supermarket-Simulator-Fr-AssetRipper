using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadScene_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainMenuManager _003C_003E4__this;

		public string _scene;

		private AsyncOperation _003Casync_003E5__2;

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
		public _003CLoadScene_003Ed__9(int _003C_003E1__state)
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
	private Button m_ContinueButton;

	[SerializeField]
	private GameObject m_ApproveNewGameMenu;

	public CanvasGroup loading;

	public Slider loadingSlider;

	private void Awake()
	{
	}

	public void Continue()
	{
	}

	public void TryNewGame()
	{
	}

	public void DisapproveNewGame()
	{
	}

	public void NewGame()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadScene_003Ed__9))]
	public IEnumerator LoadScene(string _scene)
	{
		return null;
	}

	public void Settings()
	{
	}

	public void Quit()
	{
	}

	public void MoreFunBtnClick()
	{
	}

	public void showYinsiDialog()
	{
	}

	public void Update()
	{
	}
}
