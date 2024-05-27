using System;
using MyBox;
using UnityEngine;

public class InputActions : Singleton<InputActions>
{
	private Vector2 m_Move;

	private Vector2 m_Look;

	private bool m_Sprint;

	private bool m_AnalogMovement;

	private bool m_CursorLocked;

	private bool m_CursorInputForLook;

	public Action onJump;

	private SaveManager.SettingsContainer m_Settings;

	private Vector2 moveDelta;

	public Vector2 Move => default(Vector2);

	public Vector2 Look => default(Vector2);

	public bool Sprint => false;

	public bool AnalogMovement => false;

	public bool CursorLocked => false;

	public bool CursorInputForLook => false;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void MoveInput(Vector2 newMoveDirection)
	{
	}

	public void LookInput(Vector2 newLookDirection)
	{
	}

	public void SprintInput(bool newSprintState)
	{
	}

	private void SetCursorState(bool newState)
	{
	}
}
