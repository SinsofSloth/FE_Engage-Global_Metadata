// Namespace: UnityEngine
public class GUILayout // TypeDefIndex: 4156
{
	// Methods

	// RVA: 0x3C7A110 Offset: 0x3C7A211 VA: 0x3C7A110
	public static void Label(string text, GUILayoutOption[] options) { }

	// RVA: 0x3C7A3B0 Offset: 0x3C7A4B1 VA: 0x3C7A3B0
	public static void Label(string text, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x3C7A230 Offset: 0x3C7A331 VA: 0x3C7A230
	private static void DoLabel(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x3C7A4C0 Offset: 0x3C7A5C1 VA: 0x3C7A4C0
	public static float HorizontalSlider(float value, float leftValue, float rightValue, GUILayoutOption[] options) { }

	// RVA: 0x3C7A620 Offset: 0x3C7A721 VA: 0x3C7A620
	private static float DoHorizontalSlider(float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUILayoutOption[] options) { }

	// RVA: 0x3C7A820 Offset: 0x3C7A921 VA: 0x3C7A820
	public static void BeginHorizontal(GUILayoutOption[] options) { }

	// RVA: 0x3C7A8D0 Offset: 0x3C7A9D1 VA: 0x3C7A8D0
	public static void BeginHorizontal(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x3C7ADC0 Offset: 0x3C7AEC1 VA: 0x3C7ADC0
	public static void EndHorizontal() { }

	// RVA: 0x3C7B040 Offset: 0x3C7B141 VA: 0x3C7B040
	public static void BeginArea(Rect screenRect) { }

	// RVA: 0x3C7B110 Offset: 0x3C7B211 VA: 0x3C7B110
	public static void BeginArea(Rect screenRect, GUIContent content, GUIStyle style) { }

	// RVA: 0x3C7B6B0 Offset: 0x3C7B7B1 VA: 0x3C7B6B0
	public static void EndArea() { }

	// RVA: 0x3C7B8A0 Offset: 0x3C7B9A1 VA: 0x3C7B8A0
	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUILayoutOption[] options) { }

	// RVA: 0x3C7BA70 Offset: 0x3C7BB71 VA: 0x3C7BA70
	public static Vector2 BeginScrollView(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background, GUILayoutOption[] options) { }

	// RVA: 0x3C7BD20 Offset: 0x3C7BE21 VA: 0x3C7BD20
	internal static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x3C7BDD0 Offset: 0x3C7BED1 VA: 0x3C7BDD0
	public static Rect Window(int id, Rect screenRect, GUI.WindowFunction func, string text, GUILayoutOption[] options) { }

	// RVA: 0x3C7BF30 Offset: 0x3C7C031 VA: 0x3C7BF30
	private static Rect DoWindow(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x3C79310 Offset: 0x3C79411 VA: 0x3C79310
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x3C793C0 Offset: 0x3C794C1 VA: 0x3C793C0
	public static GUILayoutOption Height(float height) { }
}

