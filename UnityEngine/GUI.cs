// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x52910 Offset: 0x52A11 VA: 0x52910
[NativeHeaderAttribute] // RVA: 0x52910 Offset: 0x52A11 VA: 0x52910
public class GUI // TypeDefIndex: 4147
{
	// Fields
	private static int s_ScrollControlId; // 0x0
	private static int s_HotTextField; // 0x4
	private static readonly int s_BoxHash; // 0x8
	private static readonly int s_ButonHash; // 0xC
	private static readonly int s_RepeatButtonHash; // 0x10
	private static readonly int s_ToggleHash; // 0x14
	private static readonly int s_ButtonGridHash; // 0x18
	private static readonly int s_SliderHash; // 0x1C
	private static readonly int s_BeginGroupHash; // 0x20
	private static readonly int s_ScrollviewHash; // 0x24
	[DebuggerBrowsableAttribute] // RVA: 0x532E0 Offset: 0x533E1 VA: 0x532E0
	[CompilerGeneratedAttribute] // RVA: 0x532E0 Offset: 0x533E1 VA: 0x532E0
	private static int <scrollTroughSide>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x53320 Offset: 0x53421 VA: 0x53320
	[DebuggerBrowsableAttribute] // RVA: 0x53320 Offset: 0x53421 VA: 0x53320
	private static DateTime <nextScrollStepTime>k__BackingField; // 0x30
	private static GUISkin s_Skin; // 0x38
	internal static Rect s_ToolTipRect; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x53360 Offset: 0x53461 VA: 0x53360
	[DebuggerBrowsableAttribute] // RVA: 0x53360 Offset: 0x53461 VA: 0x53360
	private static GenericStack <scrollViewStates>k__BackingField; // 0x50

	// Properties
	public static Color color { get; set; }
	public static Color backgroundColor { set; }
	public static bool changed { set; }
	public static int depth { set; }
	internal static bool usePageScrollbars { get; }
	internal static Material blendMaterial { get; }
	internal static Material blitMaterial { get; }
	internal static Material roundedRectMaterial { get; }
	internal static Material roundedRectWithColorPerBorderMaterial { get; }
	internal static int scrollTroughSide { get; set; }
	internal static DateTime nextScrollStepTime { get; set; }
	public static GUISkin skin { get; set; }
	public static Matrix4x4 matrix { set; }
	internal static GenericStack scrollViewStates { get; }

	// Methods

	// RVA: 0x3C6FDB0 Offset: 0x3C6FEB1 VA: 0x3C6FDB0
	public static Color get_color() { }

	// RVA: 0x3C6FEB0 Offset: 0x3C6FFB1 VA: 0x3C6FEB0
	public static void set_color(Color value) { }

	// RVA: 0x3C6FFA0 Offset: 0x3C700A1 VA: 0x3C6FFA0
	public static void set_backgroundColor(Color value) { }

	// RVA: 0x3C70090 Offset: 0x3C70191 VA: 0x3C70090
	public static void set_changed(bool value) { }

	// RVA: 0x3C700E0 Offset: 0x3C701E1 VA: 0x3C700E0
	public static void set_depth(int value) { }

	// RVA: 0x3C70130 Offset: 0x3C70231 VA: 0x3C70130
	internal static bool get_usePageScrollbars() { }

	[FreeFunctionAttribute] // RVA: 0x538B0 Offset: 0x539B1 VA: 0x538B0
	// RVA: 0x3C70170 Offset: 0x3C70271 VA: 0x3C70170
	internal static Material get_blendMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x538F0 Offset: 0x539F1 VA: 0x538F0
	// RVA: 0x3C701B0 Offset: 0x3C702B1 VA: 0x3C701B0
	internal static Material get_blitMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x53930 Offset: 0x53A31 VA: 0x53930
	// RVA: 0x3C701F0 Offset: 0x3C702F1 VA: 0x3C701F0
	internal static Material get_roundedRectMaterial() { }

	[FreeFunctionAttribute] // RVA: 0x53970 Offset: 0x53A71 VA: 0x53970
	// RVA: 0x3C70230 Offset: 0x3C70331 VA: 0x3C70230
	internal static Material get_roundedRectWithColorPerBorderMaterial() { }

	// RVA: 0x3C70270 Offset: 0x3C70371 VA: 0x3C70270
	internal static void GrabMouseControl(int id) { }

	// RVA: 0x3C702C0 Offset: 0x3C703C1 VA: 0x3C702C0
	internal static bool HasMouseControl(int id) { }

	// RVA: 0x3C70310 Offset: 0x3C70411 VA: 0x3C70310
	internal static void ReleaseMouseControl() { }

