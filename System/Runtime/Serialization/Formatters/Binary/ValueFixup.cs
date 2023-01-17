// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ValueFixup // TypeDefIndex: 1084
{
	// Fields
	internal ValueFixupEnum valueFixupEnum; // 0x10
	internal Array arrayObj; // 0x18
	internal int[] indexMap; // 0x20
	internal object header; // 0x28
	internal object memberObject; // 0x30
	internal static MemberInfo valueInfo; // 0x0
	internal ReadObjectInfo objectInfo; // 0x38
	internal string memberName; // 0x40

	// Methods

	// RVA: 0x34CCB20 Offset: 0x34CCC21 VA: 0x34CCB20
	internal void .ctor(Array arrayObj, int[] indexMap) { }

	// RVA: 0x34CCB80 Offset: 0x34CCC81 VA: 0x34CCB80
	internal void .ctor(object memberObject, string memberName, ReadObjectInfo objectInfo) { }

	// RVA: 0x34CCBF0 Offset: 0x34CCCF1 VA: 0x34CCBF0
	internal void Fixup(ParseRecord record, ParseRecord parent) { }
}

