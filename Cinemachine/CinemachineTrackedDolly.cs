// Namespace: Cinemachine
[SaveDuringPlayAttribute] // RVA: 0x1B6B0 Offset: 0x1B7B1 VA: 0x1B6B0
[AddComponentMenu] // RVA: 0x1B6B0 Offset: 0x1B7B1 VA: 0x1B6B0
[DocumentationSortingAttribute] // RVA: 0x1B6B0 Offset: 0x1B7B1 VA: 0x1B6B0
public class CinemachineTrackedDolly : CinemachineComponentBase // TypeDefIndex: 5804
{
	// Fields
	[TooltipAttribute] // RVA: 0x20730 Offset: 0x20831 VA: 0x20730
	public CinemachinePathBase m_Path; // 0x50
	[TooltipAttribute] // RVA: 0x20770 Offset: 0x20871 VA: 0x20770
	public float m_PathPosition; // 0x58
	[TooltipAttribute] // RVA: 0x207B0 Offset: 0x208B1 VA: 0x207B0
	public CinemachinePathBase.PositionUnits m_PositionUnits; // 0x5C
	[TooltipAttribute] // RVA: 0x207F0 Offset: 0x208F1 VA: 0x207F0
	public Vector3 m_PathOffset; // 0x60
	[TooltipAttribute] // RVA: 0x20830 Offset: 0x20931 VA: 0x20830
	[RangeAttribute] // RVA: 0x20830 Offset: 0x20931 VA: 0x20830
	public float m_XDamping; // 0x6C
	[TooltipAttribute] // RVA: 0x20890 Offset: 0x20991 VA: 0x20890
	[RangeAttribute] // RVA: 0x20890 Offset: 0x20991 VA: 0x20890
	public float m_YDamping; // 0x70
	[TooltipAttribute] // RVA: 0x208F0 Offset: 0x209F1 VA: 0x208F0
	[RangeAttribute] // RVA: 0x208F0 Offset: 0x209F1 VA: 0x208F0
	public float m_ZDamping; // 0x74
	[TooltipAttribute] // RVA: 0x20950 Offset: 0x20A51 VA: 0x20950
	public CinemachineTrackedDolly.CameraUpMode m_CameraUp; // 0x78
	[TooltipAttribute] // RVA: 0x20990 Offset: 0x20A91 VA: 0x20990
	[RangeAttribute] // RVA: 0x20990 Offset: 0x20A91 VA: 0x20990
	public float m_PitchDamping; // 0x7C
	[TooltipAttribute] // RVA: 0x209F0 Offset: 0x20AF1 VA: 0x209F0
	[RangeAttribute] // RVA: 0x209F0 Offset: 0x20AF1 VA: 0x209F0
	public float m_YawDamping; // 0x80
	[TooltipAttribute] // RVA: 0x20A50 Offset: 0x20B51 VA: 0x20A50
	[RangeAttribute] // RVA: 0x20A50 Offset: 0x20B51 VA: 0x20A50
	public float m_RollDamping; // 0x84
	[TooltipAttribute] // RVA: 0x20AB0 Offset: 0x20BB1 VA: 0x20AB0
	public CinemachineTrackedDolly.AutoDolly m_AutoDolly; // 0x88
	private float m_PreviousPathPosition; // 0x98
	private Quaternion m_PreviousOrientation; // 0x9C
	private Vector3 m_PreviousCameraPosition; // 0xAC

	// Properties
	public override bool IsValid { get; }
	public override CinemachineCore.Stage Stage { get; }
	private Vector3 AngularDamping { get; }

	// Methods

	// RVA: 0x1A771A0 Offset: 0x1A772A1 VA: 0x1A771A0 Slot: 4
	public override bool get_IsValid() { }

	// RVA: 0x1A77230 Offset: 0x1A77331 VA: 0x1A77230 Slot: 6
	public override CinemachineCore.Stage get_Stage() { }

	// RVA: 0x1A77240 Offset: 0x1A77341 VA: 0x1A77240 Slot: 12
	public override float GetMaxDampTime() { }

	// RVA: 0x1A77350 Offset: 0x1A77451 VA: 0x1A77350 Slot: 8
	public override void MutateCameraState(ref CameraState curState, float deltaTime) { }

	// RVA: 0x1A77E10 Offset: 0x1A77F11 VA: 0x1A77E10
	private Quaternion GetCameraOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up) { }

	// RVA: 0x1A77300 Offset: 0x1A77401 VA: 0x1A77300
	private Vector3 get_AngularDamping() { }

	// RVA: 0x1A78280 Offset: 0x1A78381 VA: 0x1A78280
	public void .ctor() { }
}

