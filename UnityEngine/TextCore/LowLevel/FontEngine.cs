// Namespace: UnityEngine.TextCore.LowLevel
[NativeHeaderAttribute] // RVA: 0x61330 Offset: 0x61431 VA: 0x61330
public sealed class FontEngine // TypeDefIndex: 5718
{
	// Fields
	private static Glyph[] s_Glyphs; // 0x0
	private static uint[] s_GlyphIndexes_MarshallingArray_A; // 0x8
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; // 0x10
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; // 0x18
	private static GlyphRect[] s_FreeGlyphRects; // 0x20
	private static GlyphRect[] s_UsedGlyphRects; // 0x28
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; // 0x30
	private static Dictionary<uint, Glyph> s_GlyphLookupDictionary; // 0x38

	// Methods

	// RVA: 0x1C585A0 Offset: 0x1C586A1 VA: 0x1C585A0
	public static FontEngineError InitializeFontEngine() { }

	[NativeMethodAttribute] // RVA: 0x620B0 Offset: 0x621B1 VA: 0x620B0
	// RVA: 0x1C58630 Offset: 0x1C58731 VA: 0x1C58630
	private static int InitializeFontEngine_Internal() { }

	// RVA: 0x1C58670 Offset: 0x1C58771 VA: 0x1C58670
	public static FontEngineError LoadFontFace(Font font, int pointSize) { }

	[NativeMethodAttribute] // RVA: 0x62100 Offset: 0x62201 VA: 0x62100
	// RVA: 0x1C58710 Offset: 0x1C58811 VA: 0x1C58710
	private static int LoadFontFace_With_Size_FromFont_Internal(Font font, int pointSize) { }

	// RVA: 0x1C58760 Offset: 0x1C58861 VA: 0x1C58760
	public static FaceInfo GetFaceInfo() { }

	[NativeMethodAttribute] // RVA: 0x62150 Offset: 0x62251 VA: 0x62150
	// RVA: 0x1C58850 Offset: 0x1C58951 VA: 0x1C58850
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	[NativeMethodAttribute] // RVA: 0x621A0 Offset: 0x622A1 VA: 0x621A0
	// RVA: 0x1C588A0 Offset: 0x1C589A1 VA: 0x1C588A0
	internal static uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x1C588F0 Offset: 0x1C589F1 VA: 0x1C588F0
	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x621F0 Offset: 0x622F1 VA: 0x621F0
	// RVA: 0x1C58A60 Offset: 0x1C58B61 VA: 0x1C58A60
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x1C58B40 Offset: 0x1C58C41 VA: 0x1C58B40
	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x62240 Offset: 0x62341 VA: 0x62240
	// RVA: 0x1C58CB0 Offset: 0x1C58DB1 VA: 0x1C58CB0
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x1C58D10 Offset: 0x1C58E11 VA: 0x1C58D10
	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	[NativeMethodAttribute] // RVA: 0x62290 Offset: 0x62391 VA: 0x62290
	// RVA: 0x1C591D0 Offset: 0x1C592D1 VA: 0x1C591D0
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	// RVA: 0x1C59280 Offset: 0x1C59381 VA: 0x1C59280
	internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	[NativeMethodAttribute] // RVA: 0x622E0 Offset: 0x623E1 VA: 0x622E0
	// RVA: 0x1C59C60 Offset: 0x1C59D61 VA: 0x1C59C60
	private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	// RVA: 0x1C59D20 Offset: 0x1C59E21 VA: 0x1C59D20
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes) { }

	// RVA: 0x1C59F50 Offset: 0x1C5A051 VA: 0x1C59F50
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentRecords(List<uint> glyphIndexes, out int recordCount) { }

	[NativeMethodAttribute] // RVA: 0x62330 Offset: 0x62431 VA: 0x62330
	// RVA: 0x1C59EB0 Offset: 0x1C59FB1 VA: 0x1C59EB0
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_GlyphIndexes(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethodAttribute] // RVA: 0x62380 Offset: 0x62481 VA: 0x62380
	// RVA: 0x1C59F00 Offset: 0x1C5A001 VA: 0x1C59F00
	private static int GetGlyphPairAdjustmentRecordsFromMarshallingArray([Out] GlyphPairAdjustmentRecord[] glyphPairAdjustmentRecords) { }

	// RVA: -1 Offset: -1
	private static void GenericListToMarshallingArray<T>(ref List<T> srcList, ref T[] dstArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B4A20 Offset: 0x22B4B21 VA: 0x22B4A20
	|-FontEngine.GenericListToMarshallingArray<object>
	|
	|-RVA: 0x22B4B80 Offset: 0x22B4C81 VA: 0x22B4B80
	|-FontEngine.GenericListToMarshallingArray<uint>
	*/

	// RVA: -1 Offset: -1
	private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B4CD0 Offset: 0x22B4DD1 VA: 0x22B4CD0
	|-FontEngine.SetMarshallingArraySize<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x22B4D90 Offset: 0x22B4E91 VA: 0x22B4D90
	|-FontEngine.SetMarshallingArraySize<object>
	*/

	[NativeMethodAttribute] // RVA: 0x623D0 Offset: 0x624D1 VA: 0x623D0
	// RVA: 0x1C5A100 Offset: 0x1C5A201 VA: 0x1C5A100
	internal static void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x1C5A150 Offset: 0x1C5A251 VA: 0x1C5A150
	private static void .cctor() { }
}

