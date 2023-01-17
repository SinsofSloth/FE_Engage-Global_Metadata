// Namespace: RootMotion.FinalIK
[Serializable]
public class IKSolverLookAt : IKSolver // TypeDefIndex: 14389
{
	// Fields
	public Transform target; // 0x58
	public IKSolverLookAt.LookAtBone[] spine; // 0x60
	public IKSolverLookAt.LookAtBone head; // 0x68
	public IKSolverLookAt.LookAtBone[] eyes; // 0x70
	[RangeAttribute] // RVA: 0x2A0C70 Offset: 0x2A0D71 VA: 0x2A0C70
	public float bodyWeight; // 0x78
	[RangeAttribute] // RVA: 0x2A0C90 Offset: 0x2A0D91 VA: 0x2A0C90
	public float headWeight; // 0x7C
	[RangeAttribute] // RVA: 0x2A0CB0 Offset: 0x2A0DB1 VA: 0x2A0CB0
	public float eyesWeight; // 0x80
	[RangeAttribute] // RVA: 0x2A0CD0 Offset: 0x2A0DD1 VA: 0x2A0CD0
	public float clampWeight; // 0x84
	[RangeAttribute] // RVA: 0x2A0CF0 Offset: 0x2A0DF1 VA: 0x2A0CF0
	public float clampWeightHead; // 0x88
	[RangeAttribute] // RVA: 0x2A0D10 Offset: 0x2A0E11 VA: 0x2A0D10
	public float clampWeightEyes; // 0x8C
	[RangeAttribute] // RVA: 0x2A0D30 Offset: 0x2A0E31 VA: 0x2A0D30
	public int clampSmoothing; // 0x90
	public AnimationCurve spineWeightCurve; // 0x98
	public Vector3 spineTargetOffset; // 0xA0
	protected Vector3[] spineForwards; // 0xB0
	protected Vector3[] headForwards; // 0xB8
	protected Vector3[] eyeForward; // 0xC0
	private bool isDirty; // 0xC8

	// Properties
	protected bool spineIsValid { get; }
	protected bool spineIsEmpty { get; }
	protected bool headIsValid { get; }
	protected bool headIsEmpty { get; }
	protected bool eyesIsValid { get; }
	protected bool eyesIsEmpty { get; }

	// Methods

	// RVA: 0x3C6A6B0 Offset: 0x3C6A7B1 VA: 0x3C6A6B0
	public void SetLookAtWeight(float weight) { }

	// RVA: 0x3C6A6E0 Offset: 0x3C6A7E1 VA: 0x3C6A6E0
	public void SetLookAtWeight(float weight, float bodyWeight) { }

	// RVA: 0x3C6A750 Offset: 0x3C6A851 VA: 0x3C6A750
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight) { }

	// RVA: 0x3C6A7D0 Offset: 0x3C6A8D1 VA: 0x3C6A7D0
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight) { }

	// RVA: 0x3C6A880 Offset: 0x3C6A981 VA: 0x3C6A880
	public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight) { }

	// RVA: 0x3C6A950 Offset: 0x3C6AA51 VA: 0x3C6A950
	public void SetLookAtWeight(float weight, float bodyWeight = 0, float headWeight = 1, float eyesWeight = 0.5, float clampWeight = 0.5, float clampWeightHead = 0.5, float clampWeightEyes = 0.3) { }

	// RVA: 0x3C6AA50 Offset: 0x3C6AB51 VA: 0x3C6AA50 Slot: 9
	public override void StoreDefaultLocalState() { }

	// RVA: 0x3C6AB80 Offset: 0x3C6AC81 VA: 0x3C6AB80
	public void SetDirty() { }

	// RVA: 0x3C6AB90 Offset: 0x3C6AC91 VA: 0x3C6AB90 Slot: 8
	public override void FixTransforms() { }

	// RVA: 0x3C6ACD0 Offset: 0x3C6ADD1 VA: 0x3C6ACD0 Slot: 4
	public override bool IsValid(ref string message) { }

	// RVA: 0x3C6B190 Offset: 0x3C6B291 VA: 0x3C6B190 Slot: 6
	public override IKSolver.Point[] GetPoints() { }

	// RVA: 0x3C6B400 Offset: 0x3C6B501 VA: 0x3C6B400 Slot: 7
	public override IKSolver.Point GetPoint(Transform transform) { }

	// RVA: 0x3C6B580 Offset: 0x3C6B681 VA: 0x3C6B580
	public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root) { }

	// RVA: 0x3C6B7F0 Offset: 0x3C6B8F1 VA: 0x3C6B7F0 Slot: 10
	protected override void OnInitiate() { }

	// RVA: 0x3C6BAC0 Offset: 0x3C6BBC1 VA: 0x3C6BAC0 Slot: 11
	protected override void OnUpdate() { }

	// RVA: 0x3C6AEE0 Offset: 0x3C6AFE1 VA: 0x3C6AEE0
	protected bool get_spineIsValid() { }

	// RVA: 0x3C6B0D0 Offset: 0x3C6B1D1 VA: 0x3C6B0D0
	protected bool get_spineIsEmpty() { }

	// RVA: 0x3C6BB90 Offset: 0x3C6BC91 VA: 0x3C6BB90
	protected void SolveSpine() { }

	// RVA: 0x3C6AFD0 Offset: 0x3C6B0D1 VA: 0x3C6AFD0
	protected bool get_headIsValid() { }

	// RVA: 0x3C6B0F0 Offset: 0x3C6B1F1 VA: 0x3C6B0F0
	protected bool get_headIsEmpty() { }

	// RVA: 0x3C6BD10 Offset: 0x3C6BE11 VA: 0x3C6BD10
	protected void SolveHead() { }

	// RVA: 0x3C6AFE0 Offset: 0x3C6B0E1 VA: 0x3C6AFE0
	protected bool get_eyesIsValid() { }

	// RVA: 0x3C6B170 Offset: 0x3C6B271 VA: 0x3C6B170
	protected bool get_eyesIsEmpty() { }

	// RVA: 0x3C6BF60 Offset: 0x3C6C061 VA: 0x3C6BF60
	protected void SolveEyes() { }

	// RVA: 0x3C6C2D0 Offset: 0x3C6C3D1 VA: 0x3C6C2D0
	protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp) { }

	// RVA: 0x3C6B640 Offset: 0x3C6B741 VA: 0x3C6B640
	protected void SetBones(Transform[] array, ref IKSolverLookAt.LookAtBone[] bones) { }

	// RVA: 0x3C6C540 Offset: 0x3C6C641 VA: 0x3C6C540
	public void .ctor() { }
}

