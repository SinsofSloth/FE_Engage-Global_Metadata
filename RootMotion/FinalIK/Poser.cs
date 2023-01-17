// Namespace: RootMotion.FinalIK
public abstract class Poser : SolverManager // TypeDefIndex: 14428
{
	// Fields
	public Transform poseRoot; // 0x38
	[RangeAttribute] // RVA: 0x2A3970 Offset: 0x2A3A71 VA: 0x2A3970
	public float weight; // 0x40
	[RangeAttribute] // RVA: 0x2A3990 Offset: 0x2A3A91 VA: 0x2A3990
	public float localRotationWeight; // 0x44
	[RangeAttribute] // RVA: 0x2A39B0 Offset: 0x2A3AB1 VA: 0x2A39B0
	public float localPositionWeight; // 0x48
	private bool initiated; // 0x4C

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void AutoMapping();

	// RVA: 0x29DA450 Offset: 0x29DA551 VA: 0x29DA450
	public void UpdateManual() { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void InitiatePoser();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void UpdatePoser();

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void FixPoserTransforms();

	// RVA: 0x29DA460 Offset: 0x29DA561 VA: 0x29DA460 Slot: 5
	protected override void UpdateSolver() { }

	// RVA: 0x29DA4C0 Offset: 0x29DA5C1 VA: 0x29DA4C0 Slot: 4
	protected override void InitiateSolver() { }

	// RVA: 0x29DA510 Offset: 0x29DA611 VA: 0x29DA510 Slot: 6
	protected override void FixTransforms() { }

	// RVA: 0x29DA530 Offset: 0x29DA631 VA: 0x29DA530
	protected void .ctor() { }
}

