// Namespace: 
public enum DynamicMesh.Mode // TypeDefIndex: 14081
{
	// Fields
	public int value__; // 0x0
	public const DynamicMesh.Mode None = 0;
	public const DynamicMesh.Mode Triangle = 1;
	public const DynamicMesh.Mode Quad = 2;
	public const DynamicMesh.Mode Pyramid = 3;
	public const DynamicMesh.Mode Fan = 4;
	public const DynamicMesh.Mode FanCCW = 5;
	public const DynamicMesh.Mode Strip = 6;
	public const DynamicMesh.Mode Lines = 7;
	public const DynamicMesh.Mode Cell = 3;
}

// Namespace: 
private class DynamicMesh.StaticIndices // TypeDefIndex: 14082
{
	// Fields
	private static ushort[][] s_Indices; // 0x0

	// Methods

	// RVA: 0x1F01E10 Offset: 0x1F01F11 VA: 0x1F01E10
	private static void .cctor() { }

	// RVA: 0x1F025B0 Offset: 0x1F026B1 VA: 0x1F025B0
	public static ushort[] GetIndices(DynamicMesh.Mode mode) { }

	// RVA: 0x1F02640 Offset: 0x1F02741 VA: 0x1F02640
	public static int GetTriangleCount(DynamicMesh.Mode mode, int vertexCount) { }

	// RVA: 0x1F026C0 Offset: 0x1F027C1 VA: 0x1F026C0
	public void .ctor() { }
}

// Namespace: 
private struct DynamicMesh.State // TypeDefIndex: 14083
{
	// Fields
	public DynamicMesh.Mode mode; // 0x0
	public ushort index; // 0x4
	public ushort count; // 0x6

	// Methods

	// RVA: 0x1F01DB0 Offset: 0x1F01EB1 VA: 0x1F01DB0
	public bool CanConnect(DynamicMesh.State state) { }

	// RVA: 0x1F01DE0 Offset: 0x1F01EE1 VA: 0x1F01DE0
	public void Connect(DynamicMesh.State state) { }

	// RVA: 0x1F01E00 Offset: 0x1F01F01 VA: 0x1F01E00
	public void Clear() { }
}

// Namespace: 
protected struct DynamicMesh.Scope : IDisposable // TypeDefIndex: 14084
{
	// Fields
	private DynamicMesh m_Mesh; // 0x0

	// Methods

	// RVA: 0x1F01D10 Offset: 0x1F01E11 VA: 0x1F01D10
	public void .ctor(DynamicMesh mesh, DynamicMesh.Mode mode = 0, int subMeshIndex = 0) { }

	// RVA: 0x1F01D70 Offset: 0x1F01E71 VA: 0x1F01D70 Slot: 4
	public void Dispose() { }
}

