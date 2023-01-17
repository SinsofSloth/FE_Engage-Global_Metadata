// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObject // TypeDefIndex: 1036
{
	// Fields
	internal int objectId; // 0x10
	internal int mapId; // 0x14

	// Methods

	// RVA: 0x35057B0 Offset: 0x35058B1 VA: 0x35057B0
	internal void .ctor() { }

	// RVA: 0x35057C0 Offset: 0x35058C1 VA: 0x35057C0
	internal void Set(int objectId, int mapId) { }

	// RVA: 0x35057D0 Offset: 0x35058D1 VA: 0x35057D0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x3505820 Offset: 0x3505921 VA: 0x3505820 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3505860 Offset: 0x3505961 VA: 0x3505860
	public void Dump() { }
}

