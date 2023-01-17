// Namespace: RootMotion.FinalIK
[Serializable]
public class IKSolverLimb : IKSolverTrigonometric // TypeDefIndex: 14387
{
	// Fields
	public AvatarIKGoal goal; // 0xA8
	public IKSolverLimb.BendModifier bendModifier; // 0xAC
	[RangeAttribute] // RVA: 0x2A0C30 Offset: 0x2A0D31 VA: 0x2A0C30
	public float maintainRotationWeight; // 0xB0
	[RangeAttribute] // RVA: 0x2A0C50 Offset: 0x2A0D51 VA: 0x2A0C50
	public float bendModifierWeight; // 0xB4
	public Transform bendGoal; // 0xB8
	private bool maintainBendFor1Frame; // 0xC0
	private bool maintainRotationFor1Frame; // 0xC1
	private Quaternion defaultRootRotation; // 0xC4
	private Quaternion parentDefaultRotation; // 0xD4
	private Quaternion bone3RotationBeforeSolve; // 0xE4
	private Quaternion maintainRotation; // 0xF4
	private Quaternion bone3DefaultRotation; // 0x104
	private Vector3 _bendNormal; // 0x114
	private Vector3 animationNormal; // 0x120
	private IKSolverLimb.AxisDirection[] axisDirectionsLeft; // 0x130
	private IKSolverLimb.AxisDirection[] axisDirectionsRight; // 0x138

	// Properties
	private IKSolverLimb.AxisDirection[] axisDirections { get; }

	// Methods

	// RVA: 0x3C69590 Offset: 0x3C69691 VA: 0x3C69590
	public void MaintainRotation() { }

	// RVA: 0x3C695E0 Offset: 0x3C696E1 VA: 0x3C695E0
	public void MaintainBend() { }

	// RVA: 0x3C69630 Offset: 0x3C69731 VA: 0x3C69630 Slot: 12
	protected override void OnInitiateVirtual() { }

	// RVA: 0x3C69AD0 Offset: 0x3C69BD1 VA: 0x3C69AD0 Slot: 13
	protected override void OnUpdateVirtual() { }

	// RVA: 0x3C6A3C0 Offset: 0x3C6A4C1 VA: 0x3C6A3C0 Slot: 14
	protected override void OnPostSolveVirtual() { }

	// RVA: 0x3C6A460 Offset: 0x3C6A561 VA: 0x3C6A460
	public void .ctor() { }

	// RVA: 0x3C6A5F0 Offset: 0x3C6A6F1 VA: 0x3C6A5F0
	public void .ctor(AvatarIKGoal goal) { }

	// RVA: 0x3C6A690 Offset: 0x3C6A791 VA: 0x3C6A690
	private IKSolverLimb.AxisDirection[] get_axisDirections() { }

	// RVA: 0x3C698C0 Offset: 0x3C699C1 VA: 0x3C698C0
	private void StoreAxisDirections(ref IKSolverLimb.AxisDirection[] axisDirections) { }

	// RVA: 0x3C69BC0 Offset: 0x3C69CC1 VA: 0x3C69BC0
	private Vector3 GetModifiedBendNormal() { }
}

