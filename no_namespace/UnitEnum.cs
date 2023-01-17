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

