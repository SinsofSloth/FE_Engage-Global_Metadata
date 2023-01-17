// Namespace: AK.Wwise
[Serializable]
public class AuxBus : BaseType // TypeDefIndex: 8068
{
	// Fields
	public WwiseAuxBusReference WwiseObjectReference; // 0x20

	// Properties
	public override WwiseObjectReference ObjectReference { get; set; }
	public override WwiseObjectType WwiseObjectType { get; }

	// Methods

	// RVA: 0x2611BC0 Offset: 0x2611CC1 VA: 0x2611BC0 Slot: 4
	public override WwiseObjectReference get_ObjectReference() { }

	// RVA: 0x2611BD0 Offset: 0x2611CD1 VA: 0x2611BD0 Slot: 5
	public override void set_ObjectReference(WwiseObjectReference value) { }

	// RVA: 0x2611C60 Offset: 0x2611D61 VA: 0x2611C60 Slot: 6
	public override WwiseObjectType get_WwiseObjectType() { }

	// RVA: 0x2611C70 Offset: 0x2611D71 VA: 0x2611C70
	public void .ctor() { }
}

