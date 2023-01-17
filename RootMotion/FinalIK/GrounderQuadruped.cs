// Namespace: RootMotion.FinalIK
[AddComponentMenu] // RVA: 0x279A80 Offset: 0x279B81 VA: 0x279A80
[HelpURLAttribute] // RVA: 0x279A80 Offset: 0x279B81 VA: 0x279A80
public class GrounderQuadruped : Grounder // TypeDefIndex: 14333
{
	// Fields
	[TooltipAttribute] // RVA: 0x29F1F0 Offset: 0x29F2F1 VA: 0x29F1F0
	public Grounding forelegSolver; // 0x40
	[RangeAttribute] // RVA: 0x29F230 Offset: 0x29F331 VA: 0x29F230
	[TooltipAttribute] // RVA: 0x29F230 Offset: 0x29F331 VA: 0x29F230
	public float rootRotationWeight; // 0x48
	[TooltipAttribute] // RVA: 0x29F290 Offset: 0x29F391 VA: 0x29F290
	[RangeAttribute] // RVA: 0x29F290 Offset: 0x29F391 VA: 0x29F290
	public float minRootRotation; // 0x4C
	[TooltipAttribute] // RVA: 0x29F2F0 Offset: 0x29F3F1 VA: 0x29F2F0
	[RangeAttribute] // RVA: 0x29F2F0 Offset: 0x29F3F1 VA: 0x29F2F0
	public float maxRootRotation; // 0x50
	[TooltipAttribute] // RVA: 0x29F350 Offset: 0x29F451 VA: 0x29F350
	public float rootRotationSpeed; // 0x54
	[TooltipAttribute] // RVA: 0x29F390 Offset: 0x29F491 VA: 0x29F390
	public float maxLegOffset; // 0x58
	[TooltipAttribute] // RVA: 0x29F3D0 Offset: 0x29F4D1 VA: 0x29F3D0
	public float maxForeLegOffset; // 0x5C
	[RangeAttribute] // RVA: 0x29F410 Offset: 0x29F511 VA: 0x29F410
	[TooltipAttribute] // RVA: 0x29F410 Offset: 0x29F511 VA: 0x29F410
	public float maintainHeadRotationWeight; // 0x60
	[TooltipAttribute] // RVA: 0x29F470 Offset: 0x29F571 VA: 0x29F470
	public Transform characterRoot; // 0x68
	[TooltipAttribute] // RVA: 0x29F4B0 Offset: 0x29F5B1 VA: 0x29F4B0
	public Transform pelvis; // 0x70
	[TooltipAttribute] // RVA: 0x29F4F0 Offset: 0x29F5F1 VA: 0x29F4F0
	public Transform lastSpineBone; // 0x78
	[TooltipAttribute] // RVA: 0x29F530 Offset: 0x29F631 VA: 0x29F530
	public Transform head; // 0x80
	public IK[] legs; // 0x88
	public IK[] forelegs; // 0x90
	[HideInInspector] // RVA: 0x29F570 Offset: 0x29F671 VA: 0x29F570
	public Vector3 gravity; // 0x98
	private GrounderQuadruped.Foot[] feet; // 0xA8
	private Vector3 animatedPelvisLocalPosition; // 0xB0
	private Quaternion animatedPelvisLocalRotation; // 0xBC
	private Quaternion animatedHeadLocalRotation; // 0xCC
	private Vector3 solvedPelvisLocalPosition; // 0xDC
	private Quaternion solvedPelvisLocalRotation; // 0xE8
	private Quaternion solvedHeadLocalRotation; // 0xF8
	private int solvedFeet; // 0x108
	private bool solved; // 0x10C
	private float angle; // 0x110
	private Transform forefeetRoot; // 0x118
	private Quaternion headRotation; // 0x120
	private float lastWeight; // 0x130
	private Rigidbody characterRootRigidbody; // 0x138

	// Methods

	[ContextMenu] // RVA: 0x2CE980 Offset: 0x2CEA81 VA: 0x2CE980
	// RVA: 0x2DB4030 Offset: 0x2DB4131 VA: 0x2DB4030 Slot: 5
	protected override void OpenUserManual() { }

	[ContextMenu] // RVA: 0x2CE9C0 Offset: 0x2CEAC1 VA: 0x2CE9C0
	// RVA: 0x2DB4080 Offset: 0x2DB4181 VA: 0x2DB4080 Slot: 6
	protected override void OpenScriptReference() { }

	// RVA: 0x2DB40D0 Offset: 0x2DB41D1 VA: 0x2DB40D0 Slot: 4
	public override void ResetPosition() { }

	// RVA: 0x2DB41C0 Offset: 0x2DB42C1 VA: 0x2DB41C0
	private bool IsReadyToInitiate() { }

	// RVA: 0x2DB42E0 Offset: 0x2DB43E1 VA: 0x2DB42E0
	private bool IsReadyToInitiateLegs(IK[] ikComponents) { }

	// RVA: 0x2DB44E0 Offset: 0x2DB45E1 VA: 0x2DB44E0
	private void OnDisable() { }

	// RVA: 0x2DB4560 Offset: 0x2DB4661 VA: 0x2DB4560
	private void Update() { }

	// RVA: 0x2DB45D0 Offset: 0x2DB46D1 VA: 0x2DB45D0
	private void Initiate() { }

	// RVA: 0x2DB48D0 Offset: 0x2DB49D1 VA: 0x2DB48D0
	private Transform[] InitiateFeet(IK[] ikComponents, ref GrounderQuadruped.Foot[] f, int indexOffset) { }

	// RVA: 0x2DB4C40 Offset: 0x2DB4D41 VA: 0x2DB4C40
	private void LateUpdate() { }

	// RVA: 0x2DB4D40 Offset: 0x2DB4E41 VA: 0x2DB4D40
	private void RootRotation() { }

	// RVA: 0x2DB5100 Offset: 0x2DB5201 VA: 0x2DB5100
	private void OnSolverUpdate() { }

	// RVA: 0x2DB5700 Offset: 0x2DB5801 VA: 0x2DB5700
	private void UpdateForefeetRoot() { }

	// RVA: 0x2DB58C0 Offset: 0x2DB59C1 VA: 0x2DB58C0
	private void SetFootIK(GrounderQuadruped.Foot foot, float maxOffset) { }

	// RVA: 0x2DB5990 Offset: 0x2DB5A91 VA: 0x2DB5990
	private void OnPostSolverUpdate() { }

	// RVA: 0x2DB5BB0 Offset: 0x2DB5CB1 VA: 0x2DB5BB0
	private void OnDestroy() { }

	// RVA: 0x2DB5BF0 Offset: 0x2DB5CF1 VA: 0x2DB5BF0
	private void DestroyLegs(IK[] ikComponents) { }

	// RVA: 0x2DB3E60 Offset: 0x2DB3F61 VA: 0x2DB3E60
	public void .ctor() { }
}

