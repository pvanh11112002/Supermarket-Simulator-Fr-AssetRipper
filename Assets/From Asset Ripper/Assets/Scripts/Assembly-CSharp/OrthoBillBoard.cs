using UnityEngine;

public class OrthoBillBoard : MonoBehaviour
{
	public Transform FacedObject;

	private static Camera _camera;

	private Transform ActiveFacedObject => null;

	private void LateUpdate()
	{
	}
}
