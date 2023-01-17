// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObjectWithMapTyped // TypeDefIndex: 1044
{
	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x30
	internal object[] typeInformationA; // 0x38
	internal int[] memberAssemIds; // 0x40
	internal int assemId; // 0x48

	// Methods

	// RVA: 0x3505C40 Offset: 0x3505D41 VA: 0x3505C40
	internal void .ctor() { }

	// RVA: 0x3505C50 Offset: 0x3505D51 VA: 0x3505C50
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x3505C80 Offset: 0x3505D81 VA: 0x3505C80
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId) { }

	// RVA: 0x3505D40 Offset: 0x3505E41 VA: 0x3505D40 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x3505ED0 Offset: 0x3505FD1 VA: 0x3505ED0 Slot: 5
	public void Read(__BinaryParser input) { }
}

