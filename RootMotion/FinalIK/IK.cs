// Namespace: RootMotion.FinalIK
public abstract class IK : SolverManager // TypeDefIndex: 14345
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IKSolver GetIKSolver();

	// RVA: 0x2D62A10 Offset: 0x2D62B11 VA: 0x2D62A10 Slot: 5
	protected override void UpdateSolver() { }

	// RVA: 0x2D62A90 Offset: 0x2D62B91 VA: 0x2D62A90 Slot: 4
	protected override void InitiateSolver() { }

	// RVA: 0x2D62B00 Offset: 0x2D62C01 VA: 0x2D62B00 Slot: 6
	protected override void FixTransforms() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void OpenUserManual();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void OpenScriptReference();

	// RVA: 0x2D62B60 Offset: 0x2D62C61 VA: 0x2D62B60
	protected void .ctor() { }
}

