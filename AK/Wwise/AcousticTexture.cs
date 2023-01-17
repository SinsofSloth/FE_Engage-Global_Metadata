// Namespace: AK.Wwise
[Serializable]
public class AcousticTexture : BaseType // TypeDefIndex: 8067
{
	// Fields
	public WwiseAcousticTextureReference WwiseObjectReference; // 0x20

	// Properties
	public override WwiseObjectReference ObjectReference { get; set; }
	public override WwiseObjectType WwiseObjectType { get; }

	// Methods

	// RVA: 0x2B2FCC0 Offset: 0x2B2FDC1 VA: 0x2B2FCC0 Slot: 4
	public override WwiseObjectReference get_ObjectReference() { }

	// RVA: 0x2B2FCD0 Offset: 0x2B2FDD1 VA: 0x2B2FCD0 Slot: 5
	public override void set_ObjectReference(WwiseObjectReference value) { }

	// RVA: 0x2B2FD60 Offset: 0x2B2FE61 VA: 0x2B2FD60 Slot: 6
	public override WwiseObjectType get_WwiseObjectType() { }

	// RVA: 0x2B2FD70 Offset: 0x2B2FE71 VA: 0x2B2FD70
	public void .ctor() { }
}

