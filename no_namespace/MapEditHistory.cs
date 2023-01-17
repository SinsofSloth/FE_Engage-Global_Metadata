// Namespace: 
private abstract class MapEditHistory.MapEditCommand // TypeDefIndex: 11970
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Do();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Undo();

	// RVA: 0x1D3DA00 Offset: 0x1D3DB01 VA: 0x1D3DA00
	protected void .ctor() { }
}

// Namespace: 
private class MapEditHistory.CreateObjectCommand : MapEditHistory.MapEditCommand // TypeDefIndex: 11971
{
	// Fields
	private int m_X; // 0x10
	private int m_Z; // 0x14
	private string m_ObjectName; // 0x18

	// Methods

	// RVA: 0x1D3D9B0 Offset: 0x1D3DAB1 VA: 0x1D3D9B0
	public void .ctor(int x, int z, string objectName) { }

	// RVA: 0x1D3DA10 Offset: 0x1D3DB11 VA: 0x1D3DA10 Slot: 4
	public override void Do() { }

	// RVA: 0x1D3DA50 Offset: 0x1D3DB51 VA: 0x1D3DA50 Slot: 5
	public override void Undo() { }

	// RVA: 0x1D3DAF0 Offset: 0x1D3DBF1 VA: 0x1D3DAF0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
private class MapEditHistory.DeleteObjectCommand : MapEditHistory.MapEditCommand // TypeDefIndex: 11972
{
	// Fields
	private int m_X; // 0x10
	private int m_Z; // 0x14
	private string m_DeleteObjectName; // 0x18
	private int m_Rotate; // 0x20

	// Methods

	// RVA: 0x1D3DBA0 Offset: 0x1D3DCA1 VA: 0x1D3DBA0
	public void .ctor(int x, int z, string deleteObjectName, int rotate) { }

	// RVA: 0x1D3DC00 Offset: 0x1D3DD01 VA: 0x1D3DC00 Slot: 4
	public override void Do() { }

	// RVA: 0x1D3DC40 Offset: 0x1D3DD41 VA: 0x1D3DC40 Slot: 5
	public override void Undo() { }

	// RVA: 0x1D3DD50 Offset: 0x1D3DE51 VA: 0x1D3DD50 Slot: 3
	public override string ToString() { }
}

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

// Namespace: 
private class MapEditHistory.RotateObjectCommand : MapEditHistory.MapEditCommand // TypeDefIndex: 11974
{
	// Fields
	private int m_X; // 0x10
	private int m_Z; // 0x14
	private int m_PrevRotate; // 0x18
	private int m_NextRotate; // 0x1C

	// Methods

	// RVA: 0x1D3E310 Offset: 0x1D3E411 VA: 0x1D3E310
	public void .ctor(int x, int z, int prevRotate, int nextRotate) { }

	// RVA: 0x1D3E360 Offset: 0x1D3E461 VA: 0x1D3E360 Slot: 4
	public override void Do() { }

	// RVA: 0x1D3E3A0 Offset: 0x1D3E4A1 VA: 0x1D3E3A0 Slot: 5
	public override void Undo() { }

	// RVA: 0x1D3E430 Offset: 0x1D3E531 VA: 0x1D3E430 Slot: 3
	public override string ToString() { }
}

