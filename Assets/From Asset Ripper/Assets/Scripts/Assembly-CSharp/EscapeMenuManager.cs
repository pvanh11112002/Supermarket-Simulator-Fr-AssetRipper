using UnityEngine;

public class EscapeMenuManager : MonoBehaviour
{
	[SerializeField]
	private GameObject m_Menu;

	[SerializeField]
	private GameObject m_SavingText;

	[SerializeField]
	private SettingsMenuManager m_SettingsMenu;

	private bool m_Paused;

	private bool m_SubscribedOnCancel;

	private bool OpenEscapeMenu
	{
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Continue()
	{
	}

	public void Settings()
	{
	}

	public void Save()
	{
	}

	public void MainMenu()
	{
	}

	public void Quit()
	{
	}

	private void Pause()
	{
	}

	private void RemoveInputListeners()
	{
	}
}
