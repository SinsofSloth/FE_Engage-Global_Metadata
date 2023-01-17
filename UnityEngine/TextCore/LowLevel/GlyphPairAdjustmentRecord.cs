// Namespace: UnityEngine.TextCore.LowLevel
[DebuggerDisplayAttribute] // RVA: 0x61280 Offset: 0x61381 VA: 0x61280
[UsedByNativeCodeAttribute] // RVA: 0x61280 Offset: 0x61381 VA: 0x61280
[Serializable]
public struct GlyphPairAdjustmentRecord // TypeDefIndex: 5713
{
	// Fields
	[NativeNameAttribute] // RVA: 0x62000 Offset: 0x62101 VA: 0x62000
	[SerializeField] // RVA: 0x62000 Offset: 0x62101 VA: 0x62000
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x0
	[SerializeField] // RVA: 0x62050 Offset: 0x62151 VA: 0x62050
	[NativeNameAttribute] // RVA: 0x62050 Offset: 0x62151 VA: 0x62050
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x14
	[SerializeField] // RVA: 0x620A0 Offset: 0x621A1 VA: 0x620A0
	private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x28

	// Properties
	public GlyphAdjustmentRecord firstAdjustmentRecord { get; }
	public GlyphAdjustmentRecord secondAdjustmentRecord { get; }

	// Methods

	// RVA: 0x1C5A6A0 Offset: 0x1C5A7A1 VA: 0x1C5A6A0
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x1C5A6C0 Offset: 0x1C5A7C1 VA: 0x1C5A6C0
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }
}

