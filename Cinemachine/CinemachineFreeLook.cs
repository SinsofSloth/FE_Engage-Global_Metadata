// Namespace: Cinemachine
[ExcludeFromPresetAttribute] // RVA: 0x1AB80 Offset: 0x1AC81 VA: 0x1AB80
[AddComponentMenu] // RVA: 0x1AB80 Offset: 0x1AC81 VA: 0x1AB80
[HelpURLAttribute] // RVA: 0x1AB80 Offset: 0x1AC81 VA: 0x1AB80
[DisallowMultipleComponent] // RVA: 0x1AB80 Offset: 0x1AC81 VA: 0x1AB80
[DocumentationSortingAttribute] // RVA: 0x1AB80 Offset: 0x1AC81 VA: 0x1AB80
[ExecuteAlways] // RVA: 0x1AB80 Offset: 0x1AC81 VA: 0x1AB80
public class CinemachineFreeLook : CinemachineVirtualCameraBase // TypeDefIndex: 5757
{
	// Fields
	[VcamTargetPropertyAttribute] // RVA: 0x1D4E0 Offset: 0x1D5E1 VA: 0x1D4E0
	[TooltipAttribute] // RVA: 0x1D4E0 Offset: 0x1D5E1 VA: 0x1D4E0
	[NoSaveDuringPlayAttribute] // RVA: 0x1D4E0 Offset: 0x1D5E1 VA: 0x1D4E0
	public Transform m_LookAt; // 0x68
	[VcamTargetPropertyAttribute] // RVA: 0x1D540 Offset: 0x1D641 VA: 0x1D540
	[TooltipAttribute] // RVA: 0x1D540 Offset: 0x1D641 VA: 0x1D540
	[NoSaveDuringPlayAttribute] // RVA: 0x1D540 Offset: 0x1D641 VA: 0x1D540
	public Transform m_Follow; // 0x70
	[TooltipAttribute] // RVA: 0x1D5A0 Offset: 0x1D6A1 VA: 0x1D5A0
	[FormerlySerializedAsAttribute] // RVA: 0x1D5A0 Offset: 0x1D6A1 VA: 0x1D5A0
	public bool m_CommonLens; // 0x78
	[FormerlySerializedAsAttribute] // RVA: 0x1D600 Offset: 0x1D701 VA: 0x1D600
	[TooltipAttribute] // RVA: 0x1D600 Offset: 0x1D701 VA: 0x1D600
	[LensSettingsPropertyAttribute] // RVA: 0x1D600 Offset: 0x1D701 VA: 0x1D600
	public LensSettings m_Lens; // 0x7C
	public CinemachineVirtualCameraBase.TransitionParams m_Transitions; // 0xA8
	[SerializeField] // RVA: 0x1D670 Offset: 0x1D771 VA: 0x1D670
	[FormerlySerializedAsAttribute] // RVA: 0x1D670 Offset: 0x1D771 VA: 0x1D670
	[HideInInspector] // RVA: 0x1D670 Offset: 0x1D771 VA: 0x1D670
	[FormerlySerializedAsAttribute] // RVA: 0x1D670 Offset: 0x1D771 VA: 0x1D670
	private CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint; // 0xB8
	[HeaderAttribute] // RVA: 0x1D6F0 Offset: 0x1D7F1 VA: 0x1D6F0
	[AxisStatePropertyAttribute] // RVA: 0x1D6F0 Offset: 0x1D7F1 VA: 0x1D6F0
	[TooltipAttribute] // RVA: 0x1D6F0 Offset: 0x1D7F1 VA: 0x1D6F0
	public AxisState m_YAxis; // 0xC0
	[TooltipAttribute] // RVA: 0x1D760 Offset: 0x1D861 VA: 0x1D760
	public AxisState.Recentering m_YAxisRecentering; // 0x128
	[TooltipAttribute] // RVA: 0x1D7A0 Offset: 0x1D8A1 VA: 0x1D7A0
	[AxisStatePropertyAttribute] // RVA: 0x1D7A0 Offset: 0x1D8A1 VA: 0x1D7A0
	public AxisState m_XAxis; // 0x148
	[TooltipAttribute] // RVA: 0x1D7F0 Offset: 0x1D8F1 VA: 0x1D7F0
	[OrbitalTransposerHeadingPropertyAttribute] // RVA: 0x1D7F0 Offset: 0x1D8F1 VA: 0x1D7F0
	public CinemachineOrbitalTransposer.Heading m_Heading; // 0x1B0
	[TooltipAttribute] // RVA: 0x1D840 Offset: 0x1D941 VA: 0x1D840
	public AxisState.Recentering m_RecenterToTargetHeading; // 0x1BC
	[TooltipAttribute] // RVA: 0x1D880 Offset: 0x1D981 VA: 0x1D880
	[HeaderAttribute] // RVA: 0x1D880 Offset: 0x1D981 VA: 0x1D880
	public CinemachineTransposer.BindingMode m_BindingMode; // 0x1D8
	[TooltipAttribute] // RVA: 0x1D8E0 Offset: 0x1D9E1 VA: 0x1D8E0
	[FormerlySerializedAsAttribute] // RVA: 0x1D8E0 Offset: 0x1D9E1 VA: 0x1D8E0
	[RangeAttribute] // RVA: 0x1D8E0 Offset: 0x1D9E1 VA: 0x1D8E0
	public float m_SplineCurvature; // 0x1DC
	[TooltipAttribute] // RVA: 0x1D960 Offset: 0x1DA61 VA: 0x1D960
	public CinemachineFreeLook.Orbit[] m_Orbits; // 0x1E0
	[HideInInspector] // RVA: 0x1D9A0 Offset: 0x1DAA1 VA: 0x1D9A0
	[FormerlySerializedAsAttribute] // RVA: 0x1D9A0 Offset: 0x1DAA1 VA: 0x1D9A0
	[SerializeField] // RVA: 0x1D9A0 Offset: 0x1DAA1 VA: 0x1D9A0
	private float m_LegacyHeadingBias; // 0x1E8
	private bool mUseLegacyRigDefinitions; // 0x1EC
	private bool mIsDestroyed; // 0x1ED
	private CameraState m_State; // 0x1F0
	[SerializeField] // RVA: 0x1DA00 Offset: 0x1DB01 VA: 0x1DA00
	[HideInInspector] // RVA: 0x1DA00 Offset: 0x1DB01 VA: 0x1DA00
	[NoSaveDuringPlayAttribute] // RVA: 0x1DA00 Offset: 0x1DB01 VA: 0x1DA00
	private CinemachineVirtualCamera[] m_Rigs; // 0x2D0
	private CinemachineOrbitalTransposer[] mOrbitals; // 0x2D8
	private CinemachineBlend mBlendA; // 0x2E0
	private CinemachineBlend mBlendB; // 0x2E8
	public static CinemachineFreeLook.CreateRigDelegate CreateRigOverride; // 0x0
	public static CinemachineFreeLook.DestroyRigDelegate DestroyRigOverride; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x1DA50 Offset: 0x1DB51 VA: 0x1DA50
	private float <CachedXAxisHeading>k__BackingField; // 0x2F0
	private CinemachineFreeLook.Orbit[] m_CachedOrbits; // 0x2F8
	private float m_CachedTension; // 0x300
	private Vector4[] m_CachedKnots; // 0x308
	private Vector4[] m_CachedCtrl1; // 0x310
	private Vector4[] m_CachedCtrl2; // 0x318

