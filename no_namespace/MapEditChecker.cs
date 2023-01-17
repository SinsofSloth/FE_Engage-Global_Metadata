// Namespace: 
[DebuggerDisplayAttribute] // RVA: 0x277D70 Offset: 0x277E71 VA: 0x277D70
private struct MapEditChecker.CheckRange : IDisposable // TypeDefIndex: 11968
{
	// Fields
	public int minX; // 0x0
	public int maxX; // 0x4
	public int minZ; // 0x8
	public int maxZ; // 0xC

	// Methods

	// RVA: 0x1D3D270 Offset: 0x1D3D371 VA: 0x1D3D270
	public void .ctor(int x1, int x2, int z1, int z2) { }

	// RVA: 0x1D3D2A0 Offset: 0x1D3D3A1 VA: 0x1D3D2A0
	public bool IsRange(MapPos pos) { }

	// RVA: 0x1D3D2F0 Offset: 0x1D3D3F1 VA: 0x1D3D2F0
	public bool IsRange(int x, int z) { }

	// RVA: 0x1D3D340 Offset: 0x1D3D441 VA: 0x1D3D340 Slot: 4
	public void Dispose() { }

	// RVA: 0x1D3D350 Offset: 0x1D3D451 VA: 0x1D3D350 Slot: 3
	public override string ToString() { }
}

