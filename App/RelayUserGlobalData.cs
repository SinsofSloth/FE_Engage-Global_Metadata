// Namespace: App
public class RelayUserGlobalData : SingletonClass<RelayUserGlobalData> // TypeDefIndex: 12869
{
	// Fields
	public const uint MaxTicketCount = 999;
	public const long InitTicketLastTime = 0;
	private const int InitDailyTicketCount = 1;
	private uint m_DailyTicketCount; // 0x1C
	private Dictionary<ulong, RelayUserGlobalData.Ticket> m_TicketDict; // 0x20
	private RelayUserGlobalData.Uncommitted m_Uncommitted; // 0x28

	// Properties
	public uint DailyTicketCount { get; set; }
	protected override int Version { get; }

	// Methods

	// RVA: 0x24C8320 Offset: 0x24C8421 VA: 0x24C8320
	public void .ctor() { }

	// RVA: 0x24C8450 Offset: 0x24C8551 VA: 0x24C8450
	public void Clear() { }

	// RVA: 0x24C84C0 Offset: 0x24C85C1 VA: 0x24C84C0
	public void ClearForGame() { }

	// RVA: 0x24C84D0 Offset: 0x24C85D1 VA: 0x24C84D0
	public void CleanupUnused(ProcInst super) { }

	// RVA: 0x24C8550 Offset: 0x24C8651 VA: 0x24C8550
	public void UpdateData() { }

	// RVA: 0x24C86E0 Offset: 0x24C87E1 VA: 0x24C86E0
	public void DeleteData(ulong identifier) { }

	// RVA: 0x24C8780 Offset: 0x24C8881 VA: 0x24C8780
	public void AddTicketCount(int count = 1) { }

	// RVA: 0x24C87F0 Offset: 0x24C88F1 VA: 0x24C87F0
	public void SubTicketCount(int count = 1) { }

	// RVA: 0x24C7570 Offset: 0x24C7671 VA: 0x24C7570
	public uint GetTicketCount() { }

	// RVA: 0x24C8860 Offset: 0x24C8961 VA: 0x24C8860
	public void SetTicketLastTime(long unixTime) { }

	// RVA: 0x24C8870 Offset: 0x24C8971 VA: 0x24C8870
	public long GetTicketLastTime() { }

	// RVA: 0x24C8970 Offset: 0x24C8A71 VA: 0x24C8970
	public static long GetTicketCurrentTime() { }

	// RVA: 0x24C89A0 Offset: 0x24C8AA1 VA: 0x24C89A0
	public uint get_DailyTicketCount() { }

	// RVA: 0x24C89B0 Offset: 0x24C8AB1 VA: 0x24C89B0
	public void set_DailyTicketCount(uint value) { }

	// RVA: 0x24C89C0 Offset: 0x24C8AC1 VA: 0x24C89C0 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x24C89D0 Offset: 0x24C8AD1 VA: 0x24C89D0 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x24C8B60 Offset: 0x24C8C61 VA: 0x24C8B60 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x24C8DF0 Offset: 0x24C8EF1 VA: 0x24C8DF0
	public void SerializeUncommitted(Stream stream) { }

	// RVA: 0x24C8E00 Offset: 0x24C8F01 VA: 0x24C8E00
	public void DeserializeUncommitted(Stream stream) { }

	// RVA: 0x24C8E10 Offset: 0x24C8F11 VA: 0x24C8E10
	public void ClearUncommitted() { }

	[ConditionalAttribute] // RVA: 0x2CA160 Offset: 0x2CA261 VA: 0x2CA160
	// RVA: 0x24C8E20 Offset: 0x24C8F21 VA: 0x24C8E20
	public void DbgDump(ProcInst super) { }

	[ConditionalAttribute] // RVA: 0x2CA1A0 Offset: 0x2CA2A1 VA: 0x2CA1A0
	// RVA: 0x24C8E30 Offset: 0x24C8F31 VA: 0x24C8E30
	public void DbgAddSubTicketCountTest() { }
}

