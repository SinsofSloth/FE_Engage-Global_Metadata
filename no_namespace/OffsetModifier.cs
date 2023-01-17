// Namespace: 
[Serializable]
public class OffsetModifier.OffsetLimits // TypeDefIndex: 14467
{
	// Fields
	[TooltipAttribute] // RVA: 0x2A5440 Offset: 0x2A5541 VA: 0x2A5440
	public FullBodyBipedEffector effector; // 0x10
	[TooltipAttribute] // RVA: 0x2A5480 Offset: 0x2A5581 VA: 0x2A5480
	public float spring; // 0x14
	[TooltipAttribute] // RVA: 0x2A54C0 Offset: 0x2A55C1 VA: 0x2A54C0
	public bool x; // 0x18
	[TooltipAttribute] // RVA: 0x2A5500 Offset: 0x2A5601 VA: 0x2A5500
	public bool y; // 0x19
	[TooltipAttribute] // RVA: 0x2A5540 Offset: 0x2A5641 VA: 0x2A5540
	public bool z; // 0x1A
	[TooltipAttribute] // RVA: 0x2A5580 Offset: 0x2A5681 VA: 0x2A5580
	public float minX; // 0x1C
	[TooltipAttribute] // RVA: 0x2A55C0 Offset: 0x2A56C1 VA: 0x2A55C0
	public float maxX; // 0x20
	[TooltipAttribute] // RVA: 0x2A5600 Offset: 0x2A5701 VA: 0x2A5600
	public float minY; // 0x24
	[TooltipAttribute] // RVA: 0x2A5640 Offset: 0x2A5741 VA: 0x2A5640
	public float maxY; // 0x28
	[TooltipAttribute] // RVA: 0x2A5680 Offset: 0x2A5781 VA: 0x2A5680
	public float minZ; // 0x2C
	[TooltipAttribute] // RVA: 0x2A56C0 Offset: 0x2A57C1 VA: 0x2A56C0
	public float maxZ; // 0x30

	// Methods

	// RVA: 0x1F1B9B0 Offset: 0x1F1BAB1 VA: 0x1F1B9B0
	public void Apply(IKEffector e, Quaternion rootRotation) { }

	// RVA: 0x1F1BBE0 Offset: 0x1F1BCE1 VA: 0x1F1BBE0
	private float SpringAxis(float value, float min, float max) { }

	// RVA: 0x1F1BC80 Offset: 0x1F1BD81 VA: 0x1F1BC80
	private float Spring(float value, float limit, bool negative) { }

	// RVA: 0x1F1BCE0 Offset: 0x1F1BDE1 VA: 0x1F1BCE0
	public void .ctor() { }
}

