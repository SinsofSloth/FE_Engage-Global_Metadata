// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObjectWithMap // TypeDefIndex: 1043
{
	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal int assemId; // 0x30

	// Methods

	// RVA: 0x3505940 Offset: 0x3505A41 VA: 0x3505940
	internal void .ctor() { }

	// RVA: 0x3505950 Offset: 0x3505A51 VA: 0x3505950
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x3505980 Offset: 0x3505A81 VA: 0x3505980
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId) { }

	// RVA: 0x35059F0 Offset: 0x3505AF1 VA: 0x35059F0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x3505AD0 Offset: 0x3505BD1 VA: 0x3505AD0 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x3505C30 Offset: 0x3505D31 VA: 0x3505C30
	public void Dump() { }
}

