// Namespace: RootMotion.FinalIK
[Serializable]
public class IKSolverTrigonometric : IKSolver // TypeDefIndex: 14391
{
	// Fields
	public Transform target; // 0x58
	[RangeAttribute] // RVA: 0x2A0D50 Offset: 0x2A0E51 VA: 0x2A0D50
	public float IKRotationWeight; // 0x60
	public Quaternion IKRotation; // 0x64
	public Vector3 bendNormal; // 0x74
	public IKSolverTrigonometric.TrigonometricBone bone1; // 0x80
	public IKSolverTrigonometric.TrigonometricBone bone2; // 0x88
	public IKSolverTrigonometric.TrigonometricBone bone3; // 0x90
	protected Vector3 weightIKPosition; // 0x98
	protected bool directHierarchy; // 0xA4

	// Methods

	// RVA: 0x3C6C7E0 Offset: 0x3C6C8E1 VA: 0x3C6C7E0
	public void SetBendGoalPosition(Vector3 goalPosition, float weight) { }

	// RVA: 0x3C6C930 Offset: 0x3C6CA31 VA: 0x3C6C930
	public void SetBendPlaneToCurrent() { }

	// RVA: 0x3C6CA40 Offset: 0x3C6CB41 VA: 0x3C6CA40
	public void SetIKRotation(Quaternion rotation) { }

	// RVA: 0x3C6CA60 Offset: 0x3C6CB61 VA: 0x3C6CA60
	public void SetIKRotationWeight(float weight) { }

	// RVA: 0x3C6CA90 Offset: 0x3C6CB91 VA: 0x3C6CA90
	public Quaternion GetIKRotation() { }

	// RVA: 0x3C6CAA0 Offset: 0x3C6CBA1 VA: 0x3C6CAA0
	public float GetIKRotationWeight() { }

	// RVA: 0x3C6CAB0 Offset: 0x3C6CBB1 VA: 0x3C6CAB0 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x3C6CBD0 Offset: 0x3C6CCD1 VA: 0x3C6CBD0 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x3C6CCE0 Offset: 0x3C6CDE1 VA: 0x3C6CCE0 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x3C6CD20 Offset: 0x3C6CE21 VA: 0x3C6CD20 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x3C6CD70 Offset: 0x3C6CE71 VA: 0x3C6CD70 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x3C6D130 Offset: 0x3C6D231 VA: 0x3C6D130
	public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root) { }

	// RVA: 0x3C6D1A0 Offset: 0x3C6D2A1 VA: 0x3C6D1A0
	public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight) { }

	// RVA: 0x3C6D550 Offset: 0x3C6D651 VA: 0x3C6D550
	private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2) { }

	// RVA: 0x3C6D6D0 Offset: 0x3C6D7D1 VA: 0x3C6D6D0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x3C6D850 Offset: 0x3C6D951 VA: 0x3C6D850
	private bool IsDirectHierarchy() { }

	// RVA: 0x3C6D7E0 Offset: 0x3C6D8E1 VA: 0x3C6D7E0
	private void InitiateBones() { }

	// RVA: 0x3C6D950 Offset: 0x3C6DA51 VA: 0x3C6D950 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x3C6E060 Offset: 0x3C6E161 VA: 0x3C6E060 Slot: 12
	protected virtual void OnInitiateVirtual() { }

	// RVA: 0x3C6E070 Offset: 0x3C6E171 VA: 0x3C6E070 Slot: 13
	protected virtual void OnUpdateVirtual() { }

	// RVA: 0x3C6E080 Offset: 0x3C6E181 VA: 0x3C6E080 Slot: 14
	protected virtual void OnPostSolveVirtual() { }

	// RVA: 0x3C6DE90 Offset: 0x3C6DF91 VA: 0x3C6DE90
	protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal) { }

	// RVA: 0x3C6A4F0 Offset: 0x3C6A5F1 VA: 0x3C6A4F0
	public void .ctor() { }
}

