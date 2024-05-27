using MyBox;
using UnityEngine;
using UnityEngine.Localization;

[CreateAssetMenu(fileName = "New Furniture", menuName = "Scriptable Objects/Furniture/Furniture")]
public class FurnitureSO : ScriptableObject
{
	public int ID;

	[Separator("General Setup", false)]
	public LocalizedString LocalizedName;

	public BoxSize BoxSize;

	public Sprite FurnitureIcon;

	public GameObject FurniturePrefab;

	[Separator("Purchase Info", false)]
	public float Cost;

	public string FurnitureName => null;
}
