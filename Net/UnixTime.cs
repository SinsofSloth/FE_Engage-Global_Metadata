// Namespace: Net
internal static class UnixTime // TypeDefIndex: 8288
{
	// Fields
	private static readonly DateTime BaseUnixTime; // 0x0

	// Methods

	// RVA: 0x20AA7C0 Offset: 0x20AA8C1 VA: 0x20AA7C0
	public static void Initialize() { }

	// RVA: 0x20AA7D0 Offset: 0x20AA8D1 VA: 0x20AA7D0
	public static void Cleanup() { }

	// RVA: 0x20AA7E0 Offset: 0x20AA8E1 VA: 0x20AA7E0
	public static long Get() { }

	// RVA: 0x20AA8C0 Offset: 0x20AA9C1 VA: 0x20AA8C0
	public static long GetFromNetworkClock() { }

	// RVA: 0x20AA9F0 Offset: 0x20AAAF1 VA: 0x20AA9F0
	public static bool TryGetFromNetworkClock(out long unixTime) { }

	// RVA: 0x20AAA30 Offset: 0x20AAB31 VA: 0x20AAA30
	public static long GetFromNpDateTime(NpDateTime npDateTime) { }

	// RVA: 0x20AAB40 Offset: 0x20AAC41 VA: 0x20AAB40
	public static string ToString(long unixTime, string format) { }

	// RVA: 0x20AAC20 Offset: 0x20AAD21 VA: 0x20AAC20
	public static string ToStringUtc(long unixTime, string format) { }

	// RVA: 0x20AACF0 Offset: 0x20AADF1 VA: 0x20AACF0
	public static DateTime ToLocalTime(long unixTime) { }

	// RVA: 0x20AADA0 Offset: 0x20AAEA1 VA: 0x20AADA0
	private static void .cctor() { }
}

