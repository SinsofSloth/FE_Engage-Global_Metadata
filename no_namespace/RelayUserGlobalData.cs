// Namespace: 
public class RelayUserGlobalData.Ticket // TypeDefIndex: 12866
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29B8C0 Offset: 0x29B9C1 VA: 0x29B8C0
	private uint <Count>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29B8D0 Offset: 0x29B9D1 VA: 0x29B8D0
	private long <LastTime>k__BackingField; // 0x18

	// Properties
	public uint Count { get; set; }
	public long LastTime { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CA1E0 Offset: 0x2CA2E1 VA: 0x2CA1E0
	// RVA: 0x1F46930 Offset: 0x1F46A31 VA: 0x1F46930
	public uint get_Count() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA1F0 Offset: 0x2CA2F1 VA: 0x2CA1F0
	// RVA: 0x1F46940 Offset: 0x1F46A41 VA: 0x1F46940
	public void set_Count(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA200 Offset: 0x2CA301 VA: 0x2CA200
	// RVA: 0x1F46950 Offset: 0x1F46A51 VA: 0x1F46950
	public long get_LastTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CA210 Offset: 0x2CA311 VA: 0x2CA210
	// RVA: 0x1F46960 Offset: 0x1F46A61 VA: 0x1F46960
	public void set_LastTime(long value) { }

	// RVA: 0x1F46970 Offset: 0x1F46A71 VA: 0x1F46970
	public void Serialize(Stream stream) { }

	// RVA: 0x1F469B0 Offset: 0x1F46AB1 VA: 0x1F469B0
	public void Deserialize(Stream stream, int version) { }

	// RVA: 0x1F46B00 Offset: 0x1F46C01 VA: 0x1F46B00
	public void .ctor() { }
}

// Namespace: 
private class RelayUserGlobalData.ProcCleanupUnused : ProcInst // TypeDefIndex: 12868
{
	// Fields
	private GameSaveDataHeaderReader m_HeaderReader; // 0x70

	// Methods

	// RVA: 0x1F461B0 Offset: 0x1F462B1 VA: 0x1F461B0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x1F46200 Offset: 0x1F46301 VA: 0x1F46200
	private void ReadHeader() { }

	// RVA: 0x1F46280 Offset: 0x1F46381 VA: 0x1F46280
	private bool IsReadingHeader() { }

	// RVA: 0x1F46350 Offset: 0x1F46451 VA: 0x1F46350
	private void Cleanup() { }

	// RVA: 0x1F46670 Offset: 0x1F46771 VA: 0x1F46670
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1F46920 Offset: 0x1F46A21 VA: 0x1F46920
	public void .ctor() { }
}

