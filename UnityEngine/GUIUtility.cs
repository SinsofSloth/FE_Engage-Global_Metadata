// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x52C60 Offset: 0x52D61 VA: 0x52C60
[NativeHeaderAttribute] // RVA: 0x52C60 Offset: 0x52D61 VA: 0x52C60
[NativeHeaderAttribute] // RVA: 0x52C60 Offset: 0x52D61 VA: 0x52C60
[NativeHeaderAttribute] // RVA: 0x52C60 Offset: 0x52D61 VA: 0x52C60
[NativeHeaderAttribute] // RVA: 0x52C60 Offset: 0x52D61 VA: 0x52C60
[NativeHeaderAttribute] // RVA: 0x52C60 Offset: 0x52D61 VA: 0x52C60
public class GUIUtility // TypeDefIndex: 4170
{
	// Fields
	internal static int s_SkinMode; // 0x0
	internal static int s_OriginalID; // 0x4
	internal static Action takeCapture; // 0x8
	internal static Action releaseCapture; // 0x10
	internal static Func<int, IntPtr, bool> processEvent; // 0x18
	internal static Func<Exception, bool> endContainerGUIFromException; // 0x20
	internal static Action guiChanged; // 0x28
	[DebuggerBrowsableAttribute] // RVA: 0x53690 Offset: 0x53791 VA: 0x53690
	[CompilerGeneratedAttribute] // RVA: 0x53690 Offset: 0x53791 VA: 0x53690
	private static bool <guiIsExiting>k__BackingField; // 0x30
	internal static Func<bool> s_HasCurrentWindowKeyFocusFunc; // 0x38

	// Properties
	[NativePropertyAttribute] // RVA: 0x54830 Offset: 0x54931 VA: 0x54830
	internal static float pixelsPerPoint { get; }
	[NativePropertyAttribute] // RVA: 0x54870 Offset: 0x54971 VA: 0x54870
	internal static int guiDepth { get; }
	[NativePropertyAttribute] // RVA: 0x548B0 Offset: 0x549B1 VA: 0x548B0
	internal static bool mouseUsed { set; }
	public static string systemCopyBuffer { get; set; }
	internal static bool guiIsExiting { get; set; }
	public static int hotControl { get; set; }
	public static int keyboardControl { get; }

	// Methods

	// RVA: 0x3C80650 Offset: 0x3C80751 VA: 0x3C80650
	internal static float get_pixelsPerPoint() { }

	// RVA: 0x3C87130 Offset: 0x3C87231 VA: 0x3C87130
	internal static int get_guiDepth() { }

	// RVA: 0x3C75FA0 Offset: 0x3C760A1 VA: 0x3C75FA0
	internal static void set_mouseUsed(bool value) { }

	[FreeFunctionAttribute] // RVA: 0x54020 Offset: 0x54121 VA: 0x54020
	// RVA: 0x3C87170 Offset: 0x3C87271 VA: 0x3C87170
	public static string get_systemCopyBuffer() { }

	[FreeFunctionAttribute] // RVA: 0x54060 Offset: 0x54161 VA: 0x54060
	// RVA: 0x3C871B0 Offset: 0x3C872B1 VA: 0x3C871B0
	public static void set_systemCopyBuffer(string value) { }

	[StaticAccessorAttribute] // RVA: 0x540A0 Offset: 0x541A1 VA: 0x540A0
	// RVA: 0x3C72F40 Offset: 0x3C73041 VA: 0x3C72F40
	public static int GetControlID(int hint, FocusType focusType, Rect rect) { }

	// RVA: 0x3C87260 Offset: 0x3C87361 VA: 0x3C87260
	private static int Internal_GetHotControl() { }

	// RVA: 0x3C872A0 Offset: 0x3C873A1 VA: 0x3C872A0
	private static int Internal_GetKeyboardControl() { }

	// RVA: 0x3C872E0 Offset: 0x3C873E1 VA: 0x3C872E0
	private static void Internal_SetHotControl(int value) { }

	// RVA: 0x3C87330 Offset: 0x3C87431 VA: 0x3C87330
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x3C87380 Offset: 0x3C87481 VA: 0x3C87380
	private static void Internal_ExitGUI() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x540E0 Offset: 0x541E1 VA: 0x540E0
	// RVA: 0x3C873C0 Offset: 0x3C874C1 VA: 0x3C873C0
	private static void MarkGUIChanged() { }

