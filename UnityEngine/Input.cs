// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x77840 Offset: 0x77941 VA: 0x77840
public class Input // TypeDefIndex: 4042
{
	// Properties
	[NativeThrowsAttribute] // RVA: 0x77AA0 Offset: 0x77BA1 VA: 0x77AA0
	public static Vector3 mousePosition { get; }
	[NativeThrowsAttribute] // RVA: 0x77AB0 Offset: 0x77BB1 VA: 0x77AB0
	public static Vector2 mouseScrollDelta { get; }
	public static IMECompositionMode imeCompositionMode { get; set; }
	public static string compositionString { get; }
	public static Vector2 compositionCursorPos { get; set; }
	public static bool mousePresent { get; }
	public static int touchCount { get; }
	public static bool touchSupported { get; }
	public static Touch[] touches { get; }

	// Methods

	[NativeThrowsAttribute] // RVA: 0x77900 Offset: 0x77A01 VA: 0x77900
	// RVA: 0x1C61FA0 Offset: 0x1C620A1 VA: 0x1C61FA0
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x77910 Offset: 0x77A11 VA: 0x77910
	// RVA: 0x1C61FF0 Offset: 0x1C620F1 VA: 0x1C61FF0
	private static bool GetKeyUpInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x77920 Offset: 0x77A21 VA: 0x77920
	// RVA: 0x1C62040 Offset: 0x1C62141 VA: 0x1C62040
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrowsAttribute] // RVA: 0x77930 Offset: 0x77A31 VA: 0x77930
	// RVA: 0x1C62090 Offset: 0x1C62191 VA: 0x1C62090
	public static float GetAxis(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0x77940 Offset: 0x77A41 VA: 0x77940
	// RVA: 0x1C620E0 Offset: 0x1C621E1 VA: 0x1C620E0
	public static float GetAxisRaw(string axisName) { }

	[NativeThrowsAttribute] // RVA: 0x77950 Offset: 0x77A51 VA: 0x77950
	// RVA: 0x1C62130 Offset: 0x1C62231 VA: 0x1C62130
	public static bool GetButton(string buttonName) { }

	[NativeThrowsAttribute] // RVA: 0x77960 Offset: 0x77A61 VA: 0x77960
	// RVA: 0x1C62180 Offset: 0x1C62281 VA: 0x1C62180
	public static bool GetButtonDown(string buttonName) { }

	[NativeThrowsAttribute] // RVA: 0x77970 Offset: 0x77A71 VA: 0x77970
	// RVA: 0x1C621D0 Offset: 0x1C622D1 VA: 0x1C621D0
	public static bool GetButtonUp(string buttonName) { }

	[NativeThrowsAttribute] // RVA: 0x77980 Offset: 0x77A81 VA: 0x77980
	// RVA: 0x1C62220 Offset: 0x1C62321 VA: 0x1C62220
	public static bool GetMouseButton(int button) { }

	[NativeThrowsAttribute] // RVA: 0x77990 Offset: 0x77A91 VA: 0x77990
	// RVA: 0x1C62270 Offset: 0x1C62371 VA: 0x1C62270
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrowsAttribute] // RVA: 0x779A0 Offset: 0x77AA1 VA: 0x779A0
	// RVA: 0x1C622C0 Offset: 0x1C623C1 VA: 0x1C622C0
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrowsAttribute] // RVA: 0x779B0 Offset: 0x77AB1 VA: 0x779B0
	// RVA: 0x1C62310 Offset: 0x1C62411 VA: 0x1C62310
	public static Touch GetTouch(int index) { }

	// RVA: 0x1C62400 Offset: 0x1C62501 VA: 0x1C62400
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x1C62450 Offset: 0x1C62551 VA: 0x1C62450
	public static bool GetKeyUp(KeyCode key) { }

	// RVA: 0x1C624A0 Offset: 0x1C625A1 VA: 0x1C624A0
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x1C624F0 Offset: 0x1C625F1 VA: 0x1C624F0
	public static Vector3 get_mousePosition() { }

	// RVA: 0x1C625A0 Offset: 0x1C626A1 VA: 0x1C625A0
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x1C62640 Offset: 0x1C62741 VA: 0x1C62640
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x1C62680 Offset: 0x1C62781 VA: 0x1C62680
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x1C626D0 Offset: 0x1C627D1 VA: 0x1C626D0
	public static string get_compositionString() { }

	// RVA: 0x1C62710 Offset: 0x1C62811 VA: 0x1C62710
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x1C627B0 Offset: 0x1C628B1 VA: 0x1C627B0
	public static void set_compositionCursorPos(Vector2 value) { }

	[FreeFunctionAttribute] // RVA: 0x779C0 Offset: 0x77AC1 VA: 0x779C0
	// RVA: 0x1C62850 Offset: 0x1C62951 VA: 0x1C62850
	public static bool get_mousePresent() { }

	[FreeFunctionAttribute] // RVA: 0x77A00 Offset: 0x77B01 VA: 0x77A00
	// RVA: 0x1C62890 Offset: 0x1C62991 VA: 0x1C62890
	public static int get_touchCount() { }

	[FreeFunctionAttribute] // RVA: 0x77A40 Offset: 0x77B41 VA: 0x77A40
	// RVA: 0x1C628D0 Offset: 0x1C629D1 VA: 0x1C628D0
	public static bool get_touchSupported() { }

	// RVA: 0x1C62910 Offset: 0x1C62A11 VA: 0x1C62910
	public static Touch[] get_touches() { }

	// RVA: 0x1C623B0 Offset: 0x1C624B1 VA: 0x1C623B0
	private static void GetTouch_Injected(int index, out Touch ret) { }

	// RVA: 0x1C62550 Offset: 0x1C62651 VA: 0x1C62550
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0x1C625F0 Offset: 0x1C626F1 VA: 0x1C625F0
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	// RVA: 0x1C62760 Offset: 0x1C62861 VA: 0x1C62760
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0x1C62800 Offset: 0x1C62901 VA: 0x1C62800
	private static void set_compositionCursorPos_Injected(ref Vector2 value) { }
}

