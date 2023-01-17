// Namespace: RootMotion.FinalIK
[HelpURLAttribute] // RVA: 0x279960 Offset: 0x279A61 VA: 0x279960
[AddComponentMenu] // RVA: 0x279960 Offset: 0x279A61 VA: 0x279960
public class GrounderBipedIK : Grounder // TypeDefIndex: 14328
{
	// Fields
	[TooltipAttribute] // RVA: 0x29EE50 Offset: 0x29EF51 VA: 0x29EE50
	public BipedIK ik; // 0x40
	[TooltipAttribute] // RVA: 0x29EE90 Offset: 0x29EF91 VA: 0x29EE90
	public float spineBend; // 0x48
	[TooltipAttribute] // RVA: 0x29EED0 Offset: 0x29EFD1 VA: 0x29EED0
	public float spineSpeed; // 0x4C
	private Transform[] feet; // 0x50
	private Quaternion[] footRotations; // 0x58
	private Vector3 animatedPelvisLocalPosition; // 0x60
	private Vector3 solvedPelvisLocalPosition; // 0x6C
	private Vector3 spineOffset; // 0x78
	private float lastWeight; // 0x84

	// Methods

	[ContextMenu] // RVA: 0x2CE7C0 Offset: 0x2CE8C1 VA: 0x2CE7C0
	// RVA: 0x2DB0550 Offset: 0x2DB0651 VA: 0x2DB0550 Slot: 5
	protected override void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2CE800 Offset: 0x2CE901 VA: 0x2CE800
	// RVA: 0x2DB05A0 Offset: 0x2DB06A1 VA: 0x2DB05A0 Slot: 6
	protected override void OpenScriptReference() { }

	// RVA: 0x2DB05F0 Offset: 0x2DB06F1 VA: 0x2DB05F0 Slot: 4
	public override void ResetPosition() { }

	// RVA: 0x2DB0720 Offset: 0x2DB0821 VA: 0x2DB0720
	private bool IsReadyToInitiate() { }

	// RVA: 0x2DB07D0 Offset: 0x2DB08D1 VA: 0x2DB07D0
	private void Update() { }

	// RVA: 0x2DB08B0 Offset: 0x2DB09B1 VA: 0x2DB08B0
	private void Initiate() { }

	// RVA: 0x2DB0E60 Offset: 0x2DB0F61 VA: 0x2DB0E60
	private void OnDisable() { }

	// RVA: 0x2DB0E90 Offset: 0x2DB0F91 VA: 0x2DB0E90
	private void OnSolverUpdate() { }

	// RVA: 0x2DB14C0 Offset: 0x2DB15C1 VA: 0x2DB14C0
	private void SetLegIK(IKSolverLimb limb, int index) { }

	// RVA: 0x2DB1620 Offset: 0x2DB1721 VA: 0x2DB1620
	private void OnPostSolverUpdate() { }

	// RVA: 0x2DB1750 Offset: 0x2DB1851 VA: 0x2DB1750
	private void OnDestroy() { }

	// RVA: 0x2DB1900 Offset: 0x2DB1A01 VA: 0x2DB1900
	public void .ctor() { }
}

