// Namespace: Cinemachine
[ExcludeFromPresetAttribute] // RVA: 0x1B1B0 Offset: 0x1B2B1 VA: 0x1B1B0
[ExecuteAlways] // RVA: 0x1B1B0 Offset: 0x1B2B1 VA: 0x1B1B0
[DisallowMultipleComponent] // RVA: 0x1B1B0 Offset: 0x1B2B1 VA: 0x1B1B0
[DocumentationSortingAttribute] // RVA: 0x1B1B0 Offset: 0x1B2B1 VA: 0x1B1B0
[HelpURLAttribute] // RVA: 0x1B1B0 Offset: 0x1B2B1 VA: 0x1B1B0
[AddComponentMenu] // RVA: 0x1B1B0 Offset: 0x1B2B1 VA: 0x1B1B0
public class CinemachineVirtualCamera : CinemachineVirtualCameraBase // TypeDefIndex: 5781
{
	// Fields
	[VcamTargetPropertyAttribute] // RVA: 0x1E7E0 Offset: 0x1E8E1 VA: 0x1E7E0
	[NoSaveDuringPlayAttribute] // RVA: 0x1E7E0 Offset: 0x1E8E1 VA: 0x1E7E0
	[TooltipAttribute] // RVA: 0x1E7E0 Offset: 0x1E8E1 VA: 0x1E7E0
	public Transform m_LookAt; // 0x68
	[NoSaveDuringPlayAttribute] // RVA: 0x1E840 Offset: 0x1E941 VA: 0x1E840
	[VcamTargetPropertyAttribute] // RVA: 0x1E840 Offset: 0x1E941 VA: 0x1E840
	[TooltipAttribute] // RVA: 0x1E840 Offset: 0x1E941 VA: 0x1E840
	public Transform m_Follow; // 0x70
	[TooltipAttribute] // RVA: 0x1E8A0 Offset: 0x1E9A1 VA: 0x1E8A0
	[FormerlySerializedAsAttribute] // RVA: 0x1E8A0 Offset: 0x1E9A1 VA: 0x1E8A0
	[LensSettingsPropertyAttribute] // RVA: 0x1E8A0 Offset: 0x1E9A1 VA: 0x1E8A0
	public LensSettings m_Lens; // 0x78
	public CinemachineVirtualCameraBase.TransitionParams m_Transitions; // 0xA8
	[FormerlySerializedAsAttribute] // RVA: 0x1E910 Offset: 0x1EA11 VA: 0x1E910
	[HideInInspector] // RVA: 0x1E910 Offset: 0x1EA11 VA: 0x1E910
	[SerializeField] // RVA: 0x1E910 Offset: 0x1EA11 VA: 0x1E910
	[FormerlySerializedAsAttribute] // RVA: 0x1E910 Offset: 0x1EA11 VA: 0x1E910
	private CinemachineVirtualCameraBase.BlendHint m_LegacyBlendHint; // 0xB8
	public const string PipelineName = "cm";
	public static CinemachineVirtualCamera.CreatePipelineDelegate CreatePipelineOverride; // 0x0
	public static CinemachineVirtualCamera.DestroyPipelineDelegate DestroyPipelineOverride; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x1E990 Offset: 0x1EA91 VA: 0x1E990
	private bool <UserIsDragging>k__BackingField; // 0xBC
	private CameraState m_State; // 0xC0
	private CinemachineComponentBase[] m_ComponentPipeline; // 0x1A0
	[SerializeField] // RVA: 0x1E9A0 Offset: 0x1EAA1 VA: 0x1E9A0
	[HideInInspector] // RVA: 0x1E9A0 Offset: 0x1EAA1 VA: 0x1E9A0
	private Transform m_ComponentOwner; // 0x1A8
	private Transform mCachedLookAtTarget; // 0x1B0
	private CinemachineVirtualCameraBase mCachedLookAtTargetVcam; // 0x1B8

