// Namespace: App
public struct BattleInfoEnum : IEnumerator<BattleInfoSide>, IEnumerator, IDisposable // TypeDefIndex: 9509
{
	// Fields
	private BattleInfo m_Info; // 0x0
	private BattleSide.Type m_Min; // 0x8
	private BattleSide.Type m_Max; // 0xC
	private BattleInfoSide m_Current; // 0x10

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public BattleInfoSide Current { get; }

	// Methods

	// RVA: 0x2245110 Offset: 0x2245211 VA: 0x2245110
	public BattleInfoEnum GetEnumerator() { }

	// RVA: 0x2245FD0 Offset: 0x22460D1 VA: 0x2245FD0
	public void .ctor(BattleInfo info, BattleSide.Type min, BattleSide.Type max) { }

	// RVA: 0x22452B0 Offset: 0x22453B1 VA: 0x22452B0 Slot: 5
	public void Dispose() { }

	// RVA: 0x2245160 Offset: 0x2245261 VA: 0x2245160 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x2252240 Offset: 0x2252341 VA: 0x2252240 Slot: 8
	public void Reset() { }

	// RVA: 0x2252250 Offset: 0x2252351 VA: 0x2252250 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x2252260 Offset: 0x2252361 VA: 0x2252260 Slot: 4
	public BattleInfoSide get_Current() { }
}

