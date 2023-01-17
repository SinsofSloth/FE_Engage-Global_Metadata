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

