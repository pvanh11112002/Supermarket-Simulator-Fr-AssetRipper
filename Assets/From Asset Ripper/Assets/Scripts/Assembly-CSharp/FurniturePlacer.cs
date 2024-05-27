using System.Collections.Generic;
using MyBox;
using UnityEngine;

public class FurniturePlacer : Singleton<FurniturePlacer>
{
	[SerializeField]
	private float m_MaxRaycastDistanceForward;

	[SerializeField]
	private float m_MaxRaycastDistanceDownward;

	[Range(0f, 1f)]
	[SerializeField]
	private float m_MovingObjectSmoothness;

	[SerializeField]
	private float m_ScalingDownAnimationTime;

	[SerializeField]
	private float m_AngleSnapValue;

	[SerializeField]
	private Material m_HologramMaterial;

	[SerializeField]
	private LayerMask m_FurniturePlacingLayer;

	private FurniturePlacingMode m_CurrentPlacingMode;

	private Camera m_Camera;

	private List<LayerMask> m_CurrentObjectCollidersLayer;

	private bool m_PlacingMode;

	private List<string> m_CurrentPlacingTag;

	private Ray m_Ray;

	private RaycastHit m_HitInfo;

	public FurniturePlacingMode CurrentPlacingMode
	{
		set
		{
		}
	}

	public List<string> CurrentPlacingTag
	{
		set
		{
		}
	}

	public float ScalingDownAnimationTime => 0f;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void StartPlacingMode()
	{
	}

	public void Rotate(bool clockvise)
	{
	}

	public bool PlaceFurniture()
	{
		return false;
	}

	public void BoxUp()
	{
	}

	private void StopPlacingMode()
	{
	}

	private void PlacingRaycast()
	{
	}

	private void MoveFurniture(Vector3 targetPos)
	{
	}

	private float GetNearestSnapAngle(float angle)
	{
		return 0f;
	}
}
