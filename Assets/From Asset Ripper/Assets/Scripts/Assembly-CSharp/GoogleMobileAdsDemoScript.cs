using System;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;
using UnityEngine;
using UnityEngine.Advertisements;

public class GoogleMobileAdsDemoScript : MonoBehaviour, IUnityAdsLoadListener, IUnityAdsShowListener, IUnityAdsInitializationListener
{
	public static GoogleMobileAdsDemoScript _instance;

	private BannerView bannerView;

	private InterstitialAd interstitial_0;

	private InterstitialAd interstitial_1;

	private InterstitialAd interstitial_2;

	private RewardedAd rewardedAd;

	private float deltaTime;

	private static string outputMessage;

	private int adscount;

	private float Timer;

	private bool CanShowVideo;

	[NonSerialized]
	public int MenuAdsCount;

	[NonSerialized]
	public int rewardedIndexAD;

	[NonSerialized]
	public int time_interval;

	[NonSerialized]
	public string urlJsonString;

	[NonSerialized]
	public string type2;

	[NonSerialized]
	public int recogcn;

	[NonSerialized]
	public string totalcityname;

	[NonSerialized]
	public string adsType;

	[NonSerialized]
	public string AdsPercentStr;

	[NonSerialized]
	public int AdsPercentInt;

	private string myPlacementId;

	[NonSerialized]
	public string adCounttype;

	private string Unity_GameId;

	private string Unity_InterstitialAId;

	private string Unity_RewardedVideoId;

	private string Unity_BannerAdsShowId;

	private string Admob_appId;

	private string Admob_banner00_Id;

	private string interstitial_0_Id;

	private string interstitial_1_Id;

	private string interstitial_2_Id;

	private string Admob_OpenAds__Id;

	private string Admob_Rewarded_Id;

	private bool testMode;

	public Action buyAction;

	public static string OutputMessage
	{
		set
		{
		}
	}

	public void Awake()
	{
	}

	private void HandleInitCompleteAction(InitializationStatus initstatus)
	{
	}

	public void Start()
	{
	}

	public void DeleyShowBanner()
	{
	}

	public void OnAppStateChanged(AppState state)
	{
	}

	public void SetADBuy(Action action)
	{
	}

	public void ADSuccessCallBack(string str = "")
	{
	}

	public void Update()
	{
	}

	public void ShowAdmobInterstitial()
	{
	}

	public void ShowUnityInterstitial()
	{
	}

	public void showAdmobAdsOnly()
	{
	}

	public void showInterstitial()
	{
	}

	public void DelayShowInterstitial()
	{
	}

	public void showControlInterstitialAdsA()
	{
	}

	public void showControlInterstitialAds()
	{
	}

	private AdRequest CreateAdRequest()
	{
		return null;
	}

	public void RequestBanner()
	{
	}

	private void RequestInterstitial2()
	{
	}

	private void RequestInterstitial1()
	{
	}

	private void RequestInterstitial0()
	{
	}

	public void CreateAndLoadRewardedAd()
	{
	}

	public void ShowRewardedAd(int strint)
	{
	}

	public void HandleAdLoaded(object sender, EventArgs args)
	{
	}

	public void HandleAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	{
	}

	public void HandleAdOpened(object sender, EventArgs args)
	{
	}

	public void HandleAdClosed(object sender, EventArgs args)
	{
	}

	public void HandleAdLeftApplication(object sender, EventArgs args)
	{
	}

	public void HandleInterstitialLoaded(object sender, EventArgs args)
	{
	}

	public void HandleInterstitialFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	{
	}

	public void HandleInterstitialOpened(object sender, EventArgs args)
	{
	}

	public void HandleInterstitialClosed(object sender, EventArgs args)
	{
	}

	public void HandleInterstitialLeftApplication(object sender, EventArgs args)
	{
	}

	public void HandleRewardedAdLoaded(object sender, EventArgs args)
	{
	}

	public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
	{
	}

	public void HandleRewardedAdOpening(object sender, EventArgs args)
	{
	}

	public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
	{
	}

	public void HandleRewardedAdClosed(object sender, EventArgs args)
	{
	}

	public void HandleUserEarnedReward(object sender, Reward args)
	{
	}

	public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
	{
	}

	public void OnUnityAdsReady(string placementId)
	{
	}

	public void OnUnityAdsDidError(string message)
	{
	}

	public void OnUnityAdsDidStart(string placementId)
	{
	}

	public void OnUnityAdsAdLoaded(string adUnitId)
	{
	}

	public void OnUnityAdsFailedToLoad(string adUnitId, UnityAdsLoadError error, string message)
	{
	}

	public void OnUnityAdsShowFailure(string adUnitId, UnityAdsShowError error, string message)
	{
	}

	public void OnUnityAdsShowStart(string adUnitId)
	{
	}

	public void OnUnityAdsShowClick(string adUnitId)
	{
	}

	public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState)
	{
	}

	public void OnInitializationComplete()
	{
	}

	public void OnInitializationFailed(UnityAdsInitializationError error, string message)
	{
	}

	private void onInterstitialLoadedEvent()
	{
	}

	private void onInterstitialFailedEvent(string errorMsg)
	{
	}

	private void onInterstitialShownEvent()
	{
	}

	private void onInterstitialShownFailedEvent(string adUnitId)
	{
	}

	private void onInterstitialClickedEvent()
	{
	}

	private void onInterstitialDismissedEvent()
	{
	}

	public void RewardedSuccessAds()
	{
	}

	public void delayShowRecognisedUI()
	{
	}

	public void showRecognisedUI()
	{
	}

	public void LoginSuccess()
	{
	}

	public void OnDisable()
	{
	}
}
