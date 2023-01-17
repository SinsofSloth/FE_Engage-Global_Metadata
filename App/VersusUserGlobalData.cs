// Namespace: App
public class VersusUserGlobalData : SingletonClass<VersusUserGlobalData> // TypeDefIndex: 13781
{
	// Fields
	private const int ReportedListNum = 50;
	private List<ulong> m_ReportedList; // 0x20
	private ulong m_ReservedId; // 0x28

	// Properties
	protected override int Version { get; }

	// Methods

	// RVA: 0x26BE9E0 Offset: 0x26BEAE1 VA: 0x26BE9E0
	public void .ctor() { }

	// RVA: 0x26BEAF0 Offset: 0x26BEBF1 VA: 0x26BEAF0
	public void Clear() { }

	// RVA: 0x26BEB50 Offset: 0x26BEC51 VA: 0x26BEB50
	public void AddReportedIDReserve(ulong id) { }

	// RVA: 0x26BEB60 Offset: 0x26BEC61 VA: 0x26BEB60
	public bool ContainsReportedList(ulong id) { }

	// RVA: 0x26BEBC0 Offset: 0x26BECC1 VA: 0x26BEBC0
	public void Commit() { }

	// RVA: 0x26BEBD0 Offset: 0x26BECD1 VA: 0x26BEBD0
	private void AddReportedID(ulong id) { }

	[ConditionalAttribute] // RVA: 0x2CD560 Offset: 0x2CD661 VA: 0x2CD560
	// RVA: 0x26BECB0 Offset: 0x26BEDB1 VA: 0x26BECB0
	public void Dump() { }

	// RVA: 0x26BEEB0 Offset: 0x26BEFB1 VA: 0x26BEEB0 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x26BEEC0 Offset: 0x26BEFC1 VA: 0x26BEEC0 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x26BEF80 Offset: 0x26BF081 VA: 0x26BEF80 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	[ConditionalAttribute] // RVA: 0x2CD5A0 Offset: 0x2CD6A1 VA: 0x2CD5A0
	// RVA: 0x26BF150 Offset: 0x26BF251 VA: 0x26BF150
	private void Log(string mess) { }
}