	// RVA: 0x3C70350 Offset: 0x3C70451 VA: 0x3C70350
	internal static void InternalRepaintEditorWindow() { }

	// RVA: 0x3C70390 Offset: 0x3C70491 VA: 0x3C70390
	private static Rect Internal_DoWindow(int id, int instanceID, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout) { }

	// RVA: 0x3C70540 Offset: 0x3C70641 VA: 0x3C70540
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x539B0 Offset: 0x53AB1 VA: 0x539B0
	// RVA: 0x3C70800 Offset: 0x3C70901 VA: 0x3C70800
	internal static int get_scrollTroughSide() { }

	[CompilerGeneratedAttribute] // RVA: 0x539C0 Offset: 0x53AC1 VA: 0x539C0
	// RVA: 0x3C70870 Offset: 0x3C70971 VA: 0x3C70870
	internal static void set_scrollTroughSide(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x539D0 Offset: 0x53AD1 VA: 0x539D0
	// RVA: 0x3C708E0 Offset: 0x3C709E1 VA: 0x3C708E0
	internal static DateTime get_nextScrollStepTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x539E0 Offset: 0x53AE1 VA: 0x539E0
	// RVA: 0x3C70950 Offset: 0x3C70A51 VA: 0x3C70950
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x3C709C0 Offset: 0x3C70AC1 VA: 0x3C709C0
	public static void set_skin(GUISkin value) { }

	// RVA: 0x3C70C20 Offset: 0x3C70D21 VA: 0x3C70C20
	public static GUISkin get_skin() { }

	// RVA: 0x3C70AC0 Offset: 0x3C70BC1 VA: 0x3C70AC0
	internal static void DoSetSkin(GUISkin newSkin) { }

	// RVA: 0x3C70E30 Offset: 0x3C70F31 VA: 0x3C70E30
	public static void set_matrix(Matrix4x4 value) { }

	// RVA: 0x3C70EF0 Offset: 0x3C70FF1 VA: 0x3C70EF0
	public static void Label(Rect position, string text, GUIStyle style) { }

	// RVA: 0x3C710E0 Offset: 0x3C711E1 VA: 0x3C710E0
	public static void Label(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x3C71560 Offset: 0x3C71661 VA: 0x3C71560
	public static void DrawTexture(Rect position, Texture image) { }

	// RVA: 0x3C71600 Offset: 0x3C71701 VA: 0x3C71600
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode) { }

	// RVA: 0x3C716F0 Offset: 0x3C717F1 VA: 0x3C716F0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend) { }

	// RVA: 0x3C717B0 Offset: 0x3C718B1 VA: 0x3C717B0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect) { }

	// RVA: 0x3C71920 Offset: 0x3C71A21 VA: 0x3C71920
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, float borderWidth, float borderRadius) { }