	// Properties
	public static string[] RigNames { get; }
	public override bool PreviousStateIsValid { get; set; }
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	private float CachedXAxisHeading { get; set; }

	// Methods

	// RVA: 0x1B9A710 Offset: 0x1B9A811 VA: 0x1B9A710 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x1B9A810 Offset: 0x1B9A911 VA: 0x1B9A810
	public CinemachineVirtualCamera GetRig(int i) { }

	// RVA: 0x1B9AA90 Offset: 0x1B9AB91 VA: 0x1B9AA90
	public static string[] get_RigNames() { }

	// RVA: 0x1B9AC10 Offset: 0x1B9AD11 VA: 0x1B9AC10 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x1B9ACD0 Offset: 0x1B9ADD1 VA: 0x1B9ACD0
	public void UpdateInputAxisProvider() { }

	// RVA: 0x1B9AD70 Offset: 0x1B9AE71 VA: 0x1B9AD70 Slot: 35
	protected override void OnDestroy() { }

	// RVA: 0x1B9AEC0 Offset: 0x1B9AFC1 VA: 0x1B9AEC0
	private void OnTransformChildrenChanged() { }

	// RVA: 0x1B9AEE0 Offset: 0x1B9AFE1 VA: 0x1B9AEE0
	private void Reset() { }

