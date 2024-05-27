using UnityEngine;

public class SendToAndroid
{
	public int MenuScene;

	public int OptionScene;

	public int ShopScene;

	public int UpgradeScene;

	public int SelectLevelScene;

	public int GameScene;

	public int PauseScene;

	public int MissionCompleteScene;

	public int BattleModeBtn;

	public int MissionModeBtn;

	public int ParchuteView;

	public int PauseBtn;

	public int ResumeBtn;

	public int BackBtn;

	public int RestartBtn;

	public int Buy1;

	public int Buy2;

	public int Buy3;

	public int Buy4;

	public int RankBtn;

	public int FreeCoinBtn;

	public int DoubleCoinBtn;

	public int ConfirmBtn;

	public int RemoveAds;

	public int Char20;

	public int Char21;

	public int Char22;

	public int Char23;

	public int Char24;

	public int Char25;

	public int Restorebtn;

	private static SendToAndroid _instance;

	public AndroidJavaClass jc;

	public AndroidJavaObject activity;

	public static SendToAndroid Instance => null;

	public void SendToAndroidWithItemInfo(int item)
	{
	}

	public void SendToAndroidWithStatisticInfo(int kill, int headshoots)
	{
	}

	public void SendToAndroidWithStringInfo(string urlstr)
	{
	}
}
