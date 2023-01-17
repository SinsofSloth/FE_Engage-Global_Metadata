// Namespace: RootMotion.FinalIK
[AddComponentMenu] // RVA: 0x279F00 Offset: 0x27A001 VA: 0x279F00
public class VRIK : IK // TypeDefIndex: 14352
{
	// Fields
	[ContextMenuItemAttribute] // RVA: 0x29FC30 Offset: 0x29FD31 VA: 0x29FC30
	[TooltipAttribute] // RVA: 0x29FC30 Offset: 0x29FD31 VA: 0x29FC30
	public VRIK.References references; // 0x38
	[TooltipAttribute] // RVA: 0x29FCB0 Offset: 0x29FDB1 VA: 0x29FCB0
	public IKSolverVR solver; // 0x40

	// Methods

	[ContextMenu] // RVA: 0x2CF800 Offset: 0x2CF901 VA: 0x2CF800
	// RVA: 0x2A400F0 Offset: 0x2A401F1 VA: 0x2A400F0 Slot: 8
	protected override void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2CF840 Offset: 0x2CF941 VA: 0x2CF840
	// RVA: 0x2A40140 Offset: 0x2A40241 VA: 0x2A40140 Slot: 9
	protected override void OpenScriptReference() { }

	[ContextMenu] // RVA: 0x2CF880 Offset: 0x2CF981 VA: 0x2CF880
	// RVA: 0x2A40190 Offset: 0x2A40291 VA: 0x2A40190
	private void OpenSetupTutorial() { }

	[ContextMenu] // RVA: 0x2CF8C0 Offset: 0x2CF9C1 VA: 0x2CF8C0
	// RVA: 0x2A401E0 Offset: 0x2A402E1 VA: 0x2A401E0
	public void AutoDetectReferences() { }

	[ContextMenu] // RVA: 0x2CF900 Offset: 0x2CFA01 VA: 0x2CF900
	// RVA: 0x2A40210 Offset: 0x2A40311 VA: 0x2A40210
	public void GuessHandOrientations() { }

	// RVA: 0x2A40230 Offset: 0x2A40331 VA: 0x2A40230 Slot: 7
	public override IKSolver GetIKSolver() { }

	// RVA: 0x2A40240 Offset: 0x2A40341 VA: 0x2A40240 Slot: 4
	protected override void InitiateSolver() { }

	// RVA: 0x2A402B0 Offset: 0x2A403B1 VA: 0x2A402B0 Slot: 5
	protected override void UpdateSolver() { }

	// RVA: 0x2A403C0 Offset: 0x2A404C1 VA: 0x2A403C0
	public void .ctor() { }
}

