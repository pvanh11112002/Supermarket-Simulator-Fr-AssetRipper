using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

namespace XFrameEffect
{
	[AddComponentMenu("Rendering/X-Frame FPS Accelerator", 90)]
	[ExecuteInEditMode]
	[DefaultExecutionOrder(100)]
	[RequireComponent(typeof(Camera))]
	public class XFrameManager : MonoBehaviour
	{
		private const string XFRAME_CAMERA_OLD = "XFrameCamera";

		private const string XFRAME_BILLBOARD_OLD = "XFrameBillboard";

		private const string XFRAME_CAMERA_INSTANCED = "XFrameCameraInstanced";

		private const string XFRAME_BILLBOARD_INSTANCED = "XFrameBillboardInstanced";

		private const int XFRAME_BILLBOARD_LAYER = 29;

		public Action repaintInspectorAction;

		[SerializeField]
		private XFRAME_DOWNSAMPLING_METHOD _method;

		[SerializeField]
		private XFRAME_FILTERING_MODE _filtering;

		[SerializeField]
		private bool _hdr;

		[SerializeField]
		private int _targetFPS;

		[SerializeField]
		private int _targetFPSforStaticCamera;

		[SerializeField]
		private CameraClearFlags _cameraClearFlags;

		[SerializeField]
		private bool _niceFPSEnabled;

		[SerializeField]
		private bool _prewarm;

		[SerializeField]
		private int _niceFPS;

		[SerializeField]
		private float _downsampling;

		[SerializeField]
		private float _staticDownsampling;

		[SerializeField]
		private float _downsamplingMax;

		[SerializeField]
		private float _downsamplingStart;

		[SerializeField]
		private float _fpsChangeSpeedUp;

		[SerializeField]
		private float _fpsChangeSpeedDown;

		[SerializeField]
		private bool _sharpen;

		[SerializeField]
		private int _antialias;

		[SerializeField]
		private bool _blendWithBackground;

		[SerializeField]
		private bool _reducePixelLights;

		private float _reducePixelLightsThreshold;

		[SerializeField]
		private bool _manageLODBias;

		[SerializeField]
		private float _lodBiasMinimum;

		[SerializeField]
		private float _lodBiasMaximum;

		[SerializeField]
		private float _staticCameraPositionThreshold;

		[SerializeField]
		private bool _manageShadows;

		[SerializeField]
		private float _manageShadowsMinDistance;

		[SerializeField]
		private float _manageShadowsMinInterval;

		[SerializeField]
		private XFRAME_COMPOSITING_METHOD _compositingMethod;

		[SerializeField]
		private bool _showFPS;

		[SerializeField]
		private bool _showQuality;

		[SerializeField]
		private int _fpsFontSize;

		[SerializeField]
		private Color _fpsColor;

		[SerializeField]
		private XFRAME_FPS_LOCATION _fpsLocation;

		public bool enableClickEvents;

		[SerializeField]
		private bool _boostFrameRate;

		[NonSerialized]
		public GameObject xFrameCameraObj;

		[NonSerialized]
		public GameObject xFrameBillboardObj;

		[NonSerialized]
		public bool isDirty;

		private static XFrameManager _xFrame;

		[NonSerialized]
		public Camera mainCamera;

		private static int cameraNumber;

		private RenderTexture[] rtArray;

		private int frameCount;

		private float nextPeriod;

		private int fps;

		private const float FPS_UPDATE_RATE = 0.5f;

		private Camera xFrameCamera;

		private PostFrameCompositor xFramePost;

		private float avgDownsampling;

		private float rtDownsampling;

		private int oldVSyncCount;

		private int oldTargetFrameRate;

		private float oldShadowsDistance;

		private bool cameraIsStatic;

		private Vector3 oldCameraPos;

		private Vector3 oldCameraRot;

		private int oldPixelLightCount;

		private List<Light> lights;

		private float lastLightCheckTime;

		private float lastShadowsDisableTime;

		private Dictionary<Light, LightShadows> oldLightShadows;

		private int _screenWidth;

		private int _screenHeight;

		private Material xFrameBillboardMat;

		private float lastNiceTimeCheck;

		private float avgFPSNice;

		private float lastInspectorRefresh;

		private int camMovDetectThreshold;

		private PropertyInfo renderScaleProp;

		private PropertyInfo shadowDistanceProp;

		private PropertyInfo maxAdditionalLightsCountProp;

		private RenderPipelineAsset pipelineAsset;

		private Canvas[] canvases;

		private List<RaycastResult> hitResults;

		private bool niceMode;

		private float oldLODBias;

		public XFRAME_DOWNSAMPLING_METHOD method
		{
			get
			{
				return default(XFRAME_DOWNSAMPLING_METHOD);
			}
			set
			{
			}
		}

