using UnityEngine;

[CreateAssetMenu(fileName = "Customer Strategy", menuName = "Customer/Strategy")]
public class CustomerStrategySO : ScriptableObject
{
	public float DisplayedProductsRate;

	public float UnlockedProductsRate;

	public float ExpectedProductsRate;

	[Space]
	public int MaxProductVariantsCountToBuy;

	public int MaxProductCountToBuy;

	[Space]
	public Vector2Int LevelRange;
}
