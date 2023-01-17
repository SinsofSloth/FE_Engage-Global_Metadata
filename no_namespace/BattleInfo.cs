// Namespace: 
public class BattleInfo.FlagField : BitFieldTemplate32<BattleInfo.Flags> // TypeDefIndex: 9502
{
	// Methods

	// RVA: 0x1F756C0 Offset: 0x1F757C1 VA: 0x1F756C0 Slot: 5
	protected override int ToInt(BattleInfo.Flags value) { }

	// RVA: 0x1F756D0 Offset: 0x1F757D1 VA: 0x1F756D0
	public void .ctor() { }
}

// Namespace: 
public struct BattleInfo.SupportData // TypeDefIndex: 9504
{
	// Fields
	public Unit unit; // 0x0
	public BattleInfoSide.Status status; // 0x8

	// Methods

	// RVA: 0x1F76F10 Offset: 0x1F77011 VA: 0x1F76F10
	public void .ctor(Unit unit) { }

	// RVA: 0x1F76F40 Offset: 0x1F77041 VA: 0x1F76F40
	public void .ctor(Unit unit, BattleInfoSide.Status status) { }
}

// Namespace: 
internal struct BattleInfo.SetupScope : IDisposable // TypeDefIndex: 9506
{
	// Fields
	private BattleInfo m_Info; // 0x0
	private Unit m_Offense; // 0x8
	private Unit m_Defense; // 0x10
	private byte m_Updated; // 0x18

	// Methods

	// RVA: 0x1F757B0 Offset: 0x1F758B1 VA: 0x1F757B0
	private BattleInfoSide GetSide(BattleSide.Type side) { }

	// RVA: 0x1F75810 Offset: 0x1F75911 VA: 0x1F75810
	public void .ctor(BattleInfo info, Unit offense, UnitItem unitItem, Unit defense, UnitItem revengeItem, int attackX = -1, int attackZ = -1, int targetX = -1, int targetZ = -1) { }

	// RVA: 0x1F76EC0 Offset: 0x1F76FC1 VA: 0x1F76EC0 Slot: 4
	public void Dispose() { }
}

