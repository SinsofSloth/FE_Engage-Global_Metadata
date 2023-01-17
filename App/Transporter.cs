// Namespace: App
public class Transporter // TypeDefIndex: 13483
{
	// Fields
	public const int MaxOld = 500;
	public const int MaxData = 999;
	private const int Version = 1;
	private static Transporter.Data[] s_Data; // 0x0

	// Methods

	// RVA: 0x2870F60 Offset: 0x2871061 VA: 0x2870F60
	public static void Initialize() { }

	// RVA: 0x2871080 Offset: 0x2871181 VA: 0x2871080
	public static void Reset() { }

	// RVA: 0x28711D0 Offset: 0x28712D1 VA: 0x28711D0
	public static bool IsAvailable() { }

	// RVA: 0x28712D0 Offset: 0x28713D1 VA: 0x28712D0
	public static Transporter.Data Get(int index) { }

	// RVA: 0x2871350 Offset: 0x2871451 VA: 0x2871350
	public static int GetIndex(UnitItem unitItem) { }

	// RVA: 0x2871470 Offset: 0x2871571 VA: 0x2871470
	public static bool CanAdd() { }

	// RVA: 0x2871510 Offset: 0x2871611 VA: 0x2871510
	public static bool TryGetLowestItemIndex(out int lowestIndex, out ulong lowestWorth) { }

	// RVA: 0x2871890 Offset: 0x2871991 VA: 0x2871890
	public static int GetEmptyIndex() { }

	// RVA: 0x2871930 Offset: 0x2871A31 VA: 0x2871930
	private static void Discard(UnitItem unitItem) { }

	// RVA: 0x2871A70 Offset: 0x2871B71 VA: 0x2871A70
	public static int Add(UnitItem unitItem) { }

	// RVA: 0x2871F40 Offset: 0x2872041 VA: 0x2871F40
	public static int Add(ItemData itemData) { }

	// RVA: 0x2871FC0 Offset: 0x28720C1 VA: 0x2871FC0
	public static void Sub(int index) { }

	// RVA: 0x2872160 Offset: 0x2872261 VA: 0x2872160
	public static void Delete(int index) { }

	// RVA: 0x2872290 Offset: 0x2872391 VA: 0x2872290
	public static void Clear() { }

	// RVA: 0x28723E0 Offset: 0x28724E1 VA: 0x28723E0
	public static int GetCount() { }

	// RVA: 0x2872470 Offset: 0x2872571 VA: 0x2872470
	public static void DeleteItem(ItemData data) { }

	// RVA: 0x2872530 Offset: 0x2872631 VA: 0x2872530
	public static int GetItemCount(ItemData data) { }

	// RVA: 0x28725D0 Offset: 0x28726D1 VA: 0x28725D0
	public static int GetTypeItemCount(ItemData.UseTypes type) { }

	// RVA: 0x2872680 Offset: 0x2872781 VA: 0x2872680
	public static void Serialize(Stream stream) { }

	// RVA: 0x2872740 Offset: 0x2872841 VA: 0x2872740
	public static void Deserialize(Stream stream) { }

	// RVA: 0x2871740 Offset: 0x2871841 VA: 0x2871740
	private static bool IsRare(UnitItem unitItem) { }

	// RVA: 0x28717B0 Offset: 0x28718B1 VA: 0x28717B0
	public static ulong CalcWorth(UnitItem unitItem) { }

	// RVA: 0x2872B00 Offset: 0x2872C01 VA: 0x2872B00
	public void .ctor() { }
}

