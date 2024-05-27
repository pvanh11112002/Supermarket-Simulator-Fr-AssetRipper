using UnityEngine;

public class InteriorSpotLight : MonoBehaviour
{
	[SerializeField]
	private GameObject m_EmissionOn;

	[SerializeField]
	private GameObject m_EmissionOff;

	[SerializeField]
	private GameObject m_Light;

	public bool TurnOn
	{
		set
		{
		}
	}

	private void Start()
	{
	}
}
