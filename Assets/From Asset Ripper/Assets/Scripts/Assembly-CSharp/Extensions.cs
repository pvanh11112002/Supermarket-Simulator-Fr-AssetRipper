using System.Text.RegularExpressions;
using UnityEngine;

public static class Extensions
{
	public delegate void ResetDelegate();

	private static readonly Regex AngleBracketRegex;

	public static string ToMoneyText(this float money, float fontSize)
	{
		return null;
	}

	public static float TryParseToFloat(this string text)
	{
		return 0f;
	}

	public static string Raw(this string text)
	{
		return null;
	}

	public static string ToSprite(this string text)
	{
		return null;
	}

	public static string ToSprite(this int index)
	{
		return null;
	}

	public static CanvasGroup OpenAnimation(this CanvasGroup canvasGroup, float fadeIn, float fadeOut, float lifetime, ResetDelegate resetFunction)
	{
		return null;
	}

	public static LocalizationEntry LocalizationEntry(this DisplayType displayType)
	{
		return null;
	}

	public static LocalizationEntry LocalizationEntry(this CustomerSpeechType speechType)
	{
		return null;
	}

	public static LocalizationEntry LocalizationEntry(this InteractionWarningType warningType)
	{
		return null;
	}

	public static LocalizationEntry LocalizationEntry(this PlayerPaymentType paymentType)
	{
		return null;
	}

	public static bool HasHoldingInteraction(this InteractionType interactionType)
	{
		return false;
	}

	public static bool HasInstantInteraction(this InteractionType interactionType)
	{
		return false;
	}
}
