// Namespace: Cinemachine
[HelpURLAttribute] // RVA: 0x1AAD0 Offset: 0x1ABD1 VA: 0x1AAD0
[DisallowMultipleComponent] // RVA: 0x1AAD0 Offset: 0x1ABD1 VA: 0x1AAD0
[ExecuteAlways] // RVA: 0x1AAD0 Offset: 0x1ABD1 VA: 0x1AAD0
[SaveDuringPlayAttribute] // RVA: 0x1AAD0 Offset: 0x1ABD1 VA: 0x1AAD0
[DocumentationSortingAttribute] // RVA: 0x1AAD0 Offset: 0x1ABD1 VA: 0x1AAD0
[AddComponentMenu] // RVA: 0x1AAD0 Offset: 0x1ABD1 VA: 0x1AAD0
public class CinemachineFollowZoom : CinemachineExtension // TypeDefIndex: 5753
{
	// Fields
	[TooltipAttribute] // RVA: 0x1D380 Offset: 0x1D481 VA: 0x1D380
	public float m_Width; // 0x28
	[TooltipAttribute] // RVA: 0x1D3C0 Offset: 0x1D4C1 VA: 0x1D3C0
	[RangeAttribute] // RVA: 0x1D3C0 Offset: 0x1D4C1 VA: 0x1D3C0
	public float m_Damping; // 0x2C
	[RangeAttribute] // RVA: 0x1D420 Offset: 0x1D521 VA: 0x1D420
	[TooltipAttribute] // RVA: 0x1D420 Offset: 0x1D521 VA: 0x1D420
	public float m_MinFOV; // 0x30
	[RangeAttribute] // RVA: 0x1D480 Offset: 0x1D581 VA: 0x1D480
	[TooltipAttribute] // RVA: 0x1D480 Offset: 0x1D581 VA: 0x1D480
	public float m_MaxFOV; // 0x34

	// Methods

	// RVA: 0x1B981B0 Offset: 0x1B982B1 VA: 0x1B981B0
	private void OnValidate() { }

	// RVA: 0x1B98220 Offset: 0x1B98321 VA: 0x1B98220 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0x1B98230 Offset: 0x1B98331 VA: 0x1B98230 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1B984A0 Offset: 0x1B985A1 VA: 0x1B984A0
	public void .ctor() { }
}

