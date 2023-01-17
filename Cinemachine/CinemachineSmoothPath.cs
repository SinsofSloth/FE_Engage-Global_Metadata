// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1AE60 Offset: 0x1AF61 VA: 0x1AE60
[AddComponentMenu] // RVA: 0x1AE60 Offset: 0x1AF61 VA: 0x1AE60
[DisallowMultipleComponent] // RVA: 0x1AE60 Offset: 0x1AF61 VA: 0x1AE60
[HelpURLAttribute] // RVA: 0x1AE60 Offset: 0x1AF61 VA: 0x1AE60
[SaveDuringPlayAttribute] // RVA: 0x1AE60 Offset: 0x1AF61 VA: 0x1AE60
public class CinemachineSmoothPath : CinemachinePathBase // TypeDefIndex: 5764
{
	// Fields
	[TooltipAttribute] // RVA: 0x1DDD0 Offset: 0x1DED1 VA: 0x1DDD0
	public bool m_Looped; // 0x48
	[TooltipAttribute] // RVA: 0x1DE10 Offset: 0x1DF11 VA: 0x1DE10
	public CinemachineSmoothPath.Waypoint[] m_Waypoints; // 0x50
	private CinemachineSmoothPath.Waypoint[] m_ControlPoints1; // 0x58
	private CinemachineSmoothPath.Waypoint[] m_ControlPoints2; // 0x60
	private bool m_IsLoopedCache; // 0x68

	// Properties
	public override float MinPos { get; }
	public override float MaxPos { get; }
	public override bool Looped { get; }
	public override int DistanceCacheSampleStepsPerSegment { get; }

	// Methods

	// RVA: 0x1BA7930 Offset: 0x1BA7A31 VA: 0x1BA7930 Slot: 4
	public override float get_MinPos() { }

	// RVA: 0x1BA7940 Offset: 0x1BA7A41 VA: 0x1BA7940 Slot: 5
	public override float get_MaxPos() { }

	// RVA: 0x1BA7970 Offset: 0x1BA7A71 VA: 0x1BA7970 Slot: 6
	public override bool get_Looped() { }

	// RVA: 0x1BA7980 Offset: 0x1BA7A81 VA: 0x1BA7980 Slot: 13
	public override int get_DistanceCacheSampleStepsPerSegment() { }

	// RVA: 0x1BA7990 Offset: 0x1BA7A91 VA: 0x1BA7990
	private void OnValidate() { }

	// RVA: 0x1BA79A0 Offset: 0x1BA7AA1 VA: 0x1BA79A0
	private void Reset() { }

	// RVA: 0x1BA7A80 Offset: 0x1BA7B81 VA: 0x1BA7A80 Slot: 14
	public override void InvalidateDistanceCache() { }

	// RVA: 0x1BA7AE0 Offset: 0x1BA7BE1 VA: 0x1BA7AE0
	private void UpdateControlPoints() { }

	// RVA: 0x1BA7DB0 Offset: 0x1BA7EB1 VA: 0x1BA7DB0
	private float GetBoundingIndices(float pos, out int indexA, out int indexB) { }

	// RVA: 0x1BA7E90 Offset: 0x1BA7F91 VA: 0x1BA7E90 Slot: 8
	public override Vector3 EvaluatePosition(float pos) { }

	// RVA: 0x1BA8070 Offset: 0x1BA8171 VA: 0x1BA8070 Slot: 9
	public override Vector3 EvaluateTangent(float pos) { }

	// RVA: 0x1BA82A0 Offset: 0x1BA83A1 VA: 0x1BA82A0 Slot: 10
	public override Quaternion EvaluateOrientation(float pos) { }

	// RVA: 0x1BA8580 Offset: 0x1BA8681 VA: 0x1BA8580
	private Quaternion RollAroundForward(float angle) { }

	// RVA: 0x1BA8600 Offset: 0x1BA8701 VA: 0x1BA8600
	public void .ctor() { }
}

