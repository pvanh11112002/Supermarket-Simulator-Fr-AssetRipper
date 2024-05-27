using MyBox;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class FirstPersonController : Singleton<FirstPersonController>
{
	[Header("Player")]
	[Tooltip("Move speed of the character in m/s")]
	[SerializeField]
	private float MoveSpeed;

	[SerializeField]
	[Tooltip("Sprint speed of the character in m/s")]
	private float SprintSpeed;

	[Tooltip("Rotation speed of the character")]
	[SerializeField]
	private float RotationSpeed;

	[SerializeField]
	[Tooltip("Acceleration and deceleration")]
	private float SpeedChangeRate;

	[SerializeField]
	[Tooltip("The height the player can jump")]
	[Space(10f)]
	private float JumpHeight;

	[Tooltip("The character uses its own gravity value. The engine default is -9.81f")]
	[SerializeField]
	private float m_Gravity;

	[SerializeField]
	private float m_FreeGravity;

	[SerializeField]
	[Tooltip("Time required to pass before being able to jump again. Set to 0f to instantly jump again")]
	[Space(10f)]
	private float JumpTimeout;

	[Tooltip("Time required to pass before entering the fall state. Useful for walking down stairs")]
	[SerializeField]
	private float FallTimeout;

	[SerializeField]
	[Header("Player Grounded")]
	[Tooltip("If the character is grounded or not. Not part of the CharacterController built in grounded check")]
	private bool Grounded;

	[Tooltip("Useful for rough ground")]
	[SerializeField]
	private float GroundedOffset;

	[Tooltip("The radius of the grounded check. Should match the radius of the CharacterController")]
	[SerializeField]
	private float GroundedRadius;

	[Tooltip("What layers the character uses as ground")]
	[SerializeField]
	private LayerMask GroundLayers;

	[Header("Cinemachine")]
	[Tooltip("The follow target set in the Cinemachine Virtual Camera that the camera will follow")]
	[SerializeField]
	private GameObject CinemachineCameraTarget;

	[Tooltip("How far in degrees can you move the camera up")]
	[SerializeField]
	private float TopClamp;

	[SerializeField]
	[Tooltip("How far in degrees can you move the camera down")]
	private float BottomClamp;

	private const float _threshold = 0.01f;

	private float _cinemachineTargetPitch;

	private float _speed;

	private float _rotationVelocity;

	private float _verticalVelocity;

	private float _terminalVelocity;

	private float _jumpTimeoutDelta;

	private float _fallTimeoutDelta;

	private CharacterController _controller;

	private InputActions m_InputActions;

	private bool _movementInteraction;

	private bool _cameraInteraction;

	public bool CameraInteraction
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool MovementInteraction
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void GroundedCheck()
	{
	}

	private void CameraRotation()
	{
	}

	private void Move()
	{
	}

	private void Gravity()
	{
	}

	private void Jump()
	{
	}

	private static float ClampAngle(float lfAngle, float lfMin, float lfMax)
	{
		return 0f;
	}
}