	// RVA: 0x1B9B400 Offset: 0x1B9B501 VA: 0x1B9B400 Slot: 31
	public override bool get_PreviousStateIsValid() { }

	// RVA: 0x1B9B410 Offset: 0x1B9B511 VA: 0x1B9B410 Slot: 32
	public override void set_PreviousStateIsValid(bool value) { }

	// RVA: 0x1B9B510 Offset: 0x1B9B611 VA: 0x1B9B510 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x1B9B520 Offset: 0x1B9B621 VA: 0x1B9B520 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x1B9B530 Offset: 0x1B9B631 VA: 0x1B9B530 Slot: 28
	public override void set_LookAt(Transform value) { }

	// RVA: 0x1B9B540 Offset: 0x1B9B641 VA: 0x1B9B540 Slot: 29
	public override Transform get_Follow() { }

	// RVA: 0x1B9B550 Offset: 0x1B9B651 VA: 0x1B9B550 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1B9B560 Offset: 0x1B9B661 VA: 0x1B9B560 Slot: 26
	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = False) { }

	// RVA: 0x1B9B6B0 Offset: 0x1B9B7B1 VA: 0x1B9B6B0 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1B9B780 Offset: 0x1B9B881 VA: 0x1B9B780 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1B9C460 Offset: 0x1B9C561 VA: 0x1B9C460 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1B9C950 Offset: 0x1B9CA51 VA: 0x1B9C950 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1B9B9F0 Offset: 0x1B9BAF1 VA: 0x1B9B9F0
	private float GetYAxisClosestValue(Vector3 cameraPos, Vector3 up) { }

	// RVA: 0x1B9A7F0 Offset: 0x1B9A8F1 VA: 0x1B9A7F0
	private void InvalidateRigCache() { }

	// RVA: 0x1B9AEF0 Offset: 0x1B9AFF1 VA: 0x1B9AEF0
	private void DestroyRigs() { }

	// RVA: 0x1B9CFA0 Offset: 0x1B9D0A1 VA: 0x1B9CFA0
	private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom) { }

	// RVA: 0x1B9A870 Offset: 0x1B9A971 VA: 0x1B9A870
	private void UpdateRigCache() { }

	// RVA: 0x1B9D450 Offset: 0x1B9D551 VA: 0x1B9D450
	private int LocateExistingRigs(string[] rigNames, bool forceOrbital) { }

	[CompilerGeneratedAttribute] // RVA: 0x235E0 Offset: 0x236E1 VA: 0x235E0
	// RVA: 0x1B9DC40 Offset: 0x1B9DD41 VA: 0x1B9DC40
	private float get_CachedXAxisHeading() { }

	[CompilerGeneratedAttribute] // RVA: 0x235F0 Offset: 0x236F1 VA: 0x235F0
	// RVA: 0x1B9DC50 Offset: 0x1B9DD51 VA: 0x1B9DC50
	private void set_CachedXAxisHeading(float value) { }

	// RVA: 0x1B9DC60 Offset: 0x1B9DD61 VA: 0x1B9DC60
	private float UpdateXAxisHeading(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up) { }

	// RVA: 0x1B9C000 Offset: 0x1B9C101 VA: 0x1B9C000
	private void PushSettingsToRigs() { }

	// RVA: 0x1B9B680 Offset: 0x1B9B781 VA: 0x1B9B680
	private float GetYAxisValue() { }

	// RVA: 0x1B9C7B0 Offset: 0x1B9C8B1 VA: 0x1B9C7B0
	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1B9CE10 Offset: 0x1B9CF11 VA: 0x1B9CE10
	public Vector3 GetLocalPositionForCameraFromInput(float t) { }

	// RVA: 0x1B9DF70 Offset: 0x1B9E071 VA: 0x1B9DF70
	private void UpdateCachedSpline() { }

	// RVA: 0x1B9E3B0 Offset: 0x1B9E4B1 VA: 0x1B9E3B0
	public void .ctor() { }
}

