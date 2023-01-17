// Namespace: App
internal class AIValueStringManager // TypeDefIndex: 9467
{
	// Fields
	private static List<string> s_List; // 0x0
	private static HashSet<string> s_AIDataStrings; // 0x8
	private static bool s_IsLoadingAIData; // 0x10

	// Methods

	// RVA: 0x2B11A70 Offset: 0x2B11B71 VA: 0x2B11A70
	public static void BeginLoadAIData() { }

	// RVA: 0x2B11BA0 Offset: 0x2B11CA1 VA: 0x2B11BA0
	public static void EndLoadAIData() { }

	// RVA: 0x2B112F0 Offset: 0x2B113F1 VA: 0x2B112F0
	public static int Register(string str) { }

	// RVA: 0x2B11D30 Offset: 0x2B11E31 VA: 0x2B11D30
	public static void Reset() { }

	// RVA: 0x2B11AE0 Offset: 0x2B11BE1 VA: 0x2B11AE0
	public static void ClearAll() { }

	// RVA: 0x2B118D0 Offset: 0x2B119D1 VA: 0x2B118D0
	public static string GetString(int index) { }

	// RVA: 0x2B11E90 Offset: 0x2B11F91 VA: 0x2B11E90
	public static void Serialize(Stream stream) { }

	// RVA: 0x2B11FC0 Offset: 0x2B120C1 VA: 0x2B11FC0
	public static void Deserialize(Stream stream) { }

	// RVA: 0x2B11C10 Offset: 0x2B11D11 VA: 0x2B11C10
	private static int GetIndex(string str) { }

	[ConditionalAttribute] // RVA: 0x2B0870 Offset: 0x2B0971 VA: 0x2B0870
	// RVA: 0x2B12360 Offset: 0x2B12461 VA: 0x2B12360
	public static void Dump(string msg) { }

	// RVA: 0x2B12760 Offset: 0x2B12861 VA: 0x2B12760
	public void .ctor() { }

	// RVA: 0x2B12770 Offset: 0x2B12871 VA: 0x2B12770
	private static void .cctor() { }
}

