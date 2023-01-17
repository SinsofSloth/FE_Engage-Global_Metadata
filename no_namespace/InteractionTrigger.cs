// Namespace: 
[Serializable]
public class InteractionTrigger.CharacterPosition // TypeDefIndex: 14420
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A34B0 Offset: 0x2A35B1 VA: 0x2A34B0
	public bool use; // 0x10
	[TooltipAttribute] // RVA: 0x2A34F0 Offset: 0x2A35F1 VA: 0x2A34F0
	public Vector2 offset; // 0x14
	[RangeAttribute] // RVA: 0x2A3530 Offset: 0x2A3631 VA: 0x2A3530
	[TooltipAttribute] // RVA: 0x2A3530 Offset: 0x2A3631 VA: 0x2A3530
	public float angleOffset; // 0x1C
	[RangeAttribute] // RVA: 0x2A3590 Offset: 0x2A3691 VA: 0x2A3590
	[TooltipAttribute] // RVA: 0x2A3590 Offset: 0x2A3691 VA: 0x2A3590
	public float maxAngle; // 0x20
	[TooltipAttribute] // RVA: 0x2A35F0 Offset: 0x2A36F1 VA: 0x2A35F0
	public float radius; // 0x24
	[TooltipAttribute] // RVA: 0x2A3630 Offset: 0x2A3731 VA: 0x2A3630
	public bool orbit; // 0x28
	[TooltipAttribute] // RVA: 0x2A3670 Offset: 0x2A3771 VA: 0x2A3670
	public bool fixYAxis; // 0x29

	// Properties
	public Vector3 offset3D { get; }
	public Vector3 direction3D { get; }

	// Methods

	// RVA: 0x2221C60 Offset: 0x2221D61 VA: 0x2221C60
	public Vector3 get_offset3D() { }

	// RVA: 0x2221C70 Offset: 0x2221D71 VA: 0x2221C70
	public Vector3 get_direction3D() { }

	// RVA: 0x2221D00 Offset: 0x2221E01 VA: 0x2221D00
	public bool IsInRange(Transform character, Transform trigger, out float error) { }

	// RVA: 0x22221B0 Offset: 0x22222B1 VA: 0x22221B0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class InteractionTrigger.Range.Interaction // TypeDefIndex: 14422
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A38F0 Offset: 0x2A39F1 VA: 0x2A38F0
	public InteractionObject interactionObject; // 0x10
	[TooltipAttribute] // RVA: 0x2A3930 Offset: 0x2A3A31 VA: 0x2A3930
	public FullBodyBipedEffector[] effectors; // 0x18

	// Methods

	// RVA: 0x1DD0CE0 Offset: 0x1DD0DE1 VA: 0x1DD0CE0
	public void .ctor() { }
}

