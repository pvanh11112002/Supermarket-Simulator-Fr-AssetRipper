using MyBox;
using UnityEngine;

public class SFXManager : Singleton<SFXManager>
{
	[Header("Settings")]
	[SerializeField]
	private Vector2 m_RandomPitchRange;

	[SerializeField]
	[Header("Sounds")]
	private AudioSource m_DroppingBoxSFX;

	[SerializeField]
	private AudioSource m_CoinSFX;

	[SerializeField]
	private AudioSource m_MoneyPaperSFX;

	[SerializeField]
	private AudioSource m_CashRegisterOpen;

	[SerializeField]
	private AudioSource m_CashRegisterClose;

	[SerializeField]
	private AudioSource m_PickingUpBox;

	[SerializeField]
	private AudioSource m_ScanningProduct;

	[SerializeField]
	private AudioSource m_Checkout;

	[SerializeField]
	private AudioSource m_PlacingProduct;

	[SerializeField]
	private AudioSource m_MouseClick;

	[SerializeField]
	private AudioSource m_CheckoutWarning;

	[SerializeField]
	private AudioSource m_SwitchOn;

	[SerializeField]
	private AudioSource m_SwitchOff;

	public void PlayDroppingBoxSFX()
	{
	}

	public void PlayCoinSFX()
	{
	}

	public void PlayMoneyPaperSFX()
	{
	}

	public void PlayCashRegister(bool open)
	{
	}

	public void PlayPickingUpBoxSFX()
	{
	}

	public void PlayScanningProductSFX()
	{
	}

	public void PlayCheckoutSFX()
	{
	}

	public void PlayPlacingProductSFX()
	{
	}

	public void PlayMouseClickSFX()
	{
	}

	public void PlayCheckoutWarningSFX()
	{
	}

	public void PlaySwitchSFX(bool on)
	{
	}
}
