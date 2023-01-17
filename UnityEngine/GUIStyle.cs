// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x52BD0 Offset: 0x52CD1 VA: 0x52BD0
[NativeHeaderAttribute] // RVA: 0x52BD0 Offset: 0x52CD1 VA: 0x52BD0
[RequiredByNativeCodeAttribute] // RVA: 0x52BD0 Offset: 0x52CD1 VA: 0x52BD0
[Serializable]
public sealed class GUIStyle // TypeDefIndex: 4166
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private GUIStyleState m_Normal; // 0x18
	private GUIStyleState m_Hover; // 0x20
	private GUIStyleState m_Active; // 0x28
	private GUIStyleState m_Focused; // 0x30
	private GUIStyleState m_OnNormal; // 0x38
	private GUIStyleState m_OnHover; // 0x40
	private GUIStyleState m_OnActive; // 0x48
	private GUIStyleState m_OnFocused; // 0x50
	private RectOffset m_Border; // 0x58
	private RectOffset m_Padding; // 0x60
	private RectOffset m_Margin; // 0x68
	private RectOffset m_Overflow; // 0x70
	private string m_Name; // 0x78
	internal static bool showKeyboardFocus; // 0x0
	private static GUIStyle s_None; // 0x8

	// Properties
	[NativePropertyAttribute] // RVA: 0x544F0 Offset: 0x545F1 VA: 0x544F0
	internal string rawName { get; set; }
	[NativePropertyAttribute] // RVA: 0x54530 Offset: 0x54631 VA: 0x54530
	public Font font { set; }
	[NativePropertyAttribute] // RVA: 0x54570 Offset: 0x54671 VA: 0x54570
	public ImagePosition imagePosition { get; }
	[NativePropertyAttribute] // RVA: 0x545B0 Offset: 0x546B1 VA: 0x545B0
	public TextAnchor alignment { set; }
	[NativePropertyAttribute] // RVA: 0x545F0 Offset: 0x546F1 VA: 0x545F0
	public bool wordWrap { get; }
	[NativePropertyAttribute] // RVA: 0x54630 Offset: 0x54731 VA: 0x54630
	public TextClipping clipping { set; }
	[NativePropertyAttribute] // RVA: 0x54670 Offset: 0x54771 VA: 0x54670
	public Vector2 contentOffset { set; }
	[NativePropertyAttribute] // RVA: 0x546B0 Offset: 0x547B1 VA: 0x546B0
	public float fixedWidth { get; }
	[NativePropertyAttribute] // RVA: 0x546F0 Offset: 0x547F1 VA: 0x546F0
	public float fixedHeight { get; set; }
	[NativePropertyAttribute] // RVA: 0x54730 Offset: 0x54831 VA: 0x54730
	public bool stretchWidth { get; set; }
	[NativePropertyAttribute] // RVA: 0x54770 Offset: 0x54871 VA: 0x54770
	public bool stretchHeight { get; set; }
	[NativePropertyAttribute] // RVA: 0x547B0 Offset: 0x548B1 VA: 0x547B0
	public int fontSize { get; set; }
	[NativePropertyAttribute] // RVA: 0x547F0 Offset: 0x548F1 VA: 0x547F0
	public FontStyle fontStyle { set; }
	public string name { get; set; }
	public GUIStyleState normal { get; set; }
	public RectOffset margin { get; }
	public RectOffset padding { get; }
	public static GUIStyle none { get; }
	public bool isHeightDependantOnWidth { get; }

	// Methods

	// RVA: 0x3C85A70 Offset: 0x3C85B71 VA: 0x3C85A70
	internal string get_rawName() { }

	// RVA: 0x3C85AC0 Offset: 0x3C85BC1 VA: 0x3C85AC0
	internal void set_rawName(string value) { }

	// RVA: 0x3C85B10 Offset: 0x3C85C11 VA: 0x3C85B10
	public void set_font(Font value) { }

	// RVA: 0x3C85B60 Offset: 0x3C85C61 VA: 0x3C85B60
	public ImagePosition get_imagePosition() { }

	// RVA: 0x3C85BB0 Offset: 0x3C85CB1 VA: 0x3C85BB0
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x3C85C00 Offset: 0x3C85D01 VA: 0x3C85C00
	public bool get_wordWrap() { }

	// RVA: 0x3C85C50 Offset: 0x3C85D51 VA: 0x3C85C50
	public void set_clipping(TextClipping value) { }

	// RVA: 0x3C85CA0 Offset: 0x3C85DA1 VA: 0x3C85CA0
	public void set_contentOffset(Vector2 value) { }

	// RVA: 0x3C758B0 Offset: 0x3C759B1 VA: 0x3C758B0
	public float get_fixedWidth() { }

	// RVA: 0x3C75900 Offset: 0x3C75A01 VA: 0x3C75900
	public float get_fixedHeight() { }

	// RVA: 0x3C85D50 Offset: 0x3C85E51 VA: 0x3C85D50
	public void set_fixedHeight(float value) { }

	// RVA: 0x3C7C900 Offset: 0x3C7CA01 VA: 0x3C7C900
	public bool get_stretchWidth() { }

	// RVA: 0x3C85DA0 Offset: 0x3C85EA1 VA: 0x3C85DA0
	public void set_stretchWidth(bool value) { }

	// RVA: 0x3C7C950 Offset: 0x3C7CA51 VA: 0x3C7C950
	public bool get_stretchHeight() { }

	// RVA: 0x3C855E0 Offset: 0x3C856E1 VA: 0x3C855E0
	public void set_stretchHeight(bool value) { }

	// RVA: 0x3C85DF0 Offset: 0x3C85EF1 VA: 0x3C85DF0
	public int get_fontSize() { }

	// RVA: 0x3C85E40 Offset: 0x3C85F41 VA: 0x3C85E40
	public void set_fontSize(int value) { }

	// RVA: 0x3C85E90 Offset: 0x3C85F91 VA: 0x3C85E90
	public void set_fontStyle(FontStyle value) { }

	[FreeFunctionAttribute] // RVA: 0x53B50 Offset: 0x53C51 VA: 0x53B50
	// RVA: 0x3C85EE0 Offset: 0x3C85FE1 VA: 0x3C85EE0
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunctionAttribute] // RVA: 0x53BA0 Offset: 0x53CA1 VA: 0x53BA0
	// RVA: 0x3C85F30 Offset: 0x3C86031 VA: 0x3C85F30
	private static IntPtr Internal_Copy(GUIStyle self, GUIStyle other) { }

	[FreeFunctionAttribute] // RVA: 0x53BF0 Offset: 0x53CF1 VA: 0x53BF0
	// RVA: 0x3C85F80 Offset: 0x3C86081 VA: 0x3C85F80
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunctionAttribute] // RVA: 0x53C40 Offset: 0x53D41 VA: 0x53C40
	// RVA: 0x3C85FD0 Offset: 0x3C860D1 VA: 0x3C85FD0
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0x53CA0 Offset: 0x53DA1 VA: 0x53CA0
	// RVA: 0x3C86020 Offset: 0x3C86121 VA: 0x3C86020
	private void AssignStyleState(int idx, IntPtr srcStyleState) { }

	[FreeFunctionAttribute] // RVA: 0x53CF0 Offset: 0x53DF1 VA: 0x53CF0
	// RVA: 0x3C86080 Offset: 0x3C86181 VA: 0x3C86080
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunctionAttribute] // RVA: 0x53D40 Offset: 0x53E41 VA: 0x53D40
	// RVA: 0x3C860D0 Offset: 0x3C861D1 VA: 0x3C860D0
	private void Internal_Draw(Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	[FreeFunctionAttribute] // RVA: 0x53D90 Offset: 0x53E91 VA: 0x53D90
	// RVA: 0x3C86200 Offset: 0x3C86301 VA: 0x3C86200
	private void Internal_Draw2(Rect position, GUIContent content, int controlID, bool on) { }

	[FreeFunctionAttribute] // RVA: 0x53DE0 Offset: 0x53EE1 VA: 0x53DE0
	// RVA: 0x3C862F0 Offset: 0x3C863F1 VA: 0x3C862F0
	internal Vector2 Internal_CalcSize(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0x53E30 Offset: 0x53F31 VA: 0x53E30
	// RVA: 0x3C863B0 Offset: 0x3C864B1 VA: 0x3C863B0
	internal Vector2 Internal_CalcSizeWithConstraints(GUIContent content, Vector2 maxSize) { }

	[FreeFunctionAttribute] // RVA: 0x53E80 Offset: 0x53F81 VA: 0x53E80
	// RVA: 0x3C86490 Offset: 0x3C86591 VA: 0x3C86490
	private float Internal_CalcHeight(GUIContent content, float width) { }

	[FreeFunctionAttribute] // RVA: 0x53ED0 Offset: 0x53FD1 VA: 0x53ED0
	// RVA: 0x3C864F0 Offset: 0x3C865F1 VA: 0x3C864F0
	private Vector2 Internal_CalcMinMaxWidth(GUIContent content) { }

	[FreeFunctionAttribute] // RVA: 0x53F20 Offset: 0x54021 VA: 0x53F20
	// RVA: 0x3C73E70 Offset: 0x3C73F71 VA: 0x3C73E70
	internal static void SetMouseTooltip(string tooltip, Rect screenRect) { }

	[FreeFunctionAttribute] // RVA: 0x53F70 Offset: 0x54071 VA: 0x53F70
	// RVA: 0x3C73E20 Offset: 0x3C73F21 VA: 0x3C73E20
	internal static bool IsTooltipActive(string tooltip) { }

	[FreeFunctionAttribute] // RVA: 0x53FC0 Offset: 0x540C1 VA: 0x53FC0
	// RVA: 0x3C82340 Offset: 0x3C82441 VA: 0x3C82340
	internal static void SetDefaultFont(Font font) { }

	// RVA: 0x3C836B0 Offset: 0x3C837B1 VA: 0x3C836B0
	public void .ctor() { }

	// RVA: 0x3C86600 Offset: 0x3C86701 VA: 0x3C86600
	public void .ctor(GUIStyle other) { }

	// RVA: 0x3C86720 Offset: 0x3C86821 VA: 0x3C86720 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x3C74720 Offset: 0x3C74821 VA: 0x3C74720
	public string get_name() { }

	// RVA: 0x3C83760 Offset: 0x3C83861 VA: 0x3C83760
	public void set_name(string value) { }

	// RVA: 0x3C85630 Offset: 0x3C85731 VA: 0x3C85630
	public GUIStyleState get_normal() { }

	// RVA: 0x3C868B0 Offset: 0x3C869B1 VA: 0x3C868B0
	public void set_normal(GUIStyleState value) { }

	// RVA: 0x3C77850 Offset: 0x3C77951 VA: 0x3C77850
	public RectOffset get_margin() { }

	// RVA: 0x3C7E3F0 Offset: 0x3C7E4F1 VA: 0x3C7E3F0
	public RectOffset get_padding() { }

	// RVA: 0x3C77910 Offset: 0x3C77A11 VA: 0x3C77910
	public void Draw(Rect position, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x3C73D10 Offset: 0x3C73E11 VA: 0x3C73D10
	public void Draw(Rect position, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x3C75ED0 Offset: 0x3C75FD1 VA: 0x3C75ED0
	public void Draw(Rect position, GUIContent content, int controlID) { }

	// RVA: 0x3C72B20 Offset: 0x3C72C21 VA: 0x3C72B20
	public void Draw(Rect position, GUIContent content, int controlID, bool on, bool hover) { }

	// RVA: 0x3C86910 Offset: 0x3C86A11 VA: 0x3C86910
	private void Draw(Rect position, GUIContent content, int controlId, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x3C75D90 Offset: 0x3C75E91 VA: 0x3C75D90
	public static GUIStyle get_none() { }

	// RVA: 0x3C86AD0 Offset: 0x3C86BD1 VA: 0x3C86AD0
	public Vector2 CalcSize(GUIContent content) { }

	// RVA: 0x3C814E0 Offset: 0x3C815E1 VA: 0x3C814E0
	internal Vector2 CalcSizeWithConstraints(GUIContent content, Vector2 constraints) { }

	// RVA: 0x3C86B30 Offset: 0x3C86C31 VA: 0x3C86B30
	public float CalcHeight(GUIContent content, float width) { }

	// RVA: 0x3C81300 Offset: 0x3C81401 VA: 0x3C81300
	public bool get_isHeightDependantOnWidth() { }

	// RVA: 0x3C86B90 Offset: 0x3C86C91 VA: 0x3C86B90
	public void CalcMinMaxWidth(GUIContent content, out float minWidth, out float maxWidth) { }

	// RVA: 0x3C86C10 Offset: 0x3C86D11 VA: 0x3C86C10 Slot: 3
	public override string ToString() { }

	// RVA: 0x3C86D20 Offset: 0x3C86E21 VA: 0x3C86D20
	private static void .cctor() { }

	// RVA: 0x3C85D00 Offset: 0x3C85E01 VA: 0x3C85D00
	private void set_contentOffset_Injected(ref Vector2 value) { }

	// RVA: 0x3C86170 Offset: 0x3C86271 VA: 0x3C86170
	private void Internal_Draw_Injected(ref Rect screenRect, GUIContent content, bool isHover, bool isActive, bool on, bool hasKeyboardFocus) { }

	// RVA: 0x3C86280 Offset: 0x3C86381 VA: 0x3C86280
	private void Internal_Draw2_Injected(ref Rect position, GUIContent content, int controlID, bool on) { }

	// RVA: 0x3C86350 Offset: 0x3C86451 VA: 0x3C86350
	private void Internal_CalcSize_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x3C86420 Offset: 0x3C86521 VA: 0x3C86420
	private void Internal_CalcSizeWithConstraints_Injected(GUIContent content, ref Vector2 maxSize, out Vector2 ret) { }

	// RVA: 0x3C86550 Offset: 0x3C86651 VA: 0x3C86550
	private void Internal_CalcMinMaxWidth_Injected(GUIContent content, out Vector2 ret) { }

	// RVA: 0x3C865B0 Offset: 0x3C866B1 VA: 0x3C865B0
	private static void SetMouseTooltip_Injected(string tooltip, ref Rect screenRect) { }
}