	// RVA: 0x3C72AB0 Offset: 0x3C72BB1 VA: 0x3C72AB0
	public static int GetControlID(int hint, FocusType focus) { }

	// RVA: 0x3C777E0 Offset: 0x3C778E1 VA: 0x3C777E0
	public static object GetStateObject(Type t, int controlID) { }

	[CompilerGeneratedAttribute] // RVA: 0x540F0 Offset: 0x541F1 VA: 0x540F0
	// RVA: 0x3C87420 Offset: 0x3C87521 VA: 0x3C87420
	internal static bool get_guiIsExiting() { }

	[CompilerGeneratedAttribute] // RVA: 0x54100 Offset: 0x54201 VA: 0x54100
	// RVA: 0x3C87470 Offset: 0x3C87571 VA: 0x3C87470
	internal static void set_guiIsExiting(bool value) { }

	// RVA: 0x3C73670 Offset: 0x3C73771 VA: 0x3C73670
	public static int get_hotControl() { }

	// RVA: 0x3C73620 Offset: 0x3C73721 VA: 0x3C73620
	public static void set_hotControl(int value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x54110 Offset: 0x54211 VA: 0x54110
	// RVA: 0x3C874D0 Offset: 0x3C875D1 VA: 0x3C874D0
	internal static void TakeCapture() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x54120 Offset: 0x54221 VA: 0x54120
	// RVA: 0x3C87530 Offset: 0x3C87631 VA: 0x3C87530
	internal static void RemoveCapture() { }

	// RVA: 0x3C73CD0 Offset: 0x3C73DD1 VA: 0x3C73CD0
	public static int get_keyboardControl() { }

	// RVA: 0x3C86A00 Offset: 0x3C86B01 VA: 0x3C86A00
	internal static bool HasKeyFocus(int controlID) { }

	// RVA: 0x3C70C90 Offset: 0x3C70D91 VA: 0x3C70C90
	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x54130 Offset: 0x54231 VA: 0x54130
	// RVA: 0x3C87590 Offset: 0x3C87691 VA: 0x3C87590
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x54140 Offset: 0x54241 VA: 0x54140
	// RVA: 0x3C87630 Offset: 0x3C87731 VA: 0x3C87630
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x54150 Offset: 0x54251 VA: 0x54150
	// RVA: 0x3C87860 Offset: 0x3C87961 VA: 0x3C87860
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x54160 Offset: 0x54261 VA: 0x54160
	// RVA: 0x3C87A70 Offset: 0x3C87B71 VA: 0x3C87A70
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x54170 Offset: 0x54271 VA: 0x54170
	// RVA: 0x3C87BE0 Offset: 0x3C87CE1 VA: 0x3C87BE0
	internal static bool EndContainerGUIFromException(Exception exception) { }

	// RVA: 0x3C876F0 Offset: 0x3C877F1 VA: 0x3C876F0
	internal static void ResetGlobalState() { }

	// RVA: 0x3C87C70 Offset: 0x3C87D71 VA: 0x3C87C70
	internal static bool IsExitGUIException(Exception exception) { }

	// RVA: 0x3C87B40 Offset: 0x3C87C41 VA: 0x3C87B40
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x3C70A30 Offset: 0x3C70B31 VA: 0x3C70A30
	internal static void CheckOnGUI() { }

	// RVA: 0x3C87D00 Offset: 0x3C87E01 VA: 0x3C87D00
	internal static bool HitTest(Rect rect, Vector2 point, int offset) { }

	// RVA: 0x3C87DB0 Offset: 0x3C87EB1 VA: 0x3C87DB0
	internal static bool HitTest(Rect rect, Vector2 point, bool isDirectManipulationDevice) { }

	// RVA: 0x3C73B70 Offset: 0x3C73C71 VA: 0x3C73B70
	internal static bool HitTest(Rect rect, Event evt) { }

	// RVA: 0x3C87200 Offset: 0x3C87301 VA: 0x3C87200
	private static int GetControlID_Injected(int hint, FocusType focusType, ref Rect rect) { }
}

