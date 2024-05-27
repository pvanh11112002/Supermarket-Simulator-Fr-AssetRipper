using UnityEngine;

namespace VLB
{
	[HelpURL("http://saladgamer.com/vlb-doc/comp-trackrealtimechanges-hd/")]
	[AddComponentMenu("VLB/HD/Track Realtime Changes On Light")]
	[RequireComponent(typeof(Light), typeof(VolumetricLightBeamHD))]
	[DisallowMultipleComponent]
	public class TrackRealtimeChangesOnLightHD : MonoBehaviour
	{
		public const string ClassName = "TrackRealtimeChangesOnLightHD";

		private VolumetricLightBeamHD m_Master;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
