// Namespace: 
[AddComponentMenu] // RVA: 0x1A3E0 Offset: 0x1A4E1 VA: 0x1A3E0
[ExecuteAlways] // RVA: 0x1A3E0 Offset: 0x1A4E1 VA: 0x1A3E0
[SaveDuringPlayAttribute] // RVA: 0x1A3E0 Offset: 0x1A4E1 VA: 0x1A3E0
[HelpURLAttribute] // RVA: 0x1A3E0 Offset: 0x1A4E1 VA: 0x1A3E0
public class CinemachineRecomposer : CinemachineExtension // TypeDefIndex: 5723
{
	// Fields
	[TooltipAttribute] // RVA: 0x1BFE0 Offset: 0x1C0E1 VA: 0x1BFE0
	public CinemachineCore.Stage m_ApplyAfter; // 0x28
	[TooltipAttribute] // RVA: 0x1C020 Offset: 0x1C121 VA: 0x1C020
	public float m_Tilt; // 0x2C
	[TooltipAttribute] // RVA: 0x1C060 Offset: 0x1C161 VA: 0x1C060
	public float m_Pan; // 0x30
	[TooltipAttribute] // RVA: 0x1C0A0 Offset: 0x1C1A1 VA: 0x1C0A0
	public float m_Dutch; // 0x34
	[TooltipAttribute] // RVA: 0x1C0E0 Offset: 0x1C1E1 VA: 0x1C0E0
	public float m_ZoomScale; // 0x38
	[RangeAttribute] // RVA: 0x1C120 Offset: 0x1C221 VA: 0x1C120
	[TooltipAttribute] // RVA: 0x1C120 Offset: 0x1C221 VA: 0x1C120
	public float m_FollowAttachment; // 0x3C
	[TooltipAttribute] // RVA: 0x1C180 Offset: 0x1C281 VA: 0x1C180
	[RangeAttribute] // RVA: 0x1C180 Offset: 0x1C281 VA: 0x1C180
	public float m_LookAtAttachment; // 0x40

	// Methods

	// RVA: 0x1BA6E20 Offset: 0x1BA6F21 VA: 0x1BA6E20
	private void Reset() { }

	// RVA: 0x1BA6E40 Offset: 0x1BA6F41 VA: 0x1BA6E40
	private void OnValidate() { }

	// RVA: 0x1BA6EA0 Offset: 0x1BA6FA1 VA: 0x1BA6EA0 Slot: 8
	public override void PrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState curState, float deltaTime) { }

	// RVA: 0x1BA6EC0 Offset: 0x1BA6FC1 VA: 0x1BA6EC0 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1BA7070 Offset: 0x1BA7171 VA: 0x1BA7070
	public void .ctor() { }
}

