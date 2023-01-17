// Namespace: UnityEngine.TextCore
[UsedByNativeCodeAttribute] // RVA: 0x61230 Offset: 0x61331 VA: 0x61230
[Serializable]
public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 5708
{
	// Fields
	[NativeNameAttribute] // RVA: 0x61B00 Offset: 0x61C01 VA: 0x61B00
	[SerializeField] // RVA: 0x61B00 Offset: 0x61C01 VA: 0x61B00
	private float m_Width; // 0x0
	[NativeNameAttribute] // RVA: 0x61B50 Offset: 0x61C51 VA: 0x61B50
	[SerializeField] // RVA: 0x61B50 Offset: 0x61C51 VA: 0x61B50
	private float m_Height; // 0x4
	[SerializeField] // RVA: 0x61BA0 Offset: 0x61CA1 VA: 0x61BA0
	[NativeNameAttribute] // RVA: 0x61BA0 Offset: 0x61CA1 VA: 0x61BA0
	private float m_HorizontalBearingX; // 0x8
	[SerializeField] // RVA: 0x61BF0 Offset: 0x61CF1 VA: 0x61BF0
	[NativeNameAttribute] // RVA: 0x61BF0 Offset: 0x61CF1 VA: 0x61BF0
	private float m_HorizontalBearingY; // 0xC
	[NativeNameAttribute] // RVA: 0x61C40 Offset: 0x61D41 VA: 0x61C40
	[SerializeField] // RVA: 0x61C40 Offset: 0x61D41 VA: 0x61C40
	private float m_HorizontalAdvance; // 0x10

	// Properties
	public float width { get; }
	public float height { get; }
	public float horizontalBearingX { get; }
	public float horizontalBearingY { get; }
	public float horizontalAdvance { get; }

	// Methods

	// RVA: 0x1C5A470 Offset: 0x1C5A571 VA: 0x1C5A470
	public float get_width() { }

	// RVA: 0x1C5A480 Offset: 0x1C5A581 VA: 0x1C5A480
	public float get_height() { }

	// RVA: 0x1C5A490 Offset: 0x1C5A591 VA: 0x1C5A490
	public float get_horizontalBearingX() { }

	// RVA: 0x1C5A4A0 Offset: 0x1C5A5A1 VA: 0x1C5A4A0
	public float get_horizontalBearingY() { }

	// RVA: 0x1C5A4B0 Offset: 0x1C5A5B1 VA: 0x1C5A4B0
	public float get_horizontalAdvance() { }

	// RVA: 0x1C5A4C0 Offset: 0x1C5A5C1 VA: 0x1C5A4C0
	public void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	// RVA: 0x1C5A4E0 Offset: 0x1C5A5E1 VA: 0x1C5A4E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C5A560 Offset: 0x1C5A661 VA: 0x1C5A560 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C5A5F0 Offset: 0x1C5A6F1 VA: 0x1C5A5F0 Slot: 4
	public bool Equals(GlyphMetrics other) { }
}

