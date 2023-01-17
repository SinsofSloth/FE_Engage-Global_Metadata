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

