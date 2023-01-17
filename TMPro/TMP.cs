// Namespace: TMPro
[Serializable]
public class TMP_Character : TMP_TextElement // TypeDefIndex: 7336
{
	// Methods

	// RVA: 0x1932C40 Offset: 0x1932D41 VA: 0x1932C40
	public void .ctor() { }

	// RVA: 0x1932C80 Offset: 0x1932D81 VA: 0x1932C80
	public void .ctor(uint unicode, Glyph glyph) { }

	// RVA: 0x1932D00 Offset: 0x1932E01 VA: 0x1932D00
	public void .ctor(uint unicode, TMP_FontAsset fontAsset, Glyph glyph) { }

	// RVA: 0x1932D80 Offset: 0x1932E81 VA: 0x1932D80
	internal void .ctor(uint unicode, uint glyphIndex) { }
}

// Namespace: TMPro
public struct TMP_Offset // TypeDefIndex: 7338
{
	// Fields
	private float m_Left; // 0x0
	private float m_Right; // 0x4
	private float m_Top; // 0x8
	private float m_Bottom; // 0xC
	private static readonly TMP_Offset k_ZeroOffset; // 0x0

	// Properties
	public float left { get; set; }
	public float right { get; set; }
	public float top { get; set; }
	public float bottom { get; set; }
	public float horizontal { get; set; }
	public float vertical { get; set; }
	public static TMP_Offset zero { get; }

	// Methods

	// RVA: 0x18F3F10 Offset: 0x18F4011 VA: 0x18F3F10
	public float get_left() { }

	// RVA: 0x18F3F20 Offset: 0x18F4021 VA: 0x18F3F20
	public void set_left(float value) { }

	// RVA: 0x18F3F30 Offset: 0x18F4031 VA: 0x18F3F30
	public float get_right() { }

	// RVA: 0x18F3F40 Offset: 0x18F4041 VA: 0x18F3F40
	public void set_right(float value) { }

	// RVA: 0x18F3F50 Offset: 0x18F4051 VA: 0x18F3F50
	public float get_top() { }

	// RVA: 0x18F3F60 Offset: 0x18F4061 VA: 0x18F3F60
	public void set_top(float value) { }

	// RVA: 0x18F3F70 Offset: 0x18F4071 VA: 0x18F3F70
	public float get_bottom() { }

	// RVA: 0x18F3F80 Offset: 0x18F4081 VA: 0x18F3F80
	public void set_bottom(float value) { }

	// RVA: 0x18F3F90 Offset: 0x18F4091 VA: 0x18F3F90
	public float get_horizontal() { }

	// RVA: 0x18F3FA0 Offset: 0x18F40A1 VA: 0x18F3FA0
	public void set_horizontal(float value) { }

	// RVA: 0x18F3FB0 Offset: 0x18F40B1 VA: 0x18F3FB0
	public float get_vertical() { }

	// RVA: 0x18F3FC0 Offset: 0x18F40C1 VA: 0x18F3FC0
	public void set_vertical(float value) { }

	// RVA: 0x18F3FD0 Offset: 0x18F40D1 VA: 0x18F3FD0
	public static TMP_Offset get_zero() { }

	// RVA: 0x18F4040 Offset: 0x18F4141 VA: 0x18F4040
	public void .ctor(float left, float right, float top, float bottom) { }

	// RVA: 0x18F4060 Offset: 0x18F4161 VA: 0x18F4060
	public void .ctor(float horizontal, float vertical) { }

	// RVA: 0x18F4080 Offset: 0x18F4181 VA: 0x18F4080
	public static bool op_Equality(TMP_Offset lhs, TMP_Offset rhs) { }

	// RVA: 0x18F40B0 Offset: 0x18F41B1 VA: 0x18F40B0
	public static bool op_Inequality(TMP_Offset lhs, TMP_Offset rhs) { }

	// RVA: 0x18F4170 Offset: 0x18F4271 VA: 0x18F4170
	public static TMP_Offset op_Multiply(TMP_Offset a, float b) { }

	// RVA: 0x18F4190 Offset: 0x18F4291 VA: 0x18F4190 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18F4200 Offset: 0x18F4301 VA: 0x18F4200 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x18F4280 Offset: 0x18F4381 VA: 0x18F4280
	public bool Equals(TMP_Offset other) { }

	// RVA: 0x18F4340 Offset: 0x18F4441 VA: 0x18F4340
	private static void .cctor() { }
}

// Namespace: TMPro
[DebuggerDisplayAttribute] // RVA: 0x4CBD0 Offset: 0x4CCD1 VA: 0x4CBD0
public struct TMP_CharacterInfo // TypeDefIndex: 7340
{
	// Fields
	public char character; // 0x0
	public int index; // 0x4
	public int stringLength; // 0x8
	public TMP_TextElementType elementType; // 0xC
	public TMP_TextElement textElement; // 0x10
	public TMP_FontAsset fontAsset; // 0x18
	public TMP_SpriteAsset spriteAsset; // 0x20
	public int spriteIndex; // 0x28
	public Material material; // 0x30
	public int materialReferenceIndex; // 0x38
	public bool isUsingAlternateTypeface; // 0x3C
	public float pointSize; // 0x40
	public int lineNumber; // 0x44
	public int pageNumber; // 0x48
	public int vertexIndex; // 0x4C
	public TMP_Vertex vertex_BL; // 0x50
	public TMP_Vertex vertex_TL; // 0x78
	public TMP_Vertex vertex_TR; // 0xA0
	public TMP_Vertex vertex_BR; // 0xC8
	public Vector3 topLeft; // 0xF0
	public Vector3 bottomLeft; // 0xFC
	public Vector3 topRight; // 0x108
	public Vector3 bottomRight; // 0x114
	public float origin; // 0x120
	public float xAdvance; // 0x124
	public float ascender; // 0x128
	public float baseLine; // 0x12C
	public float descender; // 0x130
	internal float adjustedAscender; // 0x134
	internal float adjustedDescender; // 0x138
	public float aspectRatio; // 0x13C
	public float scale; // 0x140
	public Color32 color; // 0x144
	public Color32 underlineColor; // 0x148
	public int underlineVertexIndex; // 0x14C
	public Color32 strikethroughColor; // 0x150
	public int strikethroughVertexIndex; // 0x154
	public Color32 highlightColor; // 0x158
	public HighlightState highlightState; // 0x15C
	public FontStyles style; // 0x170
	public bool isVisible; // 0x174
}

// Namespace: TMPro
[ExcludeFromPresetAttribute] // RVA: 0x4CC10 Offset: 0x4CD11 VA: 0x4CC10
[Serializable]
public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 7342
{
	// Fields
	public ColorMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0

	// Methods

	// RVA: 0x1932DF0 Offset: 0x1932EF1 VA: 0x1932DF0
	public void .ctor() { }

	// RVA: 0x1932EC0 Offset: 0x1932FC1 VA: 0x1932EC0
	public void .ctor(Color color) { }

	// RVA: 0x1932F50 Offset: 0x1933051 VA: 0x1932F50
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0x1933030 Offset: 0x1933131 VA: 0x1933030
	private static void .cctor() { }
}

// Namespace: TMPro
public static class TMP_Compatibility // TypeDefIndex: 7344
{
	// Methods

	// RVA: 0x1933090 Offset: 0x1933191 VA: 0x1933090
	public static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue) { }
}

// Namespace: TMPro
public static class TMP_DefaultControls // TypeDefIndex: 7354
{
	// Fields
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_TextElementSize; // 0x0
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Color s_DefaultSelectableColor; // 0x18
	private static Color s_TextColor; // 0x28

	// Methods

	// RVA: 0x19330C0 Offset: 0x19331C1 VA: 0x19330C0
	private static GameObject CreateUIElementRoot(string name, Vector2 size) { }

	// RVA: 0x1933170 Offset: 0x1933271 VA: 0x1933170
	private static GameObject CreateUIObject(string name, GameObject parent) { }

	// RVA: 0x1933340 Offset: 0x1933441 VA: 0x1933340
	private static void SetDefaultTextValues(TMP_Text lbl) { }

