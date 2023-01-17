// Namespace: 
internal enum TimeSpanFormat.Pattern // TypeDefIndex: 711
{
	// Fields
	public int value__; // 0x0
	public const TimeSpanFormat.Pattern None = 0;
	public const TimeSpanFormat.Pattern Minimum = 1;
	public const TimeSpanFormat.Pattern Full = 2;
}

// Namespace: 
internal struct TimeSpanFormat.FormatLiterals // TypeDefIndex: 712
{
	// Fields
	internal string AppCompatLiteral; // 0x0
	internal int dd; // 0x8
	internal int hh; // 0xC
	internal int mm; // 0x10
	internal int ss; // 0x14
	internal int ff; // 0x18
	private string[] literals; // 0x20

	// Properties
	internal string Start { get; }
	internal string DayHourSep { get; }
	internal string HourMinuteSep { get; }
	internal string MinuteSecondSep { get; }
	internal string SecondFractionSep { get; }
	internal string End { get; }

	// Methods

	// RVA: 0x1C09130 Offset: 0x1C09231 VA: 0x1C09130
	internal string get_Start() { }

	// RVA: 0x1C09160 Offset: 0x1C09261 VA: 0x1C09160
	internal string get_DayHourSep() { }

	// RVA: 0x1C09190 Offset: 0x1C09291 VA: 0x1C09190
	internal string get_HourMinuteSep() { }

	// RVA: 0x1C091C0 Offset: 0x1C092C1 VA: 0x1C091C0
	internal string get_MinuteSecondSep() { }

	// RVA: 0x1C091F0 Offset: 0x1C092F1 VA: 0x1C091F0
	internal string get_SecondFractionSep() { }

	// RVA: 0x1C09220 Offset: 0x1C09321 VA: 0x1C09220
	internal string get_End() { }

	// RVA: 0x1C09250 Offset: 0x1C09351 VA: 0x1C09250
	internal static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative) { }

	// RVA: 0x1C09550 Offset: 0x1C09651 VA: 0x1C09550
	internal void Init(string format, bool useInvariantFieldLengths) { }
}

