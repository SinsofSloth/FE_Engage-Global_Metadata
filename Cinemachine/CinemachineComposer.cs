// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1B320 Offset: 0x1B421 VA: 0x1B320
[AddComponentMenu] // RVA: 0x1B320 Offset: 0x1B421 VA: 0x1B320
[SaveDuringPlayAttribute] // RVA: 0x1B320 Offset: 0x1B421 VA: 0x1B320
public class CinemachineComposer : CinemachineComponentBase // TypeDefIndex: 5785
{
	// Fields
	[TooltipAttribute] // RVA: 0x1EDE0 Offset: 0x1EEE1 VA: 0x1EDE0
	public Vector3 m_TrackedObjectOffset; // 0x50
	[SpaceAttribute] // RVA: 0x1EE20 Offset: 0x1EF21 VA: 0x1EE20
	[TooltipAttribute] // RVA: 0x1EE20 Offset: 0x1EF21 VA: 0x1EE20
	[RangeAttribute] // RVA: 0x1EE20 Offset: 0x1EF21 VA: 0x1EE20
	public float m_LookaheadTime; // 0x5C
	[TooltipAttribute] // RVA: 0x1EE90 Offset: 0x1EF91 VA: 0x1EE90
	[RangeAttribute] // RVA: 0x1EE90 Offset: 0x1EF91 VA: 0x1EE90
	public float m_LookaheadSmoothing; // 0x60
	[TooltipAttribute] // RVA: 0x1EEF0 Offset: 0x1EFF1 VA: 0x1EEF0
	public bool m_LookaheadIgnoreY; // 0x64
	[TooltipAttribute] // RVA: 0x1EF30 Offset: 0x1F031 VA: 0x1EF30
	[RangeAttribute] // RVA: 0x1EF30 Offset: 0x1F031 VA: 0x1EF30
	[SpaceAttribute] // RVA: 0x1EF30 Offset: 0x1F031 VA: 0x1EF30
	public float m_HorizontalDamping; // 0x68
	[TooltipAttribute] // RVA: 0x1EFA0 Offset: 0x1F0A1 VA: 0x1EFA0
	[RangeAttribute] // RVA: 0x1EFA0 Offset: 0x1F0A1 VA: 0x1EFA0
	public float m_VerticalDamping; // 0x6C
	[SpaceAttribute] // RVA: 0x1F000 Offset: 0x1F101 VA: 0x1F000
	[RangeAttribute] // RVA: 0x1F000 Offset: 0x1F101 VA: 0x1F000
	[TooltipAttribute] // RVA: 0x1F000 Offset: 0x1F101 VA: 0x1F000
	public float m_ScreenX; // 0x70
	[RangeAttribute] // RVA: 0x1F070 Offset: 0x1F171 VA: 0x1F070
	[TooltipAttribute] // RVA: 0x1F070 Offset: 0x1F171 VA: 0x1F070
	public float m_ScreenY; // 0x74
	[RangeAttribute] // RVA: 0x1F0D0 Offset: 0x1F1D1 VA: 0x1F0D0
	[TooltipAttribute] // RVA: 0x1F0D0 Offset: 0x1F1D1 VA: 0x1F0D0
	public float m_DeadZoneWidth; // 0x78
	[RangeAttribute] // RVA: 0x1F130 Offset: 0x1F231 VA: 0x1F130
	[TooltipAttribute] // RVA: 0x1F130 Offset: 0x1F231 VA: 0x1F130
	public float m_DeadZoneHeight; // 0x7C
	[TooltipAttribute] // RVA: 0x1F190 Offset: 0x1F291 VA: 0x1F190
	[RangeAttribute] // RVA: 0x1F190 Offset: 0x1F291 VA: 0x1F190
	public float m_SoftZoneWidth; // 0x80
	[RangeAttribute] // RVA: 0x1F1F0 Offset: 0x1F2F1 VA: 0x1F1F0
	[TooltipAttribute] // RVA: 0x1F1F0 Offset: 0x1F2F1 VA: 0x1F1F0
	public float m_SoftZoneHeight; // 0x84
	[TooltipAttribute] // RVA: 0x1F250 Offset: 0x1F351 VA: 0x1F250
	[RangeAttribute] // RVA: 0x1F250 Offset: 0x1F351 VA: 0x1F250
	public float m_BiasX; // 0x88
	[RangeAttribute] // RVA: 0x1F2B0 Offset: 0x1F3B1 VA: 0x1F2B0
	[TooltipAttribute] // RVA: 0x1F2B0 Offset: 0x1F3B1 VA: 0x1F2B0
	public float m_BiasY; // 0x8C
	[TooltipAttribute] // RVA: 0x1F310 Offset: 0x1F411 VA: 0x1F310
	public bool m_CenterOnActivate; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x1F350 Offset: 0x1F451 VA: 0x1F350
	private Vector3 <TrackedPoint>k__BackingField; // 0x94
	private Vector3 m_CameraPosPrevFrame; // 0xA0
	private Vector3 m_LookAtPrevFrame; // 0xAC
	private Vector2 m_ScreenOffsetPrevFrame; // 0xB8
	private Quaternion m_CameraOrientationPrevFrame; // 0xC0
	internal PositionPredictor m_Predictor; // 0xD0
	private CinemachineComposer.FovCache mCache; // 0xD8

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	public Vector3 TrackedPoint { get; set; }
	internal Rect SoftGuideRect { get; set; }
	internal Rect HardGuideRect { get; set; }

