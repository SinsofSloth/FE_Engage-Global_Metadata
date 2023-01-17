// Namespace: RootMotion.FinalIK
[Serializable]
public class IKSolverHeuristic : IKSolver // TypeDefIndex: 14383
{
	// Fields
	public Transform target; // 0x58
	public float tolerance; // 0x60
	public int maxIterations; // 0x64
	public bool useRotationLimits; // 0x68
	public bool XY; // 0x69
	public IKSolver.Bone[] bones; // 0x70
	protected Vector3 lastLocalDirection; // 0x78
	protected float chainLength; // 0x84

	// Properties
	protected virtual int minBones { get; }
	protected virtual bool boneLengthCanBeZero { get; }
	protected virtual bool allowCommonParent { get; }
	protected virtual Vector3 localDirection { get; }
	protected float positionOffset { get; }

	// Methods

	// RVA: 0x3C67AE0 Offset: 0x3C67BE1 VA: 0x3C67AE0
	public bool SetChain(Transform[] hierarchy, Transform root) { }

	// RVA: 0x3C67C80 Offset: 0x3C67D81 VA: 0x3C67C80
	public void AddBone(Transform bone) { }

	// RVA: 0x3C67DE0 Offset: 0x3C67EE1 VA: 0x3C67DE0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x3C67E50 Offset: 0x3C67F51 VA: 0x3C67E50 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x3C67ED0 Offset: 0x3C67FD1 VA: 0x3C67ED0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x3C68270 Offset: 0x3C68371 VA: 0x3C68270 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x3C68280 Offset: 0x3C68381 VA: 0x3C68280 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x3C68380 Offset: 0x3C68481 VA: 0x3C68380 Slot: 12
	protected virtual int get_minBones() { }

	// RVA: 0x3C68390 Offset: 0x3C68491 VA: 0x3C68390 Slot: 13
	protected virtual bool get_boneLengthCanBeZero() { }

	// RVA: 0x3C683A0 Offset: 0x3C684A1 VA: 0x3C683A0 Slot: 14
	protected virtual bool get_allowCommonParent() { }

	// RVA: 0x3C683B0 Offset: 0x3C684B1 VA: 0x3C683B0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x3C683C0 Offset: 0x3C684C1 VA: 0x3C683C0 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x3C5F350 Offset: 0x3C5F451 VA: 0x3C5F350
	protected void InitiateBones() { }

	// RVA: 0x3C683D0 Offset: 0x3C684D1 VA: 0x3C683D0 Slot: 15
	protected virtual Vector3 get_localDirection() { }

	// RVA: 0x3C5FC80 Offset: 0x3C5FD81 VA: 0x3C5FC80
	protected float get_positionOffset() { }

	// RVA: 0x3C5F9B0 Offset: 0x3C5FAB1 VA: 0x3C5F9B0
	protected Vector3 GetSingularityOffset() { }

	// RVA: 0x3C68480 Offset: 0x3C68581 VA: 0x3C68480
	private bool SingularityDetected() { }

	// RVA: 0x3C5E2C0 Offset: 0x3C5E3C1 VA: 0x3C5E2C0
	public void .ctor() { }
}

