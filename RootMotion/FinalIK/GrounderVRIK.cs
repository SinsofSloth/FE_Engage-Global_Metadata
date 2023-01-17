// Namespace: RootMotion.FinalIK
[HelpURLAttribute] // RVA: 0x279AE0 Offset: 0x279BE1 VA: 0x279AE0
[AddComponentMenu] // RVA: 0x279AE0 Offset: 0x279BE1 VA: 0x279AE0
public class GrounderVRIK : Grounder // TypeDefIndex: 14334
{
	// Fields
	[TooltipAttribute] // RVA: 0x29F580 Offset: 0x29F681 VA: 0x29F580
	public VRIK ik; // 0x40
	private Transform[] feet; // 0x48

	// Methods

	[ContextMenu] // RVA: 0x2CEA00 Offset: 0x2CEB01 VA: 0x2CEA00
	// RVA: 0x2DB5DF0 Offset: 0x2DB5EF1 VA: 0x2DB5DF0
	private void OpenTutorial() { }

	[ContextMenu] // RVA: 0x2CEA40 Offset: 0x2CEB41 VA: 0x2CEA40
	// RVA: 0x2DB5E40 Offset: 0x2DB5F41 VA: 0x2DB5E40 Slot: 5
	protected override void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2CEA80 Offset: 0x2CEB81 VA: 0x2CEA80
	// RVA: 0x2DB5E90 Offset: 0x2DB5F91 VA: 0x2DB5E90 Slot: 6
	protected override void OpenScriptReference() { }

	// RVA: 0x2DB5EE0 Offset: 0x2DB5FE1 VA: 0x2DB5EE0 Slot: 4
	public override void ResetPosition() { }

	// RVA: 0x2DB5F70 Offset: 0x2DB6071 VA: 0x2DB5F70
	private bool IsReadyToInitiate() { }

	// RVA: 0x2DB6010 Offset: 0x2DB6111 VA: 0x2DB6010
	private void Update() { }

	// RVA: 0x2DB60E0 Offset: 0x2DB61E1 VA: 0x2DB60E0
	private void Initiate() { }

	// RVA: 0x2DB6310 Offset: 0x2DB6411 VA: 0x2DB6310
	private void OnSolverUpdate() { }

	// RVA: 0x2DB64B0 Offset: 0x2DB65B1 VA: 0x2DB64B0
	private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg) { }

	// RVA: 0x2DB6530 Offset: 0x2DB6631 VA: 0x2DB6530
	private void OnPostSolverUpdate() { }

	// RVA: 0x2DB66A0 Offset: 0x2DB67A1 VA: 0x2DB66A0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x2DB6820 Offset: 0x2DB6921 VA: 0x2DB6820
	private void OnDestroy() { }

	// RVA: 0x2DB69C0 Offset: 0x2DB6AC1 VA: 0x2DB69C0
	public void .ctor() { }
}

