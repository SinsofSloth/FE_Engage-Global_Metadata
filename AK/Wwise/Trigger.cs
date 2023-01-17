// Namespace: AK.Wwise
[Serializable]
public class Trigger : BaseType // TypeDefIndex: 8077
{
	// Fields
	public WwiseTriggerReference WwiseObjectReference; // 0x20

	// Properties
	public override WwiseObjectReference ObjectReference { get; set; }
	public override WwiseObjectType WwiseObjectType { get; }

	// Methods

	// RVA: 0x2872B10 Offset: 0x2872C11 VA: 0x2872B10 Slot: 4
	public override WwiseObjectReference get_ObjectReference() { }

	// RVA: 0x2872B20 Offset: 0x2872C21 VA: 0x2872B20 Slot: 5
	public override void set_ObjectReference(WwiseObjectReference value) { }

	// RVA: 0x2872BB0 Offset: 0x2872CB1 VA: 0x2872BB0 Slot: 6
	public override WwiseObjectType get_WwiseObjectType() { }

	// RVA: 0x2872BC0 Offset: 0x2872CC1 VA: 0x2872BC0
	public void Post(GameObject gameObject) { }

	// RVA: 0x2872C80 Offset: 0x2872D81 VA: 0x2872C80
	public void .ctor() { }
}

