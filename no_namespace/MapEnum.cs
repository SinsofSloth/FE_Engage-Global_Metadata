// Namespace: 
public struct MapEnum.MoveEnumerator : IEnumerable<MapRange>, IEnumerable, IEnumerator<MapRange>, IEnumerator, IDisposable // TypeDefIndex: 12003
{
	// Fields
	private MapRange m_Current; // 0x0
	private int m_MinX; // 0xC
	private int m_MinZ; // 0x10
	private int m_MaxX; // 0x14
	private int m_MaxZ; // 0x18

	// Properties
	public MapRange Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1D3F020 Offset: 0x1D3F121 VA: 0x1D3F020
	public MapEnum.MoveEnumerator Setup() { }

	// RVA: 0x1D3F100 Offset: 0x1D3F201 VA: 0x1D3F100 Slot: 7
	public void Dispose() { }

	// RVA: 0x1D3F110 Offset: 0x1D3F211 VA: 0x1D3F110 Slot: 6
	public MapRange get_Current() { }

	// RVA: 0x1D3F120 Offset: 0x1D3F221 VA: 0x1D3F120 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1D3F190 Offset: 0x1D3F291 VA: 0x1D3F190 Slot: 8
	public bool MoveNext() { }

	// RVA: 0x1D3F2E0 Offset: 0x1D3F3E1 VA: 0x1D3F2E0 Slot: 10
	public void Reset() { }

	// RVA: 0x1D3F300 Offset: 0x1D3F401 VA: 0x1D3F300 Slot: 4
	private IEnumerator<MapRange> System.Collections.Generic.IEnumerable<App.MapRange>.GetEnumerator() { }

	// RVA: 0x1D3F380 Offset: 0x1D3F481 VA: 0x1D3F380 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1D3F400 Offset: 0x1D3F501 VA: 0x1D3F400
	public MapEnum.MoveEnumerator GetEnumerator() { }
}

