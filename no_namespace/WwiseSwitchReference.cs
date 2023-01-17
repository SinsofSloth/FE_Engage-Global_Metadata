// Namespace: 
public class WwiseSwitchReference : WwiseGroupValueObjectReference // TypeDefIndex: 7994
{
	// Fields
	[AkShowOnlyAttribute] // RVA: 0x27E6D0 Offset: 0x27E7D1 VA: 0x27E6D0
	[SerializeField] // RVA: 0x27E6D0 Offset: 0x27E7D1 VA: 0x27E6D0
	private WwiseSwitchGroupReference WwiseSwitchGroupReference; // 0x30

	// Properties
	public override WwiseObjectType WwiseObjectType { get; }
	public override WwiseObjectReference GroupObjectReference { get; set; }
	public override WwiseObjectType GroupWwiseObjectType { get; }

	// Methods

	// RVA: 0x26D9490 Offset: 0x26D9591 VA: 0x26D9490 Slot: 5
	public override WwiseObjectType get_WwiseObjectType() { }

	// RVA: 0x26D94A0 Offset: 0x26D95A1 VA: 0x26D94A0 Slot: 6
	public override WwiseObjectReference get_GroupObjectReference() { }

	// RVA: 0x26D94B0 Offset: 0x26D95B1 VA: 0x26D94B0 Slot: 7
	public override void set_GroupObjectReference(WwiseObjectReference value) { }

	// RVA: 0x26D9540 Offset: 0x26D9641 VA: 0x26D9540 Slot: 8
	public override WwiseObjectType get_GroupWwiseObjectType() { }

	// RVA: 0x26D9550 Offset: 0x26D9651 VA: 0x26D9550
	public void .ctor() { }
}

