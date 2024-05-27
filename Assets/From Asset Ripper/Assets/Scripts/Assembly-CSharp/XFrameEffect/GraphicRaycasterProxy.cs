using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace XFrameEffect
{
	[RequireComponent(typeof(Canvas))]
	public class GraphicRaycasterProxy : GraphicRaycaster
	{
		[NonSerialized]
		public XFrameManager xframe;

		private Canvas canvas;

		private GraphicRaycaster gr;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		private T GetAnotherComponent<T>() where T : Component
		{
			return null;
		}
	}
}
