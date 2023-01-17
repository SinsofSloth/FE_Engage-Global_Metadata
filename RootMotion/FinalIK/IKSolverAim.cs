// Namespace: RootMotion.FinalIK
[Serializable]
public class IKSolverAim : IKSolverHeuristic // TypeDefIndex: 14374
{
	// Fields
	public Transform transform; // 0x88
	public Vector3 axis; // 0x90
	public Vector3 poleAxis; // 0x9C
	public Vector3 polePosition; // 0xA8
	[RangeAttribute] // RVA: 0x2A0AE0 Offset: 0x2A0BE1 VA: 0x2A0AE0
	public float poleWeight; // 0xB4
	public Transform poleTarget; // 0xB8
	[RangeAttribute] // RVA: 0x2A0B00 Offset: 0x2A0C01 VA: 0x2A0B00
	public float clampWeight; // 0xC0
	[RangeAttribute] // RVA: 0x2A0B20 Offset: 0x2A0C21 VA: 0x2A0B20
	public int clampSmoothing; // 0xC4
	public IKSolver.IterationDelegate OnPreIteration; // 0xC8
	private float step; // 0xD0
	private Vector3 clampedIKPosition; // 0xD4
	private RotationLimit transformLimit; // 0xE0
	private Transform lastTransform; // 0xE8

	// Properties
	public Vector3 transformAxis { get; }
	public Vector3 transformPoleAxis { get; }
	protected override int minBones { get; }
	protected override Vector3 localDirection { get; }

	// Methods

	// RVA: 0x3C5D190 Offset: 0x3C5D291 VA: 0x3C5D190
	public float GetAngle() { }

	// RVA: 0x3C5D220 Offset: 0x3C5D321 VA: 0x3C5D220
	public Vector3 get_transformAxis() { }

	// RVA: 0x3C5D260 Offset: 0x3C5D361 VA: 0x3C5D260
	public Vector3 get_transformPoleAxis() { }

	// RVA: 0x3C5D2A0 Offset: 0x3C5D3A1 VA: 0x3C5D2A0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x3C5D4D0 Offset: 0x3C5D5D1 VA: 0x3C5D4D0 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x3C5DDB0 Offset: 0x3C5DEB1 VA: 0x3C5DDB0 Slot: 12
	protected override int get_minBones() { }

	// RVA: 0x3C5DCF0 Offset: 0x3C5DDF1 VA: 0x3C5DCF0
	private void Solve() { }

	// RVA: 0x3C5DA40 Offset: 0x3C5DB41 VA: 0x3C5DA40
	private Vector3 GetClampedIKPosition() { }

	// RVA: 0x3C5DDC0 Offset: 0x3C5DEC1 VA: 0x3C5DDC0
	private void RotateToTarget(Vector3 targetPosition, IKSolver.Bone bone, float weight) { }

	// RVA: 0x3C5E190 Offset: 0x3C5E291 VA: 0x3C5E190 Slot: 15
	protected override Vector3 get_localDirection() { }

	// RVA: 0x3C5E1F0 Offset: 0x3C5E2F1 VA: 0x3C5E1F0
	public void .ctor() { }
}

