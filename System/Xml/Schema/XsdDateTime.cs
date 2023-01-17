// Namespace: System.Xml.Schema
internal struct XsdDateTime // TypeDefIndex: 2077
{
	// Fields
	private DateTime dt; // 0x0
	private uint extra; // 0x8
	private static readonly int Lzyyyy; // 0x0
	private static readonly int Lzyyyy_; // 0x4
	private static readonly int Lzyyyy_MM; // 0x8
	private static readonly int Lzyyyy_MM_; // 0xC
	private static readonly int Lzyyyy_MM_dd; // 0x10
	private static readonly int Lzyyyy_MM_ddT; // 0x14
	private static readonly int LzHH; // 0x18
	private static readonly int LzHH_; // 0x1C
	private static readonly int LzHH_mm; // 0x20
	private static readonly int LzHH_mm_; // 0x24
	private static readonly int LzHH_mm_ss; // 0x28
	private static readonly int Lz_; // 0x2C
	private static readonly int Lz_zz; // 0x30
	private static readonly int Lz_zz_; // 0x34
	private static readonly int Lz_zz_zz; // 0x38
	private static readonly int Lz__; // 0x3C
	private static readonly int Lz__mm; // 0x40
	private static readonly int Lz__mm_; // 0x44
	private static readonly int Lz__mm__; // 0x48
	private static readonly int Lz__mm_dd; // 0x4C
	private static readonly int Lz___; // 0x50
	private static readonly int Lz___dd; // 0x54
	private static readonly XmlTypeCode[] typeCodes; // 0x58

	// Properties
	private XsdDateTime.DateTimeTypeCode InternalTypeCode { get; }
	private XsdDateTime.XsdDateTimeKind InternalKind { get; }
	public int Year { get; }
	public int Month { get; }
	public int Day { get; }
	public int Hour { get; }
	public int Minute { get; }
	public int Second { get; }
	public int Fraction { get; }
	public int ZoneHour { get; }
	public int ZoneMinute { get; }

	// Methods

	// RVA: 0x1A05220 Offset: 0x1A05321 VA: 0x1A05220
	public void .ctor(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x1A05430 Offset: 0x1A05531 VA: 0x1A05430
	private void .ctor(XsdDateTime.Parser parser) { }

	// RVA: 0x1A053A0 Offset: 0x1A054A1 VA: 0x1A053A0
	private void InitiateXsdDateTime(XsdDateTime.Parser parser) { }

	// RVA: 0x1A054D0 Offset: 0x1A055D1 VA: 0x1A054D0
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

	// RVA: 0x1A055B0 Offset: 0x1A056B1 VA: 0x1A055B0
	public void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0x1A05700 Offset: 0x1A05801 VA: 0x1A05700
	public void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0x1A05820 Offset: 0x1A05921 VA: 0x1A05820
	private XsdDateTime.DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0x1A05830 Offset: 0x1A05931 VA: 0x1A05830
	private XsdDateTime.XsdDateTimeKind get_InternalKind() { }

	// RVA: 0x1A05840 Offset: 0x1A05941 VA: 0x1A05840
	public int get_Year() { }

	// RVA: 0x1A05850 Offset: 0x1A05951 VA: 0x1A05850
	public int get_Month() { }

	// RVA: 0x1A05860 Offset: 0x1A05961 VA: 0x1A05860
	public int get_Day() { }

	// RVA: 0x1A05870 Offset: 0x1A05971 VA: 0x1A05870
	public int get_Hour() { }

	// RVA: 0x1A05880 Offset: 0x1A05981 VA: 0x1A05880
	public int get_Minute() { }

	// RVA: 0x1A05890 Offset: 0x1A05991 VA: 0x1A05890
	public int get_Second() { }

	// RVA: 0x1A058A0 Offset: 0x1A059A1 VA: 0x1A058A0
	public int get_Fraction() { }

	// RVA: 0x1A05990 Offset: 0x1A05A91 VA: 0x1A05990
	public int get_ZoneHour() { }

	// RVA: 0x1A059A0 Offset: 0x1A05AA1 VA: 0x1A059A0
	public int get_ZoneMinute() { }

	// RVA: 0x1A059B0 Offset: 0x1A05AB1 VA: 0x1A059B0
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1A05E10 Offset: 0x1A05F11 VA: 0x1A05E10
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1A060A0 Offset: 0x1A061A1 VA: 0x1A060A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A067B0 Offset: 0x1A068B1 VA: 0x1A067B0
	private void PrintDate(StringBuilder sb) { }

	// RVA: 0x1A06A30 Offset: 0x1A06B31 VA: 0x1A06A30
	private void PrintTime(StringBuilder sb) { }

	// RVA: 0x1A06E10 Offset: 0x1A06F11 VA: 0x1A06E10
	private void PrintZone(StringBuilder sb) { }

	// RVA: 0x1A06D30 Offset: 0x1A06E31 VA: 0x1A06D30
	private void IntToCharArray(char[] text, int start, int value, int digits) { }

	// RVA: 0x1A06DA0 Offset: 0x1A06EA1 VA: 0x1A06DA0
	private void ShortToCharArray(char[] text, int start, int value) { }

	// RVA: 0x1A07050 Offset: 0x1A07151 VA: 0x1A07050
	private static void .cctor() { }
}

