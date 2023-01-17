// Namespace: 
public enum MapHeight.Layers // TypeDefIndex: 12025
{
	// Fields
	public int value__; // 0x0
	public const MapHeight.Layers Under = 0;
	public const MapHeight.Layers Over = 1;
	public const MapHeight.Layers Num = 2;
}

// Namespace: 
public class MapHeight.CellInfo // TypeDefIndex: 12026
{
	// Fields
	public float[] heights; // 0x10
	public Vector3[] normals; // 0x18
	public int[] layers; // 0x20

	// Methods

	// RVA: 0x1D427A0 Offset: 0x1D428A1 VA: 0x1D427A0
	public void .ctor() { }

	// RVA: 0x1D42890 Offset: 0x1D42991 VA: 0x1D42890
	public void Clear() { }

	// RVA: 0x1D42A20 Offset: 0x1D42B21 VA: 0x1D42A20
	private float GetMin() { }

	// RVA: 0x1D42AB0 Offset: 0x1D42BB1 VA: 0x1D42AB0
	private float GetMax() { }

	// RVA: 0x1D42B40 Offset: 0x1D42C41 VA: 0x1D42B40
	public float GetDiff() { }

	// RVA: 0x1D42C30 Offset: 0x1D42D31 VA: 0x1D42C30
	public void Update(int index, float x, float z, int layerMaskA, int layerMaskB) { }

	// RVA: 0x1D42E50 Offset: 0x1D42F51 VA: 0x1D42E50
	private bool IsFlat(int index) { }

	// RVA: 0x1D42EA0 Offset: 0x1D42FA1 VA: 0x1D42EA0
	public bool IsFlat() { }

	// RVA: 0x1D42F60 Offset: 0x1D43061 VA: 0x1D42F60
	public void Commit() { }

	// RVA: 0x1D432B0 Offset: 0x1D433B1 VA: 0x1D432B0
	public void Copy(MapHeight.CellInfo src) { }
}

// Namespace: 
public class MapHeight.CellMap // TypeDefIndex: 12027
{
	// Fields
	private MapHeight.CellInfo[] m_Cells; // 0x10
	private int m_LayerMaskA; // 0x18
	private int m_LayerMaskB; // 0x1C

	// Methods

	// RVA: 0x1D43540 Offset: 0x1D43641 VA: 0x1D43540
	public void .ctor(int layerMaskA, int layerMaskB) { }

	// RVA: 0x1D43670 Offset: 0x1D43771 VA: 0x1D43670
	public float GetX(int x, int index) { }

	// RVA: 0x1D43720 Offset: 0x1D43821 VA: 0x1D43720
	public float GetZ(int z, int index) { }

	// RVA: 0x1D437D0 Offset: 0x1D438D1 VA: 0x1D437D0
	public float GetHeight(int x, int z, int index) { }

	// RVA: 0x1D43AC0 Offset: 0x1D43BC1 VA: 0x1D43AC0
	public float GetMaxHeight(int x, int z) { }

	// RVA: 0x1D440B0 Offset: 0x1D441B1 VA: 0x1D440B0
	public float GetMinHeight(int x, int z) { }

	// RVA: 0x1D446A0 Offset: 0x1D447A1 VA: 0x1D446A0
	public MapHeight.CellInfo Get(int x, int z) { }

	// RVA: 0x1D446E0 Offset: 0x1D447E1 VA: 0x1D446E0
	public void Update(int x, int z) { }

	// RVA: 0x1D44E90 Offset: 0x1D44F91 VA: 0x1D44E90
	public bool IsLayerMask(int x, int z, int layerMask) { }

	// RVA: 0x1D44F20 Offset: 0x1D45021 VA: 0x1D44F20
	public void Clear() { }
}

// Namespace: 
private enum MapHeight.Plane // TypeDefIndex: 12028
{
	// Fields
	public int value__; // 0x0
	public const MapHeight.Plane Up = 0;
	public const MapHeight.Plane Down = 1;
	public const MapHeight.Plane Left = 2;
	public const MapHeight.Plane Right = 3;
}

// Namespace: 
private class MapHeight.EdgeIndex // TypeDefIndex: 12029
{
	// Fields
	public int Index1; // 0x10
	public int Index2; // 0x14

	// Methods

	// RVA: 0x1D44F80 Offset: 0x1D45081 VA: 0x1D44F80
	public void .ctor() { }
}

