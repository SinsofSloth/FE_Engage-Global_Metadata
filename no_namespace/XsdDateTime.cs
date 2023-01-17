// Namespace: 
private enum XsdDateTime.DateTimeTypeCode // TypeDefIndex: 2074
{
	// Fields
	public int value__; // 0x0
	public const XsdDateTime.DateTimeTypeCode DateTime = 0;
	public const XsdDateTime.DateTimeTypeCode Time = 1;
	public const XsdDateTime.DateTimeTypeCode Date = 2;
	public const XsdDateTime.DateTimeTypeCode GYearMonth = 3;
	public const XsdDateTime.DateTimeTypeCode GYear = 4;
	public const XsdDateTime.DateTimeTypeCode GMonthDay = 5;
	public const XsdDateTime.DateTimeTypeCode GDay = 6;
	public const XsdDateTime.DateTimeTypeCode GMonth = 7;
	public const XsdDateTime.DateTimeTypeCode XdrDateTime = 8;
}

// Namespace: 
private enum XsdDateTime.XsdDateTimeKind // TypeDefIndex: 2075
{
	// Fields
	public int value__; // 0x0
	public const XsdDateTime.XsdDateTimeKind Unspecified = 0;
	public const XsdDateTime.XsdDateTimeKind Zulu = 1;
	public const XsdDateTime.XsdDateTimeKind LocalWestOfZulu = 2;
	public const XsdDateTime.XsdDateTimeKind LocalEastOfZulu = 3;
}

// Namespace: 
private struct XsdDateTime.Parser // TypeDefIndex: 2076
{
	// Fields
	public XsdDateTime.DateTimeTypeCode typeCode; // 0x0
	public int year; // 0x4
	public int month; // 0x8
	public int day; // 0xC
	public int hour; // 0x10
	public int minute; // 0x14
	public int second; // 0x18
	public int fraction; // 0x1C
	public XsdDateTime.XsdDateTimeKind kind; // 0x20
	public int zoneHour; // 0x24
	public int zoneMinute; // 0x28
	private string text; // 0x30
	private int length; // 0x38
	private static int[] Power10; // 0x0

	// Methods

	// RVA: 0x19ABAF0 Offset: 0x19ABBF1 VA: 0x19ABAF0
	public bool Parse(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x19AC840 Offset: 0x19AC941 VA: 0x19AC840
	private bool ParseDate(int start) { }

	// RVA: 0x19ACB40 Offset: 0x19ACC41 VA: 0x19ACB40
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x19ACE80 Offset: 0x19ACF81 VA: 0x19ACE80
	private bool ParseTimeAndWhitespace(int start) { }

	// RVA: 0x19AD0B0 Offset: 0x19AD1B1 VA: 0x19AD0B0
	private bool ParseTime(ref int start) { }

	// RVA: 0x19ACB90 Offset: 0x19ACC91 VA: 0x19ACB90
	private bool ParseZoneAndWhitespace(int start) { }

	// RVA: 0x19ACEF0 Offset: 0x19ACFF1 VA: 0x19ACEF0
	private bool Parse4Dig(int start, ref int num) { }

	// RVA: 0x19AD000 Offset: 0x19AD101 VA: 0x19AD000
	private bool Parse2Dig(int start, ref int num) { }

	// RVA: 0x19ACAF0 Offset: 0x19ACBF1 VA: 0x19ACAF0
	private bool ParseChar(int start, char ch) { }

	// RVA: 0x19AC830 Offset: 0x19AC931 VA: 0x19AC830
	private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	// RVA: 0x19AD510 Offset: 0x19AD611 VA: 0x19AD510
	private static void .cctor() { }
}

