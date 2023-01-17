// Namespace: System.Xml.Schema
internal struct XsdDuration // TypeDefIndex: 2080
{
	// Fields
	private int years; // 0x0
	private int months; // 0x4
	private int days; // 0x8
	private int hours; // 0xC
	private int minutes; // 0x10
	private int seconds; // 0x14
	private uint nanoseconds; // 0x18

	// Properties
	public bool IsNegative { get; }
	public int Years { get; }
	public int Months { get; }
	public int Days { get; }
	public int Hours { get; }
	public int Minutes { get; }
	public int Seconds { get; }
	public int Nanoseconds { get; }

	// Methods

	// RVA: 0x1A074A0 Offset: 0x1A075A1 VA: 0x1A074A0
	public void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	// RVA: 0x1A07610 Offset: 0x1A07711 VA: 0x1A07610
	public void .ctor(TimeSpan timeSpan, XsdDuration.DurationType durationType) { }

	// RVA: 0x1A077B0 Offset: 0x1A078B1 VA: 0x1A077B0
	public void .ctor(string s, XsdDuration.DurationType durationType) { }

	// RVA: 0x1A08700 Offset: 0x1A08801 VA: 0x1A08700
	public bool get_IsNegative() { }

	// RVA: 0x1A08710 Offset: 0x1A08811 VA: 0x1A08710
	public int get_Years() { }

	// RVA: 0x1A08720 Offset: 0x1A08821 VA: 0x1A08720
	public int get_Months() { }

	// RVA: 0x1A08730 Offset: 0x1A08831 VA: 0x1A08730
	public int get_Days() { }

	// RVA: 0x1A08740 Offset: 0x1A08841 VA: 0x1A08740
	public int get_Hours() { }

	// RVA: 0x1A08750 Offset: 0x1A08851 VA: 0x1A08750
	public int get_Minutes() { }

	// RVA: 0x1A08760 Offset: 0x1A08861 VA: 0x1A08760
	public int get_Seconds() { }

	// RVA: 0x1A086F0 Offset: 0x1A087F1 VA: 0x1A086F0
	public int get_Nanoseconds() { }

	// RVA: 0x1A08770 Offset: 0x1A08871 VA: 0x1A08770
	public TimeSpan ToTimeSpan(XsdDuration.DurationType durationType) { }

	// RVA: 0x1A08CD0 Offset: 0x1A08DD1 VA: 0x1A08CD0
	internal Exception TryToTimeSpan(out TimeSpan result) { }

	// RVA: 0x1A087C0 Offset: 0x1A088C1 VA: 0x1A087C0
	internal Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result) { }

	// RVA: 0x1A08CE0 Offset: 0x1A08DE1 VA: 0x1A08CE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A08CF0 Offset: 0x1A08DF1 VA: 0x1A08CF0
	internal string ToString(XsdDuration.DurationType durationType) { }

	// RVA: 0x1A09140 Offset: 0x1A09241 VA: 0x1A09140
	internal static Exception TryParse(string s, out XsdDuration result) { }

	// RVA: 0x1A07860 Offset: 0x1A07961 VA: 0x1A07860
	internal static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result) { }

	// RVA: 0x1A09150 Offset: 0x1A09251 VA: 0x1A09150
	private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits) { }
}

