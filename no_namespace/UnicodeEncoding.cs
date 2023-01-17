// Namespace: 
[Serializable]
private class UnicodeEncoding.Decoder : DecoderNLS, ISerializable // TypeDefIndex: 467
{
	// Fields
	internal int lastByte; // 0x30
	internal char lastChar; // 0x34

	// Properties
	internal override bool HasState { get; }

	// Methods

	// RVA: 0x1C0E6E0 Offset: 0x1C0E7E1 VA: 0x1C0E6E0
	public void .ctor(UnicodeEncoding encoding) { }

	// RVA: 0x1C0E6F0 Offset: 0x1C0E7F1 VA: 0x1C0E6F0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C0EBC0 Offset: 0x1C0ECC1 VA: 0x1C0EBC0 Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C0ED60 Offset: 0x1C0EE61 VA: 0x1C0ED60 Slot: 4
	public override void Reset() { }

	// RVA: 0x1C0ED90 Offset: 0x1C0EE91 VA: 0x1C0ED90 Slot: 14
	internal override bool get_HasState() { }
}

