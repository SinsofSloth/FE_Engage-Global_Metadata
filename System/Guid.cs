// Namespace: System
[ComVisibleAttribute] // RVA: 0x470300 Offset: 0x470401 VA: 0x470300
[Serializable]
public struct Guid : IFormattable, IComparable, IComparable<Guid>, IEquatable<Guid> // TypeDefIndex: 245
{
	// Fields
	public static readonly Guid Empty; // 0x0
	private int _a; // 0x0
	private short _b; // 0x4
	private short _c; // 0x6
	private byte _d; // 0x8
	private byte _e; // 0x9
	private byte _f; // 0xA
	private byte _g; // 0xB
	private byte _h; // 0xC
	private byte _i; // 0xD
	private byte _j; // 0xE
	private byte _k; // 0xF
	private static object _rngAccess; // 0x10
	private static RandomNumberGenerator _rng; // 0x18
	private static RandomNumberGenerator _fastRng; // 0x20

	// Methods

	// RVA: 0x38BA350 Offset: 0x38BA451 VA: 0x38BA350
	public void .ctor(byte[] b) { }

	// RVA: 0x38BA540 Offset: 0x38BA641 VA: 0x38BA540
	public void .ctor(int a, short b, short c, byte[] d) { }

	// RVA: 0x38BA710 Offset: 0x38BA811 VA: 0x38BA710
	public void .ctor(int a, short b, short c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k) { }

	// RVA: 0x38BA750 Offset: 0x38BA851 VA: 0x38BA750
	public void .ctor(string g) { }

	// RVA: 0x38BAAF0 Offset: 0x38BABF1 VA: 0x38BAAF0
	public static Guid Parse(string input) { }

	// RVA: 0x38BAC00 Offset: 0x38BAD01 VA: 0x38BAC00
	public static bool TryParse(string input, out Guid result) { }

	// RVA: 0x38BA880 Offset: 0x38BA981 VA: 0x38BA880
	private static bool TryParseGuid(string g, Guid.GuidStyles flags, ref Guid.GuidResult result) { }

	// RVA: 0x38BB180 Offset: 0x38BB281 VA: 0x38BB180
	private static bool TryParseGuidWithHexPrefix(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x38BB7E0 Offset: 0x38BB8E1 VA: 0x38BB7E0
	private static bool TryParseGuidWithNoStyle(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x38BACF0 Offset: 0x38BADF1 VA: 0x38BACF0
	private static bool TryParseGuidWithDashes(string guidString, ref Guid.GuidResult result) { }

	// RVA: 0x38BBEE0 Offset: 0x38BBFE1 VA: 0x38BBEE0
	private static bool StringToShort(string str, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x38BC120 Offset: 0x38BC221 VA: 0x38BC120
	private static bool StringToShort(string str, int* parsePos, int requiredLength, int flags, out short result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x38BBE40 Offset: 0x38BBF41 VA: 0x38BBE40
	private static bool StringToInt(string str, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x38BC080 Offset: 0x38BC181 VA: 0x38BC080
	private static bool StringToInt(string str, ref int parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x38BC1E0 Offset: 0x38BC2E1 VA: 0x38BC1E0
	private static bool StringToInt(string str, int* parsePos, int requiredLength, int flags, out int result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x38BBFE0 Offset: 0x38BC0E1 VA: 0x38BBFE0
	private static bool StringToLong(string str, ref int parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x38BC3F0 Offset: 0x38BC4F1 VA: 0x38BC3F0
	private static bool StringToLong(string str, int* parsePos, int flags, out long result, ref Guid.GuidResult parseResult) { }

	// RVA: 0x38BBBF0 Offset: 0x38BBCF1 VA: 0x38BBBF0
	private static string EatAllWhitespace(string str) { }

	// RVA: 0x38BBD20 Offset: 0x38BBE21 VA: 0x38BBD20
	private static bool IsHexPrefix(string str, int i) { }

	// RVA: 0x38BC570 Offset: 0x38BC671 VA: 0x38BC570
	public byte[] ToByteArray() { }

	// RVA: 0x38BC6E0 Offset: 0x38BC7E1 VA: 0x38BC6E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x38BCF60 Offset: 0x38BD061 VA: 0x38BCF60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x38BCF90 Offset: 0x38BD091 VA: 0x38BCF90 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x38BD0C0 Offset: 0x38BD1C1 VA: 0x38BD0C0 Slot: 7
	public bool Equals(Guid g) { }

	// RVA: 0x38BD170 Offset: 0x38BD271 VA: 0x38BD170
	private int GetResult(uint me, uint them) { }

	// RVA: 0x38BD180 Offset: 0x38BD281 VA: 0x38BD180 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x38BD320 Offset: 0x38BD421 VA: 0x38BD320 Slot: 6
	public int CompareTo(Guid value) { }

	// RVA: 0x38BD420 Offset: 0x38BD521 VA: 0x38BD420
	public static bool op_Equality(Guid a, Guid b) { }

	// RVA: 0x38BD4D0 Offset: 0x38BD5D1 VA: 0x38BD4D0
	public string ToString(string format) { }

	// RVA: 0x38BD4E0 Offset: 0x38BD5E1 VA: 0x38BD4E0
	private static char HexToChar(int a) { }

	// RVA: 0x38BD500 Offset: 0x38BD601 VA: 0x38BD500
	private static int HexsToChars(char* guidChars, int offset, int a, int b) { }

	// RVA: 0x38BD590 Offset: 0x38BD691 VA: 0x38BD590
	private static int HexsToChars(char* guidChars, int offset, int a, int b, bool hex) { }

	// RVA: 0x38BC740 Offset: 0x38BC841 VA: 0x38BC740 Slot: 4
	public string ToString(string format, IFormatProvider provider) { }

	// RVA: 0x38BD710 Offset: 0x38BD811 VA: 0x38BD710
	public static Guid NewGuid() { }

	// RVA: 0x38BD930 Offset: 0x38BDA31 VA: 0x38BD930
	private static void .cctor() { }
}

