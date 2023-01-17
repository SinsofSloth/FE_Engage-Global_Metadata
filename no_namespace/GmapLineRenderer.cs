// Namespace: 
private class GmapLineRenderer.LinePoint // TypeDefIndex: 10268
{
	// Fields
	private readonly Vector3[] vtxOffsets; // 0x10
	private readonly Vector2[] uv_table; // 0x18
	private Color m_Color; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x28DD40 Offset: 0x28DE41 VA: 0x28DD40
	private readonly int <index>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x28DD50 Offset: 0x28DE51 VA: 0x28DD50
	private readonly Vector3 <position>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x28DD60 Offset: 0x28DE61 VA: 0x28DD60
	private float <alpha>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x28DD70 Offset: 0x28DE71 VA: 0x28DD70
	private bool <isApperd>k__BackingField; // 0x44

	// Properties
	public int index { get; }
	public Vector3 position { get; }
	public Color color { get; set; }
	public float alpha { get; set; }
	public bool isApperd { get; set; }

	// Methods

	// RVA: 0x22ED2A0 Offset: 0x22ED3A1 VA: 0x22ED2A0
	public void .ctor(int index, Vector3 pos, Color color) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD850 Offset: 0x2BD951 VA: 0x2BD850
	// RVA: 0x22ED430 Offset: 0x22ED531 VA: 0x22ED430
	public int get_index() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD860 Offset: 0x2BD961 VA: 0x2BD860
	// RVA: 0x22ED440 Offset: 0x22ED541 VA: 0x22ED440
	public Vector3 get_position() { }

	// RVA: 0x22ED450 Offset: 0x22ED551 VA: 0x22ED450
	public Color get_color() { }

	// RVA: 0x22ED460 Offset: 0x22ED561 VA: 0x22ED460
	public void set_color(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD870 Offset: 0x2BD971 VA: 0x2BD870
	// RVA: 0x22ED480 Offset: 0x22ED581 VA: 0x22ED480
	public float get_alpha() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD880 Offset: 0x2BD981 VA: 0x2BD880
	// RVA: 0x22ED490 Offset: 0x22ED591 VA: 0x22ED490
	public void set_alpha(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD890 Offset: 0x2BD991 VA: 0x2BD890
	// RVA: 0x22ED4A0 Offset: 0x22ED5A1 VA: 0x22ED4A0
	public bool get_isApperd() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD8A0 Offset: 0x2BD9A1 VA: 0x2BD8A0
	// RVA: 0x22ED4B0 Offset: 0x22ED5B1 VA: 0x22ED4B0
	public void set_isApperd(bool value) { }

	// RVA: 0x22ED4C0 Offset: 0x22ED5C1 VA: 0x22ED4C0
	public void Add(ref List<Vector3> vertices, ref List<Color> colors, ref List<Vector2> uvs, ref List<int> indices, float size, float rotate = NaN) { }

	// RVA: 0x22ED940 Offset: 0x22EDA41 VA: 0x22ED940
	public void UpdateColor(ref List<Color> colors) { }

	// RVA: 0x22EDA00 Offset: 0x22EDB01 VA: 0x22EDA00
	public void Tick() { }
}

