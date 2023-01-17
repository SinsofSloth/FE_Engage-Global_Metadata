// Namespace: App
public class GodPool : SingletonPool<GodPool, GodUnit> // TypeDefIndex: 13473
{
	// Properties
	protected override int Version { get; }

	// Methods

	// RVA: 0x27A7FE0 Offset: 0x27A80E1 VA: 0x27A7FE0
	public void .ctor() { }

	// RVA: 0x27A8040 Offset: 0x27A8141 VA: 0x27A8040 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x27A8050 Offset: 0x27A8151 VA: 0x27A8050
	public static GodUnit TryGet(string gid, bool includeReserved = False) { }

	// RVA: 0x27A80E0 Offset: 0x27A81E1 VA: 0x27A80E0
	public static GodUnit TryGet(GodData data, bool includeReserved = False) { }

	// RVA: 0x27A8200 Offset: 0x27A8301 VA: 0x27A8200
	private static GodUnit TryGetImpl(GodData data, bool includeReserved) { }

	// RVA: 0x27A84A0 Offset: 0x27A85A1 VA: 0x27A84A0
	public static GodUnit Create(GodData data) { }

	// RVA: 0x27A8710 Offset: 0x27A8811 VA: 0x27A8710
	public static void Delete(GodUnit god) { }

	// RVA: 0x27A8890 Offset: 0x27A8991 VA: 0x27A8890
	public static void DeleteOrReserve(GodUnit god) { }

	// RVA: 0x27A89B0 Offset: 0x27A8AB1 VA: 0x27A89B0
	public static void DeleteReserved() { }

	// RVA: 0x27A8C10 Offset: 0x27A8D11 VA: 0x27A8C10
	public static void DeleteExceptForPlayer() { }

	// RVA: 0x27A8F00 Offset: 0x27A9001 VA: 0x27A8F00
	public static GodUnit AppendEnemyGod(GodUnit god) { }

	// RVA: 0x27A9080 Offset: 0x27A9181 VA: 0x27A9080
	public static bool HasArmlet() { }

	// RVA: 0x27A9290 Offset: 0x27A9391 VA: 0x27A9290 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x27A92F0 Offset: 0x27A93F1 VA: 0x27A92F0 Slot: 12
	protected override void OnDeserialize(Stream stream, int version) { }
}

