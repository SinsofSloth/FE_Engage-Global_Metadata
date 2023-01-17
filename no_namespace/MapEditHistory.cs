// Namespace: 
private class MapEditHistory.ReplaceObjectCommand : MapEditHistory.MapEditCommand // TypeDefIndex: 11973
{
	// Fields
	private int m_X; // 0x10
	private int m_Z; // 0x14
	private int m_DeleteRotate; // 0x18
	private string m_DeleteObjName; // 0x20
	private string m_CreateObjName; // 0x28

	// Methods

	// RVA: 0x1D3DF20 Offset: 0x1D3E021 VA: 0x1D3DF20
	public void .ctor(int x, int z, int deleteRotate, string deleteObjName, string createObjName) { }

	// RVA: 0x1D3DF90 Offset: 0x1D3E091 VA: 0x1D3DF90 Slot: 4
	public override void Do() { }

	// RVA: 0x1D3DFD0 Offset: 0x1D3E0D1 VA: 0x1D3DFD0 Slot: 5
	public override void Undo() { }

	// RVA: 0x1D3E100 Offset: 0x1D3E201 VA: 0x1D3E100 Slot: 3
	public override string ToString() { }
}

