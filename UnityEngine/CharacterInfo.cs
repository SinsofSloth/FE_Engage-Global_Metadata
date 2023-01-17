// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x48C8F0 Offset: 0x48C9F1 VA: 0x48C8F0
public struct CharacterInfo // TypeDefIndex: 4066
{
	// Fields
	public int index; // 0x0
	[ObsoleteAttribute] // RVA: 0x48C9E0 Offset: 0x48CAE1 VA: 0x48C9E0
	public Rect uv; // 0x4
	[ObsoleteAttribute] // RVA: 0x48CA20 Offset: 0x48CB21 VA: 0x48CA20
	public Rect vert; // 0x14
	[NativeNameAttribute] // RVA: 0x48CA60 Offset: 0x48CB61 VA: 0x48CA60
	[ObsoleteAttribute] // RVA: 0x48CA60 Offset: 0x48CB61 VA: 0x48CA60
	public float width; // 0x24
	public int size; // 0x28
	public FontStyle style; // 0x2C
	[ObsoleteAttribute] // RVA: 0x48CAC0 Offset: 0x48CBC1 VA: 0x48CAC0
	public bool flipped; // 0x30

	// Properties
	public int glyphWidth { get; }
	public int glyphHeight { get; }
	public int minY { get; }
	internal Vector2 uvBottomLeftUnFlipped { get; }
	internal Vector2 uvBottomRightUnFlipped { get; }
	internal Vector2 uvTopRightUnFlipped { get; }
	internal Vector2 uvTopLeftUnFlipped { get; }
	public Vector2 uvBottomLeft { get; }
	public Vector2 uvBottomRight { get; }
	public Vector2 uvTopRight { get; }
	public Vector2 uvTopLeft { get; }

	// Methods

	// RVA: 0x3F08980 Offset: 0x3F08A81 VA: 0x3F08980
	public int get_glyphWidth() { }

	// RVA: 0x3F089C0 Offset: 0x3F08AC1 VA: 0x3F089C0
	public int get_glyphHeight() { }

	// RVA: 0x3F08A00 Offset: 0x3F08B01 VA: 0x3F08A00
	public int get_minY() { }

	// RVA: 0x3F08A60 Offset: 0x3F08B61 VA: 0x3F08A60
	internal Vector2 get_uvBottomLeftUnFlipped() { }

	// RVA: 0x3F08AB0 Offset: 0x3F08BB1 VA: 0x3F08AB0
	internal Vector2 get_uvBottomRightUnFlipped() { }

	// RVA: 0x3F08B10 Offset: 0x3F08C11 VA: 0x3F08B10
	internal Vector2 get_uvTopRightUnFlipped() { }

	// RVA: 0x3F08B90 Offset: 0x3F08C91 VA: 0x3F08B90
	internal Vector2 get_uvTopLeftUnFlipped() { }

	// RVA: 0x3F08BF0 Offset: 0x3F08CF1 VA: 0x3F08BF0
	public Vector2 get_uvBottomLeft() { }

	// RVA: 0x3F08C40 Offset: 0x3F08D41 VA: 0x3F08C40
	public Vector2 get_uvBottomRight() { }

	// RVA: 0x3F08CC0 Offset: 0x3F08DC1 VA: 0x3F08CC0
	public Vector2 get_uvTopRight() { }

	// RVA: 0x3F08D40 Offset: 0x3F08E41 VA: 0x3F08D40
	public Vector2 get_uvTopLeft() { }
}

