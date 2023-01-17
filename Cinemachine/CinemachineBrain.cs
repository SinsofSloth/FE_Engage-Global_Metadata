// Namespace: Cinemachine
[DisallowMultipleComponent] // RVA: 0x1A650 Offset: 0x1A751 VA: 0x1A650
[ExecuteAlways] // RVA: 0x1A650 Offset: 0x1A751 VA: 0x1A650
[AddComponentMenu] // RVA: 0x1A650 Offset: 0x1A751 VA: 0x1A650
[SaveDuringPlayAttribute] // RVA: 0x1A650 Offset: 0x1A751 VA: 0x1A650
[HelpURLAttribute] // RVA: 0x1A650 Offset: 0x1A751 VA: 0x1A650
[DocumentationSortingAttribute] // RVA: 0x1A650 Offset: 0x1A751 VA: 0x1A650
public class CinemachineBrain : MonoBehaviour // TypeDefIndex: 5739
{
	// Fields
	[TooltipAttribute] // RVA: 0x1C5D0 Offset: 0x1C6D1 VA: 0x1C5D0
	public bool m_ShowDebugText; // 0x18
	[TooltipAttribute] // RVA: 0x1C610 Offset: 0x1C711 VA: 0x1C610
	public bool m_ShowCameraFrustum; // 0x19
	[TooltipAttribute] // RVA: 0x1C650 Offset: 0x1C751 VA: 0x1C650
	public bool m_IgnoreTimeScale; // 0x1A
	[TooltipAttribute] // RVA: 0x1C690 Offset: 0x1C791 VA: 0x1C690
	public Transform m_WorldUpOverride; // 0x20
	[TooltipAttribute] // RVA: 0x1C6D0 Offset: 0x1C7D1 VA: 0x1C6D0
	public CinemachineBrain.UpdateMethod m_UpdateMethod; // 0x28
	[TooltipAttribute] // RVA: 0x1C710 Offset: 0x1C811 VA: 0x1C710
	public CinemachineBrain.BrainUpdateMethod m_BlendUpdateMethod; // 0x2C
	[TooltipAttribute] // RVA: 0x1C750 Offset: 0x1C851 VA: 0x1C750
	[CinemachineBlendDefinitionPropertyAttribute] // RVA: 0x1C750 Offset: 0x1C851 VA: 0x1C750
	public CinemachineBlendDefinition m_DefaultBlend; // 0x30
	[TooltipAttribute] // RVA: 0x1C7A0 Offset: 0x1C8A1 VA: 0x1C7A0
	public CinemachineBlenderSettings m_CustomBlends; // 0x40
	private Camera m_OutputCamera; // 0x48
	[TooltipAttribute] // RVA: 0x1C7E0 Offset: 0x1C8E1 VA: 0x1C7E0
	public CinemachineBrain.BrainEvent m_CameraCutEvent; // 0x50
	[TooltipAttribute] // RVA: 0x1C820 Offset: 0x1C921 VA: 0x1C820
	public CinemachineBrain.VcamActivatedEvent m_CameraActivatedEvent; // 0x58
	private static ICinemachineCamera mSoloCamera; // 0x0
	private Coroutine mPhysicsCoroutine; // 0x60
	private WaitForFixedUpdate mWaitForFixedUpdate; // 0x68
	private List<CinemachineBrain.BrainFrame> mFrameStack; // 0x70
	private int mNextFrameId; // 0x78
	private CinemachineBlend mCurrentLiveCameras; // 0x80
	private static readonly AnimationCurve mDefaultLinearAnimationCurve; // 0x8
	private ICinemachineCamera mActiveCameraPreviousFrame; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x1C860 Offset: 0x1C961 VA: 0x1C860
	private CameraState <CurrentCameraState>k__BackingField; // 0x90

	// Properties
	public Camera OutputCamera { get; }
	public static ICinemachineCamera SoloCamera { get; set; }
	public Vector3 DefaultWorldUp { get; }
	public ICinemachineCamera ActiveVirtualCamera { get; }
	public bool IsBlending { get; }
	public CinemachineBlend ActiveBlend { get; }
	public CameraState CurrentCameraState { get; set; }

	// Methods

	// RVA: 0x1B84AE0 Offset: 0x1B84BE1 VA: 0x1B84AE0
	public Camera get_OutputCamera() { }

	// RVA: 0x1B89200 Offset: 0x1B89301 VA: 0x1B89200
	public static ICinemachineCamera get_SoloCamera() { }

	// RVA: 0x1B89270 Offset: 0x1B89371 VA: 0x1B89270
	public static void set_SoloCamera(ICinemachineCamera value) { }

	// RVA: 0x1B89690 Offset: 0x1B89791 VA: 0x1B89690
	public static Color GetSoloGUIColor() { }

	// RVA: 0x1B89710 Offset: 0x1B89811 VA: 0x1B89710
	public Vector3 get_DefaultWorldUp() { }

