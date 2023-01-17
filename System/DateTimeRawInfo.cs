// Namespace: System
internal struct DateTimeRawInfo // TypeDefIndex: 235
{
	// Fields
	private int* num; // 0x0
	internal int numCount; // 0x8
	internal int month; // 0xC
	internal int year; // 0x10
	internal int dayOfWeek; // 0x14
	internal int era; // 0x18
	internal DateTimeParse.TM timeMark; // 0x1C
	internal double fraction; // 0x20
	internal bool hasSameDateAndTimeSeparators; // 0x28
	internal bool timeZone; // 0x29

	// Methods

	// RVA: 0x3719FD0 Offset: 0x371A0D1 VA: 0x3719FD0
	internal void Init(int* numberBuffer) { }

	// RVA: 0x3719FF0 Offset: 0x371A0F1 VA: 0x3719FF0
	internal void AddNumber(int value) { }

	// RVA: 0x371A010 Offset: 0x371A111 VA: 0x371A010
	internal int GetNumber(int index) { }
}

