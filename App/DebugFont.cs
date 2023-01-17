// Namespace: App
public class DebugFont // TypeDefIndex: 8913
{
	// Fields
	private static Font s_Font; // 0x0
	private static GUIStyle s_NormalStyle; // 0x8
	private static GUIStyle s_MiddleStyle; // 0x10
	private static GUIStyle s_SmallStyle; // 0x18
	private static GUIStyle s_CurrentStyle; // 0x20

	// Properties
	public static GUIStyle NormalStyle { get; }
	public static GUIStyle MiddleStyle { get; }
	public static GUIStyle SmallStyle { get; }
	public static GUIStyle CurrentStyle { get; set; }
	public static int FontSize { get; }
	public static int LineSize { get; }

	// Methods

	// RVA: 0x2E9CF00 Offset: 0x2E9D001 VA: 0x2E9CF00
	public static void Intialize() { }

	// RVA: 0x2E9D040 Offset: 0x2E9D141 VA: 0x2E9D040
	public static GUIStyle CreateStyle(int size) { }

	// RVA: 0x2E9D1B0 Offset: 0x2E9D2B1 VA: 0x2E9D1B0
	public static Font GetFont() { }

	// RVA: 0x2E9D220 Offset: 0x2E9D321 VA: 0x2E9D220
	public static GUIStyle get_NormalStyle() { }

	// RVA: 0x2E9D290 Offset: 0x2E9D391 VA: 0x2E9D290
	public static GUIStyle get_MiddleStyle() { }

	// RVA: 0x2E9D300 Offset: 0x2E9D401 VA: 0x2E9D300
	public static GUIStyle get_SmallStyle() { }

	// RVA: 0x2E9D370 Offset: 0x2E9D471 VA: 0x2E9D370
	public static GUIStyle get_CurrentStyle() { }

	// RVA: 0x2E9D3E0 Offset: 0x2E9D4E1 VA: 0x2E9D3E0
	public static void set_CurrentStyle(GUIStyle value) { }

	// RVA: 0x2E9BFB0 Offset: 0x2E9C0B1 VA: 0x2E9BFB0
	public static int get_FontSize() { }

	// RVA: 0x2E9C020 Offset: 0x2E9C121 VA: 0x2E9C020
	public static int get_LineSize() { }

	// RVA: 0x2E9D460 Offset: 0x2E9D561 VA: 0x2E9D460
	public void .ctor() { }

	// RVA: 0x2E9D470 Offset: 0x2E9D571 VA: 0x2E9D470
	private static void .cctor() { }
}

