// Namespace: RootMotion.FinalIK
[Serializable]
public class IKMappingSpine : IKMapping // TypeDefIndex: 14367
{
	// Fields
	public Transform[] spineBones; // 0x10
	public Transform leftUpperArmBone; // 0x18
	public Transform rightUpperArmBone; // 0x20
	public Transform leftThighBone; // 0x28
	public Transform rightThighBone; // 0x30
	[RangeAttribute] // RVA: 0x2A09B0 Offset: 0x2A0AB1 VA: 0x2A09B0
	public int iterations; // 0x38
	[RangeAttribute] // RVA: 0x2A09D0 Offset: 0x2A0AD1 VA: 0x2A09D0
	public float twistWeight; // 0x3C
	private int rootNodeIndex; // 0x40
	private IKMapping.BoneMap[] spine; // 0x48
	private IKMapping.BoneMap leftUpperArm; // 0x50
	private IKMapping.BoneMap rightUpperArm; // 0x58
	private IKMapping.BoneMap leftThigh; // 0x60
	private IKMapping.BoneMap rightThigh; // 0x68
	private bool useFABRIK; // 0x70

	// Methods

	// RVA: 0x2D66530 Offset: 0x2D66631 VA: 0x2D66530 Slot: 4
	public override bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x2D66890 Offset: 0x2D66991 VA: 0x2D66890
	public void .ctor() { }

	// RVA: 0x2D669B0 Offset: 0x2D66AB1 VA: 0x2D669B0
	public void .ctor(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	// RVA: 0x2D66B50 Offset: 0x2D66C51 VA: 0x2D66B50
	public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone) { }

	// RVA: 0x2D66BD0 Offset: 0x2D66CD1 VA: 0x2D66BD0
	public void StoreDefaultLocalState() { }

	// RVA: 0x2D66C40 Offset: 0x2D66D41 VA: 0x2D66C40
	public void FixTransforms() { }

	// RVA: 0x2D66CC0 Offset: 0x2D66DC1 VA: 0x2D66CC0 Slot: 5
	public override void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x2D672A0 Offset: 0x2D673A1 VA: 0x2D672A0
	private bool UseFABRIK() { }

	// RVA: 0x2D672D0 Offset: 0x2D673D1 VA: 0x2D672D0
	public void ReadPose() { }

	// RVA: 0x2D67500 Offset: 0x2D67601 VA: 0x2D67500
	public void WritePose(IKSolverFullBody solver) { }

	// RVA: 0x2D677A0 Offset: 0x2D678A1 VA: 0x2D677A0
	public void ForwardReach(Vector3 position) { }

	// RVA: 0x2D678D0 Offset: 0x2D679D1 VA: 0x2D678D0
	private void BackwardReach(Vector3 position) { }

	// RVA: 0x2D679E0 Offset: 0x2D67AE1 VA: 0x2D679E0
	private void MapToSolverPositions(IKSolverFullBody solver) { }
}

