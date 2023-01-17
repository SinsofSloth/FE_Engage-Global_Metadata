// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCodeAttribute] // RVA: 0x61270 Offset: 0x61371 VA: 0x61270
[Serializable]
public struct GlyphAdjustmentRecord // TypeDefIndex: 5712
{
	// Fields
	[SerializeField] // RVA: 0x61F60 Offset: 0x62061 VA: 0x61F60
	[NativeNameAttribute] // RVA: 0x61F60 Offset: 0x62061 VA: 0x61F60
	private uint m_GlyphIndex; // 0x0
	[SerializeField] // RVA: 0x61FB0 Offset: 0x620B1 VA: 0x61FB0
	[NativeNameAttribute] // RVA: 0x61FB0 Offset: 0x620B1 VA: 0x61FB0
	private GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; }
	public GlyphValueRecord glyphValueRecord { get; }

	// Methods

	// RVA: 0x1C5A450 Offset: 0x1C5A551 VA: 0x1C5A450
	public uint get_glyphIndex() { }

	// RVA: 0x1C5A460 Offset: 0x1C5A561 VA: 0x1C5A460
	public GlyphValueRecord get_glyphValueRecord() { }
}

