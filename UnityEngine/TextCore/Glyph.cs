// Namespace: UnityEngine.TextCore
[UsedByNativeCodeAttribute] // RVA: 0x61240 Offset: 0x61341 VA: 0x61240
[Serializable]
public class Glyph // TypeDefIndex: 5709
{
	// Fields
	[NativeNameAttribute] // RVA: 0x61C90 Offset: 0x61D91 VA: 0x61C90
	[SerializeField] // RVA: 0x61C90 Offset: 0x61D91 VA: 0x61C90
	private uint m_Index; // 0x10
	[NativeNameAttribute] // RVA: 0x61CE0 Offset: 0x61DE1 VA: 0x61CE0
	[SerializeField] // RVA: 0x61CE0 Offset: 0x61DE1 VA: 0x61CE0
	private GlyphMetrics m_Metrics; // 0x14
	[NativeNameAttribute] // RVA: 0x61D30 Offset: 0x61E31 VA: 0x61D30
	[SerializeField] // RVA: 0x61D30 Offset: 0x61E31 VA: 0x61D30
	private GlyphRect m_GlyphRect; // 0x28
	[NativeNameAttribute] // RVA: 0x61D80 Offset: 0x61E81 VA: 0x61D80
	[SerializeField] // RVA: 0x61D80 Offset: 0x61E81 VA: 0x61D80
	private float m_Scale; // 0x38
	[NativeNameAttribute] // RVA: 0x61DD0 Offset: 0x61ED1 VA: 0x61DD0
	[SerializeField] // RVA: 0x61DD0 Offset: 0x61ED1 VA: 0x61DD0
	private int m_AtlasIndex; // 0x3C

	// Properties
	public uint index { get; set; }
	public GlyphMetrics metrics { get; set; }
	public GlyphRect glyphRect { get; set; }
	public float scale { get; set; }
	public int atlasIndex { get; set; }

	// Methods

	// RVA: 0x1C5A2D0 Offset: 0x1C5A3D1 VA: 0x1C5A2D0
	public uint get_index() { }

	// RVA: 0x1C5A2E0 Offset: 0x1C5A3E1 VA: 0x1C5A2E0
	public void set_index(uint value) { }

	// RVA: 0x1C5A2F0 Offset: 0x1C5A3F1 VA: 0x1C5A2F0
	public GlyphMetrics get_metrics() { }

	// RVA: 0x1C5A310 Offset: 0x1C5A411 VA: 0x1C5A310
	public void set_metrics(GlyphMetrics value) { }

	// RVA: 0x1C5A330 Offset: 0x1C5A431 VA: 0x1C5A330
	public GlyphRect get_glyphRect() { }

	// RVA: 0x1C5A340 Offset: 0x1C5A441 VA: 0x1C5A340
	public void set_glyphRect(GlyphRect value) { }

	// RVA: 0x1C5A350 Offset: 0x1C5A451 VA: 0x1C5A350
	public float get_scale() { }

	// RVA: 0x1C5A360 Offset: 0x1C5A461 VA: 0x1C5A360
	public void set_scale(float value) { }

	// RVA: 0x1C5A370 Offset: 0x1C5A471 VA: 0x1C5A370
	public int get_atlasIndex() { }

	// RVA: 0x1C5A380 Offset: 0x1C5A481 VA: 0x1C5A380
	public void set_atlasIndex(int value) { }

	// RVA: 0x1C5A390 Offset: 0x1C5A491 VA: 0x1C5A390
	public void .ctor() { }

	// RVA: 0x1C58AC0 Offset: 0x1C58BC1 VA: 0x1C58AC0
	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x1C5A3D0 Offset: 0x1C5A4D1 VA: 0x1C5A3D0
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }
}

