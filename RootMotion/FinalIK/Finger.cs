// Namespace: RootMotion.FinalIK
[Serializable]
public class Finger // TypeDefIndex: 14324
{
	// Fields
	[TooltipAttribute] // RVA: 0x29EAA0 Offset: 0x29EBA1 VA: 0x29EAA0
	[RangeAttribute] // RVA: 0x29EAA0 Offset: 0x29EBA1 VA: 0x29EAA0
	public float weight; // 0x10
	[RangeAttribute] // RVA: 0x29EB00 Offset: 0x29EC01 VA: 0x29EB00
	[TooltipAttribute] // RVA: 0x29EB00 Offset: 0x29EC01 VA: 0x29EB00
	public float rotationWeight; // 0x14
	[TooltipAttribute] // RVA: 0x29EB60 Offset: 0x29EC61 VA: 0x29EB60
	public Finger.DOF rotationDOF; // 0x18
	[TooltipAttribute] // RVA: 0x29EBA0 Offset: 0x29ECA1 VA: 0x29EBA0
	public bool fixBone1Twist; // 0x1C
	[TooltipAttribute] // RVA: 0x29EBE0 Offset: 0x29ECE1 VA: 0x29EBE0
	public Transform bone1; // 0x20
	[TooltipAttribute] // RVA: 0x29EC20 Offset: 0x29ED21 VA: 0x29EC20
	public Transform bone2; // 0x28
	[TooltipAttribute] // RVA: 0x29EC60 Offset: 0x29ED61 VA: 0x29EC60
	public Transform bone3; // 0x30
	[TooltipAttribute] // RVA: 0x29ECA0 Offset: 0x29EDA1 VA: 0x29ECA0
	public Transform tip; // 0x38
	[TooltipAttribute] // RVA: 0x29ECE0 Offset: 0x29EDE1 VA: 0x29ECE0
	public Transform target; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x29ED20 Offset: 0x29EE21 VA: 0x29ED20
	private bool <initiated>k__BackingField; // 0x48
	private IKSolverLimb solver; // 0x50
	private Quaternion bone3RelativeToTarget; // 0x58
	private Vector3 bone3DefaultLocalPosition; // 0x68
	private Quaternion bone3DefaultLocalRotation; // 0x74
	private Vector3 bone1Axis; // 0x84
	private Vector3 tipAxis; // 0x90
	private Vector3 bone1TwistAxis; // 0x9C
	private Vector3 defaultBendNormal; // 0xA8

	// Properties
	public bool initiated { get; set; }
	public Vector3 IKPosition { get; set; }
	public Quaternion IKRotation { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CE720 Offset: 0x2CE821 VA: 0x2CE720
	// RVA: 0x2A21F80 Offset: 0x2A22081 VA: 0x2A21F80
	public bool get_initiated() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE730 Offset: 0x2CE831 VA: 0x2CE730
	// RVA: 0x2A21F90 Offset: 0x2A22091 VA: 0x2A21F90
	private void set_initiated(bool value) { }

	// RVA: 0x2A21FA0 Offset: 0x2A220A1 VA: 0x2A21FA0
	public Vector3 get_IKPosition() { }

	// RVA: 0x2A21FB0 Offset: 0x2A220B1 VA: 0x2A21FB0
	public void set_IKPosition(Vector3 value) { }

	// RVA: 0x2A21FD0 Offset: 0x2A220D1 VA: 0x2A21FD0
	public Quaternion get_IKRotation() { }

	// RVA: 0x2A21FE0 Offset: 0x2A220E1 VA: 0x2A21FE0
	public void set_IKRotation(Quaternion value) { }

	// RVA: 0x2A22000 Offset: 0x2A22101 VA: 0x2A22000
	public bool IsValid(ref string errorMessage) { }

	// RVA: 0x2A22120 Offset: 0x2A22221 VA: 0x2A22120
	public void Initiate(Transform hand, int index) { }

	// RVA: 0x2A22620 Offset: 0x2A22721 VA: 0x2A22620
	public void FixTransforms() { }

	// RVA: 0x2A226F0 Offset: 0x2A227F1 VA: 0x2A226F0
	public void StoreDefaultLocalState() { }

	// RVA: 0x2A227C0 Offset: 0x2A228C1 VA: 0x2A227C0
	public void Update(float masterWeight) { }

	// RVA: 0x2A22C00 Offset: 0x2A22D01 VA: 0x2A22C00
	public void .ctor() { }
}

