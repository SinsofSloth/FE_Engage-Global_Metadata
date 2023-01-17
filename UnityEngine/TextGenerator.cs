// Namespace: UnityEngine
[UsedByNativeCodeAttribute] // RVA: 0x48C7C0 Offset: 0x48C8C1 VA: 0x48C7C0
[NativeHeaderAttribute] // RVA: 0x48C7C0 Offset: 0x48C8C1 VA: 0x48C7C0
public sealed class TextGenerator : IDisposable // TypeDefIndex: 4061
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private string m_LastString; // 0x18
	private TextGenerationSettings m_LastSettings; // 0x20
	private bool m_HasGenerated; // 0x80
	private TextGenerationError m_LastValid; // 0x84
	private readonly List<UIVertex> m_Verts; // 0x88
	private readonly List<UICharInfo> m_Characters; // 0x90
	private readonly List<UILineInfo> m_Lines; // 0x98
	private bool m_CachedVerts; // 0xA0
	private bool m_CachedCharacters; // 0xA1
	private bool m_CachedLines; // 0xA2

	// Properties
	public int characterCountVisible { get; }
	public IList<UIVertex> verts { get; }
	public IList<UICharInfo> characters { get; }
	public IList<UILineInfo> lines { get; }
	public Rect rectExtents { get; }
	public int characterCount { get; }
	public int lineCount { get; }

	// Methods

	// RVA: 0x3F097C0 Offset: 0x3F098C1 VA: 0x3F097C0
	public void .ctor() { }

	// RVA: 0x3F097D0 Offset: 0x3F098D1 VA: 0x3F097D0
	public void .ctor(int initialCapacity) { }

	// RVA: 0x3F09990 Offset: 0x3F09A91 VA: 0x3F09990 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3F09A80 Offset: 0x3F09B81 VA: 0x3F09A80 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x3F09B60 Offset: 0x3F09C61 VA: 0x3F09B60
	public int get_characterCountVisible() { }

	// RVA: 0x3F09C00 Offset: 0x3F09D01 VA: 0x3F09C00
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x3F09F50 Offset: 0x3F0A051 VA: 0x3F09F50
	public void Invalidate() { }

	// RVA: 0x3F09F60 Offset: 0x3F0A061 VA: 0x3F09F60
	public void GetCharacters(List<UICharInfo> characters) { }

	// RVA: 0x3F0A000 Offset: 0x3F0A101 VA: 0x3F0A000
	public void GetLines(List<UILineInfo> lines) { }

	// RVA: 0x3F0A0A0 Offset: 0x3F0A1A1 VA: 0x3F0A0A0
	public void GetVertices(List<UIVertex> vertices) { }

	// RVA: 0x3F0A140 Offset: 0x3F0A241 VA: 0x3F0A140
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x3F0A410 Offset: 0x3F0A511 VA: 0x3F0A410
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x3F0A570 Offset: 0x3F0A671 VA: 0x3F0A570
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x3F0A2A0 Offset: 0x3F0A3A1 VA: 0x3F0A2A0
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x3F0A810 Offset: 0x3F0A911 VA: 0x3F0A810
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x3F0A8F0 Offset: 0x3F0A9F1 VA: 0x3F0A8F0
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x3F0AC30 Offset: 0x3F0AD31 VA: 0x3F0AC30
	public IList<UIVertex> get_verts() { }

	// RVA: 0x3F0ACA0 Offset: 0x3F0ADA1 VA: 0x3F0ACA0
	public IList<UICharInfo> get_characters() { }

	// RVA: 0x3F0AD10 Offset: 0x3F0AE11 VA: 0x3F0AD10
	public IList<UILineInfo> get_lines() { }

	// RVA: 0x3F0A3B0 Offset: 0x3F0A4B1 VA: 0x3F0A3B0
	public Rect get_rectExtents() { }

	// RVA: 0x3F09BB0 Offset: 0x3F09CB1 VA: 0x3F09BB0
	public int get_characterCount() { }

	// RVA: 0x3F0ADD0 Offset: 0x3F0AED1 VA: 0x3F0ADD0
	public int get_lineCount() { }

	[NativeMethodAttribute] // RVA: 0x48CB80 Offset: 0x48CC81 VA: 0x48CB80
	// RVA: 0x3F09950 Offset: 0x3F09A51 VA: 0x3F09950
	private static IntPtr Internal_Create() { }

	[NativeMethodAttribute] // RVA: 0x48CBC0 Offset: 0x48CCC1 VA: 0x48CBC0
	// RVA: 0x3F09B10 Offset: 0x3F09C11 VA: 0x3F09B10
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x3F0AE20 Offset: 0x3F0AF21 VA: 0x3F0AE20
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x3F0AA50 Offset: 0x3F0AB51 VA: 0x3F0AA50
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[NativeThrowsAttribute] // RVA: 0x48CC00 Offset: 0x48CD01 VA: 0x48CC00
	// RVA: 0x3F0A0F0 Offset: 0x3F0A1F1 VA: 0x3F0A0F0
	private void GetVerticesInternal(object vertices) { }

	[NativeThrowsAttribute] // RVA: 0x48CC10 Offset: 0x48CD11 VA: 0x48CC10
	// RVA: 0x3F09FB0 Offset: 0x3F0A0B1 VA: 0x3F09FB0
	private void GetCharactersInternal(object characters) { }

	[NativeThrowsAttribute] // RVA: 0x48CC20 Offset: 0x48CD21 VA: 0x48CC20
	// RVA: 0x3F0A050 Offset: 0x3F0A151 VA: 0x3F0A050
	private void GetLinesInternal(object lines) { }

	// RVA: 0x3F0AD80 Offset: 0x3F0AE81 VA: 0x3F0AD80
	private void get_rectExtents_Injected(out Rect ret) { }

	// RVA: 0x3F0AF80 Offset: 0x3F0B081 VA: 0x3F0AF80
	private bool Populate_Internal_Injected(string str, Font font, ref Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }
}

