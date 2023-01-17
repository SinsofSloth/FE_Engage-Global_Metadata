// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1B380 Offset: 0x1B481 VA: 0x1B380
[AddComponentMenu] // RVA: 0x1B380 Offset: 0x1B481 VA: 0x1B380
[SaveDuringPlayAttribute] // RVA: 0x1B380 Offset: 0x1B481 VA: 0x1B380
public class CinemachineFramingTransposer : CinemachineComponentBase // TypeDefIndex: 5788
{
	// Fields
	[TooltipAttribute] // RVA: 0x1F360 Offset: 0x1F461 VA: 0x1F360
	public Vector3 m_TrackedObjectOffset; // 0x50
	[TooltipAttribute] // RVA: 0x1F3A0 Offset: 0x1F4A1 VA: 0x1F3A0
	[RangeAttribute] // RVA: 0x1F3A0 Offset: 0x1F4A1 VA: 0x1F3A0
	[SpaceAttribute] // RVA: 0x1F3A0 Offset: 0x1F4A1 VA: 0x1F3A0
	public float m_LookaheadTime; // 0x5C
	[TooltipAttribute] // RVA: 0x1F410 Offset: 0x1F511 VA: 0x1F410
	[RangeAttribute] // RVA: 0x1F410 Offset: 0x1F511 VA: 0x1F410
	public float m_LookaheadSmoothing; // 0x60
	[TooltipAttribute] // RVA: 0x1F470 Offset: 0x1F571 VA: 0x1F470
	public bool m_LookaheadIgnoreY; // 0x64
	[SpaceAttribute] // RVA: 0x1F4B0 Offset: 0x1F5B1 VA: 0x1F4B0
	[RangeAttribute] // RVA: 0x1F4B0 Offset: 0x1F5B1 VA: 0x1F4B0
	[TooltipAttribute] // RVA: 0x1F4B0 Offset: 0x1F5B1 VA: 0x1F4B0
	public float m_XDamping; // 0x68
	[RangeAttribute] // RVA: 0x1F520 Offset: 0x1F621 VA: 0x1F520
	[TooltipAttribute] // RVA: 0x1F520 Offset: 0x1F621 VA: 0x1F520
	public float m_YDamping; // 0x6C
	[RangeAttribute] // RVA: 0x1F580 Offset: 0x1F681 VA: 0x1F580
	[TooltipAttribute] // RVA: 0x1F580 Offset: 0x1F681 VA: 0x1F580
	public float m_ZDamping; // 0x70
	[TooltipAttribute] // RVA: 0x1F5E0 Offset: 0x1F6E1 VA: 0x1F5E0
	public bool m_TargetMovementOnly; // 0x74
	[SpaceAttribute] // RVA: 0x1F620 Offset: 0x1F721 VA: 0x1F620
	[RangeAttribute] // RVA: 0x1F620 Offset: 0x1F721 VA: 0x1F620
	[TooltipAttribute] // RVA: 0x1F620 Offset: 0x1F721 VA: 0x1F620
	public float m_ScreenX; // 0x78
	[RangeAttribute] // RVA: 0x1F690 Offset: 0x1F791 VA: 0x1F690
	[TooltipAttribute] // RVA: 0x1F690 Offset: 0x1F791 VA: 0x1F690
	public float m_ScreenY; // 0x7C
	[TooltipAttribute] // RVA: 0x1F6F0 Offset: 0x1F7F1 VA: 0x1F6F0
	public float m_CameraDistance; // 0x80
	[SpaceAttribute] // RVA: 0x1F730 Offset: 0x1F831 VA: 0x1F730
	[RangeAttribute] // RVA: 0x1F730 Offset: 0x1F831 VA: 0x1F730
	[TooltipAttribute] // RVA: 0x1F730 Offset: 0x1F831 VA: 0x1F730
	public float m_DeadZoneWidth; // 0x84
	[TooltipAttribute] // RVA: 0x1F7A0 Offset: 0x1F8A1 VA: 0x1F7A0
	[RangeAttribute] // RVA: 0x1F7A0 Offset: 0x1F8A1 VA: 0x1F7A0
	public float m_DeadZoneHeight; // 0x88
	[TooltipAttribute] // RVA: 0x1F800 Offset: 0x1F901 VA: 0x1F800
	[FormerlySerializedAsAttribute] // RVA: 0x1F800 Offset: 0x1F901 VA: 0x1F800
	public float m_DeadZoneDepth; // 0x8C
	[SpaceAttribute] // RVA: 0x1F860 Offset: 0x1F961 VA: 0x1F860
	[TooltipAttribute] // RVA: 0x1F860 Offset: 0x1F961 VA: 0x1F860
	public bool m_UnlimitedSoftZone; // 0x90
	[RangeAttribute] // RVA: 0x1F8B0 Offset: 0x1F9B1 VA: 0x1F8B0
	[TooltipAttribute] // RVA: 0x1F8B0 Offset: 0x1F9B1 VA: 0x1F8B0
	public float m_SoftZoneWidth; // 0x94
	[RangeAttribute] // RVA: 0x1F910 Offset: 0x1FA11 VA: 0x1F910
	[TooltipAttribute] // RVA: 0x1F910 Offset: 0x1FA11 VA: 0x1F910
	public float m_SoftZoneHeight; // 0x98
	[RangeAttribute] // RVA: 0x1F970 Offset: 0x1FA71 VA: 0x1F970
	[TooltipAttribute] // RVA: 0x1F970 Offset: 0x1FA71 VA: 0x1F970
	public float m_BiasX; // 0x9C
	[TooltipAttribute] // RVA: 0x1F9D0 Offset: 0x1FAD1 VA: 0x1F9D0
	[RangeAttribute] // RVA: 0x1F9D0 Offset: 0x1FAD1 VA: 0x1F9D0
	public float m_BiasY; // 0xA0
	[TooltipAttribute] // RVA: 0x1FA30 Offset: 0x1FB31 VA: 0x1FA30
	public bool m_CenterOnActivate; // 0xA4
	[TooltipAttribute] // RVA: 0x1FA70 Offset: 0x1FB71 VA: 0x1FA70
	[FormerlySerializedAsAttribute] // RVA: 0x1FA70 Offset: 0x1FB71 VA: 0x1FA70
	[SpaceAttribute] // RVA: 0x1FA70 Offset: 0x1FB71 VA: 0x1FA70
	public CinemachineFramingTransposer.FramingMode m_GroupFramingMode; // 0xA8
	[TooltipAttribute] // RVA: 0x1FAE0 Offset: 0x1FBE1 VA: 0x1FAE0
	public CinemachineFramingTransposer.AdjustmentMode m_AdjustmentMode; // 0xAC
	[TooltipAttribute] // RVA: 0x1FB20 Offset: 0x1FC21 VA: 0x1FB20
	public float m_GroupFramingSize; // 0xB0
	[TooltipAttribute] // RVA: 0x1FB60 Offset: 0x1FC61 VA: 0x1FB60
	public float m_MaxDollyIn; // 0xB4
	[TooltipAttribute] // RVA: 0x1FBA0 Offset: 0x1FCA1 VA: 0x1FBA0
	public float m_MaxDollyOut; // 0xB8
	[TooltipAttribute] // RVA: 0x1FBE0 Offset: 0x1FCE1 VA: 0x1FBE0
	public float m_MinimumDistance; // 0xBC
	[TooltipAttribute] // RVA: 0x1FC20 Offset: 0x1FD21 VA: 0x1FC20
	public float m_MaximumDistance; // 0xC0
	[TooltipAttribute] // RVA: 0x1FC60 Offset: 0x1FD61 VA: 0x1FC60
	[RangeAttribute] // RVA: 0x1FC60 Offset: 0x1FD61 VA: 0x1FC60
	public float m_MinimumFOV; // 0xC4
	[RangeAttribute] // RVA: 0x1FCC0 Offset: 0x1FDC1 VA: 0x1FCC0
	[TooltipAttribute] // RVA: 0x1FCC0 Offset: 0x1FDC1 VA: 0x1FCC0
	public float m_MaximumFOV; // 0xC8
	[TooltipAttribute] // RVA: 0x1FD20 Offset: 0x1FE21 VA: 0x1FD20
	public float m_MinimumOrthoSize; // 0xCC
	[TooltipAttribute] // RVA: 0x1FD60 Offset: 0x1FE61 VA: 0x1FD60
	public float m_MaximumOrthoSize; // 0xD0
	private const float kMinimumCameraDistance = 0.01;
	private const float kMinimumGroupSize = 0.01;
	private Vector3 m_PreviousCameraPosition; // 0xD4
	private PositionPredictor m_Predictor; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x1FDA0 Offset: 0x1FEA1 VA: 0x1FDA0
	private Vector3 <TrackedPoint>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x1FDB0 Offset: 0x1FEB1 VA: 0x1FDB0
	private bool <InheritingPosition>k__BackingField; // 0xF4
	private float m_prevFOV; // 0xF8
	private Quaternion m_prevRotation; // 0xFC
	[CompilerGeneratedAttribute] // RVA: 0x1FDC0 Offset: 0x1FEC1 VA: 0x1FDC0
	private Bounds <LastBounds>k__BackingField; // 0x10C
	[CompilerGeneratedAttribute] // RVA: 0x1FDD0 Offset: 0x1FED1 VA: 0x1FDD0
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; // 0x124

