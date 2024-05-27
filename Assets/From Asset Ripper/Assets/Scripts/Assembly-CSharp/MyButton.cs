using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("UI/MyButton")]
public class MyButton : Button
{
	public Image press;

	public Action OnDown;

	public Action OnUp;

	public Action OnTocuhAction;

	public Action OnUpActionAdd;

	public float scale;

	public Sprite tmpSpr;

	public GameObject[] selectedObjs;

	public bool IsPressing { get; set; }

	protected override void Awake()
	{
	}

	public void OnDownEvent()
	{
	}

	public void OnUpEvent()
	{
	}

	public override void OnPointerDown(PointerEventData eventData)
	{
	}

	public override void OnPointerUp(PointerEventData eventData)
	{
	}

	public override void OnPointerExit(PointerEventData eventData)
	{
	}
}
