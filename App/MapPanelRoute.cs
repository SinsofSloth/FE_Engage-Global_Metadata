// Namespace: App
public class MapPanelRoute : MapPanelBase<MapPanelRoute> // TypeDefIndex: 9065
{
	// Fields
	private Dir.Type[] m_Routes; // 0x40

	// Properties
	public Dir.Type[] Routes { get; }

	// Methods

	// RVA: 0x2784B50 Offset: 0x2784C51 VA: 0x2784B50
	public void .ctor() { }

	// RVA: 0x2784C70 Offset: 0x2784D71 VA: 0x2784C70
	private void Update() { }

	// RVA: 0x2784C80 Offset: 0x2784D81 VA: 0x2784C80
	public void SetupRoute() { }

	// RVA: 0x2784F80 Offset: 0x2785081 VA: 0x2784F80
	private void SetupResumeRoute(Dir.Type[] routes) { }

	// RVA: 0x2786CB0 Offset: 0x2786DB1 VA: 0x2786CB0
	public void SetTransparent(bool enable = True) { }

	// RVA: 0x2786D20 Offset: 0x2786E21 VA: 0x2786D20
	private void Save(Dir.Type[] routes) { }

	// RVA: 0x2784C30 Offset: 0x2784D31 VA: 0x2784C30
	public void Reset() { }

	// RVA: 0x2786D40 Offset: 0x2786E41 VA: 0x2786D40
	public bool IsRoute() { }

	// RVA: 0x27850C0 Offset: 0x27851C1 VA: 0x27850C0
	private Vector2 GetUV(Dir.Type oldDir, Dir.Type curDir) { }

	// RVA: 0x27852C0 Offset: 0x27853C1 VA: 0x27852C0
	private void AddVerticalVertex(Dir.Type oldDir, int oldX, int oldZ, int x, int z) { }

	// RVA: 0x2786BE0 Offset: 0x2786CE1 VA: 0x2786BE0
	private void AddHeadVertex(Dir.Type oldDir, int x, int z) { }

	// RVA: 0x2785220 Offset: 0x2785321 VA: 0x2785220
	private void AddCell(int x, int z, Vector2 uv) { }

	// RVA: 0x2786D80 Offset: 0x2786E81 VA: 0x2786D80
	private void AddCell(int x, int z, Color color, Vector2 uv0, Vector3 uv2) { }

	// RVA: 0x27874F0 Offset: 0x27875F1 VA: 0x27874F0
	public Dir.Type[] get_Routes() { }
}

