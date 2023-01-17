// Namespace: System
internal sealed class NumberFormatter // TypeDefIndex: 384
{
	// Fields
	private static readonly ulong* MantissaBitsTable; // 0x0
	private static readonly int* TensExponentTable; // 0x8
	private static readonly char* DigitLowerTable; // 0x10
	private static readonly char* DigitUpperTable; // 0x18
	private static readonly long* TenPowersList; // 0x20
	private static readonly int* DecHexDigits; // 0x28
	private NumberFormatInfo _nfi; // 0x10
	private char[] _cbuf; // 0x18
	private bool _NaN; // 0x20
	private bool _infinity; // 0x21
	private bool _isCustomFormat; // 0x22
	private bool _specifierIsUpper; // 0x23
	private bool _positive; // 0x24
	private char _specifier; // 0x26
	private int _precision; // 0x28
	private int _defPrecision; // 0x2C
	private int _digitsLen; // 0x30
	private int _offset; // 0x34
	private int _decPointPos; // 0x38
	private uint _val1; // 0x3C
	private uint _val2; // 0x40
	private uint _val3; // 0x44
	private uint _val4; // 0x48
	private int _ind; // 0x4C
	[ThreadStaticAttribute] // RVA: 0x4781A0 Offset: 0x4782A1 VA: 0x4781A0
	private static NumberFormatter threadNumberFormatter; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x4781B0 Offset: 0x4782B1 VA: 0x4781B0
	private static NumberFormatter userFormatProvider; // 0x80000008

	// Properties
	private CultureInfo CurrentCulture { set; }
	private int IntegerDigits { get; }
	private int DecimalDigits { get; }
	private bool IsFloatingSource { get; }
	private bool IsZero { get; }
	private bool IsZeroInteger { get; }

	// Methods

