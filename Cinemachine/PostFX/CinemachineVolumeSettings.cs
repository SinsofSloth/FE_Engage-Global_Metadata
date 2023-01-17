// Namespace: Cinemachine.PostFX
[ExecuteAlways] // RVA: 0x1BE30 Offset: 0x1BF31 VA: 0x1BE30
[SaveDuringPlayAttribute] // RVA: 0x1BE30 Offset: 0x1BF31 VA: 0x1BE30
[DisallowMultipleComponent] // RVA: 0x1BE30 Offset: 0x1BF31 VA: 0x1BE30
[HelpURLAttribute] // RVA: 0x1BE30 Offset: 0x1BF31 VA: 0x1BE30
[DocumentationSortingAttribute] // RVA: 0x1BE30 Offset: 0x1BF31 VA: 0x1BE30
[AddComponentMenu] // RVA: 0x1BE30 Offset: 0x1BF31 VA: 0x1BE30
public class CinemachineVolumeSettings : CinemachineExtension // TypeDefIndex: 5896
{
	// Fields
	public static float s_VolumePriority; // 0x0
	[HideInInspector] // RVA: 0x23330 Offset: 0x23431 VA: 0x23330
	public bool m_FocusTracksTarget; // 0x28
	[TooltipAttribute] // RVA: 0x23340 Offset: 0x23441 VA: 0x23340
	public CinemachineVolumeSettings.FocusTrackingMode m_FocusTracking; // 0x2C
	[TooltipAttribute] // RVA: 0x23380 Offset: 0x23481 VA: 0x23380
	public Transform m_FocusTarget; // 0x30
	[TooltipAttribute] // RVA: 0x233C0 Offset: 0x234C1 VA: 0x233C0
	public float m_FocusOffset; // 0x38
	[TooltipAttribute] // RVA: 0x23400 Offset: 0x23501 VA: 0x23400
	public VolumeProfile m_Profile; // 0x40
	private static string sVolumeOwnerName; // 0x8
	private static List<Volume> sVolumes; // 0x10

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0x1A80170 Offset: 0x1A80271 VA: 0x1A80170
	public bool get_IsValid() { }

	// RVA: 0x1A80220 Offset: 0x1A80321 VA: 0x1A80220
	public void InvalidateCachedProfile() { }

	// RVA: 0x1A803A0 Offset: 0x1A804A1 VA: 0x1A803A0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1A80460 Offset: 0x1A80561 VA: 0x1A80460 Slot: 6
	protected override void OnDestroy() { }

	// RVA: 0x1A80490 Offset: 0x1A80591 VA: 0x1A80490 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1A80980 Offset: 0x1A80A81 VA: 0x1A80980
	private static void OnCameraCut(CinemachineBrain brain) { }

	// RVA: 0x1A80990 Offset: 0x1A80A91 VA: 0x1A80990
	private static void ApplyPostFX(CinemachineBrain brain) { }

	// RVA: 0x1A80C90 Offset: 0x1A80D91 VA: 0x1A80C90
	private static List<Volume> GetDynamicBrainVolumes(CinemachineBrain brain, int minVolumes) { }

	[RuntimeInitializeOnLoadMethodAttribute] // RVA: 0x240C0 Offset: 0x241C1 VA: 0x240C0
	// RVA: 0x1A81260 Offset: 0x1A81361 VA: 0x1A81260
	private static void InitializeModule() { }

	// RVA: 0x1A81430 Offset: 0x1A81531 VA: 0x1A81430
	public void .ctor() { }

	// RVA: 0x1A81440 Offset: 0x1A81541 VA: 0x1A81440
	private static void .cctor() { }
}

