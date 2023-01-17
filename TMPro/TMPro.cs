// Namespace: TMPro
public static class TMPro_EventManager // TypeDefIndex: 7469
{
	// Fields
	public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT; // 0x0
	public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT; // 0x8
	public static readonly FastAction<bool, Object> FONT_PROPERTY_EVENT; // 0x10
	public static readonly FastAction<bool, Object> SPRITE_ASSET_PROPERTY_EVENT; // 0x18
	public static readonly FastAction<bool, Object> TEXTMESHPRO_PROPERTY_EVENT; // 0x20
	public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; // 0x28
	public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT; // 0x30
	public static readonly FastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT; // 0x38
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; // 0x40
	public static readonly FastAction RESOURCE_LOAD_EVENT; // 0x48
	public static readonly FastAction<bool, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT; // 0x50
	public static readonly FastAction<Object> TEXT_CHANGED_EVENT; // 0x58

	// Methods

	// RVA: 0x1987510 Offset: 0x1987611 VA: 0x1987510
	public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) { }

	// RVA: 0x19875B0 Offset: 0x19876B1 VA: 0x19875B0
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x1987650 Offset: 0x1987751 VA: 0x1987650
	public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x19876F0 Offset: 0x19877F1 VA: 0x19876F0
	public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x1987790 Offset: 0x1987891 VA: 0x1987790
	public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) { }

	// RVA: 0x1987840 Offset: 0x1987941 VA: 0x1987840
	public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) { }

	// RVA: 0x19878D0 Offset: 0x19879D1 VA: 0x19878D0
	public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(Object obj) { }

	// RVA: 0x1987960 Offset: 0x1987A61 VA: 0x1987960
	public static void ON_TEXT_CHANGED(Object obj) { }

	// RVA: 0x19879F0 Offset: 0x1987AF1 VA: 0x19879F0
	public static void ON_TMP_SETTINGS_CHANGED() { }

	// RVA: 0x1987A60 Offset: 0x1987B61 VA: 0x1987A60
	public static void ON_RESOURCES_LOADED() { }

	// RVA: 0x1987AD0 Offset: 0x1987BD1 VA: 0x1987AD0
	public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x1987B70 Offset: 0x1987C71 VA: 0x1987B70
	public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) { }

	// RVA: 0x1987C10 Offset: 0x1987D11 VA: 0x1987C10
	private static void .cctor() { }
}

// Namespace: TMPro
[ExtensionAttribute] // RVA: 0x4D0C0 Offset: 0x4D1C1 VA: 0x4D0C0
public static class TMPro_ExtensionMethods // TypeDefIndex: 7471
{
	// Methods

	[ExtensionAttribute] // RVA: 0x4E9E0 Offset: 0x4EAE1 VA: 0x4E9E0
	// RVA: 0x1987F50 Offset: 0x1988051 VA: 0x1987F50
	public static int[] ToIntArray(string text) { }

	[ExtensionAttribute] // RVA: 0x4E9F0 Offset: 0x4EAF1 VA: 0x4E9F0
	// RVA: 0x1988010 Offset: 0x1988111 VA: 0x1988010
	public static string ArrayToString(char[] chars) { }

	[ExtensionAttribute] // RVA: 0x4EA00 Offset: 0x4EB01 VA: 0x4EA00
	// RVA: 0x19880D0 Offset: 0x19881D1 VA: 0x19880D0
	public static string IntToString(int[] unicodes) { }

	[ExtensionAttribute] // RVA: 0x4EA10 Offset: 0x4EB11 VA: 0x4EA10
	// RVA: 0x1988190 Offset: 0x1988291 VA: 0x1988190
	internal static string UintToString(List<uint> unicodes) { }

	[ExtensionAttribute] // RVA: 0x4EA20 Offset: 0x4EB21 VA: 0x4EA20
	// RVA: 0x1988270 Offset: 0x1988371 VA: 0x1988270
	public static string IntToString(int[] unicodes, int start, int length) { }

	[ExtensionAttribute] // RVA: 0x4EA30 Offset: 0x4EB31 VA: 0x4EA30
	// RVA: -1 Offset: -1
	public static int FindInstanceID<T>(List<T> list, T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2024140 Offset: 0x2024241 VA: 0x2024140
	|-TMPro_ExtensionMethods.FindInstanceID<object>
	*/

	[ExtensionAttribute] // RVA: 0x4EA40 Offset: 0x4EB41 VA: 0x4EA40
	// RVA: 0x1988390 Offset: 0x1988491 VA: 0x1988390
	public static bool Compare(Color32 a, Color32 b) { }

	[ExtensionAttribute] // RVA: 0x4EA50 Offset: 0x4EB51 VA: 0x4EA50
	// RVA: 0x19883D0 Offset: 0x19884D1 VA: 0x19883D0
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[ExtensionAttribute] // RVA: 0x4EA60 Offset: 0x4EB61 VA: 0x4EA60
	// RVA: 0x1988400 Offset: 0x1988501 VA: 0x1988400
	public static bool Compare(Color a, Color b) { }

	[ExtensionAttribute] // RVA: 0x4EA70 Offset: 0x4EB71 VA: 0x4EA70
	// RVA: 0x1988430 Offset: 0x1988531 VA: 0x1988430
	public static bool CompareRGB(Color a, Color b) { }

	[ExtensionAttribute] // RVA: 0x4EA80 Offset: 0x4EB81 VA: 0x4EA80
	// RVA: 0x1988450 Offset: 0x1988551 VA: 0x1988450
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] // RVA: 0x4EA90 Offset: 0x4EB91 VA: 0x4EA90
	// RVA: 0x1988520 Offset: 0x1988621 VA: 0x1988520
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[ExtensionAttribute] // RVA: 0x4EAA0 Offset: 0x4EBA1 VA: 0x4EAA0
	// RVA: 0x19885F0 Offset: 0x19886F1 VA: 0x19885F0
	public static Color32 Tint(Color32 c1, float tint) { }

	[ExtensionAttribute] // RVA: 0x4EAB0 Offset: 0x4EBB1 VA: 0x4EAB0
	// RVA: 0x1988720 Offset: 0x1988821 VA: 0x1988720
	public static Color MinAlpha(Color c1, Color c2) { }

	[ExtensionAttribute] // RVA: 0x4EAC0 Offset: 0x4EBC1 VA: 0x4EAC0
	// RVA: 0x1988760 Offset: 0x1988861 VA: 0x1988760
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[ExtensionAttribute] // RVA: 0x4EAD0 Offset: 0x4EBD1 VA: 0x4EAD0
	// RVA: 0x1988820 Offset: 0x1988921 VA: 0x1988820
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }
}

