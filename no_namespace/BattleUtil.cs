// Namespace: 
public struct BattleUtil.CalcScope : IDisposable // TypeDefIndex: 9533
{
	// Fields
	private static Stack<BattleCalculator> s_Stack; // 0x0
	public BattleInfo Info; // 0x0
	public BattleCalculator Calc; // 0x8

	// Methods

	// RVA: 0x1F79450 Offset: 0x1F79551 VA: 0x1F79450
	public void .ctor(Unit unit, BattleInfo.Flags flags = 0) { }

	// RVA: 0x1F79620 Offset: 0x1F79721 VA: 0x1F79620 Slot: 4
	public void Dispose() { }

	// RVA: 0x1F79700 Offset: 0x1F79801 VA: 0x1F79700
	public BattleInfoSide GetSide(BattleSide.Type side) { }

	// RVA: 0x1F79760 Offset: 0x1F79861 VA: 0x1F79760
	private static void .cctor() { }
}

