// Namespace: UnityEngine.UI
[AddComponentMenu] // RVA: 0x43700 Offset: 0x43801 VA: 0x43700
public class Shadow : BaseMeshEffect // TypeDefIndex: 4374
{
	// Fields
	[SerializeField] // RVA: 0x457E0 Offset: 0x458E1 VA: 0x457E0
	private Color m_EffectColor; // 0x20
	[SerializeField] // RVA: 0x457F0 Offset: 0x458F1 VA: 0x457F0
	private Vector2 m_EffectDistance; // 0x30
	[SerializeField] // RVA: 0x45800 Offset: 0x45901 VA: 0x45800
	private bool m_UseGraphicAlpha; // 0x38
	private const float kMaxEffectDistance = 600;

	// Properties
	public Color effectColor { get; set; }
	public Vector2 effectDistance { get; set; }
	public bool useGraphicAlpha { get; set; }

	// Methods

	// RVA: 0x1B6E1D0 Offset: 0x1B6E2D1 VA: 0x1B6E1D0
	protected void .ctor() { }

	// RVA: 0x1B7EA20 Offset: 0x1B7EB21 VA: 0x1B7EA20
	public Color get_effectColor() { }

	// RVA: 0x1B7EA30 Offset: 0x1B7EB31 VA: 0x1B7EA30
	public void set_effectColor(Color value) { }

	// RVA: 0x1B7EB10 Offset: 0x1B7EC11 VA: 0x1B7EB10
	public Vector2 get_effectDistance() { }

	// RVA: 0x1B7EB20 Offset: 0x1B7EC21 VA: 0x1B7EB20
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x1B7EC60 Offset: 0x1B7ED61 VA: 0x1B7EC60
	public bool get_useGraphicAlpha() { }

	// RVA: 0x1B7EC70 Offset: 0x1B7ED71 VA: 0x1B7EC70
	public void set_useGraphicAlpha(bool value) { }

	// RVA: 0x1B6E4A0 Offset: 0x1B6E5A1 VA: 0x1B6E4A0
	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x1B7ED30 Offset: 0x1B7EE31 VA: 0x1B7ED30
	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x1B7ED40 Offset: 0x1B7EE41 VA: 0x1B7ED40 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }
}

