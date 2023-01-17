// Namespace: UnityEngine.TextCore
[UsedByNativeCodeAttribute] // RVA: 0x61220 Offset: 0x61321 VA: 0x61220
[Serializable]
public struct GlyphRect : IEquatable<GlyphRect> // TypeDefIndex: 5707
{
	// Fields
	[SerializeField] // RVA: 0x619C0 Offset: 0x61AC1 VA: 0x619C0
	[NativeNameAttribute] // RVA: 0x619C0 Offset: 0x61AC1 VA: 0x619C0
	private int m_X; // 0x0
	[SerializeField] // RVA: 0x61A10 Offset: 0x61B11 VA: 0x61A10
	[NativeNameAttribute] // RVA: 0x61A10 Offset: 0x61B11 VA: 0x61A10
	private int m_Y; // 0x4
	[NativeNameAttribute] // RVA: 0x61A60 Offset: 0x61B61 VA: 0x61A60
	[SerializeField] // RVA: 0x61A60 Offset: 0x61B61 VA: 0x61A60
	private int m_Width; // 0x8
	[NativeNameAttribute] // RVA: 0x61AB0 Offset: 0x61BB1 VA: 0x61AB0
	[SerializeField] // RVA: 0x61AB0 Offset: 0x61BB1 VA: 0x61AB0
	private int m_Height; // 0xC
	private static readonly GlyphRect s_ZeroGlyphRect; // 0x0

	// Properties
	public int x { get; }
	public int y { get; }
	public int width { get; }
	public int height { get; }
	public static GlyphRect zero { get; }

	// Methods

	// RVA: 0x1C5A6E0 Offset: 0x1C5A7E1 VA: 0x1C5A6E0
	public int get_x() { }

	// RVA: 0x1C5A6F0 Offset: 0x1C5A7F1 VA: 0x1C5A6F0
	public int get_y() { }

	// RVA: 0x1C5A700 Offset: 0x1C5A801 VA: 0x1C5A700
	public int get_width() { }

	// RVA: 0x1C5A710 Offset: 0x1C5A811 VA: 0x1C5A710
	public int get_height() { }

	// RVA: 0x1C5A720 Offset: 0x1C5A821 VA: 0x1C5A720
	public static GlyphRect get_zero() { }

	// RVA: 0x1C5A790 Offset: 0x1C5A891 VA: 0x1C5A790
	public void .ctor(int x, int y, int width, int height) { }

	// RVA: 0x1C5A7A0 Offset: 0x1C5A8A1 VA: 0x1C5A7A0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C5A810 Offset: 0x1C5A911 VA: 0x1C5A810 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C5A890 Offset: 0x1C5A991 VA: 0x1C5A890 Slot: 4
	public bool Equals(GlyphRect other) { }

	// RVA: 0x1C5A930 Offset: 0x1C5AA31 VA: 0x1C5A930
	private static void .cctor() { }
}

