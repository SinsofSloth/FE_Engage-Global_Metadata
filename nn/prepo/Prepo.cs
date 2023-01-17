// Namespace: nn.prepo
public static class Prepo // TypeDefIndex: 14522
{
	// Fields
	public const int KeyValueCountMax = 100;
	public const long EventIdLengthMax = 31;
	public const long KeyLengthMax = 63;
	public const long KeySizeMax = 65;
	public const long PrimitiveValueSizeMax = 10;
	public const long PrimitiveKeyValueSizeMax = 75;
	public const long ReportBufferSizeMin = 3;
	public const long StringBufferSizeMin = 3;
	public const long BinaryBufferSizeMin = 3;
	public const long ArrayBufferSizeMin = 3;
	public const long StructBufferSizeMin = 3;
	public const long ReportBufferSizeMax = 16384;

	// Methods

	// RVA: 0x29D8BD0 Offset: 0x29D8CD1 VA: 0x29D8BD0
	public static extern void Initialize(long playReportBufferSize) { }

	// RVA: 0x29D8EF0 Offset: 0x29D8FF1 VA: 0x29D8EF0
	public static extern Result RequestImmediateTransmission() { }
}

