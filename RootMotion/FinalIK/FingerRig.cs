// Namespace: RootMotion.FinalIK
public class FingerRig : SolverManager // TypeDefIndex: 14325
{
	// Fields
	[TooltipAttribute] // RVA: 0x29ED30 Offset: 0x29EE31 VA: 0x29ED30
	[RangeAttribute] // RVA: 0x29ED30 Offset: 0x29EE31 VA: 0x29ED30
	public float weight; // 0x34
	public Finger[] fingers; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x29ED90 Offset: 0x29EE91 VA: 0x29ED90
	private bool <initiated>k__BackingField; // 0x40

	// Properties
	public bool initiated { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CE740 Offset: 0x2CE841 VA: 0x2CE740
	// RVA: 0x2A23230 Offset: 0x2A23331 VA: 0x2A23230
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE750 Offset: 0x2CE851 VA: 0x2CE750
	// RVA: 0x2A23240 Offset: 0x2A23341 VA: 0x2A23240
	private void set_initiated(bool value) { }

	// RVA: 0x2A23250 Offset: 0x2A23351 VA: 0x2A23250
	public bool IsValid(ref string errorMessage) { }

	[ContextMenu] // RVA: 0x2CE760 Offset: 0x2CE861 VA: 0x2CE760
	// RVA: 0x2A232E0 Offset: 0x2A233E1 VA: 0x2A232E0
	public void AutoDetect() { }

	// RVA: 0x2A23650 Offset: 0x2A23751 VA: 0x2A23650
	public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, Transform target) { }

	// RVA: 0x2A23800 Offset: 0x2A23901 VA: 0x2A23800
	public void RemoveFinger(int index) { }

	// RVA: 0x2A23550 Offset: 0x2A23651 VA: 0x2A23550
	private void AddChildrenRecursive(Transform parent, ref Transform[] array) { }

	// RVA: 0x2A23990 Offset: 0x2A23A91 VA: 0x2A23990 Slot: 4
	protected override void InitiateSolver() { }

	// RVA: 0x2A23A50 Offset: 0x2A23B51 VA: 0x2A23A50
	public void UpdateFingerSolvers() { }

	// RVA: 0x2A23AC0 Offset: 0x2A23BC1 VA: 0x2A23AC0
	public void FixFingerTransforms() { }

	// RVA: 0x2A23B40 Offset: 0x2A23C41 VA: 0x2A23B40
	public void StoreDefaultLocalState() { }

	// RVA: 0x2A23BB0 Offset: 0x2A23CB1 VA: 0x2A23BB0 Slot: 5
	protected override void UpdateSolver() { }

	// RVA: 0x2A23C20 Offset: 0x2A23D21 VA: 0x2A23C20 Slot: 6
	protected override void FixTransforms() { }

	// RVA: 0x2A23CA0 Offset: 0x2A23DA1 VA: 0x2A23CA0
	public void .ctor() { }
}

