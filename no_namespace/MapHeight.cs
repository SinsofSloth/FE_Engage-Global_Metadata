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
private enum MapHeight.Plane // TypeDefIndex: 12028
{
	// Fields
	public int value__; // 0x0
	public const MapHeight.Plane Up = 0;
	public const MapHeight.Plane Down = 1;
	public const MapHeight.Plane Left = 2;
	public const MapHeight.Plane Right = 3;
}

