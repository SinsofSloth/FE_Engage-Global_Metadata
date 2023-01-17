// Namespace: 
public struct Map.Pos // TypeDefIndex: 11883
{
	// Fields
	public int X; // 0x0
	public int Z; // 0x4

	// Methods

	// RVA: 0x223EDE0 Offset: 0x223EEE1 VA: 0x223EDE0
	public void .ctor(int x, int z) { }
}

// Namespace: 
[DefaultMemberAttribute] // RVA: 0x277C20 Offset: 0x277D21 VA: 0x277C20
public class Map.CellVertex // TypeDefIndex: 11884
{
	// Fields
	private Vector3[] m_Position; // 0x10

	// Properties
	public Vector3 Item { get; set; }
	public float MinHeight { get; }
	public float MaxHeight { get; }

	// Methods

	// RVA: 0x223E6C0 Offset: 0x223E7C1 VA: 0x223E6C0
	public void Clear() { }

	// RVA: 0x223E750 Offset: 0x223E851 VA: 0x223E750
	public void Calc(int x, int z) { }

	// RVA: 0x223E9D0 Offset: 0x223EAD1 VA: 0x223E9D0
	public Vector3 get_Item(int i) { }

	// RVA: 0x223EA10 Offset: 0x223EB11 VA: 0x223EA10
	public void set_Item(int i, Vector3 value) { }

	// RVA: 0x223EA60 Offset: 0x223EB61 VA: 0x223EA60
	public float get_MinHeight() { }

	// RVA: 0x223EAF0 Offset: 0x223EBF1 VA: 0x223EAF0
	public float get_MaxHeight() { }

	// RVA: 0x2238150 Offset: 0x2238251 VA: 0x2238150
	public void .ctor() { }
}

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

// Namespace: 
private class Map.FillList : List<Map.Pos> // TypeDefIndex: 11886
{
	// Methods

	// RVA: 0x223EB80 Offset: 0x223EC81 VA: 0x223EB80
	public void FillTerrain(int x, int z, int before, int after) { }

	// RVA: 0x223EDF0 Offset: 0x223EEF1 VA: 0x223EDF0
	public void .ctor() { }
}

