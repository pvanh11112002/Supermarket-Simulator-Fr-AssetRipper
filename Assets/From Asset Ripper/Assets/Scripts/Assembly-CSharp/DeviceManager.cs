using UnityEngine;

public class DeviceManager : MonoBehaviour
{
	public static DeviceManager Instance;

	[HideInInspector]
	public bool isOldAndCheapDevice;

	[HideInInspector]
	public bool HighEndModels;

	[HideInInspector]
	public bool MidEndModels;

	private void Awake()
	{
	}
}
