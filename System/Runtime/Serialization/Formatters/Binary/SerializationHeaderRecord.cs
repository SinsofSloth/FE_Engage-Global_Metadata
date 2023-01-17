// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerializationHeaderRecord // TypeDefIndex: 1033
{
	// Fields
	internal int binaryFormatterMajorVersion; // 0x10
	internal int binaryFormatterMinorVersion; // 0x14
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x18
	internal int topId; // 0x1C
	internal int headerId; // 0x20
	internal int majorVersion; // 0x24
	internal int minorVersion; // 0x28

	// Methods

	// RVA: 0x3619860 Offset: 0x3619961 VA: 0x3619860
	internal void .ctor() { }

	// RVA: 0x3619870 Offset: 0x3619971 VA: 0x3619870
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	// RVA: 0x36198D0 Offset: 0x36199D1 VA: 0x36198D0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x3619950 Offset: 0x3619A51 VA: 0x3619950
	private static int GetInt32(byte[] buffer, int index) { }

	// RVA: 0x36199D0 Offset: 0x3619AD1 VA: 0x36199D0 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3619B50 Offset: 0x3619C51 VA: 0x3619B50
	public void Dump() { }
}