	// Properties
	internal Rect SoftGuideRect { get; set; }
	internal Rect HardGuideRect { get; set; }
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	public override bool BodyAppliesAfterAim { get; }
	public Vector3 TrackedPoint { get; set; }
	private bool InheritingPosition { get; set; }
	public Bounds LastBounds { get; set; }
	public Matrix4x4 LastBoundsMatrix { get; set; }

	// Methods

	// RVA: 0x1B984C0 Offset: 0x1B985C1 VA: 0x1B984C0
	internal Rect get_SoftGuideRect() { }

	// RVA: 0x1B98510 Offset: 0x1B98611 VA: 0x1B98510
	internal void set_SoftGuideRect(Rect value) { }

	// RVA: 0x1B98620 Offset: 0x1B98721 VA: 0x1B98620
	internal Rect get_HardGuideRect() { }

	// RVA: 0x1B986C0 Offset: 0x1B987C1 VA: 0x1B986C0
	internal void set_HardGuideRect(Rect value) { }

	// RVA: 0x1B98840 Offset: 0x1B98941 VA: 0x1B98840
	private void OnValidate() { }

	// RVA: 0x1B98960 Offset: 0x1B98A61 VA: 0x1B98960 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1B98A00 Offset: 0x1B98B01 VA: 0x1B98A00 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1B98A10 Offset: 0x1B98B11 VA: 0x1B98A10 Slot: 7
	public override bool get_BodyAppliesAfterAim() { }