	// RVA: 0x1B897B0 Offset: 0x1B898B1 VA: 0x1B897B0
	private void OnEnable() { }

	// RVA: 0x1B89CD0 Offset: 0x1B89DD1 VA: 0x1B89CD0
	private void OnDisable() { }

	// RVA: 0x1B89FC0 Offset: 0x1B8A0C1 VA: 0x1B89FC0
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	// RVA: 0x1B8A1E0 Offset: 0x1B8A2E1 VA: 0x1B8A1E0
	private void OnSceneUnloaded(Scene scene) { }

	// RVA: 0x1B8A1F0 Offset: 0x1B8A2F1 VA: 0x1B8A1F0
	private void Start() { }

	// RVA: 0x1B8A520 Offset: 0x1B8A621 VA: 0x1B8A520
	private void OnGuiHandler() { }

	[IteratorStateMachineAttribute] // RVA: 0x234A0 Offset: 0x235A1 VA: 0x234A0
	// RVA: 0x1B89C50 Offset: 0x1B89D51 VA: 0x1B89C50
	private IEnumerator AfterPhysics() { }

	// RVA: 0x1B8AC70 Offset: 0x1B8AD71 VA: 0x1B8AC70
	private void LateUpdate() { }

	// RVA: 0x1B89FD0 Offset: 0x1B8A0D1 VA: 0x1B89FD0
	public void ManualUpdate() { }

	// RVA: 0x1B8AC90 Offset: 0x1B8AD91 VA: 0x1B8AC90
	private float GetEffectiveDeltaTime(bool fixedDelta) { }

	// RVA: 0x1B8A200 Offset: 0x1B8A301 VA: 0x1B8A200
	private void UpdateVirtualCameras(CinemachineCore.UpdateFilter updateFilter, float deltaTime) { }

	// RVA: 0x1B8AAF0 Offset: 0x1B8ABF1 VA: 0x1B8AAF0
	public ICinemachineCamera get_ActiveVirtualCamera() { }

	// RVA: 0x1B8BFB0 Offset: 0x1B8C0B1 VA: 0x1B8BFB0
	private static ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend) { }

	// RVA: 0x1B8A9B0 Offset: 0x1B8AAB1 VA: 0x1B8A9B0
	public bool get_IsBlending() { }

	// RVA: 0x1B8A9D0 Offset: 0x1B8AAD1 VA: 0x1B8A9D0
	public CinemachineBlend get_ActiveBlend() { }

	// RVA: 0x1B8C0D0 Offset: 0x1B8C1D1 VA: 0x1B8C0D0
	private int GetBrainFrame(int withId) { }

	// RVA: 0x1B8C1E0 Offset: 0x1B8C2E1 VA: 0x1B8C1E0
	public int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime) { }

	// RVA: 0x1B8C440 Offset: 0x1B8C541 VA: 0x1B8C440
	public void ReleaseCameraOverride(int overrideId) { }

	// RVA: 0x1B8B5F0 Offset: 0x1B8B6F1 VA: 0x1B8B5F0
	private void ProcessActiveCamera(float deltaTime) { }

	// RVA: 0x1B8AED0 Offset: 0x1B8AFD1 VA: 0x1B8AED0
	private void UpdateFrame0(float deltaTime) { }

	// RVA: 0x1B8B290 Offset: 0x1B8B391 VA: 0x1B8B290
	public void ComputeCurrentBlend(ref CinemachineBlend outputBlend, int numTopLayersToExclude) { }

	// RVA: 0x1B847D0 Offset: 0x1B848D1 VA: 0x1B847D0
	public bool IsLive(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	[CompilerGeneratedAttribute] // RVA: 0x23510 Offset: 0x23611 VA: 0x23510
	// RVA: 0x1B8CBD0 Offset: 0x1B8CCD1 VA: 0x1B8CBD0
	public CameraState get_CurrentCameraState() { }

	[CompilerGeneratedAttribute] // RVA: 0x23520 Offset: 0x23621 VA: 0x23520
	// RVA: 0x1B8CBE0 Offset: 0x1B8CCE1 VA: 0x1B8CBE0
	private void set_CurrentCameraState(CameraState value) { }

	// RVA: 0x1B8C760 Offset: 0x1B8C861 VA: 0x1B8C760
	private ICinemachineCamera TopCameraFromPriorityQueue() { }

	// RVA: 0x1B8C970 Offset: 0x1B8CA71 VA: 0x1B8C970
	private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) { }

	// RVA: 0x1B8C520 Offset: 0x1B8C621 VA: 0x1B8C520
	private void PushStateToUnityCamera(CameraState state) { }

	// RVA: 0x1B8CCD0 Offset: 0x1B8CDD1 VA: 0x1B8CCD0
	public void .ctor() { }

	// RVA: 0x1B8CEE0 Offset: 0x1B8CFE1 VA: 0x1B8CEE0
	private static void .cctor() { }
}

