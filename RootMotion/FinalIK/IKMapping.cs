// Namespace: RootMotion.FinalIK
[Serializable]
public class IKMapping // TypeDefIndex: 14363
{
	// Methods

	// RVA: 0x2D65490 Offset: 0x2D65591 VA: 0x2D65490 Slot: 4
	public virtual bool IsValid(IKSolver solver, ref string message) { }

	// RVA: 0x2D654A0 Offset: 0x2D655A1 VA: 0x2D654A0 Slot: 5
	public virtual void Initiate(IKSolverFullBody solver) { }

	// RVA: 0x2D654B0 Offset: 0x2D655B1 VA: 0x2D654B0
	protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, Warning.Logger logger) { }

	// RVA: 0x2D65600 Offset: 0x2D65701 VA: 0x2D65600
	protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length) { }

	// RVA: 0x2D65670 Offset: 0x2D65771 VA: 0x2D65670
	public void .ctor() { }
}

