using MyBox;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuManager : Singleton<SettingsMenuManager>
{
	[SerializeField]
	private GameObject m_Menu;

	public bool isMenuScene;

	[SerializeField]
	private Slider m_SoundSetting;

	[SerializeField]
	private Slider m_MouseSensitivitySetting;

	private SaveManager.SettingsContainer m_Settings;

	private Resolution[] m_Resolutions;

	private bool m_ChangingLocale;

	public bool Enable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void SetSound(float sound)
	{
	}

	public void SetSensitivity(float sensitivity)
	{
	}

	public void SetLanguage(int languageIndex)
	{
	}

	private void LoadSettings()
	{
	}
}
