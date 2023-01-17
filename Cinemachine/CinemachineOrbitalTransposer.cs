// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1B540 Offset: 0x1B641 VA: 0x1B540
[AddComponentMenu] // RVA: 0x1B540 Offset: 0x1B641 VA: 0x1B540
[SaveDuringPlayAttribute] // RVA: 0x1B540 Offset: 0x1B641 VA: 0x1B540
public class CinemachineOrbitalTransposer : CinemachineTransposer // TypeDefIndex: 5798
{
	// Fields
	[TooltipAttribute] // RVA: 0x201B0 Offset: 0x202B1 VA: 0x201B0
	[OrbitalTransposerHeadingPropertyAttribute] // RVA: 0x201B0 Offset: 0x202B1 VA: 0x201B0
	[SpaceAttribute] // RVA: 0x201B0 Offset: 0x202B1 VA: 0x201B0
	public CinemachineOrbitalTransposer.Heading m_Heading; // 0xC8
	[TooltipAttribute] // RVA: 0x20210 Offset: 0x20311 VA: 0x20210
	public AxisState.Recentering m_RecenterToTargetHeading; // 0xD4
	[TooltipAttribute] // RVA: 0x20250 Offset: 0x20351 VA: 0x20250
	[AxisStatePropertyAttribute] // RVA: 0x20250 Offset: 0x20351 VA: 0x20250
	public AxisState m_XAxis; // 0xF0
	[HideInInspector] // RVA: 0x202A0 Offset: 0x203A1 VA: 0x202A0
	[SerializeField] // RVA: 0x202A0 Offset: 0x203A1 VA: 0x202A0
	[FormerlySerializedAsAttribute] // RVA: 0x202A0 Offset: 0x203A1 VA: 0x202A0
	private float m_LegacyRadius; // 0x158
	[HideInInspector] // RVA: 0x20300 Offset: 0x20401 VA: 0x20300
	[SerializeField] // RVA: 0x20300 Offset: 0x20401 VA: 0x20300
	[FormerlySerializedAsAttribute] // RVA: 0x20300 Offset: 0x20401 VA: 0x20300
	private float m_LegacyHeightOffset; // 0x15C
	[SerializeField] // RVA: 0x20360 Offset: 0x20461 VA: 0x20360
	[HideInInspector] // RVA: 0x20360 Offset: 0x20461 VA: 0x20360
	[FormerlySerializedAsAttribute] // RVA: 0x20360 Offset: 0x20461 VA: 0x20360
	private float m_LegacyHeadingBias; // 0x160
	[HideInInspector] // RVA: 0x203C0 Offset: 0x204C1 VA: 0x203C0
	[NoSaveDuringPlayAttribute] // RVA: 0x203C0 Offset: 0x204C1 VA: 0x203C0
	public bool m_HeadingIsSlave; // 0x164
	internal CinemachineOrbitalTransposer.UpdateHeadingDelegate HeadingUpdater; // 0x168
	private Vector3 mLastTargetPosition; // 0x170
	private HeadingTracker mHeadingTracker; // 0x180
	private Rigidbody mTargetRigidBody; // 0x188
	[CompilerGeneratedAttribute] // RVA: 0x20400 Offset: 0x20501 VA: 0x20400
	private Transform <PreviousTarget>k__BackingField; // 0x190
	private Vector3 mLastCameraPosition; // 0x198
	[CompilerGeneratedAttribute] // RVA: 0x20410 Offset: 0x20511 VA: 0x20410
	private float <LastHeading>k__BackingField; // 0x1A4

	// Properties
	private Transform PreviousTarget { get; set; }
	private float LastHeading { get; set; }

	// Methods

	// RVA: 0x1BA3280 Offset: 0x1BA3381 VA: 0x1BA3280 Slot: 13
	protected override void OnValidate() { }

	// RVA: 0x1BA3370 Offset: 0x1BA3471 VA: 0x1BA3370
	public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis) { }

	// RVA: 0x1B9DE10 Offset: 0x1B9DF11 VA: 0x1B9DE10
	public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis, ref AxisState.Recentering recentering, bool isLive) { }

	// RVA: 0x1BA3700 Offset: 0x1BA3801 VA: 0x1BA3700
	private void OnEnable() { }

	// RVA: 0x1BA3750 Offset: 0x1BA3851 VA: 0x1BA3750
	public void UpdateInputAxisProvider() { }

	[CompilerGeneratedAttribute] // RVA: 0x237D0 Offset: 0x238D1 VA: 0x237D0
	// RVA: 0x1BA3830 Offset: 0x1BA3931 VA: 0x1BA3830
	private Transform get_PreviousTarget() { }

	[CompilerGeneratedAttribute] // RVA: 0x237E0 Offset: 0x238E1 VA: 0x237E0
	// RVA: 0x1BA3840 Offset: 0x1BA3941 VA: 0x1BA3840
	private void set_PreviousTarget(Transform value) { }

	// RVA: 0x1BA3850 Offset: 0x1BA3951 VA: 0x1BA3850 Slot: 10
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1BA3960 Offset: 0x1BA3A61 VA: 0x1BA3960 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1BA3A00 Offset: 0x1BA3B01 VA: 0x1BA3A00 Slot: 9
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	// RVA: 0x1B9BD90 Offset: 0x1B9BE91 VA: 0x1B9BD90
	public float GetAxisClosestValue(Vector3 cameraPos, Vector3 up) { }

	[CompilerGeneratedAttribute] // RVA: 0x237F0 Offset: 0x238F1 VA: 0x237F0
	// RVA: 0x1BA3B50 Offset: 0x1BA3C51 VA: 0x1BA3B50
	private float get_LastHeading() { }

	[CompilerGeneratedAttribute] // RVA: 0x23800 Offset: 0x23901 VA: 0x23800
	// RVA: 0x1BA3B60 Offset: 0x1BA3C61 VA: 0x1BA3B60
	private void set_LastHeading(float value) { }

	// RVA: 0x1BA3B70 Offset: 0x1BA3C71 VA: 0x1BA3B70 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1BA40E0 Offset: 0x1BA41E1 VA: 0x1BA40E0 Slot: 14
	public override Vector3 GetTargetCameraPosition(Vector3 worldUp) { }

	// RVA: 0x1BA3380 Offset: 0x1BA3481 VA: 0x1BA3380
	private float GetTargetHeading(float currentHeading, Quaternion targetOrientation) { }

	// RVA: 0x1BA4220 Offset: 0x1BA4321 VA: 0x1BA4220
	public void .ctor() { }
}