	// RVA: 0x3C71A50 Offset: 0x3C71B51 VA: 0x3C71A50
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, float borderRadius) { }

	// RVA: 0x3C71BA0 Offset: 0x3C71CA1 VA: 0x3C71BA0
	public static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses) { }

	// RVA: 0x3C71D40 Offset: 0x3C71E41 VA: 0x3C71D40
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x3C71ED0 Offset: 0x3C71FD1 VA: 0x3C71ED0
	internal static void DrawTexture(Rect position, Texture image, ScaleMode scaleMode, bool alphaBlend, float imageAspect, Color leftColor, Color topColor, Color rightColor, Color bottomColor, Vector4 borderWidths, Vector4 borderRadiuses, bool drawSmoothCorners) { }

	// RVA: 0x3C72640 Offset: 0x3C72741 VA: 0x3C72640
	internal static bool CalculateScaledTextureRects(Rect position, ScaleMode scaleMode, float imageAspect, ref Rect outScreenRect, ref Rect outSourceRect) { }

	// RVA: 0x3C728B0 Offset: 0x3C729B1 VA: 0x3C728B0
	public static void Box(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x3C72D10 Offset: 0x3C72E11 VA: 0x3C72D10
	public static bool Button(Rect position, string text) { }

	// RVA: 0x3C72E00 Offset: 0x3C72F01 VA: 0x3C72E00
	public static bool Button(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x3C72FB0 Offset: 0x3C730B1 VA: 0x3C72FB0
	internal static bool Button(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x3C731C0 Offset: 0x3C732C1 VA: 0x3C731C0
	private static bool DoRepeatButton(Rect position, GUIContent content, GUIStyle style, FocusType focusType) { }

	// RVA: 0x3C736B0 Offset: 0x3C737B1 VA: 0x3C736B0
	internal static bool DoControl(Rect position, int id, bool on, bool hover, GUIContent content, GUIStyle style) { }

	// RVA: 0x3C71190 Offset: 0x3C71291 VA: 0x3C71190
	private static void DoLabel(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x3C73070 Offset: 0x3C73171 VA: 0x3C73070
	internal static bool DoButton(Rect position, int id, GUIContent content, GUIStyle style) { }

	// RVA: 0x3C73F20 Offset: 0x3C74021 VA: 0x3C73F20
	public static float HorizontalSlider(Rect position, float value, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb) { }

	// RVA: 0x3C74000 Offset: 0x3C74101 VA: 0x3C74000
	public static float Slider(Rect position, float value, float size, float start, float end, GUIStyle slider, GUIStyle thumb, bool horiz, int id, GUIStyle thumbExtent) { }

	// RVA: 0x3C743F0 Offset: 0x3C744F1 VA: 0x3C743F0
	public static float HorizontalScrollbar(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle style) { }

	// RVA: 0x3C75210 Offset: 0x3C75311 VA: 0x3C75210
	internal static bool ScrollerRepeatButton(int scrollerID, Rect rect, GUIStyle style) { }

	// RVA: 0x3C75580 Offset: 0x3C75681 VA: 0x3C75580
	public static float VerticalScrollbar(Rect position, float value, float size, float topValue, float bottomValue, GUIStyle style) { }

	// RVA: 0x3C74B50 Offset: 0x3C74C51 VA: 0x3C74B50
	internal static float Scroller(Rect position, float value, float size, float leftValue, float rightValue, GUIStyle slider, GUIStyle thumb, GUIStyle leftButton, GUIStyle rightButton, bool horiz) { }

	// RVA: 0x3C75950 Offset: 0x3C75A51 VA: 0x3C75950
	public static void BeginGroup(Rect position, GUIContent content, GUIStyle style) { }

	// RVA: 0x3C75A10 Offset: 0x3C75B11 VA: 0x3C75A10
	internal static void BeginGroup(Rect position, GUIContent content, GUIStyle style, Vector2 scrollOffset) { }

	// RVA: 0x3C76060 Offset: 0x3C76161 VA: 0x3C76060
	public static void EndGroup() { }

	// RVA: 0x3C760F0 Offset: 0x3C761F1 VA: 0x3C760F0
	public static void BeginClip(Rect position) { }

	// RVA: 0x3C761A0 Offset: 0x3C762A1 VA: 0x3C761A0
	public static void EndClip() { }

	[CompilerGeneratedAttribute] // RVA: 0x539F0 Offset: 0x53AF1 VA: 0x539F0
	// RVA: 0x3C76230 Offset: 0x3C76331 VA: 0x3C76230
	internal static GenericStack get_scrollViewStates() { }

	// RVA: 0x3C762A0 Offset: 0x3C763A1 VA: 0x3C762A0
	internal static Vector2 BeginScrollView(Rect position, Vector2 scrollPosition, Rect viewRect, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar, GUIStyle background) { }

	// RVA: 0x3C77A10 Offset: 0x3C77B11 VA: 0x3C77A10
	public static void EndScrollView(bool handleScrollWheel) { }

	// RVA: 0x3C78990 Offset: 0x3C78A91 VA: 0x3C78990
	public static Rect Window(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style) { }

	// RVA: 0x3C78B10 Offset: 0x3C78C11 VA: 0x3C78B10
	private static Rect DoWindow(int id, Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, GUISkin skin, bool forceRectOnLayout) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x53A00 Offset: 0x53B01 VA: 0x53A00
	// RVA: 0x3C78C10 Offset: 0x3C78D11 VA: 0x3C78C10
	internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }

	// RVA: 0x3C79960 Offset: 0x3C79A61 VA: 0x3C79960
	public void .ctor() { }

	// RVA: 0x3C6FE60 Offset: 0x3C6FF61 VA: 0x3C6FE60
	private static void get_color_Injected(out Color ret) { }

	// RVA: 0x3C6FF50 Offset: 0x3C70051 VA: 0x3C6FF50
	private static void set_color_Injected(ref Color value) { }

	// RVA: 0x3C70040 Offset: 0x3C70141 VA: 0x3C70040
	private static void set_backgroundColor_Injected(ref Color value) { }

	// RVA: 0x3C704A0 Offset: 0x3C705A1 VA: 0x3C704A0
	private static void Internal_DoWindow_Injected(int id, int instanceID, ref Rect clientRect, GUI.WindowFunction func, GUIContent title, GUIStyle style, object skin, bool forceRectOnLayout, out Rect ret) { }
}

