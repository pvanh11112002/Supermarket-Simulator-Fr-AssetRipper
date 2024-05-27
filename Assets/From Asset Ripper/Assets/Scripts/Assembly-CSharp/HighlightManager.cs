using EPOOutline;
using MyBox;
using UnityEngine;

public class HighlightManager : Singleton<HighlightManager>
{
	[SerializeField]
	[ColorUsage(true, true)]
	private Color m_OutlineColor;

	private Highlightable m_CurrentHighligtedObject;

	public void SetHighlight(Highlightable highlightable)
	{
	}

	public void AddOrRemoveRenderer(Renderer[] renderers, bool add)
	{
	}

	private void AddRendererTarget(Outlinable outline, Renderer renderer)
	{
	}
}