	// RVA: 0x19333E0 Offset: 0x19334E1 VA: 0x19333E0
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x1933240 Offset: 0x1933341 VA: 0x1933240
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x1933470 Offset: 0x1933571 VA: 0x1933470
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x1933560 Offset: 0x1933661 VA: 0x1933560
	public static GameObject CreateScrollbar(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x19338B0 Offset: 0x19339B1 VA: 0x19338B0
	public static GameObject CreateButton(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x1933C40 Offset: 0x1933D41 VA: 0x1933C40
	public static GameObject CreateText(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x1933D70 Offset: 0x1933E71 VA: 0x1933D70
	public static GameObject CreateInputField(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x19343F0 Offset: 0x19344F1 VA: 0x19343F0
	public static GameObject CreateDropdown(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x1935480 Offset: 0x1935581 VA: 0x1935480
	private static void .cctor() { }
}

// Namespace: TMPro
[ExcludeFromPresetAttribute] // RVA: 0x4CCE0 Offset: 0x4CDE1 VA: 0x4CCE0
[Serializable]
public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 7364
{
	// Fields
	[SerializeField] // RVA: 0x4D520 Offset: 0x4D621 VA: 0x4D520
	private string m_Version; // 0x30
	[SerializeField] // RVA: 0x4D530 Offset: 0x4D631 VA: 0x4D530
	internal string m_SourceFontFileGUID; // 0x38
	[SerializeField] // RVA: 0x4D540 Offset: 0x4D641 VA: 0x4D540
	private Font m_SourceFontFile; // 0x40
	[SerializeField] // RVA: 0x4D550 Offset: 0x4D651 VA: 0x4D550
	private AtlasPopulationMode m_AtlasPopulationMode; // 0x48
	[SerializeField] // RVA: 0x4D560 Offset: 0x4D661 VA: 0x4D560
	internal FaceInfo m_FaceInfo; // 0x50
	[SerializeField] // RVA: 0x4D570 Offset: 0x4D671 VA: 0x4D570
	internal List<Glyph> m_GlyphTable; // 0xB0
	internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0xB8
	[SerializeField] // RVA: 0x4D580 Offset: 0x4D681 VA: 0x4D580
	internal List<TMP_Character> m_CharacterTable; // 0xC0
	internal Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0xC8
	internal Texture2D m_AtlasTexture; // 0xD0
	[SerializeField] // RVA: 0x4D590 Offset: 0x4D691 VA: 0x4D590
	internal Texture2D[] m_AtlasTextures; // 0xD8
	[SerializeField] // RVA: 0x4D5A0 Offset: 0x4D6A1 VA: 0x4D5A0
	internal int m_AtlasTextureIndex; // 0xE0
	[SerializeField] // RVA: 0x4D5B0 Offset: 0x4D6B1 VA: 0x4D5B0
	private bool m_IsMultiAtlasTexturesEnabled; // 0xE4
	[SerializeField] // RVA: 0x4D5C0 Offset: 0x4D6C1 VA: 0x4D5C0
	private bool m_ClearDynamicDataOnBuild; // 0xE5
	[SerializeField] // RVA: 0x4D5D0 Offset: 0x4D6D1 VA: 0x4D5D0
	private List<GlyphRect> m_UsedGlyphRects; // 0xE8
	[SerializeField] // RVA: 0x4D5E0 Offset: 0x4D6E1 VA: 0x4D5E0
	private List<GlyphRect> m_FreeGlyphRects; // 0xF0
	[SerializeField] // RVA: 0x4D5F0 Offset: 0x4D6F1 VA: 0x4D5F0
	private FaceInfo_Legacy m_fontInfo; // 0xF8
	[SerializeField] // RVA: 0x4D600 Offset: 0x4D701 VA: 0x4D600
	public Texture2D atlas; // 0x100
	[SerializeField] // RVA: 0x4D610 Offset: 0x4D711 VA: 0x4D610
	internal int m_AtlasWidth; // 0x108
	[SerializeField] // RVA: 0x4D620 Offset: 0x4D721 VA: 0x4D620
	internal int m_AtlasHeight; // 0x10C
	[SerializeField] // RVA: 0x4D630 Offset: 0x4D731 VA: 0x4D630
	internal int m_AtlasPadding; // 0x110
	[SerializeField] // RVA: 0x4D640 Offset: 0x4D741 VA: 0x4D640
	internal GlyphRenderMode m_AtlasRenderMode; // 0x114
	[SerializeField] // RVA: 0x4D650 Offset: 0x4D751 VA: 0x4D650
	internal List<TMP_Glyph> m_glyphInfoList; // 0x118
	[FormerlySerializedAsAttribute] // RVA: 0x4D660 Offset: 0x4D761 VA: 0x4D660
	[SerializeField] // RVA: 0x4D660 Offset: 0x4D761 VA: 0x4D660
	internal KerningTable m_KerningTable; // 0x120
	[SerializeField] // RVA: 0x4D6B0 Offset: 0x4D7B1 VA: 0x4D6B0
	internal TMP_FontFeatureTable m_FontFeatureTable; // 0x128
	[SerializeField] // RVA: 0x4D6C0 Offset: 0x4D7C1 VA: 0x4D6C0
	private List<TMP_FontAsset> fallbackFontAssets; // 0x130
	[SerializeField] // RVA: 0x4D6D0 Offset: 0x4D7D1 VA: 0x4D6D0
	internal List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x138
	[SerializeField] // RVA: 0x4D6E0 Offset: 0x4D7E1 VA: 0x4D6E0
	internal FontAssetCreationSettings m_CreationSettings; // 0x140
	[SerializeField] // RVA: 0x4D6F0 Offset: 0x4D7F1 VA: 0x4D6F0
	private TMP_FontWeightPair[] m_FontWeightTable; // 0x198
	[SerializeField] // RVA: 0x4D700 Offset: 0x4D801 VA: 0x4D700
	private TMP_FontWeightPair[] fontWeights; // 0x1A0
	public float normalStyle; // 0x1A8
	public float normalSpacingOffset; // 0x1AC
	public float boldStyle; // 0x1B0
	public float boldSpacing; // 0x1B4
	public byte italicStyle; // 0x1B8
	public byte tabSize; // 0x1B9
	internal bool IsFontAssetLookupTablesDirty; // 0x1BA
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x0
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x8
	private static ProfilerMarker k_TryAddCharacterMarker; // 0x10
	private static ProfilerMarker k_TryAddCharactersMarker; // 0x18
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x20
	private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x28
	private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x30
	private static string s_DefaultMaterialSuffix; // 0x38
	internal HashSet<int> FallbackSearchQueryLookup; // 0x1C0
	private static HashSet<int> k_SearchedFontAssetLookup; // 0x40
	private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x48
	private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x50
	private static List<TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue; // 0x58
	private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x60
	private List<Glyph> m_GlyphsToRender; // 0x1C8
	private List<Glyph> m_GlyphsRendered; // 0x1D0
	private List<uint> m_GlyphIndexList; // 0x1D8
	private List<uint> m_GlyphIndexListNewlyAdded; // 0x1E0
	internal List<uint> m_GlyphsToAdd; // 0x1E8
	internal HashSet<uint> m_GlyphsToAddLookup; // 0x1F0
	internal List<TMP_Character> m_CharactersToAdd; // 0x1F8
	internal HashSet<uint> m_CharactersToAddLookup; // 0x200
	internal List<uint> s_MissingCharacterList; // 0x208
	internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x210
	internal static uint[] k_GlyphIndexArray; // 0x68

	// Properties
	public string version { get; set; }
	public Font sourceFontFile { get; set; }
	public AtlasPopulationMode atlasPopulationMode { get; set; }
	public FaceInfo faceInfo { get; set; }
	public List<Glyph> glyphTable { get; set; }
	public Dictionary<uint, Glyph> glyphLookupTable { get; }
	public List<TMP_Character> characterTable { get; set; }
	public Dictionary<uint, TMP_Character> characterLookupTable { get; }
	public Texture2D atlasTexture { get; }
	public Texture2D[] atlasTextures { get; set; }
	public int atlasTextureCount { get; }
	public bool isMultiAtlasTexturesEnabled { get; set; }
	internal bool clearDynamicDataOnBuild { get; set; }
	internal List<GlyphRect> usedGlyphRects { get; set; }
	internal List<GlyphRect> freeGlyphRects { get; set; }
	[ObsoleteAttribute] // RVA: 0x4ECB0 Offset: 0x4EDB1 VA: 0x4ECB0
	public FaceInfo_Legacy fontInfo { get; }
	public int atlasWidth { get; set; }
	public int atlasHeight { get; set; }
	public int atlasPadding { get; set; }
	public GlyphRenderMode atlasRenderMode { get; set; }
	public TMP_FontFeatureTable fontFeatureTable { get; set; }
	public List<TMP_FontAsset> fallbackFontAssetTable { get; set; }
	public FontAssetCreationSettings creationSettings { get; set; }
	public TMP_FontWeightPair[] fontWeightTable { get; set; }

	// Methods

	// RVA: 0x1938710 Offset: 0x1938811 VA: 0x1938710
	public string get_version() { }

	// RVA: 0x1938720 Offset: 0x1938821 VA: 0x1938720
	internal void set_version(string value) { }

	// RVA: 0x1938730 Offset: 0x1938831 VA: 0x1938730
	public Font get_sourceFontFile() { }

	// RVA: 0x1938740 Offset: 0x1938841 VA: 0x1938740
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x1938750 Offset: 0x1938851 VA: 0x1938750
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x1938760 Offset: 0x1938861 VA: 0x1938760
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0x1938770 Offset: 0x1938871 VA: 0x1938770
	public FaceInfo get_faceInfo() { }

	// RVA: 0x19387B0 Offset: 0x19388B1 VA: 0x19387B0
	public void set_faceInfo(FaceInfo value) { }

	// RVA: 0x19387E0 Offset: 0x19388E1 VA: 0x19387E0
	public List<Glyph> get_glyphTable() { }

	// RVA: 0x19387F0 Offset: 0x19388F1 VA: 0x19387F0
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0x1938800 Offset: 0x1938901 VA: 0x1938800
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x1938AB0 Offset: 0x1938BB1 VA: 0x1938AB0
	public List<TMP_Character> get_characterTable() { }

	// RVA: 0x1938AC0 Offset: 0x1938BC1 VA: 0x1938AC0
	internal void set_characterTable(List<TMP_Character> value) { }

	// RVA: 0x1938AD0 Offset: 0x1938BD1 VA: 0x1938AD0
	public Dictionary<uint, TMP_Character> get_characterLookupTable() { }

	// RVA: 0x1938B10 Offset: 0x1938C11 VA: 0x1938B10
	public Texture2D get_atlasTexture() { }

	// RVA: 0x1938BC0 Offset: 0x1938CC1 VA: 0x1938BC0
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0x1938BD0 Offset: 0x1938CD1 VA: 0x1938BD0
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x1938BE0 Offset: 0x1938CE1 VA: 0x1938BE0
	public int get_atlasTextureCount() { }

	// RVA: 0x1938BF0 Offset: 0x1938CF1 VA: 0x1938BF0
	public bool get_isMultiAtlasTexturesEnabled() { }

	// RVA: 0x1938C00 Offset: 0x1938D01 VA: 0x1938C00
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	// RVA: 0x1938C10 Offset: 0x1938D11 VA: 0x1938C10
	internal bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x1938C20 Offset: 0x1938D21 VA: 0x1938C20
	internal void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x1938C30 Offset: 0x1938D31 VA: 0x1938C30
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x1938C40 Offset: 0x1938D41 VA: 0x1938C40
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x1938C50 Offset: 0x1938D51 VA: 0x1938C50
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x1938C60 Offset: 0x1938D61 VA: 0x1938C60
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x1938C70 Offset: 0x1938D71 VA: 0x1938C70
	public FaceInfo_Legacy get_fontInfo() { }

	// RVA: 0x1938C80 Offset: 0x1938D81 VA: 0x1938C80
	public int get_atlasWidth() { }

	// RVA: 0x1938C90 Offset: 0x1938D91 VA: 0x1938C90
	internal void set_atlasWidth(int value) { }

	// RVA: 0x1938CA0 Offset: 0x1938DA1 VA: 0x1938CA0
	public int get_atlasHeight() { }

	// RVA: 0x1938CB0 Offset: 0x1938DB1 VA: 0x1938CB0
	internal void set_atlasHeight(int value) { }

	// RVA: 0x1938CC0 Offset: 0x1938DC1 VA: 0x1938CC0
	public int get_atlasPadding() { }

	// RVA: 0x1938CD0 Offset: 0x1938DD1 VA: 0x1938CD0
	internal void set_atlasPadding(int value) { }

	// RVA: 0x1938CE0 Offset: 0x1938DE1 VA: 0x1938CE0
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0x1938CF0 Offset: 0x1938DF1 VA: 0x1938CF0
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x1938D00 Offset: 0x1938E01 VA: 0x1938D00
	public TMP_FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0x1938D10 Offset: 0x1938E11 VA: 0x1938D10
	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	// RVA: 0x1938D20 Offset: 0x1938E21 VA: 0x1938D20
	public List<TMP_FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x1938D30 Offset: 0x1938E31 VA: 0x1938D30
	public void set_fallbackFontAssetTable(List<TMP_FontAsset> value) { }

	// RVA: 0x1938D40 Offset: 0x1938E41 VA: 0x1938D40
	public FontAssetCreationSettings get_creationSettings() { }

	// RVA: 0x1938D80 Offset: 0x1938E81 VA: 0x1938D80
	public void set_creationSettings(FontAssetCreationSettings value) { }

	// RVA: 0x1938DB0 Offset: 0x1938EB1 VA: 0x1938DB0
	public TMP_FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0x1938DC0 Offset: 0x1938EC1 VA: 0x1938DC0
	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	// RVA: 0x1938DD0 Offset: 0x1938ED1 VA: 0x1938DD0
	public static TMP_FontAsset CreateFontAsset(Font font) { }

	// RVA: 0x1938E60 Offset: 0x1938F61 VA: 0x1938E60
	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x1939400 Offset: 0x1939501 VA: 0x1939400
	private void Awake() { }

	// RVA: 0x1938840 Offset: 0x1938941 VA: 0x1938840
	public void ReadFontAssetDefinition() { }

	// RVA: 0x193A090 Offset: 0x193A191 VA: 0x193A090
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0x193A3B0 Offset: 0x193A4B1 VA: 0x193A3B0
	internal void InitializeGlyphLookupDictionary() { }

	// RVA: 0x193A640 Offset: 0x193A741 VA: 0x193A640
	internal void InitializeCharacterLookupDictionary() { }

	// RVA: 0x193A8A0 Offset: 0x193A9A1 VA: 0x193A8A0
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x193A0C0 Offset: 0x193A1C1 VA: 0x193A0C0
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	// RVA: 0x193ADE0 Offset: 0x193AEE1 VA: 0x193ADE0
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = False) { }

	// RVA: 0x193B0D0 Offset: 0x193B1D1 VA: 0x193B0D0
	internal void AddCharacterToLookupCache(uint unicode, TMP_Character character) { }

	// RVA: 0x193B180 Offset: 0x193B281 VA: 0x193B180
	internal void SortCharacterTable() { }

	// RVA: 0x193B320 Offset: 0x193B421 VA: 0x193B320
	internal void SortGlyphTable() { }

	// RVA: 0x193B4C0 Offset: 0x193B5C1 VA: 0x193B4C0
	internal void SortFontFeatureTable() { }

	// RVA: 0x193B4D0 Offset: 0x193B5D1 VA: 0x193B4D0
	internal void SortAllTables() { }

	// RVA: 0x193B500 Offset: 0x193B601 VA: 0x193B500
	public bool HasCharacter(int character) { }

	// RVA: 0x193B570 Offset: 0x193B671 VA: 0x193B570
	public bool HasCharacter(char character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x193C330 Offset: 0x193C431 VA: 0x193C330
	private bool HasCharacter_Internal(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x193C570 Offset: 0x193C671 VA: 0x193C570
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0x193C6F0 Offset: 0x193C7F1 VA: 0x193C6F0
	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x193CD10 Offset: 0x193CE11 VA: 0x193CD10
	public bool HasCharacters(string text) { }

	// RVA: 0x193CDF0 Offset: 0x193CEF1 VA: 0x193CDF0
	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x193CEF0 Offset: 0x193CFF1 VA: 0x193CEF0
	public static int[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	// RVA: 0x193CFE0 Offset: 0x193D0E1 VA: 0x193CFE0
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x193D110 Offset: 0x193D211 VA: 0x193D110
	internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset) { }

	// RVA: 0x193D210 Offset: 0x193D311 VA: 0x193D210
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	// RVA: 0x193D690 Offset: 0x193D791 VA: 0x193D690
	internal static void RegisterFontAssetForAtlasTextureUpdate(TMP_FontAsset fontAsset) { }

	// RVA: 0x193D790 Offset: 0x193D891 VA: 0x193D790
	internal static void UpdateAtlasTexturesForFontAssetsInQueue() { }

	// RVA: 0x193D900 Offset: 0x193DA01 VA: 0x193D900
	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = False) { }

	// RVA: 0x193D930 Offset: 0x193DA31 VA: 0x193D930
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = False) { }

	// RVA: 0x193E680 Offset: 0x193E781 VA: 0x193E680
	public bool TryAddCharacters(string characters, bool includeFontFeatures = False) { }

	// RVA: 0x193E6B0 Offset: 0x193E7B1 VA: 0x193E6B0
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = False) { }

	// RVA: 0x193BAB0 Offset: 0x193BBB1 VA: 0x193BAB0
	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	// RVA: 0x193F290 Offset: 0x193F391 VA: 0x193F290
	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character) { }

	// RVA: 0x193D8F0 Offset: 0x193D9F1 VA: 0x193D8F0
	internal void TryAddGlyphsToAtlasTextures() { }

	// RVA: 0x193E350 Offset: 0x193E451 VA: 0x193E350
	private bool TryAddGlyphsToNewAtlasTexture() { }

	// RVA: 0x193F090 Offset: 0x193F191 VA: 0x193F090
	private void SetupNewAtlasTexture() { }

	// RVA: 0x193F760 Offset: 0x193F861 VA: 0x193F760
	internal void UpdateAtlasTexture() { }

	// RVA: 0x193D390 Offset: 0x193D491 VA: 0x193D390
	internal void UpdateGlyphAdjustmentRecords() { }

	// RVA: 0x193F8C0 Offset: 0x193F9C1 VA: 0x193F8C0
	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) { }

	// RVA: 0x193FBB0 Offset: 0x193FCB1 VA: 0x193FBB0
	internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x193FBC0 Offset: 0x193FCC1 VA: 0x193FBC0
	internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes) { }

	// RVA: -1 Offset: -1
	private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2023C10 Offset: 0x2023D11 VA: 0x2023C10
	|-TMP_FontAsset.CopyListDataToArray<object>
	*/

	// RVA: 0x193FBD0 Offset: 0x193FCD1 VA: 0x193FBD0
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0x19401C0 Offset: 0x19402C1 VA: 0x19401C0
	internal void ClearFontAssetDataInternal() { }

	// RVA: 0x19401F0 Offset: 0x19402F1 VA: 0x19401F0
	internal void UpdateFontAssetData() { }

	// RVA: 0x193FC10 Offset: 0x193FD11 VA: 0x193FC10
	internal void ClearFontAssetTables() { }

