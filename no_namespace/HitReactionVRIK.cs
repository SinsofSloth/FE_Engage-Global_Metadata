// Namespace: 
[Serializable]
public abstract class HitReactionVRIK.Offset // TypeDefIndex: 14457
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4A90 Offset: 0x2A4B91 VA: 0x2A4A90
	public string name; // 0x10
	[TooltipAttribute] // RVA: 0x2A4AD0 Offset: 0x2A4BD1 VA: 0x2A4AD0
	public Collider collider; // 0x18
	[TooltipAttribute] // RVA: 0x2A4B10 Offset: 0x2A4C11 VA: 0x2A4B10
	[SerializeField] // RVA: 0x2A4B10 Offset: 0x2A4C11 VA: 0x2A4B10
	private float crossFadeTime; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x2A4B60 Offset: 0x2A4C61 VA: 0x2A4B60
	private float <crossFader>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x2A4B70 Offset: 0x2A4C71 VA: 0x2A4B70
	private float <timer>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x2A4B80 Offset: 0x2A4C81 VA: 0x2A4B80
	private Vector3 <force>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x2A4B90 Offset: 0x2A4C91 VA: 0x2A4B90
	private Vector3 <point>k__BackingField; // 0x38
	private float length; // 0x44
	private float crossFadeSpeed; // 0x48
	private float lastTime; // 0x4C

	// Properties
	protected float crossFader { get; set; }
	protected float timer { get; set; }
	protected Vector3 force { get; set; }
	protected Vector3 point { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2D0A40 Offset: 0x2D0B41 VA: 0x2D0A40
	// RVA: 0x1FAB4D0 Offset: 0x1FAB5D1 VA: 0x1FAB4D0
	protected float get_crossFader() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0A50 Offset: 0x2D0B51 VA: 0x2D0A50
	// RVA: 0x1FAB4E0 Offset: 0x1FAB5E1 VA: 0x1FAB4E0
	private void set_crossFader(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0A60 Offset: 0x2D0B61 VA: 0x2D0A60
	// RVA: 0x1FAB4F0 Offset: 0x1FAB5F1 VA: 0x1FAB4F0
	protected float get_timer() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0A70 Offset: 0x2D0B71 VA: 0x2D0A70
	// RVA: 0x1FAB500 Offset: 0x1FAB601 VA: 0x1FAB500
	private void set_timer(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0A80 Offset: 0x2D0B81 VA: 0x2D0A80
	// RVA: 0x1FAB510 Offset: 0x1FAB611 VA: 0x1FAB510
	protected Vector3 get_force() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0A90 Offset: 0x2D0B91 VA: 0x2D0A90
	// RVA: 0x1FAB520 Offset: 0x1FAB621 VA: 0x1FAB520
	private void set_force(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0AA0 Offset: 0x2D0BA1 VA: 0x2D0AA0
	// RVA: 0x1FAB530 Offset: 0x1FAB631 VA: 0x1FAB530
	protected Vector3 get_point() { }

	[CompilerGeneratedAttribute] // RVA: 0x2D0AB0 Offset: 0x2D0BB1 VA: 0x2D0AB0
	// RVA: 0x1FAB540 Offset: 0x1FAB641 VA: 0x1FAB540
	private void set_point(Vector3 value) { }

	// RVA: 0x1FAB550 Offset: 0x1FAB651 VA: 0x1FAB550
	public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point) { }

	// RVA: 0x1FAB620 Offset: 0x1FAB721 VA: 0x1FAB620
	public void Apply(VRIK ik, AnimationCurve[] curves, float weight) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract float GetLength(AnimationCurve[] curves);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void CrossFadeStart();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

	// RVA: 0x1FAB710 Offset: 0x1FAB811 VA: 0x1FAB710
	protected void .ctor() { }
}

// Namespace: 
[Serializable]
public class HitReactionVRIK.PositionOffset.PositionOffsetLink // TypeDefIndex: 14458
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4C60 Offset: 0x2A4D61 VA: 0x2A4C60
	public IKSolverVR.PositionOffset positionOffset; // 0x10
	[TooltipAttribute] // RVA: 0x2A4CA0 Offset: 0x2A4DA1 VA: 0x2A4CA0
	public float weight; // 0x14
	private Vector3 lastValue; // 0x18
	private Vector3 current; // 0x24

	// Methods

	// RVA: 0x1DCE330 Offset: 0x1DCE431 VA: 0x1DCE330
	public void Apply(VRIK ik, Vector3 offset, float crossFader) { }

	// RVA: 0x1DCE3D0 Offset: 0x1DCE4D1 VA: 0x1DCE3D0
	public void CrossFadeStart() { }

	// RVA: 0x1DCE3F0 Offset: 0x1DCE4F1 VA: 0x1DCE3F0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class HitReactionVRIK.PositionOffset : HitReactionVRIK.Offset // TypeDefIndex: 14459
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4BA0 Offset: 0x2A4CA1 VA: 0x2A4BA0
	public int forceDirCurveIndex; // 0x50
	[TooltipAttribute] // RVA: 0x2A4BE0 Offset: 0x2A4CE1 VA: 0x2A4BE0
	public int upDirCurveIndex; // 0x54
	[TooltipAttribute] // RVA: 0x2A4C20 Offset: 0x2A4D21 VA: 0x2A4C20
	public HitReactionVRIK.PositionOffset.PositionOffsetLink[] offsetLinks; // 0x58

	// Methods

	// RVA: 0x1FAB730 Offset: 0x1FAB831 VA: 0x1FAB730 Slot: 4
	protected override float GetLength(AnimationCurve[] curves) { }

	// RVA: 0x1FAB8C0 Offset: 0x1FAB9C1 VA: 0x1FAB8C0 Slot: 5
	protected override void CrossFadeStart() { }

	// RVA: 0x1FAB930 Offset: 0x1FABA31 VA: 0x1FAB930 Slot: 6
	protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight) { }

	// RVA: 0x1FABAD0 Offset: 0x1FABBD1 VA: 0x1FABAD0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class HitReactionVRIK.RotationOffset.RotationOffsetLink // TypeDefIndex: 14460
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4D60 Offset: 0x2A4E61 VA: 0x2A4D60
	public IKSolverVR.RotationOffset rotationOffset; // 0x10
	[TooltipAttribute] // RVA: 0x2A4DA0 Offset: 0x2A4EA1 VA: 0x2A4DA0
	[RangeAttribute] // RVA: 0x2A4DA0 Offset: 0x2A4EA1 VA: 0x2A4DA0
	public float weight; // 0x14
	private Quaternion lastValue; // 0x18
	private Quaternion current; // 0x28

	// Methods

	// RVA: 0x1DCE400 Offset: 0x1DCE501 VA: 0x1DCE400
	public void Apply(VRIK ik, Quaternion offset, float crossFader) { }

	// RVA: 0x1DCE4E0 Offset: 0x1DCE5E1 VA: 0x1DCE4E0
	public void CrossFadeStart() { }

	// RVA: 0x1DCE500 Offset: 0x1DCE601 VA: 0x1DCE500
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class HitReactionVRIK.RotationOffset : HitReactionVRIK.Offset // TypeDefIndex: 14461
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4CE0 Offset: 0x2A4DE1 VA: 0x2A4CE0
	public int curveIndex; // 0x50
	[TooltipAttribute] // RVA: 0x2A4D20 Offset: 0x2A4E21 VA: 0x2A4D20
	public HitReactionVRIK.RotationOffset.RotationOffsetLink[] offsetLinks; // 0x58
	private Rigidbody rigidbody; // 0x60

	// Methods

	// RVA: 0x1FABAF0 Offset: 0x1FABBF1 VA: 0x1FABAF0 Slot: 4
	protected override float GetLength(AnimationCurve[] curves) { }

	// RVA: 0x1FABBD0 Offset: 0x1FABCD1 VA: 0x1FABBD0 Slot: 5
	protected override void CrossFadeStart() { }

	// RVA: 0x1FABC40 Offset: 0x1FABD41 VA: 0x1FABC40 Slot: 6
	protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight) { }

	// RVA: 0x1FABE80 Offset: 0x1FABF81 VA: 0x1FABE80
	public void .ctor() { }
}

