using UnityEngine;
using UnityEngine.AI;

public class CustomerAnimator : MonoBehaviour
{
	[SerializeField]
	private Animator m_Animator;

	[SerializeField]
	private NavMeshAgent m_Agent;

	[SerializeField]
	private float m_MinimumHeightForHighDisplay;

	[SerializeField]
	private float m_MinimumHeightForMediumDisplay;

	[SerializeField]
	private float m_MinimumHeightForMediumLowDisplay;

	private bool m_Bending;

	public bool Shopping
	{
		set
		{
		}
	}

	private void Update()
	{
	}

	public void PickUpProductFromDisplay(float displayHeight)
	{
	}

	public void FinishAnimation(bool standUp)
	{
	}

	public void ExpensiveProduct()
	{
	}

	public void LookForProduct()
	{
	}

	public void HandPayment(bool play)
	{
	}
}