	// RVA: 0x193FD80 Offset: 0x193FE81 VA: 0x193FD80
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = False) { }

	// RVA: 0x19394A0 Offset: 0x19395A1 VA: 0x19394A0
	internal void UpgradeFontAsset() { }

	// RVA: 0x193AA70 Offset: 0x193AB71 VA: 0x193AA70
	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

	// RVA: 0x1940320 Offset: 0x1940421 VA: 0x1940320
	public void .ctor() { }

	// RVA: 0x1940740 Offset: 0x1940841 VA: 0x1940740
	private static void .cctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Glyph : TMP_TextElement_Legacy // TypeDefIndex: 7366
{
	// Methods

	// RVA: 0x1AAC6A0 Offset: 0x1AAC7A1 VA: 0x1AAC6A0
	public static TMP_Glyph Clone(TMP_Glyph source) { }

	// RVA: 0x1AAC750 Offset: 0x1AAC851 VA: 0x1AAC750
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public struct TMP_FontWeightPair // TypeDefIndex: 7368
{
	// Fields
	public TMP_FontAsset regularTypeface; // 0x0
	public TMP_FontAsset italicTypeface; // 0x8
}

// Namespace: TMPro
public class TMP_FontAssetUtilities // TypeDefIndex: 7378
{
	// Fields
	private static readonly TMP_FontAssetUtilities s_Instance; // 0x0
	private static HashSet<int> k_SearchedAssets; // 0x8
	private static bool k_IsFontEngineInitialized; // 0x10

	// Properties
	public static TMP_FontAssetUtilities instance { get; }

	// Methods

	// RVA: 0x1940A40 Offset: 0x1940B41 VA: 0x1940A40
	private static void .cctor() { }

	// RVA: 0x1940AC0 Offset: 0x1940BC1 VA: 0x1940AC0
	public static TMP_FontAssetUtilities get_instance() { }

	// RVA: 0x1940B30 Offset: 0x1940C31 VA: 0x1940B30
	public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x1940CE0 Offset: 0x1940DE1 VA: 0x1940CE0
	private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x19410B0 Offset: 0x19411B1 VA: 0x19410B0
	public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x1941350 Offset: 0x1941451 VA: 0x1941350
	public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x19416C0 Offset: 0x19417C1 VA: 0x19416C0
	private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x1940AB0 Offset: 0x1940BB1 VA: 0x1940AB0
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_FontFeatureTable // TypeDefIndex: 7380
{
	// Fields
	[SerializeField] // RVA: 0x4D820 Offset: 0x4D921 VA: 0x4D820
	internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
	internal Dictionary<uint, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18

	// Properties
	public List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; }

	// Methods

	// RVA: 0x1AABC50 Offset: 0x1AABD51 VA: 0x1AABC50
	public List<TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	// RVA: 0x1AABC60 Offset: 0x1AABD61 VA: 0x1AABC60
	public void set_glyphPairAdjustmentRecords(List<TMP_GlyphPairAdjustmentRecord> value) { }

	// RVA: 0x1AABC70 Offset: 0x1AABD71 VA: 0x1AABC70
	public void .ctor() { }

	// RVA: 0x1AABD50 Offset: 0x1AABE51 VA: 0x1AABD50
	public void SortGlyphPairAdjustmentRecords() { }
}

// Namespace: TMPro
[Serializable]
public struct TMP_GlyphValueRecord // TypeDefIndex: 7382
{
	// Fields
	[SerializeField] // RVA: 0x4D830 Offset: 0x4D931 VA: 0x4D830
	internal float m_XPlacement; // 0x0
	[SerializeField] // RVA: 0x4D840 Offset: 0x4D941 VA: 0x4D840
	internal float m_YPlacement; // 0x4
	[SerializeField] // RVA: 0x4D850 Offset: 0x4D951 VA: 0x4D850
	internal float m_XAdvance; // 0x8
	[SerializeField] // RVA: 0x4D860 Offset: 0x4D961 VA: 0x4D860
	internal float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; set; }
	public float yAdvance { get; set; }

	// Methods

	// RVA: 0x1AACB70 Offset: 0x1AACC71 VA: 0x1AACB70
	public float get_xPlacement() { }

	// RVA: 0x1AACB80 Offset: 0x1AACC81 VA: 0x1AACB80
	public void set_xPlacement(float value) { }

	// RVA: 0x1AACB90 Offset: 0x1AACC91 VA: 0x1AACB90
	public float get_yPlacement() { }

	// RVA: 0x1AACBA0 Offset: 0x1AACCA1 VA: 0x1AACBA0
	public void set_yPlacement(float value) { }

	// RVA: 0x1AACBB0 Offset: 0x1AACCB1 VA: 0x1AACBB0
	public float get_xAdvance() { }

	// RVA: 0x1AACBC0 Offset: 0x1AACCC1 VA: 0x1AACBC0
	public void set_xAdvance(float value) { }

	// RVA: 0x1AACBD0 Offset: 0x1AACCD1 VA: 0x1AACBD0
	public float get_yAdvance() { }

	// RVA: 0x1AACBE0 Offset: 0x1AACCE1 VA: 0x1AACBE0
	public void set_yAdvance(float value) { }

	// RVA: 0x1AACBF0 Offset: 0x1AACCF1 VA: 0x1AACBF0
	public void .ctor(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	// RVA: 0x1AACC10 Offset: 0x1AACD11 VA: 0x1AACC10
	internal void .ctor(GlyphValueRecord_Legacy valueRecord) { }

	// RVA: 0x1AAC880 Offset: 0x1AAC981 VA: 0x1AAC880
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0x1AACC30 Offset: 0x1AACD31 VA: 0x1AACC30
	public static TMP_GlyphValueRecord op_Addition(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 7384
{
	// Fields
	[SerializeField] // RVA: 0x4D890 Offset: 0x4D991 VA: 0x4D890
	internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
	[SerializeField] // RVA: 0x4D8A0 Offset: 0x4D9A1 VA: 0x4D8A0
	internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
	[SerializeField] // RVA: 0x4D8B0 Offset: 0x4D9B1 VA: 0x4D8B0
	internal FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38

	// Properties
	public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
	public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; }
	public FontFeatureLookupFlags featureLookupFlags { get; set; }

	// Methods

	// RVA: 0x1AAC8F0 Offset: 0x1AAC9F1 VA: 0x1AAC8F0
	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x1AAC910 Offset: 0x1AACA11 VA: 0x1AAC910
	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x1AAC930 Offset: 0x1AACA31 VA: 0x1AAC930
	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0x1AAC950 Offset: 0x1AACA51 VA: 0x1AAC950
	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x1AAC970 Offset: 0x1AACA71 VA: 0x1AAC970
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0x1AAC980 Offset: 0x1AACA81 VA: 0x1AAC980
	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	// RVA: 0x1AAC990 Offset: 0x1AACA91 VA: 0x1AAC990
	public void .ctor(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	// RVA: 0x1AAC9F0 Offset: 0x1AACAF1 VA: 0x1AAC9F0
	internal void .ctor(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }
}

// Namespace: TMPro
public struct TMP_LineInfo // TypeDefIndex: 7402
{
	// Fields
	internal int controlCharacterCount; // 0x0
	public int characterCount; // 0x4
	public int visibleCharacterCount; // 0x8
	public int spaceCount; // 0xC
	public int wordCount; // 0x10
	public int firstCharacterIndex; // 0x14
	public int firstVisibleCharacterIndex; // 0x18
	public int lastCharacterIndex; // 0x1C
	public int lastVisibleCharacterIndex; // 0x20
	public float length; // 0x24
	public float lineHeight; // 0x28
	public float ascender; // 0x2C
	public float baseline; // 0x30
	public float descender; // 0x34
	public float maxAdvance; // 0x38
	public float width; // 0x3C
	public float marginLeft; // 0x40
	public float marginRight; // 0x44
	public HorizontalAlignmentOptions alignment; // 0x48
	public Extents lineExtents; // 0x4C
}

// Namespace: TMPro
internal static class TMP_ListPool<T> // TypeDefIndex: 7404
{
	// Fields
	private static readonly TMP_ObjectPool<List<T>> s_ListPool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3670 Offset: 0x34B3771 VA: 0x34B3670
	|-TMP_ListPool<Canvas>.Get
	|-TMP_ListPool<IMaterialModifier>.Get
	|-TMP_ListPool<Mask>.Get
	|-TMP_ListPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3800 Offset: 0x34B3901 VA: 0x34B3800
	|-TMP_ListPool<Canvas>.Release
	|-TMP_ListPool<IMaterialModifier>.Release
	|-TMP_ListPool<Mask>.Release
	|-TMP_ListPool<object>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3990 Offset: 0x34B3A91 VA: 0x34B3990
	|-TMP_ListPool<object>..cctor
	*/
}

// Namespace: TMPro
internal class TMP_ObjectPool<T> // TypeDefIndex: 7414
{
	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x4DBF0 Offset: 0x4DCF1 VA: 0x4DBF0
	private int <countAll>k__BackingField; // 0x0

	// Properties
	public int countAll { get; set; }
	public int countActive { get; }
	public int countInactive { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x4E880 Offset: 0x4E981 VA: 0x4E880
	// RVA: -1 Offset: -1
	public int get_countAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3C40 Offset: 0x34B3D41 VA: 0x34B3C40
	|-TMP_ObjectPool<object>.get_countAll
	*/

	[CompilerGeneratedAttribute] // RVA: 0x4E890 Offset: 0x4E991 VA: 0x4E890
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3C50 Offset: 0x34B3D51 VA: 0x34B3C50
	|-TMP_ObjectPool<object>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3C60 Offset: 0x34B3D61 VA: 0x34B3C60
	|-TMP_ObjectPool<object>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3CC0 Offset: 0x34B3DC1 VA: 0x34B3CC0
	|-TMP_ObjectPool<object>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3CE0 Offset: 0x34B3DE1 VA: 0x34B3CE0
	|-TMP_ObjectPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3D90 Offset: 0x34B3E91 VA: 0x34B3D90
	|-TMP_ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3E70 Offset: 0x34B3F71 VA: 0x34B3E70
	|-TMP_ObjectPool<object>.Release
	*/
}

// Namespace: TMPro
public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 7420
{
	// Fields
	public bool isSelected; // 0x18

	// Methods

	// RVA: 0x18F4900 Offset: 0x18F4A01 VA: 0x18F4900 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x18F4980 Offset: 0x18F4A81 VA: 0x18F4980 Slot: 5
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x18F4A10 Offset: 0x18F4B11 VA: 0x18F4A10 Slot: 6
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x18F4AA0 Offset: 0x18F4BA1 VA: 0x18F4AA0
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_SpriteCharacter : TMP_TextElement // TypeDefIndex: 7430
{
	// Fields
	[SerializeField] // RVA: 0x4DE40 Offset: 0x4DF41 VA: 0x4DE40
	private string m_Name; // 0x30
	[SerializeField] // RVA: 0x4DE50 Offset: 0x4DF51 VA: 0x4DE50
	private int m_HashCode; // 0x38

	// Properties
	public string name { get; set; }
	public int hashCode { get; }

	// Methods

	// RVA: 0x18F7C50 Offset: 0x18F7D51 VA: 0x18F7C50
	public string get_name() { }

	// RVA: 0x18F7AC0 Offset: 0x18F7BC1 VA: 0x18F7AC0
	public void set_name(string value) { }

	// RVA: 0x18F7C60 Offset: 0x18F7D61 VA: 0x18F7C60
	public int get_hashCode() { }

	// RVA: 0x18F7A90 Offset: 0x18F7B91 VA: 0x18F7A90
	public void .ctor() { }

	// RVA: 0x18F7C70 Offset: 0x18F7D71 VA: 0x18F7C70
	public void .ctor(uint unicode, TMP_SpriteGlyph glyph) { }

	// RVA: 0x18F7CE0 Offset: 0x18F7DE1 VA: 0x18F7CE0
	public void .ctor(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph) { }

	// RVA: 0x18F7D60 Offset: 0x18F7E61 VA: 0x18F7D60
	internal void .ctor(uint unicode, uint glyphIndex) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Style // TypeDefIndex: 7432
{
	// Fields
	internal static TMP_Style k_NormalStyle; // 0x0
	[SerializeField] // RVA: 0x4DE60 Offset: 0x4DF61 VA: 0x4DE60
	private string m_Name; // 0x10
	[SerializeField] // RVA: 0x4DE70 Offset: 0x4DF71 VA: 0x4DE70
	private int m_HashCode; // 0x18
	[SerializeField] // RVA: 0x4DE80 Offset: 0x4DF81 VA: 0x4DE80
	private string m_OpeningDefinition; // 0x20
	[SerializeField] // RVA: 0x4DE90 Offset: 0x4DF91 VA: 0x4DE90
	private string m_ClosingDefinition; // 0x28
	[SerializeField] // RVA: 0x4DEA0 Offset: 0x4DFA1 VA: 0x4DEA0
	private int[] m_OpeningTagArray; // 0x30
	[SerializeField] // RVA: 0x4DEB0 Offset: 0x4DFB1 VA: 0x4DEB0
	private int[] m_ClosingTagArray; // 0x38
	[SerializeField] // RVA: 0x4DEC0 Offset: 0x4DFC1 VA: 0x4DEC0
	internal uint[] m_OpeningTagUnicodeArray; // 0x40
	[SerializeField] // RVA: 0x4DED0 Offset: 0x4DFD1 VA: 0x4DED0
	internal uint[] m_ClosingTagUnicodeArray; // 0x48

	// Properties
	public static TMP_Style NormalStyle { get; }
	public string name { get; set; }
	public int hashCode { get; set; }
	public string styleOpeningDefinition { get; }
	public string styleClosingDefinition { get; }
	public int[] styleOpeningTagArray { get; }
	public int[] styleClosingTagArray { get; }

	// Methods

	// RVA: 0x18F7F70 Offset: 0x18F8071 VA: 0x18F7F70
	public static TMP_Style get_NormalStyle() { }

	// RVA: 0x18F8110 Offset: 0x18F8211 VA: 0x18F8110
	public string get_name() { }

	// RVA: 0x18F8120 Offset: 0x18F8221 VA: 0x18F8120
	public void set_name(string value) { }

	// RVA: 0x18F8170 Offset: 0x18F8271 VA: 0x18F8170
	public int get_hashCode() { }

	// RVA: 0x18F8180 Offset: 0x18F8281 VA: 0x18F8180
	public void set_hashCode(int value) { }

	// RVA: 0x18F81A0 Offset: 0x18F82A1 VA: 0x18F81A0
	public string get_styleOpeningDefinition() { }

	// RVA: 0x18F81B0 Offset: 0x18F82B1 VA: 0x18F81B0
	public string get_styleClosingDefinition() { }

	// RVA: 0x18F81C0 Offset: 0x18F82C1 VA: 0x18F81C0
	public int[] get_styleOpeningTagArray() { }

	// RVA: 0x18F81D0 Offset: 0x18F82D1 VA: 0x18F81D0
	public int[] get_styleClosingTagArray() { }

	// RVA: 0x18F8040 Offset: 0x18F8141 VA: 0x18F8040
	internal void .ctor(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	// RVA: 0x18F81E0 Offset: 0x18F82E1 VA: 0x18F81E0
	public void RefreshStyle() { }
}

// Namespace: TMPro
[RequireComponent] // RVA: 0x4CEE0 Offset: 0x4CFE1 VA: 0x4CEE0
[ExecuteAlways] // RVA: 0x4CEE0 Offset: 0x4CFE1 VA: 0x4CEE0
public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 7434
{
	// Fields
	[SerializeField] // RVA: 0x4DEF0 Offset: 0x4DFF1 VA: 0x4DEF0
	private TMP_FontAsset m_fontAsset; // 0x18
	[SerializeField] // RVA: 0x4DF00 Offset: 0x4E001 VA: 0x4DF00
	private TMP_SpriteAsset m_spriteAsset; // 0x20
	[SerializeField] // RVA: 0x4DF10 Offset: 0x4E011 VA: 0x4DF10
	private Material m_material; // 0x28
	[SerializeField] // RVA: 0x4DF20 Offset: 0x4E021 VA: 0x4DF20
	private Material m_sharedMaterial; // 0x30
	private Material m_fallbackMaterial; // 0x38
	private Material m_fallbackSourceMaterial; // 0x40
	[SerializeField] // RVA: 0x4DF30 Offset: 0x4E031 VA: 0x4DF30
	private bool m_isDefaultMaterial; // 0x48
	[SerializeField] // RVA: 0x4DF40 Offset: 0x4E041 VA: 0x4DF40
	private float m_padding; // 0x4C
	[SerializeField] // RVA: 0x4DF50 Offset: 0x4E051 VA: 0x4DF50
	private Renderer m_renderer; // 0x50
	private MeshFilter m_meshFilter; // 0x58
	private Mesh m_mesh; // 0x60
	[SerializeField] // RVA: 0x4DF60 Offset: 0x4E061 VA: 0x4DF60
	private TextMeshPro m_TextComponent; // 0x68
	private bool m_isRegisteredForEvents; // 0x70

	// Properties
	public TMP_FontAsset fontAsset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public Renderer renderer { get; }
	public MeshFilter meshFilter { get; }
	public Mesh mesh { get; set; }
	public TMP_Text textComponent { get; }

	// Methods

	// RVA: 0x18F8910 Offset: 0x18F8A11 VA: 0x18F8910
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x18F8920 Offset: 0x18F8A21 VA: 0x18F8920
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x18F8930 Offset: 0x18F8A31 VA: 0x18F8930
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x18F8940 Offset: 0x18F8A41 VA: 0x18F8940
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x18F8950 Offset: 0x18F8A51 VA: 0x18F8950
	public Material get_material() { }

	// RVA: 0x18F8B20 Offset: 0x18F8C21 VA: 0x18F8B20
	public void set_material(Material value) { }

	// RVA: 0x18F8DA0 Offset: 0x18F8EA1 VA: 0x18F8DA0
	public Material get_sharedMaterial() { }

	// RVA: 0x18F8DB0 Offset: 0x18F8EB1 VA: 0x18F8DB0
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x18F8E70 Offset: 0x18F8F71 VA: 0x18F8E70
	public Material get_fallbackMaterial() { }

	// RVA: 0x18F8E80 Offset: 0x18F8F81 VA: 0x18F8E80
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x18F9010 Offset: 0x18F9111 VA: 0x18F9010
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x18F9020 Offset: 0x18F9121 VA: 0x18F9020
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x18F9030 Offset: 0x18F9131 VA: 0x18F9030
	public bool get_isDefaultMaterial() { }

	// RVA: 0x18F9040 Offset: 0x18F9141 VA: 0x18F9040
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x18F9050 Offset: 0x18F9151 VA: 0x18F9050
	public float get_padding() { }

	// RVA: 0x18F9060 Offset: 0x18F9161 VA: 0x18F9060
	public void set_padding(float value) { }

	// RVA: 0x18F9070 Offset: 0x18F9171 VA: 0x18F9070
	public Renderer get_renderer() { }

	// RVA: 0x18F9130 Offset: 0x18F9231 VA: 0x18F9130
	public MeshFilter get_meshFilter() { }

	// RVA: 0x18F9260 Offset: 0x18F9361 VA: 0x18F9260
	public Mesh get_mesh() { }

	// RVA: 0x18F9330 Offset: 0x18F9431 VA: 0x18F9330
	public void set_mesh(Mesh value) { }

	// RVA: 0x18F9340 Offset: 0x18F9441 VA: 0x18F9340
	public TMP_Text get_textComponent() { }

	// RVA: 0x18F9400 Offset: 0x18F9501 VA: 0x18F9400
	public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) { }

	// RVA: 0x18F9730 Offset: 0x18F9831 VA: 0x18F9730
	private void OnEnable() { }

	// RVA: 0x18F9890 Offset: 0x18F9991 VA: 0x18F9890
	private void OnDisable() { }

	// RVA: 0x18F9980 Offset: 0x18F9A81 VA: 0x18F9980
	private void OnDestroy() { }

	// RVA: 0x18F9B50 Offset: 0x18F9C51 VA: 0x18F9B50
	public void DestroySelf() { }

	// RVA: 0x18F8960 Offset: 0x18F8A61 VA: 0x18F8960
	private Material GetMaterial(Material mat) { }

	// RVA: 0x18F9BD0 Offset: 0x18F9CD1 VA: 0x18F9BD0
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0x18F9C90 Offset: 0x18F9D91 VA: 0x18F9C90
	private Material GetSharedMaterial() { }

	// RVA: 0x18F8DC0 Offset: 0x18F8EC1 VA: 0x18F8DC0
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0x18F8C30 Offset: 0x18F8D31 VA: 0x18F8C30
	public float GetPaddingForMaterial() { }

	// RVA: 0x18F9D50 Offset: 0x18F9E51 VA: 0x18F9D50
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x18F8CC0 Offset: 0x18F8DC1 VA: 0x18F8CC0
	public void SetVerticesDirty() { }

	// RVA: 0x18F8D90 Offset: 0x18F8E91 VA: 0x18F8D90
	public void SetMaterialDirty() { }

	// RVA: 0x18F9DE0 Offset: 0x18F9EE1 VA: 0x18F9DE0
	protected void UpdateMaterial() { }

	// RVA: 0x18F9F60 Offset: 0x18FA061 VA: 0x18F9F60
	public void .ctor() { }
}

// Namespace: TMPro
public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 7454
{
	// Fields
	[SerializeField] // RVA: 0x4DFF0 Offset: 0x4E0F1 VA: 0x4DFF0
	[TextAreaAttribute] // RVA: 0x4DFF0 Offset: 0x4E0F1 VA: 0x4DFF0
	protected string m_text; // 0xD0
	private bool m_IsTextBackingStringDirty; // 0xD8
	[SerializeField] // RVA: 0x4E030 Offset: 0x4E131 VA: 0x4E030
	protected ITextPreprocessor m_TextPreprocessor; // 0xE0
	[SerializeField] // RVA: 0x4E040 Offset: 0x4E141 VA: 0x4E040
	protected bool m_isRightToLeft; // 0xE8
	[SerializeField] // RVA: 0x4E050 Offset: 0x4E151 VA: 0x4E050
	protected TMP_FontAsset m_fontAsset; // 0xF0
	protected TMP_FontAsset m_currentFontAsset; // 0xF8
	protected bool m_isSDFShader; // 0x100
	[SerializeField] // RVA: 0x4E060 Offset: 0x4E161 VA: 0x4E060
	protected Material m_sharedMaterial; // 0x108
	protected Material m_currentMaterial; // 0x110
	protected static MaterialReference[] m_materialReferences; // 0x0
	protected static Dictionary<int, int> m_materialReferenceIndexLookup; // 0x8
	protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; // 0x10
	protected int m_currentMaterialIndex; // 0x118
	[SerializeField] // RVA: 0x4E070 Offset: 0x4E171 VA: 0x4E070
	protected Material[] m_fontSharedMaterials; // 0x120
	[SerializeField] // RVA: 0x4E080 Offset: 0x4E181 VA: 0x4E080
	protected Material m_fontMaterial; // 0x128
	[SerializeField] // RVA: 0x4E090 Offset: 0x4E191 VA: 0x4E090
	protected Material[] m_fontMaterials; // 0x130
	protected bool m_isMaterialDirty; // 0x138
	[SerializeField] // RVA: 0x4E0A0 Offset: 0x4E1A1 VA: 0x4E0A0
	protected Color32 m_fontColor32; // 0x13C
	[SerializeField] // RVA: 0x4E0B0 Offset: 0x4E1B1 VA: 0x4E0B0
	protected Color m_fontColor; // 0x140
	protected static Color32 s_colorWhite; // 0x68
	protected Color32 m_underlineColor; // 0x150
	protected Color32 m_strikethroughColor; // 0x154
	[SerializeField] // RVA: 0x4E0C0 Offset: 0x4E1C1 VA: 0x4E0C0
	protected bool m_enableVertexGradient; // 0x158
	[SerializeField] // RVA: 0x4E0D0 Offset: 0x4E1D1 VA: 0x4E0D0
	protected ColorMode m_colorMode; // 0x15C
	[SerializeField] // RVA: 0x4E0E0 Offset: 0x4E1E1 VA: 0x4E0E0
	protected VertexGradient m_fontColorGradient; // 0x160
	[SerializeField] // RVA: 0x4E0F0 Offset: 0x4E1F1 VA: 0x4E0F0
	protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1A0
	[SerializeField] // RVA: 0x4E100 Offset: 0x4E201 VA: 0x4E100
	protected TMP_SpriteAsset m_spriteAsset; // 0x1A8
	[SerializeField] // RVA: 0x4E110 Offset: 0x4E211 VA: 0x4E110
	protected bool m_tintAllSprites; // 0x1B0
	protected bool m_tintSprite; // 0x1B1
	protected Color32 m_spriteColor; // 0x1B4
	[SerializeField] // RVA: 0x4E120 Offset: 0x4E221 VA: 0x4E120
	protected TMP_StyleSheet m_StyleSheet; // 0x1B8
	internal TMP_Style m_TextStyle; // 0x1C0
	[SerializeField] // RVA: 0x4E130 Offset: 0x4E231 VA: 0x4E130
	protected int m_TextStyleHashCode; // 0x1C8
	[SerializeField] // RVA: 0x4E140 Offset: 0x4E241 VA: 0x4E140
	protected bool m_overrideHtmlColors; // 0x1CC
	[SerializeField] // RVA: 0x4E150 Offset: 0x4E251 VA: 0x4E150
	protected Color32 m_faceColor; // 0x1D0
	protected Color32 m_outlineColor; // 0x1D4
	protected float m_outlineWidth; // 0x1D8
	[SerializeField] // RVA: 0x4E160 Offset: 0x4E261 VA: 0x4E160
	protected float m_fontSize; // 0x1DC
	protected float m_currentFontSize; // 0x1E0
	[SerializeField] // RVA: 0x4E170 Offset: 0x4E271 VA: 0x4E170
	protected float m_fontSizeBase; // 0x1E4
	protected TMP_TextProcessingStack<float> m_sizeStack; // 0x1E8
	[SerializeField] // RVA: 0x4E180 Offset: 0x4E281 VA: 0x4E180
	protected FontWeight m_fontWeight; // 0x208
	protected FontWeight m_FontWeightInternal; // 0x20C
	protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; // 0x210
	[SerializeField] // RVA: 0x4E190 Offset: 0x4E291 VA: 0x4E190
	protected bool m_enableAutoSizing; // 0x230
	protected float m_maxFontSize; // 0x234
	protected float m_minFontSize; // 0x238
	protected int m_AutoSizeIterationCount; // 0x23C
	protected int m_AutoSizeMaxIterationCount; // 0x240
	protected bool m_IsAutoSizePointSizeSet; // 0x244
	[SerializeField] // RVA: 0x4E1A0 Offset: 0x4E2A1 VA: 0x4E1A0
	protected float m_fontSizeMin; // 0x248
	[SerializeField] // RVA: 0x4E1B0 Offset: 0x4E2B1 VA: 0x4E1B0
	protected float m_fontSizeMax; // 0x24C
	[SerializeField] // RVA: 0x4E1C0 Offset: 0x4E2C1 VA: 0x4E1C0
	protected FontStyles m_fontStyle; // 0x250
	protected FontStyles m_FontStyleInternal; // 0x254
	protected TMP_FontStyleStack m_fontStyleStack; // 0x258
	protected bool m_isUsingBold; // 0x262
	[SerializeField] // RVA: 0x4E1D0 Offset: 0x4E2D1 VA: 0x4E1D0
	protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x264
	[SerializeField] // RVA: 0x4E1E0 Offset: 0x4E2E1 VA: 0x4E1E0
	protected VerticalAlignmentOptions m_VerticalAlignment; // 0x268
	[SerializeField] // RVA: 0x4E1F0 Offset: 0x4E2F1 VA: 0x4E1F0
	[FormerlySerializedAsAttribute] // RVA: 0x4E1F0 Offset: 0x4E2F1 VA: 0x4E1F0
	protected TextAlignmentOptions m_textAlignment; // 0x26C
	protected HorizontalAlignmentOptions m_lineJustification; // 0x270
	protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x278
	protected Vector3[] m_textContainerLocalCorners; // 0x298
	[SerializeField] // RVA: 0x4E240 Offset: 0x4E341 VA: 0x4E240
	protected float m_characterSpacing; // 0x2A0
	protected float m_cSpacing; // 0x2A4
	protected float m_monoSpacing; // 0x2A8
	[SerializeField] // RVA: 0x4E250 Offset: 0x4E351 VA: 0x4E250
	protected float m_wordSpacing; // 0x2AC
	[SerializeField] // RVA: 0x4E260 Offset: 0x4E361 VA: 0x4E260
	protected float m_lineSpacing; // 0x2B0
	protected float m_lineSpacingDelta; // 0x2B4
	protected float m_lineHeight; // 0x2B8
	protected bool m_IsDrivenLineSpacing; // 0x2BC
	[SerializeField] // RVA: 0x4E270 Offset: 0x4E371 VA: 0x4E270
	protected float m_lineSpacingMax; // 0x2C0
	[SerializeField] // RVA: 0x4E280 Offset: 0x4E381 VA: 0x4E280
	protected float m_paragraphSpacing; // 0x2C4
	[SerializeField] // RVA: 0x4E290 Offset: 0x4E391 VA: 0x4E290
	protected float m_charWidthMaxAdj; // 0x2C8
	protected float m_charWidthAdjDelta; // 0x2CC
	[SerializeField] // RVA: 0x4E2A0 Offset: 0x4E3A1 VA: 0x4E2A0
	protected bool m_enableWordWrapping; // 0x2D0
	protected bool m_isCharacterWrappingEnabled; // 0x2D1
	protected bool m_isNonBreakingSpace; // 0x2D2
	protected bool m_isIgnoringAlignment; // 0x2D3
	[SerializeField] // RVA: 0x4E2B0 Offset: 0x4E3B1 VA: 0x4E2B0
	protected float m_wordWrappingRatios; // 0x2D4
	[SerializeField] // RVA: 0x4E2C0 Offset: 0x4E3C1 VA: 0x4E2C0
	protected TextOverflowModes m_overflowMode; // 0x2D8
	protected int m_firstOverflowCharacterIndex; // 0x2DC
	[SerializeField] // RVA: 0x4E2D0 Offset: 0x4E3D1 VA: 0x4E2D0
	protected TMP_Text m_linkedTextComponent; // 0x2E0
	[SerializeField] // RVA: 0x4E2E0 Offset: 0x4E3E1 VA: 0x4E2E0
	internal TMP_Text parentLinkedComponent; // 0x2E8
	protected bool m_isTextTruncated; // 0x2F0
	[SerializeField] // RVA: 0x4E2F0 Offset: 0x4E3F1 VA: 0x4E2F0
	protected bool m_enableKerning; // 0x2F1
	protected float m_GlyphHorizontalAdvanceAdjustment; // 0x2F4
	[SerializeField] // RVA: 0x4E300 Offset: 0x4E401 VA: 0x4E300
	protected bool m_enableExtraPadding; // 0x2F8
	[SerializeField] // RVA: 0x4E310 Offset: 0x4E411 VA: 0x4E310
	protected bool checkPaddingRequired; // 0x2F9
	[SerializeField] // RVA: 0x4E320 Offset: 0x4E421 VA: 0x4E320
	protected bool m_isRichText; // 0x2FA
	[SerializeField] // RVA: 0x4E330 Offset: 0x4E431 VA: 0x4E330
	protected bool m_parseCtrlCharacters; // 0x2FB
	protected bool m_isOverlay; // 0x2FC
	[SerializeField] // RVA: 0x4E340 Offset: 0x4E441 VA: 0x4E340
	protected bool m_isOrthographic; // 0x2FD
	[SerializeField] // RVA: 0x4E350 Offset: 0x4E451 VA: 0x4E350
	protected bool m_isCullingEnabled; // 0x2FE
	protected bool m_isMaskingEnabled; // 0x2FF
	protected bool isMaskUpdateRequired; // 0x300
	protected bool m_ignoreCulling; // 0x301
	[SerializeField] // RVA: 0x4E360 Offset: 0x4E461 VA: 0x4E360
	protected TextureMappingOptions m_horizontalMapping; // 0x304
	[SerializeField] // RVA: 0x4E370 Offset: 0x4E471 VA: 0x4E370
	protected TextureMappingOptions m_verticalMapping; // 0x308
	[SerializeField] // RVA: 0x4E380 Offset: 0x4E481 VA: 0x4E380
	protected float m_uvLineOffset; // 0x30C
	protected TextRenderFlags m_renderMode; // 0x310
	[SerializeField] // RVA: 0x4E390 Offset: 0x4E491 VA: 0x4E390
	protected VertexSortingOrder m_geometrySortingOrder; // 0x314
	[SerializeField] // RVA: 0x4E3A0 Offset: 0x4E4A1 VA: 0x4E3A0
	protected bool m_IsTextObjectScaleStatic; // 0x318
	[SerializeField] // RVA: 0x4E3B0 Offset: 0x4E4B1 VA: 0x4E3B0
	protected bool m_VertexBufferAutoSizeReduction; // 0x319
	protected int m_firstVisibleCharacter; // 0x31C
	protected int m_maxVisibleCharacters; // 0x320
	protected int m_maxVisibleWords; // 0x324
	protected int m_maxVisibleLines; // 0x328
	[SerializeField] // RVA: 0x4E3C0 Offset: 0x4E4C1 VA: 0x4E3C0
	protected bool m_useMaxVisibleDescender; // 0x32C
	[SerializeField] // RVA: 0x4E3D0 Offset: 0x4E4D1 VA: 0x4E3D0
	protected int m_pageToDisplay; // 0x330
	protected bool m_isNewPage; // 0x334
	[SerializeField] // RVA: 0x4E3E0 Offset: 0x4E4E1 VA: 0x4E3E0
	protected Vector4 m_margin; // 0x338
	protected float m_marginLeft; // 0x348
	protected float m_marginRight; // 0x34C
	protected float m_marginWidth; // 0x350
	protected float m_marginHeight; // 0x354
	protected float m_width; // 0x358
	protected TMP_TextInfo m_textInfo; // 0x360
	protected bool m_havePropertiesChanged; // 0x368
	[SerializeField] // RVA: 0x4E3F0 Offset: 0x4E4F1 VA: 0x4E3F0
	protected bool m_isUsingLegacyAnimationComponent; // 0x369
	protected Transform m_transform; // 0x370
	protected RectTransform m_rectTransform; // 0x378
	protected Vector2 m_PreviousRectTransformSize; // 0x380
	protected Vector2 m_PreviousPivotPosition; // 0x388
	[CompilerGeneratedAttribute] // RVA: 0x4E400 Offset: 0x4E501 VA: 0x4E400
	private bool <autoSizeTextContainer>k__BackingField; // 0x390
	protected bool m_autoSizeTextContainer; // 0x391
	protected Mesh m_mesh; // 0x398
	[SerializeField] // RVA: 0x4E410 Offset: 0x4E511 VA: 0x4E410
	protected bool m_isVolumetricText; // 0x3A0
	[CompilerGeneratedAttribute] // RVA: 0x4E420 Offset: 0x4E521 VA: 0x4E420
	private static Func<int, string, TMP_FontAsset> OnFontAssetRequest; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x4E430 Offset: 0x4E531 VA: 0x4E430
	private static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x4E440 Offset: 0x4E541 VA: 0x4E440
	private Action<TMP_TextInfo> OnPreRenderText; // 0x3A8
	protected TMP_SpriteAnimator m_spriteAnimator; // 0x3B0
	protected float m_flexibleHeight; // 0x3B8
	protected float m_flexibleWidth; // 0x3BC
	protected float m_minWidth; // 0x3C0
	protected float m_minHeight; // 0x3C4
	protected float m_maxWidth; // 0x3C8
	protected float m_maxHeight; // 0x3CC
	protected LayoutElement m_LayoutElement; // 0x3D0
	protected float m_preferredWidth; // 0x3D8
	protected float m_renderedWidth; // 0x3DC
	protected bool m_isPreferredWidthDirty; // 0x3E0
	protected float m_preferredHeight; // 0x3E4
	protected float m_renderedHeight; // 0x3E8
	protected bool m_isPreferredHeightDirty; // 0x3EC
	protected bool m_isCalculatingPreferredValues; // 0x3ED
	protected int m_layoutPriority; // 0x3F0
	protected bool m_isLayoutDirty; // 0x3F4
	protected bool m_isAwake; // 0x3F5
	internal bool m_isWaitingOnResourceLoad; // 0x3F6
	internal TMP_Text.TextInputSources m_inputSource; // 0x3F8
	protected float m_fontScaleMultiplier; // 0x3FC
	private static char[] m_htmlTag; // 0x80
	private static RichTextTagAttribute[] m_xmlAttribute; // 0x88
	private static float[] m_attributeParameterValues; // 0x90
	protected float tag_LineIndent; // 0x400
	protected float tag_Indent; // 0x404
	protected TMP_TextProcessingStack<float> m_indentStack; // 0x408
	protected bool tag_NoParsing; // 0x428
	protected bool m_isParsingText; // 0x429
	protected Matrix4x4 m_FXMatrix; // 0x42C
	protected bool m_isFXMatrixSet; // 0x46C
	internal TMP_Text.UnicodeChar[] m_TextProcessingArray; // 0x470
	internal int m_InternalTextProcessingArraySize; // 0x478
	private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x480
	protected int m_totalCharacterCount; // 0x488
	protected static WordWrapState m_SavedWordWrapState; // 0x98
	protected static WordWrapState m_SavedLineState; // 0x410
	protected static WordWrapState m_SavedEllipsisState; // 0x788
	protected static WordWrapState m_SavedLastValidState; // 0xB00
	protected static WordWrapState m_SavedSoftLineBreakState; // 0xE78
	internal static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x11F0
	protected int m_characterCount; // 0x48C
	protected int m_firstCharacterOfLine; // 0x490
	protected int m_firstVisibleCharacterOfLine; // 0x494
	protected int m_lastCharacterOfLine; // 0x498
	protected int m_lastVisibleCharacterOfLine; // 0x49C
	protected int m_lineNumber; // 0x4A0
	protected int m_lineVisibleCharacterCount; // 0x4A4
	protected int m_pageNumber; // 0x4A8
	protected float m_PageAscender; // 0x4AC
	protected float m_maxTextAscender; // 0x4B0
	protected float m_maxCapHeight; // 0x4B4
	protected float m_ElementAscender; // 0x4B8
	protected float m_ElementDescender; // 0x4BC
	protected float m_maxLineAscender; // 0x4C0
	protected float m_maxLineDescender; // 0x4C4
	protected float m_startOfLineAscender; // 0x4C8
	protected float m_startOfLineDescender; // 0x4CC
	protected float m_lineOffset; // 0x4D0
	protected Extents m_meshExtents; // 0x4D4
	protected Color32 m_htmlColor; // 0x4E4
	protected TMP_TextProcessingStack<Color32> m_colorStack; // 0x4E8
	protected TMP_TextProcessingStack<Color32> m_underlineColorStack; // 0x508
	protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; // 0x528
	protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x548
	protected TMP_ColorGradient m_colorGradientPreset; // 0x578
	protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; // 0x580
	protected bool m_colorGradientPresetIsTinted; // 0x5A8
	protected float m_tabSpacing; // 0x5AC
	protected float m_spacing; // 0x5B0
	protected TMP_TextProcessingStack<int>[] m_TextStyleStacks; // 0x5B8
	protected int m_TextStyleStackDepth; // 0x5C0
	protected TMP_TextProcessingStack<int> m_ItalicAngleStack; // 0x5C8
	protected int m_ItalicAngle; // 0x5E8
	protected TMP_TextProcessingStack<int> m_actionStack; // 0x5F0
	protected float m_padding; // 0x610
	protected float m_baselineOffset; // 0x614
	protected TMP_TextProcessingStack<float> m_baselineOffsetStack; // 0x618
	protected float m_xAdvance; // 0x638
	protected TMP_TextElementType m_textElementType; // 0x63C
	protected TMP_TextElement m_cached_TextElement; // 0x640
	protected TMP_Text.SpecialCharacter m_Ellipsis; // 0x648
	protected TMP_Text.SpecialCharacter m_Underline; // 0x668
	protected TMP_SpriteAsset m_defaultSpriteAsset; // 0x688
	protected TMP_SpriteAsset m_currentSpriteAsset; // 0x690
	protected int m_spriteCount; // 0x698
	protected int m_spriteIndex; // 0x69C
	protected int m_spriteAnimationID; // 0x6A0
	private static ProfilerMarker k_ParseTextMarker; // 0x1588
	private static ProfilerMarker k_InsertNewLineMarker; // 0x1590
	protected bool m_ignoreActiveState; // 0x6A4
	private TMP_Text.TextBackingContainer m_TextBackingArray; // 0x6A8
	private readonly Decimal[] k_Power; // 0x6B8
	protected static Vector2 k_LargePositiveVector2; // 0x1598
	protected static Vector2 k_LargeNegativeVector2; // 0x15A0
	protected static float k_LargePositiveFloat; // 0x15A8
	protected static float k_LargeNegativeFloat; // 0x15AC
	protected static int k_LargePositiveInt; // 0x15B0
	protected static int k_LargeNegativeInt; // 0x15B4

	// Properties
	public virtual string text { get; set; }
	public ITextPreprocessor textPreprocessor { get; set; }
	public bool isRightToLeftText { get; set; }
	public TMP_FontAsset font { get; set; }
	public virtual Material fontSharedMaterial { get; set; }
	public virtual Material[] fontSharedMaterials { get; set; }
	public Material fontMaterial { get; set; }
	public virtual Material[] fontMaterials { get; set; }
	public override Color color { get; set; }
	public float alpha { get; set; }
	public bool enableVertexGradient { get; set; }
	public VertexGradient colorGradient { get; set; }
	public TMP_ColorGradient colorGradientPreset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public bool tintAllSprites { get; set; }
	public TMP_StyleSheet styleSheet { get; set; }
	public TMP_Style textStyle { get; set; }
	public bool overrideColorTags { get; set; }
	public Color32 faceColor { get; set; }
	public Color32 outlineColor { get; set; }
	public float outlineWidth { get; set; }
	public float fontSize { get; set; }
	public FontWeight fontWeight { get; set; }
	public float pixelsPerUnit { get; }
	public bool enableAutoSizing { get; set; }
	public float fontSizeMin { get; set; }
	public float fontSizeMax { get; set; }
	public FontStyles fontStyle { get; set; }
	public bool isUsingBold { get; }
	public HorizontalAlignmentOptions horizontalAlignment { get; set; }
	public VerticalAlignmentOptions verticalAlignment { get; set; }
	public TextAlignmentOptions alignment { get; set; }
	public float characterSpacing { get; set; }
	public float wordSpacing { get; set; }
	public float lineSpacing { get; set; }
	public float lineSpacingAdjustment { get; set; }
	public float paragraphSpacing { get; set; }
	public float characterWidthAdjustment { get; set; }
	public bool enableWordWrapping { get; set; }
	public float wordWrappingRatios { get; set; }
	public TextOverflowModes overflowMode { get; set; }
	public bool isTextOverflowing { get; }
	public int firstOverflowCharacterIndex { get; }
	public TMP_Text linkedTextComponent { get; set; }
	public bool isTextTruncated { get; }
	public bool enableKerning { get; set; }
	public bool extraPadding { get; set; }
	public bool richText { get; set; }
	public bool parseCtrlCharacters { get; set; }
	public bool isOverlay { get; set; }
	public bool isOrthographic { get; set; }
	public bool enableCulling { get; set; }
	public bool ignoreVisibility { get; set; }
	public TextureMappingOptions horizontalMapping { get; set; }
	public TextureMappingOptions verticalMapping { get; set; }
	public float mappingUvLineOffset { get; set; }
	public TextRenderFlags renderMode { get; set; }
	public VertexSortingOrder geometrySortingOrder { get; set; }
	public bool isTextObjectScaleStatic { get; set; }
	public bool vertexBufferAutoSizeReduction { get; set; }
	public int firstVisibleCharacter { get; set; }
	public int maxVisibleCharacters { get; set; }
	public int maxVisibleWords { get; set; }
	public int maxVisibleLines { get; set; }
	public bool useMaxVisibleDescender { get; set; }
	public int pageToDisplay { get; set; }
	public virtual Vector4 margin { get; set; }
	public TMP_TextInfo textInfo { get; }
	public bool havePropertiesChanged { get; set; }
	public bool isUsingLegacyAnimationComponent { get; set; }
	public Transform transform { get; }
	public RectTransform rectTransform { get; }
	public virtual bool autoSizeTextContainer { get; set; }
	public virtual Mesh mesh { get; }
	public bool isVolumetricText { get; set; }
	public Bounds bounds { get; }
	public Bounds textBounds { get; }
	protected TMP_SpriteAnimator spriteAnimator { get; }
	public float flexibleHeight { get; }
	public float flexibleWidth { get; }
	public float minWidth { get; }
	public float minHeight { get; }
	public float maxWidth { get; }
	public float maxHeight { get; }
	protected LayoutElement layoutElement { get; }
	public virtual float preferredWidth { get; }
	public virtual float preferredHeight { get; }
	public virtual float renderedWidth { get; }
	public virtual float renderedHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0x18FB990 Offset: 0x18FBA91 VA: 0x18FB990 Slot: 65
	public virtual string get_text() { }

	// RVA: 0x18FBA90 Offset: 0x18FBB91 VA: 0x18FBA90 Slot: 66
	public virtual void set_text(string value) { }

	// RVA: 0x18FBB40 Offset: 0x18FBC41 VA: 0x18FBB40
	public ITextPreprocessor get_textPreprocessor() { }

	// RVA: 0x18FBB50 Offset: 0x18FBC51 VA: 0x18FBB50
	public void set_textPreprocessor(ITextPreprocessor value) { }

	// RVA: 0x18FBB60 Offset: 0x18FBC61 VA: 0x18FBB60
	public bool get_isRightToLeftText() { }

	// RVA: 0x18FBB70 Offset: 0x18FBC71 VA: 0x18FBB70
	public void set_isRightToLeftText(bool value) { }

	// RVA: 0x18FBBE0 Offset: 0x18FBCE1 VA: 0x18FBBE0
	public TMP_FontAsset get_font() { }

	// RVA: 0x18FBBF0 Offset: 0x18FBCF1 VA: 0x18FBBF0
	public void set_font(TMP_FontAsset value) { }

	// RVA: 0x18FBCE0 Offset: 0x18FBDE1 VA: 0x18FBCE0 Slot: 67
	public virtual Material get_fontSharedMaterial() { }

	// RVA: 0x18FBCF0 Offset: 0x18FBDF1 VA: 0x18FBCF0 Slot: 68
	public virtual void set_fontSharedMaterial(Material value) { }

	// RVA: 0x18FBDD0 Offset: 0x18FBED1 VA: 0x18FBDD0 Slot: 69
	public virtual Material[] get_fontSharedMaterials() { }

	// RVA: 0x18FBDE0 Offset: 0x18FBEE1 VA: 0x18FBDE0 Slot: 70
	public virtual void set_fontSharedMaterials(Material[] value) { }

	// RVA: 0x18FBE40 Offset: 0x18FBF41 VA: 0x18FBE40
	public Material get_fontMaterial() { }

	// RVA: 0x18FBE60 Offset: 0x18FBF61 VA: 0x18FBE60
	public void set_fontMaterial(Material value) { }

	// RVA: 0x18FBF70 Offset: 0x18FC071 VA: 0x18FBF70 Slot: 71
	public virtual Material[] get_fontMaterials() { }

	// RVA: 0x18FBF90 Offset: 0x18FC091 VA: 0x18FBF90 Slot: 72
	public virtual void set_fontMaterials(Material[] value) { }

	// RVA: 0x18FBFF0 Offset: 0x18FC0F1 VA: 0x18FBFF0 Slot: 22
	public override Color get_color() { }

	// RVA: 0x18FC010 Offset: 0x18FC111 VA: 0x18FC010 Slot: 23
	public override void set_color(Color value) { }

	// RVA: 0x18FC0C0 Offset: 0x18FC1C1 VA: 0x18FC0C0
	public float get_alpha() { }

	// RVA: 0x18FC0D0 Offset: 0x18FC1D1 VA: 0x18FC0D0
	public void set_alpha(float value) { }

	// RVA: 0x18FC100 Offset: 0x18FC201 VA: 0x18FC100
	public bool get_enableVertexGradient() { }

	// RVA: 0x18FC110 Offset: 0x18FC211 VA: 0x18FC110
	public void set_enableVertexGradient(bool value) { }

	// RVA: 0x18FC150 Offset: 0x18FC251 VA: 0x18FC150
	public VertexGradient get_colorGradient() { }

	// RVA: 0x18FC180 Offset: 0x18FC281 VA: 0x18FC180
	public void set_colorGradient(VertexGradient value) { }

	// RVA: 0x18FC1C0 Offset: 0x18FC2C1 VA: 0x18FC1C0
	public TMP_ColorGradient get_colorGradientPreset() { }

	// RVA: 0x18FC1D0 Offset: 0x18FC2D1 VA: 0x18FC1D0
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	// RVA: 0x18FC210 Offset: 0x18FC311 VA: 0x18FC210
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x18FC220 Offset: 0x18FC321 VA: 0x18FC220
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x18FC280 Offset: 0x18FC381 VA: 0x18FC280
	public bool get_tintAllSprites() { }

	// RVA: 0x18FC290 Offset: 0x18FC391 VA: 0x18FC290
	public void set_tintAllSprites(bool value) { }

	// RVA: 0x18FC2D0 Offset: 0x18FC3D1 VA: 0x18FC2D0
	public TMP_StyleSheet get_styleSheet() { }

	// RVA: 0x18FC2E0 Offset: 0x18FC3E1 VA: 0x18FC2E0
	public void set_styleSheet(TMP_StyleSheet value) { }

	// RVA: 0x18FC340 Offset: 0x18FC441 VA: 0x18FC340
	public TMP_Style get_textStyle() { }

	// RVA: 0x18FC540 Offset: 0x18FC641 VA: 0x18FC540
	public void set_textStyle(TMP_Style value) { }

	// RVA: 0x18FC5A0 Offset: 0x18FC6A1 VA: 0x18FC5A0
	public bool get_overrideColorTags() { }

	// RVA: 0x18FC5B0 Offset: 0x18FC6B1 VA: 0x18FC5B0
	public void set_overrideColorTags(bool value) { }

	// RVA: 0x18FC5F0 Offset: 0x18FC6F1 VA: 0x18FC5F0
	public Color32 get_faceColor() { }

	// RVA: 0x18FC6E0 Offset: 0x18FC7E1 VA: 0x18FC6E0
	public void set_faceColor(Color32 value) { }

	// RVA: 0x18FC780 Offset: 0x18FC881 VA: 0x18FC780
	public Color32 get_outlineColor() { }

	// RVA: 0x18FC870 Offset: 0x18FC971 VA: 0x18FC870
	public void set_outlineColor(Color32 value) { }

	// RVA: 0x18FC900 Offset: 0x18FCA01 VA: 0x18FC900
	public float get_outlineWidth() { }

	// RVA: 0x18FC9E0 Offset: 0x18FCAE1 VA: 0x18FC9E0
	public void set_outlineWidth(float value) { }

	// RVA: 0x18FCA60 Offset: 0x18FCB61 VA: 0x18FCA60
	public float get_fontSize() { }

	// RVA: 0x18FCA70 Offset: 0x18FCB71 VA: 0x18FCA70
	public void set_fontSize(float value) { }

	// RVA: 0x18FCAE0 Offset: 0x18FCBE1 VA: 0x18FCAE0
	public FontWeight get_fontWeight() { }

	// RVA: 0x18FCAF0 Offset: 0x18FCBF1 VA: 0x18FCAF0
	public void set_fontWeight(FontWeight value) { }

	// RVA: 0x18FCB50 Offset: 0x18FCC51 VA: 0x18FCB50
	public float get_pixelsPerUnit() { }

	// RVA: 0x18FCCE0 Offset: 0x18FCDE1 VA: 0x18FCCE0
	public bool get_enableAutoSizing() { }

	// RVA: 0x18FCCF0 Offset: 0x18FCDF1 VA: 0x18FCCF0
	public void set_enableAutoSizing(bool value) { }

	// RVA: 0x18FCD60 Offset: 0x18FCE61 VA: 0x18FCD60
	public float get_fontSizeMin() { }

	// RVA: 0x18FCD70 Offset: 0x18FCE71 VA: 0x18FCD70
	public void set_fontSizeMin(float value) { }

	// RVA: 0x18FCDD0 Offset: 0x18FCED1 VA: 0x18FCDD0
	public float get_fontSizeMax() { }

	// RVA: 0x18FCDE0 Offset: 0x18FCEE1 VA: 0x18FCDE0
	public void set_fontSizeMax(float value) { }

	// RVA: 0x18FCE40 Offset: 0x18FCF41 VA: 0x18FCE40
	public FontStyles get_fontStyle() { }

	// RVA: 0x18FCE50 Offset: 0x18FCF51 VA: 0x18FCE50
	public void set_fontStyle(FontStyles value) { }

	// RVA: 0x18FCEB0 Offset: 0x18FCFB1 VA: 0x18FCEB0
	public bool get_isUsingBold() { }

	// RVA: 0x18FCEC0 Offset: 0x18FCFC1 VA: 0x18FCEC0
	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	// RVA: 0x18FCED0 Offset: 0x18FCFD1 VA: 0x18FCED0
	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	// RVA: 0x18FCF00 Offset: 0x18FD001 VA: 0x18FCF00
	public VerticalAlignmentOptions get_verticalAlignment() { }

	// RVA: 0x18FCF10 Offset: 0x18FD011 VA: 0x18FCF10
	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	// RVA: 0x18FCF40 Offset: 0x18FD041 VA: 0x18FCF40
	public TextAlignmentOptions get_alignment() { }

	// RVA: 0x18FCF50 Offset: 0x18FD051 VA: 0x18FCF50
	public void set_alignment(TextAlignmentOptions value) { }

	// RVA: 0x18FCFA0 Offset: 0x18FD0A1 VA: 0x18FCFA0
	public float get_characterSpacing() { }

	// RVA: 0x18FCFB0 Offset: 0x18FD0B1 VA: 0x18FCFB0
	public void set_characterSpacing(float value) { }

	// RVA: 0x18FD010 Offset: 0x18FD111 VA: 0x18FD010
	public float get_wordSpacing() { }

	// RVA: 0x18FD020 Offset: 0x18FD121 VA: 0x18FD020
	public void set_wordSpacing(float value) { }

	// RVA: 0x18FD080 Offset: 0x18FD181 VA: 0x18FD080
	public float get_lineSpacing() { }

	// RVA: 0x18FD090 Offset: 0x18FD191 VA: 0x18FD090
	public void set_lineSpacing(float value) { }

	// RVA: 0x18FD0F0 Offset: 0x18FD1F1 VA: 0x18FD0F0
	public float get_lineSpacingAdjustment() { }

	// RVA: 0x18FD100 Offset: 0x18FD201 VA: 0x18FD100
	public void set_lineSpacingAdjustment(float value) { }

	// RVA: 0x18FD160 Offset: 0x18FD261 VA: 0x18FD160
	public float get_paragraphSpacing() { }

	// RVA: 0x18FD170 Offset: 0x18FD271 VA: 0x18FD170
	public void set_paragraphSpacing(float value) { }

	// RVA: 0x18FD1D0 Offset: 0x18FD2D1 VA: 0x18FD1D0
	public float get_characterWidthAdjustment() { }

	// RVA: 0x18FD1E0 Offset: 0x18FD2E1 VA: 0x18FD1E0
	public void set_characterWidthAdjustment(float value) { }

	// RVA: 0x18FD240 Offset: 0x18FD341 VA: 0x18FD240
	public bool get_enableWordWrapping() { }

	// RVA: 0x18FD250 Offset: 0x18FD351 VA: 0x18FD250
	public void set_enableWordWrapping(bool value) { }

	// RVA: 0x18FD2C0 Offset: 0x18FD3C1 VA: 0x18FD2C0
	public float get_wordWrappingRatios() { }

	// RVA: 0x18FD2D0 Offset: 0x18FD3D1 VA: 0x18FD2D0
	public void set_wordWrappingRatios(float value) { }

	// RVA: 0x18FD330 Offset: 0x18FD431 VA: 0x18FD330
	public TextOverflowModes get_overflowMode() { }

	// RVA: 0x18FD340 Offset: 0x18FD441 VA: 0x18FD340
	public void set_overflowMode(TextOverflowModes value) { }

	// RVA: 0x18FD3A0 Offset: 0x18FD4A1 VA: 0x18FD3A0
	public bool get_isTextOverflowing() { }

	// RVA: 0x18FD3B0 Offset: 0x18FD4B1 VA: 0x18FD3B0
	public int get_firstOverflowCharacterIndex() { }

	// RVA: 0x18FD3C0 Offset: 0x18FD4C1 VA: 0x18FD3C0
	public TMP_Text get_linkedTextComponent() { }

	// RVA: 0x18FD3D0 Offset: 0x18FD4D1 VA: 0x18FD3D0
	public void set_linkedTextComponent(TMP_Text value) { }

	// RVA: 0x18FD730 Offset: 0x18FD831 VA: 0x18FD730
	public bool get_isTextTruncated() { }

	// RVA: 0x18FD740 Offset: 0x18FD841 VA: 0x18FD740
	public bool get_enableKerning() { }

	// RVA: 0x18FD750 Offset: 0x18FD851 VA: 0x18FD750
	public void set_enableKerning(bool value) { }

	// RVA: 0x18FD7C0 Offset: 0x18FD8C1 VA: 0x18FD7C0
	public bool get_extraPadding() { }

	// RVA: 0x18FD7D0 Offset: 0x18FD8D1 VA: 0x18FD7D0
	public void set_extraPadding(bool value) { }

	// RVA: 0x18FD840 Offset: 0x18FD941 VA: 0x18FD840
	public bool get_richText() { }

	// RVA: 0x18FD850 Offset: 0x18FD951 VA: 0x18FD850
	public void set_richText(bool value) { }

	// RVA: 0x18FD8C0 Offset: 0x18FD9C1 VA: 0x18FD8C0
	public bool get_parseCtrlCharacters() { }

	// RVA: 0x18FD8D0 Offset: 0x18FD9D1 VA: 0x18FD8D0
	public void set_parseCtrlCharacters(bool value) { }

	// RVA: 0x18FD940 Offset: 0x18FDA41 VA: 0x18FD940
	public bool get_isOverlay() { }

	// RVA: 0x18FD950 Offset: 0x18FDA51 VA: 0x18FD950
	public void set_isOverlay(bool value) { }

	// RVA: 0x18FD9C0 Offset: 0x18FDAC1 VA: 0x18FD9C0
	public bool get_isOrthographic() { }

	// RVA: 0x18FD9D0 Offset: 0x18FDAD1 VA: 0x18FD9D0
	public void set_isOrthographic(bool value) { }

	// RVA: 0x18FDA10 Offset: 0x18FDB11 VA: 0x18FDA10
	public bool get_enableCulling() { }

	// RVA: 0x18FDA20 Offset: 0x18FDB21 VA: 0x18FDA20
	public void set_enableCulling(bool value) { }

	// RVA: 0x18FDA70 Offset: 0x18FDB71 VA: 0x18FDA70
	public bool get_ignoreVisibility() { }

	// RVA: 0x18FDA80 Offset: 0x18FDB81 VA: 0x18FDA80
	public void set_ignoreVisibility(bool value) { }

	// RVA: 0x18FDAB0 Offset: 0x18FDBB1 VA: 0x18FDAB0
	public TextureMappingOptions get_horizontalMapping() { }

	// RVA: 0x18FDAC0 Offset: 0x18FDBC1 VA: 0x18FDAC0
	public void set_horizontalMapping(TextureMappingOptions value) { }

	// RVA: 0x18FDAF0 Offset: 0x18FDBF1 VA: 0x18FDAF0
	public TextureMappingOptions get_verticalMapping() { }

	// RVA: 0x18FDB00 Offset: 0x18FDC01 VA: 0x18FDB00
	public void set_verticalMapping(TextureMappingOptions value) { }

	// RVA: 0x18FDB30 Offset: 0x18FDC31 VA: 0x18FDB30
	public float get_mappingUvLineOffset() { }

	// RVA: 0x18FDB40 Offset: 0x18FDC41 VA: 0x18FDB40
	public void set_mappingUvLineOffset(float value) { }

	// RVA: 0x18FDB70 Offset: 0x18FDC71 VA: 0x18FDB70
	public TextRenderFlags get_renderMode() { }

	// RVA: 0x18FDB80 Offset: 0x18FDC81 VA: 0x18FDB80
	public void set_renderMode(TextRenderFlags value) { }

	// RVA: 0x18FDBA0 Offset: 0x18FDCA1 VA: 0x18FDBA0
	public VertexSortingOrder get_geometrySortingOrder() { }

	// RVA: 0x18FDBB0 Offset: 0x18FDCB1 VA: 0x18FDBB0
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	// RVA: 0x18FDBD0 Offset: 0x18FDCD1 VA: 0x18FDBD0
	public bool get_isTextObjectScaleStatic() { }

	// RVA: 0x18FDBE0 Offset: 0x18FDCE1 VA: 0x18FDBE0
	public void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x18FDC90 Offset: 0x18FDD91 VA: 0x18FDC90
	public bool get_vertexBufferAutoSizeReduction() { }

	// RVA: 0x18FDCA0 Offset: 0x18FDDA1 VA: 0x18FDCA0
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	// RVA: 0x18FDCC0 Offset: 0x18FDDC1 VA: 0x18FDCC0
	public int get_firstVisibleCharacter() { }

	// RVA: 0x18FDCD0 Offset: 0x18FDDD1 VA: 0x18FDCD0
	public void set_firstVisibleCharacter(int value) { }

	// RVA: 0x18FDD00 Offset: 0x18FDE01 VA: 0x18FDD00
	public int get_maxVisibleCharacters() { }

	// RVA: 0x18FDD10 Offset: 0x18FDE11 VA: 0x18FDD10
	public void set_maxVisibleCharacters(int value) { }

	// RVA: 0x18FDD40 Offset: 0x18FDE41 VA: 0x18FDD40
	public int get_maxVisibleWords() { }

	// RVA: 0x18FDD50 Offset: 0x18FDE51 VA: 0x18FDD50
	public void set_maxVisibleWords(int value) { }

	// RVA: 0x18FDD80 Offset: 0x18FDE81 VA: 0x18FDD80
	public int get_maxVisibleLines() { }

	// RVA: 0x18FDD90 Offset: 0x18FDE91 VA: 0x18FDD90
	public void set_maxVisibleLines(int value) { }

	// RVA: 0x18FDDC0 Offset: 0x18FDEC1 VA: 0x18FDDC0
	public bool get_useMaxVisibleDescender() { }

	// RVA: 0x18FDDD0 Offset: 0x18FDED1 VA: 0x18FDDD0
	public void set_useMaxVisibleDescender(bool value) { }

	// RVA: 0x18FDE10 Offset: 0x18FDF11 VA: 0x18FDE10
	public int get_pageToDisplay() { }

	// RVA: 0x18FDE20 Offset: 0x18FDF21 VA: 0x18FDE20
	public void set_pageToDisplay(int value) { }

	// RVA: 0x18FDE50 Offset: 0x18FDF51 VA: 0x18FDE50 Slot: 73
	public virtual Vector4 get_margin() { }

	// RVA: 0x18FDE70 Offset: 0x18FDF71 VA: 0x18FDE70 Slot: 74
	public virtual void set_margin(Vector4 value) { }

	// RVA: 0x18FDF20 Offset: 0x18FE021 VA: 0x18FDF20
	public TMP_TextInfo get_textInfo() { }

	// RVA: 0x18FDF30 Offset: 0x18FE031 VA: 0x18FDF30
	public bool get_havePropertiesChanged() { }

	// RVA: 0x18F9B20 Offset: 0x18F9C21 VA: 0x18F9B20
	public void set_havePropertiesChanged(bool value) { }

	// RVA: 0x18FDF40 Offset: 0x18FE041 VA: 0x18FDF40
	public bool get_isUsingLegacyAnimationComponent() { }

	// RVA: 0x18FDF50 Offset: 0x18FE051 VA: 0x18FDF50
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	// RVA: 0x18FAC70 Offset: 0x18FAD71 VA: 0x18FAC70
	public Transform get_transform() { }

	// RVA: 0x18FAD30 Offset: 0x18FAE31 VA: 0x18FAD30
	public RectTransform get_rectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x4E960 Offset: 0x4EA61 VA: 0x4E960
	// RVA: 0x18FDF60 Offset: 0x18FE061 VA: 0x18FDF60 Slot: 75
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGeneratedAttribute] // RVA: 0x4E970 Offset: 0x4EA71 VA: 0x4E970
	// RVA: 0x18FDF70 Offset: 0x18FE071 VA: 0x18FDF70 Slot: 76
	public virtual void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x18FDF80 Offset: 0x18FE081 VA: 0x18FDF80 Slot: 77
	public virtual Mesh get_mesh() { }

	// RVA: 0x18FDF90 Offset: 0x18FE091 VA: 0x18FDF90
	public bool get_isVolumetricText() { }

	// RVA: 0x18FDFA0 Offset: 0x18FE0A1 VA: 0x18FDFA0
	public void set_isVolumetricText(bool value) { }

	// RVA: 0x18FE020 Offset: 0x18FE121 VA: 0x18FE020
	public Bounds get_bounds() { }

	// RVA: 0x18FE0E0 Offset: 0x18FE1E1 VA: 0x18FE0E0
	public Bounds get_textBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x4E980 Offset: 0x4EA81 VA: 0x4E980
	// RVA: 0x18FE340 Offset: 0x18FE441 VA: 0x18FE340
	public static void add_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4E990 Offset: 0x4EA91 VA: 0x4E990
	// RVA: 0x18FE440 Offset: 0x18FE541 VA: 0x18FE440
	public static void remove_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4E9A0 Offset: 0x4EAA1 VA: 0x4E9A0
	// RVA: 0x18FE540 Offset: 0x18FE641 VA: 0x18FE540
	public static void add_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4E9B0 Offset: 0x4EAB1 VA: 0x4E9B0
	// RVA: 0x18FE640 Offset: 0x18FE741 VA: 0x18FE640
	public static void remove_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4E9C0 Offset: 0x4EAC1 VA: 0x4E9C0
	// RVA: 0x18FE740 Offset: 0x18FE841 VA: 0x18FE740 Slot: 78
	public virtual void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4E9D0 Offset: 0x4EAD1 VA: 0x4E9D0
	// RVA: 0x18FE7F0 Offset: 0x18FE8F1 VA: 0x18FE7F0 Slot: 79
	public virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x18FE8A0 Offset: 0x18FE9A1 VA: 0x18FE8A0
	protected TMP_SpriteAnimator get_spriteAnimator() { }

	// RVA: 0x18FE9C0 Offset: 0x18FEAC1 VA: 0x18FE9C0 Slot: 80
	public float get_flexibleHeight() { }

	// RVA: 0x18FE9D0 Offset: 0x18FEAD1 VA: 0x18FE9D0 Slot: 81
	public float get_flexibleWidth() { }

	// RVA: 0x18FE9E0 Offset: 0x18FEAE1 VA: 0x18FE9E0 Slot: 82
	public float get_minWidth() { }

	// RVA: 0x18FE9F0 Offset: 0x18FEAF1 VA: 0x18FE9F0 Slot: 83
	public float get_minHeight() { }

	// RVA: 0x18FEA00 Offset: 0x18FEB01 VA: 0x18FEA00
	public float get_maxWidth() { }

	// RVA: 0x18FEA10 Offset: 0x18FEB11 VA: 0x18FEA10
	public float get_maxHeight() { }

	// RVA: 0x18FEA20 Offset: 0x18FEB21 VA: 0x18FEA20
	protected LayoutElement get_layoutElement() { }

	// RVA: 0x18FEAE0 Offset: 0x18FEBE1 VA: 0x18FEAE0 Slot: 84
	public virtual float get_preferredWidth() { }

	// RVA: 0x18FEC60 Offset: 0x18FED61 VA: 0x18FEC60 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x18FEE30 Offset: 0x18FEF31 VA: 0x18FEE30 Slot: 86
	public virtual float get_renderedWidth() { }

	// RVA: 0x18FEED0 Offset: 0x18FEFD1 VA: 0x18FEED0 Slot: 87
	public virtual float get_renderedHeight() { }

	// RVA: 0x18FEF70 Offset: 0x18FF071 VA: 0x18FEF70 Slot: 88
	public int get_layoutPriority() { }

	// RVA: 0x18FEF80 Offset: 0x18FF081 VA: 0x18FEF80 Slot: 89
	protected virtual void LoadFontAsset() { }

	// RVA: 0x18FEF90 Offset: 0x18FF091 VA: 0x18FEF90 Slot: 90
	protected virtual void SetSharedMaterial(Material mat) { }

	// RVA: 0x18FEFA0 Offset: 0x18FF0A1 VA: 0x18FEFA0 Slot: 91
	protected virtual Material GetMaterial(Material mat) { }

	// RVA: 0x18FEFB0 Offset: 0x18FF0B1 VA: 0x18FEFB0 Slot: 92
	protected virtual void SetFontBaseMaterial(Material mat) { }

	// RVA: 0x18FEFC0 Offset: 0x18FF0C1 VA: 0x18FEFC0 Slot: 93
	protected virtual Material[] GetSharedMaterials() { }

	// RVA: 0x18FEFD0 Offset: 0x18FF0D1 VA: 0x18FEFD0 Slot: 94
	protected virtual void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x18FEFE0 Offset: 0x18FF0E1 VA: 0x18FEFE0 Slot: 95
	protected virtual Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x18FEFF0 Offset: 0x18FF0F1 VA: 0x18FEFF0 Slot: 96
	protected virtual Material CreateMaterialInstance(Material source) { }

	// RVA: 0x18FF0B0 Offset: 0x18FF1B1 VA: 0x18FF0B0
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	// RVA: 0x18FF1A0 Offset: 0x18FF2A1 VA: 0x18FF1A0
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	// RVA: 0x18FF1B0 Offset: 0x18FF2B1 VA: 0x18FF1B0
	protected void SetTextSortingOrder(int[] order) { }

	// RVA: 0x18FF1C0 Offset: 0x18FF2C1 VA: 0x18FF1C0 Slot: 97
	protected virtual void SetFaceColor(Color32 color) { }

	// RVA: 0x18FF1D0 Offset: 0x18FF2D1 VA: 0x18FF1D0 Slot: 98
	protected virtual void SetOutlineColor(Color32 color) { }

	// RVA: 0x18FF1E0 Offset: 0x18FF2E1 VA: 0x18FF1E0 Slot: 99
	protected virtual void SetOutlineThickness(float thickness) { }

	// RVA: 0x18FF1F0 Offset: 0x18FF2F1 VA: 0x18FF1F0 Slot: 100
	protected virtual void SetShaderDepth() { }

	// RVA: 0x18FF200 Offset: 0x18FF301 VA: 0x18FF200 Slot: 101
	protected virtual void SetCulling() { }

	// RVA: 0x18FF210 Offset: 0x18FF311 VA: 0x18FF210 Slot: 102
	internal virtual void UpdateCulling() { }

	// RVA: 0x18FF220 Offset: 0x18FF321 VA: 0x18FF220 Slot: 103
	protected virtual float GetPaddingForMaterial() { }

	// RVA: 0x18FF360 Offset: 0x18FF461 VA: 0x18FF360 Slot: 104
	protected virtual float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x18FF480 Offset: 0x18FF581 VA: 0x18FF480 Slot: 105
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x18FF490 Offset: 0x18FF591 VA: 0x18FF490 Slot: 106
	public virtual void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x18FF4A0 Offset: 0x18FF5A1 VA: 0x18FF4A0 Slot: 107
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x18FF4B0 Offset: 0x18FF5B1 VA: 0x18FF4B0 Slot: 108
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x18FF4C0 Offset: 0x18FF5C1 VA: 0x18FF4C0 Slot: 109
	public virtual void UpdateVertexData() { }

	// RVA: 0x18FF4D0 Offset: 0x18FF5D1 VA: 0x18FF4D0 Slot: 110
	public virtual void SetVertices(Vector3[] vertices) { }

	// RVA: 0x18FF4E0 Offset: 0x18FF5E1 VA: 0x18FF4E0 Slot: 111
	public virtual void UpdateMeshPadding() { }

	// RVA: 0x18FF4F0 Offset: 0x18FF5F1 VA: 0x18FF4F0 Slot: 47
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x18FF590 Offset: 0x18FF691 VA: 0x18FF590 Slot: 49
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x18FF5F0 Offset: 0x18FF6F1 VA: 0x18FF5F0 Slot: 112
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x18FF600 Offset: 0x18FF701 VA: 0x18FF600 Slot: 113
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x18FF610 Offset: 0x18FF711 VA: 0x18FF610
	protected void ParseInputText() { }

	// RVA: 0x18FF720 Offset: 0x18FF821 VA: 0x18FF720
	private void PopulateTextBackingArray(string sourceText) { }

	// RVA: 0x19002F0 Offset: 0x19003F1 VA: 0x19002F0
	private void PopulateTextBackingArray(string sourceText, int start, int length) { }

	// RVA: 0x1900400 Offset: 0x1900501 VA: 0x1900400
	private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length) { }

	// RVA: 0x1900540 Offset: 0x1900641 VA: 0x1900540
	private void PopulateTextBackingArray(char[] sourceText, int start, int length) { }

	// RVA: 0x18FF740 Offset: 0x18FF841 VA: 0x18FF740
	private void PopulateTextProcessingArray() { }

	// RVA: 0x1901900 Offset: 0x1901A01 VA: 0x1901900
	private void SetTextInternal(string sourceText) { }

	// RVA: 0x1901950 Offset: 0x1901A51 VA: 0x1901950
	public void SetText(string sourceText, bool syncTextInputBox = True) { }

	// RVA: 0x19019E0 Offset: 0x1901AE1 VA: 0x19019E0
	public void SetText(string sourceText, float arg0) { }

	// RVA: 0x1901CD0 Offset: 0x1901DD1 VA: 0x1901CD0
	public void SetText(string sourceText, float arg0, float arg1) { }

	// RVA: 0x1901CF0 Offset: 0x1901DF1 VA: 0x1901CF0
	public void SetText(string sourceText, float arg0, float arg1, float arg2) { }

	// RVA: 0x1901D10 Offset: 0x1901E11 VA: 0x1901D10
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3) { }

	// RVA: 0x1901D30 Offset: 0x1901E31 VA: 0x1901D30
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	// RVA: 0x1901D40 Offset: 0x1901E41 VA: 0x1901D40
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	// RVA: 0x1901D50 Offset: 0x1901E51 VA: 0x1901D50
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	// RVA: 0x1901A00 Offset: 0x1901B01 VA: 0x1901A00
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	// RVA: 0x1902090 Offset: 0x1902191 VA: 0x1902090
	public void SetText(StringBuilder sourceText) { }

	// RVA: 0x1902120 Offset: 0x1902221 VA: 0x1902120
	private void SetText(StringBuilder sourceText, int start, int length) { }

	// RVA: 0x1902180 Offset: 0x1902281 VA: 0x1902180
	public void SetText(char[] sourceText) { }

	// RVA: 0x1902260 Offset: 0x1902361 VA: 0x1902260
	public void SetText(char[] sourceText, int start, int length) { }

	// RVA: 0x19022C0 Offset: 0x19023C1 VA: 0x19022C0
	public void SetCharArray(char[] sourceText) { }

	// RVA: 0x1902200 Offset: 0x1902301 VA: 0x1902200
	public void SetCharArray(char[] sourceText, int start, int length) { }

	// RVA: 0x18FC3B0 Offset: 0x18FC4B1 VA: 0x18FC3B0
	private TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x1900D50 Offset: 0x1900E51 VA: 0x1900D50
	private bool ReplaceOpeningStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x19027A0 Offset: 0x19028A1 VA: 0x19027A0
	private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1901160 Offset: 0x1901261 VA: 0x1901160
	private void ReplaceClosingStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1902BB0 Offset: 0x1902CB1 VA: 0x1902BB0
	private void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1900680 Offset: 0x1900781 VA: 0x1900680
	private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1901540 Offset: 0x1901641 VA: 0x1901540
	private void InsertClosingStyleTag(ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1902670 Offset: 0x1902771 VA: 0x1902670
	private int GetMarkupTagHashCode(int[] tagDefinition, int readIndex) { }

	// RVA: 0x1900C30 Offset: 0x1900D31 VA: 0x1900C30
	private int GetMarkupTagHashCode(TMP_Text.TextBackingContainer tagDefinition, int readIndex) { }

	// RVA: 0x1902F90 Offset: 0x1903091 VA: 0x1902F90
	private int GetStyleHashCode(ref int[] text, int index, out int closeIndex) { }

	// RVA: 0x1902340 Offset: 0x1902441 VA: 0x1902340
	private int GetStyleHashCode(ref TMP_Text.TextBackingContainer text, int index, out int closeIndex) { }

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2023D30 Offset: 0x2023E31 VA: 0x2023D30
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x2023D80 Offset: 0x2023E81 VA: 0x2023D80
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2023DD0 Offset: 0x2023ED1 VA: 0x2023DD0
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x2023E10 Offset: 0x2023F11 VA: 0x2023E10
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: 0x1901D60 Offset: 0x1901E61 VA: 0x1901D60
	private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex) { }

	// RVA: 0x19030A0 Offset: 0x19031A1 VA: 0x19030A0
	private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex) { }

	// RVA: 0x18FB9B0 Offset: 0x18FBAB1 VA: 0x18FB9B0
	private string InternalTextBackingArrayToString() { }

	// RVA: 0x19031E0 Offset: 0x19032E1 VA: 0x19031E0 Slot: 114
	internal virtual int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x19031F0 Offset: 0x19032F1 VA: 0x19031F0
	public Vector2 GetPreferredValues() { }

	// RVA: 0x1903240 Offset: 0x1903341 VA: 0x1903240
	public Vector2 GetPreferredValues(float width, float height) { }

	// RVA: 0x1903490 Offset: 0x1903591 VA: 0x1903490
	public Vector2 GetPreferredValues(string text) { }

	// RVA: 0x1903660 Offset: 0x1903761 VA: 0x1903660
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	// RVA: 0x18FEB10 Offset: 0x18FEC11 VA: 0x18FEB10
	protected float GetPreferredWidth() { }

	// RVA: 0x1903370 Offset: 0x1903471 VA: 0x1903370
	private float GetPreferredWidth(Vector2 margin) { }

	// RVA: 0x18FEC90 Offset: 0x18FED91 VA: 0x18FEC90
	protected float GetPreferredHeight() { }

	// RVA: 0x19033E0 Offset: 0x19034E1 VA: 0x19033E0
	private float GetPreferredHeight(Vector2 margin) { }

	// RVA: 0x19037E0 Offset: 0x19038E1 VA: 0x19037E0
	public Vector2 GetRenderedValues() { }

	// RVA: 0x1903830 Offset: 0x1903931 VA: 0x1903830
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	// RVA: 0x18FEE80 Offset: 0x18FEF81 VA: 0x18FEE80
	private float GetRenderedWidth() { }

	// RVA: 0x1903BD0 Offset: 0x1903CD1 VA: 0x1903BD0
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	// RVA: 0x18FEF20 Offset: 0x18FF021 VA: 0x18FEF20
	private float GetRenderedHeight() { }

	// RVA: 0x1903C20 Offset: 0x1903D21 VA: 0x1903C20
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	// RVA: 0x1903C70 Offset: 0x1903D71 VA: 0x1903C70 Slot: 115
	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled) { }

	// RVA: 0x190CF60 Offset: 0x190D061 VA: 0x190CF60 Slot: 116
	protected virtual Bounds GetCompoundBounds() { }

	// RVA: 0x190CF70 Offset: 0x190D071 VA: 0x190CF70 Slot: 117
	internal virtual Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x18FE140 Offset: 0x18FE241 VA: 0x18FE140
	protected Bounds GetTextBounds() { }

	// RVA: 0x1903880 Offset: 0x1903981 VA: 0x1903880
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	// RVA: 0x190CF80 Offset: 0x190D081 VA: 0x190CF80
	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x190D160 Offset: 0x190D261 VA: 0x190D160
	protected void ResizeLineExtents(int size) { }

	// RVA: 0x190D370 Offset: 0x190D471 VA: 0x190D370 Slot: 118
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x190D380 Offset: 0x190D481 VA: 0x190D380 Slot: 119
	public virtual void ComputeMarginSize() { }

	// RVA: 0x190D390 Offset: 0x190D491 VA: 0x190D390
	protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	// RVA: 0x190CB20 Offset: 0x190CC21 VA: 0x190CB20
	protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	// RVA: 0x190C610 Offset: 0x190C711 VA: 0x190C610
	protected int RestoreWordWrappingState(ref WordWrapState state) { }

	// RVA: 0x190D9E0 Offset: 0x190DAE1 VA: 0x190D9E0 Slot: 120
	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	// RVA: 0x190E3F0 Offset: 0x190E4F1 VA: 0x190E3F0 Slot: 121
	protected virtual void SaveSpriteVertexInfo(Color32 vertexColor) { }

	// RVA: 0x190EAB0 Offset: 0x190EBB1 VA: 0x190EAB0 Slot: 122
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4) { }

	// RVA: 0x190F0D0 Offset: 0x190F1D1 VA: 0x190F0D0 Slot: 123
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) { }

	// RVA: 0x190FAF0 Offset: 0x190FBF1 VA: 0x190FAF0 Slot: 124
	protected virtual void FillSpriteVertexBuffers(int i, int index_X4) { }

	// RVA: 0x1910110 Offset: 0x1910211 VA: 0x1910110 Slot: 125
	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	// RVA: 0x19110E0 Offset: 0x19111E1 VA: 0x19110E0 Slot: 126
	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	// RVA: 0x1911590 Offset: 0x1911691 VA: 0x1911590
	protected void LoadDefaultSettings() { }

	// RVA: 0x19117F0 Offset: 0x19118F1 VA: 0x19117F0
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x1911820 Offset: 0x1911921 VA: 0x1911820
	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x1910F00 Offset: 0x1911001 VA: 0x1910F00
	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x1911A90 Offset: 0x1911B91 VA: 0x1911A90
	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	// RVA: 0x1911B10 Offset: 0x1911C11 VA: 0x1911B10
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	// RVA: 0x1911B90 Offset: 0x1911C91 VA: 0x1911B90
	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	// RVA: 0x1911FB0 Offset: 0x19120B1 VA: 0x1911FB0 Slot: 127
	protected virtual void SetActiveSubMeshes(bool state) { }

	// RVA: 0x1911FC0 Offset: 0x19120C1 VA: 0x1911FC0 Slot: 128
	protected virtual void DestroySubMeshObjects() { }

	// RVA: 0x1911FD0 Offset: 0x19120D1 VA: 0x1911FD0 Slot: 129
	public virtual void ClearMesh() { }

	// RVA: 0x1911FE0 Offset: 0x19120E1 VA: 0x1911FE0 Slot: 130
	public virtual void ClearMesh(bool uploadGeometry) { }

	// RVA: 0x1911FF0 Offset: 0x19120F1 VA: 0x1911FF0 Slot: 131
	public virtual string GetParsedText() { }

	// RVA: 0x18FD630 Offset: 0x18FD731 VA: 0x18FD630
	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	// RVA: 0x18FD4F0 Offset: 0x18FD5F1 VA: 0x18FD4F0
	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	// RVA: 0x1911070 Offset: 0x1911171 VA: 0x1911070
	protected Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0x19120F0 Offset: 0x19121F1 VA: 0x19120F0
	protected float PackUV(float x, float y) { }

	// RVA: 0x1912160 Offset: 0x1912261 VA: 0x1912160 Slot: 132
	internal virtual void InternalUpdate() { }

	// RVA: 0x1912170 Offset: 0x1912271 VA: 0x1912170
	protected int HexToInt(char hex) { }

	// RVA: 0x19121A0 Offset: 0x19122A1 VA: 0x19121A0
	protected int GetUTF16(string text, int i) { }

	// RVA: 0x1902460 Offset: 0x1902561 VA: 0x1902460
	protected int GetUTF16(int[] text, int i) { }

	// RVA: 0x1912250 Offset: 0x1912351 VA: 0x1912250
	internal int GetUTF16(uint[] text, int i) { }

	// RVA: 0x1912310 Offset: 0x1912411 VA: 0x1912310
	protected int GetUTF16(StringBuilder text, int i) { }

	// RVA: 0x1900A40 Offset: 0x1900B41 VA: 0x1900A40
	private int GetUTF16(TMP_Text.TextBackingContainer text, int i) { }

	// RVA: 0x19123C0 Offset: 0x19124C1 VA: 0x19123C0
	protected int GetUTF32(string text, int i) { }

	// RVA: 0x1902520 Offset: 0x1902621 VA: 0x1902520
	protected int GetUTF32(int[] text, int i) { }

	// RVA: 0x1912500 Offset: 0x1912601 VA: 0x1912500
	internal int GetUTF32(uint[] text, int i) { }

	// RVA: 0x1912650 Offset: 0x1912751 VA: 0x1912650
	protected int GetUTF32(StringBuilder text, int i) { }

	// RVA: 0x1900AF0 Offset: 0x1900BF1 VA: 0x1900AF0
	private int GetUTF32(TMP_Text.TextBackingContainer text, int i) { }

	// RVA: 0x1912790 Offset: 0x1912891 VA: 0x1912790
	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0x1912BC0 Offset: 0x1912CC1 VA: 0x1912BC0
	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0x1912E40 Offset: 0x1912F41 VA: 0x1912E40
	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x19130C0 Offset: 0x19131C1 VA: 0x19130C0
	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x1912F00 Offset: 0x1913001 VA: 0x1912F00
	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0x1906000 Offset: 0x1906101 VA: 0x1906000
	internal bool ValidateHtmlTag(TMP_Text.UnicodeChar[] chars, int startIndex, out int endIndex) { }

	// RVA: 0x19130F0 Offset: 0x19131F1 VA: 0x19130F0
	protected void .ctor() { }

	// RVA: 0x1913C20 Offset: 0x1913D21 VA: 0x1913C20
	private static void .cctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_TextElement // TypeDefIndex: 7456
{
	// Fields
	[SerializeField] // RVA: 0x4E450 Offset: 0x4E551 VA: 0x4E450
	protected TextElementType m_ElementType; // 0x10
	[SerializeField] // RVA: 0x4E460 Offset: 0x4E561 VA: 0x4E460
	internal uint m_Unicode; // 0x14
	internal TMP_Asset m_TextAsset; // 0x18
	internal Glyph m_Glyph; // 0x20
	[SerializeField] // RVA: 0x4E470 Offset: 0x4E571 VA: 0x4E470
	internal uint m_GlyphIndex; // 0x28
	[SerializeField] // RVA: 0x4E480 Offset: 0x4E581 VA: 0x4E480
	internal float m_Scale; // 0x2C

	// Properties
	public TextElementType elementType { get; }
	public uint unicode { get; set; }
	public TMP_Asset textAsset { get; set; }
	public Glyph glyph { get; set; }
	public uint glyphIndex { get; set; }
	public float scale { get; set; }

	// Methods

	// RVA: 0x197F3A0 Offset: 0x197F4A1 VA: 0x197F3A0
	public TextElementType get_elementType() { }

	// RVA: 0x197F3B0 Offset: 0x197F4B1 VA: 0x197F3B0
	public uint get_unicode() { }

	// RVA: 0x197F3C0 Offset: 0x197F4C1 VA: 0x197F3C0
	public void set_unicode(uint value) { }

	// RVA: 0x197F3D0 Offset: 0x197F4D1 VA: 0x197F3D0
	public TMP_Asset get_textAsset() { }

	// RVA: 0x197F3E0 Offset: 0x197F4E1 VA: 0x197F3E0
	public void set_textAsset(TMP_Asset value) { }

	// RVA: 0x197F3F0 Offset: 0x197F4F1 VA: 0x197F3F0
	public Glyph get_glyph() { }

	// RVA: 0x197F400 Offset: 0x197F501 VA: 0x197F400
	public void set_glyph(Glyph value) { }

	// RVA: 0x197F410 Offset: 0x197F511 VA: 0x197F410
	public uint get_glyphIndex() { }

	// RVA: 0x197F420 Offset: 0x197F521 VA: 0x197F420
	public void set_glyphIndex(uint value) { }

	// RVA: 0x197F430 Offset: 0x197F531 VA: 0x197F430
	public float get_scale() { }

	// RVA: 0x197F440 Offset: 0x197F541 VA: 0x197F440
	public void set_scale(float value) { }

	// RVA: 0x197F450 Offset: 0x197F551 VA: 0x197F450
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_TextInfo // TypeDefIndex: 7458
{
	// Fields
	internal static Vector2 k_InfinityVectorPositive; // 0x0
	internal static Vector2 k_InfinityVectorNegative; // 0x8
	public TMP_Text textComponent; // 0x10
	public int characterCount; // 0x18
	public int spriteCount; // 0x1C
	public int spaceCount; // 0x20
	public int wordCount; // 0x24
	public int linkCount; // 0x28
	public int lineCount; // 0x2C
	public int pageCount; // 0x30
	public int materialCount; // 0x34
	public TMP_CharacterInfo[] characterInfo; // 0x38
	public TMP_WordInfo[] wordInfo; // 0x40
	public TMP_LinkInfo[] linkInfo; // 0x48
	public TMP_LineInfo[] lineInfo; // 0x50
	public TMP_PageInfo[] pageInfo; // 0x58
	public TMP_MeshInfo[] meshInfo; // 0x60
	private TMP_MeshInfo[] m_CachedMeshInfo; // 0x68

	// Methods

	// RVA: 0x197F470 Offset: 0x197F571 VA: 0x197F470
	public void .ctor() { }

	// RVA: 0x197F5E0 Offset: 0x197F6E1 VA: 0x197F5E0
	internal void .ctor(int characterCount) { }

	// RVA: 0x197F760 Offset: 0x197F861 VA: 0x197F760
	public void .ctor(TMP_Text textComponent) { }

	// RVA: 0x197F940 Offset: 0x197FA41 VA: 0x197F940
	public void Clear() { }

	// RVA: 0x197F9B0 Offset: 0x197FAB1 VA: 0x197F9B0
	internal void ClearAllData() { }

	// RVA: 0x197FB30 Offset: 0x197FC31 VA: 0x197FB30
	public void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x197FBB0 Offset: 0x197FCB1 VA: 0x197FBB0
	public void ClearAllMeshInfo() { }

	// RVA: 0x197FC30 Offset: 0x197FD31 VA: 0x197FC30
	public void ResetVertexLayout(bool isVolumetric) { }

	// RVA: 0x197FCC0 Offset: 0x197FDC1 VA: 0x197FCC0
	public void ClearUnusedVertices(MaterialReference[] materials) { }

	// RVA: 0x197FD40 Offset: 0x197FE41 VA: 0x197FD40
	public void ClearLineInfo() { }

	// RVA: 0x197FFA0 Offset: 0x19800A1 VA: 0x197FFA0
	internal void ClearPageInfo() { }

	// RVA: 0x19800F0 Offset: 0x19801F1 VA: 0x19800F0
	public TMP_MeshInfo[] CopyMeshInfoVertexData() { }

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2023E50 Offset: 0x2023F51 VA: 0x2023E50
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<TMP_SubMesh>
	|-TMP_TextInfo.Resize<TMP_SubMeshUI>
	|
	|-RVA: 0x2023EA0 Offset: 0x2023FA1 VA: 0x2023EA0
	|-TMP_TextInfo.Resize<TMP_LinkInfo>
	|
	|-RVA: 0x2023EF0 Offset: 0x2023FF1 VA: 0x2023EF0
	|-TMP_TextInfo.Resize<TMP_WordInfo>
	*/

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2023F40 Offset: 0x2024041 VA: 0x2023F40
	|-TMP_TextInfo.Resize<Material>
	|-TMP_TextInfo.Resize<object>
	|
	|-RVA: 0x2023FC0 Offset: 0x20240C1 VA: 0x2023FC0
	|-TMP_TextInfo.Resize<TMP_CharacterInfo>
	|
	|-RVA: 0x2024040 Offset: 0x2024141 VA: 0x2024040
	|-TMP_TextInfo.Resize<TMP_MeshInfo>
	|
	|-RVA: 0x20240C0 Offset: 0x20241C1 VA: 0x20240C0
	|-TMP_TextInfo.Resize<TMP_PageInfo>
	*/

	// RVA: 0x19804F0 Offset: 0x19805F1 VA: 0x19804F0
	private static void .cctor() { }
}

// Namespace: TMPro
public struct TMP_FontStyleStack // TypeDefIndex: 7460
{
	// Fields
	public byte bold; // 0x0
	public byte italic; // 0x1
	public byte underline; // 0x2
	public byte strikethrough; // 0x3
	public byte highlight; // 0x4
	public byte superscript; // 0x5
	public byte subscript; // 0x6
	public byte uppercase; // 0x7
	public byte lowercase; // 0x8
	public byte smallcaps; // 0x9

	// Methods

	// RVA: 0x1AABFB0 Offset: 0x1AAC0B1 VA: 0x1AABFB0
	public void Clear() { }

	// RVA: 0x1AABFC0 Offset: 0x1AAC0C1 VA: 0x1AABFC0
	public byte Add(FontStyles style) { }

	// RVA: 0x1AAC0E0 Offset: 0x1AAC1E1 VA: 0x1AAC0E0
	public byte Remove(FontStyles style) { }
}

// Namespace: TMPro
public class TMP_UpdateManager // TypeDefIndex: 7466
{
	// Fields
	private static TMP_UpdateManager s_Instance; // 0x0
	private readonly HashSet<int> m_LayoutQueueLookup; // 0x10
	private readonly List<TMP_Text> m_LayoutRebuildQueue; // 0x18
	private readonly HashSet<int> m_GraphicQueueLookup; // 0x20
	private readonly List<TMP_Text> m_GraphicRebuildQueue; // 0x28
	private readonly HashSet<int> m_InternalUpdateLookup; // 0x30
	private readonly List<TMP_Text> m_InternalUpdateQueue; // 0x38
	private readonly HashSet<int> m_CullingUpdateLookup; // 0x40
	private readonly List<TMP_Text> m_CullingUpdateQueue; // 0x48
	private static ProfilerMarker k_RegisterTextObjectForUpdateMarker; // 0x8
	private static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker; // 0x10
	private static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker; // 0x18
	private static ProfilerMarker k_UnregisterTextObjectForUpdateMarker; // 0x20
	private static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker; // 0x28

	// Properties
	private static TMP_UpdateManager instance { get; }

	// Methods

	// RVA: 0x1985600 Offset: 0x1985701 VA: 0x1985600
	private static TMP_UpdateManager get_instance() { }

	// RVA: 0x19856E0 Offset: 0x19857E1 VA: 0x19856E0
	private void .ctor() { }

	// RVA: 0x19858F0 Offset: 0x19859F1 VA: 0x19858F0
	internal static void RegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x1985960 Offset: 0x1985A61 VA: 0x1985960
	private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x1985A30 Offset: 0x1985B31 VA: 0x1985A30
	public static void RegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x1985AA0 Offset: 0x1985BA1 VA: 0x1985AA0
	private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x1985B70 Offset: 0x1985C71 VA: 0x1985B70
	public static void RegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x1985BE0 Offset: 0x1985CE1 VA: 0x1985BE0
	private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x1985CB0 Offset: 0x1985DB1 VA: 0x1985CB0
	public static void RegisterTextElementForCullingUpdate(TMP_Text element) { }

	// RVA: 0x1985D20 Offset: 0x1985E21 VA: 0x1985D20
	private void InternalRegisterTextElementForCullingUpdate(TMP_Text element) { }

	// RVA: 0x1985DF0 Offset: 0x1985EF1 VA: 0x1985DF0
	private void OnCameraPreCull() { }

	// RVA: 0x1985E00 Offset: 0x1985F01 VA: 0x1985E00
	private void DoRebuilds() { }

	// RVA: 0x1986080 Offset: 0x1986181 VA: 0x1986080
	internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x1986200 Offset: 0x1986301 VA: 0x1986200
	public static void UnRegisterTextElementForRebuild(TMP_Text element) { }

	// RVA: 0x19863B0 Offset: 0x19864B1 VA: 0x19863B0
	private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x1986450 Offset: 0x1986551 VA: 0x1986450
	private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x1986160 Offset: 0x1986261 VA: 0x1986160
	private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x19864F0 Offset: 0x19865F1 VA: 0x19864F0
	private static void .cctor() { }
}

// Namespace: TMPro
public static class TMP_Math // TypeDefIndex: 7472
{
	// Fields
	public const float FLOAT_MAX = 32767;
	public const float FLOAT_MIN = -32767;
	public const int INT_MAX = 2147483647;
	public const int INT_MIN = -2147483647;
	public const float FLOAT_UNSET = -32767;
	public const int INT_UNSET = -32767;
	public static Vector2 MAX_16BIT; // 0x0
	public static Vector2 MIN_16BIT; // 0x8

	// Methods

	// RVA: 0x18F1550 Offset: 0x18F1651 VA: 0x18F1550
	public static bool Approximately(float a, float b) { }

	// RVA: 0x18F1590 Offset: 0x18F1691 VA: 0x18F1590
	public static int Mod(int a, int b) { }

	// RVA: 0x18F15B0 Offset: 0x18F16B1 VA: 0x18F15B0
	private static void .cctor() { }
}

// Namespace: TMPro
public struct TMP_LinkInfo // TypeDefIndex: 7476
{
	// Fields
	public TMP_Text textComponent; // 0x0
	public int hashCode; // 0x8
	public int linkIdFirstCharacterIndex; // 0xC
	public int linkIdLength; // 0x10
	public int linkTextfirstCharacterIndex; // 0x14
	public int linkTextLength; // 0x18
	internal char[] linkID; // 0x20

	// Methods

	// RVA: 0x1ABB650 Offset: 0x1ABB751 VA: 0x1ABB650
	internal void SetLinkID(char[] text, int startIndex, int length) { }

	// RVA: 0x1ABB750 Offset: 0x1ABB851 VA: 0x1ABB750
	public string GetLinkText() { }

	// RVA: 0x1ABB830 Offset: 0x1ABB931 VA: 0x1ABB830
	public string GetLinkID() { }
}

// Namespace: TMPro
public struct TMP_SpriteInfo // TypeDefIndex: 7478
{
	// Fields
	public int spriteIndex; // 0x0
	public int characterIndex; // 0x4
	public int vertexIndex; // 0x8
}

