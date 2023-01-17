// Namespace: RootMotion.FinalIK
[Serializable]
public class IKSolverFABRIK : IKSolverHeuristic // TypeDefIndex: 14377
{
	// Fields
	public IKSolver.IterationDelegate OnPreIteration; // 0x88
	private bool[] limitedBones; // 0x90
	private Vector3[] solverLocalPositions; // 0x98

	// Properties
	protected override bool boneLengthCanBeZero { get; }

	// Methods

	// RVA: 0x3C602F0 Offset: 0x3C603F1 VA: 0x3C602F0
	public void SolveForward(Vector3 position) { }

	// RVA: 0x3C608D0 Offset: 0x3C609D1 VA: 0x3C608D0
	public void SolveBackward(Vector3 position) { }

	// RVA: 0x3C60A60 Offset: 0x3C60B61 VA: 0x3C60A60 Slot: 5
	public override Vector3 GetIKPosition() { }

	// RVA: 0x3C60B00 Offset: 0x3C60C01 VA: 0x3C60B00 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x3C60FA0 Offset: 0x3C610A1 VA: 0x3C60FA0 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x3C612A0 Offset: 0x3C613A1 VA: 0x3C612A0 Slot: 13
	protected override bool get_boneLengthCanBeZero() { }

	// RVA: 0x3C612B0 Offset: 0x3C613B1 VA: 0x3C612B0
	private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length) { }

	// RVA: 0x3C603D0 Offset: 0x3C604D1 VA: 0x3C603D0
	private void OnPreSolve() { }

	// RVA: 0x3C60A00 Offset: 0x3C60B01 VA: 0x3C60A00
	private void OnPostSolve() { }

	// RVA: 0x3C61230 Offset: 0x3C61331 VA: 0x3C61230
	private void Solve(Vector3 targetPosition) { }

	// RVA: 0x3C606F0 Offset: 0x3C607F1 VA: 0x3C606F0
	private void ForwardReach(Vector3 position) { }

	// RVA: 0x3C619F0 Offset: 0x3C61AF1 VA: 0x3C619F0
	private void SolverMove(int index, Vector3 offset) { }

	// RVA: 0x3C61A60 Offset: 0x3C61B61 VA: 0x3C61A60
	private void SolverRotate(int index, Quaternion rotation, bool recursive) { }

	// RVA: 0x3C61B50 Offset: 0x3C61C51 VA: 0x3C61B50
	private void SolverRotateChildren(int index, Quaternion rotation) { }

	// RVA: 0x3C61C10 Offset: 0x3C61D11 VA: 0x3C61C10
	private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation) { }

	// RVA: 0x3C60D60 Offset: 0x3C60E61 VA: 0x3C60D60
	private Quaternion GetParentSolverRotation(int index) { }

	// RVA: 0x3C60E80 Offset: 0x3C60F81 VA: 0x3C60E80
	private Vector3 GetParentSolverPosition(int index) { }

	// RVA: 0x3C61D30 Offset: 0x3C61E31 VA: 0x3C61D30
	private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed) { }

	// RVA: 0x3C614C0 Offset: 0x3C615C1 VA: 0x3C614C0
	private void LimitForward(int rotateBone, int limitBone) { }

	// RVA: 0x3C609F0 Offset: 0x3C60AF1 VA: 0x3C609F0
	private void BackwardReach(Vector3 position) { }

	// RVA: 0x3C62320 Offset: 0x3C62421 VA: 0x3C62320
	private void BackwardReachUnlimited(Vector3 position) { }

	// RVA: 0x3C61E70 Offset: 0x3C61F71 VA: 0x3C61E70
	private void BackwardReachLimited(Vector3 position) { }

	// RVA: 0x3C61330 Offset: 0x3C61431 VA: 0x3C61330
	private void MapToSolverPositions() { }

	// RVA: 0x3C61410 Offset: 0x3C61511 VA: 0x3C61410
	private void MapToSolverPositionsLimited() { }

	// RVA: 0x3C62440 Offset: 0x3C62541 VA: 0x3C62440
	public void .ctor() { }
}

