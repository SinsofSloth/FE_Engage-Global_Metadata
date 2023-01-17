// Namespace: Cinemachine
[DisallowMultipleComponent] // RVA: 0x1ACE0 Offset: 0x1ADE1 VA: 0x1ACE0
[HelpURLAttribute] // RVA: 0x1ACE0 Offset: 0x1ADE1 VA: 0x1ACE0
[AddComponentMenu] // RVA: 0x1ACE0 Offset: 0x1ADE1 VA: 0x1ACE0
[SaveDuringPlayAttribute] // RVA: 0x1ACE0 Offset: 0x1ADE1 VA: 0x1ACE0
[DocumentationSortingAttribute] // RVA: 0x1ACE0 Offset: 0x1ADE1 VA: 0x1ACE0
public class CinemachinePath : CinemachinePathBase // TypeDefIndex: 5760
{
	// Fields
	[TooltipAttribute] // RVA: 0x1DC90 Offset: 0x1DD91 VA: 0x1DC90
	public bool m_Looped; // 0x48
	[TooltipAttribute] // RVA: 0x1DCD0 Offset: 0x1DDD1 VA: 0x1DCD0
	public CinemachinePath.Waypoint[] m_Waypoints; // 0x50

	// Properties
	public override float MinPos { get; }
	public override float MaxPos { get; }
	public override bool Looped { get; }
	public override int DistanceCacheSampleStepsPerSegment { get; }

	// Methods

	// RVA: 0x1BA5120 Offset: 0x1BA5221 VA: 0x1BA5120 Slot: 4
	public override float get_MinPos() { }

	// RVA: 0x1BA5130 Offset: 0x1BA5231 VA: 0x1BA5130 Slot: 5
	public override float get_MaxPos() { }

	// RVA: 0x1BA5160 Offset: 0x1BA5261 VA: 0x1BA5160 Slot: 6
	public override bool get_Looped() { }

	// RVA: 0x1BA5170 Offset: 0x1BA5271 VA: 0x1BA5170
	private void Reset() { }

	// RVA: 0x1BA5270 Offset: 0x1BA5371 VA: 0x1BA5270 Slot: 13
	public override int get_DistanceCacheSampleStepsPerSegment() { }

	// RVA: 0x1BA5280 Offset: 0x1BA5381 VA: 0x1BA5280
	private float GetBoundingIndices(float pos, out int indexA, out int indexB) { }

	// RVA: 0x1BA5370 Offset: 0x1BA5471 VA: 0x1BA5370 Slot: 8
	public override Vector3 EvaluatePosition(float pos) { }

	// RVA: 0x1BA5550 Offset: 0x1BA5651 VA: 0x1BA5550 Slot: 9
	public override Vector3 EvaluateTangent(float pos) { }

	// RVA: 0x1BA5760 Offset: 0x1BA5861 VA: 0x1BA5760 Slot: 10
	public override Quaternion EvaluateOrientation(float pos) { }

	// RVA: 0x1BA5A20 Offset: 0x1BA5B21 VA: 0x1BA5A20
	private void OnValidate() { }

	// RVA: 0x1BA5A30 Offset: 0x1BA5B31 VA: 0x1BA5A30
	public void .ctor() { }
}

