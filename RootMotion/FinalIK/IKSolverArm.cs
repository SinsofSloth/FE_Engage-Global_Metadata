// Namespace: RootMotion.FinalIK
[Serializable]
public class IKSolverArm : IKSolver // TypeDefIndex: 14375
{
	// Fields
	[RangeAttribute] // RVA: 0x2A0B40 Offset: 0x2A0C41 VA: 0x2A0B40
	public float IKRotationWeight; // 0x58
	public Quaternion IKRotation; // 0x5C
	public IKSolver.Point chest; // 0x70
	public IKSolver.Point shoulder; // 0x78
	public IKSolver.Point upperArm; // 0x80
	public IKSolver.Point forearm; // 0x88
	public IKSolver.Point hand; // 0x90
	public bool isLeft; // 0x98
	public IKSolverVR.Arm arm; // 0xA0
	private Vector3[] positions; // 0xA8
	private Quaternion[] rotations; // 0xB0

	// Methods

	// RVA: 0x3C5E350 Offset: 0x3C5E451 VA: 0x3C5E350 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x3C5E710 Offset: 0x3C5E811 VA: 0x3C5E710
	public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root) { }

	// RVA: 0x3C5E7B0 Offset: 0x3C5E8B1 VA: 0x3C5E7B0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x3C5E940 Offset: 0x3C5EA41 VA: 0x3C5E940 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x3C5EAC0 Offset: 0x3C5EBC1 VA: 0x3C5EAC0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x3C5EB10 Offset: 0x3C5EC11 VA: 0x3C5EB10 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x3C5EB70 Offset: 0x3C5EC71 VA: 0x3C5EB70 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x3C5EE60 Offset: 0x3C5EF61 VA: 0x3C5EE60 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x3C5EED0 Offset: 0x3C5EFD1 VA: 0x3C5EED0
	private void Solve() { }

	// RVA: 0x3C5EBD0 Offset: 0x3C5ECD1 VA: 0x3C5EBD0
	private void Read() { }

	// RVA: 0x3C5EF30 Offset: 0x3C5F031 VA: 0x3C5EF30
	private void Write() { }

	// RVA: 0x3C5F060 Offset: 0x3C5F161 VA: 0x3C5F060
	public void .ctor() { }
}

