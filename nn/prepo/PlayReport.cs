// Namespace: nn.prepo
public static class PlayReport // TypeDefIndex: 14524
{
	// Methods

	// RVA: 0x29D1FD0 Offset: 0x29D20D1 VA: 0x29D1FD0
	public static extern void Begin(string eventId) { }

	// RVA: 0x29D2000 Offset: 0x29D2101 VA: 0x29D2000
	public static extern Result End() { }

	// RVA: 0x29D2020 Offset: 0x29D2121 VA: 0x29D2020
	public static extern Result End(Uid uid) { }

	// RVA: 0x29D2040 Offset: 0x29D2141 VA: 0x29D2040
	public static extern Result Add(string key, long val) { }

	// RVA: 0x29D2080 Offset: 0x29D2181 VA: 0x29D2080
	public static extern Result Add(string key, ulong val) { }

	// RVA: 0x29D20C0 Offset: 0x29D21C1 VA: 0x29D20C0
	public static extern Result Add(string key, float val) { }

	// RVA: 0x29D2110 Offset: 0x29D2211 VA: 0x29D2110
	public static extern Result Add(string key, double val) { }

	// RVA: 0x29D2160 Offset: 0x29D2261 VA: 0x29D2160
	public static extern Result Add(string key, string val) { }

	// RVA: 0x29D21C0 Offset: 0x29D22C1 VA: 0x29D21C0
	public static extern Result Add(string key, bool val) { }

	// RVA: 0x29D2200 Offset: 0x29D2301 VA: 0x29D2200
	public static extern Result Add(string key, byte[] val, long length) { }

	// RVA: 0x29D2260 Offset: 0x29D2361 VA: 0x29D2260
	public static extern Result AddStruct(string key) { }

	// RVA: 0x29D22A0 Offset: 0x29D23A1 VA: 0x29D22A0
	public static extern int GetCount() { }

	// RVA: 0x29D22B0 Offset: 0x29D23B1 VA: 0x29D22B0
	public static extern long GetSize() { }
}

