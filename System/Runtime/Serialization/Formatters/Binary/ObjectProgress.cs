// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectProgress // TypeDefIndex: 1051
{
	// Fields
	internal static int opRecordIdCount; // 0x0
	internal bool isInitial; // 0x10
	internal int count; // 0x14
	internal BinaryTypeEnum expectedType; // 0x18
	internal object expectedTypeInformation; // 0x20
	internal string name; // 0x28
	internal InternalObjectTypeE objectTypeEnum; // 0x30
	internal InternalMemberTypeE memberTypeEnum; // 0x34
	internal InternalMemberValueE memberValueEnum; // 0x38
	internal Type dtType; // 0x40
	internal int numItems; // 0x48
	internal BinaryTypeEnum binaryTypeEnum; // 0x4C
	internal object typeInformation; // 0x50
	internal int nullCount; // 0x58
	internal int memberLength; // 0x5C
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x60
	internal object[] typeInformationA; // 0x68
	internal string[] memberNames; // 0x70
	internal Type[] memberTypes; // 0x78
	internal ParseRecord pr; // 0x80

	// Methods

	// RVA: 0x38697C0 Offset: 0x38698C1 VA: 0x38697C0
	internal void .ctor() { }

	// RVA: 0x3869840 Offset: 0x3869941 VA: 0x3869840
	internal void Init() { }

	// RVA: 0x3869900 Offset: 0x3869A01 VA: 0x3869900
	internal void ArrayCountIncrement(int value) { }

	// RVA: 0x3869910 Offset: 0x3869A11 VA: 0x3869910
	internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation) { }

	// RVA: 0x3869A80 Offset: 0x3869B81 VA: 0x3869A80
	private static void .cctor() { }
}

