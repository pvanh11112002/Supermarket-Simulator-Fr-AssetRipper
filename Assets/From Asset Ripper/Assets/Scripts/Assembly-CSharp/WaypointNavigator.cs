using UnityEngine;

[RequireComponent(typeof(NPC))]
public class WaypointNavigator : MonoBehaviour
{
	private Waypoint m_CurrentWaypoint;

	private NPC m_Npc;

	private bool m_TravelForward;

	private bool m_FinishTravel;

	private int m_TripLength;

	private int m_CurrentTripLength;

	private bool m_EndOfRoute => false;

	private void Awake()
	{
	}

	public void SetupTravel(Waypoint waypoint, bool forward, int waypointTravelCount, float speed)
	{
	}

	public void ReachedWaypoint()
	{
	}

	private bool CheckToFinishTravel()
	{
		return false;
	}

	private void FinishTravel(Vector3 buildingEnterence)
	{
	}

	private void SelectNextWaypoint()
	{
	}
}
