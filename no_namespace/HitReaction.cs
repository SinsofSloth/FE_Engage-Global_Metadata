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

