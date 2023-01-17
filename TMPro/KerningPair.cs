// Namespace: TMPro
[Serializable]
public class KerningPair // TypeDefIndex: 7371
{
	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0x4D710 Offset: 0x4D811 VA: 0x4D710
	[SerializeField] // RVA: 0x4D710 Offset: 0x4D811 VA: 0x4D710
	private uint m_FirstGlyph; // 0x10
	[SerializeField] // RVA: 0x4D760 Offset: 0x4D861 VA: 0x4D760
	private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
	[FormerlySerializedAsAttribute] // RVA: 0x4D770 Offset: 0x4D871 VA: 0x4D770
	[SerializeField] // RVA: 0x4D770 Offset: 0x4D871 VA: 0x4D770
	private uint m_SecondGlyph; // 0x24
	[SerializeField] // RVA: 0x4D7C0 Offset: 0x4D8C1 VA: 0x4D7C0
	private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0x4D7D0 Offset: 0x4D8D1 VA: 0x4D7D0
	public float xOffset; // 0x38
	internal static KerningPair empty; // 0x0
	[SerializeField] // RVA: 0x4D810 Offset: 0x4D911 VA: 0x4D810
	private bool m_IgnoreSpacingAdjustments; // 0x3C

	// Properties
	public uint firstGlyph { get; set; }
	public GlyphValueRecord_Legacy firstGlyphAdjustments { get; }
	public uint secondGlyph { get; set; }
	public GlyphValueRecord_Legacy secondGlyphAdjustments { get; }
	public bool ignoreSpacingAdjustments { get; }

	// Methods

	// RVA: 0x192DE70 Offset: 0x192DF71 VA: 0x192DE70
	public uint get_firstGlyph() { }

	// RVA: 0x192DE80 Offset: 0x192DF81 VA: 0x192DE80
	public void set_firstGlyph(uint value) { }

	// RVA: 0x192DE90 Offset: 0x192DF91 VA: 0x192DE90
	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	// RVA: 0x192DEA0 Offset: 0x192DFA1 VA: 0x192DEA0
	public uint get_secondGlyph() { }

	// RVA: 0x192DEB0 Offset: 0x192DFB1 VA: 0x192DEB0
	public void set_secondGlyph(uint value) { }

	// RVA: 0x192DEC0 Offset: 0x192DFC1 VA: 0x192DEC0
	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	// RVA: 0x192DED0 Offset: 0x192DFD1 VA: 0x192DED0
	public bool get_ignoreSpacingAdjustments() { }

	// RVA: 0x192DEE0 Offset: 0x192DFE1 VA: 0x192DEE0
	public void .ctor() { }

	// RVA: 0x192DF10 Offset: 0x192E011 VA: 0x192DF10
	public void .ctor(uint left, uint right, float offset) { }

	// RVA: 0x192DF60 Offset: 0x192E061 VA: 0x192DF60
	public void .ctor(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	// RVA: 0x192E000 Offset: 0x192E101 VA: 0x192E000
	internal void ConvertLegacyKerningData() { }

	// RVA: 0x192E010 Offset: 0x192E111 VA: 0x192E010
	private static void .cctor() { }
}