	// Methods

	// RVA: 0x1B93730 Offset: 0x1B93831 VA: 0x1B93730 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1B93840 Offset: 0x1B93941 VA: 0x1B93840 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	[CompilerGeneratedAttribute] // RVA: 0x236F0 Offset: 0x237F1 VA: 0x236F0
	// RVA: 0x1B93850 Offset: 0x1B93951 VA: 0x1B93850
	public Vector3 get_TrackedPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x23700 Offset: 0x23801 VA: 0x23700
	// RVA: 0x1B93860 Offset: 0x1B93961 VA: 0x1B93860
	private void set_TrackedPoint(Vector3 value) { }

	// RVA: 0x1B93870 Offset: 0x1B93971 VA: 0x1B93870 Slot: 13
	protected virtual Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt, Vector3 up, float deltaTime) { }

	// RVA: 0x1B93A80 Offset: 0x1B93B81 VA: 0x1B93A80 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1B93C00 Offset: 0x1B93D01 VA: 0x1B93C00 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1B93C20 Offset: 0x1B93D21 VA: 0x1B93C20 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1B93C30 Offset: 0x1B93D31 VA: 0x1B93C30 Slot: 5
	public override void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1B93CC0 Offset: 0x1B93DC1 VA: 0x1B93CC0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1B94300 Offset: 0x1B94401 VA: 0x1B94300
	internal Rect get_SoftGuideRect() { }

	// RVA: 0x1B94620 Offset: 0x1B94721 VA: 0x1B94620
	internal void set_SoftGuideRect(Rect value) { }

	// RVA: 0x1B94350 Offset: 0x1B94451 VA: 0x1B94350
	internal Rect get_HardGuideRect() { }

	// RVA: 0x1B94730 Offset: 0x1B94831 VA: 0x1B94730
	internal void set_HardGuideRect(Rect value) { }

	// RVA: 0x1B943F0 Offset: 0x1B944F1 VA: 0x1B943F0
	private void RotateToScreenBounds(ref CameraState state, Rect screenRect, Vector3 trackedPoint, ref Quaternion rigOrientation, float fov, float fovH, float deltaTime) { }

	// RVA: 0x1B948B0 Offset: 0x1B949B1 VA: 0x1B948B0
	private bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov) { }

	// RVA: 0x1B949F0 Offset: 0x1B94AF1 VA: 0x1B949F0
	public void .ctor() { }
}