	// RVA: 0x385BBB0 Offset: 0x385BCB1 VA: 0x385BBB0
	private static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits) { }

	// RVA: 0x385BBC0 Offset: 0x385BCC1 VA: 0x385BBC0
	private static void .cctor() { }

	// RVA: 0x385BC20 Offset: 0x385BD21 VA: 0x385BC20
	private static long GetTenPowerOf(int i) { }

	// RVA: 0x385BCA0 Offset: 0x385BDA1 VA: 0x385BCA0
	private void InitDecHexDigits(uint value) { }

	// RVA: 0x385BF10 Offset: 0x385C011 VA: 0x385BF10
	private void InitDecHexDigits(ulong value) { }

	// RVA: 0x385C030 Offset: 0x385C131 VA: 0x385C030
	private void InitDecHexDigits(uint hi, ulong lo) { }

	// RVA: 0x385BD60 Offset: 0x385BE61 VA: 0x385BD60
	private static uint FastToDecHex(int val) { }

	// RVA: 0x385BE40 Offset: 0x385BF41 VA: 0x385BE40
	private static uint ToDecHex(int val) { }

	// RVA: 0x385C210 Offset: 0x385C311 VA: 0x385C210
	private static int FastDecHexLen(int val) { }

	// RVA: 0x385C240 Offset: 0x385C341 VA: 0x385C240
	private static int DecHexLen(uint val) { }

	// RVA: 0x385C320 Offset: 0x385C421 VA: 0x385C320
	private int DecHexLen() { }

	// RVA: 0x385C6D0 Offset: 0x385C7D1 VA: 0x385C6D0
	private static int ScaleOrder(long hi) { }

	// RVA: 0x385C7C0 Offset: 0x385C8C1 VA: 0x385C7C0
	private int InitialFloatingPrecision() { }

	// RVA: 0x385C8B0 Offset: 0x385C9B1 VA: 0x385C8B0
	private static int ParsePrecision(string format) { }

	// RVA: 0x385C950 Offset: 0x385CA51 VA: 0x385C950
	private void .ctor(Thread current) { }

	// RVA: 0x385CAB0 Offset: 0x385CBB1 VA: 0x385CAB0
	private void Init(string format) { }

	// RVA: 0x385CC40 Offset: 0x385CD41 VA: 0x385CC40
	private void InitHex(ulong value) { }

	// RVA: 0x385CC90 Offset: 0x385CD91 VA: 0x385CC90
	private void Init(string format, int value, int defPrecision) { }

	// RVA: 0x385CD40 Offset: 0x385CE41 VA: 0x385CD40
	private void Init(string format, uint value, int defPrecision) { }

	// RVA: 0x385CDE0 Offset: 0x385CEE1 VA: 0x385CDE0
	private void Init(string format, long value) { }

	// RVA: 0x385CE80 Offset: 0x385CF81 VA: 0x385CE80
	private void Init(string format, ulong value) { }

	// RVA: 0x385CF10 Offset: 0x385D011 VA: 0x385CF10
	private void Init(string format, double value, int defPrecision) { }

	// RVA: 0x385D520 Offset: 0x385D621 VA: 0x385D520
	private void Init(string format, Decimal value) { }

	// RVA: 0x385D690 Offset: 0x385D791 VA: 0x385D690
	private void ResetCharBuf(int size) { }

	// RVA: 0x385D720 Offset: 0x385D821 VA: 0x385D720
	private void Resize(int len) { }

	// RVA: 0x385D780 Offset: 0x385D881 VA: 0x385D780
	private void Append(char c) { }

	// RVA: 0x385D840 Offset: 0x385D941 VA: 0x385D840
	private void Append(char c, int cnt) { }

	// RVA: 0x385D920 Offset: 0x385DA21 VA: 0x385D920
	private void Append(string s) { }

	// RVA: 0x385DA10 Offset: 0x385DB11 VA: 0x385DA10
	private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp) { }

	// RVA: 0x385CA40 Offset: 0x385CB41 VA: 0x385CA40
	private void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x385DA30 Offset: 0x385DB31 VA: 0x385DA30
	private int get_IntegerDigits() { }

	// RVA: 0x385DA40 Offset: 0x385DB41 VA: 0x385DA40
	private int get_DecimalDigits() { }

	// RVA: 0x385DA60 Offset: 0x385DB61 VA: 0x385DA60
	private bool get_IsFloatingSource() { }

	// RVA: 0x385DA80 Offset: 0x385DB81 VA: 0x385DA80
	private bool get_IsZero() { }

	// RVA: 0x385DA90 Offset: 0x385DB91 VA: 0x385DA90
	private bool get_IsZeroInteger() { }

	// RVA: 0x385DAB0 Offset: 0x385DBB1 VA: 0x385DAB0
	private void RoundPos(int pos) { }

	// RVA: 0x385DC70 Offset: 0x385DD71 VA: 0x385DC70
	private bool RoundDecimal(int decimals) { }

	// RVA: 0x385DAC0 Offset: 0x385DBC1 VA: 0x385DAC0
	private bool RoundBits(int shift) { }

	// RVA: 0x385E060 Offset: 0x385E161 VA: 0x385E060
	private void RemoveTrailingZeros() { }

	// RVA: 0x385DC90 Offset: 0x385DD91 VA: 0x385DC90
	private void AddOneToDecHex() { }

	// RVA: 0x385E0B0 Offset: 0x385E1B1 VA: 0x385E0B0
	private static uint AddOneToDecHex(uint val) { }

	// RVA: 0x385D2D0 Offset: 0x385D3D1 VA: 0x385D2D0
	private int CountTrailingZeros() { }

	// RVA: 0x385E160 Offset: 0x385E261 VA: 0x385E160
	private static int CountTrailingZeros(uint val) { }

	// RVA: 0x385E1B0 Offset: 0x385E2B1 VA: 0x385E1B0
	private static NumberFormatter GetInstance(IFormatProvider fp) { }

	// RVA: 0x385E3B0 Offset: 0x385E4B1 VA: 0x385E3B0
	private void Release() { }

	// RVA: 0x3857370 Offset: 0x3857471 VA: 0x3857370
	public static string NumberToString(string format, uint value, IFormatProvider fp) { }

	// RVA: 0x38571E0 Offset: 0x38572E1 VA: 0x38571E0
	public static string NumberToString(string format, int value, IFormatProvider fp) { }

	// RVA: 0x3857690 Offset: 0x3857791 VA: 0x3857690
	public static string NumberToString(string format, ulong value, IFormatProvider fp) { }

	// RVA: 0x3857500 Offset: 0x3857601 VA: 0x3857500
	public static string NumberToString(string format, long value, IFormatProvider fp) { }

	// RVA: 0x3857820 Offset: 0x3857921 VA: 0x3857820
	public static string NumberToString(string format, float value, IFormatProvider fp) { }

	// RVA: 0x3857040 Offset: 0x3857141 VA: 0x3857040
	public static string NumberToString(string format, double value, IFormatProvider fp) { }

	// RVA: 0x3856EF0 Offset: 0x3856FF1 VA: 0x3856EF0
	public static string NumberToString(string format, Decimal value, IFormatProvider fp) { }

	// RVA: 0x385E470 Offset: 0x385E571 VA: 0x385E470
	private string IntegerToString(string format, IFormatProvider fp) { }

	// RVA: 0x385E770 Offset: 0x385E871 VA: 0x385E770
	private string NumberToString(string format, NumberFormatInfo nfi) { }

	// RVA: 0x385EA80 Offset: 0x385EB81 VA: 0x385EA80
	private string FormatCurrency(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x385F210 Offset: 0x385F311 VA: 0x385F210
	private string FormatDecimal(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x385FDB0 Offset: 0x385FEB1 VA: 0x385FDB0
	private string FormatHexadecimal(int precision) { }

	// RVA: 0x385F390 Offset: 0x385F491 VA: 0x385F390
	private string FormatFixedPoint(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x385E920 Offset: 0x385EA21 VA: 0x385E920
	private string FormatRoundtrip(double origval, NumberFormatInfo nfi) { }

	// RVA: 0x385E690 Offset: 0x385E791 VA: 0x385E690
	private string FormatRoundtrip(float origval, NumberFormatInfo nfi) { }

	// RVA: 0x385F4D0 Offset: 0x385F5D1 VA: 0x385F4D0
	private string FormatGeneral(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x385F710 Offset: 0x385F811 VA: 0x385F710
	private string FormatNumber(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x385FAE0 Offset: 0x385FBE1 VA: 0x385FAE0
	private string FormatPercent(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x385F330 Offset: 0x385F431 VA: 0x385F330
	private string FormatExponential(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x3860D10 Offset: 0x3860E11 VA: 0x3860D10
	private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits) { }

	// RVA: 0x385FF80 Offset: 0x3860081 VA: 0x385FF80
	private string FormatCustom(string format, NumberFormatInfo nfi) { }

	// RVA: 0x38617F0 Offset: 0x38618F1 VA: 0x38617F0
	private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty) { }

	// RVA: 0x38616E0 Offset: 0x38617E1 VA: 0x38616E0
	private static bool IsZeroOnly(StringBuilder sb) { }

	// RVA: 0x38614B0 Offset: 0x38615B1 VA: 0x38614B0
	private static void AppendNonNegativeNumber(StringBuilder sb, int v) { }

	// RVA: 0x3861640 Offset: 0x3861741 VA: 0x3861640
	private void AppendIntegerString(int minLength, StringBuilder sb) { }

	// RVA: 0x3860AF0 Offset: 0x3860BF1 VA: 0x3860AF0
	private void AppendIntegerString(int minLength) { }

	// RVA: 0x38616C0 Offset: 0x38617C1 VA: 0x38616C0
	private void AppendDecimalString(int precision, StringBuilder sb) { }

	// RVA: 0x3860830 Offset: 0x3860931 VA: 0x3860830
	private void AppendDecimalString(int precision) { }

	// RVA: 0x3860540 Offset: 0x3860641 VA: 0x3860540
	private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator) { }

	// RVA: 0x3860F80 Offset: 0x3861081 VA: 0x3860F80
	private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits) { }

	// RVA: 0x3860E60 Offset: 0x3860F61 VA: 0x3860E60
	private void AppendOneDigit(int start) { }

	// RVA: 0x3860850 Offset: 0x3860951 VA: 0x3860850
	private void AppendDigits(int start, int end) { }

	// RVA: 0x38618E0 Offset: 0x38619E1 VA: 0x38618E0
	private void AppendDigits(int start, int end, StringBuilder sb) { }

	// RVA: 0x3860E40 Offset: 0x3860F41 VA: 0x3860E40
	private void Multiply10(int count) { }

	// RVA: 0x3861490 Offset: 0x3861591 VA: 0x3861490
	private void Divide10(int count) { }

	// RVA: 0x3860CA0 Offset: 0x3860DA1 VA: 0x3860CA0
	private NumberFormatter GetClone() { }
}

