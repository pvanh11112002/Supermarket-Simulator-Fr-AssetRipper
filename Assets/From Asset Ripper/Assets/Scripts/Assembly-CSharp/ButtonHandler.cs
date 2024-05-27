using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ButtonHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[SerializeField]
	private UnityEvent m_OnClick;

	[SerializeField]
	private UnityEvent m_OnDoubleClick;

	public void OnPointerClick(PointerEventData eventData)
	{
	}
}
