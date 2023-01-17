// Namespace: 
[AddComponentMenu] // RVA: 0x1A360 Offset: 0x1A461 VA: 0x1A360
[HelpURLAttribute] // RVA: 0x1A360 Offset: 0x1A461 VA: 0x1A360
[SaveDuringPlayAttribute] // RVA: 0x1A360 Offset: 0x1A461 VA: 0x1A360
[ExecuteAlways] // RVA: 0x1A360 Offset: 0x1A461 VA: 0x1A360
public class CinemachineCameraOffset : CinemachineExtension // TypeDefIndex: 5722
{
	// Fields
	[TooltipAttribute] // RVA: 0x1BF20 Offset: 0x1C021 VA: 0x1BF20
	public Vector3 m_Offset; // 0x28
	[TooltipAttribute] // RVA: 0x1BF60 Offset: 0x1C061 VA: 0x1BF60
	public CinemachineCore.Stage m_ApplyAfter; // 0x34
	[TooltipAttribute] // RVA: 0x1BFA0 Offset: 0x1C0A1 VA: 0x1BFA0
	public bool m_PreserveComposition; // 0x38

	// Methods

	// RVA: 0x1B8CF50 Offset: 0x1B8D051 VA: 0x1B8CF50 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1B8D110 Offset: 0x1B8D211 VA: 0x1B8D110
	public void .ctor() { }
}

