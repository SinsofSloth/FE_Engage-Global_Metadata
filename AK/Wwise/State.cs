// Namespace: AK.Wwise
[Serializable]
public class State : BaseGroupType // TypeDefIndex: 8075
{
	// Fields
	public WwiseStateReference WwiseObjectReference; // 0x30

	// Properties
	public override WwiseObjectReference ObjectReference { get; set; }
	public override WwiseObjectType WwiseObjectType { get; }
	public override WwiseObjectType WwiseObjectGroupType { get; }

	// Methods

	// RVA: 0x291D410 Offset: 0x291D511 VA: 0x291D410 Slot: 4
	public override WwiseObjectReference get_ObjectReference() { }

	// RVA: 0x291D420 Offset: 0x291D521 VA: 0x291D420 Slot: 5
	public override void set_ObjectReference(WwiseObjectReference value) { }

	// RVA: 0x291D4B0 Offset: 0x291D5B1 VA: 0x291D4B0 Slot: 6
	public override WwiseObjectType get_WwiseObjectType() { }

	// RVA: 0x291D4C0 Offset: 0x291D5C1 VA: 0x291D4C0 Slot: 9
	public override WwiseObjectType get_WwiseObjectGroupType() { }

	// RVA: 0x291D4D0 Offset: 0x291D5D1 VA: 0x291D4D0
	public void SetValue() { }

	// RVA: 0x291D5A0 Offset: 0x291D6A1 VA: 0x291D5A0
	public void .ctor() { }
}

