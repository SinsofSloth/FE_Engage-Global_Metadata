// Namespace: 
public struct MapEnum.RangeEnumerator : IEnumerable<MapRange>, IEnumerable, IEnumerator<MapRange>, IEnumerator, IDisposable // TypeDefIndex: 12002
{
	// Fields
	private MapRange m_Current; // 0x0
	private int m_PivotX; // 0xC
	private int m_PivotZ; // 0x10
	private int m_MinX; // 0x14
	private int m_MinZ; // 0x18
	private int m_MaxX; // 0x1C
	private int m_MaxZ; // 0x20
	private int m_Near; // 0x24
	private int m_Far; // 0x28

	// Properties
	public MapRange Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1D3F420 Offset: 0x1D3F521 VA: 0x1D3F420
	public MapEnum.RangeEnumerator Setup(int x, int z, int near, int far) { }

	// RVA: 0x1D3F5A0 Offset: 0x1D3F6A1 VA: 0x1D3F5A0 Slot: 7
	public void Dispose() { }

	// RVA: 0x1D3F5B0 Offset: 0x1D3F6B1 VA: 0x1D3F5B0 Slot: 6
	public MapRange get_Current() { }

	// RVA: 0x1D3F5C0 Offset: 0x1D3F6C1 VA: 0x1D3F5C0 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1D3F630 Offset: 0x1D3F731 VA: 0x1D3F630 Slot: 8
	public bool MoveNext() { }

	// RVA: 0x1D3F6E0 Offset: 0x1D3F7E1 VA: 0x1D3F6E0 Slot: 10
	public void Reset() { }

	// RVA: 0x1D3F700 Offset: 0x1D3F801 VA: 0x1D3F700 Slot: 4
	private IEnumerator<MapRange> System.Collections.Generic.IEnumerable<App.MapRange>.GetEnumerator() { }

	// RVA: 0x1D3F780 Offset: 0x1D3F881 VA: 0x1D3F780 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1D3F800 Offset: 0x1D3F901 VA: 0x1D3F800
	public MapEnum.RangeEnumerator GetEnumerator() { }
}

// Namespace: 
public struct MapEnum.CellEnumerator : IEnumerable<MapPos>, IEnumerable, IEnumerator<MapPos>, IEnumerator, IDisposable // TypeDefIndex: 12004
{
	// Fields
	private MapPos m_Current; // 0x0
	private int m_X; // 0x8
	private int m_Z; // 0xC
	private int m_Size; // 0x10

	// Properties
	public MapPos Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1D3EE10 Offset: 0x1D3EF11 VA: 0x1D3EE10
	public MapEnum.CellEnumerator Setup(int x, int z, int size) { }

	// RVA: 0x1D3EE30 Offset: 0x1D3EF31 VA: 0x1D3EE30 Slot: 7
	public void Dispose() { }

	// RVA: 0x1D3EE40 Offset: 0x1D3EF41 VA: 0x1D3EE40 Slot: 6
	public MapPos get_Current() { }

	// RVA: 0x1D3EE50 Offset: 0x1D3EF51 VA: 0x1D3EE50 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1D3EEB0 Offset: 0x1D3EFB1 VA: 0x1D3EEB0 Slot: 8
	public bool MoveNext() { }

	// RVA: 0x1D3EF10 Offset: 0x1D3F011 VA: 0x1D3EF10 Slot: 10
	public void Reset() { }

	// RVA: 0x1D3EF20 Offset: 0x1D3F021 VA: 0x1D3EF20 Slot: 4
	private IEnumerator<MapPos> System.Collections.Generic.IEnumerable<App.MapPos>.GetEnumerator() { }

	// RVA: 0x1D3EF90 Offset: 0x1D3F091 VA: 0x1D3EF90 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1D3F000 Offset: 0x1D3F101 VA: 0x1D3F000
	public MapEnum.CellEnumerator GetEnumerator() { }
}

