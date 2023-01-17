// Namespace: RootMotion.FinalIK
[Serializable]
public class FBIKChain // TypeDefIndex: 14359
{
	// Fields
	[RangeAttribute] // RVA: 0x2A07D0 Offset: 0x2A08D1 VA: 0x2A07D0
	public float pin; // 0x10
	[RangeAttribute] // RVA: 0x2A07F0 Offset: 0x2A08F1 VA: 0x2A07F0
	public float pull; // 0x14
	[RangeAttribute] // RVA: 0x2A0810 Offset: 0x2A0911 VA: 0x2A0810
	public float push; // 0x18
	[RangeAttribute] // RVA: 0x2A0830 Offset: 0x2A0931 VA: 0x2A0830
	public float pushParent; // 0x1C
	[RangeAttribute] // RVA: 0x2A0850 Offset: 0x2A0951 VA: 0x2A0850
	public float reach; // 0x20
	public FBIKChain.Smoothing reachSmoothing; // 0x24
	public FBIKChain.Smoothing pushSmoothing; // 0x28
	public IKSolver.Node[] nodes; // 0x30
	public int[] children; // 0x38
	public FBIKChain.ChildConstraint[] childConstraints; // 0x40
	public IKConstraintBend bendConstraint; // 0x48
	private float rootLength; // 0x50
	private bool initiated; // 0x54
	private float length; // 0x58
	private float distance; // 0x5C
	private IKSolver.Point p; // 0x60
	private float reachForce; // 0x68
	private float pullParentSum; // 0x6C
	private float[] crossFades; // 0x70
	private float sqrMag1; // 0x78
	private float sqrMag2; // 0x7C
	private float sqrMagDif; // 0x80
	private const float maxLimbLength = 0.99999;

	// Methods

	// RVA: 0x2A0A520 Offset: 0x2A0A621 VA: 0x2A0A520
	public void .ctor() { }

	// RVA: 0x2A0A650 Offset: 0x2A0A751 VA: 0x2A0A650
	public void .ctor(float pin, float pull, Transform[] nodeTransforms) { }

	// RVA: 0x2A0A7D0 Offset: 0x2A0A8D1 VA: 0x2A0A7D0
	public void SetNodes(Transform[] boneTransforms) { }

	// RVA: 0x2A0A900 Offset: 0x2A0AA01 VA: 0x2A0A900
	public int GetNodeIndex(Transform boneTransform) { }

	// RVA: 0x2A0A9F0 Offset: 0x2A0AAF1 VA: 0x2A0A9F0
	public bool IsValid(ref string message) { }

	// RVA: 0x2A0AB10 Offset: 0x2A0AC11 VA: 0x2A0AB10
	public void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x2A0B150 Offset: 0x2A0B251 VA: 0x2A0B150
	public void ReadPose(IKSolverFullBody solver, bool fullBody) { }

	// RVA: 0x2A0AC80 Offset: 0x2A0AD81 VA: 0x2A0AC80
	private void CalculateBoneLengths(IKSolverFullBody solver) { }

	// RVA: 0x2A0B4E0 Offset: 0x2A0B5E1 VA: 0x2A0B4E0
	public void Reach(IKSolverFullBody solver) { }

	// RVA: 0x2A0B730 Offset: 0x2A0B831 VA: 0x2A0B730
	public Vector3 Push(IKSolverFullBody solver) { }

	// RVA: 0x2A0B970 Offset: 0x2A0BA71 VA: 0x2A0B970
	public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = False) { }

	// RVA: 0x2A0BCF0 Offset: 0x2A0BDF1 VA: 0x2A0BCF0
	public void Stage1(IKSolverFullBody solver) { }

	// RVA: 0x2A0C230 Offset: 0x2A0C331 VA: 0x2A0C230
	public void Stage2(IKSolverFullBody solver, Vector3 position) { }

	// RVA: 0x2A0C4B0 Offset: 0x2A0C5B1 VA: 0x2A0C4B0
	public void SolveConstraintSystems(IKSolverFullBody solver) { }

	// RVA: 0x2A0C1C0 Offset: 0x2A0C2C1 VA: 0x2A0C1C0
	private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) { }

	// RVA: 0x2A0BB70 Offset: 0x2A0BC71 VA: 0x2A0BB70
	protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude) { }

	// RVA: 0x2A0C140 Offset: 0x2A0C241 VA: 0x2A0C140
	private void SolveChildConstraints(IKSolverFullBody solver) { }

	// RVA: 0x2A0C6A0 Offset: 0x2A0C7A1 VA: 0x2A0C6A0
	private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance) { }

	// RVA: 0x2A0C020 Offset: 0x2A0C121 VA: 0x2A0C020
	public void ForwardReach(Vector3 position) { }

	// RVA: 0x2A0C330 Offset: 0x2A0C431 VA: 0x2A0C330
	private void BackwardReach(Vector3 position) { }
}

