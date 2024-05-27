using System.Collections.Generic;
using UnityEngine;

public class FurniturePlacingMode : IPlacingMode
{
	[SerializeField]
	private Vector3 m_PositionOffset;

	[SerializeField]
	private List<string> m_PlacingTag;

	[SerializeField]
	private Collider[] m_PhysicalColliders;

	[SerializeField]
	private GameObject m_Furniture;

	[SerializeField]
	private GameObject m_InteractionZoneCanvas;

	private List<Collider> m_AllColliders;

	private bool m_PlacedOnCorrectSurface;

	private Collider m_PlacingCollider;

	public List<string> PlacingTag => null;

	public Vector3 PositionOffset => default(Vector3);

	public Collider[] PhysicalColliders => null;

	public bool PlacedOnCorrectSurface
	{
		set
		{
		}
	}

	public override bool AvailablePosition => false;

	public bool EnableInteractionZoneCanvas
	{
		set
		{
		}
	}

	public Transform Furniture => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	protected override void OnTriggerEnter(Collider other)
	{
	}

	protected override void OnTriggerExit(Collider other)
	{
	}

	public override void PlacingMode(bool value, Material hologramMaterial = null)
	{
	}

	public void SubscribeToMovingFurnitureInteraction()
	{
	}

	public void ShowInteractionZone(bool show)
	{
	}
}