	// Properties
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }
	public bool UserIsDragging { get; set; }

	// Methods

	// RVA: 0x1A7ADE0 Offset: 0x1A7AEE1 VA: 0x1A7ADE0 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x1A7ADF0 Offset: 0x1A7AEF1 VA: 0x1A7ADF0 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x1A7AF40 Offset: 0x1A7B041 VA: 0x1A7AF40 Slot: 28
	public override void set_LookAt(Transform value) { }

	// RVA: 0x1A7AF50 Offset: 0x1A7B051 VA: 0x1A7AF50 Slot: 29
	public override Transform get_Follow() { }

	// RVA: 0x1A7B0A0 Offset: 0x1A7B1A1 VA: 0x1A7B0A0 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1A7B0B0 Offset: 0x1A7B1B1 VA: 0x1A7B0B0 Slot: 21
	public override float GetMaxDampTime() { }

	// RVA: 0x1A7B9B0 Offset: 0x1A7BAB1 VA: 0x1A7B9B0 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A7C140 Offset: 0x1A7C241 VA: 0x1A7C140 Slot: 39
	protected override void OnEnable() { }

	// RVA: 0x1A7CB00 Offset: 0x1A7CC01 VA: 0x1A7CB00 Slot: 35
	protected override void OnDestroy() { }

	// RVA: 0x1A7CEF0 Offset: 0x1A7CFF1 VA: 0x1A7CEF0 Slot: 38
	protected override void OnValidate() { }

	// RVA: 0x1A7D110 Offset: 0x1A7D211 VA: 0x1A7D110
	private void OnTransformChildrenChanged() { }

	// RVA: 0x1A7D130 Offset: 0x1A7D231 VA: 0x1A7D130
	private void Reset() { }

	// RVA: 0x1A7D140 Offset: 0x1A7D241 VA: 0x1A7D140
	private void DestroyPipeline() { }

	// RVA: 0x1A7DA00 Offset: 0x1A7DB01 VA: 0x1A7DA00
	private Transform CreatePipeline(CinemachineVirtualCamera copyFrom) { }

	// RVA: 0x1A7C9B0 Offset: 0x1A7CAB1 VA: 0x1A7C9B0
	public void InvalidateComponentPipeline() { }

	// RVA: 0x1A7DF60 Offset: 0x1A7E061 VA: 0x1A7DF60
	public Transform GetComponentOwner() { }

	// RVA: 0x1A7DB90 Offset: 0x1A7DC91 VA: 0x1A7DB90
	public CinemachineComponentBase[] GetComponentPipeline() { }

	// RVA: 0x1A7CA60 Offset: 0x1A7CB61 VA: 0x1A7CA60
	public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage) { }

	// RVA: -1 Offset: -1
	public T GetCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229AB20 Offset: 0x229AC21 VA: 0x229AB20
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineComposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<CinemachineOrbitalTransposer>
	|-CinemachineVirtualCamera.GetCinemachineComponent<object>
	|-CinemachineVirtualCamera.GetCinemachineComponent<VCamShaker>
	*/

	// RVA: -1 Offset: -1
	public T AddCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229A7D0 Offset: 0x229A8D1 VA: 0x229A7D0
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineHardLockToTarget>
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineHardLookAt>
	|-CinemachineVirtualCamera.AddCinemachineComponent<CinemachineOrbitalTransposer>
	|-CinemachineVirtualCamera.AddCinemachineComponent<object>
	|-CinemachineVirtualCamera.AddCinemachineComponent<VCamShaker>
	*/

	// RVA: -1 Offset: -1
	public void DestroyCinemachineComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229A9F0 Offset: 0x229AAF1 VA: 0x229A9F0
	|-CinemachineVirtualCamera.DestroyCinemachineComponent<object>
	*/

	[CompilerGeneratedAttribute] // RVA: 0x236D0 Offset: 0x237D1 VA: 0x236D0
	// RVA: 0x1A7DF90 Offset: 0x1A7E091 VA: 0x1A7DF90
	public bool get_UserIsDragging() { }

	[CompilerGeneratedAttribute] // RVA: 0x236E0 Offset: 0x237E1 VA: 0x236E0
	// RVA: 0x1A7DFA0 Offset: 0x1A7E0A1 VA: 0x1A7DFA0
	public void set_UserIsDragging(bool value) { }

	// RVA: 0x1A7B2E0 Offset: 0x1A7B3E1 VA: 0x1A7B2E0
	private void UpdateComponentPipeline() { }

	// RVA: 0x1A7DFB0 Offset: 0x1A7E0B1 VA: 0x1A7DFB0
	internal static void SetFlagsForHiddenChild(GameObject child) { }

	// RVA: 0x1A7BBB0 Offset: 0x1A7BCB1 VA: 0x1A7BBB0
	private CameraState CalculateNewState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A7E4C0 Offset: 0x1A7E5C1 VA: 0x1A7E4C0 Slot: 42
	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	// RVA: 0x1A7E7B0 Offset: 0x1A7E8B1 VA: 0x1A7E7B0 Slot: 43
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1A7EAC0 Offset: 0x1A7EBC1 VA: 0x1A7EAC0
	internal void SetStateRawPosition(Vector3 pos) { }

	// RVA: 0x1A7EAD0 Offset: 0x1A7EBD1 VA: 0x1A7EAD0 Slot: 34
	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1A7F090 Offset: 0x1A7F191 VA: 0x1A7F090
	public void .ctor() { }
}

