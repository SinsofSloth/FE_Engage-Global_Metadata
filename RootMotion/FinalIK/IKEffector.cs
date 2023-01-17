// Namespace: RootMotion.FinalIK
[Serializable]
public class IKEffector // TypeDefIndex: 14361
{
	// Fields
	public Transform bone; // 0x10
	public Transform target; // 0x18
	[RangeAttribute] // RVA: 0x2A08E0 Offset: 0x2A09E1 VA: 0x2A08E0
	public float positionWeight; // 0x20
	[RangeAttribute] // RVA: 0x2A0900 Offset: 0x2A0A01 VA: 0x2A0900
	public float rotationWeight; // 0x24
	public Vector3 position; // 0x28
	public Quaternion rotation; // 0x34
	public Vector3 positionOffset; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x2A0920 Offset: 0x2A0A21 VA: 0x2A0920
	private bool <isEndEffector>k__BackingField; // 0x50
	public bool effectChildNodes; // 0x51
	[RangeAttribute] // RVA: 0x2A0930 Offset: 0x2A0A31 VA: 0x2A0930
	public float maintainRelativePositionWeight; // 0x54
	public Transform[] childBones; // 0x58
	public Transform planeBone1; // 0x60
	public Transform planeBone2; // 0x68
	public Transform planeBone3; // 0x70
	public Quaternion planeRotationOffset; // 0x78
	private float posW; // 0x88
	private float rotW; // 0x8C
	private Vector3[] localPositions; // 0x90
	private bool usePlaneNodes; // 0x98
	private Quaternion animatedPlaneRotation; // 0x9C
	private Vector3 animatedPosition; // 0xAC
	private bool firstUpdate; // 0xB8
	private int chainIndex; // 0xBC
	private int nodeIndex; // 0xC0
	private int plane1ChainIndex; // 0xC4
	private int plane1NodeIndex; // 0xC8
	private int plane2ChainIndex; // 0xCC
	private int plane2NodeIndex; // 0xD0
	private int plane3ChainIndex; // 0xD4
	private int plane3NodeIndex; // 0xD8
	private int[] childChainIndexes; // 0xE0
	private int[] childNodeIndexes; // 0xE8

	// Properties
	public bool isEndEffector { get; set; }

	// Methods

	// RVA: 0x2D63AB0 Offset: 0x2D63BB1 VA: 0x2D63AB0
	public IKSolver.Node GetNode(IKSolverFullBody solver) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CF9A0 Offset: 0x2CFAA1 VA: 0x2CF9A0
	// RVA: 0x2D63B10 Offset: 0x2D63C11 VA: 0x2D63B10
	public bool get_isEndEffector() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CF9B0 Offset: 0x2CFAB1 VA: 0x2CF9B0
	// RVA: 0x2D63B20 Offset: 0x2D63C21 VA: 0x2D63B20
	private void set_isEndEffector(bool value) { }

	// RVA: 0x2D63B30 Offset: 0x2D63C31 VA: 0x2D63B30
	public void PinToBone(float positionWeight, float rotationWeight) { }

	// RVA: 0x2D63BD0 Offset: 0x2D63CD1 VA: 0x2D63BD0
	public void .ctor() { }

	// RVA: 0x2D63D40 Offset: 0x2D63E41 VA: 0x2D63D40
	public void .ctor(Transform bone, Transform[] childBones) { }

	// RVA: 0x2D63EE0 Offset: 0x2D63FE1 VA: 0x2D63EE0
	public bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x2D641F0 Offset: 0x2D642F1 VA: 0x2D641F0
	public void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x2D644A0 Offset: 0x2D645A1 VA: 0x2D644A0
	public void ResetOffset(IKSolverFullBody solver) { }

	// RVA: 0x2D64580 Offset: 0x2D64681 VA: 0x2D64580
	public void SetToTarget() { }

	// RVA: 0x2D64630 Offset: 0x2D64731 VA: 0x2D64630
	public void OnPreSolve(IKSolverFullBody solver) { }

	// RVA: 0x2D649E0 Offset: 0x2D64AE1 VA: 0x2D649E0
	public void OnPostWrite() { }

	// RVA: 0x2D64A10 Offset: 0x2D64B11 VA: 0x2D64A10
	private Quaternion GetPlaneRotation(IKSolverFullBody solver) { }

	// RVA: 0x2D64B60 Offset: 0x2D64C61 VA: 0x2D64B60
	public void Update(IKSolverFullBody solver) { }

	// RVA: 0x2D64DB0 Offset: 0x2D64EB1 VA: 0x2D64DB0
	private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset) { }
}

