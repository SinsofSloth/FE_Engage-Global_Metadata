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

