// Namespace: RootMotion.FinalIK
[Serializable]
public class IKSolverFABRIKRoot : IKSolver // TypeDefIndex: 14378
{
	// Fields
	public int iterations; // 0x58
	[RangeAttribute] // RVA: 0x2A0B60 Offset: 0x2A0C61 VA: 0x2A0B60
	public float rootPin; // 0x5C
	public FABRIKChain[] chains; // 0x60
	private bool zeroWeightApplied; // 0x68
	private bool[] isRoot; // 0x70
	private Vector3 rootDefaultPosition; // 0x78

	// Methods

	// RVA: 0x3C62540 Offset: 0x3C62641 VA: 0x3C62540 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x3C62B80 Offset: 0x3C62C81 VA: 0x3C62B80 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x3C62C10 Offset: 0x3C62D11 VA: 0x3C62C10 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x3C62CB0 Offset: 0x3C62DB1 VA: 0x3C62CB0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x3C62E20 Offset: 0x3C62F21 VA: 0x3C62E20
	private bool IsRoot(int index) { }

	// RVA: 0x3C62EB0 Offset: 0x3C62FB1 VA: 0x3C62EB0 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x3C632D0 Offset: 0x3C633D1 VA: 0x3C632D0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x3C634D0 Offset: 0x3C635D1 VA: 0x3C634D0 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x3C63380 Offset: 0x3C63481 VA: 0x3C63380
	private void AddPointsToArray(ref IKSolver.Point[] array, FABRIKChain chain) { }

	// RVA: 0x3C630A0 Offset: 0x3C631A1 VA: 0x3C630A0
	private Vector3 GetCentroid() { }

	// RVA: 0x3C63560 Offset: 0x3C63661 VA: 0x3C63560
	public void .ctor() { }
}

