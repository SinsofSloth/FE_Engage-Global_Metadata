// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x52A30 Offset: 0x52B31 VA: 0x52A30
public class GUILayoutUtility // TypeDefIndex: 4160
{
	// Fields
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts; // 0x0
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows; // 0x8
	internal static GUILayoutUtility.LayoutCache current; // 0x10
	internal static readonly Rect kDummyRect; // 0x18

	// Methods

	// RVA: 0x3C80220 Offset: 0x3C80321 VA: 0x3C80220
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x3C80330 Offset: 0x3C80431 VA: 0x3C80330
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	// RVA: 0x3C79170 Offset: 0x3C79271 VA: 0x3C79170
	internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x3C80430 Offset: 0x3C80531 VA: 0x3C80430
	internal static void Begin(int instanceID) { }

	// RVA: 0x3C79480 Offset: 0x3C79581 VA: 0x3C79480
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x3C79750 Offset: 0x3C79851 VA: 0x3C79750
	internal static void Layout() { }

	// RVA: 0x3C80B20 Offset: 0x3C80C21 VA: 0x3C80B20
	internal static void LayoutFromEditorWindow() { }

	// RVA: 0x3C80690 Offset: 0x3C80791 VA: 0x3C80690
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x3C80820 Offset: 0x3C80921 VA: 0x3C80820
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x3C80D10 Offset: 0x3C80E11 VA: 0x3C80D10
	private static GUILayoutGroup CreateGUILayoutGroupInstanceOfType(Type LayoutType) { }

	// RVA: 0x3C7AAC0 Offset: 0x3C7ABC1 VA: 0x3C7AAC0
	internal static GUILayoutGroup BeginLayoutGroup(GUIStyle style, GUILayoutOption[] options, Type layoutType) { }

	// RVA: 0x3C7AE30 Offset: 0x3C7AF31 VA: 0x3C7AE30
	internal static void EndLayoutGroup() { }

	// RVA: 0x3C7B3E0 Offset: 0x3C7B4E1 VA: 0x3C7B3E0
	internal static GUILayoutGroup BeginLayoutArea(GUIStyle style, Type layoutType) { }

	// RVA: 0x3C7A440 Offset: 0x3C7A541 VA: 0x3C7A440
	public static Rect GetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x3C80E60 Offset: 0x3C80F61 VA: 0x3C80E60
	private static Rect DoGetRect(GUIContent content, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x3C81550 Offset: 0x3C81651 VA: 0x3C81550
	private static void .cctor() { }

	// RVA: 0x3C802E0 Offset: 0x3C803E1 VA: 0x3C802E0
	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	// RVA: 0x3C803E0 Offset: 0x3C804E1 VA: 0x3C803E0
	private static void Internal_MoveWindow_Injected(int windowID, ref Rect r) { }
}

