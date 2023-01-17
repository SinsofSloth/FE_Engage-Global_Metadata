// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class __BinaryWriter // TypeDefIndex: 1067
{
	// Fields
	internal Stream sout; // 0x10
	internal FormatterTypeStyle formatterTypeStyle; // 0x18
	internal Hashtable objectMapTable; // 0x20
	internal ObjectWriter objectWriter; // 0x28
	internal BinaryWriter dataWriter; // 0x30
	internal int m_nestedObjectCount; // 0x38
	private int nullCount; // 0x3C
	internal BinaryMethodCall binaryMethodCall; // 0x40
	internal BinaryMethodReturn binaryMethodReturn; // 0x48
	internal BinaryObject binaryObject; // 0x50
	internal BinaryObjectWithMap binaryObjectWithMap; // 0x58
	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped; // 0x60
	internal BinaryObjectString binaryObjectString; // 0x68
	internal BinaryArray binaryArray; // 0x70
	private byte[] byteBuffer; // 0x78
	private int chunkSize; // 0x80
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0x88
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0x90
	internal ObjectNull objectNull; // 0x98
	internal MemberReference memberReference; // 0xA0
	internal BinaryAssembly binaryAssembly; // 0xA8

	// Methods

	// RVA: 0x34E0760 Offset: 0x34E0861 VA: 0x34E0760
	internal void .ctor(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	// RVA: 0x34E0830 Offset: 0x34E0931 VA: 0x34E0830
	internal void WriteBegin() { }

	// RVA: 0x34E0840 Offset: 0x34E0941 VA: 0x34E0840
	internal void WriteEnd() { }

	// RVA: 0x34E0850 Offset: 0x34E0951 VA: 0x34E0850
	internal void WriteBoolean(bool value) { }

	// RVA: 0x34E0870 Offset: 0x34E0971 VA: 0x34E0870
	internal void WriteByte(byte value) { }

	// RVA: 0x34E0880 Offset: 0x34E0981 VA: 0x34E0880
	private void WriteBytes(byte[] value) { }

	// RVA: 0x34E0890 Offset: 0x34E0991 VA: 0x34E0890
	private void WriteBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x34E08A0 Offset: 0x34E09A1 VA: 0x34E08A0
	internal void WriteChar(char value) { }

	// RVA: 0x34E08B0 Offset: 0x34E09B1 VA: 0x34E08B0
	internal void WriteChars(char[] value) { }

	// RVA: 0x34E08D0 Offset: 0x34E09D1 VA: 0x34E08D0
	internal void WriteDecimal(Decimal value) { }

	// RVA: 0x34E0990 Offset: 0x34E0A91 VA: 0x34E0990
	internal void WriteSingle(float value) { }

	// RVA: 0x34E09B0 Offset: 0x34E0AB1 VA: 0x34E09B0
	internal void WriteDouble(double value) { }

	// RVA: 0x34E09D0 Offset: 0x34E0AD1 VA: 0x34E09D0
	internal void WriteInt16(short value) { }

	// RVA: 0x34E09F0 Offset: 0x34E0AF1 VA: 0x34E09F0
	internal void WriteInt32(int value) { }

	// RVA: 0x34E0A10 Offset: 0x34E0B11 VA: 0x34E0A10
	internal void WriteInt64(long value) { }

	// RVA: 0x34E0A30 Offset: 0x34E0B31 VA: 0x34E0A30
	internal void WriteSByte(sbyte value) { }

	// RVA: 0x34E0970 Offset: 0x34E0A71 VA: 0x34E0970
	internal void WriteString(string value) { }

	// RVA: 0x34E0A40 Offset: 0x34E0B41 VA: 0x34E0A40
	internal void WriteTimeSpan(TimeSpan value) { }

	// RVA: 0x34E0A60 Offset: 0x34E0B61 VA: 0x34E0A60
	internal void WriteDateTime(DateTime value) { }

	// RVA: 0x34E0A80 Offset: 0x34E0B81 VA: 0x34E0A80
	internal void WriteUInt16(ushort value) { }

	// RVA: 0x34E0AA0 Offset: 0x34E0BA1 VA: 0x34E0AA0
	internal void WriteUInt32(uint value) { }

	// RVA: 0x34E0AC0 Offset: 0x34E0BC1 VA: 0x34E0AC0
	internal void WriteUInt64(ulong value) { }

	// RVA: 0x34E0AE0 Offset: 0x34E0BE1 VA: 0x34E0AE0
	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x34E0AF0 Offset: 0x34E0BF1 VA: 0x34E0AF0
	internal void WriteSerializationHeaderEnd() { }

	// RVA: 0x34E0B70 Offset: 0x34E0C71 VA: 0x34E0B70
	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	// RVA: 0x34E0C20 Offset: 0x34E0D21 VA: 0x34E0C20
	internal void WriteMethodCall() { }

	// RVA: 0x34E0CC0 Offset: 0x34E0DC1 VA: 0x34E0CC0
	internal void WriteMethodReturn() { }

	// RVA: 0x34E0D60 Offset: 0x34E0E61 VA: 0x34E0D60
	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x34E1360 Offset: 0x34E1461 VA: 0x34E1360
	internal void WriteObjectString(int objectId, string value) { }

	// RVA: 0x34E1420 Offset: 0x34E1521 VA: 0x34E1420
	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	// RVA: 0x34E1720 Offset: 0x34E1821 VA: 0x34E1720
	private void WriteArrayAsBytes(Array array, int typeLength) { }

	// RVA: 0x34E19A0 Offset: 0x34E1AA1 VA: 0x34E19A0
	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	// RVA: 0x34E1B40 Offset: 0x34E1C41 VA: 0x34E1B40
	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA) { }

	// RVA: 0x34E1CC0 Offset: 0x34E1DC1 VA: 0x34E1CC0
	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA) { }

	// RVA: 0x34E1D30 Offset: 0x34E1E31 VA: 0x34E1D30
	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x34E1E90 Offset: 0x34E1F91 VA: 0x34E1E90
	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x34E1F70 Offset: 0x34E2071 VA: 0x34E1F70
	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	// RVA: 0x34E2020 Offset: 0x34E2121 VA: 0x34E2020
	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	// RVA: 0x34E2030 Offset: 0x34E2131 VA: 0x34E2030
	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	// RVA: 0x34E2070 Offset: 0x34E2171 VA: 0x34E2070
	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x34E20C0 Offset: 0x34E21C1 VA: 0x34E20C0
	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x34E20D0 Offset: 0x34E21D1 VA: 0x34E20D0
	internal void WriteDelayedNullItem() { }

	// RVA: 0x34E20E0 Offset: 0x34E21E1 VA: 0x34E20E0
	internal void WriteItemEnd() { }

	// RVA: 0x34E12A0 Offset: 0x34E13A1 VA: 0x34E12A0
	private void InternalWriteItemNull() { }

	// RVA: 0x34E20F0 Offset: 0x34E21F1 VA: 0x34E20F0
	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	// RVA: 0x34E2130 Offset: 0x34E2231 VA: 0x34E2130
	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	// RVA: 0x34E2240 Offset: 0x34E2341 VA: 0x34E2240
	internal void WriteValue(InternalPrimitiveTypeE code, object value) { }
}