		public XFRAME_FILTERING_MODE filtering
		{
			get
			{
				return default(XFRAME_FILTERING_MODE);
			}
			set
			{
			}
		}

		public bool hdr
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int targetFPS
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int targetFPSforStaticCamera
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public CameraClearFlags cameraClearFlags
		{
			get
			{
				return default(CameraClearFlags);
			}
			set
			{
			}
		}

		public bool niceFPSEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool prewarm
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int niceFPS
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool niceFPSisActive => false;

		public float downsampling
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float staticCameraDownsampling
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float downsamplingMax
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float downsamplingStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float fpsChangeSpeedUp
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float fpsChangeSpeedDown
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool sharpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int antialias
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool blendWithBackground
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool reducePixelLights
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float reducePixelLightsThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool manageLODBias
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float lodBiasMinimum
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float lodBiasMaximum
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float staticCameraPositionThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool manageShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float manageShadowsMinDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float manageShadowsMinInterval
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public XFRAME_COMPOSITING_METHOD compositingMethod
		{
			get
			{
				return default(XFRAME_COMPOSITING_METHOD);
			}
			set
			{
			}
		}

		public bool showFPS
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool showQuality
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int fpsFontSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Color fpsColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public XFRAME_FPS_LOCATION fpsLocation
		{
			get
			{
				return default(XFRAME_FPS_LOCATION);
			}
			set
			{
			}
		}

		public bool boostFrameRate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static XFrameManager instance => null;

		public int currentFPS => 0;

		public float appliedDownsampling => 0f;

		public RenderTexture rt => null;

		public float activeDownsampling => 0f;

		public int activeTargetFPS => 0;

		private int screenWidth => 0;

		private int screenHeight => 0;

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void Start()
		{
		}

		private void Reset()
		{
		}

		private void OnApplicationPause(bool pause)
		{
		}

		private void Init()
		{
		}

		private void CheckStatsLayer()
		{
		}

		private void CheckPipeline()
		{
		}

		private void ClearOldInstancedCamera()
		{
		}

		private void PrewarmRTs()
		{
		}

		private void ClearRTArray()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void DestroyXFrameCamera()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnPreRender()
		{
		}

		private void UpdateSettings()
		{
		}

		private void CheckCamera()
		{
		}

		private GameObject FindGameObject(string name)
		{
			return null;
		}

		private void SetupSecondCameraBlitMode()
		{
		}

		private void SetupSecondCameraBillboardWorldSpaceMode()
		{
		}

		private void UpdateBillboardAspectRatio(float aspect)
		{
		}

		private Vector3 GetFarCameraPos()
		{
			return default(Vector3);
		}

		private float rtClamp(float d)
		{
			return 0f;
		}

		private int getAntialiasLevel()
		{
			return 0;
		}

		private RenderTexture FetchRT(int width, int height)
		{
			return null;
		}

		private RenderTexture PrepareAdaptativeRenderTexture()
		{
			return null;
		}

		private RenderTexture PrepareVerticalRenderTexture()
		{
			return null;
		}

		private RenderTexture PrepareQuadRenderTexture()
		{
			return null;
		}

		private void CheckAndReleaseRT(RenderTexture rt)
		{
		}

		private void CheckRT()
		{
		}

		private void ResetCameraAspect()
		{
		}

		public void UpdateUICanvases()
		{
		}

		public void UpdateUICanvas(Canvas canvas)
		{
		}

		public void RestoreUICanvases()
		{
		}

		public void RestoreUICanvas(Canvas canvas)
		{
		}

		private void ResetShadows()
		{
		}

		private void ManagePixelLights()
		{
		}

		private void ManageShadows()
		{
		}

		public Vector3 AdjustScreenPosition(Vector3 position, bool targetIsDownscaled = true)
		{
			return default(Vector3);
		}

		public Ray ScreenPointToRay(Camera camera, Vector3 position)
		{
			return default(Ray);
		}

		private void DoRaycasting()
		{
		}

		public RaycastResult Raycast(Camera camera, Vector3 pointerPosition)
		{
			return default(RaycastResult);
		}

		public bool IsPointerOverUIElement()
		{
			return false;
		}

		public bool IsPointerOverUIElement(Vector3 pointerPosition)
		{
			return false;
		}

		public bool IsPointerOverUIButton()
		{
			return false;
		}

		public bool IsPointerOverUIButton(Vector3 pointerPosition)
		{
			return false;
		}

		public bool IsPointerOverGameObject(Camera camera, Vector3 pointerPosition)
		{
			return false;
		}
	}
}
