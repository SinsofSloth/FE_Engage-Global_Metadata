// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectMap // TypeDefIndex: 1050
{
	// Fields
	internal string objectName; // 0x10
	internal Type objectType; // 0x18
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x20
	internal object[] typeInformationA; // 0x28
	internal Type[] memberTypes; // 0x30
	internal string[] memberNames; // 0x38
	internal ReadObjectInfo objectInfo; // 0x40
	internal bool isInitObjectInfo; // 0x48
	internal ObjectReader objectReader; // 0x50
	internal int objectId; // 0x58
	internal BinaryAssemblyInfo assemblyInfo; // 0x60

	// Methods

	// RVA: 0x3868A90 Offset: 0x3868B91 VA: 0x3868A90
	internal void .ctor(string objectName, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	// RVA: 0x3868D30 Offset: 0x3868E31 VA: 0x3868D30
	internal void .ctor(string objectName, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	// RVA: 0x38692F0 Offset: 0x38693F1 VA: 0x38692F0
	internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x3869360 Offset: 0x3869461 VA: 0x3869360
	internal static ObjectMap Create(string name, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	// RVA: 0x3869400 Offset: 0x3869501 VA: 0x3869400
	internal static ObjectMap Create(string name, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }
}

