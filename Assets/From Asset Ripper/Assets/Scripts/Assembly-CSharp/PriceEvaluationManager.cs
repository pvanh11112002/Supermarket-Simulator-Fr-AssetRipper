using MyBox;
using UnityEngine;

public class PriceEvaluationManager : Singleton<PriceEvaluationManager>
{
	public const float PurchaseChanceForLoss = 200f;

	[SerializeField]
	private AnimationCurve m_PurchaseChanceCurveForExpensivePrice;

	[SerializeField]
	private AnimationCurve m_PurchaseChanceCurveForCheapPrice;

	public float PurchaseChance(int productID)
	{
		return 0f;
	}
}
