// Namespace: App
public class Stream : IDisposable // TypeDefIndex: 13931
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29CC20 Offset: 0x29CD21 VA: 0x29CC20
	private byte[] <m_Buffer>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29CC30 Offset: 0x29CD31 VA: 0x29CC30
	private int <m_Position>k__BackingField; // 0x18
	private Stack<Stream.Info> m_Stack; // 0x20
	private const uint MAGIC_CODE = 3452816845;
	private const ulong Magic_Number_Compress = 855396746751181331;
	private const ushort HashCode = 61389;
	private const ushort NullCode = 52443;

	// Properties
	protected byte[] m_Buffer { get; set; }
	protected int m_Position { get; set; }
	public int Position { get; set; }
	public int Length { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CD9B0 Offset: 0x2CDAB1 VA: 0x2CD9B0
	// RVA: 0x291F480 Offset: 0x291F581 VA: 0x291F480
	protected byte[] get_m_Buffer() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD9C0 Offset: 0x2CDAC1 VA: 0x2CD9C0
	// RVA: 0x291F490 Offset: 0x291F591 VA: 0x291F490
	protected void set_m_Buffer(byte[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD9D0 Offset: 0x2CDAD1 VA: 0x2CD9D0
	// RVA: 0x291F4A0 Offset: 0x291F5A1 VA: 0x291F4A0
	protected int get_m_Position() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD9E0 Offset: 0x2CDAE1 VA: 0x2CD9E0
	// RVA: 0x291F4B0 Offset: 0x291F5B1 VA: 0x291F4B0
	protected void set_m_Position(int value) { }

	// RVA: 0x291F4C0 Offset: 0x291F5C1 VA: 0x291F4C0
	public void .ctor() { }

	// RVA: 0x291F570 Offset: 0x291F671 VA: 0x291F570
	public void .ctor(int size) { }

	// RVA: 0x291F640 Offset: 0x291F741 VA: 0x291F640
	public void .ctor(byte[] buffer) { }

	// RVA: 0x291F6F0 Offset: 0x291F7F1 VA: 0x291F6F0
	public void .ctor(Stream stream) { }

	// RVA: 0x291F7F0 Offset: 0x291F8F1 VA: 0x291F7F0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x291F8A0 Offset: 0x291F9A1 VA: 0x291F8A0
	public void Setup(int size) { }

	// RVA: 0x291F870 Offset: 0x291F971 VA: 0x291F870 Slot: 4
	public void Dispose() { }

	// RVA: 0x291F910 Offset: 0x291FA11 VA: 0x291F910
	public int get_Position() { }

	// RVA: 0x291F920 Offset: 0x291FA21 VA: 0x291F920
	public void set_Position(int value) { }

	// RVA: 0x291F930 Offset: 0x291FA31 VA: 0x291F930
	public int get_Length() { }

	// RVA: 0x291F940 Offset: 0x291FA41 VA: 0x291F940
	public bool HasNext() { }

	// RVA: 0x291F960 Offset: 0x291FA61 VA: 0x291F960
	public bool HasStream() { }

	// RVA: 0x291F980 Offset: 0x291FA81 VA: 0x291F980
	public int GetRest() { }

	// RVA: 0x291F9A0 Offset: 0x291FAA1 VA: 0x291F9A0
	public void Clear() { }

	// RVA: 0x291FA00 Offset: 0x291FB01 VA: 0x291FA00
	public void Fill(byte data, int size) { }

	// RVA: 0x291FA60 Offset: 0x291FB61 VA: 0x291FA60
	public void WriteBool(bool data) { }

	// RVA: 0x291FB00 Offset: 0x291FC01 VA: 0x291FB00
	public void WriteByte(byte data) { }

	// RVA: 0x291FB40 Offset: 0x291FC41 VA: 0x291FB40
	public void WriteSbyte(sbyte data) { }

	// RVA: 0x291FB80 Offset: 0x291FC81 VA: 0x291FB80
	public void Write8(byte data) { }

	// RVA: 0x291FBC0 Offset: 0x291FCC1 VA: 0x291FBC0
	public void Write8(sbyte data) { }

	// RVA: 0x291FC00 Offset: 0x291FD01 VA: 0x291FC00
	public void WriteShort(short data) { }

	// RVA: 0x291FCA0 Offset: 0x291FDA1 VA: 0x291FCA0
	public void WriteUshort(ushort data) { }

	// RVA: 0x291FD40 Offset: 0x291FE41 VA: 0x291FD40
	public void Write16(short data) { }

	// RVA: 0x291FDE0 Offset: 0x291FEE1 VA: 0x291FDE0
	public void Write16(ushort data) { }

	// RVA: 0x291FE80 Offset: 0x291FF81 VA: 0x291FE80
	public void WriteInt(int data) { }

	// RVA: 0x291FF20 Offset: 0x2920021 VA: 0x291FF20
	public void WriteUint(uint data) { }

	// RVA: 0x291FFC0 Offset: 0x29200C1 VA: 0x291FFC0
	public void Write32(int data) { }

	// RVA: 0x2920060 Offset: 0x2920161 VA: 0x2920060
	public void Write32(uint data) { }

	// RVA: 0x2920100 Offset: 0x2920201 VA: 0x2920100
	public void WriteHash(string data) { }

	// RVA: 0x2920210 Offset: 0x2920311 VA: 0x2920210
	public void WriteLong(long data) { }

	// RVA: 0x29202B0 Offset: 0x29203B1 VA: 0x29202B0
	public void WriteUlong(ulong data) { }

	// RVA: 0x2920350 Offset: 0x2920451 VA: 0x2920350
	public void Write64(long data) { }

	// RVA: 0x29203F0 Offset: 0x29204F1 VA: 0x29203F0
	public void Write64(ulong data) { }

	// RVA: 0x2920490 Offset: 0x2920591 VA: 0x2920490
	public void WriteFloat(float data) { }

	// RVA: 0x2920540 Offset: 0x2920641 VA: 0x2920540
	public void WriteF32(float data) { }

	// RVA: 0x29205F0 Offset: 0x29206F1 VA: 0x29205F0
	public void WriteVector2(Vector2 data) { }

	// RVA: 0x2920710 Offset: 0x2920811 VA: 0x2920710
	public void WriteVector3(Vector3 data) { }

	// RVA: 0x29208A0 Offset: 0x29209A1 VA: 0x29208A0
	public void WriteQuaternion(Quaternion data) { }

	// RVA: 0x2920AA0 Offset: 0x2920BA1 VA: 0x2920AA0
	public void WriteColor(Color data) { }

	// RVA: 0x2920CA0 Offset: 0x2920DA1 VA: 0x2920CA0
	public void WriteBlock(byte[] data) { }

	// RVA: 0x2920CB0 Offset: 0x2920DB1 VA: 0x2920CB0
	public void WriteBlock(byte[] data, int size) { }

	// RVA: 0x2920D80 Offset: 0x2920E81 VA: 0x2920D80
	public void WriteStream(Stream stream) { }

	// RVA: 0x2920D90 Offset: 0x2920E91 VA: 0x2920D90
	public void WriteString(string data) { }

	// RVA: 0x2920F30 Offset: 0x2921031 VA: 0x2920F30
	public void Skip(int size) { }

	// RVA: 0x2920F40 Offset: 0x2921041 VA: 0x2920F40
	private int Replace(int position) { }

	// RVA: 0x2920F50 Offset: 0x2921051 VA: 0x2920F50
	public byte PeekByte() { }

	// RVA: 0x2920F90 Offset: 0x2921091 VA: 0x2920F90
	public byte Peek8() { }

	// RVA: 0x2920FD0 Offset: 0x29210D1 VA: 0x2920FD0
	public bool ReadBool() { }

	// RVA: 0x2921070 Offset: 0x2921171 VA: 0x2921070
	public byte ReadByte() { }

	// RVA: 0x29210D0 Offset: 0x29211D1 VA: 0x29210D0
	public sbyte ReadSbyte() { }

	// RVA: 0x2921130 Offset: 0x2921231 VA: 0x2921130
	public byte Read8() { }

	// RVA: 0x2921190 Offset: 0x2921291 VA: 0x2921190
	public byte Read8(int position) { }

	// RVA: 0x2921200 Offset: 0x2921301 VA: 0x2921200
	public short ReadShort() { }

	// RVA: 0x29212B0 Offset: 0x29213B1 VA: 0x29212B0
	public ushort ReadUshort() { }

	// RVA: 0x2921360 Offset: 0x2921461 VA: 0x2921360
	public short Read16() { }

	// RVA: 0x2921410 Offset: 0x2921511 VA: 0x2921410
	public short Read16(int position) { }

	// RVA: 0x29214D0 Offset: 0x29215D1 VA: 0x29214D0
	public int ReadInt() { }

	// RVA: 0x2921580 Offset: 0x2921681 VA: 0x2921580
	public uint ReadUint() { }

	// RVA: 0x2921630 Offset: 0x2921731 VA: 0x2921630
	public int ReadHash() { }

	// RVA: 0x29216E0 Offset: 0x29217E1 VA: 0x29216E0
	public int Read32() { }

	// RVA: 0x2921790 Offset: 0x2921891 VA: 0x2921790
	public int Read32(int position) { }

	// RVA: 0x2921850 Offset: 0x2921951 VA: 0x2921850
	public long ReadLong() { }

	// RVA: 0x2921900 Offset: 0x2921A01 VA: 0x2921900
	public long Read64() { }

	// RVA: 0x29219B0 Offset: 0x2921AB1 VA: 0x29219B0
	public ulong ReadUlong() { }

	// RVA: 0x2921A60 Offset: 0x2921B61 VA: 0x2921A60
	public ulong ReadUlong(int position) { }

	// RVA: 0x2921B20 Offset: 0x2921C21 VA: 0x2921B20
	public float ReadFloat() { }

	// RVA: 0x2921BD0 Offset: 0x2921CD1 VA: 0x2921BD0
	public float ReadF32() { }

	// RVA: 0x2921C80 Offset: 0x2921D81 VA: 0x2921C80
	public Vector2 ReadVector2() { }

	// RVA: 0x2921DB0 Offset: 0x2921EB1 VA: 0x2921DB0
	public Vector3 ReadVector3() { }

	// RVA: 0x2921F70 Offset: 0x2922071 VA: 0x2921F70
	public Quaternion ReadQuaternion() { }

	// RVA: 0x29221B0 Offset: 0x29222B1 VA: 0x29221B0
	public Color ReadColor() { }

	// RVA: 0x29223F0 Offset: 0x29224F1 VA: 0x29223F0
	public byte[] ReadBlock() { }

	// RVA: 0x2922540 Offset: 0x2922641 VA: 0x2922540
	public int ReadBlock(byte[] bytes) { }

	// RVA: 0x2922650 Offset: 0x2922751 VA: 0x2922650
	public int ReadStream(Stream stream) { }

	// RVA: 0x2922770 Offset: 0x2922871 VA: 0x2922770
	public string ReadString() { }

	// RVA: 0x29229E0 Offset: 0x2922AE1 VA: 0x29229E0
	public string ReadString(string empty) { }

	// RVA: 0x2922C70 Offset: 0x2922D71 VA: 0x2922C70
	public void Write8(byte data, int position) { }

	// RVA: 0x2922CC0 Offset: 0x2922DC1 VA: 0x2922CC0
	public void Write16(short data, int position) { }

	// RVA: 0x2922D60 Offset: 0x2922E61 VA: 0x2922D60
	public void Write32(int data, int position) { }

	// RVA: 0x2922E00 Offset: 0x2922F01 VA: 0x2922E00
	public void WriteInt(int data, int position) { }

	// RVA: 0x2922EA0 Offset: 0x2922FA1 VA: 0x2922EA0
	public void WriteBegin(int version) { }

	// RVA: 0x2923070 Offset: 0x2923171 VA: 0x2923070
	public void WriteEnd() { }

	// RVA: 0x2923150 Offset: 0x2923251 VA: 0x2923150
	public bool ReadBegin(int version) { }

	// RVA: 0x2923180 Offset: 0x2923281 VA: 0x2923180
	public int ReadBegin() { }

	// RVA: 0x2923390 Offset: 0x2923491 VA: 0x2923390
	public void ReadEnd(bool isWarning = True) { }

	// RVA: 0x2923400 Offset: 0x2923501 VA: 0x2923400
	public void ReadSkip() { }

	// RVA: 0x2923480 Offset: 0x2923581 VA: 0x2923480
	public void WriteCrc32() { }

	// RVA: 0x2923560 Offset: 0x2923661 VA: 0x2923560
	public bool ReadCrc32() { }

	// RVA: 0x2923540 Offset: 0x2923641 VA: 0x2923540
	private uint CalcCrc32() { }

	// RVA: 0x2923640 Offset: 0x2923741 VA: 0x2923640 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x29237A0 Offset: 0x29238A1 VA: 0x29237A0
	public bool Compress(int offset = 0) { }

	// RVA: 0x2923D50 Offset: 0x2923E51 VA: 0x2923D50
	public bool Decompress(int offset = 0) { }

	// RVA: 0x2924200 Offset: 0x2924301 VA: 0x2924200
	public void TestCompress() { }

	// RVA: 0x2924240 Offset: 0x2924341 VA: 0x2924240
	public void Dump(string name) { }

	// RVA: -1 Offset: -1
	public void WriteData<T>(T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2020020 Offset: 0x2020121 VA: 0x2020020
	|-Stream.WriteData<AccessoryData>
	|-Stream.WriteData<GodData>
	|-Stream.WriteData<ItemData>
	|-Stream.WriteData<JobData>
	|-Stream.WriteData<object>
	|-Stream.WriteData<PersonData>
	|-Stream.WriteData<ProfileCardBgData>
	|-Stream.WriteData<ProfileCardCharacterStampData>
	|-Stream.WriteData<ProfileCardCommentData>
	|-Stream.WriteData<ProfileCardFavoriteCharacterData>
	|-Stream.WriteData<ProfileCardFavoriteMapData>
	|-Stream.WriteData<ProfileCardFrameData>
	|-Stream.WriteData<ProfileCardStampData>
	|-Stream.WriteData<ProfileCardTextColorData>
	|-Stream.WriteData<ProfileCardTextDecoData>
	|-Stream.WriteData<ProfileCardThemeOfEditMapData>
	|-Stream.WriteData<ProfileCardTitleData>
	|-Stream.WriteData<RingData>
	|-Stream.WriteData<SkillData>
	*/

	// RVA: -1 Offset: -1
	public T ReadData<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201FAC0 Offset: 0x201FBC1 VA: 0x201FAC0
	|-Stream.ReadData<AccessoryData>
	|-Stream.ReadData<GodData>
	|-Stream.ReadData<ItemData>
	|-Stream.ReadData<JobData>
	|-Stream.ReadData<object>
	|-Stream.ReadData<PersonData>
	|-Stream.ReadData<ProfileCardBgData>
	|-Stream.ReadData<ProfileCardCharacterStampData>
	|-Stream.ReadData<ProfileCardCommentData>
	|-Stream.ReadData<ProfileCardFavoriteCharacterData>
	|-Stream.ReadData<ProfileCardFavoriteMapData>
	|-Stream.ReadData<ProfileCardFrameData>
	|-Stream.ReadData<ProfileCardStampData>
	|-Stream.ReadData<ProfileCardTextColorData>
	|-Stream.ReadData<ProfileCardTextDecoData>
	|-Stream.ReadData<ProfileCardThemeOfEditMapData>
	|-Stream.ReadData<ProfileCardTitleData>
	|-Stream.ReadData<RelayData>
	|-Stream.ReadData<RelayStampData>
	|-Stream.ReadData<RingData>
	|-Stream.ReadData<SkillData>
	*/

	// RVA: -1 Offset: -1
	public void WriteArray<T>(StructDataArrayList<T> array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201FFA0 Offset: 0x20200A1 VA: 0x201FFA0
	|-Stream.WriteArray<object>
	*/

	// RVA: -1 Offset: -1
	public StructDataArrayList<T> ReadArray<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x201F5E0 Offset: 0x201F6E1 VA: 0x201F5E0
	|-Stream.ReadArray<object>
	*/
}

