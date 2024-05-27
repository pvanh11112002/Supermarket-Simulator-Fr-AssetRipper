using System;
using GoogleMobileAds.Api;
using UnityEngine;

public class AdmobManager : MonoBehaviour
{
	protected static AdmobManager instance;

	private BannerView _bannerView;

	private InterstitialAd _interstitial_0;

	private InterstitialAd _interstitial_1;

	private InterstitialAd _interstitial_2;

	private bool _isBannerRequested;

	public static AdmobManager Instance => null;

	public static bool isBannerRequested => false;

	public void OnEnable()
	{
	}

	public static string Md5Sum(string strToEncrypt)
	{
		return null;
	}

	public static void RequestBanner()
	{
	}

	public static void RequestInterstitial0()
	{
	}

	public static void RequestInterstitial1()
	{
	}

	public static void RequestInterstitial2()
	{
	}

	public static AdRequest createAdRequest()
	{
		return null;
	}

	public static void ShowAdmobInterstitial()
	{
	}

	public static void ShowUnityInterstitial()
	{
	}

	public static void showInterstitial()
	{
	}

	public static void DestroyInterstitial()
	{
	}

	public static void ShowBanner()
	{
	}

	public static void HideBanner()
	{
	}

	public static void DestroyBanner()
	{
	}

	public static void HandleAdLoaded(object sender, EventArgs args)
	{
	}

	public static void HandleAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	{
	}

	public static void HandleAdOpened(object sender, EventArgs args)
	{
	}

	public static void HandleAdClosing(object sender, EventArgs args)
	{
	}

	public static void HandleAdClosed(object sender, EventArgs args)
	{
	}

	public static void HandleAdLeftApplication(object sender, EventArgs args)
	{
	}

	public static void HandleInterstitialLoaded(object sender, EventArgs args)
	{
	}

	public static void HandleInterstitialFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	{
	}

	public static void HandleInterstitialOpened(object sender, EventArgs args)
	{
	}

	public static void HandleInterstitialClosing(object sender, EventArgs args)
	{
	}

	public static void HandleInterstitialClosed(object sender, EventArgs args)
	{
	}

	public static void HandleInterstitialLeftApplication(object sender, EventArgs args)
	{
	}
}
