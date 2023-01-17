// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCodeAttribute] // RVA: 0x61260 Offset: 0x61361 VA: 0x61260
[Serializable]
public struct GlyphValueRecord : IEquatable<GlyphValueRecord> // TypeDefIndex: 5711
{
	// Fields
	[SerializeField] // RVA: 0x61E20 Offset: 0x61F21 VA: 0x61E20
	[NativeNameAttribute] // RVA: 0x61E20 Offset: 0x61F21 VA: 0x61E20
	private float m_XPlacement; // 0x0
	[SerializeField] // RVA: 0x61E70 Offset: 0x61F71 VA: 0x61E70
	[NativeNameAttribute] // RVA: 0x61E70 Offset: 0x61F71 VA: 0x61E70
	private float m_YPlacement; // 0x4
	[NativeNameAttribute] // RVA: 0x61EC0 Offset: 0x61FC1 VA: 0x61EC0
	[SerializeField] // RVA: 0x61EC0 Offset: 0x61FC1 VA: 0x61EC0
	private float m_XAdvance; // 0x8
	[SerializeField] // RVA: 0x61F10 Offset: 0x62011 VA: 0x61F10
	[NativeNameAttribute] // RVA: 0x61F10 Offset: 0x62011 VA: 0x61F10
	private float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; }
	public float yPlacement { get; }
	public float xAdvance { get; }
	public float yAdvance { get; }

	// Methods

	// RVA: 0x1C5A980 Offset: 0x1C5AA81 VA: 0x1C5A980
	public float get_xPlacement() { }

	// RVA: 0x1C5A990 Offset: 0x1C5AA91 VA: 0x1C5A990
	public float get_yPlacement() { }

	// RVA: 0x1C5A9A0 Offset: 0x1C5AAA1 VA: 0x1C5A9A0
	public float get_xAdvance() { }

	// RVA: 0x1C5A9B0 Offset: 0x1C5AAB1 VA: 0x1C5A9B0
	public float get_yAdvance() { }

	// RVA: 0x1C5A9C0 Offset: 0x1C5AAC1 VA: 0x1C5A9C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C5AA30 Offset: 0x1C5AB31 VA: 0x1C5AA30 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C5AAB0 Offset: 0x1C5ABB1 VA: 0x1C5AAB0 Slot: 4
	public bool Equals(GlyphValueRecord other) { }
}

