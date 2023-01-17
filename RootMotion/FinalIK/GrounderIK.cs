// Namespace: RootMotion.FinalIK
[HelpURLAttribute] // RVA: 0x279A20 Offset: 0x279B21 VA: 0x279A20
[AddComponentMenu] // RVA: 0x279A20 Offset: 0x279B21 VA: 0x279A20
public class GrounderIK : Grounder // TypeDefIndex: 14331
{
	// Fields
	public IK[] legs; // 0x40
	[TooltipAttribute] // RVA: 0x29F090 Offset: 0x29F191 VA: 0x29F090
	public Transform pelvis; // 0x48
	[TooltipAttribute] // RVA: 0x29F0D0 Offset: 0x29F1D1 VA: 0x29F0D0
	public Transform characterRoot; // 0x50
	[RangeAttribute] // RVA: 0x29F110 Offset: 0x29F211 VA: 0x29F110
	[TooltipAttribute] // RVA: 0x29F110 Offset: 0x29F211 VA: 0x29F110
	public float rootRotationWeight; // 0x58
	[TooltipAttribute] // RVA: 0x29F170 Offset: 0x29F271 VA: 0x29F170
	public float rootRotationSpeed; // 0x5C
	[TooltipAttribute] // RVA: 0x29F1B0 Offset: 0x29F2B1 VA: 0x29F1B0
	public float maxRootRotationAngle; // 0x60
	private Transform[] feet; // 0x68
	private Quaternion[] footRotations; // 0x70
	private Vector3 animatedPelvisLocalPosition; // 0x78
	private Vector3 solvedPelvisLocalPosition; // 0x84
	private int solvedFeet; // 0x90
	private bool solved; // 0x94
	private float lastWeight; // 0x98
	private Rigidbody characterRootRigidbody; // 0xA0

	// Methods

	[ContextMenu] // RVA: 0x2CE900 Offset: 0x2CEA01 VA: 0x2CE900
	// RVA: 0x2DB27A0 Offset: 0x2DB28A1 VA: 0x2DB27A0 Slot: 5
	protected override void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2CE940 Offset: 0x2CEA41 VA: 0x2CE940
	// RVA: 0x2DB27F0 Offset: 0x2DB28F1 VA: 0x2DB27F0 Slot: 6
	protected override void OpenScriptReference() { }

	// RVA: 0x2DB2840 Offset: 0x2DB2941 VA: 0x2DB2840 Slot: 4
	public override void ResetPosition() { }

	// RVA: 0x2DB28D0 Offset: 0x2DB29D1 VA: 0x2DB28D0
	private bool IsReadyToInitiate() { }

	// RVA: 0x2DB2B00 Offset: 0x2DB2C01 VA: 0x2DB2B00
	private void OnDisable() { }

	// RVA: 0x2DB2C00 Offset: 0x2DB2D01 VA: 0x2DB2C00
	private void Update() { }

	// RVA: 0x2DB3190 Offset: 0x2DB3291 VA: 0x2DB3190
	private void Initiate() { }

	// RVA: 0x2DB35D0 Offset: 0x2DB36D1 VA: 0x2DB35D0
	private void OnSolverUpdate() { }

	// RVA: 0x2DB3740 Offset: 0x2DB3841 VA: 0x2DB3740
	private void SetLegIK(int index) { }

	// RVA: 0x2DB39B0 Offset: 0x2DB3AB1 VA: 0x2DB39B0
	private void OnPostSolverUpdate() { }

	// RVA: 0x2DB3AF0 Offset: 0x2DB3BF1 VA: 0x2DB3AF0
	private void OnDestroy() { }

	// RVA: 0x2DB3CF0 Offset: 0x2DB3DF1 VA: 0x2DB3CF0
	public void .ctor() { }
}

