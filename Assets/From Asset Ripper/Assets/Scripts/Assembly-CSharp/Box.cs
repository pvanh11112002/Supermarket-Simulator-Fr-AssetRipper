using System.Collections.Generic;
using MyBox;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour, IInteractable
{
	private const float m_ClosingBoxTime = 0.7f;

	private const float m_AnimationTransitionTime = 0.7f;

	[SerializeField]
	[Separator("Components", false)]
	private int m_ID;

	[SerializeField]
	private Image m_ProductIconImage;

	[SerializeField]
	private GameObject m_IconCanvas;

	[SerializeField]
	private Animation m_Animation;

	[SerializeField]
	private Transform m_ProductsParent;

	[SerializeField]
	private BoxSO m_BoxSO;

	[SerializeField]
	private Renderer[] m_RenderersToHighlight;

	private List<Product> m_Products;

	private BoxData m_Data;

	private bool m_SpawnedProducts;

	private bool m_InAnimationTransition;

	private bool m_Racked;

	public BoxSize Size => default(BoxSize);

	public InteractactableType Type => default(InteractactableType);

	public bool IsOpen => false;

	public bool InAnimationTransition => false;

	public bool ContinousInteraction => false;

	public ProductSO Product => null;

	public bool Full => false;

	public BoxData Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string InstantInteractionHint => null;

	public string HoldingInteractionHint => null;

	public InteractionType InteractionType => default(InteractionType);

	public int BoxID => 0;

	public bool Racked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasProducts => false;

	public Renderer[] RenderersToHighlight => null;

	private void Initialize()
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Setup(int productID, bool newBox = false)
	{
	}

	public void OpenBox()
	{
	}

	public void CloseBox(bool force = false)
	{
	}

	public void PickUp()
	{
	}

	public bool InstantInteract()
	{
		return false;
	}

	public bool HoldingInteract()
	{
		return false;
	}

	public Product GetProductFromBox()
	{
		return null;
	}

	public void AddProduct(int productID, Product item)
	{
	}

	public void ResetBox()
	{
	}

	private void SpawnProducts(bool loadFromData = false)
	{
	}

	private void DespawnProducts()
	{
	}

	private void SetIdle()
	{
	}

	private void SetInAnimationTransition()
	{
	}
}
