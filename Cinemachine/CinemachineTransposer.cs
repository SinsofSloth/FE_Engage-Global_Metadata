// Namespace: Cinemachine
[AddComponentMenu] // RVA: 0x1B750 Offset: 0x1B851 VA: 0x1B750
[DocumentationSortingAttribute] // RVA: 0x1B750 Offset: 0x1B851 VA: 0x1B750
[SaveDuringPlayAttribute] // RVA: 0x1B750 Offset: 0x1B851 VA: 0x1B750
public class CinemachineTransposer : CinemachineComponentBase // TypeDefIndex: 5807
{
	// Fields
	[TooltipAttribute] // RVA: 0x20C10 Offset: 0x20D11 VA: 0x20C10
	public CinemachineTransposer.BindingMode m_BindingMode; // 0x50
	[TooltipAttribute] // RVA: 0x20C50 Offset: 0x20D51 VA: 0x20C50
	public Vector3 m_FollowOffset; // 0x54
	[RangeAttribute] // RVA: 0x20C90 Offset: 0x20D91 VA: 0x20C90
	[TooltipAttribute] // RVA: 0x20C90 Offset: 0x20D91 VA: 0x20C90
	public float m_XDamping; // 0x60
	[RangeAttribute] // RVA: 0x20CF0 Offset: 0x20DF1 VA: 0x20CF0
	[TooltipAttribute] // RVA: 0x20CF0 Offset: 0x20DF1 VA: 0x20CF0
	public float m_YDamping; // 0x64
	[TooltipAttribute] // RVA: 0x20D50 Offset: 0x20E51 VA: 0x20D50
	[RangeAttribute] // RVA: 0x20D50 Offset: 0x20E51 VA: 0x20D50
	public float m_ZDamping; // 0x68
	public CinemachineTransposer.AngularDampingMode m_AngularDampingMode; // 0x6C
	[TooltipAttribute] // RVA: 0x20DB0 Offset: 0x20EB1 VA: 0x20DB0
	[RangeAttribute] // RVA: 0x20DB0 Offset: 0x20EB1 VA: 0x20DB0
	public float m_PitchDamping; // 0x70
	[TooltipAttribute] // RVA: 0x20E10 Offset: 0x20F11 VA: 0x20E10
	[RangeAttribute] // RVA: 0x20E10 Offset: 0x20F11 VA: 0x20E10
	public float m_YawDamping; // 0x74
	[TooltipAttribute] // RVA: 0x20E70 Offset: 0x20F71 VA: 0x20E70
	[RangeAttribute] // RVA: 0x20E70 Offset: 0x20F71 VA: 0x20E70
	public float m_RollDamping; // 0x78
	[TooltipAttribute] // RVA: 0x20ED0 Offset: 0x20FD1 VA: 0x20ED0
	[RangeAttribute] // RVA: 0x20ED0 Offset: 0x20FD1 VA: 0x20ED0
	public float m_AngularDamping; // 0x7C
	[CompilerGeneratedAttribute] // RVA: 0x20F30 Offset: 0x21031 VA: 0x20F30
	private bool <HideOffsetInInspector>k__BackingField; // 0x80
	private Vector3 m_PreviousTargetPosition; // 0x84
	private Quaternion m_PreviousReferenceOrientation; // 0x90
	private Quaternion m_targetOrientationOnAssign; // 0xA0
	private Vector3 m_PreviousOffset; // 0xB0
	private Transform m_previousTarget; // 0xC0

	// Properties
	public bool HideOffsetInInspector { get; set; }
	public Vector3 EffectiveOffset { get; }
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	protected Vector3 Damping { get; }
	protected Vector3 AngularDamping { get; }

	// Methods

	// RVA: 0x1A78320 Offset: 0x1A78421 VA: 0x1A78320 Slot: 13
	protected virtual void OnValidate() { }

	[CompilerGeneratedAttribute] // RVA: 0x23810 Offset: 0x23911 VA: 0x23810
	// RVA: 0x1A78380 Offset: 0x1A78481 VA: 0x1A78380
	public bool get_HideOffsetInInspector() { }

	[CompilerGeneratedAttribute] // RVA: 0x23820 Offset: 0x23921 VA: 0x23820
	// RVA: 0x1A78390 Offset: 0x1A78491 VA: 0x1A78390
	public void set_HideOffsetInInspector(bool value) { }

	// RVA: 0x1A78350 Offset: 0x1A78451 VA: 0x1A78350
	public Vector3 get_EffectiveOffset() { }

	// RVA: 0x1A783A0 Offset: 0x1A784A1 VA: 0x1A783A0 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1A78440 Offset: 0x1A78541 VA: 0x1A78440 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1A78450 Offset: 0x1A78551 VA: 0x1A78450 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1A785F0 Offset: 0x1A786F1 VA: 0x1A785F0 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1A79460 Offset: 0x1A79561 VA: 0x1A79460 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A79540 Offset: 0x1A79641 VA: 0x1A79540 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A787D0 Offset: 0x1A788D1 VA: 0x1A787D0
	protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1A78950 Offset: 0x1A78A51 VA: 0x1A78950
	protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient) { }

	// RVA: 0x1A79170 Offset: 0x1A79271 VA: 0x1A79170
	protected Vector3 GetOffsetForMinimumTargetDistance(Vector3 dampedTargetPos, Vector3 cameraOffset, Vector3 cameraFwd, Vector3 up, Vector3 actualTargetPos) { }

	// RVA: 0x1A78550 Offset: 0x1A78651 VA: 0x1A78550
	protected Vector3 get_Damping() { }

	// RVA: 0x1A78580 Offset: 0x1A78681 VA: 0x1A78580
	protected Vector3 get_AngularDamping() { }

	// RVA: 0x1A79CB0 Offset: 0x1A79DB1 VA: 0x1A79CB0 Slot: 14
	public virtual Vector3 GetTargetCameraPosition(Vector3 worldUp) { }

	// RVA: 0x1A79660 Offset: 0x1A79761 VA: 0x1A79660
	public Quaternion GetReferenceOrientation(Vector3 worldUp) { }

	// RVA: 0x1A79D70 Offset: 0x1A79E71 VA: 0x1A79D70
	public void .ctor() { }
}

