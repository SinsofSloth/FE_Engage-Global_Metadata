// Namespace: RootMotion.FinalIK
[Serializable]
public class BipedIKSolvers // TypeDefIndex: 14316
{
	// Fields
	public IKSolverLimb leftFoot; // 0x10
	public IKSolverLimb rightFoot; // 0x18
	public IKSolverLimb leftHand; // 0x20
	public IKSolverLimb rightHand; // 0x28
	public IKSolverFABRIK spine; // 0x30
	public IKSolverLookAt lookAt; // 0x38
	public IKSolverAim aim; // 0x40
	public Constraints pelvis; // 0x48
	private IKSolverLimb[] _limbs; // 0x50
	private IKSolver[] _ikSolvers; // 0x58

	// Properties
	public IKSolverLimb[] limbs { get; }
	public IKSolver[] ikSolvers { get; }

	// Methods

	// RVA: 0x2267200 Offset: 0x2267301 VA: 0x2267200
	public IKSolverLimb[] get_limbs() { }

	// RVA: 0x2267AD0 Offset: 0x2267BD1 VA: 0x2267AD0
	public IKSolver[] get_ikSolvers() { }

	// RVA: 0x22675B0 Offset: 0x22676B1 VA: 0x22675B0
	public void AssignReferences(BipedReferences references) { }

	// RVA: 0x22678E0 Offset: 0x22679E1 VA: 0x22678E0
	public void .ctor() { }
}

