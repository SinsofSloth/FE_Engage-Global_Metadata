// Namespace: RootMotion.FinalIK
public class HitReactionVRIK : OffsetModifierVRIK // TypeDefIndex: 14462
{
	// Fields
	public AnimationCurve[] offsetCurves; // 0x30
	[TooltipAttribute] // RVA: 0x2A4A10 Offset: 0x2A4B11 VA: 0x2A4A10
	public HitReactionVRIK.PositionOffset[] positionOffsets; // 0x38
	[TooltipAttribute] // RVA: 0x2A4A50 Offset: 0x2A4B51 VA: 0x2A4A50
	public HitReactionVRIK.RotationOffset[] rotationOffsets; // 0x40

	// Methods

	// RVA: 0x2667430 Offset: 0x2667531 VA: 0x2667430 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x2667500 Offset: 0x2667601 VA: 0x2667500
	public void Hit(Collider collider, Vector3 force, Vector3 point) { }

	// RVA: 0x2667700 Offset: 0x2667801 VA: 0x2667700
	public void .ctor() { }
}

