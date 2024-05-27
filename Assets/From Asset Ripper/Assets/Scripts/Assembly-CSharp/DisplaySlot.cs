using System.Collections.Generic;
using UnityEngine;

public class DisplaySlot : MonoBehaviour
{
	[SerializeField]
	private PriceTag m_PriceTag;

	[SerializeField]
	private Label m_Label;

	[SerializeField]
	private Highlightable m_Highlightable;

	[SerializeField]
	private Transform m_InteractionPosition;

	[SerializeField]
	private Vector2 m_InteractionPositionMargin;

	private List<Product> m_Products;

	private Display m_Display;

	private float m_CurrentPrice;

	private ItemQuantity m_ProductCountData;

	public bool Full => false;

	public int ProductID => 0;

	public Display Display => null;

	public float Price => 0f;

	public ItemQuantity Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector3 InteractionPosition => default(Vector3);

	public Quaternion InteractionRotation => default(Quaternion);

	public Vector3 InteractionPositionForward => default(Vector3);

	public bool HasProduct => false;

	public Transform PriceTagTransform => null;

	public bool EnablePriceTagCollider
	{
		set
		{
		}
	}

	public bool EnableLabelCollider
	{
		set
		{
		}
	}

	private void Initialize()
	{
	}

	private void Start()
	{
	}

	public void SpawnProduct(int productID, int count)
	{
	}

	public void AddProduct(int productID, Product item)
	{
	}

	public Product TakeProductFromDisplay()
	{
		return null;
	}

	public void Clear()
	{
	}

	public void RemoveFromDisplayManagerWhileCarrying()
	{
	}

	public void AddBackToDisplayManagerAfterPlaced()
	{
	}

	public void ClearProductData()
	{
	}

	private void SetPriceTag()
	{
	}

	private void SetLabel()
	{
	}

	private void PricingChanged(int productID)
	{
	}
}
