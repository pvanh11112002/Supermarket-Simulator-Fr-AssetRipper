using UnityEngine;

[RequireComponent(typeof(ReflectionProbe))]
public class ReflectionProbeRefresh : MonoBehaviour
{
	[SerializeField]
	private int m_HourToStartRefreshing;

	[SerializeField]
	private bool m_AM;

	[SerializeField]
	private float m_RefreshRate;

	private ReflectionProbe m_ReflectionProbe;

	private bool m_Refresh;

	private float m_LastRefreshTime;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void CheckTime()
	{
	}

	private void FixedUpdate()
	{
	}

	private void RefreshProbe()
	{
	}

	private void OnDayCycleDisabled()
	{
	}
}
