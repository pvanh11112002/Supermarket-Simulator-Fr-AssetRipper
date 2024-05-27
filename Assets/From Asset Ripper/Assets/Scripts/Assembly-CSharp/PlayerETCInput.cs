using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PlayerETCInput : MonoBehaviour
{
	public static PlayerETCInput ins;

	public CanvasGroup controlGroup;

	public UITouchArea moveArea;

	public ETCJoystick moveJoystick;

	public UITouchArea rotateArea;

	public ETCTouchPad rotatePad;

	public ETCButton jumpBtn;

	public ETCButton runBtn;

	public ETCButton pauseBtn;

	[Space]
	public CanvasGroup btnGroup;

	public CanvasGroup leftGroup;

	public CanvasGroup rightGroup;

	public RectTransform leftBtnGroup;

	public RectTransform rightBtnGroup;

	public EButton[] eButtons;

	public ETCButton finishBtn;

	private Dictionary<InputActionID, List<EButton>> btnDict;

	private List<EButton> activeBtns;

	private Sequence leftAnim;

	private bool isLeft;

	private Sequence rightAnim;

	private bool isRight;

	public bool MoveEnabled
	{
		set
		{
		}
	}

	public bool IsLeftBtns
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsRightBtns
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void AddHint(InputActionID actionID)
	{
	}

	public void RemoveHint(InputActionID actionID)
	{
	}

	public void RemoveAllHint()
	{
	}

	private void Start()
	{
	}
}
