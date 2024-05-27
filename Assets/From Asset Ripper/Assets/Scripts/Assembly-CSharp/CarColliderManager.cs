using MyBox;
using UnityEngine;

public class CarColliderManager : Singleton<CarColliderManager>
{
	[SerializeField]
	private Collider m_CarColliderPrefab;

	public Collider SpawnCarCollider()
	{
		return null;
	}

	public void DespawnCarCollider(Collider carCollider)
	{
	}
}
