// Namespace: 
public struct UnitEnum.Enumerator : IEnumerator<Unit>, IEnumerator, IDisposable // TypeDefIndex: 13529
{
	// Fields
	private Force.Type[] m_Types; // 0x0
	private int m_Index; // 0x8
	private Unit m_Next; // 0x10
	private Unit m_Current; // 0x18

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public Unit Current { get; }

	// Methods

	// RVA: 0x1ECFFD0 Offset: 0x1ED00D1 VA: 0x1ECFFD0
	public void .ctor(Force.Type[] types) { }

	// RVA: 0x1ECA080 Offset: 0x1ECA181 VA: 0x1ECA080 Slot: 5
	public void Dispose() { }

	// RVA: 0x1ED0020 Offset: 0x1ED0121 VA: 0x1ED0020 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x1ED00F0 Offset: 0x1ED01F1 VA: 0x1ED00F0 Slot: 8
	public void Reset() { }

	// RVA: 0x1ED0130 Offset: 0x1ED0231 VA: 0x1ED0130 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1ED0140 Offset: 0x1ED0241 VA: 0x1ED0140 Slot: 4
	public Unit get_Current() { }
}

// Namespace: 
public struct UnitEnum.TargetEnumerator : IEnumerable<Unit>, IEnumerable, IEnumerator<Unit>, IEnumerator, IDisposable // TypeDefIndex: 13530
{
	// Fields
	private UnitEnum.Enumerator m_UnitEnum; // 0x0
	private Unit m_Current; // 0x20
	private Unit m_Unit; // 0x28
	private int m_X; // 0x30
	private int m_Z; // 0x34
	private int m_Near; // 0x38
	private int m_Far; // 0x3C

	// Properties
	public Unit Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1ED0150 Offset: 0x1ED0251 VA: 0x1ED0150
	public UnitEnum.TargetEnumerator Setup(Unit unit, int x, int z, int near, int far) { }

	// RVA: 0x1ED02E0 Offset: 0x1ED03E1 VA: 0x1ED02E0 Slot: 7
	public void Dispose() { }

	// RVA: 0x1ED02F0 Offset: 0x1ED03F1 VA: 0x1ED02F0 Slot: 6
	public Unit get_Current() { }

	// RVA: 0x1ED0300 Offset: 0x1ED0401 VA: 0x1ED0300 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1ED0310 Offset: 0x1ED0411 VA: 0x1ED0310 Slot: 8
	public bool MoveNext() { }

	// RVA: 0x1ED0A10 Offset: 0x1ED0B11 VA: 0x1ED0A10 Slot: 10
	public void Reset() { }

	// RVA: 0x1ED0B30 Offset: 0x1ED0C31 VA: 0x1ED0B30 Slot: 4
	private IEnumerator<Unit> System.Collections.Generic.IEnumerable<App.Unit>.GetEnumerator() { }

	// RVA: 0x1ED0BB0 Offset: 0x1ED0CB1 VA: 0x1ED0BB0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1ED0C30 Offset: 0x1ED0D31 VA: 0x1ED0C30
	public UnitEnum.TargetEnumerator GetEnumerator() { }
}

