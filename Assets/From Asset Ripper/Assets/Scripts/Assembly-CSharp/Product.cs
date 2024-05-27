using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Product : MonoBehaviour
{
	private ProductSO m_ProductSO;

	private Renderer[] m_Renderers;

	private Highlightable m_Highlightable;

	private float m_Price;

	private Checkout m_Checkout;

	private List<CheckoutBeltGrid> m_OccupiedGrids;

	private Vector2Int m_Size;

	private Vector2Int m_BaseGrid;

	private bool m_Visible;

	public float Price
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Checkout Checkout
	{
		set
		{
		}
	}

	public List<CheckoutBeltGrid> OccupiedGrids => null;

	public Vector2Int Size
	{
		get
		{
			return default(Vector2Int);
		}
		set
		{
		}
	}

	public Vector2Int BaseGrid
	{
		get
		{
			return default(Vector2Int);
		}
		set
		{
		}
	}

	public bool Visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ProductSO ProductSO
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void AddOccupiedGrid(CheckoutBeltGrid grid)
	{
	}

	[ContextMenu("Scan")]
	public void Scan()
	{
	}

	public void ResetProduct()
	{
	}
}
