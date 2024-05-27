using UnityEngine;
using UnityEngine.AI;

public class RestockerAnimationController : MonoBehaviour
{
	[SerializeField]
	private NavMeshAgent m_Agent;

	[SerializeField]
	private Animator m_Animator;

	public bool Carrying
	{
		set
		{
		}
	}

	private void Update()
	{
	}
}