	[CompilerGeneratedAttribute] // RVA: 0x23710 Offset: 0x23811 VA: 0x23710
	// RVA: 0x1B98A20 Offset: 0x1B98B21 VA: 0x1B98A20
	public Vector3 get_TrackedPoint() { }

	[CompilerGeneratedAttribute] // RVA: 0x23720 Offset: 0x23821 VA: 0x23720
	// RVA: 0x1B98A30 Offset: 0x1B98B31 VA: 0x1B98A30
	private void set_TrackedPoint(Vector3 value) { }

	// RVA: 0x1B98A40 Offset: 0x1B98B41 VA: 0x1B98A40 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1B98B50 Offset: 0x1B98C51 VA: 0x1B98B50 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1B98BD0 Offset: 0x1B98CD1 VA: 0x1B98BD0 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1B98C10 Offset: 0x1B98D11 VA: 0x1B98C10 Slot: 9
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	[CompilerGeneratedAttribute] // RVA: 0x23730 Offset: 0x23831 VA: 0x23730
	// RVA: 0x1B98D70 Offset: 0x1B98E71 VA: 0x1B98D70
	private bool get_InheritingPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x23740 Offset: 0x23841 VA: 0x23740
	// RVA: 0x1B98D80 Offset: 0x1B98E81 VA: 0x1B98D80
	private void set_InheritingPosition(bool value) { }

	// RVA: 0x1B98D90 Offset: 0x1B98E91 VA: 0x1B98D90
	private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect) { }

	// RVA: 0x1B98E70 Offset: 0x1B98F71 VA: 0x1B98E70
	private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect) { }

	[CompilerGeneratedAttribute] // RVA: 0x23750 Offset: 0x23851 VA: 0x23750
	// RVA: 0x1B98F70 Offset: 0x1B99071 VA: 0x1B98F70
	public Bounds get_LastBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x23760 Offset: 0x23861 VA: 0x23760
	// RVA: 0x1B98F90 Offset: 0x1B99091 VA: 0x1B98F90
	private void set_LastBounds(Bounds value) { }

	[CompilerGeneratedAttribute] // RVA: 0x23770 Offset: 0x23871 VA: 0x23770
	// RVA: 0x1B98FB0 Offset: 0x1B990B1 VA: 0x1B98FB0
	public Matrix4x4 get_LastBoundsMatrix() { }

	[CompilerGeneratedAttribute] // RVA: 0x23780 Offset: 0x23881 VA: 0x23780
	// RVA: 0x1B98FE0 Offset: 0x1B990E1 VA: 0x1B98FE0
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	// RVA: 0x1B99000 Offset: 0x1B99101 VA: 0x1B99000 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1B9A070 Offset: 0x1B9A171 VA: 0x1B9A070
	private float GetTargetHeight(Vector2 boundsSize) { }

	// RVA: 0x1B99C60 Offset: 0x1B99D61 VA: 0x1B99C60
	private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState) { }

	// RVA: 0x1B9A1B0 Offset: 0x1B9A2B1 VA: 0x1B9A1B0
	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation) { }

	// RVA: 0x1B9A5F0 Offset: 0x1B9A6F1 VA: 0x1B9A5F0
	public void .ctor() { }
}

