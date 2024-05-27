using System;
using GoogleMobileAds.Api;

public class AppOpenAdManager
{
	private const string AD_UNIT_ID = "ca-app-pub-8343092908723618/2010722027";

	private DateTime loadTime;

	private static AppOpenAdManager instance;

	private AppOpenAd ad;

	private bool isShowingAd;

	public static AppOpenAdManager Instance => null;

	private bool IsAdAvailable => false;

	public void LoadAd()
	{
	}

	public void ShowAdIfAvailable()
	{
	}

	private void HandleAdDidDismissFullScreenContent(object sender, EventArgs args)
	{
	}

	private void HandleAdFailedToPresentFullScreenContent(object sender, AdErrorEventArgs args)
	{
	}

	private void HandleAdDidPresentFullScreenContent(object sender, EventArgs args)
	{
	}

	private void HandleAdDidRecordImpression(object sender, EventArgs args)
	{
	}

	private void HandlePaidEvent(object sender, AdValueEventArgs args)
	{
	}
}
