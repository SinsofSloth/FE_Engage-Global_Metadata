// Namespace: AK.Wwise
[Serializable]
public class Switch : BaseGroupType // TypeDefIndex: 8076
{
	// Fields
	public WwiseSwitchReference WwiseObjectReference; // 0x30

	// Properties
	public override WwiseObjectReference ObjectReference { get; set; }
	public override WwiseObjectType WwiseObjectType { get; }
	public override WwiseObjectType WwiseObjectGroupType { get; }

	// Methods

	// RVA: 0x2929910 Offset: 0x2929A11 VA: 0x2929910 Slot: 4
	public override WwiseObjectReference get_ObjectReference() { }

	// RVA: 0x2929920 Offset: 0x2929A21 VA: 0x2929920 Slot: 5
	public override void set_ObjectReference(WwiseObjectReference value) { }

	// RVA: 0x29299B0 Offset: 0x2929AB1 VA: 0x29299B0 Slot: 6
	public override WwiseObjectType get_WwiseObjectType() { }

	// RVA: 0x29299C0 Offset: 0x2929AC1 VA: 0x29299C0 Slot: 9
	public override WwiseObjectType get_WwiseObjectGroupType() { }

	// RVA: 0x29299D0 Offset: 0x2929AD1 VA: 0x29299D0
	public void SetValue(GameObject gameObject) { }

	// RVA: 0x2929AA0 Offset: 0x2929BA1 VA: 0x2929AA0
	public void .ctor() { }
}

