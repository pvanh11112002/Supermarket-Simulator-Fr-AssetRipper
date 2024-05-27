using System;
using UnityEngine;

[Serializable]
public class TransformData
{
	public Vector3 Position;

	public Quaternion Rotation;

	public TransformData()
	{
	}

	public TransformData(Vector3 position, Quaternion rotation)
	{
	}
}
