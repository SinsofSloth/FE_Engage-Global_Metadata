// Namespace: UnityEngine
public struct TextGenerationSettings // TypeDefIndex: 4060
{
	// Fields
	public Font font; // 0x0
	public Color color; // 0x8
	public int fontSize; // 0x18
	public float lineSpacing; // 0x1C
	public bool richText; // 0x20
	public float scaleFactor; // 0x24
	public FontStyle fontStyle; // 0x28
	public TextAnchor textAnchor; // 0x2C
	public bool alignByGeometry; // 0x30
	public bool resizeTextForBestFit; // 0x31
	public int resizeTextMinSize; // 0x34
	public int resizeTextMaxSize; // 0x38
	public bool updateBounds; // 0x3C
	public VerticalWrapMode verticalOverflow; // 0x40
	public HorizontalWrapMode horizontalOverflow; // 0x44
	public Vector2 generationExtents; // 0x48
	public Vector2 pivot; // 0x50
	public bool generateOutOfBounds; // 0x58

	// Methods

	// RVA: 0x3F09450 Offset: 0x3F09551 VA: 0x3F09450
	private bool CompareColors(Color left, Color right) { }

	// RVA: 0x3F094F0 Offset: 0x3F095F1 VA: 0x3F094F0
	private bool CompareVector2(Vector2 left, Vector2 right) { }

	// RVA: 0x3F09540 Offset: 0x3F09641 VA: 0x3F09540
	public bool Equals(TextGenerationSettings other) { }
}

