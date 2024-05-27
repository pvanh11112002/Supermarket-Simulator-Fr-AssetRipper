using UnityEngine;

public class ComputerOperatingSystem : MonoBehaviour
{
	[SerializeField]
	private BaseWindow[] m_AppWindows;

	private BaseWindow m_CurrentWindow;

	private BaseWindow GetAppWindowByName(string appName)
	{
		return null;
	}

	public void OpenApp(string appName)
	{
	}

	public void CloseApp(string appName)
	{
	}
}
