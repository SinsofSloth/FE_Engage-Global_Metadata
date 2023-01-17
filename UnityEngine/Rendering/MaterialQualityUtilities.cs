// Namespace: UnityEngine.Rendering
[MovedFromAttribute] // RVA: 0x3B9F0 Offset: 0x3BAF1 VA: 0x3B9F0
[ExtensionAttribute] // RVA: 0x3B9F0 Offset: 0x3BAF1 VA: 0x3B9F0
public static class MaterialQualityUtilities // TypeDefIndex: 4633
{
	// Fields
	public static string[] KeywordNames; // 0x0
	public static string[] EnumNames; // 0x8
	public static ShaderKeyword[] Keywords; // 0x10

	// Methods

	[ExtensionAttribute] // RVA: 0x3DB50 Offset: 0x3DC51 VA: 0x3DB50
	// RVA: 0x1A11280 Offset: 0x1A11381 VA: 0x1A11280
	public static MaterialQuality GetHighestQuality(MaterialQuality levels) { }

	[ExtensionAttribute] // RVA: 0x3DB60 Offset: 0x3DC61 VA: 0x3DB60
	// RVA: 0x1A11330 Offset: 0x1A11431 VA: 0x1A11330
	public static MaterialQuality GetClosestQuality(MaterialQuality availableLevels, MaterialQuality requestedLevel) { }

	[ExtensionAttribute] // RVA: 0x3DB70 Offset: 0x3DC71 VA: 0x3DB70
	// RVA: 0x1A115E0 Offset: 0x1A116E1 VA: 0x1A115E0
	public static void SetGlobalShaderKeywords(MaterialQuality level) { }

	[ExtensionAttribute] // RVA: 0x3DB80 Offset: 0x3DC81 VA: 0x3DB80
	// RVA: 0x1A11700 Offset: 0x1A11801 VA: 0x1A11700
	public static void SetGlobalShaderKeywords(MaterialQuality level, CommandBuffer cmd) { }

	[ExtensionAttribute] // RVA: 0x3DB90 Offset: 0x3DC91 VA: 0x3DB90
	// RVA: 0x1A11520 Offset: 0x1A11621 VA: 0x1A11520
	public static int ToFirstIndex(MaterialQuality level) { }

	// RVA: 0x1A115D0 Offset: 0x1A116D1 VA: 0x1A115D0
	public static MaterialQuality FromIndex(int index) { }

	// RVA: 0x1A11830 Offset: 0x1A11931 VA: 0x1A11830
	private static void .cctor() { }
}

