// Namespace: 
[Serializable]
public struct TexturePacker_JsonArray.SpriteFrame // TypeDefIndex: 7491
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float w; // 0x8
	public float h; // 0xC

	// Methods

	// RVA: 0x1C120B0 Offset: 0x1C121B1 VA: 0x1C120B0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Serializable]
public struct TexturePacker_JsonArray.SpriteSize // TypeDefIndex: 7492
{
	// Fields
	public float w; // 0x0
	public float h; // 0x4

	// Methods

	// RVA: 0x1C123D0 Offset: 0x1C124D1 VA: 0x1C123D0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[Serializable]
public struct TexturePacker_JsonArray.Frame // TypeDefIndex: 7493
{
	// Fields
	public string filename; // 0x0
	public TexturePacker_JsonArray.SpriteFrame frame; // 0x8
	public bool rotated; // 0x18
	public bool trimmed; // 0x19
	public TexturePacker_JsonArray.SpriteFrame spriteSourceSize; // 0x1C
	public TexturePacker_JsonArray.SpriteSize sourceSize; // 0x2C
	public Vector2 pivot; // 0x34
}

// Namespace: 
[Serializable]
public struct TexturePacker_JsonArray.Meta // TypeDefIndex: 7494
{
	// Fields
	public string app; // 0x0
	public string version; // 0x8
	public string image; // 0x10
	public string format; // 0x18
	public TexturePacker_JsonArray.SpriteSize size; // 0x20
	public float scale; // 0x28
	public string smartupdate; // 0x30
}

// Namespace: 
[Serializable]
public class TexturePacker_JsonArray.SpriteDataObject // TypeDefIndex: 7495
{
	// Fields
	public List<TexturePacker_JsonArray.Frame> frames; // 0x10
	public TexturePacker_JsonArray.Meta meta; // 0x18

	// Methods

	// RVA: 0x1C120A0 Offset: 0x1C121A1 VA: 0x1C120A0
	public void .ctor() { }
}

