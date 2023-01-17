// Namespace: App
[RequireComponent] // RVA: 0x2783A0 Offset: 0x2784A1 VA: 0x2783A0
public class MiniMapSightRenderer : MaskableGraphic // TypeDefIndex: 12360
{
	// Fields
	[SerializeField] // RVA: 0x299FA0 Offset: 0x29A0A1 VA: 0x299FA0
	public Texture2D m_Texture; // 0xD0
	private CanvasRenderer m_CanvasRenderer; // 0xD8
	public Color m_SightFillColor; // 0xE0
	private Mesh m_Mesh; // 0xF0
	private List<Vector3> m_Vertices; // 0xF8
	private List<Color> m_Colors; // 0x100
	private List<Vector2> m_UVs; // 0x108
	private List<int> m_Indices; // 0x110
	private readonly int VERTEX_CAPACITY; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x299FB0 Offset: 0x29A0B1 VA: 0x299FB0
	private float <GridSize>k__BackingField; // 0x11C
	private readonly Vector3[] vtxOffsets; // 0x120

	// Properties
	public Texture2D Texture { get; set; }
	public CanvasRenderer CanvasRenderer { get; }
	public float GridSize { get; set; }

	// Methods

	// RVA: 0x22771D0 Offset: 0x22772D1 VA: 0x22771D0
	public Texture2D get_Texture() { }

	// RVA: 0x22771E0 Offset: 0x22772E1 VA: 0x22771E0
	public void set_Texture(Texture2D value) { }

	// RVA: 0x22772A0 Offset: 0x22773A1 VA: 0x22772A0
	public CanvasRenderer get_CanvasRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C8250 Offset: 0x2C8351 VA: 0x2C8250
	// RVA: 0x2277360 Offset: 0x2277461 VA: 0x2277360
	public void set_GridSize(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C8260 Offset: 0x2C8361 VA: 0x2C8260
	// RVA: 0x2277370 Offset: 0x2277471 VA: 0x2277370
	public float get_GridSize() { }

	// RVA: 0x2277380 Offset: 0x2277481 VA: 0x2277380
	private void TryInitializeData() { }

	// RVA: 0x22775E0 Offset: 0x22776E1 VA: 0x22775E0
	private MapImage GetMapImage() { }

	// RVA: 0x2277660 Offset: 0x2277761 VA: 0x2277660 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x22776F0 Offset: 0x22777F1 VA: 0x22776F0
	protected void Update() { }

	// RVA: 0x2274140 Offset: 0x2274241 VA: 0x2274140
	public void CreateTerrainMesh() { }

	// RVA: 0x2277780 Offset: 0x2277881 VA: 0x2277780
	public void CreateTerrainMesh(MapImage mapImage) { }

	// RVA: 0x2277CC0 Offset: 0x2277DC1 VA: 0x2277CC0
	private void SetMeshToRenderer() { }

	// RVA: 0x2274060 Offset: 0x2274161 VA: 0x2274060
	public void UpdateMapSize() { }

	// RVA: 0x2277DC0 Offset: 0x2277EC1 VA: 0x2277DC0
	public void .ctor() { }
}

