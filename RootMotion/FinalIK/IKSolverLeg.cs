// Namespace: RootMotion.FinalIK
[Serializable]
public class IKSolverLeg : IKSolver // TypeDefIndex: 14384
{
	// Fields
	[RangeAttribute] // RVA: 0x2A0C10 Offset: 0x2A0D11 VA: 0x2A0C10
	public float IKRotationWeight; // 0x58
	public Quaternion IKRotation; // 0x5C
	public IKSolver.Point pelvis; // 0x70
	public IKSolver.Point thigh; // 0x78
	public IKSolver.Point calf; // 0x80
	public IKSolver.Point foot; // 0x88
	public IKSolver.Point toe; // 0x90
	public IKSolverVR.Leg leg; // 0x98
	public Vector3 heelOffset; // 0xA0
	private Vector3[] positions; // 0xB0
	private Quaternion[] rotations; // 0xB8

	// Methods

	// RVA: 0x3C68650 Offset: 0x3C68751 VA: 0x3C68650 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x3C68A10 Offset: 0x3C68B11 VA: 0x3C68A10
	public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root) { }

	// RVA: 0x3C68AB0 Offset: 0x3C68BB1 VA: 0x3C68AB0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x3C68C40 Offset: 0x3C68D41 VA: 0x3C68C40 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x3C68DC0 Offset: 0x3C68EC1 VA: 0x3C68DC0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x3C68E10 Offset: 0x3C68F11 VA: 0x3C68E10 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x3C68E70 Offset: 0x3C68F71 VA: 0x3C68E70 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x3C69160 Offset: 0x3C69261 VA: 0x3C69160 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x3C691F0 Offset: 0x3C692F1 VA: 0x3C691F0
	private void Solve() { }

	// RVA: 0x3C68ED0 Offset: 0x3C68FD1 VA: 0x3C68ED0
	private void Read() { }

	// RVA: 0x3C69280 Offset: 0x3C69381 VA: 0x3C69280
	private void Write() { }

	// RVA: 0x3C693B0 Offset: 0x3C694B1 VA: 0x3C693B0
	public void .ctor() { }
}

