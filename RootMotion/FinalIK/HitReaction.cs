// Namespace: RootMotion.FinalIK
public class HitReaction : OffsetModifier // TypeDefIndex: 14456
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A4620 Offset: 0x2A4721 VA: 0x2A4620
	public HitReaction.HitPointEffector[] effectorHitPoints; // 0x30
	[TooltipAttribute] // RVA: 0x2A4660 Offset: 0x2A4761 VA: 0x2A4660
	public HitReaction.HitPointBone[] boneHitPoints; // 0x38

	// Properties
	public bool inProgress { get; }

	// Methods

	// RVA: 0x2667080 Offset: 0x2667181 VA: 0x2667080
	public bool get_inProgress() { }

	// RVA: 0x2667150 Offset: 0x2667251 VA: 0x2667150 Slot: 4
	protected override void OnModifyOffset() { }

	// RVA: 0x2667220 Offset: 0x2667321 VA: 0x2667220
	public void Hit(Collider collider, Vector3 force, Vector3 point) { }

	// RVA: 0x2667420 Offset: 0x2667521 VA: 0x2667420
	public void .ctor() { }
}

