// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1A8C0 Offset: 0x1A9C1 VA: 0x1A8C0
[ExecuteAlways] // RVA: 0x1A8C0 Offset: 0x1A9C1 VA: 0x1A8C0
[SaveDuringPlayAttribute] // RVA: 0x1A8C0 Offset: 0x1A9C1 VA: 0x1A8C0
[AddComponentMenu] // RVA: 0x1A8C0 Offset: 0x1A9C1 VA: 0x1A8C0
[DisallowMultipleComponent] // RVA: 0x1A8C0 Offset: 0x1A9C1 VA: 0x1A8C0
[HelpURLAttribute] // RVA: 0x1A8C0 Offset: 0x1A9C1 VA: 0x1A8C0
public class CinemachineConfiner : CinemachineExtension // TypeDefIndex: 5748
{
	// Fields
	[TooltipAttribute] // RVA: 0x1CFD0 Offset: 0x1D0D1 VA: 0x1CFD0
	public CinemachineConfiner.Mode m_ConfineMode; // 0x28
	[TooltipAttribute] // RVA: 0x1D010 Offset: 0x1D111 VA: 0x1D010
	public Collider m_BoundingVolume; // 0x30
	[TooltipAttribute] // RVA: 0x1D050 Offset: 0x1D151 VA: 0x1D050
	public Collider2D m_BoundingShape2D; // 0x38
	private Collider2D m_BoundingShape2DCache; // 0x40
	[TooltipAttribute] // RVA: 0x1D090 Offset: 0x1D191 VA: 0x1D090
	public bool m_ConfineScreenEdges; // 0x48
	[TooltipAttribute] // RVA: 0x1D0D0 Offset: 0x1D1D1 VA: 0x1D0D0
	[RangeAttribute] // RVA: 0x1D0D0 Offset: 0x1D1D1 VA: 0x1D0D0
	public float m_Damping; // 0x4C
	private List<List<Vector2>> m_pathCache; // 0x50
	private int m_pathTotalPointCount; // 0x58

	// Properties
	public bool IsValid { get; }

	// Methods

	// RVA: 0x1B94AF0 Offset: 0x1B94BF1 VA: 0x1B94AF0
	public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1B94B60 Offset: 0x1B94C61 VA: 0x1B94B60
	public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam) { }

	// RVA: 0x1B94BD0 Offset: 0x1B94CD1 VA: 0x1B94BD0
	private void OnValidate() { }

	// RVA: 0x1B94C00 Offset: 0x1B94D01 VA: 0x1B94C00 Slot: 7
	protected override void ConnectToVcam(bool connect) { }

	// RVA: 0x1B94C10 Offset: 0x1B94D11 VA: 0x1B94C10
	public bool get_IsValid() { }

	// RVA: 0x1B94CF0 Offset: 0x1B94DF1 VA: 0x1B94CF0 Slot: 13
	public override float GetMaxDampTime() { }

	// RVA: 0x1B94D00 Offset: 0x1B94E01 VA: 0x1B94D00 Slot: 9
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime) { }

	// RVA: 0x1B95520 Offset: 0x1B95621 VA: 0x1B95520
	public void InvalidatePathCache() { }

	// RVA: 0x1B95560 Offset: 0x1B95661 VA: 0x1B95560
	private bool ValidatePathCache() { }

	// RVA: 0x1B95210 Offset: 0x1B95311 VA: 0x1B95210
	private Vector3 ConfinePoint(Vector3 camPos) { }

	// RVA: 0x1B94EB0 Offset: 0x1B94FB1 VA: 0x1B94EB0
	private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state) { }

	// RVA: 0x1B95B60 Offset: 0x1B95C61 VA: 0x1B95B60
	public void .ctor() { }
}

