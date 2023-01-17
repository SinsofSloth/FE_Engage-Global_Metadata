// Namespace: RootMotion.FinalIK
[Serializable]
public class IKMappingBone : IKMapping // TypeDefIndex: 14364
{
	// Fields
	public Transform bone; // 0x10
	[RangeAttribute] // RVA: 0x2A0950 Offset: 0x2A0A51 VA: 0x2A0950
	public float maintainRotationWeight; // 0x18
	private IKMapping.BoneMap boneMap; // 0x20

	// Methods

	// RVA: 0x2D65680 Offset: 0x2D65781 VA: 0x2D65680 Slot: 4
	public override bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x2D65740 Offset: 0x2D65841 VA: 0x2D65740
	public void .ctor() { }

	// RVA: 0x2D657C0 Offset: 0x2D658C1 VA: 0x2D657C0
	public void .ctor(Transform bone) { }

	// RVA: 0x2D65860 Offset: 0x2D65961 VA: 0x2D65860
	public void StoreDefaultLocalState() { }

	// RVA: 0x2D65870 Offset: 0x2D65971 VA: 0x2D65870
	public void FixTransforms() { }

	// RVA: 0x2D65880 Offset: 0x2D65981 VA: 0x2D65880 Slot: 5
	public override void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x2D65910 Offset: 0x2D65A11 VA: 0x2D65910
	public void ReadPose() { }

	// RVA: 0x2D65920 Offset: 0x2D65A21 VA: 0x2D65920
	public void WritePose(float solverWeight) { }
}

