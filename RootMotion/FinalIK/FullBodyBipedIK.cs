// Namespace: RootMotion.FinalIK
[HelpURLAttribute] // RVA: 0x279D20 Offset: 0x279E21 VA: 0x279D20
[AddComponentMenu] // RVA: 0x279D20 Offset: 0x279E21 VA: 0x279D20
public class FullBodyBipedIK : IK // TypeDefIndex: 14344
{
	// Fields
	public BipedReferences references; // 0x38
	public IKSolverFullBodyBiped solver; // 0x40

	// Methods

	[ContextMenu] // RVA: 0x2CF200 Offset: 0x2CF301 VA: 0x2CF200
	// RVA: 0x269FC70 Offset: 0x269FD71 VA: 0x269FC70 Slot: 8
	protected override void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2CF240 Offset: 0x2CF341 VA: 0x2CF240
	// RVA: 0x269FCC0 Offset: 0x269FDC1 VA: 0x269FCC0 Slot: 9
	protected override void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x2CF280 Offset: 0x2CF381 VA: 0x2CF280
	// RVA: 0x269FD10 Offset: 0x269FE11 VA: 0x269FD10
	private void OpenSetupTutorial() { }

	[ContextMenu] // RVA: 0x2CF2C0 Offset: 0x2CF3C1 VA: 0x2CF2C0
	// RVA: 0x269FD60 Offset: 0x269FE61 VA: 0x269FD60
	private void OpenInspectorTutorial() { }

	[ContextMenu] // RVA: 0x2CF300 Offset: 0x2CF401 VA: 0x2CF300
	// RVA: 0x269FDB0 Offset: 0x269FEB1 VA: 0x269FDB0
	private void SupportGroup() { }

	[ContextMenu] // RVA: 0x2CF340 Offset: 0x2CF441 VA: 0x2CF340
	// RVA: 0x269FE00 Offset: 0x269FF01 VA: 0x269FE00
	private void ASThread() { }

	// RVA: 0x269FE50 Offset: 0x269FF51 VA: 0x269FE50
	public void SetReferences(BipedReferences references, Transform rootNode) { }

	// RVA: 0x269FE90 Offset: 0x269FF91 VA: 0x269FE90 Slot: 7
	public override IKSolver GetIKSolver() { }

	// RVA: 0x269FEA0 Offset: 0x269FFA1 VA: 0x269FEA0
	public bool ReferencesError(ref string errorMessage) { }

	// RVA: 0x26A0070 Offset: 0x26A0171 VA: 0x26A0070
	public bool ReferencesWarning(ref string warningMessage) { }

	[ContextMenu] // RVA: 0x2CF380 Offset: 0x2CF481 VA: 0x2CF380
	// RVA: 0x26A02E0 Offset: 0x26A03E1 VA: 0x26A02E0
	private void Reinitiate() { }

	[ContextMenu] // RVA: 0x2CF3C0 Offset: 0x2CF4C1 VA: 0x2CF3C0
	// RVA: 0x26A0320 Offset: 0x26A0421 VA: 0x26A0320
	private void AutoDetectReferences() { }

	// RVA: 0x269FBC0 Offset: 0x269FCC1 VA: 0x269FBC0
	public void .ctor() { }
}

