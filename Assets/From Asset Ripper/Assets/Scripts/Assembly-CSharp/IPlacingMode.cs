using System.Collections.Generic;
using UnityEngine;

public abstract class IPlacingMode : MonoBehaviour
{
	[SerializeField]
	private Renderer[] m_Renderers;

	[SerializeField]
	private List<string> m_ExcludeTag;

	protected bool m_PlacingMode;

	protected bool m_OverrideAvailability;

	private List<Material> m_DefaultMaterials;

	protected HashSet<Collider> m_Triggers;

	protected bool furniturePlacingMode;

	public Color HologramColor
	{
		set
		{
		}
	}

	public virtual bool AvailablePosition => false;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	protected virtual void OnTriggerEnter(Collider other)
	{
	}

	protected virtual void OnTriggerExit(Collider other)
	{
	}

	public virtual void PlacingMode(bool value, Material hologramMaterial = null)
	{
	}

	public void UpdateHologramColor()
	{
	}

	protected void SaveDefaultMaterials()
	{
	}

	protected void ClearTriggers()
	{
	}
}
