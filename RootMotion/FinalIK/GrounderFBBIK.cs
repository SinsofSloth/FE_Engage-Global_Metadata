// Namespace: RootMotion.FinalIK
[HelpURLAttribute] // RVA: 0x2799C0 Offset: 0x279AC1 VA: 0x2799C0
[AddComponentMenu] // RVA: 0x2799C0 Offset: 0x279AC1 VA: 0x2799C0
public class GrounderFBBIK : Grounder // TypeDefIndex: 14330
{
	// Fields
	[TooltipAttribute] // RVA: 0x29EF10 Offset: 0x29F011 VA: 0x29EF10
	public FullBodyBipedIK ik; // 0x40
	[TooltipAttribute] // RVA: 0x29EF50 Offset: 0x29F051 VA: 0x29EF50
	public float spineBend; // 0x48
	[TooltipAttribute] // RVA: 0x29EF90 Offset: 0x29F091 VA: 0x29EF90
	public float spineSpeed; // 0x4C
	public GrounderFBBIK.SpineEffector[] spine; // 0x50
	private Transform[] feet; // 0x58
	private Vector3 spineOffset; // 0x60
	private bool firstSolve; // 0x6C

	// Methods

	[ContextMenu] // RVA: 0x2CE840 Offset: 0x2CE941 VA: 0x2CE840
	// RVA: 0x2DB1BD0 Offset: 0x2DB1CD1 VA: 0x2DB1BD0
	private void OpenTutorial() { }

	[ContextMenu] // RVA: 0x2CE880 Offset: 0x2CE981 VA: 0x2CE880
	// RVA: 0x2DB1C20 Offset: 0x2DB1D21 VA: 0x2DB1C20 Slot: 5
	protected override void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2CE8C0 Offset: 0x2CE9C1 VA: 0x2CE8C0
	// RVA: 0x2DB1C70 Offset: 0x2DB1D71 VA: 0x2DB1C70 Slot: 6
	protected override void OpenScriptReference() { }

	// RVA: 0x2DB1CC0 Offset: 0x2DB1DC1 VA: 0x2DB1CC0 Slot: 4
	public override void ResetPosition() { }

	// RVA: 0x2DB1D60 Offset: 0x2DB1E61 VA: 0x2DB1D60
	private bool IsReadyToInitiate() { }

	// RVA: 0x2DB1E00 Offset: 0x2DB1F01 VA: 0x2DB1E00
	private void Update() { }

	// RVA: 0x2DB20D0 Offset: 0x2DB21D1 VA: 0x2DB20D0
	private void FixedUpdate() { }

	// RVA: 0x2DB20E0 Offset: 0x2DB21E1 VA: 0x2DB20E0
	private void LateUpdate() { }

	// RVA: 0x2DB1ED0 Offset: 0x2DB1FD1 VA: 0x2DB1ED0
	private void Initiate() { }

	// RVA: 0x2DB20F0 Offset: 0x2DB21F1 VA: 0x2DB20F0
	private void OnSolverUpdate() { }

	// RVA: 0x2DB23E0 Offset: 0x2DB24E1 VA: 0x2DB23E0
	private void SetLegIK(IKEffector effector, Grounding.Leg leg) { }

	// RVA: 0x2DB24F0 Offset: 0x2DB25F1 VA: 0x2DB24F0
	private void OnDrawGizmosSelected() { }

	// RVA: 0x2DB2670 Offset: 0x2DB2771 VA: 0x2DB2670
	private void OnDestroy() { }

	// RVA: 0x2DB1A70 Offset: 0x2DB1B71 VA: 0x2DB1A70
	public void .ctor() { }
}

