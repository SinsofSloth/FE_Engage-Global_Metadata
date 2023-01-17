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

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class __BinaryParser // TypeDefIndex: 1078
{
	// Fields
	internal ObjectReader objectReader; // 0x10
	internal Stream input; // 0x18
	internal long topId; // 0x20
	internal long headerId; // 0x28
	internal SizedArray objectMapIdTable; // 0x30
	internal SizedArray assemIdToAssemblyTable; // 0x38
	internal SerStack stack; // 0x40
	internal BinaryTypeEnum expectedType; // 0x48
	internal object expectedTypeInformation; // 0x50
	internal ParseRecord PRS; // 0x58
	private BinaryAssemblyInfo systemAssemblyInfo; // 0x60
	private BinaryReader dataReader; // 0x68
	private static Encoding encoding; // 0x0
	private SerStack opPool; // 0x70
	private BinaryObject binaryObject; // 0x78
	private BinaryObjectWithMap bowm; // 0x80
	private BinaryObjectWithMapTyped bowmt; // 0x88
	internal BinaryObjectString objectString; // 0x90
	internal BinaryCrossAppDomainString crossAppDomainString; // 0x98
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0xA0
	private byte[] byteBuffer; // 0xA8
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0xB0
	internal MemberReference memberReference; // 0xB8
	internal ObjectNull objectNull; // 0xC0
	internal static MessageEnd messageEnd; // 0x8

	// Properties
	internal BinaryAssemblyInfo SystemAssemblyInfo { get; }
	internal SizedArray ObjectMapIdTable { get; }
	internal SizedArray AssemIdToAssemblyTable { get; }
	internal ParseRecord prs { get; }

	// Methods

	// RVA: 0x34DAE70 Offset: 0x34DAF71 VA: 0x34DAE70
	internal void .ctor(Stream stream, ObjectReader objectReader) { }

	// RVA: 0x34DAFC0 Offset: 0x34DB0C1 VA: 0x34DAFC0
	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	// RVA: 0x34DB0A0 Offset: 0x34DB1A1 VA: 0x34DB0A0
	internal SizedArray get_ObjectMapIdTable() { }

	// RVA: 0x34DB130 Offset: 0x34DB231 VA: 0x34DB130
	internal SizedArray get_AssemIdToAssemblyTable() { }

	// RVA: 0x34DB1C0 Offset: 0x34DB2C1 VA: 0x34DB1C0
	internal ParseRecord get_prs() { }

	// RVA: 0x34DB250 Offset: 0x34DB351 VA: 0x34DB250
	internal void Run() { }

	// RVA: 0x34DBA60 Offset: 0x34DBB61 VA: 0x34DBA60
	internal void ReadBegin() { }

	// RVA: 0x34DE8A0 Offset: 0x34DE9A1 VA: 0x34DE8A0
	internal void ReadEnd() { }

	// RVA: 0x34DEF40 Offset: 0x34DF041 VA: 0x34DEF40
	internal bool ReadBoolean() { }

	// RVA: 0x34DEF50 Offset: 0x34DF051 VA: 0x34DEF50
	internal byte ReadByte() { }

	// RVA: 0x34DEF60 Offset: 0x34DF061 VA: 0x34DEF60
	internal byte[] ReadBytes(int length) { }

	// RVA: 0x34DEF80 Offset: 0x34DF081 VA: 0x34DEF80
	internal void ReadBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x34DF010 Offset: 0x34DF111 VA: 0x34DF010
	internal char ReadChar() { }

	// RVA: 0x34DF020 Offset: 0x34DF121 VA: 0x34DF020
	internal char[] ReadChars(int length) { }

	// RVA: 0x34DF040 Offset: 0x34DF141 VA: 0x34DF040
	internal Decimal ReadDecimal() { }

	// RVA: 0x34DF100 Offset: 0x34DF201 VA: 0x34DF100
	internal float ReadSingle() { }

	// RVA: 0x34DF120 Offset: 0x34DF221 VA: 0x34DF120
	internal double ReadDouble() { }

	// RVA: 0x34DF140 Offset: 0x34DF241 VA: 0x34DF140
	internal short ReadInt16() { }

	// RVA: 0x34DF160 Offset: 0x34DF261 VA: 0x34DF160
	internal int ReadInt32() { }

	// RVA: 0x34DF180 Offset: 0x34DF281 VA: 0x34DF180
	internal long ReadInt64() { }

	// RVA: 0x34DF1A0 Offset: 0x34DF2A1 VA: 0x34DF1A0
	internal sbyte ReadSByte() { }

	// RVA: 0x34DF1B0 Offset: 0x34DF2B1 VA: 0x34DF1B0
	internal string ReadString() { }

	// RVA: 0x34DF1D0 Offset: 0x34DF2D1 VA: 0x34DF1D0
	internal TimeSpan ReadTimeSpan() { }

	// RVA: 0x34DF1F0 Offset: 0x34DF2F1 VA: 0x34DF1F0
	internal DateTime ReadDateTime() { }

	// RVA: 0x34DF280 Offset: 0x34DF381 VA: 0x34DF280
	internal ushort ReadUInt16() { }

	// RVA: 0x34DF2A0 Offset: 0x34DF3A1 VA: 0x34DF2A0
	internal uint ReadUInt32() { }

	// RVA: 0x34DF2C0 Offset: 0x34DF3C1 VA: 0x34DF2C0
	internal ulong ReadUInt64() { }

	// RVA: 0x34DBA70 Offset: 0x34DBB71 VA: 0x34DBA70
	internal void ReadSerializationHeaderRecord() { }

	// RVA: 0x34DBB40 Offset: 0x34DBC41 VA: 0x34DBB40
	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x34DBE00 Offset: 0x34DBF01 VA: 0x34DBE00
	private void ReadObject() { }

	// RVA: 0x34DC1F0 Offset: 0x34DC2F1 VA: 0x34DC1F0
	internal void ReadCrossAppDomainMap() { }

	// RVA: 0x34DC3B0 Offset: 0x34DC4B1 VA: 0x34DC3B0
	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x34DF3A0 Offset: 0x34DF4A1 VA: 0x34DF3A0
	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	// RVA: 0x34DC460 Offset: 0x34DC561 VA: 0x34DC460
	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x34DF8A0 Offset: 0x34DF9A1 VA: 0x34DF8A0
	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	// RVA: 0x34DC510 Offset: 0x34DC611 VA: 0x34DC510
	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x34DD680 Offset: 0x34DD781 VA: 0x34DD680
	private void ReadMemberPrimitiveTyped() { }

	// RVA: 0x34DD010 Offset: 0x34DD111 VA: 0x34DD010
	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x34DFE70 Offset: 0x34DFF71 VA: 0x34DFE70
	private void ReadArrayAsBytes(ParseRecord pr) { }

	// RVA: 0x34DE8B0 Offset: 0x34DE9B1 VA: 0x34DE8B0
	private void ReadMemberPrimitiveUnTyped() { }

	// RVA: 0x34DDDF0 Offset: 0x34DDEF1 VA: 0x34DDDF0
	private void ReadMemberReference() { }

	// RVA: 0x34DE260 Offset: 0x34DE361 VA: 0x34DE260
	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x34DE6F0 Offset: 0x34DE7F1 VA: 0x34DE6F0
	private void ReadMessageEnd() { }

	// RVA: 0x34E02A0 Offset: 0x34E03A1 VA: 0x34E02A0
	internal object ReadValue(InternalPrimitiveTypeE code) { }

	// RVA: 0x34DF2E0 Offset: 0x34DF3E1 VA: 0x34DF2E0
	private ObjectProgress GetOp() { }

	// RVA: 0x34DEEA0 Offset: 0x34DEFA1 VA: 0x34DEEA0
	private void PutOp(ObjectProgress op) { }

	// RVA: 0x34E06D0 Offset: 0x34E07D1 VA: 0x34E06D0
	private static void .cctor() { }
}

