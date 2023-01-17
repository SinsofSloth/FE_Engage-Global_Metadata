// Namespace: System.Runtime.Serialization.Formatters.Binary
internal static class BinaryConverter // TypeDefIndex: 1030
{
	// Methods

	// RVA: 0x3504070 Offset: 0x3504171 VA: 0x3504070
	internal static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out object typeInformation, out int assemId) { }

	// RVA: 0x35043C0 Offset: 0x35044C1 VA: 0x35043C0
	internal static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out object typeInformation) { }

	// RVA: 0x3503620 Offset: 0x3503721 VA: 0x3503620
	internal static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, int assemId, __BinaryWriter sout) { }

	// RVA: 0x3503BC0 Offset: 0x3503CC1 VA: 0x3503BC0
	internal static object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId) { }

	// RVA: 0x3504620 Offset: 0x3504721 VA: 0x3504620
	internal static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out Type type, out bool isVariant) { }
}

