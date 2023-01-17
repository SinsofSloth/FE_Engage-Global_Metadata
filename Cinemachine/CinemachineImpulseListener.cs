// Namespace: Cinemachine
[AddComponentMenu] // RVA: 0x1BC70 Offset: 0x1BD71 VA: 0x1BC70
[SaveDuringPlayAttribute] // RVA: 0x1BC70 Offset: 0x1BD71 VA: 0x1BC70
[HelpURLAttribute] // RVA: 0x1BC70 Offset: 0x1BD71 VA: 0x1BC70
[ExecuteAlways] // RVA: 0x1BC70 Offset: 0x1BD71 VA: 0x1BC70
[DocumentationSortingAttribute] // RVA: 0x1BC70 Offset: 0x1BD71 VA: 0x1BC70
public class CinemachineImpulseListener : CinemachineExtension // TypeDefIndex: 5883
{
	// Fields
	[TooltipAttribute] // RVA: 0x22D30 Offset: 0x22E31 VA: 0x22D30
	[CinemachineImpulseChannelPropertyAttribute] // RVA: 0x22D30 Offset: 0x22E31 VA: 0x22D30
	public int m_ChannelMask; // 0x28
	[TooltipAttribute] // RVA: 0x22D80 Offset: 0x22E81 VA: 0x22D80
	public float m_Gain; // 0x2C
	[TooltipAttribute] // RVA: 0x22DC0 Offset: 0x22EC1 VA: 0x22DC0
	public bool m_Use2DDistance; // 0x30

	// Methods

	// RVA: 0x1BA02A0 Offset: 0x1BA03A1 VA: 0x1BA02A0 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1BA06D0 Offset: 0x1BA07D1 VA: 0x1BA06D0
	public void .ctor() { }
}

