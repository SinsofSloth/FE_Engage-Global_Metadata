// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class MemberPrimitiveUnTyped // TypeDefIndex: 1046
{
	// Fields
	internal InternalPrimitiveTypeE typeInformation; // 0x10
	internal object value; // 0x18

	// Methods

	// RVA: 0x34E8FA0 Offset: 0x34E90A1 VA: 0x34E8FA0
	internal void .ctor() { }

	// RVA: 0x34E8FB0 Offset: 0x34E90B1 VA: 0x34E8FB0
	internal void Set(InternalPrimitiveTypeE typeInformation, object value) { }

	// RVA: 0x34E8FC0 Offset: 0x34E90C1 VA: 0x34E8FC0
	internal void Set(InternalPrimitiveTypeE typeInformation) { }

	// RVA: 0x34E8FD0 Offset: 0x34E90D1 VA: 0x34E8FD0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x34E8FF0 Offset: 0x34E90F1 VA: 0x34E8FF0 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x34E9030 Offset: 0x34E9131 VA: 0x34E9030
	public void Dump() { }
}

