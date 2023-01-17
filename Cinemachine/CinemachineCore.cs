// Namespace: Cinemachine
public sealed class CinemachineCore // TypeDefIndex: 5829
{
	// Fields
	public static readonly int kStreamingVersion; // 0x0
	public static readonly string kVersionString; // 0x8
	private static CinemachineCore sInstance; // 0x10
	public static bool sShowHiddenObjects; // 0x18
	public static CinemachineCore.AxisInputDelegate GetInputAxis; // 0x20
	public static float UniformDeltaTimeOverride; // 0x28
	public static float CurrentTimeOverride; // 0x2C
	public static CinemachineCore.GetBlendOverrideDelegate GetBlendOverride; // 0x30
	public static CinemachineBrain.BrainEvent CameraUpdatedEvent; // 0x38
	public static CinemachineBrain.BrainEvent CameraCutEvent; // 0x40
	private List<CinemachineBrain> mActiveBrains; // 0x10
	private List<CinemachineVirtualCameraBase> mActiveCameras; // 0x18
	private List<List<CinemachineVirtualCameraBase>> mAllCameras; // 0x20
	private CinemachineVirtualCameraBase mRoundRobinVcamLastFrame; // 0x28
	private static float mLastUpdateTime; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x21770 Offset: 0x21871 VA: 0x21770
	private static int <FixedFrameCount>k__BackingField; // 0x4C
	private Dictionary<CinemachineVirtualCameraBase, CinemachineCore.UpdateStatus> mUpdateStatus; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x21780 Offset: 0x21881 VA: 0x21780
	private CinemachineCore.UpdateFilter <CurrentUpdateFilter>k__BackingField; // 0x38

	// Properties
	public static CinemachineCore Instance { get; }
	public static float DeltaTime { get; }
	public static float CurrentTime { get; }
	public int BrainCount { get; }
	public int VirtualCameraCount { get; }
	private static int FixedFrameCount { get; set; }
	internal CinemachineCore.UpdateFilter CurrentUpdateFilter { get; set; }

	// Methods

	// RVA: 0x1B88400 Offset: 0x1B88501 VA: 0x1B88400
	public static CinemachineCore get_Instance() { }

	// RVA: 0x1B895D0 Offset: 0x1B896D1 VA: 0x1B895D0
	public static float get_DeltaTime() { }

	// RVA: 0x1B86AD0 Offset: 0x1B86BD1 VA: 0x1B86AD0
	public static float get_CurrentTime() { }

	// RVA: 0x1B95CB0 Offset: 0x1B95DB1 VA: 0x1B95CB0
	public int get_BrainCount() { }

	// RVA: 0x1B95D00 Offset: 0x1B95E01 VA: 0x1B95D00
	public CinemachineBrain GetActiveBrain(int index) { }

	// RVA: 0x1B89BB0 Offset: 0x1B89CB1 VA: 0x1B89BB0
	internal void AddActiveBrain(CinemachineBrain brain) { }

	// RVA: 0x1B89F60 Offset: 0x1B8A061 VA: 0x1B89F60
	internal void RemoveActiveBrain(CinemachineBrain brain) { }

	// RVA: 0x1B8CC10 Offset: 0x1B8CD11 VA: 0x1B8CC10
	public int get_VirtualCameraCount() { }

	// RVA: 0x1B8CC60 Offset: 0x1B8CD61 VA: 0x1B8CC60
	public CinemachineVirtualCameraBase GetVirtualCamera(int index) { }

	// RVA: 0x1B95D70 Offset: 0x1B95E71 VA: 0x1B95D70
	internal void AddActiveCamera(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1B95E90 Offset: 0x1B95F91 VA: 0x1B95E90
	internal void RemoveActiveCamera(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1B95EF0 Offset: 0x1B95FF1 VA: 0x1B95EF0
	internal void CameraDestroyed(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1B95FE0 Offset: 0x1B960E1 VA: 0x1B95FE0
	internal void CameraEnabled(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1B961A0 Offset: 0x1B962A1 VA: 0x1B961A0
	internal void CameraDisabled(CinemachineVirtualCameraBase vcam) { }

	[CompilerGeneratedAttribute] // RVA: 0x23E20 Offset: 0x23F21 VA: 0x23E20
	// RVA: 0x1B962D0 Offset: 0x1B963D1 VA: 0x1B962D0
	private static int get_FixedFrameCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x23E30 Offset: 0x23F31 VA: 0x23E30
	// RVA: 0x1B96340 Offset: 0x1B96441 VA: 0x1B96340
	private static void set_FixedFrameCount(int value) { }

	// RVA: 0x1B8BA60 Offset: 0x1B8BB61 VA: 0x1B8BA60
	internal void UpdateAllActiveVirtualCameras(int layerMask, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1B963B0 Offset: 0x1B964B1 VA: 0x1B963B0
	internal void UpdateVirtualCamera(CinemachineVirtualCameraBase vcam, Vector3 worldUp, float deltaTime) { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x23E40 Offset: 0x23F41 VA: 0x23E40
	// RVA: 0x1B96950 Offset: 0x1B96A51 VA: 0x1B96950
	private static void InitializeModule() { }

	[CompilerGeneratedAttribute] // RVA: 0x23E50 Offset: 0x23F51 VA: 0x23E50
	// RVA: 0x1B96A00 Offset: 0x1B96B01 VA: 0x1B96A00
	internal CinemachineCore.UpdateFilter get_CurrentUpdateFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x23E60 Offset: 0x23F61 VA: 0x23E60
	// RVA: 0x1B96A10 Offset: 0x1B96B11 VA: 0x1B96A10
	internal void set_CurrentUpdateFilter(CinemachineCore.UpdateFilter value) { }

	// RVA: 0x1B967F0 Offset: 0x1B968F1 VA: 0x1B967F0
	private static Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1B96A20 Offset: 0x1B96B21 VA: 0x1B96A20
	internal UpdateTracker.UpdateClock GetVcamUpdateStatus(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1B89490 Offset: 0x1B89591 VA: 0x1B89490
	public bool IsLive(ICinemachineCamera vcam) { }

	// RVA: 0x1B884E0 Offset: 0x1B885E1 VA: 0x1B884E0
	public void GenerateCameraActivationEvent(ICinemachineCamera vcam, ICinemachineCamera vcamFrom) { }

	// RVA: 0x1B88650 Offset: 0x1B88751 VA: 0x1B88650
	public void GenerateCameraCutEvent(ICinemachineCamera vcam) { }

	// RVA: 0x1B96AB0 Offset: 0x1B96BB1 VA: 0x1B96AB0
	public CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1B95B70 Offset: 0x1B95C71 VA: 0x1B95B70
	public void .ctor() { }

	// RVA: 0x1B96D50 Offset: 0x1B96E51 VA: 0x1B96D50
	private static void .cctor() { }
}

