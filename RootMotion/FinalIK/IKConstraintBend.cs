// Namespace: RootMotion.FinalIK
[Serializable]
public class IKConstraintBend // TypeDefIndex: 14360
{
	// Fields
	public Transform bone1; // 0x10
	public Transform bone2; // 0x18
	public Transform bone3; // 0x20
	public Transform bendGoal; // 0x28
	public Vector3 direction; // 0x30
	public Quaternion rotationOffset; // 0x3C
	[RangeAttribute] // RVA: 0x2A08B0 Offset: 0x2A09B1 VA: 0x2A08B0
	public float weight; // 0x4C
	public Vector3 defaultLocalDirection; // 0x50
	public Vector3 defaultChildDirection; // 0x5C
	public float clampF; // 0x68
	private int chainIndex1; // 0x6C
	private int nodeIndex1; // 0x70
	private int chainIndex2; // 0x74
	private int nodeIndex2; // 0x78
	private int chainIndex3; // 0x7C
	private int nodeIndex3; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x2A08D0 Offset: 0x2A09D1 VA: 0x2A08D0
	private bool <initiated>k__BackingField; // 0x84
	private bool limbOrientationsSet; // 0x85

	// Properties
	public bool initiated { get; set; }

	// Methods

	// RVA: 0x2D62B70 Offset: 0x2D62C71 VA: 0x2D62B70
	public bool IsValid(IKSolverFullBody solver, Warning.Logger logger) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CF980 Offset: 0x2CFA81 VA: 0x2CF980
	// RVA: 0x2D62D50 Offset: 0x2D62E51 VA: 0x2D62D50
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CF990 Offset: 0x2CFA91 VA: 0x2CF990
	// RVA: 0x2D62D60 Offset: 0x2D62E61 VA: 0x2D62D60
	private void set_initiated(bool value) { }

	// RVA: 0x2D62D70 Offset: 0x2D62E71 VA: 0x2D62D70
	public void .ctor() { }

	// RVA: 0x2D62DC0 Offset: 0x2D62EC1 VA: 0x2D62DC0
	public void .ctor(Transform bone1, Transform bone2, Transform bone3) { }

	// RVA: 0x2D62E50 Offset: 0x2D62F51 VA: 0x2D62E50
	public void SetBones(Transform bone1, Transform bone2, Transform bone3) { }

	// RVA: 0x2D62EA0 Offset: 0x2D62FA1 VA: 0x2D62EA0
	public void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x2D63240 Offset: 0x2D63341 VA: 0x2D63240
	public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last) { }

	// RVA: 0x2D63370 Offset: 0x2D63471 VA: 0x2D63370
	public void LimitBend(float solverWeight, float positionWeight) { }

	// RVA: 0x2D63690 Offset: 0x2D63791 VA: 0x2D63690
	public Vector3 GetDir(IKSolverFullBody solver) { }

	// RVA: 0x2D63100 Offset: 0x2D63201 VA: 0x2D63100
	private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent) { }

	// RVA: 0x2D631A0 Offset: 0x2D632A1 VA: 0x2D631A0
	private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent) { }
}

