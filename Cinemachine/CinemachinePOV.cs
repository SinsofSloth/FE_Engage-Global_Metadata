// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1B5F0 Offset: 0x1B6F1 VA: 0x1B5F0
[SaveDuringPlayAttribute] // RVA: 0x1B5F0 Offset: 0x1B6F1 VA: 0x1B5F0
[AddComponentMenu] // RVA: 0x1B5F0 Offset: 0x1B6F1 VA: 0x1B5F0
public class CinemachinePOV : CinemachineComponentBase // TypeDefIndex: 5800
{
	// Fields
	public CinemachinePOV.RecenterTargetMode m_RecenterTarget; // 0x50
	[AxisStatePropertyAttribute] // RVA: 0x20560 Offset: 0x20661 VA: 0x20560
	[TooltipAttribute] // RVA: 0x20560 Offset: 0x20661 VA: 0x20560
	public AxisState m_VerticalAxis; // 0x58
	[TooltipAttribute] // RVA: 0x205B0 Offset: 0x206B1 VA: 0x205B0
	public AxisState.Recentering m_VerticalRecentering; // 0xC0
	[TooltipAttribute] // RVA: 0x205F0 Offset: 0x206F1 VA: 0x205F0
	[AxisStatePropertyAttribute] // RVA: 0x205F0 Offset: 0x206F1 VA: 0x205F0
	public AxisState m_HorizontalAxis; // 0xE0
	[TooltipAttribute] // RVA: 0x20640 Offset: 0x20741 VA: 0x20640
	public AxisState.Recentering m_HorizontalRecentering; // 0x148
	[HideInInspector] // RVA: 0x20680 Offset: 0x20781 VA: 0x20680
	[TooltipAttribute] // RVA: 0x20680 Offset: 0x20781 VA: 0x20680
	public bool m_ApplyBeforeBody; // 0x164

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }

	// Methods

	// RVA: 0x1BA4490 Offset: 0x1BA4591 VA: 0x1BA4490 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1BA44A0 Offset: 0x1BA45A1 VA: 0x1BA44A0 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1BA44B0 Offset: 0x1BA45B1 VA: 0x1BA44B0
	private void OnValidate() { }

	// RVA: 0x1BA4500 Offset: 0x1BA4601 VA: 0x1BA4500
	private void OnEnable() { }

	// RVA: 0x1BA4510 Offset: 0x1BA4611 VA: 0x1BA4510
	public void UpdateInputAxisProvider() { }

	// RVA: 0x1BA4630 Offset: 0x1BA4731 VA: 0x1BA4630 Slot: 5
	public override void PrePipelineMutateCameraState(ref CameraState state, float deltaTime) { }

	// RVA: 0x1BA4640 Offset: 0x1BA4741 VA: 0x1BA4640 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1BA4890 Offset: 0x1BA4991 VA: 0x1BA4890
	public Vector2 GetRecenterTarget() { }

	// RVA: 0x1BA4A60 Offset: 0x1BA4B61 VA: 0x1BA4A60 Slot: 11
	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	// RVA: 0x1BA4D70 Offset: 0x1BA4E71 VA: 0x1BA4D70 Slot: 9
	public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams) { }

	// RVA: 0x1BA4A80 Offset: 0x1BA4B81 VA: 0x1BA4A80
	private void SetAxesForRotation(Quaternion targetRot) { }

	// RVA: 0x1BA4EC0 Offset: 0x1BA4FC1 VA: 0x1BA4EC0
	public void .ctor() { }
}

