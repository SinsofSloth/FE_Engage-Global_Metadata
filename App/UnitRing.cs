// Namespace: App
public class UnitRing : LinkNode<UnitRing> // TypeDefIndex: 13544
{
	// Fields
	public const int MaxStockCount = 99;
	private RingData m_Data; // 0x20
	private Unit m_Owner; // 0x28
	private byte m_StockCount; // 0x30

	// Properties
	public override int SortKey { get; }
	public RingData Data { get; }
	public Unit Owner { get; }
	public int StockCount { get; }
	public string Rnid { get; }

	// Methods

	// RVA: 0x208C950 Offset: 0x208CA51 VA: 0x208C950
	public void Build(string rnid, Unit owner, int stockCount) { }

	// RVA: 0x208CAD0 Offset: 0x208CBD1 VA: 0x208CAD0
	public string GetName() { }

	// RVA: 0x208CAE0 Offset: 0x208CBE1 VA: 0x208CAE0
	public string GetFullName() { }

	// RVA: 0x208CAF0 Offset: 0x208CBF1 VA: 0x208CAF0
	public string GetDebugName() { }

	// RVA: 0x208CB00 Offset: 0x208CC01 VA: 0x208CB00
	public void ChangeOwner(Unit owner) { }

	// RVA: 0x208CB20 Offset: 0x208CC21 VA: 0x208CB20
	public void SetStockCount(int stockCount) { }

	// RVA: 0x208CB90 Offset: 0x208CC91 VA: 0x208CB90
	public void AddStockCount(int stockCount) { }

	// RVA: 0x208CBE0 Offset: 0x208CCE1 VA: 0x208CBE0 Slot: 6
	public override int get_SortKey() { }

	// RVA: 0x208CB70 Offset: 0x208CC71 VA: 0x208CB70
	public bool IsSingleStockOnly() { }

	// RVA: 0x208CAB0 Offset: 0x208CBB1 VA: 0x208CAB0
	private static bool IsSingleStockOnly(RingData data, Unit owner) { }

	// RVA: 0x208CC00 Offset: 0x208CD01 VA: 0x208CC00
	public RingData get_Data() { }

	// RVA: 0x208CC10 Offset: 0x208CD11 VA: 0x208CC10
	public Unit get_Owner() { }

	// RVA: 0x208CC20 Offset: 0x208CD21 VA: 0x208CC20
	public int get_StockCount() { }

	// RVA: 0x208CC30 Offset: 0x208CD31 VA: 0x208CC30
	public string get_Rnid() { }

	// RVA: 0x208CC40 Offset: 0x208CD41 VA: 0x208CC40 Slot: 7
	public override void OnSerialize(Stream stream) { }

	// RVA: 0x208CCB0 Offset: 0x208CDB1 VA: 0x208CCB0 Slot: 8
	public override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x208CDF0 Offset: 0x208CEF1 VA: 0x208CDF0 Slot: 5
	public override bool IsValid() { }

	// RVA: 0x208CA70 Offset: 0x208CB71 VA: 0x208CA70
	private void Clear() { }

	// RVA: 0x208CE00 Offset: 0x208CF01 VA: 0x208CE00
	public void .ctor() { }
}

