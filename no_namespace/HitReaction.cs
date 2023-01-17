// Namespace: 
[Serializable]
public abstract class HitReaction.HitPoint // TypeDefIndex: 14451
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A46A0 Offset: 0x2A47A1 VA: 0x2A46A0
	public string name; // 0x10
	[TooltipAttribute] // RVA: 0x2A46E0 Offset: 0x2A47E1 VA: 0x2A46E0
	public Collider collider; // 0x18
	[TooltipAttribute] // RVA: 0x2A4720 Offset: 0x2A4821 VA: 0x2A4720
	[SerializeField] // RVA: 0x2A4720 Offset: 0x2A4821 VA: 0x2A4720
	private float crossFadeTime; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x2A4770 Offset: 0x2A4871 VA: 0x2A4770
	private float <crossFader>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x2A4780 Offset: 0x2A4881 VA: 0x2A4780
	private float <timer>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x2A4790 Offset: 0x2A4891 VA: 0x2A4790
	private Vector3 <force>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x2A47A0 Offset: 0x2A48A1 VA: 0x2A47A0
	private Vector3 <point>k__BackingField; // 0x38
	private float length; // 0x44
	private float crossFadeSpeed; // 0x48
	private float lastTime; // 0x4C

	// Properties
	public bool inProgress { get; }
	protected float crossFader { get; set; }
	protected float timer { get; set; }
	protected Vector3 force { get; set; }
	protected Vector3 point { get; set; }

	// Methods

	// RVA: 0x1FAAC60 Offset: 0x1FAAD61 VA: 0x1FAAC60
	public bool get_inProgress() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D09C0 Offset: 0x2D0AC1 VA: 0x2D09C0
	// RVA: 0x1FAAC80 Offset: 0x1FAAD81 VA: 0x1FAAC80
	protected float get_crossFader() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D09D0 Offset: 0x2D0AD1 VA: 0x2D09D0
	// RVA: 0x1FAAC90 Offset: 0x1FAAD91 VA: 0x1FAAC90
	private void set_crossFader(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2D09E0 Offset: 0x2D0AE1 VA: 0x2D09E0
	// RVA: 0x1FAACA0 Offset: 0x1FAADA1 VA: 0x1FAACA0
	protected float get_timer() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D09F0 Offset: 0x2D0AF1 VA: 0x2D09F0
	// RVA: 0x1FAACB0 Offset: 0x1FAADB1 VA: 0x1FAACB0
	private void set_timer(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0A00 Offset: 0x2D0B01 VA: 0x2D0A00
	// RVA: 0x1FAACC0 Offset: 0x1FAADC1 VA: 0x1FAACC0
	protected Vector3 get_force() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0A10 Offset: 0x2D0B11 VA: 0x2D0A10
	// RVA: 0x1FAACD0 Offset: 0x1FAADD1 VA: 0x1FAACD0
	private void set_force(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0A20 Offset: 0x2D0B21 VA: 0x2D0A20
	// RVA: 0x1FAACE0 Offset: 0x1FAADE1 VA: 0x1FAACE0
	protected Vector3 get_point() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0A30 Offset: 0x2D0B31 VA: 0x2D0A30
	// RVA: 0x1FAACF0 Offset: 0x1FAADF1 VA: 0x1FAACF0
	private void set_point(Vector3 value) { }

	// RVA: 0x1FAAD00 Offset: 0x1FAAE01 VA: 0x1FAAD00
	public void Hit(Vector3 force, Vector3 point) { }

	// RVA: 0x1FAADD0 Offset: 0x1FAAED1 VA: 0x1FAADD0
	public void Apply(IKSolverFullBodyBiped solver, float weight) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract float GetLength();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void CrossFadeStart();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

	// RVA: 0x1FAAEB0 Offset: 0x1FAAFB1 VA: 0x1FAAEB0
	protected void .ctor() { }
}

// Namespace: 
[Serializable]
public class HitReaction.HitPointEffector.EffectorLink // TypeDefIndex: 14452
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4870 Offset: 0x2A4971 VA: 0x2A4870
	public FullBodyBipedEffector effector; // 0x10
	[TooltipAttribute] // RVA: 0x2A48B0 Offset: 0x2A49B1 VA: 0x2A48B0
	public float weight; // 0x14
	private Vector3 lastValue; // 0x18
	private Vector3 current; // 0x24

	// Methods

	// RVA: 0x1DCE240 Offset: 0x1DCE341 VA: 0x1DCE240
	public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader) { }

	// RVA: 0x1DCE300 Offset: 0x1DCE401 VA: 0x1DCE300
	public void CrossFadeStart() { }

	// RVA: 0x1DCE320 Offset: 0x1DCE421 VA: 0x1DCE320
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class HitReaction.HitPointEffector : HitReaction.HitPoint // TypeDefIndex: 14453
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A47B0 Offset: 0x2A48B1 VA: 0x2A47B0
	public AnimationCurve offsetInForceDirection; // 0x50
	[TooltipAttribute] // RVA: 0x2A47F0 Offset: 0x2A48F1 VA: 0x2A47F0
	public AnimationCurve offsetInUpDirection; // 0x58
	[TooltipAttribute] // RVA: 0x2A4830 Offset: 0x2A4931 VA: 0x2A4830
	public HitReaction.HitPointEffector.EffectorLink[] effectorLinks; // 0x60

	// Methods

	// RVA: 0x1FAB1E0 Offset: 0x1FAB2E1 VA: 0x1FAB1E0 Slot: 4
	protected override float GetLength() { }

	// RVA: 0x1FAB2E0 Offset: 0x1FAB3E1 VA: 0x1FAB2E0 Slot: 5
	protected override void CrossFadeStart() { }

	// RVA: 0x1FAB350 Offset: 0x1FAB451 VA: 0x1FAB350 Slot: 6
	protected override void OnApply(IKSolverFullBodyBiped solver, float weight) { }

	// RVA: 0x1FAB4B0 Offset: 0x1FAB5B1 VA: 0x1FAB4B0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class HitReaction.HitPointBone.BoneLink // TypeDefIndex: 14454
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4970 Offset: 0x2A4A71 VA: 0x2A4970
	public Transform bone; // 0x10
	[TooltipAttribute] // RVA: 0x2A49B0 Offset: 0x2A4AB1 VA: 0x2A49B0
	[RangeAttribute] // RVA: 0x2A49B0 Offset: 0x2A4AB1 VA: 0x2A49B0
	public float weight; // 0x18
	private Quaternion lastValue; // 0x1C
	private Quaternion current; // 0x2C

	// Methods

	// RVA: 0x1DCE0B0 Offset: 0x1DCE1B1 VA: 0x1DCE0B0
	public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader) { }

	// RVA: 0x1DCE1C0 Offset: 0x1DCE2C1 VA: 0x1DCE1C0
	public void CrossFadeStart() { }

	// RVA: 0x1DCE1E0 Offset: 0x1DCE2E1 VA: 0x1DCE1E0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class HitReaction.HitPointBone : HitReaction.HitPoint // TypeDefIndex: 14455
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A48F0 Offset: 0x2A49F1 VA: 0x2A48F0
	public AnimationCurve aroundCenterOfMass; // 0x50
	[TooltipAttribute] // RVA: 0x2A4930 Offset: 0x2A4A31 VA: 0x2A4930
	public HitReaction.HitPointBone.BoneLink[] boneLinks; // 0x58
	private Rigidbody rigidbody; // 0x60

	// Methods

	// RVA: 0x1FAAED0 Offset: 0x1FAAFD1 VA: 0x1FAAED0 Slot: 4
	protected override float GetLength() { }

	// RVA: 0x1FAAF60 Offset: 0x1FAB061 VA: 0x1FAAF60 Slot: 5
	protected override void CrossFadeStart() { }

	// RVA: 0x1FAAFD0 Offset: 0x1FAB0D1 VA: 0x1FAAFD0 Slot: 6
	protected override void OnApply(IKSolverFullBodyBiped solver, float weight) { }

	// RVA: 0x1FAB1C0 Offset: 0x1FAB2C1 VA: 0x1FAB1C0
	public void .ctor() { }
}

