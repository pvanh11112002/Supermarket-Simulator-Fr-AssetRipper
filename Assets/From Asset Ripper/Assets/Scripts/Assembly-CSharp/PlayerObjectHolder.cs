using MyBox;
using UnityEngine;

public class PlayerObjectHolder : Singleton<PlayerObjectHolder>
{
	[SerializeField]
	private Transform m_ObjectHolder;

	[SerializeField]
	private float m_MaxDistance;

	[SerializeField]
	private float m_MaxVerticleAngleAllowed;

	[SerializeField]
	private float m_AngleSnapValue;

	[SerializeField]
	[Range(0f, 1f)]
	private float m_MovingObjectSmoothness;

	[SerializeField]
	private Material m_HologramMaterial;

	[SerializeField]
	private LayerMask m_PlacingLayer;

	private GameObject m_CurrentObject;

	private Camera m_Camera;

	private IPlacingMode m_CurrentPlacingMode;

	private bool m_PlacingMode;

	private LayerMask m_CurrentObjectsLayer;

	private Ray m_Ray;

	private RaycastHit m_HitInfo;

	private Quaternion m_Rotation;

	private float m_Angle;

	private Vector3 m_PositionOffset;

	private Vector3 m_RotationOffset;

	private Rigidbody m_Rigidbody;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void HoldObject(GameObject item, Vector3 positionOffset, Vector3 rotationOffset)
	{
	}

	public void StartPlacingMode()
	{
	}

	public bool DropObject()
	{
		return false;
	}

	public void CancelPlacingMode()
	{
	}

	public bool ThrowObject()
	{
		return false;
	}

	public void ThrowObjectToBin()
	{
	}

	public void PlaceBoxToRack()
	{
	}

	public void Rotate(bool clockvise)
	{
	}

	private void PlacingRaycast()
	{
	}

	private void MoveToCarryingPosition()
	{
	}

	private float GetNearestSnapAngle(float angle)
	{
		return 0f;
	}
}
