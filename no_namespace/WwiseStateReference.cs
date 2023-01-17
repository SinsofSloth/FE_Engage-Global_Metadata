// Namespace: 
public class WwiseStateReference : WwiseGroupValueObjectReference // TypeDefIndex: 7992
{
	// Fields
	[AkShowOnlyAttribute] // RVA: 0x27E690 Offset: 0x27E791 VA: 0x27E690
	[SerializeField] // RVA: 0x27E690 Offset: 0x27E791 VA: 0x27E690
	private WwiseStateGroupReference WwiseStateGroupReference; // 0x30

	// Properties
	public override WwiseObjectType WwiseObjectType { get; }
	public override WwiseObjectReference GroupObjectReference { get; set; }
	public override WwiseObjectType GroupWwiseObjectType { get; }

	// Methods

	// RVA: 0x26D92A0 Offset: 0x26D93A1 VA: 0x26D92A0 Slot: 5
	public override WwiseObjectType get_WwiseObjectType() { }

	// RVA: 0x26D92B0 Offset: 0x26D93B1 VA: 0x26D92B0 Slot: 6
	public override WwiseObjectReference get_GroupObjectReference() { }

	// RVA: 0x26D92C0 Offset: 0x26D93C1 VA: 0x26D92C0 Slot: 7
	public override void set_GroupObjectReference(WwiseObjectReference value) { }

	// RVA: 0x26D9350 Offset: 0x26D9451 VA: 0x26D9350 Slot: 8
	public override WwiseObjectType get_GroupWwiseObjectType() { }

	// RVA: 0x26D9360 Offset: 0x26D9461 VA: 0x26D9360
	public void .ctor() { }
}

