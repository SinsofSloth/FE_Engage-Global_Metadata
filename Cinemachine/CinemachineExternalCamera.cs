// Namespace: Cinemachine
[AddComponentMenu] // RVA: 0x1A9E0 Offset: 0x1AAE1 VA: 0x1A9E0
[DocumentationSortingAttribute] // RVA: 0x1A9E0 Offset: 0x1AAE1 VA: 0x1A9E0
[RequireComponent] // RVA: 0x1A9E0 Offset: 0x1AAE1 VA: 0x1A9E0
[DisallowMultipleComponent] // RVA: 0x1A9E0 Offset: 0x1AAE1 VA: 0x1A9E0
[ExecuteAlways] // RVA: 0x1A9E0 Offset: 0x1AAE1 VA: 0x1A9E0
[HelpURLAttribute] // RVA: 0x1A9E0 Offset: 0x1AAE1 VA: 0x1A9E0
public class CinemachineExternalCamera : CinemachineVirtualCameraBase // TypeDefIndex: 5751
{
	// Fields
	[NoSaveDuringPlayAttribute] // RVA: 0x1D2B0 Offset: 0x1D3B1 VA: 0x1D2B0
	[VcamTargetPropertyAttribute] // RVA: 0x1D2B0 Offset: 0x1D3B1 VA: 0x1D2B0
	[TooltipAttribute] // RVA: 0x1D2B0 Offset: 0x1D3B1 VA: 0x1D2B0
	public Transform m_LookAt; // 0x68
	private Camera m_Camera; // 0x70
	private CameraState m_State; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x1D310 Offset: 0x1D411 VA: 0x1D310
	private Transform <Follow>k__BackingField; // 0x158
	[TooltipAttribute] // RVA: 0x1D320 Offset: 0x1D421 VA: 0x1D320
	[FormerlySerializedAsAttribute] // RVA: 0x1D320 Offset: 0x1D421 VA: 0x1D320
	public CinemachineVirtualCameraBase.BlendHint m_BlendHint; // 0x160

	// Properties
	public override CameraState State { get; }
	public override Transform LookAt { get; set; }
	public override Transform Follow { get; set; }

	// Methods

	// RVA: 0x1B97A30 Offset: 0x1B97B31 VA: 0x1B97A30 Slot: 25
	public override CameraState get_State() { }

	// RVA: 0x1B97A40 Offset: 0x1B97B41 VA: 0x1B97A40 Slot: 27
	public override Transform get_LookAt() { }

	// RVA: 0x1B97A50 Offset: 0x1B97B51 VA: 0x1B97A50 Slot: 28
	public override void set_LookAt(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x235C0 Offset: 0x236C1 VA: 0x235C0
	// RVA: 0x1B97A60 Offset: 0x1B97B61 VA: 0x1B97A60 Slot: 29
	public override Transform get_Follow() { }

	[CompilerGeneratedAttribute] // RVA: 0x235D0 Offset: 0x236D1 VA: 0x235D0
	// RVA: 0x1B97A70 Offset: 0x1B97B71 VA: 0x1B97A70 Slot: 30
	public override void set_Follow(Transform value) { }

	// RVA: 0x1B97A80 Offset: 0x1B97B81 VA: 0x1B97A80 Slot: 33
	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	// RVA: 0x1B97E50 Offset: 0x1B97F51 VA: 0x1B97E50
	public void .ctor() { }
}

