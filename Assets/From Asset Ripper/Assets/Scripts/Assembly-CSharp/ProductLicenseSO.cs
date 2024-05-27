using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;

[Serializable]
[CreateAssetMenu(fileName = "Product License", menuName = "Product/Product License")]
public class ProductLicenseSO : ScriptableObject
{
	public int ID;

	public LocalizedString LocalizedName;

	public int RequiredPlayerLevel;

	public float PurchasingCost;

	public List<ProductSO> Products;

	public string LicenseName => null;
}
