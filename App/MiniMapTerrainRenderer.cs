// Namespace: App
[RequireComponent] // RVA: 0x278410 Offset: 0x278511 VA: 0x278410
public class MiniMapTerrainRenderer : MaskableGraphic // TypeDefIndex: 12361
{
	// Fields
	[SerializeField] // RVA: 0x299FC0 Offset: 0x29A0C1 VA: 0x299FC0
	public Texture2D m_Texture; // 0xD0
	private CanvasRenderer m_CanvasRenderer; // 0xD8
	public Color[] m_CostTypeColors; // 0xE0
	public bool m_IsFillConstColorSightRange; // 0xE8
	public float m_SightColorDarkness; // 0xEC
	public Color m_SightFillColor; // 0xF0
	private Mesh m_Mesh; // 0x100
	private List<Vector3> m_Vertices; // 0x108
	private List<Color> m_Colors; // 0x110
	private List<Vector2> m_UVs; // 0x118
	private List<int> m_Indices; // 0x120
	private readonly int VERTEX_CAPACITY; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x299FD0 Offset: 0x29A0D1 VA: 0x299FD0
	private float <GridSize>k__BackingField; // 0x12C
	[CompilerGeneratedAttribute] // RVA: 0x299FE0 Offset: 0x29A0E1 VA: 0x299FE0
	private float <OutLineSize>k__BackingField; // 0x130
	private readonly Vector3[] vtxOffsets; // 0x138

	// Properties
	public Texture2D Texture { get; set; }
	public CanvasRenderer CanvasRenderer { get; }
	public float GridSize { get; set; }
	public float OutLineSize { get; set; }

	// Methods

	// RVA: 0x2278020 Offset: 0x2278121 VA: 0x2278020
	public Texture2D get_Texture() { }

	// RVA: 0x2278030 Offset: 0x2278131 VA: 0x2278030
	public void set_Texture(Texture2D value) { }

	// RVA: 0x22780F0 Offset: 0x22781F1 VA: 0x22780F0
	public CanvasRenderer get_CanvasRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C8270 Offset: 0x2C8371 VA: 0x2C8270
	// RVA: 0x22781B0 Offset: 0x22782B1 VA: 0x22781B0
	public void set_GridSize(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C8280 Offset: 0x2C8381 VA: 0x2C8280
	// RVA: 0x22781C0 Offset: 0x22782C1 VA: 0x22781C0
	public float get_GridSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C8290 Offset: 0x2C8391 VA: 0x2C8290
	// RVA: 0x22781D0 Offset: 0x22782D1 VA: 0x22781D0
	public void set_OutLineSize(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C82A0 Offset: 0x2C83A1 VA: 0x2C82A0
	// RVA: 0x22781E0 Offset: 0x22782E1 VA: 0x22781E0
	public float get_OutLineSize() { }

	// RVA: 0x22781F0 Offset: 0x22782F1 VA: 0x22781F0
	private void TryInitializeData() { }

	// RVA: 0x2278450 Offset: 0x2278551 VA: 0x2278450
	private MapImage GetMapImage() { }

	// RVA: 0x22784D0 Offset: 0x22785D1 VA: 0x22784D0 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x2273960 Offset: 0x2273A61 VA: 0x2273960
	public void CreateTerrainMesh() { }

	// RVA: 0x2278560 Offset: 0x2278661 VA: 0x2278560
	public void CreateTerrainMesh(MapImage mapImage) { }

	// RVA: 0x22792A0 Offset: 0x22793A1 VA: 0x22792A0
	private void SetMeshToRenderer() { }

	// RVA: 0x2273F80 Offset: 0x2274081 VA: 0x2273F80
	public void UpdateMapSize() { }

	// RVA: 0x22793A0 Offset: 0x22794A1 VA: 0x22793A0
	public void .ctor() { }
}

