// Namespace: 
public abstract class WwiseGroupValueObjectReference : WwiseObjectReference // TypeDefIndex: 7988
{
	// Properties
	public abstract WwiseObjectReference GroupObjectReference { get; set; }
	public abstract WwiseObjectType GroupWwiseObjectType { get; }
	public override string DisplayName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract WwiseObjectReference get_GroupObjectReference();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_GroupObjectReference(WwiseObjectReference value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract WwiseObjectType get_GroupWwiseObjectType();

	// RVA: 0x26D8F20 Offset: 0x26D9021 VA: 0x26D8F20 Slot: 4
	public override string get_DisplayName() { }

	// RVA: 0x26D8FF0 Offset: 0x26D90F1 VA: 0x26D8FF0
	protected void .ctor() { }
}

