// Namespace: RootMotion.FinalIK
[Serializable]
public class IKMappingLimb : IKMapping // TypeDefIndex: 14366
{
	// Fields
	public Transform parentBone; // 0x10
	public Transform bone1; // 0x18
	public Transform bone2; // 0x20
	public Transform bone3; // 0x28
	[RangeAttribute] // RVA: 0x2A0970 Offset: 0x2A0A71 VA: 0x2A0970
	public float maintainRotationWeight; // 0x30
	[RangeAttribute] // RVA: 0x2A0990 Offset: 0x2A0A91 VA: 0x2A0990
	public float weight; // 0x34
	public bool updatePlaneRotations; // 0x38
	private IKMapping.BoneMap boneMapParent; // 0x40
	private IKMapping.BoneMap boneMap1; // 0x48
	private IKMapping.BoneMap boneMap2; // 0x50
	private IKMapping.BoneMap boneMap3; // 0x58

	// Methods

	// RVA: 0x2D65940 Offset: 0x2D65A41 VA: 0x2D65940 Slot: 4
	public override bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x2D659C0 Offset: 0x2D65AC1 VA: 0x2D659C0
	public IKMapping.BoneMap GetBoneMap(IKMappingLimb.BoneMapType boneMap) { }

	// RVA: 0x2D65AA0 Offset: 0x2D65BA1 VA: 0x2D65AA0
	public void SetLimbOrientation(Vector3 upper, Vector3 lower) { }

	// RVA: 0x2D65CA0 Offset: 0x2D65DA1 VA: 0x2D65CA0
	public void .ctor() { }

	// RVA: 0x2D65DA0 Offset: 0x2D65EA1 VA: 0x2D65DA0
	public void .ctor(Transform bone1, Transform bone2, Transform bone3, Transform parentBone) { }

	// RVA: 0x2D65F00 Offset: 0x2D66001 VA: 0x2D65F00
	public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone) { }

	// RVA: 0x2D65F70 Offset: 0x2D66071 VA: 0x2D65F70
	public void StoreDefaultLocalState() { }

	// RVA: 0x2D66020 Offset: 0x2D66121 VA: 0x2D66020
	public void FixTransforms() { }

	// RVA: 0x2D660E0 Offset: 0x2D661E1 VA: 0x2D660E0 Slot: 5
	public override void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x2D66380 Offset: 0x2D66481 VA: 0x2D66380
	public void ReadPose() { }

	// RVA: 0x2D663F0 Offset: 0x2D664F1 VA: 0x2D663F0
	public void WritePose(IKSolverFullBody solver, bool fullBody) { }
}

