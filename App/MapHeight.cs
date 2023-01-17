// Namespace: App
public class MapHeight : SingletonClass<MapHeight> // TypeDefIndex: 12030
{
	// Fields
	public const int R = 4;
	public const int N = 5;
	public const int W = 32;
	public const int H = 32;
	private MapHeight.CellMap[] m_CellMaps; // 0x20
	private int[] m_LayerMasksA; // 0x28
	private int[] m_LayerMasksB; // 0x30
	private int m_LayerMaskOver; // 0x38
	private static readonly Vector3 ZERO; // 0x0
	private static readonly MapHeight.EdgeIndex[] s_EdgeIndexes; // 0x10

	// Methods

	// RVA: 0x21C9F70 Offset: 0x21CA071 VA: 0x21C9F70
	private static bool CalcRayCast(out RaycastHit hit, float x, float z, int layerMaskA, int layerMaskB) { }

	// RVA: 0x21CA020 Offset: 0x21CA121 VA: 0x21CA020
	private static float CalcRayCast(float x, float z, int layerMaskA, int layerMaskB) { }

	// RVA: 0x21CA140 Offset: 0x21CA241 VA: 0x21CA140
	public void .ctor() { }

	// RVA: 0x21CA620 Offset: 0x21CA721 VA: 0x21CA620
	public void Clear() { }

	// RVA: 0x21CA680 Offset: 0x21CA781 VA: 0x21CA680
	public MapHeight.CellMap GetCellMap(MapHeight.Layers layer) { }

	// RVA: 0x21CA6C0 Offset: 0x21CA7C1 VA: 0x21CA6C0
	public MapHeight.CellMap GetOver() { }

	// RVA: 0x21CA6F0 Offset: 0x21CA7F1 VA: 0x21CA6F0
	public MapHeight.CellMap GetUnder() { }

	// RVA: 0x21CA720 Offset: 0x21CA821 VA: 0x21CA720
	public void Update(int x, int z) { }

	// RVA: 0x21CB910 Offset: 0x21CBA11 VA: 0x21CB910 Slot: 8
	protected override void OnUpdate() { }

	// RVA: 0x21CCBD0 Offset: 0x21CCCD1 VA: 0x21CCBD0
	public float Get(Vector3 pos, MapHeight.Layers layer) { }

	// RVA: 0x21CD710 Offset: 0x21CD811 VA: 0x21CD710
	public Vector3 GetNormal(Vector3 pos, MapHeight.Layers layer) { }

	// RVA: 0x21CDF50 Offset: 0x21CE051 VA: 0x21CDF50
	public float GetMaxHeight(int x, int z) { }

	// RVA: 0x21CEAD0 Offset: 0x21CEBD1 VA: 0x21CEAD0
	public float GetMinHeight(int x, int z) { }

	// RVA: 0x21CF650 Offset: 0x21CF751 VA: 0x21CF650
	private static MapHeight.Plane GetPlane(float ox, float oz) { }

	// RVA: 0x21CF690 Offset: 0x21CF791 VA: 0x21CF690
	private static bool IsOutSide(int x, int z) { }

	// RVA: 0x21CF6C0 Offset: 0x21CF7C1 VA: 0x21CF6C0
	public float Get(float x, float z, MapHeight.Layers layer) { }

	// RVA: 0x21D01F0 Offset: 0x21D02F1 VA: 0x21D01F0
	public float Get(int x, int z, int index, MapHeight.Layers layer) { }

	// RVA: 0x21D04F0 Offset: 0x21D05F1 VA: 0x21D04F0
	public Vector3 GetNormal(float x, float z, MapHeight.Layers layer) { }

	// RVA: 0x21D0D30 Offset: 0x21D0E31 VA: 0x21D0D30
	public float GetEdge(int x, int z, Dir.Type dir) { }

	// RVA: 0x21D1390 Offset: 0x21D1491 VA: 0x21D1390
	public float GetMinEdge(int x, int z, Dir.Type dir) { }

	// RVA: 0x21D19F0 Offset: 0x21D1AF1 VA: 0x21D19F0
	public float GetMaxEdge(int x, int z, Dir.Type dir) { }

	// RVA: 0x21D2050 Offset: 0x21D2151 VA: 0x21D2050
	public bool IsSlope(int x, int z, float slope) { }

	// RVA: 0x21D2BF0 Offset: 0x21D2CF1 VA: 0x21D2BF0
	public float GetTiltAngle(int x, int z) { }

	// RVA: 0x21D3790 Offset: 0x21D3891 VA: 0x21D3790
	private static float GetLength_point_plane(Vector3 P, Vector3 D, Vector3 NormalizedN) { }

	// RVA: 0x21D3870 Offset: 0x21D3971 VA: 0x21D3870
	private static float GetLength_point_plane(Vector3 P, float D, Vector3 NormalizedN) { }

	// RVA: 0x21D3890 Offset: 0x21D3991 VA: 0x21D3890
	private static bool GetIntersectPt_segment_plane(Vector3 P, Vector3 Q, Vector3 A, Vector3 B, Vector3 C, out Vector3 oPT) { }

	// RVA: 0x21D3B80 Offset: 0x21D3C81 VA: 0x21D3B80
	private static bool GetIntersectPt_segment_triangle(Vector3 P, Vector3 Q, Vector3 A, Vector3 B, Vector3 C, out Vector3 oPT) { }

	// RVA: 0x21D3E20 Offset: 0x21D3F21 VA: 0x21D3E20
	private static void .cctor() { }
}

