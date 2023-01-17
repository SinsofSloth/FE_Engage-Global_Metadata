// Namespace: System
internal struct DateTimeResult // TypeDefIndex: 238
{
	// Fields
	internal int Year; // 0x0
	internal int Month; // 0x4
	internal int Day; // 0x8
	internal int Hour; // 0xC
	internal int Minute; // 0x10
	internal int Second; // 0x14
	internal double fraction; // 0x18
	internal int era; // 0x20
	internal ParseFlags flags; // 0x24
	internal TimeSpan timeZoneOffset; // 0x28
	internal Calendar calendar; // 0x30
	internal DateTime parsedDate; // 0x38
	internal ParseFailureKind failure; // 0x40
	internal string failureMessageID; // 0x48
	internal object failureMessageFormatArgument; // 0x50
	internal string failureArgumentName; // 0x58

	// Methods

	// RVA: 0x371A020 Offset: 0x371A121 VA: 0x371A020
	internal void Init() { }

	// RVA: 0x371A040 Offset: 0x371A141 VA: 0x371A040
	internal void SetDate(int year, int month, int day) { }

	// RVA: 0x371A050 Offset: 0x371A151 VA: 0x371A050
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument) { }

	// RVA: 0x371A090 Offset: 0x371A191 VA: 0x371A090
	internal void SetFailure(ParseFailureKind failure, string failureMessageID, object failureMessageFormatArgument, string failureArgumentName) { }
}

