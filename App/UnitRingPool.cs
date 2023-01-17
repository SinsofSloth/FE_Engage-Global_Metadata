// Namespace: App
public class UnitRingPool : SingletonPool<UnitRingPool, UnitRing> // TypeDefIndex: 13545
{
	// Fields
	public const int MaxRingCount = 700;
	public const int MaxOwnerCount = 50;
	public const int MaxTotalCount = 750;

	// Properties
	protected override int Version { get; }

	// Methods

	// RVA: 0x208CE60 Offset: 0x208CF61 VA: 0x208CE60
	public void .ctor() { }

	// RVA: 0x208CEC0 Offset: 0x208CFC1 VA: 0x208CEC0 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x208CED0 Offset: 0x208CFD1 VA: 0x208CED0
	public static UnitRing TryGet(string rnid, Unit owner) { }

	// RVA: 0x208CFD0 Offset: 0x208D0D1 VA: 0x208CFD0
	public static UnitRing TryGet(RingData data, Unit owner) { }

	// RVA: 0x208D1B0 Offset: 0x208D2B1 VA: 0x208D1B0
	public static int GetAllStockCount(RingData data) { }

	// RVA: 0x208D350 Offset: 0x208D451 VA: 0x208D350
	public static int GetStockCount(RingData data, bool IsEquipped) { }

	// RVA: 0x208D580 Offset: 0x208D681 VA: 0x208D580
	public static bool CanAdd(string rnid, int stockCount = 1) { }

	// RVA: 0x208D630 Offset: 0x208D731 VA: 0x208D630
	public static bool CanAdd(UnitRing ring, int stockCount = 1) { }

	// RVA: 0x208D690 Offset: 0x208D791 VA: 0x208D690
	public static UnitRing Add(string rnid, Unit owner, int stockCount = 1) { }

	// RVA: 0x208D7B0 Offset: 0x208D8B1 VA: 0x208D7B0
	public static void Add(UnitRing ring, int stockCount = 1) { }

	// RVA: 0x208D820 Offset: 0x208D921 VA: 0x208D820
	public static void Sub(string rnid, Unit unit, int stockCount = 1) { }

	// RVA: 0x208D860 Offset: 0x208D961 VA: 0x208D860
	public static void Sub(UnitRing ring, int stockCount = 1) { }

	// RVA: 0x208D9A0 Offset: 0x208DAA1 VA: 0x208D9A0
	public static void SetOwner(string rnid, Unit owner) { }

	// RVA: 0x208D9D0 Offset: 0x208DAD1 VA: 0x208D9D0
	public static void SetOwner(UnitRing ring, Unit owner) { }

	// RVA: 0x208DAA0 Offset: 0x208DBA1 VA: 0x208DAA0
	public static void ClearOwner(string rnid, Unit owner) { }

	// RVA: 0x208DB10 Offset: 0x208DC11 VA: 0x208DB10
	public static void ClearOwner(UnitRing ring) { }

	// RVA: 0x208DB70 Offset: 0x208DC71 VA: 0x208DB70
	public static UnitRing Composite(UnitRing baseRing, UnitRing[] rings) { }

	// RVA: 0x208DC70 Offset: 0x208DD71 VA: 0x208DC70
	public static void Delete(string rnid, Unit owner) { }

	// RVA: 0x208D930 Offset: 0x208DA31 VA: 0x208D930
	public static void Delete(UnitRing ring) { }

	// RVA: 0x208DCF0 Offset: 0x208DDF1 VA: 0x208DCF0
	private static void DeleteFromPool(UnitRing ring) { }

	[ConditionalAttribute] // RVA: 0x2CBE80 Offset: 0x2CBF81 VA: 0x2CBE80
	// RVA: 0x208DD50 Offset: 0x208DE51 VA: 0x208DD50
	public static void DbgAddAllCommonRings(int count) { }
}

