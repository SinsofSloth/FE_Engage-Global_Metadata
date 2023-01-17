// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObjectString // TypeDefIndex: 1039
{
	// Fields
	internal int objectId; // 0x10
	internal string value; // 0x18

	// Methods

	// RVA: 0x3505870 Offset: 0x3505971 VA: 0x3505870
	internal void .ctor() { }

	// RVA: 0x3505880 Offset: 0x3505981 VA: 0x3505880
	internal void Set(int objectId, string value) { }

	// RVA: 0x3505890 Offset: 0x3505991 VA: 0x3505890 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x35058E0 Offset: 0x35059E1 VA: 0x35058E0 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3505930 Offset: 0x3505A31 VA: 0x3505930
	public void Dump() { }
}

