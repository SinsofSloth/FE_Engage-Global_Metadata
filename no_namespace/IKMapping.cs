// Namespace: 
[Serializable]
public class IKMapping.BoneMap // TypeDefIndex: 14362
{
	// Fields
	public Transform transform; // 0x10
	public int chainIndex; // 0x18
	public int nodeIndex; // 0x1C
	public Vector3 defaultLocalPosition; // 0x20
	public Quaternion defaultLocalRotation; // 0x2C
	public Vector3 localSwingAxis; // 0x3C
	public Vector3 localTwistAxis; // 0x48
	public Vector3 planePosition; // 0x54
	public Vector3 ikPosition; // 0x60
	public Quaternion defaultLocalTargetRotation; // 0x6C
	private Quaternion maintainRotation; // 0x7C
	public float length; // 0x8C
	public Quaternion animatedRotation; // 0x90
	private Transform planeBone1; // 0xA0
	private Transform planeBone2; // 0xA8
	private Transform planeBone3; // 0xB0
	private int plane1ChainIndex; // 0xB8
	private int plane1NodeIndex; // 0xBC
	private int plane2ChainIndex; // 0xC0
	private int plane2NodeIndex; // 0xC4
	private int plane3ChainIndex; // 0xC8
	private int plane3NodeIndex; // 0xCC

	// Properties
	public Vector3 swingDirection { get; }
	public bool isNodeBone { get; }
	private Quaternion lastAnimatedTargetRotation { get; }

	// Methods

	// RVA: 0x35FACC0 Offset: 0x35FADC1 VA: 0x35FACC0
	public void Initiate(Transform transform, IKSolverFullBody solver) { }

	// RVA: 0x35FAD10 Offset: 0x35FAE11 VA: 0x35FAD10
	public Vector3 get_swingDirection() { }

	// RVA: 0x35FAD50 Offset: 0x35FAE51 VA: 0x35FAD50
	public void StoreDefaultLocalState() { }

	// RVA: 0x35FADA0 Offset: 0x35FAEA1 VA: 0x35FADA0
	public void FixTransform(bool position) { }

	// RVA: 0x35FADF0 Offset: 0x35FAEF1 VA: 0x35FADF0
	public bool get_isNodeBone() { }

	// RVA: 0x35FAE00 Offset: 0x35FAF01 VA: 0x35FAE00
	public void SetLength(IKMapping.BoneMap nextBone) { }

	// RVA: 0x35FAE80 Offset: 0x35FAF81 VA: 0x35FAE80
	public void SetLocalSwingAxis(IKMapping.BoneMap swingTarget) { }

	// RVA: 0x35FAF40 Offset: 0x35FB041 VA: 0x35FAF40
	public void SetLocalSwingAxis(IKMapping.BoneMap bone1, IKMapping.BoneMap bone2) { }

	// RVA: 0x35FB000 Offset: 0x35FB101 VA: 0x35FB000
	public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection) { }

	// RVA: 0x35FB080 Offset: 0x35FB181 VA: 0x35FB080
	public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3) { }

	// RVA: 0x35FB140 Offset: 0x35FB241 VA: 0x35FB140
	public void UpdatePlane(bool rotation, bool position) { }

	// RVA: 0x35FB360 Offset: 0x35FB461 VA: 0x35FB360
	public void SetIKPosition() { }

	// RVA: 0x35FB3A0 Offset: 0x35FB4A1 VA: 0x35FB3A0
	public void MaintainRotation() { }

	// RVA: 0x35FB3E0 Offset: 0x35FB4E1 VA: 0x35FB3E0
	public void SetToIKPosition() { }

	// RVA: 0x35FB400 Offset: 0x35FB501 VA: 0x35FB400
	public void FixToNode(IKSolverFullBody solver, float weight, IKSolver.Node fixNode) { }

	// RVA: 0x35FB4F0 Offset: 0x35FB5F1 VA: 0x35FB4F0
	public Vector3 GetPlanePosition(IKSolverFullBody solver) { }

	// RVA: 0x35FB660 Offset: 0x35FB761 VA: 0x35FB660
	public void PositionToPlane(IKSolverFullBody solver) { }

	// RVA: 0x35FB6F0 Offset: 0x35FB7F1 VA: 0x35FB6F0
	public void RotateToPlane(IKSolverFullBody solver, float weight) { }

	// RVA: 0x35FB7C0 Offset: 0x35FB8C1 VA: 0x35FB7C0
	public void Swing(Vector3 swingTarget, float weight) { }

	// RVA: 0x35FB830 Offset: 0x35FB931 VA: 0x35FB830
	public void Swing(Vector3 pos1, Vector3 pos2, float weight) { }

	// RVA: 0x35FB980 Offset: 0x35FBA81 VA: 0x35FB980
	public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight) { }

	// RVA: 0x35FBAD0 Offset: 0x35FBBD1 VA: 0x35FBAD0
	public void RotateToMaintain(float weight) { }

	// RVA: 0x35FBB40 Offset: 0x35FBC41 VA: 0x35FBB40
	public void RotateToEffector(IKSolverFullBody solver, float weight) { }

	// RVA: 0x35FB560 Offset: 0x35FB661 VA: 0x35FB560
	private Quaternion GetTargetRotation(IKSolverFullBody solver) { }

	// RVA: 0x35FB250 Offset: 0x35FB351 VA: 0x35FB250
	private Quaternion get_lastAnimatedTargetRotation() { }

	// RVA: 0x35FBC60 Offset: 0x35FBD61 VA: 0x35FBC60
	public void .ctor() { }
}

