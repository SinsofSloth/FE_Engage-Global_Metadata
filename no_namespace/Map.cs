// Namespace: 
public class Map.CellMesh : DynamicMesh // TypeDefIndex: 11885
{
	// Fields
	private Map.CellVertex m_CellVertex; // 0x68

	// Methods

	// RVA: 0x2238030 Offset: 0x2238131 VA: 0x2238030
	public void .ctor(GameObject go, int subMeshCount = 1, int vertexCapacity = 8192) { }

	// RVA: 0x22381C0 Offset: 0x22382C1 VA: 0x22381C0
	private void AddTangents5(in Vector4 tangent) { }

	// RVA: 0x2238320 Offset: 0x2238421 VA: 0x2238320
	public void AddCell(int x, int z, Color color, float distance = 0) { }

	// RVA: 0x2238990 Offset: 0x2238A91 VA: 0x2238990
	public void AddCell(int x, int z, Color color, Vector2 uv0, Vector2 uv2, int rotation = 0, float distance = 0) { }

	// RVA: 0x2239150 Offset: 0x2239251 VA: 0x2239150
	public void AddCell(int x, int z, Vector2 uv0, Vector2 uv2, float distance = 0) { }

	// RVA: 0x22397C0 Offset: 0x22398C1 VA: 0x22397C0
	public void AddCell(int x, int z, Color color0, Color color1, Color color2, Color color3, float distance = 0) { }

	// RVA: 0x2239EF0 Offset: 0x2239FF1 VA: 0x2239EF0
	public void AddCell(int x, int z, Color color0, Color color1, Color color2, Color color3, Vector2 uv0, Vector2 uv2, float distance = 0) { }

	// RVA: 0x223A740 Offset: 0x223A841 VA: 0x223A740
	public void AddCell(int x, int z, Dir.Type dir, Color color, Vector2 uv0, Vector2 uv2, float distance = 0) { }

	// RVA: 0x223C080 Offset: 0x223C181 VA: 0x223C080
	public void AddStraddleCell(Unit unit, Color color, float uvRotate = 0) { }

	// RVA: 0x223DF80 Offset: 0x223E081 VA: 0x223DF80
	public void AddEventCell(int x, int z, Color color) { }
}

