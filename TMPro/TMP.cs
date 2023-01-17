// Namespace: TMPro
public struct TMP_MaterialReference // TypeDefIndex: 7333
{
	// Fields
	public Material material; // 0x0
	public int referenceCount; // 0x8
}

// Namespace: TMPro
[Serializable]
public abstract class TMP_Asset : ScriptableObject // TypeDefIndex: 7335
{
	// Fields
	private int m_InstanceID; // 0x18
	public int hashCode; // 0x1C
	public Material material; // 0x20
	public int materialHashCode; // 0x28

	// Properties
	public int instanceID { get; }

	// Methods

	// RVA: 0x1932BF0 Offset: 0x1932CF1 VA: 0x1932BF0
	public int get_instanceID() { }

	// RVA: 0x1932C30 Offset: 0x1932D31 VA: 0x1932C30
	protected void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Character : TMP_TextElement // TypeDefIndex: 7336
{
	// Methods

	// RVA: 0x1932C40 Offset: 0x1932D41 VA: 0x1932C40
	public void .ctor() { }

	// RVA: 0x1932C80 Offset: 0x1932D81 VA: 0x1932C80
	public void .ctor(uint unicode, Glyph glyph) { }

	// RVA: 0x1932D00 Offset: 0x1932E01 VA: 0x1932D00
	public void .ctor(uint unicode, TMP_FontAsset fontAsset, Glyph glyph) { }

	// RVA: 0x1932D80 Offset: 0x1932E81 VA: 0x1932D80
	internal void .ctor(uint unicode, uint glyphIndex) { }
}

// Namespace: TMPro
public struct TMP_Vertex // TypeDefIndex: 7337
{
	// Fields
	public Vector3 position; // 0x0
	public Vector2 uv; // 0xC
	public Vector2 uv2; // 0x14
	public Vector2 uv4; // 0x1C
	public Color32 color; // 0x24
	private static readonly TMP_Vertex k_Zero; // 0x0

	// Properties
	public static TMP_Vertex zero { get; }

	// Methods

	// RVA: 0x1987390 Offset: 0x1987491 VA: 0x1987390
	public static TMP_Vertex get_zero() { }

	// RVA: 0x1987420 Offset: 0x1987521 VA: 0x1987420
	private static void .cctor() { }
}

// Namespace: TMPro
public struct TMP_Offset // TypeDefIndex: 7338
{
	// Fields
	private float m_Left; // 0x0
	private float m_Right; // 0x4
	private float m_Top; // 0x8
	private float m_Bottom; // 0xC
	private static readonly TMP_Offset k_ZeroOffset; // 0x0

	// Properties
	public float left { get; set; }
	public float right { get; set; }
	public float top { get; set; }
	public float bottom { get; set; }
	public float horizontal { get; set; }
	public float vertical { get; set; }
	public static TMP_Offset zero { get; }

	// Methods

	// RVA: 0x18F3F10 Offset: 0x18F4011 VA: 0x18F3F10
	public float get_left() { }

	// RVA: 0x18F3F20 Offset: 0x18F4021 VA: 0x18F3F20
	public void set_left(float value) { }

	// RVA: 0x18F3F30 Offset: 0x18F4031 VA: 0x18F3F30
	public float get_right() { }

	// RVA: 0x18F3F40 Offset: 0x18F4041 VA: 0x18F3F40
	public void set_right(float value) { }

	// RVA: 0x18F3F50 Offset: 0x18F4051 VA: 0x18F3F50
	public float get_top() { }

	// RVA: 0x18F3F60 Offset: 0x18F4061 VA: 0x18F3F60
	public void set_top(float value) { }

	// RVA: 0x18F3F70 Offset: 0x18F4071 VA: 0x18F3F70
	public float get_bottom() { }

	// RVA: 0x18F3F80 Offset: 0x18F4081 VA: 0x18F3F80
	public void set_bottom(float value) { }

	// RVA: 0x18F3F90 Offset: 0x18F4091 VA: 0x18F3F90
	public float get_horizontal() { }

	// RVA: 0x18F3FA0 Offset: 0x18F40A1 VA: 0x18F3FA0
	public void set_horizontal(float value) { }

	// RVA: 0x18F3FB0 Offset: 0x18F40B1 VA: 0x18F3FB0
	public float get_vertical() { }

	// RVA: 0x18F3FC0 Offset: 0x18F40C1 VA: 0x18F3FC0
	public void set_vertical(float value) { }

	// RVA: 0x18F3FD0 Offset: 0x18F40D1 VA: 0x18F3FD0
	public static TMP_Offset get_zero() { }

	// RVA: 0x18F4040 Offset: 0x18F4141 VA: 0x18F4040
	public void .ctor(float left, float right, float top, float bottom) { }

	// RVA: 0x18F4060 Offset: 0x18F4161 VA: 0x18F4060
	public void .ctor(float horizontal, float vertical) { }

	// RVA: 0x18F4080 Offset: 0x18F4181 VA: 0x18F4080
	public static bool op_Equality(TMP_Offset lhs, TMP_Offset rhs) { }

	// RVA: 0x18F40B0 Offset: 0x18F41B1 VA: 0x18F40B0
	public static bool op_Inequality(TMP_Offset lhs, TMP_Offset rhs) { }

	// RVA: 0x18F4170 Offset: 0x18F4271 VA: 0x18F4170
	public static TMP_Offset op_Multiply(TMP_Offset a, float b) { }

	// RVA: 0x18F4190 Offset: 0x18F4291 VA: 0x18F4190 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18F4200 Offset: 0x18F4301 VA: 0x18F4200 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x18F4280 Offset: 0x18F4381 VA: 0x18F4280
	public bool Equals(TMP_Offset other) { }

	// RVA: 0x18F4340 Offset: 0x18F4441 VA: 0x18F4340
	private static void .cctor() { }
}

// Namespace: TMPro
[DebuggerDisplayAttribute] // RVA: 0x4CBD0 Offset: 0x4CCD1 VA: 0x4CBD0
public struct TMP_CharacterInfo // TypeDefIndex: 7340
{
	// Fields
	public char character; // 0x0
	public int index; // 0x4
	public int stringLength; // 0x8
	public TMP_TextElementType elementType; // 0xC
	public TMP_TextElement textElement; // 0x10
	public TMP_FontAsset fontAsset; // 0x18
	public TMP_SpriteAsset spriteAsset; // 0x20
	public int spriteIndex; // 0x28
	public Material material; // 0x30
	public int materialReferenceIndex; // 0x38
	public bool isUsingAlternateTypeface; // 0x3C
	public float pointSize; // 0x40
	public int lineNumber; // 0x44
	public int pageNumber; // 0x48
	public int vertexIndex; // 0x4C
	public TMP_Vertex vertex_BL; // 0x50
	public TMP_Vertex vertex_TL; // 0x78
	public TMP_Vertex vertex_TR; // 0xA0
	public TMP_Vertex vertex_BR; // 0xC8
	public Vector3 topLeft; // 0xF0
	public Vector3 bottomLeft; // 0xFC
	public Vector3 topRight; // 0x108
	public Vector3 bottomRight; // 0x114
	public float origin; // 0x120
	public float xAdvance; // 0x124
	public float ascender; // 0x128
	public float baseLine; // 0x12C
	public float descender; // 0x130
	internal float adjustedAscender; // 0x134
	internal float adjustedDescender; // 0x138
	public float aspectRatio; // 0x13C
	public float scale; // 0x140
	public Color32 color; // 0x144
	public Color32 underlineColor; // 0x148
	public int underlineVertexIndex; // 0x14C
	public Color32 strikethroughColor; // 0x150
	public int strikethroughVertexIndex; // 0x154
	public Color32 highlightColor; // 0x158
	public HighlightState highlightState; // 0x15C
	public FontStyles style; // 0x170
	public bool isVisible; // 0x174
}

// Namespace: TMPro
[ExcludeFromPresetAttribute] // RVA: 0x4CC10 Offset: 0x4CD11 VA: 0x4CC10
[Serializable]
public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 7342
{
	// Fields
	public ColorMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0

	// Methods

	// RVA: 0x1932DF0 Offset: 0x1932EF1 VA: 0x1932DF0
	public void .ctor() { }

	// RVA: 0x1932EC0 Offset: 0x1932FC1 VA: 0x1932EC0
	public void .ctor(Color color) { }

	// RVA: 0x1932F50 Offset: 0x1933051 VA: 0x1932F50
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0x1933030 Offset: 0x1933131 VA: 0x1933030
	private static void .cctor() { }
}

// Namespace: TMPro
public static class TMP_Compatibility // TypeDefIndex: 7344
{
	// Methods

	// RVA: 0x1933090 Offset: 0x1933191 VA: 0x1933090
	public static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue) { }
}

// Namespace: TMPro
public static class TMP_DefaultControls // TypeDefIndex: 7354
{
	// Fields
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_TextElementSize; // 0x0
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Color s_DefaultSelectableColor; // 0x18
	private static Color s_TextColor; // 0x28

	// Methods

	// RVA: 0x19330C0 Offset: 0x19331C1 VA: 0x19330C0
	private static GameObject CreateUIElementRoot(string name, Vector2 size) { }

	// RVA: 0x1933170 Offset: 0x1933271 VA: 0x1933170
	private static GameObject CreateUIObject(string name, GameObject parent) { }

	// RVA: 0x1933340 Offset: 0x1933441 VA: 0x1933340
	private static void SetDefaultTextValues(TMP_Text lbl) { }

	// RVA: 0x19333E0 Offset: 0x19334E1 VA: 0x19333E0
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x1933240 Offset: 0x1933341 VA: 0x1933240
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x1933470 Offset: 0x1933571 VA: 0x1933470
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x1933560 Offset: 0x1933661 VA: 0x1933560
	public static GameObject CreateScrollbar(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x19338B0 Offset: 0x19339B1 VA: 0x19338B0
	public static GameObject CreateButton(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x1933C40 Offset: 0x1933D41 VA: 0x1933C40
	public static GameObject CreateText(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x1933D70 Offset: 0x1933E71 VA: 0x1933D70
	public static GameObject CreateInputField(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x19343F0 Offset: 0x19344F1 VA: 0x19343F0
	public static GameObject CreateDropdown(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x1935480 Offset: 0x1935581 VA: 0x1935480
	private static void .cctor() { }
}

// Namespace: TMPro
[RequireComponent] // RVA: 0x4CC30 Offset: 0x4CD31 VA: 0x4CC30
[AddComponentMenu] // RVA: 0x4CC30 Offset: 0x4CD31 VA: 0x4CC30
public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 7361
{
	// Fields
	[SerializeField] // RVA: 0x4D350 Offset: 0x4D451 VA: 0x4D350
	private RectTransform m_Template; // 0xF8
	[SerializeField] // RVA: 0x4D360 Offset: 0x4D461 VA: 0x4D360
	private TMP_Text m_CaptionText; // 0x100
	[SerializeField] // RVA: 0x4D370 Offset: 0x4D471 VA: 0x4D370
	private Image m_CaptionImage; // 0x108
	[SerializeField] // RVA: 0x4D380 Offset: 0x4D481 VA: 0x4D380
	private Graphic m_Placeholder; // 0x110
	[SpaceAttribute] // RVA: 0x4D390 Offset: 0x4D491 VA: 0x4D390
	[SerializeField] // RVA: 0x4D390 Offset: 0x4D491 VA: 0x4D390
	private TMP_Text m_ItemText; // 0x118
	[SerializeField] // RVA: 0x4D3D0 Offset: 0x4D4D1 VA: 0x4D3D0
	private Image m_ItemImage; // 0x120
	[SerializeField] // RVA: 0x4D3E0 Offset: 0x4D4E1 VA: 0x4D3E0
	[SpaceAttribute] // RVA: 0x4D3E0 Offset: 0x4D4E1 VA: 0x4D3E0
	private int m_Value; // 0x128
	[SerializeField] // RVA: 0x4D420 Offset: 0x4D521 VA: 0x4D420
	[SpaceAttribute] // RVA: 0x4D420 Offset: 0x4D521 VA: 0x4D420
	private TMP_Dropdown.OptionDataList m_Options; // 0x130
	[SerializeField] // RVA: 0x4D460 Offset: 0x4D561 VA: 0x4D460
	[SpaceAttribute] // RVA: 0x4D460 Offset: 0x4D561 VA: 0x4D460
	private TMP_Dropdown.DropdownEvent m_OnValueChanged; // 0x138
	[SerializeField] // RVA: 0x4D4A0 Offset: 0x4D5A1 VA: 0x4D4A0
	private float m_AlphaFadeSpeed; // 0x140
	private GameObject m_Dropdown; // 0x148
	private GameObject m_Blocker; // 0x150
	private List<TMP_Dropdown.DropdownItem> m_Items; // 0x158
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x160
	private bool validTemplate; // 0x168
	private Coroutine m_Coroutine; // 0x170
	private static TMP_Dropdown.OptionData s_NoOptionData; // 0x0

	// Properties
	public RectTransform template { get; set; }
	public TMP_Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Graphic placeholder { get; set; }
	public TMP_Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<TMP_Dropdown.OptionData> options { get; set; }
	public TMP_Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }
	public bool IsExpanded { get; }

	// Methods

	// RVA: 0x1935590 Offset: 0x1935691 VA: 0x1935590
	public RectTransform get_template() { }

	// RVA: 0x1935150 Offset: 0x1935251 VA: 0x1935150
	public void set_template(RectTransform value) { }

	// RVA: 0x19355A0 Offset: 0x19356A1 VA: 0x19355A0
	public TMP_Text get_captionText() { }

	// RVA: 0x1935180 Offset: 0x1935281 VA: 0x1935180
	public void set_captionText(TMP_Text value) { }

	// RVA: 0x19355B0 Offset: 0x19356B1 VA: 0x19355B0
	public Image get_captionImage() { }

	// RVA: 0x19355C0 Offset: 0x19356C1 VA: 0x19355C0
	public void set_captionImage(Image value) { }

	// RVA: 0x19355F0 Offset: 0x19356F1 VA: 0x19355F0
	public Graphic get_placeholder() { }

	// RVA: 0x1935600 Offset: 0x1935701 VA: 0x1935600
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1935630 Offset: 0x1935731 VA: 0x1935630
	public TMP_Text get_itemText() { }

	// RVA: 0x19351B0 Offset: 0x19352B1 VA: 0x19351B0
	public void set_itemText(TMP_Text value) { }

	// RVA: 0x1935640 Offset: 0x1935741 VA: 0x1935640
	public Image get_itemImage() { }

	// RVA: 0x1935650 Offset: 0x1935751 VA: 0x1935650
	public void set_itemImage(Image value) { }

	// RVA: 0x19351E0 Offset: 0x19352E1 VA: 0x19351E0
	public List<TMP_Dropdown.OptionData> get_options() { }

	// RVA: 0x1935680 Offset: 0x1935781 VA: 0x1935680
	public void set_options(List<TMP_Dropdown.OptionData> value) { }

	// RVA: 0x19356B0 Offset: 0x19357B1 VA: 0x19356B0
	public TMP_Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x19356C0 Offset: 0x19357C1 VA: 0x19356C0
	public void set_onValueChanged(TMP_Dropdown.DropdownEvent value) { }

	// RVA: 0x19356D0 Offset: 0x19357D1 VA: 0x19356D0
	public float get_alphaFadeSpeed() { }

	// RVA: 0x19356E0 Offset: 0x19357E1 VA: 0x19356E0
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x19356F0 Offset: 0x19357F1 VA: 0x19356F0
	public int get_value() { }

	// RVA: 0x1935700 Offset: 0x1935801 VA: 0x1935700
	public void set_value(int value) { }

	// RVA: 0x1935850 Offset: 0x1935951 VA: 0x1935850
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x1935710 Offset: 0x1935811 VA: 0x1935710
	private void SetValue(int value, bool sendCallback = True) { }

	// RVA: 0x1935860 Offset: 0x1935961 VA: 0x1935860
	public bool get_IsExpanded() { }

	// RVA: 0x19358E0 Offset: 0x19359E1 VA: 0x19358E0
	protected void .ctor() { }

	// RVA: 0x1935A30 Offset: 0x1935B31 VA: 0x1935A30 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1935B60 Offset: 0x1935C61 VA: 0x1935B60 Slot: 6
	protected override void Start() { }

	// RVA: 0x1935C10 Offset: 0x1935D11 VA: 0x1935C10 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x19351F0 Offset: 0x19352F1 VA: 0x19351F0
	public void RefreshShownValue() { }

	// RVA: 0x1935EA0 Offset: 0x1935FA1 VA: 0x1935EA0
	public void AddOptions(List<TMP_Dropdown.OptionData> options) { }

	// RVA: 0x1935F10 Offset: 0x1936011 VA: 0x1935F10
	public void AddOptions(List<string> options) { }

	// RVA: 0x1936020 Offset: 0x1936121 VA: 0x1936020
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x1936130 Offset: 0x1936231 VA: 0x1936130
	public void ClearOptions() { }

	// RVA: 0x19361E0 Offset: 0x19362E1 VA: 0x19361E0
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2023B40 Offset: 0x2023C41 VA: 0x2023B40
	|-TMP_Dropdown.GetOrAddComponent<Canvas>
	|-TMP_Dropdown.GetOrAddComponent<CanvasGroup>
	|-TMP_Dropdown.GetOrAddComponent<GraphicRaycaster>
	|-TMP_Dropdown.GetOrAddComponent<object>
	*/

	// RVA: 0x1936910 Offset: 0x1936A11 VA: 0x1936910 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x19376D0 Offset: 0x19377D1 VA: 0x19376D0 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x19376E0 Offset: 0x19377E1 VA: 0x19376E0 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1936920 Offset: 0x1936A21 VA: 0x1936920
	public void Show() { }

	// RVA: 0x1937D40 Offset: 0x1937E41 VA: 0x1937D40 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x1938190 Offset: 0x1938291 VA: 0x1938190 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x1938200 Offset: 0x1938301 VA: 0x1938200 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x1938280 Offset: 0x1938381 VA: 0x1938280 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x19382F0 Offset: 0x19383F1 VA: 0x19382F0 Slot: 49
	protected virtual TMP_Dropdown.DropdownItem CreateItem(TMP_Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x1938370 Offset: 0x1938471 VA: 0x1938370 Slot: 50
	protected virtual void DestroyItem(TMP_Dropdown.DropdownItem item) { }

	// RVA: 0x19378F0 Offset: 0x19379F1 VA: 0x19378F0
	private TMP_Dropdown.DropdownItem AddItem(TMP_Dropdown.OptionData data, bool selected, TMP_Dropdown.DropdownItem itemTemplate, List<TMP_Dropdown.DropdownItem> items) { }

	// RVA: 0x1938380 Offset: 0x1938481 VA: 0x1938380
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x1937BA0 Offset: 0x1937CA1 VA: 0x1937BA0
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x1938400 Offset: 0x1938501 VA: 0x1938400
	private void SetAlpha(float alpha) { }

	// RVA: 0x19376F0 Offset: 0x19377F1 VA: 0x19376F0
	public void Hide() { }

	[IteratorStateMachineAttribute] // RVA: 0x4E640 Offset: 0x4E741 VA: 0x4E640
	// RVA: 0x19384D0 Offset: 0x19385D1 VA: 0x19384D0
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x1935CD0 Offset: 0x1935DD1 VA: 0x1935CD0
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x1938560 Offset: 0x1938661 VA: 0x1938560
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x1938690 Offset: 0x1938791 VA: 0x1938690
	private static void .cctor() { }
}

// Namespace: TMPro
[ExcludeFromPresetAttribute] // RVA: 0x4CCE0 Offset: 0x4CDE1 VA: 0x4CCE0
[Serializable]
public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 7364
{
	// Fields
	[SerializeField] // RVA: 0x4D520 Offset: 0x4D621 VA: 0x4D520
	private string m_Version; // 0x30
	[SerializeField] // RVA: 0x4D530 Offset: 0x4D631 VA: 0x4D530
	internal string m_SourceFontFileGUID; // 0x38
	[SerializeField] // RVA: 0x4D540 Offset: 0x4D641 VA: 0x4D540
	private Font m_SourceFontFile; // 0x40
	[SerializeField] // RVA: 0x4D550 Offset: 0x4D651 VA: 0x4D550
	private AtlasPopulationMode m_AtlasPopulationMode; // 0x48
	[SerializeField] // RVA: 0x4D560 Offset: 0x4D661 VA: 0x4D560
	internal FaceInfo m_FaceInfo; // 0x50
	[SerializeField] // RVA: 0x4D570 Offset: 0x4D671 VA: 0x4D570
	internal List<Glyph> m_GlyphTable; // 0xB0
	internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0xB8
	[SerializeField] // RVA: 0x4D580 Offset: 0x4D681 VA: 0x4D580
	internal List<TMP_Character> m_CharacterTable; // 0xC0
	internal Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0xC8
	internal Texture2D m_AtlasTexture; // 0xD0
	[SerializeField] // RVA: 0x4D590 Offset: 0x4D691 VA: 0x4D590
	internal Texture2D[] m_AtlasTextures; // 0xD8
	[SerializeField] // RVA: 0x4D5A0 Offset: 0x4D6A1 VA: 0x4D5A0
	internal int m_AtlasTextureIndex; // 0xE0
	[SerializeField] // RVA: 0x4D5B0 Offset: 0x4D6B1 VA: 0x4D5B0
	private bool m_IsMultiAtlasTexturesEnabled; // 0xE4
	[SerializeField] // RVA: 0x4D5C0 Offset: 0x4D6C1 VA: 0x4D5C0
	private bool m_ClearDynamicDataOnBuild; // 0xE5
	[SerializeField] // RVA: 0x4D5D0 Offset: 0x4D6D1 VA: 0x4D5D0
	private List<GlyphRect> m_UsedGlyphRects; // 0xE8
	[SerializeField] // RVA: 0x4D5E0 Offset: 0x4D6E1 VA: 0x4D5E0
	private List<GlyphRect> m_FreeGlyphRects; // 0xF0
	[SerializeField] // RVA: 0x4D5F0 Offset: 0x4D6F1 VA: 0x4D5F0
	private FaceInfo_Legacy m_fontInfo; // 0xF8
	[SerializeField] // RVA: 0x4D600 Offset: 0x4D701 VA: 0x4D600
	public Texture2D atlas; // 0x100
	[SerializeField] // RVA: 0x4D610 Offset: 0x4D711 VA: 0x4D610
	internal int m_AtlasWidth; // 0x108
	[SerializeField] // RVA: 0x4D620 Offset: 0x4D721 VA: 0x4D620
	internal int m_AtlasHeight; // 0x10C
	[SerializeField] // RVA: 0x4D630 Offset: 0x4D731 VA: 0x4D630
	internal int m_AtlasPadding; // 0x110
	[SerializeField] // RVA: 0x4D640 Offset: 0x4D741 VA: 0x4D640
	internal GlyphRenderMode m_AtlasRenderMode; // 0x114
	[SerializeField] // RVA: 0x4D650 Offset: 0x4D751 VA: 0x4D650
	internal List<TMP_Glyph> m_glyphInfoList; // 0x118
	[FormerlySerializedAsAttribute] // RVA: 0x4D660 Offset: 0x4D761 VA: 0x4D660
	[SerializeField] // RVA: 0x4D660 Offset: 0x4D761 VA: 0x4D660
	internal KerningTable m_KerningTable; // 0x120
	[SerializeField] // RVA: 0x4D6B0 Offset: 0x4D7B1 VA: 0x4D6B0
	internal TMP_FontFeatureTable m_FontFeatureTable; // 0x128
	[SerializeField] // RVA: 0x4D6C0 Offset: 0x4D7C1 VA: 0x4D6C0
	private List<TMP_FontAsset> fallbackFontAssets; // 0x130
	[SerializeField] // RVA: 0x4D6D0 Offset: 0x4D7D1 VA: 0x4D6D0
	internal List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x138
	[SerializeField] // RVA: 0x4D6E0 Offset: 0x4D7E1 VA: 0x4D6E0
	internal FontAssetCreationSettings m_CreationSettings; // 0x140
	[SerializeField] // RVA: 0x4D6F0 Offset: 0x4D7F1 VA: 0x4D6F0
	private TMP_FontWeightPair[] m_FontWeightTable; // 0x198
	[SerializeField] // RVA: 0x4D700 Offset: 0x4D801 VA: 0x4D700
	private TMP_FontWeightPair[] fontWeights; // 0x1A0
	public float normalStyle; // 0x1A8
	public float normalSpacingOffset; // 0x1AC
	public float boldStyle; // 0x1B0
	public float boldSpacing; // 0x1B4
	public byte italicStyle; // 0x1B8
	public byte tabSize; // 0x1B9
	internal bool IsFontAssetLookupTablesDirty; // 0x1BA
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x0
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x8
	private static ProfilerMarker k_TryAddCharacterMarker; // 0x10
	private static ProfilerMarker k_TryAddCharactersMarker; // 0x18
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x20
	private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x28
	private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x30
	private static string s_DefaultMaterialSuffix; // 0x38
	internal HashSet<int> FallbackSearchQueryLookup; // 0x1C0
	private static HashSet<int> k_SearchedFontAssetLookup; // 0x40
	private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x48
	private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x50
	private static List<TMP_FontAsset> k_FontAssets_AtlasTexturesUpdateQueue; // 0x58
	private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x60
	private List<Glyph> m_GlyphsToRender; // 0x1C8
	private List<Glyph> m_GlyphsRendered; // 0x1D0
	private List<uint> m_GlyphIndexList; // 0x1D8
	private List<uint> m_GlyphIndexListNewlyAdded; // 0x1E0
	internal List<uint> m_GlyphsToAdd; // 0x1E8
	internal HashSet<uint> m_GlyphsToAddLookup; // 0x1F0
	internal List<TMP_Character> m_CharactersToAdd; // 0x1F8
	internal HashSet<uint> m_CharactersToAddLookup; // 0x200
	internal List<uint> s_MissingCharacterList; // 0x208
	internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x210
	internal static uint[] k_GlyphIndexArray; // 0x68

	// Properties
	public string version { get; set; }
	public Font sourceFontFile { get; set; }
	public AtlasPopulationMode atlasPopulationMode { get; set; }
	public FaceInfo faceInfo { get; set; }
	public List<Glyph> glyphTable { get; set; }
	public Dictionary<uint, Glyph> glyphLookupTable { get; }
	public List<TMP_Character> characterTable { get; set; }
	public Dictionary<uint, TMP_Character> characterLookupTable { get; }
	public Texture2D atlasTexture { get; }
	public Texture2D[] atlasTextures { get; set; }
	public int atlasTextureCount { get; }
	public bool isMultiAtlasTexturesEnabled { get; set; }
	internal bool clearDynamicDataOnBuild { get; set; }
	internal List<GlyphRect> usedGlyphRects { get; set; }
	internal List<GlyphRect> freeGlyphRects { get; set; }
	[ObsoleteAttribute] // RVA: 0x4ECB0 Offset: 0x4EDB1 VA: 0x4ECB0
	public FaceInfo_Legacy fontInfo { get; }
	public int atlasWidth { get; set; }
	public int atlasHeight { get; set; }
	public int atlasPadding { get; set; }
	public GlyphRenderMode atlasRenderMode { get; set; }
	public TMP_FontFeatureTable fontFeatureTable { get; set; }
	public List<TMP_FontAsset> fallbackFontAssetTable { get; set; }
	public FontAssetCreationSettings creationSettings { get; set; }
	public TMP_FontWeightPair[] fontWeightTable { get; set; }

	// Methods

	// RVA: 0x1938710 Offset: 0x1938811 VA: 0x1938710
	public string get_version() { }

	// RVA: 0x1938720 Offset: 0x1938821 VA: 0x1938720
	internal void set_version(string value) { }

	// RVA: 0x1938730 Offset: 0x1938831 VA: 0x1938730
	public Font get_sourceFontFile() { }

	// RVA: 0x1938740 Offset: 0x1938841 VA: 0x1938740
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x1938750 Offset: 0x1938851 VA: 0x1938750
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x1938760 Offset: 0x1938861 VA: 0x1938760
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0x1938770 Offset: 0x1938871 VA: 0x1938770
	public FaceInfo get_faceInfo() { }

	// RVA: 0x19387B0 Offset: 0x19388B1 VA: 0x19387B0
	public void set_faceInfo(FaceInfo value) { }

	// RVA: 0x19387E0 Offset: 0x19388E1 VA: 0x19387E0
	public List<Glyph> get_glyphTable() { }

	// RVA: 0x19387F0 Offset: 0x19388F1 VA: 0x19387F0
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0x1938800 Offset: 0x1938901 VA: 0x1938800
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x1938AB0 Offset: 0x1938BB1 VA: 0x1938AB0
	public List<TMP_Character> get_characterTable() { }

	// RVA: 0x1938AC0 Offset: 0x1938BC1 VA: 0x1938AC0
	internal void set_characterTable(List<TMP_Character> value) { }

	// RVA: 0x1938AD0 Offset: 0x1938BD1 VA: 0x1938AD0
	public Dictionary<uint, TMP_Character> get_characterLookupTable() { }

	// RVA: 0x1938B10 Offset: 0x1938C11 VA: 0x1938B10
	public Texture2D get_atlasTexture() { }

	// RVA: 0x1938BC0 Offset: 0x1938CC1 VA: 0x1938BC0
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0x1938BD0 Offset: 0x1938CD1 VA: 0x1938BD0
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x1938BE0 Offset: 0x1938CE1 VA: 0x1938BE0
	public int get_atlasTextureCount() { }

	// RVA: 0x1938BF0 Offset: 0x1938CF1 VA: 0x1938BF0
	public bool get_isMultiAtlasTexturesEnabled() { }

	// RVA: 0x1938C00 Offset: 0x1938D01 VA: 0x1938C00
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	// RVA: 0x1938C10 Offset: 0x1938D11 VA: 0x1938C10
	internal bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x1938C20 Offset: 0x1938D21 VA: 0x1938C20
	internal void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x1938C30 Offset: 0x1938D31 VA: 0x1938C30
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x1938C40 Offset: 0x1938D41 VA: 0x1938C40
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x1938C50 Offset: 0x1938D51 VA: 0x1938C50
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x1938C60 Offset: 0x1938D61 VA: 0x1938C60
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x1938C70 Offset: 0x1938D71 VA: 0x1938C70
	public FaceInfo_Legacy get_fontInfo() { }

	// RVA: 0x1938C80 Offset: 0x1938D81 VA: 0x1938C80
	public int get_atlasWidth() { }

	// RVA: 0x1938C90 Offset: 0x1938D91 VA: 0x1938C90
	internal void set_atlasWidth(int value) { }

	// RVA: 0x1938CA0 Offset: 0x1938DA1 VA: 0x1938CA0
	public int get_atlasHeight() { }

	// RVA: 0x1938CB0 Offset: 0x1938DB1 VA: 0x1938CB0
	internal void set_atlasHeight(int value) { }

	// RVA: 0x1938CC0 Offset: 0x1938DC1 VA: 0x1938CC0
	public int get_atlasPadding() { }

	// RVA: 0x1938CD0 Offset: 0x1938DD1 VA: 0x1938CD0
	internal void set_atlasPadding(int value) { }

	// RVA: 0x1938CE0 Offset: 0x1938DE1 VA: 0x1938CE0
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0x1938CF0 Offset: 0x1938DF1 VA: 0x1938CF0
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x1938D00 Offset: 0x1938E01 VA: 0x1938D00
	public TMP_FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0x1938D10 Offset: 0x1938E11 VA: 0x1938D10
	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	// RVA: 0x1938D20 Offset: 0x1938E21 VA: 0x1938D20
	public List<TMP_FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x1938D30 Offset: 0x1938E31 VA: 0x1938D30
	public void set_fallbackFontAssetTable(List<TMP_FontAsset> value) { }

	// RVA: 0x1938D40 Offset: 0x1938E41 VA: 0x1938D40
	public FontAssetCreationSettings get_creationSettings() { }

	// RVA: 0x1938D80 Offset: 0x1938E81 VA: 0x1938D80
	public void set_creationSettings(FontAssetCreationSettings value) { }

	// RVA: 0x1938DB0 Offset: 0x1938EB1 VA: 0x1938DB0
	public TMP_FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0x1938DC0 Offset: 0x1938EC1 VA: 0x1938DC0
	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	// RVA: 0x1938DD0 Offset: 0x1938ED1 VA: 0x1938DD0
	public static TMP_FontAsset CreateFontAsset(Font font) { }

	// RVA: 0x1938E60 Offset: 0x1938F61 VA: 0x1938E60
	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x1939400 Offset: 0x1939501 VA: 0x1939400
	private void Awake() { }

	// RVA: 0x1938840 Offset: 0x1938941 VA: 0x1938840
	public void ReadFontAssetDefinition() { }

	// RVA: 0x193A090 Offset: 0x193A191 VA: 0x193A090
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0x193A3B0 Offset: 0x193A4B1 VA: 0x193A3B0
	internal void InitializeGlyphLookupDictionary() { }

	// RVA: 0x193A640 Offset: 0x193A741 VA: 0x193A640
	internal void InitializeCharacterLookupDictionary() { }

	// RVA: 0x193A8A0 Offset: 0x193A9A1 VA: 0x193A8A0
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x193A0C0 Offset: 0x193A1C1 VA: 0x193A0C0
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	// RVA: 0x193ADE0 Offset: 0x193AEE1 VA: 0x193ADE0
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = False) { }

	// RVA: 0x193B0D0 Offset: 0x193B1D1 VA: 0x193B0D0
	internal void AddCharacterToLookupCache(uint unicode, TMP_Character character) { }

	// RVA: 0x193B180 Offset: 0x193B281 VA: 0x193B180
	internal void SortCharacterTable() { }

	// RVA: 0x193B320 Offset: 0x193B421 VA: 0x193B320
	internal void SortGlyphTable() { }

	// RVA: 0x193B4C0 Offset: 0x193B5C1 VA: 0x193B4C0
	internal void SortFontFeatureTable() { }

	// RVA: 0x193B4D0 Offset: 0x193B5D1 VA: 0x193B4D0
	internal void SortAllTables() { }

	// RVA: 0x193B500 Offset: 0x193B601 VA: 0x193B500
	public bool HasCharacter(int character) { }

	// RVA: 0x193B570 Offset: 0x193B671 VA: 0x193B570
	public bool HasCharacter(char character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x193C330 Offset: 0x193C431 VA: 0x193C330
	private bool HasCharacter_Internal(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x193C570 Offset: 0x193C671 VA: 0x193C570
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0x193C6F0 Offset: 0x193C7F1 VA: 0x193C6F0
	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x193CD10 Offset: 0x193CE11 VA: 0x193CD10
	public bool HasCharacters(string text) { }

	// RVA: 0x193CDF0 Offset: 0x193CEF1 VA: 0x193CDF0
	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x193CEF0 Offset: 0x193CFF1 VA: 0x193CEF0
	public static int[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	// RVA: 0x193CFE0 Offset: 0x193D0E1 VA: 0x193CFE0
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x193D110 Offset: 0x193D211 VA: 0x193D110
	internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset) { }

	// RVA: 0x193D210 Offset: 0x193D311 VA: 0x193D210
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	// RVA: 0x193D690 Offset: 0x193D791 VA: 0x193D690
	internal static void RegisterFontAssetForAtlasTextureUpdate(TMP_FontAsset fontAsset) { }

	// RVA: 0x193D790 Offset: 0x193D891 VA: 0x193D790
	internal static void UpdateAtlasTexturesForFontAssetsInQueue() { }

	// RVA: 0x193D900 Offset: 0x193DA01 VA: 0x193D900
	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = False) { }

	// RVA: 0x193D930 Offset: 0x193DA31 VA: 0x193D930
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = False) { }

	// RVA: 0x193E680 Offset: 0x193E781 VA: 0x193E680
	public bool TryAddCharacters(string characters, bool includeFontFeatures = False) { }

	// RVA: 0x193E6B0 Offset: 0x193E7B1 VA: 0x193E6B0
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = False) { }

	// RVA: 0x193BAB0 Offset: 0x193BBB1 VA: 0x193BAB0
	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	// RVA: 0x193F290 Offset: 0x193F391 VA: 0x193F290
	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character) { }

	// RVA: 0x193D8F0 Offset: 0x193D9F1 VA: 0x193D8F0
	internal void TryAddGlyphsToAtlasTextures() { }

	// RVA: 0x193E350 Offset: 0x193E451 VA: 0x193E350
	private bool TryAddGlyphsToNewAtlasTexture() { }

	// RVA: 0x193F090 Offset: 0x193F191 VA: 0x193F090
	private void SetupNewAtlasTexture() { }

	// RVA: 0x193F760 Offset: 0x193F861 VA: 0x193F760
	internal void UpdateAtlasTexture() { }

	// RVA: 0x193D390 Offset: 0x193D491 VA: 0x193D390
	internal void UpdateGlyphAdjustmentRecords() { }

	// RVA: 0x193F8C0 Offset: 0x193F9C1 VA: 0x193F8C0
	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) { }

	// RVA: 0x193FBB0 Offset: 0x193FCB1 VA: 0x193FBB0
	internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x193FBC0 Offset: 0x193FCC1 VA: 0x193FBC0
	internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes) { }

	// RVA: -1 Offset: -1
	private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2023C10 Offset: 0x2023D11 VA: 0x2023C10
	|-TMP_FontAsset.CopyListDataToArray<object>
	*/

	// RVA: 0x193FBD0 Offset: 0x193FCD1 VA: 0x193FBD0
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0x19401C0 Offset: 0x19402C1 VA: 0x19401C0
	internal void ClearFontAssetDataInternal() { }

	// RVA: 0x19401F0 Offset: 0x19402F1 VA: 0x19401F0
	internal void UpdateFontAssetData() { }

	// RVA: 0x193FC10 Offset: 0x193FD11 VA: 0x193FC10
	internal void ClearFontAssetTables() { }

	// RVA: 0x193FD80 Offset: 0x193FE81 VA: 0x193FD80
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = False) { }

	// RVA: 0x19394A0 Offset: 0x19395A1 VA: 0x19394A0
	internal void UpgradeFontAsset() { }

	// RVA: 0x193AA70 Offset: 0x193AB71 VA: 0x193AA70
	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

	// RVA: 0x1940320 Offset: 0x1940421 VA: 0x1940320
	public void .ctor() { }

	// RVA: 0x1940740 Offset: 0x1940841 VA: 0x1940740
	private static void .cctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Glyph : TMP_TextElement_Legacy // TypeDefIndex: 7366
{
	// Methods

	// RVA: 0x1AAC6A0 Offset: 0x1AAC7A1 VA: 0x1AAC6A0
	public static TMP_Glyph Clone(TMP_Glyph source) { }

	// RVA: 0x1AAC750 Offset: 0x1AAC851 VA: 0x1AAC750
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public struct TMP_FontWeightPair // TypeDefIndex: 7368
{
	// Fields
	public TMP_FontAsset regularTypeface; // 0x0
	public TMP_FontAsset italicTypeface; // 0x8
}

// Namespace: TMPro
public static class TMP_FontUtilities // TypeDefIndex: 7377
{
	// Fields
	private static List<int> k_searchedFontAssets; // 0x0

	// Methods

	// RVA: 0x1AAC240 Offset: 0x1AAC341 VA: 0x1AAC240
	public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0x1AAC580 Offset: 0x1AAC681 VA: 0x1AAC580
	public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

	// RVA: 0x1AAC330 Offset: 0x1AAC431 VA: 0x1AAC330
	private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0x1AAC590 Offset: 0x1AAC691 VA: 0x1AAC590
	private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }
}

// Namespace: TMPro
public class TMP_FontAssetUtilities // TypeDefIndex: 7378
{
	// Fields
	private static readonly TMP_FontAssetUtilities s_Instance; // 0x0
	private static HashSet<int> k_SearchedAssets; // 0x8
	private static bool k_IsFontEngineInitialized; // 0x10

	// Properties
	public static TMP_FontAssetUtilities instance { get; }

	// Methods

	// RVA: 0x1940A40 Offset: 0x1940B41 VA: 0x1940A40
	private static void .cctor() { }

	// RVA: 0x1940AC0 Offset: 0x1940BC1 VA: 0x1940AC0
	public static TMP_FontAssetUtilities get_instance() { }

	// RVA: 0x1940B30 Offset: 0x1940C31 VA: 0x1940B30
	public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x1940CE0 Offset: 0x1940DE1 VA: 0x1940CE0
	private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x19410B0 Offset: 0x19411B1 VA: 0x19410B0
	public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x1941350 Offset: 0x1941451 VA: 0x1941350
	public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x19416C0 Offset: 0x19417C1 VA: 0x19416C0
	private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x1940AB0 Offset: 0x1940BB1 VA: 0x1940AB0
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_FontFeatureTable // TypeDefIndex: 7380
{
	// Fields
	[SerializeField] // RVA: 0x4D820 Offset: 0x4D921 VA: 0x4D820
	internal List<TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x10
	internal Dictionary<uint, TMP_GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookupDictionary; // 0x18

	// Properties
	public List<TMP_GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; }

	// Methods

	// RVA: 0x1AABC50 Offset: 0x1AABD51 VA: 0x1AABC50
	public List<TMP_GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	// RVA: 0x1AABC60 Offset: 0x1AABD61 VA: 0x1AABC60
	public void set_glyphPairAdjustmentRecords(List<TMP_GlyphPairAdjustmentRecord> value) { }

	// RVA: 0x1AABC70 Offset: 0x1AABD71 VA: 0x1AABC70
	public void .ctor() { }

	// RVA: 0x1AABD50 Offset: 0x1AABE51 VA: 0x1AABD50
	public void SortGlyphPairAdjustmentRecords() { }
}

// Namespace: TMPro
[Serializable]
public struct TMP_GlyphValueRecord // TypeDefIndex: 7382
{
	// Fields
	[SerializeField] // RVA: 0x4D830 Offset: 0x4D931 VA: 0x4D830
	internal float m_XPlacement; // 0x0
	[SerializeField] // RVA: 0x4D840 Offset: 0x4D941 VA: 0x4D840
	internal float m_YPlacement; // 0x4
	[SerializeField] // RVA: 0x4D850 Offset: 0x4D951 VA: 0x4D850
	internal float m_XAdvance; // 0x8
	[SerializeField] // RVA: 0x4D860 Offset: 0x4D961 VA: 0x4D860
	internal float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; set; }
	public float yAdvance { get; set; }

	// Methods

	// RVA: 0x1AACB70 Offset: 0x1AACC71 VA: 0x1AACB70
	public float get_xPlacement() { }

	// RVA: 0x1AACB80 Offset: 0x1AACC81 VA: 0x1AACB80
	public void set_xPlacement(float value) { }

	// RVA: 0x1AACB90 Offset: 0x1AACC91 VA: 0x1AACB90
	public float get_yPlacement() { }

	// RVA: 0x1AACBA0 Offset: 0x1AACCA1 VA: 0x1AACBA0
	public void set_yPlacement(float value) { }

	// RVA: 0x1AACBB0 Offset: 0x1AACCB1 VA: 0x1AACBB0
	public float get_xAdvance() { }

	// RVA: 0x1AACBC0 Offset: 0x1AACCC1 VA: 0x1AACBC0
	public void set_xAdvance(float value) { }

	// RVA: 0x1AACBD0 Offset: 0x1AACCD1 VA: 0x1AACBD0
	public float get_yAdvance() { }

	// RVA: 0x1AACBE0 Offset: 0x1AACCE1 VA: 0x1AACBE0
	public void set_yAdvance(float value) { }

	// RVA: 0x1AACBF0 Offset: 0x1AACCF1 VA: 0x1AACBF0
	public void .ctor(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	// RVA: 0x1AACC10 Offset: 0x1AACD11 VA: 0x1AACC10
	internal void .ctor(GlyphValueRecord_Legacy valueRecord) { }

	// RVA: 0x1AAC880 Offset: 0x1AAC981 VA: 0x1AAC880
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0x1AACC30 Offset: 0x1AACD31 VA: 0x1AACC30
	public static TMP_GlyphValueRecord op_Addition(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) { }
}

// Namespace: TMPro
[Serializable]
public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 7383
{
	// Fields
	[SerializeField] // RVA: 0x4D870 Offset: 0x4D971 VA: 0x4D870
	internal uint m_GlyphIndex; // 0x0
	[SerializeField] // RVA: 0x4D880 Offset: 0x4D981 VA: 0x4D880
	internal TMP_GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; set; }
	public TMP_GlyphValueRecord glyphValueRecord { get; set; }

	// Methods

	// RVA: 0x1AAC760 Offset: 0x1AAC861 VA: 0x1AAC760
	public uint get_glyphIndex() { }

	// RVA: 0x1AAC770 Offset: 0x1AAC871 VA: 0x1AAC770
	public void set_glyphIndex(uint value) { }

	// RVA: 0x1AAC780 Offset: 0x1AAC881 VA: 0x1AAC780
	public TMP_GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0x1AAC790 Offset: 0x1AAC891 VA: 0x1AAC790
	public void set_glyphValueRecord(TMP_GlyphValueRecord value) { }

	// RVA: 0x1AAC7B0 Offset: 0x1AAC8B1 VA: 0x1AAC7B0
	public void .ctor(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord) { }

	// RVA: 0x1AAC7D0 Offset: 0x1AAC8D1 VA: 0x1AAC7D0
	internal void .ctor(GlyphAdjustmentRecord adjustmentRecord) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 7384
{
	// Fields
	[SerializeField] // RVA: 0x4D890 Offset: 0x4D991 VA: 0x4D890
	internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
	[SerializeField] // RVA: 0x4D8A0 Offset: 0x4D9A1 VA: 0x4D8A0
	internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
	[SerializeField] // RVA: 0x4D8B0 Offset: 0x4D9B1 VA: 0x4D8B0
	internal FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38

	// Properties
	public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
	public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; }
	public FontFeatureLookupFlags featureLookupFlags { get; set; }

	// Methods

	// RVA: 0x1AAC8F0 Offset: 0x1AAC9F1 VA: 0x1AAC8F0
	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x1AAC910 Offset: 0x1AACA11 VA: 0x1AAC910
	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x1AAC930 Offset: 0x1AACA31 VA: 0x1AAC930
	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0x1AAC950 Offset: 0x1AACA51 VA: 0x1AAC950
	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x1AAC970 Offset: 0x1AACA71 VA: 0x1AAC970
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0x1AAC980 Offset: 0x1AACA81 VA: 0x1AAC980
	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	// RVA: 0x1AAC990 Offset: 0x1AACA91 VA: 0x1AAC990
	public void .ctor(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	// RVA: 0x1AAC9F0 Offset: 0x1AACAF1 VA: 0x1AAC9F0
	internal void .ctor(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }
}

// Namespace: TMPro
[AddComponentMenu] // RVA: 0x4CD60 Offset: 0x4CE61 VA: 0x4CD60
public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IScrollHandler // TypeDefIndex: 7399
{
	// Fields
	protected TouchScreenKeyboard m_SoftKeyboard; // 0xF8
	private static readonly char[] kSeparators; // 0x0
	protected RectTransform m_RectTransform; // 0x100
	[SerializeField] // RVA: 0x4D8C0 Offset: 0x4D9C1 VA: 0x4D8C0
	protected RectTransform m_TextViewport; // 0x108
	protected RectMask2D m_TextComponentRectMask; // 0x110
	protected RectMask2D m_TextViewportRectMask; // 0x118
	private Rect m_CachedViewportRect; // 0x120
	[SerializeField] // RVA: 0x4D8D0 Offset: 0x4D9D1 VA: 0x4D8D0
	protected TMP_Text m_TextComponent; // 0x130
	protected RectTransform m_TextComponentRectTransform; // 0x138
	[SerializeField] // RVA: 0x4D8E0 Offset: 0x4D9E1 VA: 0x4D8E0
	protected Graphic m_Placeholder; // 0x140
	[SerializeField] // RVA: 0x4D8F0 Offset: 0x4D9F1 VA: 0x4D8F0
	protected Scrollbar m_VerticalScrollbar; // 0x148
	[SerializeField] // RVA: 0x4D900 Offset: 0x4DA01 VA: 0x4D900
	protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x150
	private bool m_IsDrivenByLayoutComponents; // 0x158
	[SerializeField] // RVA: 0x4D910 Offset: 0x4DA11 VA: 0x4D910
	private LayoutGroup m_LayoutGroup; // 0x160
	private IScrollHandler m_IScrollHandlerParent; // 0x168
	private float m_ScrollPosition; // 0x170
	[SerializeField] // RVA: 0x4D920 Offset: 0x4DA21 VA: 0x4D920
	protected float m_ScrollSensitivity; // 0x174
	[SerializeField] // RVA: 0x4D930 Offset: 0x4DA31 VA: 0x4D930
	private TMP_InputField.ContentType m_ContentType; // 0x178
	[SerializeField] // RVA: 0x4D940 Offset: 0x4DA41 VA: 0x4D940
	private TMP_InputField.InputType m_InputType; // 0x17C
	[SerializeField] // RVA: 0x4D950 Offset: 0x4DA51 VA: 0x4D950
	private char m_AsteriskChar; // 0x180
	[SerializeField] // RVA: 0x4D960 Offset: 0x4DA61 VA: 0x4D960
	private TouchScreenKeyboardType m_KeyboardType; // 0x184
	[SerializeField] // RVA: 0x4D970 Offset: 0x4DA71 VA: 0x4D970
	private TMP_InputField.LineType m_LineType; // 0x188
	[SerializeField] // RVA: 0x4D980 Offset: 0x4DA81 VA: 0x4D980
	private bool m_HideMobileInput; // 0x18C
	[SerializeField] // RVA: 0x4D990 Offset: 0x4DA91 VA: 0x4D990
	private bool m_HideSoftKeyboard; // 0x18D
	[SerializeField] // RVA: 0x4D9A0 Offset: 0x4DAA1 VA: 0x4D9A0
	private TMP_InputField.CharacterValidation m_CharacterValidation; // 0x190
	[SerializeField] // RVA: 0x4D9B0 Offset: 0x4DAB1 VA: 0x4D9B0
	private string m_RegexValue; // 0x198
	[SerializeField] // RVA: 0x4D9C0 Offset: 0x4DAC1 VA: 0x4D9C0
	private float m_GlobalPointSize; // 0x1A0
	[SerializeField] // RVA: 0x4D9D0 Offset: 0x4DAD1 VA: 0x4D9D0
	private int m_CharacterLimit; // 0x1A4
	[SerializeField] // RVA: 0x4D9E0 Offset: 0x4DAE1 VA: 0x4D9E0
	private TMP_InputField.SubmitEvent m_OnEndEdit; // 0x1A8
	[SerializeField] // RVA: 0x4D9F0 Offset: 0x4DAF1 VA: 0x4D9F0
	private TMP_InputField.SubmitEvent m_OnSubmit; // 0x1B0
	[SerializeField] // RVA: 0x4DA00 Offset: 0x4DB01 VA: 0x4DA00
	private TMP_InputField.SelectionEvent m_OnSelect; // 0x1B8
	[SerializeField] // RVA: 0x4DA10 Offset: 0x4DB11 VA: 0x4DA10
	private TMP_InputField.SelectionEvent m_OnDeselect; // 0x1C0
	[SerializeField] // RVA: 0x4DA20 Offset: 0x4DB21 VA: 0x4DA20
	private TMP_InputField.TextSelectionEvent m_OnTextSelection; // 0x1C8
	[SerializeField] // RVA: 0x4DA30 Offset: 0x4DB31 VA: 0x4DA30
	private TMP_InputField.TextSelectionEvent m_OnEndTextSelection; // 0x1D0
	[SerializeField] // RVA: 0x4DA40 Offset: 0x4DB41 VA: 0x4DA40
	private TMP_InputField.OnChangeEvent m_OnValueChanged; // 0x1D8
	[SerializeField] // RVA: 0x4DA50 Offset: 0x4DB51 VA: 0x4DA50
	private TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x1E0
	[SerializeField] // RVA: 0x4DA60 Offset: 0x4DB61 VA: 0x4DA60
	private TMP_InputField.OnValidateInput m_OnValidateInput; // 0x1E8
	[SerializeField] // RVA: 0x4DA70 Offset: 0x4DB71 VA: 0x4DA70
	private Color m_CaretColor; // 0x1F0
	[SerializeField] // RVA: 0x4DA80 Offset: 0x4DB81 VA: 0x4DA80
	private bool m_CustomCaretColor; // 0x200
	[SerializeField] // RVA: 0x4DA90 Offset: 0x4DB91 VA: 0x4DA90
	private Color m_SelectionColor; // 0x204
	[SerializeField] // RVA: 0x4DAA0 Offset: 0x4DBA1 VA: 0x4DAA0
	[TextAreaAttribute] // RVA: 0x4DAA0 Offset: 0x4DBA1 VA: 0x4DAA0
	protected string m_Text; // 0x218
	[SerializeField] // RVA: 0x4DAE0 Offset: 0x4DBE1 VA: 0x4DAE0
	[RangeAttribute] // RVA: 0x4DAE0 Offset: 0x4DBE1 VA: 0x4DAE0
	private float m_CaretBlinkRate; // 0x220
	[RangeAttribute] // RVA: 0x4DB20 Offset: 0x4DC21 VA: 0x4DB20
	[SerializeField] // RVA: 0x4DB20 Offset: 0x4DC21 VA: 0x4DB20
	private int m_CaretWidth; // 0x224
	[SerializeField] // RVA: 0x4DB60 Offset: 0x4DC61 VA: 0x4DB60
	private bool m_ReadOnly; // 0x228
	[SerializeField] // RVA: 0x4DB70 Offset: 0x4DC71 VA: 0x4DB70
	private bool m_RichText; // 0x229
	protected int m_StringPosition; // 0x22C
	protected int m_StringSelectPosition; // 0x230
	protected int m_CaretPosition; // 0x234
	protected int m_CaretSelectPosition; // 0x238
	private RectTransform caretRectTrans; // 0x240
	protected UIVertex[] m_CursorVerts; // 0x248
	private CanvasRenderer m_CachedInputRenderer; // 0x250
	private Vector2 m_LastPosition; // 0x258
	protected Mesh m_Mesh; // 0x260
	private bool m_AllowInput; // 0x268
	private bool m_ShouldActivateNextUpdate; // 0x269
	private bool m_UpdateDrag; // 0x26A
	private bool m_DragPositionOutOfBounds; // 0x26B
	private const float kHScrollSpeed = 0.05;
	private const float kVScrollSpeed = 0.1;
	protected bool m_CaretVisible; // 0x26C
	private Coroutine m_BlinkCoroutine; // 0x270
	private float m_BlinkStartTime; // 0x278
	private Coroutine m_DragCoroutine; // 0x280
	private string m_OriginalText; // 0x288
	private bool m_WasCanceled; // 0x290
	private bool m_HasDoneFocusTransition; // 0x291
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x298
	private bool m_PreventCallback; // 0x2A0
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x2A1
	private bool m_IsTextComponentUpdateRequired; // 0x2A2
	private bool m_isLastKeyBackspace; // 0x2A3
	private float m_PointerDownClickStartTime; // 0x2A4
	private float m_KeyDownStartTime; // 0x2A8
	private float m_DoubleClickDelay; // 0x2AC
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private bool m_IsCompositionActive; // 0x2B0
	private bool m_ShouldUpdateIMEWindowPosition; // 0x2B1
	private int m_PreviousIMEInsertionLine; // 0x2B4
	[SerializeField] // RVA: 0x4DB80 Offset: 0x4DC81 VA: 0x4DB80
	protected TMP_FontAsset m_GlobalFontAsset; // 0x2B8
	[SerializeField] // RVA: 0x4DB90 Offset: 0x4DC91 VA: 0x4DB90
	protected bool m_OnFocusSelectAll; // 0x2C0
	protected bool m_isSelectAll; // 0x2C1
	[SerializeField] // RVA: 0x4DBA0 Offset: 0x4DCA1 VA: 0x4DBA0
	protected bool m_ResetOnDeActivation; // 0x2C2
	private bool m_SelectionStillActive; // 0x2C3
	private bool m_ReleaseSelection; // 0x2C4
	private GameObject m_PreviouslySelectedObject; // 0x2C8
	[SerializeField] // RVA: 0x4DBB0 Offset: 0x4DCB1 VA: 0x4DBB0
	private bool m_RestoreOriginalTextOnEscape; // 0x2D0
	[SerializeField] // RVA: 0x4DBC0 Offset: 0x4DCC1 VA: 0x4DBC0
	protected bool m_isRichTextEditingAllowed; // 0x2D1
	[SerializeField] // RVA: 0x4DBD0 Offset: 0x4DCD1 VA: 0x4DBD0
	protected int m_LineLimit; // 0x2D4
	[SerializeField] // RVA: 0x4DBE0 Offset: 0x4DCE1 VA: 0x4DBE0
	protected TMP_InputValidator m_InputValidator; // 0x2D8
	private bool m_isSelected; // 0x2E0
	private bool m_IsStringPositionDirty; // 0x2E1
	private bool m_IsCaretPositionDirty; // 0x2E2
	private bool m_forceRectTransformAdjustment; // 0x2E3
	private Event m_ProcessingEvent; // 0x2E8

	// Properties
	private BaseInput inputSystem { get; }
	private string compositionString { get; }
	private int compositionLength { get; }
	protected Mesh mesh { get; }
	public bool shouldHideMobileInput { get; set; }
	public bool shouldHideSoftKeyboard { get; set; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public RectTransform textViewport { get; set; }
	public TMP_Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public float scrollSensitivity { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public TMP_InputField.SubmitEvent onEndEdit { get; set; }
	public TMP_InputField.SubmitEvent onSubmit { get; set; }
	public TMP_InputField.SelectionEvent onSelect { get; set; }
	public TMP_InputField.SelectionEvent onDeselect { get; set; }
	public TMP_InputField.TextSelectionEvent onTextSelection { get; set; }
	public TMP_InputField.TextSelectionEvent onEndTextSelection { get; set; }
	public TMP_InputField.OnChangeEvent onValueChanged { get; set; }
	public TMP_InputField.TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get; set; }
	public TMP_InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public float pointSize { get; set; }
	public TMP_FontAsset fontAsset { get; set; }
	public bool onFocusSelectAll { get; set; }
	public bool resetOnDeActivation { get; set; }
	public bool restoreOriginalTextOnEscape { get; set; }
	public bool isRichTextEditingAllowed { get; set; }
	public TMP_InputField.ContentType contentType { get; set; }
	public TMP_InputField.LineType lineType { get; set; }
	public int lineLimit { get; set; }
	public TMP_InputField.InputType inputType { get; set; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public TMP_InputField.CharacterValidation characterValidation { get; set; }
	public TMP_InputValidator inputValidator { get; set; }
	public bool readOnly { get; set; }
	public bool richText { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int stringPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	protected int stringSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	public int stringPosition { get; set; }
	public int selectionStringAnchorPosition { get; set; }
	public int selectionStringFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x1AACC50 Offset: 0x1AACD51 VA: 0x1AACC50
	private BaseInput get_inputSystem() { }

	// RVA: 0x1AACDB0 Offset: 0x1AACEB1 VA: 0x1AACDB0
	private string get_compositionString() { }

	// RVA: 0x1AACE50 Offset: 0x1AACF51 VA: 0x1AACE50
	private int get_compositionLength() { }

	// RVA: 0x1AACE80 Offset: 0x1AACF81 VA: 0x1AACE80
	protected void .ctor() { }

	// RVA: 0x1AAD2D0 Offset: 0x1AAD3D1 VA: 0x1AAD2D0
	protected Mesh get_mesh() { }

	// RVA: 0x1AAD390 Offset: 0x1AAD491 VA: 0x1AAD390
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x1AAD3F0 Offset: 0x1AAD4F1 VA: 0x1AAD3F0
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x1AAD490 Offset: 0x1AAD591 VA: 0x1AAD490
	public bool get_shouldHideSoftKeyboard() { }

	// RVA: 0x1AAD540 Offset: 0x1AAD641 VA: 0x1AAD540
	public void set_shouldHideSoftKeyboard(bool value) { }

	// RVA: 0x1AAD680 Offset: 0x1AAD781 VA: 0x1AAD680
	private bool isKeyboardUsingEvents() { }

	// RVA: 0x1AAD6E0 Offset: 0x1AAD7E1 VA: 0x1AAD6E0
	public string get_text() { }

	// RVA: 0x1AAD6F0 Offset: 0x1AAD7F1 VA: 0x1AAD6F0
	public void set_text(string value) { }

	// RVA: 0x1AAD870 Offset: 0x1AAD971 VA: 0x1AAD870
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x1AAD700 Offset: 0x1AAD801 VA: 0x1AAD700
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0x1AADEB0 Offset: 0x1AADFB1 VA: 0x1AADEB0
	public bool get_isFocused() { }

	// RVA: 0x1AADEC0 Offset: 0x1AADFC1 VA: 0x1AADEC0
	public float get_caretBlinkRate() { }

	// RVA: 0x1AADED0 Offset: 0x1AADFD1 VA: 0x1AADED0
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x1AAE040 Offset: 0x1AAE141 VA: 0x1AAE040
	public int get_caretWidth() { }

	// RVA: 0x1AAE050 Offset: 0x1AAE151 VA: 0x1AAE050
	public void set_caretWidth(int value) { }

	// RVA: 0x1AAE180 Offset: 0x1AAE281 VA: 0x1AAE180
	public RectTransform get_textViewport() { }

	// RVA: 0x1AAE190 Offset: 0x1AAE291 VA: 0x1AAE190
	public void set_textViewport(RectTransform value) { }

	// RVA: 0x1AAE1F0 Offset: 0x1AAE2F1 VA: 0x1AAE1F0
	public TMP_Text get_textComponent() { }

	// RVA: 0x1AAE200 Offset: 0x1AAE301 VA: 0x1AAE200
	public void set_textComponent(TMP_Text value) { }

	// RVA: 0x1AAE280 Offset: 0x1AAE381 VA: 0x1AAE280
	public Graphic get_placeholder() { }

	// RVA: 0x1AAE290 Offset: 0x1AAE391 VA: 0x1AAE290
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1AAE2F0 Offset: 0x1AAE3F1 VA: 0x1AAE2F0
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x1AAE300 Offset: 0x1AAE401 VA: 0x1AAE300
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x1AAE4F0 Offset: 0x1AAE5F1 VA: 0x1AAE4F0
	public float get_scrollSensitivity() { }

	// RVA: 0x1AAE500 Offset: 0x1AAE601 VA: 0x1AAE500
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x1AAE5D0 Offset: 0x1AAE6D1 VA: 0x1AAE5D0
	public Color get_caretColor() { }

	// RVA: 0x1AAE620 Offset: 0x1AAE721 VA: 0x1AAE620
	public void set_caretColor(Color value) { }

	// RVA: 0x1AAE6B0 Offset: 0x1AAE7B1 VA: 0x1AAE6B0
	public bool get_customCaretColor() { }

	// RVA: 0x1AAE6C0 Offset: 0x1AAE7C1 VA: 0x1AAE6C0
	public void set_customCaretColor(bool value) { }

	// RVA: 0x1AAE760 Offset: 0x1AAE861 VA: 0x1AAE760
	public Color get_selectionColor() { }

	// RVA: 0x1AAE780 Offset: 0x1AAE881 VA: 0x1AAE780
	public void set_selectionColor(Color value) { }

	// RVA: 0x1AAE810 Offset: 0x1AAE911 VA: 0x1AAE810
	public TMP_InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0x1AAE820 Offset: 0x1AAE921 VA: 0x1AAE820
	public void set_onEndEdit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0x1AAE880 Offset: 0x1AAE981 VA: 0x1AAE880
	public TMP_InputField.SubmitEvent get_onSubmit() { }

	// RVA: 0x1AAE890 Offset: 0x1AAE991 VA: 0x1AAE890
	public void set_onSubmit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0x1AAE8F0 Offset: 0x1AAE9F1 VA: 0x1AAE8F0
	public TMP_InputField.SelectionEvent get_onSelect() { }

	// RVA: 0x1AAE900 Offset: 0x1AAEA01 VA: 0x1AAE900
	public void set_onSelect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x1AAE960 Offset: 0x1AAEA61 VA: 0x1AAE960
	public TMP_InputField.SelectionEvent get_onDeselect() { }

	// RVA: 0x1AAE970 Offset: 0x1AAEA71 VA: 0x1AAE970
	public void set_onDeselect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x1AAE9D0 Offset: 0x1AAEAD1 VA: 0x1AAE9D0
	public TMP_InputField.TextSelectionEvent get_onTextSelection() { }

	// RVA: 0x1AAE9E0 Offset: 0x1AAEAE1 VA: 0x1AAE9E0
	public void set_onTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0x1AAEA40 Offset: 0x1AAEB41 VA: 0x1AAEA40
	public TMP_InputField.TextSelectionEvent get_onEndTextSelection() { }

	// RVA: 0x1AAEA50 Offset: 0x1AAEB51 VA: 0x1AAEA50
	public void set_onEndTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0x1AAEAB0 Offset: 0x1AAEBB1 VA: 0x1AAEAB0
	public TMP_InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x1AAEAC0 Offset: 0x1AAEBC1 VA: 0x1AAEAC0
	public void set_onValueChanged(TMP_InputField.OnChangeEvent value) { }

	// RVA: 0x1AAEB20 Offset: 0x1AAEC21 VA: 0x1AAEB20
	public TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }

	// RVA: 0x1AAEB30 Offset: 0x1AAEC31 VA: 0x1AAEB30
	public void set_onTouchScreenKeyboardStatusChanged(TMP_InputField.TouchScreenKeyboardEvent value) { }

	// RVA: 0x1AAEB90 Offset: 0x1AAEC91 VA: 0x1AAEB90
	public TMP_InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x1AAEBA0 Offset: 0x1AAECA1 VA: 0x1AAEBA0
	public void set_onValidateInput(TMP_InputField.OnValidateInput value) { }

	// RVA: 0x1AAEC00 Offset: 0x1AAED01 VA: 0x1AAEC00
	public int get_characterLimit() { }

	// RVA: 0x1AAEC10 Offset: 0x1AAED11 VA: 0x1AAEC10
	public void set_characterLimit(int value) { }

	// RVA: 0x1AAECF0 Offset: 0x1AAEDF1 VA: 0x1AAECF0
	public float get_pointSize() { }

	// RVA: 0x1AAED00 Offset: 0x1AAEE01 VA: 0x1AAED00
	public void set_pointSize(float value) { }

	// RVA: 0x1AAEED0 Offset: 0x1AAEFD1 VA: 0x1AAEED0
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x1AAEEE0 Offset: 0x1AAEFE1 VA: 0x1AAEEE0
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x1AAF070 Offset: 0x1AAF171 VA: 0x1AAF070
	public bool get_onFocusSelectAll() { }

	// RVA: 0x1AAF080 Offset: 0x1AAF181 VA: 0x1AAF080
	public void set_onFocusSelectAll(bool value) { }

	// RVA: 0x1AAF090 Offset: 0x1AAF191 VA: 0x1AAF090
	public bool get_resetOnDeActivation() { }

	// RVA: 0x1AAF0A0 Offset: 0x1AAF1A1 VA: 0x1AAF0A0
	public void set_resetOnDeActivation(bool value) { }

	// RVA: 0x1AAF0B0 Offset: 0x1AAF1B1 VA: 0x1AAF0B0
	public bool get_restoreOriginalTextOnEscape() { }

	// RVA: 0x1AAF0C0 Offset: 0x1AAF1C1 VA: 0x1AAF0C0
	public void set_restoreOriginalTextOnEscape(bool value) { }

	// RVA: 0x1AAF0D0 Offset: 0x1AAF1D1 VA: 0x1AAF0D0
	public bool get_isRichTextEditingAllowed() { }

	// RVA: 0x1AAF0E0 Offset: 0x1AAF1E1 VA: 0x1AAF0E0
	public void set_isRichTextEditingAllowed(bool value) { }

	// RVA: 0x1AAF0F0 Offset: 0x1AAF1F1 VA: 0x1AAF0F0
	public TMP_InputField.ContentType get_contentType() { }

	// RVA: 0x1AAF100 Offset: 0x1AAF201 VA: 0x1AAF100
	public void set_contentType(TMP_InputField.ContentType value) { }

	// RVA: 0x1AAF300 Offset: 0x1AAF401 VA: 0x1AAF300
	public TMP_InputField.LineType get_lineType() { }

	// RVA: 0x1AAF310 Offset: 0x1AAF411 VA: 0x1AAF310
	public void set_lineType(TMP_InputField.LineType value) { }

	// RVA: 0x1AAF480 Offset: 0x1AAF581 VA: 0x1AAF480
	public int get_lineLimit() { }

	// RVA: 0x1AAF490 Offset: 0x1AAF591 VA: 0x1AAF490
	public void set_lineLimit(int value) { }

	// RVA: 0x1AAF510 Offset: 0x1AAF611 VA: 0x1AAF510
	public TMP_InputField.InputType get_inputType() { }

	// RVA: 0x1AAF520 Offset: 0x1AAF621 VA: 0x1AAF520
	public void set_inputType(TMP_InputField.InputType value) { }

	// RVA: 0x1AAF5D0 Offset: 0x1AAF6D1 VA: 0x1AAF5D0
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x1AAF5E0 Offset: 0x1AAF6E1 VA: 0x1AAF5E0
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x1AAF670 Offset: 0x1AAF771 VA: 0x1AAF670
	public TMP_InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x1AAF680 Offset: 0x1AAF781 VA: 0x1AAF680
	public void set_characterValidation(TMP_InputField.CharacterValidation value) { }

	// RVA: 0x1AAF710 Offset: 0x1AAF811 VA: 0x1AAF710
	public TMP_InputValidator get_inputValidator() { }

	// RVA: 0x1AAF720 Offset: 0x1AAF821 VA: 0x1AAF720
	public void set_inputValidator(TMP_InputValidator value) { }

	// RVA: 0x1AAF7D0 Offset: 0x1AAF8D1 VA: 0x1AAF7D0
	public bool get_readOnly() { }

	// RVA: 0x1AAF7E0 Offset: 0x1AAF8E1 VA: 0x1AAF7E0
	public void set_readOnly(bool value) { }

	// RVA: 0x1AAF7F0 Offset: 0x1AAF8F1 VA: 0x1AAF7F0
	public bool get_richText() { }

	// RVA: 0x1AAF800 Offset: 0x1AAF901 VA: 0x1AAF800
	public void set_richText(bool value) { }

	// RVA: 0x1AAF940 Offset: 0x1AAFA41 VA: 0x1AAF940
	public bool get_multiLine() { }

	// RVA: 0x1AAF960 Offset: 0x1AAFA61 VA: 0x1AAF960
	public char get_asteriskChar() { }

	// RVA: 0x1AAF970 Offset: 0x1AAFA71 VA: 0x1AAF970
	public void set_asteriskChar(char value) { }

	// RVA: 0x1AAF9F0 Offset: 0x1AAFAF1 VA: 0x1AAF9F0
	public bool get_wasCanceled() { }

	// RVA: 0x1AAFA00 Offset: 0x1AAFB01 VA: 0x1AAFA00
	protected void ClampStringPos(ref int pos) { }

	// RVA: 0x1AAFA30 Offset: 0x1AAFB31 VA: 0x1AAFA30
	protected void ClampCaretPos(ref int pos) { }

	// RVA: 0x1AAFA60 Offset: 0x1AAFB61 VA: 0x1AAFA60
	protected int get_caretPositionInternal() { }

	// RVA: 0x1AAFAB0 Offset: 0x1AAFBB1 VA: 0x1AAFAB0
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x1AAFAE0 Offset: 0x1AAFBE1 VA: 0x1AAFAE0
	protected int get_stringPositionInternal() { }

	// RVA: 0x1AAFB30 Offset: 0x1AAFC31 VA: 0x1AAFB30
	protected void set_stringPositionInternal(int value) { }

	// RVA: 0x1AAFB60 Offset: 0x1AAFC61 VA: 0x1AAFB60
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x1AAFBB0 Offset: 0x1AAFCB1 VA: 0x1AAFBB0
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x1AAFBE0 Offset: 0x1AAFCE1 VA: 0x1AAFBE0
	protected int get_stringSelectPositionInternal() { }

	// RVA: 0x1AAFC30 Offset: 0x1AAFD31 VA: 0x1AAFC30
	protected void set_stringSelectPositionInternal(int value) { }

	// RVA: 0x1AAFC60 Offset: 0x1AAFD61 VA: 0x1AAFC60
	private bool get_hasSelection() { }

	// RVA: 0x1AAFCD0 Offset: 0x1AAFDD1 VA: 0x1AAFCD0
	public int get_caretPosition() { }

	// RVA: 0x1AAFD20 Offset: 0x1AAFE21 VA: 0x1AAFD20
	public void set_caretPosition(int value) { }

	// RVA: 0x1AAFEF0 Offset: 0x1AAFFF1 VA: 0x1AAFEF0
	public int get_selectionAnchorPosition() { }

	// RVA: 0x1AAFDF0 Offset: 0x1AAFEF1 VA: 0x1AAFDF0
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x1AAFF40 Offset: 0x1AB0041 VA: 0x1AAFF40
	public int get_selectionFocusPosition() { }

	// RVA: 0x1AAFE70 Offset: 0x1AAFF71 VA: 0x1AAFE70
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x1AAFF90 Offset: 0x1AB0091 VA: 0x1AAFF90
	public int get_stringPosition() { }

	// RVA: 0x1AAFFE0 Offset: 0x1AB00E1 VA: 0x1AAFFE0
	public void set_stringPosition(int value) { }

	// RVA: 0x1AB0180 Offset: 0x1AB0281 VA: 0x1AB0180
	public int get_selectionStringAnchorPosition() { }

	// RVA: 0x1AB00A0 Offset: 0x1AB01A1 VA: 0x1AB00A0
	public void set_selectionStringAnchorPosition(int value) { }

	// RVA: 0x1AB01D0 Offset: 0x1AB02D1 VA: 0x1AB01D0
	public int get_selectionStringFocusPosition() { }

	// RVA: 0x1AB0110 Offset: 0x1AB0211 VA: 0x1AB0110
	public void set_selectionStringFocusPosition(int value) { }

	// RVA: 0x1AB0220 Offset: 0x1AB0321 VA: 0x1AB0220 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1AB0E70 Offset: 0x1AB0F71 VA: 0x1AB0E70 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1AB1440 Offset: 0x1AB1541 VA: 0x1AB1440
	private void ON_TEXT_CHANGED(Object obj) { }

	[IteratorStateMachineAttribute] // RVA: 0x4E700 Offset: 0x4E801 VA: 0x4E700
	// RVA: 0x1AB1800 Offset: 0x1AB1901 VA: 0x1AB1800
	private IEnumerator CaretBlink() { }

	// RVA: 0x1AB1880 Offset: 0x1AB1981 VA: 0x1AB1880
	private void SetCaretVisible() { }

	// RVA: 0x1AADF60 Offset: 0x1AAE061 VA: 0x1AADF60
	private void SetCaretActive() { }

	// RVA: 0x1AB18D0 Offset: 0x1AB19D1 VA: 0x1AB18D0
	protected void OnFocus() { }

	// RVA: 0x1AB1920 Offset: 0x1AB1A21 VA: 0x1AB1920
	protected void SelectAll() { }

	// RVA: 0x1AB1970 Offset: 0x1AB1A71 VA: 0x1AB1970
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x1AB1C20 Offset: 0x1AB1D21 VA: 0x1AB1C20
	public void MoveTextStart(bool shift) { }

	// RVA: 0x1AB1DF0 Offset: 0x1AB1EF1 VA: 0x1AB1DF0
	public void MoveToEndOfLine(bool shift, bool ctrl) { }

	// RVA: 0x1AB1FF0 Offset: 0x1AB20F1 VA: 0x1AB1FF0
	public void MoveToStartOfLine(bool shift, bool ctrl) { }

	// RVA: 0x1AB2210 Offset: 0x1AB2311 VA: 0x1AB2210
	private static string get_clipboard() { }

	// RVA: 0x1AB2220 Offset: 0x1AB2321 VA: 0x1AB2220
	private static void set_clipboard(string value) { }

	// RVA: 0x1AB2230 Offset: 0x1AB2331 VA: 0x1AB2230
	private bool InPlaceEditing() { }

	// RVA: 0x1AB23F0 Offset: 0x1AB24F1 VA: 0x1AB23F0
	private void UpdateStringPositionFromKeyboard() { }

	// RVA: 0x1AB2680 Offset: 0x1AB2781 VA: 0x1AB2680 Slot: 60
	protected virtual void LateUpdate() { }

	// RVA: 0x1AB3E40 Offset: 0x1AB3F41 VA: 0x1AB3E40
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1AB3FF0 Offset: 0x1AB40F1 VA: 0x1AB3FF0 Slot: 61
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1AB4020 Offset: 0x1AB4121 VA: 0x1AB4020 Slot: 62
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachineAttribute] // RVA: 0x4E770 Offset: 0x4E871 VA: 0x4E770
	// RVA: 0x1AB43E0 Offset: 0x1AB44E1 VA: 0x1AB43E0
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x1AB4470 Offset: 0x1AB4571 VA: 0x1AB4470 Slot: 63
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1AB44A0 Offset: 0x1AB45A1 VA: 0x1AB44A0 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1AB4C90 Offset: 0x1AB4D91 VA: 0x1AB4C90
	protected TMP_InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x1AB6B80 Offset: 0x1AB6C81 VA: 0x1AB6B80 Slot: 64
	protected virtual bool IsValidChar(char c) { }

	// RVA: 0x1AB6BA0 Offset: 0x1AB6CA1 VA: 0x1AB6BA0
	public void ProcessEvent(Event e) { }

	// RVA: 0x1AB6BB0 Offset: 0x1AB6CB1 VA: 0x1AB6BB0 Slot: 65
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x1AB6E20 Offset: 0x1AB6F21 VA: 0x1AB6E20 Slot: 66
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x1AB6FE0 Offset: 0x1AB70E1 VA: 0x1AB6FE0
	private float GetScrollPositionRelativeToViewport() { }

	// RVA: 0x1AB5B20 Offset: 0x1AB5C21 VA: 0x1AB5B20
	private string GetSelectedString() { }

	// RVA: 0x1AB72B0 Offset: 0x1AB73B1 VA: 0x1AB72B0
	private int FindNextWordBegin() { }

	// RVA: 0x1AB64C0 Offset: 0x1AB65C1 VA: 0x1AB64C0
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x1AB73B0 Offset: 0x1AB74B1 VA: 0x1AB73B0
	private int FindPrevWordBegin() { }

	// RVA: 0x1AB5E90 Offset: 0x1AB5F91 VA: 0x1AB5E90
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x1AB74A0 Offset: 0x1AB75A1 VA: 0x1AB74A0
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x1AB75F0 Offset: 0x1AB76F1 VA: 0x1AB75F0
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x1AB7740 Offset: 0x1AB7841 VA: 0x1AB7740
	private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x1AB7930 Offset: 0x1AB7A31 VA: 0x1AB7930
	private int PageDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x1AB6B50 Offset: 0x1AB6C51 VA: 0x1AB6B50
	private void MoveDown(bool shift) { }

	// RVA: 0x1AB7B30 Offset: 0x1AB7C31 VA: 0x1AB7B30
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x1AB6B40 Offset: 0x1AB6C41 VA: 0x1AB6B40
	private void MoveUp(bool shift) { }

	// RVA: 0x1AB7EB0 Offset: 0x1AB7FB1 VA: 0x1AB7EB0
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x1AB6B60 Offset: 0x1AB6C61 VA: 0x1AB6B60
	private void MovePageUp(bool shift) { }

	// RVA: 0x1AB8230 Offset: 0x1AB8331 VA: 0x1AB8230
	private void MovePageUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x1AB6B70 Offset: 0x1AB6C71 VA: 0x1AB6B70
	private void MovePageDown(bool shift) { }

	// RVA: 0x1AB86D0 Offset: 0x1AB87D1 VA: 0x1AB86D0
	private void MovePageDown(bool shift, bool goToLastChar) { }

	// RVA: 0x1AB5C40 Offset: 0x1AB5D41 VA: 0x1AB5C40
	private void Delete() { }

	// RVA: 0x1AB57A0 Offset: 0x1AB58A1 VA: 0x1AB57A0
	private void DeleteKey() { }

	// RVA: 0x1AB5180 Offset: 0x1AB5281 VA: 0x1AB5180
	private void Backspace() { }

	// RVA: 0x1AB8B80 Offset: 0x1AB8C81 VA: 0x1AB8B80 Slot: 67
	protected virtual void Append(string input) { }

	// RVA: 0x1AB8C40 Offset: 0x1AB8D41 VA: 0x1AB8C40 Slot: 68
	protected virtual void Append(char input) { }

	// RVA: 0x1AB8F10 Offset: 0x1AB9011 VA: 0x1AB8F10
	private void Insert(char c) { }

	// RVA: 0x1AB5E40 Offset: 0x1AB5F41 VA: 0x1AB5E40
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x1AB3DD0 Offset: 0x1AB3ED1 VA: 0x1AB3DD0
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x1AADE50 Offset: 0x1AADF51 VA: 0x1AADE50
	private void SendOnValueChanged() { }

	// RVA: 0x1AB9080 Offset: 0x1AB9181 VA: 0x1AB9080
	protected void SendOnEndEdit() { }

	// RVA: 0x1AB6DC0 Offset: 0x1AB6EC1 VA: 0x1AB6DC0
	protected void SendOnSubmit() { }

	// RVA: 0x1AB90E0 Offset: 0x1AB91E1 VA: 0x1AB90E0
	protected void SendOnFocus() { }

	// RVA: 0x1AB9140 Offset: 0x1AB9241 VA: 0x1AB9140
	protected void SendOnFocusLost() { }

	// RVA: 0x1AB91A0 Offset: 0x1AB92A1 VA: 0x1AB91A0
	protected void SendOnTextSelection() { }

	// RVA: 0x1AB9270 Offset: 0x1AB9371 VA: 0x1AB9270
	protected void SendOnEndTextSelection() { }

	// RVA: 0x1AB34F0 Offset: 0x1AB35F1 VA: 0x1AB34F0
	protected void SendTouchScreenKeyboardStatusChanged() { }

	// RVA: 0x1AAD880 Offset: 0x1AAD981 VA: 0x1AAD880
	protected void UpdateLabel() { }

	// RVA: 0x1AB1700 Offset: 0x1AB1801 VA: 0x1AB1700
	private void UpdateScrollbar() { }

	// RVA: 0x1AB9340 Offset: 0x1AB9441 VA: 0x1AB9340
	private void OnScrollbarValueChange(float value) { }

	// RVA: 0x1AB0E60 Offset: 0x1AB0F61 VA: 0x1AB0E60
	private void UpdateMaskRegions() { }

	// RVA: 0x1AB70E0 Offset: 0x1AB71E1 VA: 0x1AB70E0
	private void AdjustTextPositionRelativeToViewport(float relativePosition) { }

	// RVA: 0x1AB1690 Offset: 0x1AB1791 VA: 0x1AB1690
	private int GetCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x1AB9390 Offset: 0x1AB9491 VA: 0x1AB9390
	private int GetMinCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x1AB9410 Offset: 0x1AB9511 VA: 0x1AB9410
	private int GetMaxCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x1AB1BB0 Offset: 0x1AB1CB1 VA: 0x1AB1BB0
	private int GetStringIndexFromCaretPosition(int caretPosition) { }

	// RVA: 0x1AB9480 Offset: 0x1AB9581 VA: 0x1AB9480
	public void ForceLabelUpdate() { }

	// RVA: 0x1AAE110 Offset: 0x1AAE211 VA: 0x1AAE110
	private void MarkGeometryAsDirty() { }

	// RVA: 0x1AB9490 Offset: 0x1AB9591 VA: 0x1AB9490 Slot: 69
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1AB9560 Offset: 0x1AB9661 VA: 0x1AB9560 Slot: 70
	public virtual void LayoutComplete() { }

	// RVA: 0x1AB9570 Offset: 0x1AB9671 VA: 0x1AB9570 Slot: 71
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1AB94A0 Offset: 0x1AB95A1 VA: 0x1AB94A0
	private void UpdateGeometry() { }

	// RVA: 0x1AB09E0 Offset: 0x1AB0AE1 VA: 0x1AB09E0
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x1AB9580 Offset: 0x1AB9681 VA: 0x1AB9580
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x1AB9AE0 Offset: 0x1AB9BE1 VA: 0x1AB9AE0
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x1ABA890 Offset: 0x1ABA991 VA: 0x1ABA890
	private void CreateCursorVerts() { }

	// RVA: 0x1ABA120 Offset: 0x1ABA221 VA: 0x1ABA120
	private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x1ABAA60 Offset: 0x1ABAB61 VA: 0x1ABAA60
	private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) { }

	// RVA: 0x1AB3570 Offset: 0x1AB3671 VA: 0x1AB3570
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x1ABAF40 Offset: 0x1ABB041 VA: 0x1ABAF40
	public void ActivateInputField() { }

	// RVA: 0x1AB2DF0 Offset: 0x1AB2EF1 VA: 0x1AB2DF0
	private void ActivateInputFieldInternal() { }

	// RVA: 0x1ABB060 Offset: 0x1ABB161 VA: 0x1ABB060 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1ABB0D0 Offset: 0x1ABB1D1 VA: 0x1ABB0D0 Slot: 72
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1ABB0E0 Offset: 0x1ABB1E1 VA: 0x1ABB0E0
	public void OnControlClick() { }

	// RVA: 0x1AB3420 Offset: 0x1AB3521 VA: 0x1AB3420
	public void ReleaseSelection() { }

	// RVA: 0x1AB1210 Offset: 0x1AB1311 VA: 0x1AB1210
	public void DeactivateInputField(bool clearSelection = False) { }

	// RVA: 0x1ABB0F0 Offset: 0x1ABB1F1 VA: 0x1ABB0F0 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1ABB170 Offset: 0x1ABB271 VA: 0x1ABB170 Slot: 73
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1AAF240 Offset: 0x1AAF341 VA: 0x1AAF240
	private void EnforceContentType() { }

	// RVA: 0x1AAD220 Offset: 0x1AAD321 VA: 0x1AAD220
	private void SetTextComponentWrapMode() { }

	// RVA: 0x1AAF8A0 Offset: 0x1AAF9A1 VA: 0x1AAF8A0
	private void SetTextComponentRichTextMode() { }

	// RVA: 0x1AAF410 Offset: 0x1AAF511 VA: 0x1AAF410
	private void SetToCustomIfContentTypeIsNot(TMP_InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x1AAF5B0 Offset: 0x1AAF6B1 VA: 0x1AAF5B0
	private void SetToCustom() { }

	// RVA: 0x1AAF7B0 Offset: 0x1AAF8B1 VA: 0x1AAF7B0
	private void SetToCustom(TMP_InputField.CharacterValidation characterValidation) { }

	// RVA: 0x1ABB220 Offset: 0x1ABB321 VA: 0x1ABB220 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x1ABB260 Offset: 0x1ABB361 VA: 0x1ABB260 Slot: 74
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1ABB270 Offset: 0x1ABB371 VA: 0x1ABB270 Slot: 75
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1ABB280 Offset: 0x1ABB381 VA: 0x1ABB280 Slot: 76
	public virtual float get_minWidth() { }

	// RVA: 0x1ABB290 Offset: 0x1ABB391 VA: 0x1ABB290 Slot: 77
	public virtual float get_preferredWidth() { }

	// RVA: 0x1ABB3F0 Offset: 0x1ABB4F1 VA: 0x1ABB3F0 Slot: 78
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1ABB400 Offset: 0x1ABB501 VA: 0x1ABB400 Slot: 79
	public virtual float get_minHeight() { }

	// RVA: 0x1ABB410 Offset: 0x1ABB511 VA: 0x1ABB410 Slot: 80
	public virtual float get_preferredHeight() { }

	// RVA: 0x1ABB570 Offset: 0x1ABB671 VA: 0x1ABB570 Slot: 81
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1ABB580 Offset: 0x1ABB681 VA: 0x1ABB580 Slot: 82
	public virtual int get_layoutPriority() { }

	// RVA: 0x1AAEDD0 Offset: 0x1AAEED1 VA: 0x1AAEDD0
	public void SetGlobalPointSize(float pointSize) { }

	// RVA: 0x1AAEF70 Offset: 0x1AAF071 VA: 0x1AAEF70
	public void SetGlobalFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x1ABB590 Offset: 0x1ABB691 VA: 0x1ABB590
	private static void .cctor() { }

	// RVA: 0x1ABB630 Offset: 0x1ABB731 VA: 0x1ABB630 Slot: 46
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: TMPro
[Serializable]
public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 7401
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract char Validate(ref string text, ref int pos, char ch);

	// RVA: 0x1ABB640 Offset: 0x1ABB741 VA: 0x1ABB640
	protected void .ctor() { }
}

// Namespace: TMPro
public struct TMP_LineInfo // TypeDefIndex: 7402
{
	// Fields
	internal int controlCharacterCount; // 0x0
	public int characterCount; // 0x4
	public int visibleCharacterCount; // 0x8
	public int spaceCount; // 0xC
	public int wordCount; // 0x10
	public int firstCharacterIndex; // 0x14
	public int firstVisibleCharacterIndex; // 0x18
	public int lastCharacterIndex; // 0x1C
	public int lastVisibleCharacterIndex; // 0x20
	public float length; // 0x24
	public float lineHeight; // 0x28
	public float ascender; // 0x2C
	public float baseline; // 0x30
	public float descender; // 0x34
	public float maxAdvance; // 0x38
	public float width; // 0x3C
	public float marginLeft; // 0x40
	public float marginRight; // 0x44
	public HorizontalAlignmentOptions alignment; // 0x48
	public Extents lineExtents; // 0x4C
}

// Namespace: TMPro
internal static class TMP_ListPool<T> // TypeDefIndex: 7404
{
	// Fields
	private static readonly TMP_ObjectPool<List<T>> s_ListPool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3670 Offset: 0x34B3771 VA: 0x34B3670
	|-TMP_ListPool<Canvas>.Get
	|-TMP_ListPool<IMaterialModifier>.Get
	|-TMP_ListPool<Mask>.Get
	|-TMP_ListPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3800 Offset: 0x34B3901 VA: 0x34B3800
	|-TMP_ListPool<Canvas>.Release
	|-TMP_ListPool<IMaterialModifier>.Release
	|-TMP_ListPool<Mask>.Release
	|-TMP_ListPool<object>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3990 Offset: 0x34B3A91 VA: 0x34B3990
	|-TMP_ListPool<object>..cctor
	*/
}

// Namespace: TMPro
public static class TMP_MaterialManager // TypeDefIndex: 7411
{
	// Fields
	private static List<TMP_MaterialManager.MaskingMaterial> m_materialList; // 0x0
	private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials; // 0x8
	private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
	private static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList; // 0x18
	private static bool isFallbackListDirty; // 0x20

	// Methods

	// RVA: 0x1ABB8F0 Offset: 0x1ABB9F1 VA: 0x1ABB8F0
	private static void .cctor() { }

	// RVA: 0x1ABBAE0 Offset: 0x1ABBBE1 VA: 0x1ABBAE0
	private static void OnPreRender() { }

	// RVA: 0x1ABBDD0 Offset: 0x1ABBED1 VA: 0x1ABBDD0
	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	// RVA: 0x1ABC1B0 Offset: 0x1ABC2B1 VA: 0x1ABC1B0
	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x1ABC420 Offset: 0x1ABC521 VA: 0x1ABC420
	public static Material GetBaseMaterial(Material stencilMaterial) { }

	// RVA: 0x1ABC5C0 Offset: 0x1ABC6C1 VA: 0x1ABC5C0
	public static Material SetStencil(Material material, int stencilID) { }

	// RVA: 0x1ABC6A0 Offset: 0x1ABC7A1 VA: 0x1ABC6A0
	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	// RVA: 0x1ABC940 Offset: 0x1ABCA41 VA: 0x1ABC940
	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x1ABCAE0 Offset: 0x1ABCBE1 VA: 0x1ABCAE0
	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	// RVA: 0x1ABD120 Offset: 0x1ABD221 VA: 0x1ABD120
	public static void ClearMaterials() { }

	// RVA: 0x1ABD330 Offset: 0x1ABD431 VA: 0x1ABD330
	public static int GetStencilID(GameObject obj) { }

	// RVA: 0x1ABD7F0 Offset: 0x1ABD8F1 VA: 0x1ABD7F0
	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	// RVA: 0x1ABD630 Offset: 0x1ABD731 VA: 0x1ABD630
	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x1ABDA00 Offset: 0x1ABDB01 VA: 0x1ABDA00
	internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x1ABDF60 Offset: 0x1ABE061 VA: 0x1ABDF60
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x1ABE3B0 Offset: 0x1ABE4B1 VA: 0x1ABE3B0
	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x1ABE510 Offset: 0x1ABE611 VA: 0x1ABE510
	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x1ABBB70 Offset: 0x1ABBC71 VA: 0x1ABBB70
	public static void CleanupFallbackMaterials() { }

	// RVA: 0x1ABE6B0 Offset: 0x1ABE7B1 VA: 0x1ABE6B0
	public static void ReleaseFallbackMaterial(Material fallbackMaterial) { }

	// RVA: 0x1ABDCE0 Offset: 0x1ABDDE1 VA: 0x1ABDCE0
	public static void CopyMaterialPresetProperties(Material source, Material destination) { }
}

// Namespace: TMPro
public struct TMP_MeshInfo // TypeDefIndex: 7413
{
	// Fields
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x4
	private static readonly Vector4 s_DefaultTangent; // 0x10
	private static readonly Bounds s_DefaultBounds; // 0x20
	public Mesh mesh; // 0x0
	public int vertexCount; // 0x8
	public Vector3[] vertices; // 0x10
	public Vector3[] normals; // 0x18
	public Vector4[] tangents; // 0x20
	public Vector2[] uvs0; // 0x28
	public Vector2[] uvs2; // 0x30
	public Color32[] colors32; // 0x38
	public int[] triangles; // 0x40
	public Material material; // 0x48

	// Methods

	// RVA: 0x18F1620 Offset: 0x18F1721 VA: 0x18F1620
	public void .ctor(Mesh mesh, int size) { }

	// RVA: 0x18F1B90 Offset: 0x18F1C91 VA: 0x18F1B90
	public void .ctor(Mesh mesh, int size, bool isVolumetric) { }

	// RVA: 0x18F2470 Offset: 0x18F2571 VA: 0x18F2470
	public void ResizeMeshInfo(int size) { }

	// RVA: 0x18F2900 Offset: 0x18F2A01 VA: 0x18F2900
	public void ResizeMeshInfo(int size, bool isVolumetric) { }

	// RVA: 0x18F3300 Offset: 0x18F3401 VA: 0x18F3300
	public void Clear() { }

	// RVA: 0x18F33C0 Offset: 0x18F34C1 VA: 0x18F33C0
	public void Clear(bool uploadChanges) { }

	// RVA: 0x18F3500 Offset: 0x18F3601 VA: 0x18F3500
	public void ClearUnusedVertices() { }

	// RVA: 0x18F3530 Offset: 0x18F3631 VA: 0x18F3530
	public void ClearUnusedVertices(int startIndex) { }

	// RVA: 0x18F3550 Offset: 0x18F3651 VA: 0x18F3550
	public void ClearUnusedVertices(int startIndex, bool updateMesh) { }

	// RVA: 0x18F3620 Offset: 0x18F3721 VA: 0x18F3620
	public void SortGeometry(VertexSortingOrder order) { }

	// RVA: 0x18F3C60 Offset: 0x18F3D61 VA: 0x18F3C60
	public void SortGeometry(IList<int> sortingOrder) { }

	// RVA: 0x18F36B0 Offset: 0x18F37B1 VA: 0x18F36B0
	public void SwapVertexData(int src, int dst) { }

	// RVA: 0x18F3E40 Offset: 0x18F3F41 VA: 0x18F3E40
	private static void .cctor() { }
}

// Namespace: TMPro
internal class TMP_ObjectPool<T> // TypeDefIndex: 7414
{
	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x4DBF0 Offset: 0x4DCF1 VA: 0x4DBF0
	private int <countAll>k__BackingField; // 0x0

	// Properties
	public int countAll { get; set; }
	public int countActive { get; }
	public int countInactive { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x4E880 Offset: 0x4E981 VA: 0x4E880
	// RVA: -1 Offset: -1
	public int get_countAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3C40 Offset: 0x34B3D41 VA: 0x34B3C40
	|-TMP_ObjectPool<object>.get_countAll
	*/

	[CompilerGeneratedAttribute] // RVA: 0x4E890 Offset: 0x4E991 VA: 0x4E890
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3C50 Offset: 0x34B3D51 VA: 0x34B3C50
	|-TMP_ObjectPool<object>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3C60 Offset: 0x34B3D61 VA: 0x34B3C60
	|-TMP_ObjectPool<object>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3CC0 Offset: 0x34B3DC1 VA: 0x34B3CC0
	|-TMP_ObjectPool<object>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3CE0 Offset: 0x34B3DE1 VA: 0x34B3CE0
	|-TMP_ObjectPool<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3D90 Offset: 0x34B3E91 VA: 0x34B3D90
	|-TMP_ObjectPool<object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3E70 Offset: 0x34B3F71 VA: 0x34B3E70
	|-TMP_ObjectPool<object>.Release
	*/
}

// Namespace: TMPro
public class TMP_ResourceManager // TypeDefIndex: 7415
{
	// Fields
	private static readonly TMP_ResourceManager s_instance; // 0x0
	private static TMP_Settings s_TextSettings; // 0x8
	private static readonly List<TMP_FontAsset> s_FontAssetReferences; // 0x10
	private static readonly Dictionary<int, TMP_FontAsset> s_FontAssetReferenceLookup; // 0x18

	// Methods

	// RVA: 0x18F4390 Offset: 0x18F4491 VA: 0x18F4390
	private static void .cctor() { }

	// RVA: 0x18F44C0 Offset: 0x18F45C1 VA: 0x18F44C0
	internal static TMP_Settings GetTextSettings() { }

	// RVA: 0x18F4600 Offset: 0x18F4701 VA: 0x18F4600
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x18F4720 Offset: 0x18F4821 VA: 0x18F4720
	public static bool TryGetFontAsset(int hashcode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x18F47D0 Offset: 0x18F48D1 VA: 0x18F47D0
	internal static void RebuildFontAssetCache(int instanceID) { }

	// RVA: 0x18F44B0 Offset: 0x18F45B1 VA: 0x18F44B0
	public void .ctor() { }
}

// Namespace: TMPro
public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 7420
{
	// Fields
	public bool isSelected; // 0x18

	// Methods

	// RVA: 0x18F4900 Offset: 0x18F4A01 VA: 0x18F4900 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x18F4980 Offset: 0x18F4A81 VA: 0x18F4980 Slot: 5
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x18F4A10 Offset: 0x18F4B11 VA: 0x18F4A10 Slot: 6
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x18F4AA0 Offset: 0x18F4BA1 VA: 0x18F4AA0
	public void .ctor() { }
}

// Namespace: TMPro
[RequireComponent] // RVA: 0x4CE10 Offset: 0x4CF11 VA: 0x4CE10
public class TMP_SelectionCaret : MaskableGraphic // TypeDefIndex: 7421
{
	// Methods

	// RVA: 0x18F4AB0 Offset: 0x18F4BB1 VA: 0x18F4AB0 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x18F4B90 Offset: 0x18F4C91 VA: 0x18F4B90 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x18F4BA0 Offset: 0x18F4CA1 VA: 0x18F4BA0
	public void .ctor() { }
}

// Namespace: TMPro
[ExcludeFromPresetAttribute] // RVA: 0x4CE80 Offset: 0x4CF81 VA: 0x4CE80
[Serializable]
public class TMP_Settings : ScriptableObject // TypeDefIndex: 7423
{
	// Fields
	private static TMP_Settings s_Instance; // 0x0
	[SerializeField] // RVA: 0x4DC00 Offset: 0x4DD01 VA: 0x4DC00
	private bool m_enableWordWrapping; // 0x18
	[SerializeField] // RVA: 0x4DC10 Offset: 0x4DD11 VA: 0x4DC10
	private bool m_enableKerning; // 0x19
	[SerializeField] // RVA: 0x4DC20 Offset: 0x4DD21 VA: 0x4DC20
	private bool m_enableExtraPadding; // 0x1A
	[SerializeField] // RVA: 0x4DC30 Offset: 0x4DD31 VA: 0x4DC30
	private bool m_enableTintAllSprites; // 0x1B
	[SerializeField] // RVA: 0x4DC40 Offset: 0x4DD41 VA: 0x4DC40
	private bool m_enableParseEscapeCharacters; // 0x1C
	[SerializeField] // RVA: 0x4DC50 Offset: 0x4DD51 VA: 0x4DC50
	private bool m_EnableRaycastTarget; // 0x1D
	[SerializeField] // RVA: 0x4DC60 Offset: 0x4DD61 VA: 0x4DC60
	private bool m_GetFontFeaturesAtRuntime; // 0x1E
	[SerializeField] // RVA: 0x4DC70 Offset: 0x4DD71 VA: 0x4DC70
	private int m_missingGlyphCharacter; // 0x20
	[SerializeField] // RVA: 0x4DC80 Offset: 0x4DD81 VA: 0x4DC80
	private bool m_warningsDisabled; // 0x24
	[SerializeField] // RVA: 0x4DC90 Offset: 0x4DD91 VA: 0x4DC90
	private TMP_FontAsset m_defaultFontAsset; // 0x28
	[SerializeField] // RVA: 0x4DCA0 Offset: 0x4DDA1 VA: 0x4DCA0
	private string m_defaultFontAssetPath; // 0x30
	[SerializeField] // RVA: 0x4DCB0 Offset: 0x4DDB1 VA: 0x4DCB0
	private float m_defaultFontSize; // 0x38
	[SerializeField] // RVA: 0x4DCC0 Offset: 0x4DDC1 VA: 0x4DCC0
	private float m_defaultAutoSizeMinRatio; // 0x3C
	[SerializeField] // RVA: 0x4DCD0 Offset: 0x4DDD1 VA: 0x4DCD0
	private float m_defaultAutoSizeMaxRatio; // 0x40
	[SerializeField] // RVA: 0x4DCE0 Offset: 0x4DDE1 VA: 0x4DCE0
	private Vector2 m_defaultTextMeshProTextContainerSize; // 0x44
	[SerializeField] // RVA: 0x4DCF0 Offset: 0x4DDF1 VA: 0x4DCF0
	private Vector2 m_defaultTextMeshProUITextContainerSize; // 0x4C
	[SerializeField] // RVA: 0x4DD00 Offset: 0x4DE01 VA: 0x4DD00
	private bool m_autoSizeTextContainer; // 0x54
	[SerializeField] // RVA: 0x4DD10 Offset: 0x4DE11 VA: 0x4DD10
	private bool m_IsTextObjectScaleStatic; // 0x55
	[SerializeField] // RVA: 0x4DD20 Offset: 0x4DE21 VA: 0x4DD20
	private List<TMP_FontAsset> m_fallbackFontAssets; // 0x58
	[SerializeField] // RVA: 0x4DD30 Offset: 0x4DE31 VA: 0x4DD30
	private bool m_matchMaterialPreset; // 0x60
	[SerializeField] // RVA: 0x4DD40 Offset: 0x4DE41 VA: 0x4DD40
	private TMP_SpriteAsset m_defaultSpriteAsset; // 0x68
	[SerializeField] // RVA: 0x4DD50 Offset: 0x4DE51 VA: 0x4DD50
	private string m_defaultSpriteAssetPath; // 0x70
	[SerializeField] // RVA: 0x4DD60 Offset: 0x4DE61 VA: 0x4DD60
	private bool m_enableEmojiSupport; // 0x78
	[SerializeField] // RVA: 0x4DD70 Offset: 0x4DE71 VA: 0x4DD70
	private uint m_MissingCharacterSpriteUnicode; // 0x7C
	[SerializeField] // RVA: 0x4DD80 Offset: 0x4DE81 VA: 0x4DD80
	private string m_defaultColorGradientPresetsPath; // 0x80
	[SerializeField] // RVA: 0x4DD90 Offset: 0x4DE91 VA: 0x4DD90
	private TMP_StyleSheet m_defaultStyleSheet; // 0x88
	[SerializeField] // RVA: 0x4DDA0 Offset: 0x4DEA1 VA: 0x4DDA0
	private string m_StyleSheetsResourcePath; // 0x90
	[SerializeField] // RVA: 0x4DDB0 Offset: 0x4DEB1 VA: 0x4DDB0
	private TextAsset m_leadingCharacters; // 0x98
	[SerializeField] // RVA: 0x4DDC0 Offset: 0x4DEC1 VA: 0x4DDC0
	private TextAsset m_followingCharacters; // 0xA0
	[SerializeField] // RVA: 0x4DDD0 Offset: 0x4DED1 VA: 0x4DDD0
	private TMP_Settings.LineBreakingTable m_linebreakingRules; // 0xA8
	[SerializeField] // RVA: 0x4DDE0 Offset: 0x4DEE1 VA: 0x4DDE0
	private bool m_UseModernHangulLineBreakingRules; // 0xB0

	// Properties
	public static string version { get; }
	public static bool enableWordWrapping { get; }
	public static bool enableKerning { get; }
	public static bool enableExtraPadding { get; }
	public static bool enableTintAllSprites { get; }
	public static bool enableParseEscapeCharacters { get; }
	public static bool enableRaycastTarget { get; }
	public static bool getFontFeaturesAtRuntime { get; }
	public static int missingGlyphCharacter { get; set; }
	public static bool warningsDisabled { get; }
	public static TMP_FontAsset defaultFontAsset { get; }
	public static string defaultFontAssetPath { get; }
	public static float defaultFontSize { get; }
	public static float defaultTextAutoSizingMinRatio { get; }
	public static float defaultTextAutoSizingMaxRatio { get; }
	public static Vector2 defaultTextMeshProTextContainerSize { get; }
	public static Vector2 defaultTextMeshProUITextContainerSize { get; }
	public static bool autoSizeTextContainer { get; }
	public static bool isTextObjectScaleStatic { get; set; }
	public static List<TMP_FontAsset> fallbackFontAssets { get; }
	public static bool matchMaterialPreset { get; }
	public static TMP_SpriteAsset defaultSpriteAsset { get; }
	public static string defaultSpriteAssetPath { get; }
	public static bool enableEmojiSupport { get; set; }
	public static uint missingCharacterSpriteUnicode { get; set; }
	public static string defaultColorGradientPresetsPath { get; }
	public static TMP_StyleSheet defaultStyleSheet { get; }
	public static string styleSheetsResourcePath { get; }
	public static TextAsset leadingCharacters { get; }
	public static TextAsset followingCharacters { get; }
	public static TMP_Settings.LineBreakingTable linebreakingRules { get; }
	public static bool useModernHangulLineBreakingRules { get; set; }
	public static TMP_Settings instance { get; }

	// Methods

	// RVA: 0x18F4BB0 Offset: 0x18F4CB1 VA: 0x18F4BB0
	public static string get_version() { }

	// RVA: 0x18F4C00 Offset: 0x18F4D01 VA: 0x18F4C00
	public static bool get_enableWordWrapping() { }

	// RVA: 0x18F4D10 Offset: 0x18F4E11 VA: 0x18F4D10
	public static bool get_enableKerning() { }

	// RVA: 0x18F4D30 Offset: 0x18F4E31 VA: 0x18F4D30
	public static bool get_enableExtraPadding() { }

	// RVA: 0x18F4D50 Offset: 0x18F4E51 VA: 0x18F4D50
	public static bool get_enableTintAllSprites() { }

	// RVA: 0x18F4D70 Offset: 0x18F4E71 VA: 0x18F4D70
	public static bool get_enableParseEscapeCharacters() { }

	// RVA: 0x18F4D90 Offset: 0x18F4E91 VA: 0x18F4D90
	public static bool get_enableRaycastTarget() { }

	// RVA: 0x18F4DB0 Offset: 0x18F4EB1 VA: 0x18F4DB0
	public static bool get_getFontFeaturesAtRuntime() { }

	// RVA: 0x18F4DD0 Offset: 0x18F4ED1 VA: 0x18F4DD0
	public static int get_missingGlyphCharacter() { }

	// RVA: 0x18F4DF0 Offset: 0x18F4EF1 VA: 0x18F4DF0
	public static void set_missingGlyphCharacter(int value) { }

	// RVA: 0x18F4E20 Offset: 0x18F4F21 VA: 0x18F4E20
	public static bool get_warningsDisabled() { }

	// RVA: 0x18F4E40 Offset: 0x18F4F41 VA: 0x18F4E40
	public static TMP_FontAsset get_defaultFontAsset() { }

	// RVA: 0x18F4E60 Offset: 0x18F4F61 VA: 0x18F4E60
	public static string get_defaultFontAssetPath() { }

	// RVA: 0x18F4E80 Offset: 0x18F4F81 VA: 0x18F4E80
	public static float get_defaultFontSize() { }

	// RVA: 0x18F4EA0 Offset: 0x18F4FA1 VA: 0x18F4EA0
	public static float get_defaultTextAutoSizingMinRatio() { }

	// RVA: 0x18F4EC0 Offset: 0x18F4FC1 VA: 0x18F4EC0
	public static float get_defaultTextAutoSizingMaxRatio() { }

	// RVA: 0x18F4EE0 Offset: 0x18F4FE1 VA: 0x18F4EE0
	public static Vector2 get_defaultTextMeshProTextContainerSize() { }

	// RVA: 0x18F4F00 Offset: 0x18F5001 VA: 0x18F4F00
	public static Vector2 get_defaultTextMeshProUITextContainerSize() { }

	// RVA: 0x18F4F20 Offset: 0x18F5021 VA: 0x18F4F20
	public static bool get_autoSizeTextContainer() { }

	// RVA: 0x18F4F40 Offset: 0x18F5041 VA: 0x18F4F40
	public static bool get_isTextObjectScaleStatic() { }

	// RVA: 0x18F4F60 Offset: 0x18F5061 VA: 0x18F4F60
	public static void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x18F4F90 Offset: 0x18F5091 VA: 0x18F4F90
	public static List<TMP_FontAsset> get_fallbackFontAssets() { }

	// RVA: 0x18F4FB0 Offset: 0x18F50B1 VA: 0x18F4FB0
	public static bool get_matchMaterialPreset() { }

	// RVA: 0x18F4FD0 Offset: 0x18F50D1 VA: 0x18F4FD0
	public static TMP_SpriteAsset get_defaultSpriteAsset() { }

	// RVA: 0x18F4FF0 Offset: 0x18F50F1 VA: 0x18F4FF0
	public static string get_defaultSpriteAssetPath() { }

	// RVA: 0x18F5010 Offset: 0x18F5111 VA: 0x18F5010
	public static bool get_enableEmojiSupport() { }

	// RVA: 0x18F5030 Offset: 0x18F5131 VA: 0x18F5030
	public static void set_enableEmojiSupport(bool value) { }

	// RVA: 0x18F5060 Offset: 0x18F5161 VA: 0x18F5060
	public static uint get_missingCharacterSpriteUnicode() { }

	// RVA: 0x18F5080 Offset: 0x18F5181 VA: 0x18F5080
	public static void set_missingCharacterSpriteUnicode(uint value) { }

	// RVA: 0x18F50B0 Offset: 0x18F51B1 VA: 0x18F50B0
	public static string get_defaultColorGradientPresetsPath() { }

	// RVA: 0x18F50D0 Offset: 0x18F51D1 VA: 0x18F50D0
	public static TMP_StyleSheet get_defaultStyleSheet() { }

	// RVA: 0x18F50F0 Offset: 0x18F51F1 VA: 0x18F50F0
	public static string get_styleSheetsResourcePath() { }

	// RVA: 0x18F5110 Offset: 0x18F5211 VA: 0x18F5110
	public static TextAsset get_leadingCharacters() { }

	// RVA: 0x18F5130 Offset: 0x18F5231 VA: 0x18F5130
	public static TextAsset get_followingCharacters() { }

	// RVA: 0x18F5150 Offset: 0x18F5251 VA: 0x18F5150
	public static TMP_Settings.LineBreakingTable get_linebreakingRules() { }

	// RVA: 0x18F52D0 Offset: 0x18F53D1 VA: 0x18F52D0
	public static bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0x18F52F0 Offset: 0x18F53F1 VA: 0x18F52F0
	public static void set_useModernHangulLineBreakingRules(bool value) { }

	// RVA: 0x18F4C20 Offset: 0x18F4D21 VA: 0x18F4C20
	public static TMP_Settings get_instance() { }

	// RVA: 0x18F5320 Offset: 0x18F5421 VA: 0x18F5320
	public static TMP_Settings LoadDefaultSettings() { }

	// RVA: 0x18F5440 Offset: 0x18F5541 VA: 0x18F5440
	public static TMP_Settings GetSettings() { }

	// RVA: 0x18F54D0 Offset: 0x18F55D1 VA: 0x18F54D0
	public static TMP_FontAsset GetFontAsset() { }

	// RVA: 0x18F5560 Offset: 0x18F5661 VA: 0x18F5560
	public static TMP_SpriteAsset GetSpriteAsset() { }

	// RVA: 0x18F55F0 Offset: 0x18F56F1 VA: 0x18F55F0
	public static TMP_StyleSheet GetStyleSheet() { }

	// RVA: 0x18F5190 Offset: 0x18F5291 VA: 0x18F5190
	public static void LoadLinebreakingRules() { }

	// RVA: 0x18F5680 Offset: 0x18F5781 VA: 0x18F5680
	private static Dictionary<int, char> GetCharacters(TextAsset file) { }

	// RVA: 0x18F57A0 Offset: 0x18F58A1 VA: 0x18F57A0
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Sprite : TMP_TextElement_Legacy // TypeDefIndex: 7425
{
	// Fields
	public string name; // 0x38
	public int hashCode; // 0x40
	public int unicode; // 0x44
	public Vector2 pivot; // 0x48
	public Sprite sprite; // 0x50

	// Methods

	// RVA: 0x18F57B0 Offset: 0x18F58B1 VA: 0x18F57B0
	public void .ctor() { }
}

// Namespace: TMPro
[DisallowMultipleComponent] // RVA: 0x4CE90 Offset: 0x4CF91 VA: 0x4CE90
public class TMP_SpriteAnimator : MonoBehaviour // TypeDefIndex: 7427
{
	// Fields
	private Dictionary<int, bool> m_animations; // 0x18
	private TMP_Text m_TextComponent; // 0x20

	// Methods

	// RVA: 0x18F57C0 Offset: 0x18F58C1 VA: 0x18F57C0
	private void Awake() { }

	// RVA: 0x18F5830 Offset: 0x18F5931 VA: 0x18F5830
	private void OnEnable() { }

	// RVA: 0x18F5840 Offset: 0x18F5941 VA: 0x18F5840
	private void OnDisable() { }

	// RVA: 0x18F5850 Offset: 0x18F5951 VA: 0x18F5850
	public void StopAllAnimations() { }

	// RVA: 0x18F58B0 Offset: 0x18F59B1 VA: 0x18F58B0
	public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	[IteratorStateMachineAttribute] // RVA: 0x4E8A0 Offset: 0x4E9A1 VA: 0x4E8A0
	// RVA: 0x18F59F0 Offset: 0x18F5AF1 VA: 0x18F59F0
	private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	// RVA: 0x18F5AB0 Offset: 0x18F5BB1 VA: 0x18F5AB0
	public void .ctor() { }
}

// Namespace: TMPro
[ExcludeFromPresetAttribute] // RVA: 0x4CEB0 Offset: 0x4CFB1 VA: 0x4CEB0
public class TMP_SpriteAsset : TMP_Asset // TypeDefIndex: 7429
{
	// Fields
	internal Dictionary<int, int> m_NameLookup; // 0x30
	internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x38
	[SerializeField] // RVA: 0x4DDF0 Offset: 0x4DEF1 VA: 0x4DDF0
	private string m_Version; // 0x40
	[SerializeField] // RVA: 0x4DE00 Offset: 0x4DF01 VA: 0x4DE00
	internal FaceInfo m_FaceInfo; // 0x48
	public Texture spriteSheet; // 0xA8
	[SerializeField] // RVA: 0x4DE10 Offset: 0x4DF11 VA: 0x4DE10
	private List<TMP_SpriteCharacter> m_SpriteCharacterTable; // 0xB0
	internal Dictionary<uint, TMP_SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
	[SerializeField] // RVA: 0x4DE20 Offset: 0x4DF21 VA: 0x4DE20
	private List<TMP_SpriteGlyph> m_SpriteGlyphTable; // 0xC0
	internal Dictionary<uint, TMP_SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
	public List<TMP_Sprite> spriteInfoList; // 0xD0
	[SerializeField] // RVA: 0x4DE30 Offset: 0x4DF31 VA: 0x4DE30
	public List<TMP_SpriteAsset> fallbackSpriteAssets; // 0xD8
	internal bool m_IsSpriteAssetLookupTablesDirty; // 0xE0
	private static HashSet<int> k_searchedSpriteAssets; // 0x0

	// Properties
	public string version { get; set; }
	public FaceInfo faceInfo { get; set; }
	public List<TMP_SpriteCharacter> spriteCharacterTable { get; set; }
	public Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable { get; set; }
	public List<TMP_SpriteGlyph> spriteGlyphTable { get; set; }

	// Methods

	// RVA: 0x18F5B40 Offset: 0x18F5C41 VA: 0x18F5B40
	public string get_version() { }

	// RVA: 0x18F5B50 Offset: 0x18F5C51 VA: 0x18F5B50
	internal void set_version(string value) { }

	// RVA: 0x18F5B60 Offset: 0x18F5C61 VA: 0x18F5B60
	public FaceInfo get_faceInfo() { }

	// RVA: 0x18F5BA0 Offset: 0x18F5CA1 VA: 0x18F5BA0
	internal void set_faceInfo(FaceInfo value) { }

	// RVA: 0x18F5BD0 Offset: 0x18F5CD1 VA: 0x18F5BD0
	public List<TMP_SpriteCharacter> get_spriteCharacterTable() { }

	// RVA: 0x18F6190 Offset: 0x18F6291 VA: 0x18F6190
	internal void set_spriteCharacterTable(List<TMP_SpriteCharacter> value) { }

	// RVA: 0x18F61A0 Offset: 0x18F62A1 VA: 0x18F61A0
	public Dictionary<uint, TMP_SpriteCharacter> get_spriteCharacterLookupTable() { }

	// RVA: 0x18F61E0 Offset: 0x18F62E1 VA: 0x18F61E0
	internal void set_spriteCharacterLookupTable(Dictionary<uint, TMP_SpriteCharacter> value) { }

	// RVA: 0x18F61F0 Offset: 0x18F62F1 VA: 0x18F61F0
	public List<TMP_SpriteGlyph> get_spriteGlyphTable() { }

	// RVA: 0x18F6200 Offset: 0x18F6301 VA: 0x18F6200
	internal void set_spriteGlyphTable(List<TMP_SpriteGlyph> value) { }

	// RVA: 0x18F6210 Offset: 0x18F6311 VA: 0x18F6210
	private void Awake() { }

	// RVA: 0x18F6840 Offset: 0x18F6941 VA: 0x18F6840
	private Material GetDefaultSpriteMaterial() { }

	// RVA: 0x18F5C10 Offset: 0x18F5D11 VA: 0x18F5C10
	public void UpdateLookupTables() { }

	// RVA: 0x18F6930 Offset: 0x18F6A31 VA: 0x18F6930
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	// RVA: 0x18F69C0 Offset: 0x18F6AC1 VA: 0x18F69C0
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	// RVA: 0x18F6A60 Offset: 0x18F6B61 VA: 0x18F6A60
	public int GetSpriteIndexFromName(string name) { }

	// RVA: 0x18F6B70 Offset: 0x18F6C71 VA: 0x18F6B70
	public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x18F6DF0 Offset: 0x18F6EF1 VA: 0x18F6DF0
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x18F6F90 Offset: 0x18F7091 VA: 0x18F6F90
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x18F70A0 Offset: 0x18F71A1 VA: 0x18F70A0
	public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x18F7470 Offset: 0x18F7571 VA: 0x18F7470
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x18F7610 Offset: 0x18F7711 VA: 0x18F7610
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x18F7710 Offset: 0x18F7811 VA: 0x18F7710
	public void SortGlyphTable() { }

	// RVA: 0x18F78B0 Offset: 0x18F79B1 VA: 0x18F78B0
	internal void SortCharacterTable() { }

	// RVA: 0x18F7A50 Offset: 0x18F7B51 VA: 0x18F7A50
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0x18F62B0 Offset: 0x18F63B1 VA: 0x18F62B0
	private void UpgradeSpriteAsset() { }

	// RVA: 0x18F7B70 Offset: 0x18F7C71 VA: 0x18F7B70
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_SpriteCharacter : TMP_TextElement // TypeDefIndex: 7430
{
	// Fields
	[SerializeField] // RVA: 0x4DE40 Offset: 0x4DF41 VA: 0x4DE40
	private string m_Name; // 0x30
	[SerializeField] // RVA: 0x4DE50 Offset: 0x4DF51 VA: 0x4DE50
	private int m_HashCode; // 0x38

	// Properties
	public string name { get; set; }
	public int hashCode { get; }

	// Methods

	// RVA: 0x18F7C50 Offset: 0x18F7D51 VA: 0x18F7C50
	public string get_name() { }

	// RVA: 0x18F7AC0 Offset: 0x18F7BC1 VA: 0x18F7AC0
	public void set_name(string value) { }

	// RVA: 0x18F7C60 Offset: 0x18F7D61 VA: 0x18F7C60
	public int get_hashCode() { }

	// RVA: 0x18F7A90 Offset: 0x18F7B91 VA: 0x18F7A90
	public void .ctor() { }

	// RVA: 0x18F7C70 Offset: 0x18F7D71 VA: 0x18F7C70
	public void .ctor(uint unicode, TMP_SpriteGlyph glyph) { }

	// RVA: 0x18F7CE0 Offset: 0x18F7DE1 VA: 0x18F7CE0
	public void .ctor(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph) { }

	// RVA: 0x18F7D60 Offset: 0x18F7E61 VA: 0x18F7D60
	internal void .ctor(uint unicode, uint glyphIndex) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_SpriteGlyph : Glyph // TypeDefIndex: 7431
{
	// Fields
	public Sprite sprite; // 0x40

	// Methods

	// RVA: 0x18F7A80 Offset: 0x18F7B81 VA: 0x18F7A80
	public void .ctor() { }

	// RVA: 0x18F7DD0 Offset: 0x18F7ED1 VA: 0x18F7DD0
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

	// RVA: 0x18F7E90 Offset: 0x18F7F91 VA: 0x18F7E90
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex, Sprite sprite) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Style // TypeDefIndex: 7432
{
	// Fields
	internal static TMP_Style k_NormalStyle; // 0x0
	[SerializeField] // RVA: 0x4DE60 Offset: 0x4DF61 VA: 0x4DE60
	private string m_Name; // 0x10
	[SerializeField] // RVA: 0x4DE70 Offset: 0x4DF71 VA: 0x4DE70
	private int m_HashCode; // 0x18
	[SerializeField] // RVA: 0x4DE80 Offset: 0x4DF81 VA: 0x4DE80
	private string m_OpeningDefinition; // 0x20
	[SerializeField] // RVA: 0x4DE90 Offset: 0x4DF91 VA: 0x4DE90
	private string m_ClosingDefinition; // 0x28
	[SerializeField] // RVA: 0x4DEA0 Offset: 0x4DFA1 VA: 0x4DEA0
	private int[] m_OpeningTagArray; // 0x30
	[SerializeField] // RVA: 0x4DEB0 Offset: 0x4DFB1 VA: 0x4DEB0
	private int[] m_ClosingTagArray; // 0x38
	[SerializeField] // RVA: 0x4DEC0 Offset: 0x4DFC1 VA: 0x4DEC0
	internal uint[] m_OpeningTagUnicodeArray; // 0x40
	[SerializeField] // RVA: 0x4DED0 Offset: 0x4DFD1 VA: 0x4DED0
	internal uint[] m_ClosingTagUnicodeArray; // 0x48

	// Properties
	public static TMP_Style NormalStyle { get; }
	public string name { get; set; }
	public int hashCode { get; set; }
	public string styleOpeningDefinition { get; }
	public string styleClosingDefinition { get; }
	public int[] styleOpeningTagArray { get; }
	public int[] styleClosingTagArray { get; }

	// Methods

	// RVA: 0x18F7F70 Offset: 0x18F8071 VA: 0x18F7F70
	public static TMP_Style get_NormalStyle() { }

	// RVA: 0x18F8110 Offset: 0x18F8211 VA: 0x18F8110
	public string get_name() { }

	// RVA: 0x18F8120 Offset: 0x18F8221 VA: 0x18F8120
	public void set_name(string value) { }

	// RVA: 0x18F8170 Offset: 0x18F8271 VA: 0x18F8170
	public int get_hashCode() { }

	// RVA: 0x18F8180 Offset: 0x18F8281 VA: 0x18F8180
	public void set_hashCode(int value) { }

	// RVA: 0x18F81A0 Offset: 0x18F82A1 VA: 0x18F81A0
	public string get_styleOpeningDefinition() { }

	// RVA: 0x18F81B0 Offset: 0x18F82B1 VA: 0x18F81B0
	public string get_styleClosingDefinition() { }

	// RVA: 0x18F81C0 Offset: 0x18F82C1 VA: 0x18F81C0
	public int[] get_styleOpeningTagArray() { }

	// RVA: 0x18F81D0 Offset: 0x18F82D1 VA: 0x18F81D0
	public int[] get_styleClosingTagArray() { }

	// RVA: 0x18F8040 Offset: 0x18F8141 VA: 0x18F8040
	internal void .ctor(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	// RVA: 0x18F81E0 Offset: 0x18F82E1 VA: 0x18F81E0
	public void RefreshStyle() { }
}

// Namespace: TMPro
[ExcludeFromPresetAttribute] // RVA: 0x4CED0 Offset: 0x4CFD1 VA: 0x4CED0
[Serializable]
public class TMP_StyleSheet : ScriptableObject // TypeDefIndex: 7433
{
	// Fields
	[SerializeField] // RVA: 0x4DEE0 Offset: 0x4DFE1 VA: 0x4DEE0
	private List<TMP_Style> m_StyleList; // 0x18
	private Dictionary<int, TMP_Style> m_StyleLookupDictionary; // 0x20

	// Properties
	internal List<TMP_Style> styles { get; }

	// Methods

	// RVA: 0x18F8400 Offset: 0x18F8501 VA: 0x18F8400
	internal List<TMP_Style> get_styles() { }

	// RVA: 0x18F8410 Offset: 0x18F8511 VA: 0x18F8410
	private void Reset() { }

	// RVA: 0x18F8710 Offset: 0x18F8811 VA: 0x18F8710
	public TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x18F87A0 Offset: 0x18F88A1 VA: 0x18F87A0
	public TMP_Style GetStyle(string name) { }

	// RVA: 0x18F8870 Offset: 0x18F8971 VA: 0x18F8870
	public void RefreshStyles() { }

	// RVA: 0x18F8420 Offset: 0x18F8521 VA: 0x18F8420
	private void LoadStyleDictionaryInternal() { }

	// RVA: 0x18F8880 Offset: 0x18F8981 VA: 0x18F8880
	public void .ctor() { }
}

// Namespace: TMPro
[RequireComponent] // RVA: 0x4CEE0 Offset: 0x4CFE1 VA: 0x4CEE0
[ExecuteAlways] // RVA: 0x4CEE0 Offset: 0x4CFE1 VA: 0x4CEE0
public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 7434
{
	// Fields
	[SerializeField] // RVA: 0x4DEF0 Offset: 0x4DFF1 VA: 0x4DEF0
	private TMP_FontAsset m_fontAsset; // 0x18
	[SerializeField] // RVA: 0x4DF00 Offset: 0x4E001 VA: 0x4DF00
	private TMP_SpriteAsset m_spriteAsset; // 0x20
	[SerializeField] // RVA: 0x4DF10 Offset: 0x4E011 VA: 0x4DF10
	private Material m_material; // 0x28
	[SerializeField] // RVA: 0x4DF20 Offset: 0x4E021 VA: 0x4DF20
	private Material m_sharedMaterial; // 0x30
	private Material m_fallbackMaterial; // 0x38
	private Material m_fallbackSourceMaterial; // 0x40
	[SerializeField] // RVA: 0x4DF30 Offset: 0x4E031 VA: 0x4DF30
	private bool m_isDefaultMaterial; // 0x48
	[SerializeField] // RVA: 0x4DF40 Offset: 0x4E041 VA: 0x4DF40
	private float m_padding; // 0x4C
	[SerializeField] // RVA: 0x4DF50 Offset: 0x4E051 VA: 0x4DF50
	private Renderer m_renderer; // 0x50
	private MeshFilter m_meshFilter; // 0x58
	private Mesh m_mesh; // 0x60
	[SerializeField] // RVA: 0x4DF60 Offset: 0x4E061 VA: 0x4DF60
	private TextMeshPro m_TextComponent; // 0x68
	private bool m_isRegisteredForEvents; // 0x70

	// Properties
	public TMP_FontAsset fontAsset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public Renderer renderer { get; }
	public MeshFilter meshFilter { get; }
	public Mesh mesh { get; set; }
	public TMP_Text textComponent { get; }

	// Methods

	// RVA: 0x18F8910 Offset: 0x18F8A11 VA: 0x18F8910
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x18F8920 Offset: 0x18F8A21 VA: 0x18F8920
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x18F8930 Offset: 0x18F8A31 VA: 0x18F8930
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x18F8940 Offset: 0x18F8A41 VA: 0x18F8940
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x18F8950 Offset: 0x18F8A51 VA: 0x18F8950
	public Material get_material() { }

	// RVA: 0x18F8B20 Offset: 0x18F8C21 VA: 0x18F8B20
	public void set_material(Material value) { }

	// RVA: 0x18F8DA0 Offset: 0x18F8EA1 VA: 0x18F8DA0
	public Material get_sharedMaterial() { }

	// RVA: 0x18F8DB0 Offset: 0x18F8EB1 VA: 0x18F8DB0
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x18F8E70 Offset: 0x18F8F71 VA: 0x18F8E70
	public Material get_fallbackMaterial() { }

	// RVA: 0x18F8E80 Offset: 0x18F8F81 VA: 0x18F8E80
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x18F9010 Offset: 0x18F9111 VA: 0x18F9010
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x18F9020 Offset: 0x18F9121 VA: 0x18F9020
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x18F9030 Offset: 0x18F9131 VA: 0x18F9030
	public bool get_isDefaultMaterial() { }

	// RVA: 0x18F9040 Offset: 0x18F9141 VA: 0x18F9040
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x18F9050 Offset: 0x18F9151 VA: 0x18F9050
	public float get_padding() { }

	// RVA: 0x18F9060 Offset: 0x18F9161 VA: 0x18F9060
	public void set_padding(float value) { }

	// RVA: 0x18F9070 Offset: 0x18F9171 VA: 0x18F9070
	public Renderer get_renderer() { }

	// RVA: 0x18F9130 Offset: 0x18F9231 VA: 0x18F9130
	public MeshFilter get_meshFilter() { }

	// RVA: 0x18F9260 Offset: 0x18F9361 VA: 0x18F9260
	public Mesh get_mesh() { }

	// RVA: 0x18F9330 Offset: 0x18F9431 VA: 0x18F9330
	public void set_mesh(Mesh value) { }

	// RVA: 0x18F9340 Offset: 0x18F9441 VA: 0x18F9340
	public TMP_Text get_textComponent() { }

	// RVA: 0x18F9400 Offset: 0x18F9501 VA: 0x18F9400
	public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) { }

	// RVA: 0x18F9730 Offset: 0x18F9831 VA: 0x18F9730
	private void OnEnable() { }

	// RVA: 0x18F9890 Offset: 0x18F9991 VA: 0x18F9890
	private void OnDisable() { }

	// RVA: 0x18F9980 Offset: 0x18F9A81 VA: 0x18F9980
	private void OnDestroy() { }

	// RVA: 0x18F9B50 Offset: 0x18F9C51 VA: 0x18F9B50
	public void DestroySelf() { }

	// RVA: 0x18F8960 Offset: 0x18F8A61 VA: 0x18F8960
	private Material GetMaterial(Material mat) { }

	// RVA: 0x18F9BD0 Offset: 0x18F9CD1 VA: 0x18F9BD0
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0x18F9C90 Offset: 0x18F9D91 VA: 0x18F9C90
	private Material GetSharedMaterial() { }

	// RVA: 0x18F8DC0 Offset: 0x18F8EC1 VA: 0x18F8DC0
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0x18F8C30 Offset: 0x18F8D31 VA: 0x18F8C30
	public float GetPaddingForMaterial() { }

	// RVA: 0x18F9D50 Offset: 0x18F9E51 VA: 0x18F9D50
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x18F8CC0 Offset: 0x18F8DC1 VA: 0x18F8CC0
	public void SetVerticesDirty() { }

	// RVA: 0x18F8D90 Offset: 0x18F8E91 VA: 0x18F8D90
	public void SetMaterialDirty() { }

	// RVA: 0x18F9DE0 Offset: 0x18F9EE1 VA: 0x18F9DE0
	protected void UpdateMaterial() { }

	// RVA: 0x18F9F60 Offset: 0x18FA061 VA: 0x18F9F60
	public void .ctor() { }
}

// Namespace: TMPro
[RequireComponent] // RVA: 0x4CF60 Offset: 0x4D061 VA: 0x4CF60
[ExecuteAlways] // RVA: 0x4CF60 Offset: 0x4D061 VA: 0x4CF60
public class TMP_SubMeshUI : MaskableGraphic // TypeDefIndex: 7435
{
	// Fields
	[SerializeField] // RVA: 0x4DF70 Offset: 0x4E071 VA: 0x4DF70
	private TMP_FontAsset m_fontAsset; // 0xD0
	[SerializeField] // RVA: 0x4DF80 Offset: 0x4E081 VA: 0x4DF80
	private TMP_SpriteAsset m_spriteAsset; // 0xD8
	[SerializeField] // RVA: 0x4DF90 Offset: 0x4E091 VA: 0x4DF90
	private Material m_material; // 0xE0
	[SerializeField] // RVA: 0x4DFA0 Offset: 0x4E0A1 VA: 0x4DFA0
	private Material m_sharedMaterial; // 0xE8
	private Material m_fallbackMaterial; // 0xF0
	private Material m_fallbackSourceMaterial; // 0xF8
	[SerializeField] // RVA: 0x4DFB0 Offset: 0x4E0B1 VA: 0x4DFB0
	private bool m_isDefaultMaterial; // 0x100
	[SerializeField] // RVA: 0x4DFC0 Offset: 0x4E0C1 VA: 0x4DFC0
	private float m_padding; // 0x104
	private Mesh m_mesh; // 0x108
	[SerializeField] // RVA: 0x4DFD0 Offset: 0x4E0D1 VA: 0x4DFD0
	private TextMeshProUGUI m_TextComponent; // 0x110
	private bool m_isRegisteredForEvents; // 0x118
	private bool m_materialDirty; // 0x119
	[SerializeField] // RVA: 0x4DFE0 Offset: 0x4E0E1 VA: 0x4DFE0
	private int m_materialReferenceIndex; // 0x11C
	private Transform m_RootCanvasTransform; // 0x120

	// Properties
	public TMP_FontAsset fontAsset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public override Texture mainTexture { get; }
	public override Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public override Material materialForRendering { get; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public Mesh mesh { get; set; }
	public TMP_Text textComponent { get; }

	// Methods

	// RVA: 0x18F9F70 Offset: 0x18FA071 VA: 0x18F9F70
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x18F9F80 Offset: 0x18FA081 VA: 0x18F9F80
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x18F9F90 Offset: 0x18FA091 VA: 0x18F9F90
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x18F9FA0 Offset: 0x18FA0A1 VA: 0x18F9FA0
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x18F9FB0 Offset: 0x18FA0B1 VA: 0x18F9FB0 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x18FA090 Offset: 0x18FA191 VA: 0x18FA090 Slot: 32
	public override Material get_material() { }

	// RVA: 0x18FA220 Offset: 0x18FA321 VA: 0x18FA220 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x18FA430 Offset: 0x18FA531 VA: 0x18FA430
	public Material get_sharedMaterial() { }

	// RVA: 0x18FA440 Offset: 0x18FA541 VA: 0x18FA440
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x18FA520 Offset: 0x18FA621 VA: 0x18FA520
	public Material get_fallbackMaterial() { }

	// RVA: 0x18FA530 Offset: 0x18FA631 VA: 0x18FA530
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x18FA6C0 Offset: 0x18FA7C1 VA: 0x18FA6C0
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x18FA6D0 Offset: 0x18FA7D1 VA: 0x18FA6D0
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x18FA6E0 Offset: 0x18FA7E1 VA: 0x18FA6E0 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x18FA760 Offset: 0x18FA861 VA: 0x18FA760
	public bool get_isDefaultMaterial() { }

	// RVA: 0x18FA770 Offset: 0x18FA871 VA: 0x18FA770
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x18FA780 Offset: 0x18FA881 VA: 0x18FA780
	public float get_padding() { }

	// RVA: 0x18FA790 Offset: 0x18FA891 VA: 0x18FA790
	public void set_padding(float value) { }

	// RVA: 0x18FA7A0 Offset: 0x18FA8A1 VA: 0x18FA7A0
	public Mesh get_mesh() { }

	// RVA: 0x18FA870 Offset: 0x18FA971 VA: 0x18FA870
	public void set_mesh(Mesh value) { }

	// RVA: 0x18FA880 Offset: 0x18FA981 VA: 0x18FA880
	public TMP_Text get_textComponent() { }

	// RVA: 0x18FA940 Offset: 0x18FAA41 VA: 0x18FA940
	public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) { }

	// RVA: 0x18FADF0 Offset: 0x18FAEF1 VA: 0x18FADF0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x18FAE70 Offset: 0x18FAF71 VA: 0x18FAE70 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x18FAF50 Offset: 0x18FB051 VA: 0x18FAF50 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x18FB160 Offset: 0x18FB261 VA: 0x18FB160 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x18FB1D0 Offset: 0x18FB2D1 VA: 0x18FB1D0 Slot: 58
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x18FA3A0 Offset: 0x18FA4A1 VA: 0x18FA3A0
	public float GetPaddingForMaterial() { }

	// RVA: 0x18FB300 Offset: 0x18FB401 VA: 0x18FB300
	public float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x18FB390 Offset: 0x18FB491 VA: 0x18FB390
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x18FB420 Offset: 0x18FB521 VA: 0x18FB420 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x18FB430 Offset: 0x18FB531 VA: 0x18FB430 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x18FB500 Offset: 0x18FB601 VA: 0x18FB500 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x18FB510 Offset: 0x18FB611 VA: 0x18FB510 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x18FB560 Offset: 0x18FB661 VA: 0x18FB560
	public void SetPivotDirty() { }

	// RVA: 0x18FB5C0 Offset: 0x18FB6C1 VA: 0x18FB5C0
	private Transform GetRootCanvasTransform() { }

	// RVA: 0x18FB670 Offset: 0x18FB771 VA: 0x18FB670 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x18FB680 Offset: 0x18FB781 VA: 0x18FB680 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x18FB690 Offset: 0x18FB791 VA: 0x18FB690 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x18FB6E0 Offset: 0x18FB7E1 VA: 0x18FB6E0
	public void RefreshMaterial() { }

	// RVA: 0x18FB6F0 Offset: 0x18FB7F1 VA: 0x18FB6F0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x18FB880 Offset: 0x18FB981 VA: 0x18FB880 Slot: 63
	public override void RecalculateClipping() { }

	// RVA: 0x18FB890 Offset: 0x18FB991 VA: 0x18FB890
	private Material GetMaterial() { }

	// RVA: 0x18FA0A0 Offset: 0x18FA1A1 VA: 0x18FA0A0
	private Material GetMaterial(Material mat) { }

	// RVA: 0x18FB8A0 Offset: 0x18FB9A1 VA: 0x18FB8A0
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0x18FB960 Offset: 0x18FBA61 VA: 0x18FB960
	private Material GetSharedMaterial() { }

	// RVA: 0x18FA450 Offset: 0x18FA551 VA: 0x18FA450
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0x18FB980 Offset: 0x18FBA81 VA: 0x18FB980
	public void .ctor() { }
}

// Namespace: TMPro
public enum TMP_TextElementType // TypeDefIndex: 7441
{
	// Fields
	public int value__; // 0x0
	public const TMP_TextElementType Character = 0;
	public const TMP_TextElementType Sprite = 1;
}

// Namespace: TMPro
public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 7454
{
	// Fields
	[SerializeField] // RVA: 0x4DFF0 Offset: 0x4E0F1 VA: 0x4DFF0
	[TextAreaAttribute] // RVA: 0x4DFF0 Offset: 0x4E0F1 VA: 0x4DFF0
	protected string m_text; // 0xD0
	private bool m_IsTextBackingStringDirty; // 0xD8
	[SerializeField] // RVA: 0x4E030 Offset: 0x4E131 VA: 0x4E030
	protected ITextPreprocessor m_TextPreprocessor; // 0xE0
	[SerializeField] // RVA: 0x4E040 Offset: 0x4E141 VA: 0x4E040
	protected bool m_isRightToLeft; // 0xE8
	[SerializeField] // RVA: 0x4E050 Offset: 0x4E151 VA: 0x4E050
	protected TMP_FontAsset m_fontAsset; // 0xF0
	protected TMP_FontAsset m_currentFontAsset; // 0xF8
	protected bool m_isSDFShader; // 0x100
	[SerializeField] // RVA: 0x4E060 Offset: 0x4E161 VA: 0x4E060
	protected Material m_sharedMaterial; // 0x108
	protected Material m_currentMaterial; // 0x110
	protected static MaterialReference[] m_materialReferences; // 0x0
	protected static Dictionary<int, int> m_materialReferenceIndexLookup; // 0x8
	protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; // 0x10
	protected int m_currentMaterialIndex; // 0x118
	[SerializeField] // RVA: 0x4E070 Offset: 0x4E171 VA: 0x4E070
	protected Material[] m_fontSharedMaterials; // 0x120
	[SerializeField] // RVA: 0x4E080 Offset: 0x4E181 VA: 0x4E080
	protected Material m_fontMaterial; // 0x128
	[SerializeField] // RVA: 0x4E090 Offset: 0x4E191 VA: 0x4E090
	protected Material[] m_fontMaterials; // 0x130
	protected bool m_isMaterialDirty; // 0x138
	[SerializeField] // RVA: 0x4E0A0 Offset: 0x4E1A1 VA: 0x4E0A0
	protected Color32 m_fontColor32; // 0x13C
	[SerializeField] // RVA: 0x4E0B0 Offset: 0x4E1B1 VA: 0x4E0B0
	protected Color m_fontColor; // 0x140
	protected static Color32 s_colorWhite; // 0x68
	protected Color32 m_underlineColor; // 0x150
	protected Color32 m_strikethroughColor; // 0x154
	[SerializeField] // RVA: 0x4E0C0 Offset: 0x4E1C1 VA: 0x4E0C0
	protected bool m_enableVertexGradient; // 0x158
	[SerializeField] // RVA: 0x4E0D0 Offset: 0x4E1D1 VA: 0x4E0D0
	protected ColorMode m_colorMode; // 0x15C
	[SerializeField] // RVA: 0x4E0E0 Offset: 0x4E1E1 VA: 0x4E0E0
	protected VertexGradient m_fontColorGradient; // 0x160
	[SerializeField] // RVA: 0x4E0F0 Offset: 0x4E1F1 VA: 0x4E0F0
	protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1A0
	[SerializeField] // RVA: 0x4E100 Offset: 0x4E201 VA: 0x4E100
	protected TMP_SpriteAsset m_spriteAsset; // 0x1A8
	[SerializeField] // RVA: 0x4E110 Offset: 0x4E211 VA: 0x4E110
	protected bool m_tintAllSprites; // 0x1B0
	protected bool m_tintSprite; // 0x1B1
	protected Color32 m_spriteColor; // 0x1B4
	[SerializeField] // RVA: 0x4E120 Offset: 0x4E221 VA: 0x4E120
	protected TMP_StyleSheet m_StyleSheet; // 0x1B8
	internal TMP_Style m_TextStyle; // 0x1C0
	[SerializeField] // RVA: 0x4E130 Offset: 0x4E231 VA: 0x4E130
	protected int m_TextStyleHashCode; // 0x1C8
	[SerializeField] // RVA: 0x4E140 Offset: 0x4E241 VA: 0x4E140
	protected bool m_overrideHtmlColors; // 0x1CC
	[SerializeField] // RVA: 0x4E150 Offset: 0x4E251 VA: 0x4E150
	protected Color32 m_faceColor; // 0x1D0
	protected Color32 m_outlineColor; // 0x1D4
	protected float m_outlineWidth; // 0x1D8
	[SerializeField] // RVA: 0x4E160 Offset: 0x4E261 VA: 0x4E160
	protected float m_fontSize; // 0x1DC
	protected float m_currentFontSize; // 0x1E0
	[SerializeField] // RVA: 0x4E170 Offset: 0x4E271 VA: 0x4E170
	protected float m_fontSizeBase; // 0x1E4
	protected TMP_TextProcessingStack<float> m_sizeStack; // 0x1E8
	[SerializeField] // RVA: 0x4E180 Offset: 0x4E281 VA: 0x4E180
	protected FontWeight m_fontWeight; // 0x208
	protected FontWeight m_FontWeightInternal; // 0x20C
	protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; // 0x210
	[SerializeField] // RVA: 0x4E190 Offset: 0x4E291 VA: 0x4E190
	protected bool m_enableAutoSizing; // 0x230
	protected float m_maxFontSize; // 0x234
	protected float m_minFontSize; // 0x238
	protected int m_AutoSizeIterationCount; // 0x23C
	protected int m_AutoSizeMaxIterationCount; // 0x240
	protected bool m_IsAutoSizePointSizeSet; // 0x244
	[SerializeField] // RVA: 0x4E1A0 Offset: 0x4E2A1 VA: 0x4E1A0
	protected float m_fontSizeMin; // 0x248
	[SerializeField] // RVA: 0x4E1B0 Offset: 0x4E2B1 VA: 0x4E1B0
	protected float m_fontSizeMax; // 0x24C
	[SerializeField] // RVA: 0x4E1C0 Offset: 0x4E2C1 VA: 0x4E1C0
	protected FontStyles m_fontStyle; // 0x250
	protected FontStyles m_FontStyleInternal; // 0x254
	protected TMP_FontStyleStack m_fontStyleStack; // 0x258
	protected bool m_isUsingBold; // 0x262
	[SerializeField] // RVA: 0x4E1D0 Offset: 0x4E2D1 VA: 0x4E1D0
	protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x264
	[SerializeField] // RVA: 0x4E1E0 Offset: 0x4E2E1 VA: 0x4E1E0
	protected VerticalAlignmentOptions m_VerticalAlignment; // 0x268
	[SerializeField] // RVA: 0x4E1F0 Offset: 0x4E2F1 VA: 0x4E1F0
	[FormerlySerializedAsAttribute] // RVA: 0x4E1F0 Offset: 0x4E2F1 VA: 0x4E1F0
	protected TextAlignmentOptions m_textAlignment; // 0x26C
	protected HorizontalAlignmentOptions m_lineJustification; // 0x270
	protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x278
	protected Vector3[] m_textContainerLocalCorners; // 0x298
	[SerializeField] // RVA: 0x4E240 Offset: 0x4E341 VA: 0x4E240
	protected float m_characterSpacing; // 0x2A0
	protected float m_cSpacing; // 0x2A4
	protected float m_monoSpacing; // 0x2A8
	[SerializeField] // RVA: 0x4E250 Offset: 0x4E351 VA: 0x4E250
	protected float m_wordSpacing; // 0x2AC
	[SerializeField] // RVA: 0x4E260 Offset: 0x4E361 VA: 0x4E260
	protected float m_lineSpacing; // 0x2B0
	protected float m_lineSpacingDelta; // 0x2B4
	protected float m_lineHeight; // 0x2B8
	protected bool m_IsDrivenLineSpacing; // 0x2BC
	[SerializeField] // RVA: 0x4E270 Offset: 0x4E371 VA: 0x4E270
	protected float m_lineSpacingMax; // 0x2C0
	[SerializeField] // RVA: 0x4E280 Offset: 0x4E381 VA: 0x4E280
	protected float m_paragraphSpacing; // 0x2C4
	[SerializeField] // RVA: 0x4E290 Offset: 0x4E391 VA: 0x4E290
	protected float m_charWidthMaxAdj; // 0x2C8
	protected float m_charWidthAdjDelta; // 0x2CC
	[SerializeField] // RVA: 0x4E2A0 Offset: 0x4E3A1 VA: 0x4E2A0
	protected bool m_enableWordWrapping; // 0x2D0
	protected bool m_isCharacterWrappingEnabled; // 0x2D1
	protected bool m_isNonBreakingSpace; // 0x2D2
	protected bool m_isIgnoringAlignment; // 0x2D3
	[SerializeField] // RVA: 0x4E2B0 Offset: 0x4E3B1 VA: 0x4E2B0
	protected float m_wordWrappingRatios; // 0x2D4
	[SerializeField] // RVA: 0x4E2C0 Offset: 0x4E3C1 VA: 0x4E2C0
	protected TextOverflowModes m_overflowMode; // 0x2D8
	protected int m_firstOverflowCharacterIndex; // 0x2DC
	[SerializeField] // RVA: 0x4E2D0 Offset: 0x4E3D1 VA: 0x4E2D0
	protected TMP_Text m_linkedTextComponent; // 0x2E0
	[SerializeField] // RVA: 0x4E2E0 Offset: 0x4E3E1 VA: 0x4E2E0
	internal TMP_Text parentLinkedComponent; // 0x2E8
	protected bool m_isTextTruncated; // 0x2F0
	[SerializeField] // RVA: 0x4E2F0 Offset: 0x4E3F1 VA: 0x4E2F0
	protected bool m_enableKerning; // 0x2F1
	protected float m_GlyphHorizontalAdvanceAdjustment; // 0x2F4
	[SerializeField] // RVA: 0x4E300 Offset: 0x4E401 VA: 0x4E300
	protected bool m_enableExtraPadding; // 0x2F8
	[SerializeField] // RVA: 0x4E310 Offset: 0x4E411 VA: 0x4E310
	protected bool checkPaddingRequired; // 0x2F9
	[SerializeField] // RVA: 0x4E320 Offset: 0x4E421 VA: 0x4E320
	protected bool m_isRichText; // 0x2FA
	[SerializeField] // RVA: 0x4E330 Offset: 0x4E431 VA: 0x4E330
	protected bool m_parseCtrlCharacters; // 0x2FB
	protected bool m_isOverlay; // 0x2FC
	[SerializeField] // RVA: 0x4E340 Offset: 0x4E441 VA: 0x4E340
	protected bool m_isOrthographic; // 0x2FD
	[SerializeField] // RVA: 0x4E350 Offset: 0x4E451 VA: 0x4E350
	protected bool m_isCullingEnabled; // 0x2FE
	protected bool m_isMaskingEnabled; // 0x2FF
	protected bool isMaskUpdateRequired; // 0x300
	protected bool m_ignoreCulling; // 0x301
	[SerializeField] // RVA: 0x4E360 Offset: 0x4E461 VA: 0x4E360
	protected TextureMappingOptions m_horizontalMapping; // 0x304
	[SerializeField] // RVA: 0x4E370 Offset: 0x4E471 VA: 0x4E370
	protected TextureMappingOptions m_verticalMapping; // 0x308
	[SerializeField] // RVA: 0x4E380 Offset: 0x4E481 VA: 0x4E380
	protected float m_uvLineOffset; // 0x30C
	protected TextRenderFlags m_renderMode; // 0x310
	[SerializeField] // RVA: 0x4E390 Offset: 0x4E491 VA: 0x4E390
	protected VertexSortingOrder m_geometrySortingOrder; // 0x314
	[SerializeField] // RVA: 0x4E3A0 Offset: 0x4E4A1 VA: 0x4E3A0
	protected bool m_IsTextObjectScaleStatic; // 0x318
	[SerializeField] // RVA: 0x4E3B0 Offset: 0x4E4B1 VA: 0x4E3B0
	protected bool m_VertexBufferAutoSizeReduction; // 0x319
	protected int m_firstVisibleCharacter; // 0x31C
	protected int m_maxVisibleCharacters; // 0x320
	protected int m_maxVisibleWords; // 0x324
	protected int m_maxVisibleLines; // 0x328
	[SerializeField] // RVA: 0x4E3C0 Offset: 0x4E4C1 VA: 0x4E3C0
	protected bool m_useMaxVisibleDescender; // 0x32C
	[SerializeField] // RVA: 0x4E3D0 Offset: 0x4E4D1 VA: 0x4E3D0
	protected int m_pageToDisplay; // 0x330
	protected bool m_isNewPage; // 0x334
	[SerializeField] // RVA: 0x4E3E0 Offset: 0x4E4E1 VA: 0x4E3E0
	protected Vector4 m_margin; // 0x338
	protected float m_marginLeft; // 0x348
	protected float m_marginRight; // 0x34C
	protected float m_marginWidth; // 0x350
	protected float m_marginHeight; // 0x354
	protected float m_width; // 0x358
	protected TMP_TextInfo m_textInfo; // 0x360
	protected bool m_havePropertiesChanged; // 0x368
	[SerializeField] // RVA: 0x4E3F0 Offset: 0x4E4F1 VA: 0x4E3F0
	protected bool m_isUsingLegacyAnimationComponent; // 0x369
	protected Transform m_transform; // 0x370
	protected RectTransform m_rectTransform; // 0x378
	protected Vector2 m_PreviousRectTransformSize; // 0x380
	protected Vector2 m_PreviousPivotPosition; // 0x388
	[CompilerGeneratedAttribute] // RVA: 0x4E400 Offset: 0x4E501 VA: 0x4E400
	private bool <autoSizeTextContainer>k__BackingField; // 0x390
	protected bool m_autoSizeTextContainer; // 0x391
	protected Mesh m_mesh; // 0x398
	[SerializeField] // RVA: 0x4E410 Offset: 0x4E511 VA: 0x4E410
	protected bool m_isVolumetricText; // 0x3A0
	[CompilerGeneratedAttribute] // RVA: 0x4E420 Offset: 0x4E521 VA: 0x4E420
	private static Func<int, string, TMP_FontAsset> OnFontAssetRequest; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x4E430 Offset: 0x4E531 VA: 0x4E430
	private static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x4E440 Offset: 0x4E541 VA: 0x4E440
	private Action<TMP_TextInfo> OnPreRenderText; // 0x3A8
	protected TMP_SpriteAnimator m_spriteAnimator; // 0x3B0
	protected float m_flexibleHeight; // 0x3B8
	protected float m_flexibleWidth; // 0x3BC
	protected float m_minWidth; // 0x3C0
	protected float m_minHeight; // 0x3C4
	protected float m_maxWidth; // 0x3C8
	protected float m_maxHeight; // 0x3CC
	protected LayoutElement m_LayoutElement; // 0x3D0
	protected float m_preferredWidth; // 0x3D8
	protected float m_renderedWidth; // 0x3DC
	protected bool m_isPreferredWidthDirty; // 0x3E0
	protected float m_preferredHeight; // 0x3E4
	protected float m_renderedHeight; // 0x3E8
	protected bool m_isPreferredHeightDirty; // 0x3EC
	protected bool m_isCalculatingPreferredValues; // 0x3ED
	protected int m_layoutPriority; // 0x3F0
	protected bool m_isLayoutDirty; // 0x3F4
	protected bool m_isAwake; // 0x3F5
	internal bool m_isWaitingOnResourceLoad; // 0x3F6
	internal TMP_Text.TextInputSources m_inputSource; // 0x3F8
	protected float m_fontScaleMultiplier; // 0x3FC
	private static char[] m_htmlTag; // 0x80
	private static RichTextTagAttribute[] m_xmlAttribute; // 0x88
	private static float[] m_attributeParameterValues; // 0x90
	protected float tag_LineIndent; // 0x400
	protected float tag_Indent; // 0x404
	protected TMP_TextProcessingStack<float> m_indentStack; // 0x408
	protected bool tag_NoParsing; // 0x428
	protected bool m_isParsingText; // 0x429
	protected Matrix4x4 m_FXMatrix; // 0x42C
	protected bool m_isFXMatrixSet; // 0x46C
	internal TMP_Text.UnicodeChar[] m_TextProcessingArray; // 0x470
	internal int m_InternalTextProcessingArraySize; // 0x478
	private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x480
	protected int m_totalCharacterCount; // 0x488
	protected static WordWrapState m_SavedWordWrapState; // 0x98
	protected static WordWrapState m_SavedLineState; // 0x410
	protected static WordWrapState m_SavedEllipsisState; // 0x788
	protected static WordWrapState m_SavedLastValidState; // 0xB00
	protected static WordWrapState m_SavedSoftLineBreakState; // 0xE78
	internal static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x11F0
	protected int m_characterCount; // 0x48C
	protected int m_firstCharacterOfLine; // 0x490
	protected int m_firstVisibleCharacterOfLine; // 0x494
	protected int m_lastCharacterOfLine; // 0x498
	protected int m_lastVisibleCharacterOfLine; // 0x49C
	protected int m_lineNumber; // 0x4A0
	protected int m_lineVisibleCharacterCount; // 0x4A4
	protected int m_pageNumber; // 0x4A8
	protected float m_PageAscender; // 0x4AC
	protected float m_maxTextAscender; // 0x4B0
	protected float m_maxCapHeight; // 0x4B4
	protected float m_ElementAscender; // 0x4B8
	protected float m_ElementDescender; // 0x4BC
	protected float m_maxLineAscender; // 0x4C0
	protected float m_maxLineDescender; // 0x4C4
	protected float m_startOfLineAscender; // 0x4C8
	protected float m_startOfLineDescender; // 0x4CC
	protected float m_lineOffset; // 0x4D0
	protected Extents m_meshExtents; // 0x4D4
	protected Color32 m_htmlColor; // 0x4E4
	protected TMP_TextProcessingStack<Color32> m_colorStack; // 0x4E8
	protected TMP_TextProcessingStack<Color32> m_underlineColorStack; // 0x508
	protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; // 0x528
	protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x548
	protected TMP_ColorGradient m_colorGradientPreset; // 0x578
	protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; // 0x580
	protected bool m_colorGradientPresetIsTinted; // 0x5A8
	protected float m_tabSpacing; // 0x5AC
	protected float m_spacing; // 0x5B0
	protected TMP_TextProcessingStack<int>[] m_TextStyleStacks; // 0x5B8
	protected int m_TextStyleStackDepth; // 0x5C0
	protected TMP_TextProcessingStack<int> m_ItalicAngleStack; // 0x5C8
	protected int m_ItalicAngle; // 0x5E8
	protected TMP_TextProcessingStack<int> m_actionStack; // 0x5F0
	protected float m_padding; // 0x610
	protected float m_baselineOffset; // 0x614
	protected TMP_TextProcessingStack<float> m_baselineOffsetStack; // 0x618
	protected float m_xAdvance; // 0x638
	protected TMP_TextElementType m_textElementType; // 0x63C
	protected TMP_TextElement m_cached_TextElement; // 0x640
	protected TMP_Text.SpecialCharacter m_Ellipsis; // 0x648
	protected TMP_Text.SpecialCharacter m_Underline; // 0x668
	protected TMP_SpriteAsset m_defaultSpriteAsset; // 0x688
	protected TMP_SpriteAsset m_currentSpriteAsset; // 0x690
	protected int m_spriteCount; // 0x698
	protected int m_spriteIndex; // 0x69C
	protected int m_spriteAnimationID; // 0x6A0
	private static ProfilerMarker k_ParseTextMarker; // 0x1588
	private static ProfilerMarker k_InsertNewLineMarker; // 0x1590
	protected bool m_ignoreActiveState; // 0x6A4
	private TMP_Text.TextBackingContainer m_TextBackingArray; // 0x6A8
	private readonly Decimal[] k_Power; // 0x6B8
	protected static Vector2 k_LargePositiveVector2; // 0x1598
	protected static Vector2 k_LargeNegativeVector2; // 0x15A0
	protected static float k_LargePositiveFloat; // 0x15A8
	protected static float k_LargeNegativeFloat; // 0x15AC
	protected static int k_LargePositiveInt; // 0x15B0
	protected static int k_LargeNegativeInt; // 0x15B4

	// Properties
	public virtual string text { get; set; }
	public ITextPreprocessor textPreprocessor { get; set; }
	public bool isRightToLeftText { get; set; }
	public TMP_FontAsset font { get; set; }
	public virtual Material fontSharedMaterial { get; set; }
	public virtual Material[] fontSharedMaterials { get; set; }
	public Material fontMaterial { get; set; }
	public virtual Material[] fontMaterials { get; set; }
	public override Color color { get; set; }
	public float alpha { get; set; }
	public bool enableVertexGradient { get; set; }
	public VertexGradient colorGradient { get; set; }
	public TMP_ColorGradient colorGradientPreset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public bool tintAllSprites { get; set; }
	public TMP_StyleSheet styleSheet { get; set; }
	public TMP_Style textStyle { get; set; }
	public bool overrideColorTags { get; set; }
	public Color32 faceColor { get; set; }
	public Color32 outlineColor { get; set; }
	public float outlineWidth { get; set; }
	public float fontSize { get; set; }
	public FontWeight fontWeight { get; set; }
	public float pixelsPerUnit { get; }
	public bool enableAutoSizing { get; set; }
	public float fontSizeMin { get; set; }
	public float fontSizeMax { get; set; }
	public FontStyles fontStyle { get; set; }
	public bool isUsingBold { get; }
	public HorizontalAlignmentOptions horizontalAlignment { get; set; }
	public VerticalAlignmentOptions verticalAlignment { get; set; }
	public TextAlignmentOptions alignment { get; set; }
	public float characterSpacing { get; set; }
	public float wordSpacing { get; set; }
	public float lineSpacing { get; set; }
	public float lineSpacingAdjustment { get; set; }
	public float paragraphSpacing { get; set; }
	public float characterWidthAdjustment { get; set; }
	public bool enableWordWrapping { get; set; }
	public float wordWrappingRatios { get; set; }
	public TextOverflowModes overflowMode { get; set; }
	public bool isTextOverflowing { get; }
	public int firstOverflowCharacterIndex { get; }
	public TMP_Text linkedTextComponent { get; set; }
	public bool isTextTruncated { get; }
	public bool enableKerning { get; set; }
	public bool extraPadding { get; set; }
	public bool richText { get; set; }
	public bool parseCtrlCharacters { get; set; }
	public bool isOverlay { get; set; }
	public bool isOrthographic { get; set; }
	public bool enableCulling { get; set; }
	public bool ignoreVisibility { get; set; }
	public TextureMappingOptions horizontalMapping { get; set; }
	public TextureMappingOptions verticalMapping { get; set; }
	public float mappingUvLineOffset { get; set; }
	public TextRenderFlags renderMode { get; set; }
	public VertexSortingOrder geometrySortingOrder { get; set; }
	public bool isTextObjectScaleStatic { get; set; }
	public bool vertexBufferAutoSizeReduction { get; set; }
	public int firstVisibleCharacter { get; set; }
	public int maxVisibleCharacters { get; set; }
	public int maxVisibleWords { get; set; }
	public int maxVisibleLines { get; set; }
	public bool useMaxVisibleDescender { get; set; }
	public int pageToDisplay { get; set; }
	public virtual Vector4 margin { get; set; }
	public TMP_TextInfo textInfo { get; }
	public bool havePropertiesChanged { get; set; }
	public bool isUsingLegacyAnimationComponent { get; set; }
	public Transform transform { get; }
	public RectTransform rectTransform { get; }
	public virtual bool autoSizeTextContainer { get; set; }
	public virtual Mesh mesh { get; }
	public bool isVolumetricText { get; set; }
	public Bounds bounds { get; }
	public Bounds textBounds { get; }
	protected TMP_SpriteAnimator spriteAnimator { get; }
	public float flexibleHeight { get; }
	public float flexibleWidth { get; }
	public float minWidth { get; }
	public float minHeight { get; }
	public float maxWidth { get; }
	public float maxHeight { get; }
	protected LayoutElement layoutElement { get; }
	public virtual float preferredWidth { get; }
	public virtual float preferredHeight { get; }
	public virtual float renderedWidth { get; }
	public virtual float renderedHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0x18FB990 Offset: 0x18FBA91 VA: 0x18FB990 Slot: 65
	public virtual string get_text() { }

	// RVA: 0x18FBA90 Offset: 0x18FBB91 VA: 0x18FBA90 Slot: 66
	public virtual void set_text(string value) { }

	// RVA: 0x18FBB40 Offset: 0x18FBC41 VA: 0x18FBB40
	public ITextPreprocessor get_textPreprocessor() { }

	// RVA: 0x18FBB50 Offset: 0x18FBC51 VA: 0x18FBB50
	public void set_textPreprocessor(ITextPreprocessor value) { }

	// RVA: 0x18FBB60 Offset: 0x18FBC61 VA: 0x18FBB60
	public bool get_isRightToLeftText() { }

	// RVA: 0x18FBB70 Offset: 0x18FBC71 VA: 0x18FBB70
	public void set_isRightToLeftText(bool value) { }

	// RVA: 0x18FBBE0 Offset: 0x18FBCE1 VA: 0x18FBBE0
	public TMP_FontAsset get_font() { }

	// RVA: 0x18FBBF0 Offset: 0x18FBCF1 VA: 0x18FBBF0
	public void set_font(TMP_FontAsset value) { }

	// RVA: 0x18FBCE0 Offset: 0x18FBDE1 VA: 0x18FBCE0 Slot: 67
	public virtual Material get_fontSharedMaterial() { }

	// RVA: 0x18FBCF0 Offset: 0x18FBDF1 VA: 0x18FBCF0 Slot: 68
	public virtual void set_fontSharedMaterial(Material value) { }

	// RVA: 0x18FBDD0 Offset: 0x18FBED1 VA: 0x18FBDD0 Slot: 69
	public virtual Material[] get_fontSharedMaterials() { }

	// RVA: 0x18FBDE0 Offset: 0x18FBEE1 VA: 0x18FBDE0 Slot: 70
	public virtual void set_fontSharedMaterials(Material[] value) { }

	// RVA: 0x18FBE40 Offset: 0x18FBF41 VA: 0x18FBE40
	public Material get_fontMaterial() { }

	// RVA: 0x18FBE60 Offset: 0x18FBF61 VA: 0x18FBE60
	public void set_fontMaterial(Material value) { }

	// RVA: 0x18FBF70 Offset: 0x18FC071 VA: 0x18FBF70 Slot: 71
	public virtual Material[] get_fontMaterials() { }

	// RVA: 0x18FBF90 Offset: 0x18FC091 VA: 0x18FBF90 Slot: 72
	public virtual void set_fontMaterials(Material[] value) { }

	// RVA: 0x18FBFF0 Offset: 0x18FC0F1 VA: 0x18FBFF0 Slot: 22
	public override Color get_color() { }

	// RVA: 0x18FC010 Offset: 0x18FC111 VA: 0x18FC010 Slot: 23
	public override void set_color(Color value) { }

	// RVA: 0x18FC0C0 Offset: 0x18FC1C1 VA: 0x18FC0C0
	public float get_alpha() { }

	// RVA: 0x18FC0D0 Offset: 0x18FC1D1 VA: 0x18FC0D0
	public void set_alpha(float value) { }

	// RVA: 0x18FC100 Offset: 0x18FC201 VA: 0x18FC100
	public bool get_enableVertexGradient() { }

	// RVA: 0x18FC110 Offset: 0x18FC211 VA: 0x18FC110
	public void set_enableVertexGradient(bool value) { }

	// RVA: 0x18FC150 Offset: 0x18FC251 VA: 0x18FC150
	public VertexGradient get_colorGradient() { }

	// RVA: 0x18FC180 Offset: 0x18FC281 VA: 0x18FC180
	public void set_colorGradient(VertexGradient value) { }

	// RVA: 0x18FC1C0 Offset: 0x18FC2C1 VA: 0x18FC1C0
	public TMP_ColorGradient get_colorGradientPreset() { }

	// RVA: 0x18FC1D0 Offset: 0x18FC2D1 VA: 0x18FC1D0
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	// RVA: 0x18FC210 Offset: 0x18FC311 VA: 0x18FC210
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x18FC220 Offset: 0x18FC321 VA: 0x18FC220
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x18FC280 Offset: 0x18FC381 VA: 0x18FC280
	public bool get_tintAllSprites() { }

	// RVA: 0x18FC290 Offset: 0x18FC391 VA: 0x18FC290
	public void set_tintAllSprites(bool value) { }

	// RVA: 0x18FC2D0 Offset: 0x18FC3D1 VA: 0x18FC2D0
	public TMP_StyleSheet get_styleSheet() { }

	// RVA: 0x18FC2E0 Offset: 0x18FC3E1 VA: 0x18FC2E0
	public void set_styleSheet(TMP_StyleSheet value) { }

	// RVA: 0x18FC340 Offset: 0x18FC441 VA: 0x18FC340
	public TMP_Style get_textStyle() { }

	// RVA: 0x18FC540 Offset: 0x18FC641 VA: 0x18FC540
	public void set_textStyle(TMP_Style value) { }

	// RVA: 0x18FC5A0 Offset: 0x18FC6A1 VA: 0x18FC5A0
	public bool get_overrideColorTags() { }

	// RVA: 0x18FC5B0 Offset: 0x18FC6B1 VA: 0x18FC5B0
	public void set_overrideColorTags(bool value) { }

	// RVA: 0x18FC5F0 Offset: 0x18FC6F1 VA: 0x18FC5F0
	public Color32 get_faceColor() { }

	// RVA: 0x18FC6E0 Offset: 0x18FC7E1 VA: 0x18FC6E0
	public void set_faceColor(Color32 value) { }

	// RVA: 0x18FC780 Offset: 0x18FC881 VA: 0x18FC780
	public Color32 get_outlineColor() { }

	// RVA: 0x18FC870 Offset: 0x18FC971 VA: 0x18FC870
	public void set_outlineColor(Color32 value) { }

	// RVA: 0x18FC900 Offset: 0x18FCA01 VA: 0x18FC900
	public float get_outlineWidth() { }

	// RVA: 0x18FC9E0 Offset: 0x18FCAE1 VA: 0x18FC9E0
	public void set_outlineWidth(float value) { }

	// RVA: 0x18FCA60 Offset: 0x18FCB61 VA: 0x18FCA60
	public float get_fontSize() { }

	// RVA: 0x18FCA70 Offset: 0x18FCB71 VA: 0x18FCA70
	public void set_fontSize(float value) { }

	// RVA: 0x18FCAE0 Offset: 0x18FCBE1 VA: 0x18FCAE0
	public FontWeight get_fontWeight() { }

	// RVA: 0x18FCAF0 Offset: 0x18FCBF1 VA: 0x18FCAF0
	public void set_fontWeight(FontWeight value) { }

	// RVA: 0x18FCB50 Offset: 0x18FCC51 VA: 0x18FCB50
	public float get_pixelsPerUnit() { }

	// RVA: 0x18FCCE0 Offset: 0x18FCDE1 VA: 0x18FCCE0
	public bool get_enableAutoSizing() { }

	// RVA: 0x18FCCF0 Offset: 0x18FCDF1 VA: 0x18FCCF0
	public void set_enableAutoSizing(bool value) { }

	// RVA: 0x18FCD60 Offset: 0x18FCE61 VA: 0x18FCD60
	public float get_fontSizeMin() { }

	// RVA: 0x18FCD70 Offset: 0x18FCE71 VA: 0x18FCD70
	public void set_fontSizeMin(float value) { }

	// RVA: 0x18FCDD0 Offset: 0x18FCED1 VA: 0x18FCDD0
	public float get_fontSizeMax() { }

	// RVA: 0x18FCDE0 Offset: 0x18FCEE1 VA: 0x18FCDE0
	public void set_fontSizeMax(float value) { }

	// RVA: 0x18FCE40 Offset: 0x18FCF41 VA: 0x18FCE40
	public FontStyles get_fontStyle() { }

	// RVA: 0x18FCE50 Offset: 0x18FCF51 VA: 0x18FCE50
	public void set_fontStyle(FontStyles value) { }

	// RVA: 0x18FCEB0 Offset: 0x18FCFB1 VA: 0x18FCEB0
	public bool get_isUsingBold() { }

	// RVA: 0x18FCEC0 Offset: 0x18FCFC1 VA: 0x18FCEC0
	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	// RVA: 0x18FCED0 Offset: 0x18FCFD1 VA: 0x18FCED0
	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	// RVA: 0x18FCF00 Offset: 0x18FD001 VA: 0x18FCF00
	public VerticalAlignmentOptions get_verticalAlignment() { }

	// RVA: 0x18FCF10 Offset: 0x18FD011 VA: 0x18FCF10
	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	// RVA: 0x18FCF40 Offset: 0x18FD041 VA: 0x18FCF40
	public TextAlignmentOptions get_alignment() { }

	// RVA: 0x18FCF50 Offset: 0x18FD051 VA: 0x18FCF50
	public void set_alignment(TextAlignmentOptions value) { }

	// RVA: 0x18FCFA0 Offset: 0x18FD0A1 VA: 0x18FCFA0
	public float get_characterSpacing() { }

	// RVA: 0x18FCFB0 Offset: 0x18FD0B1 VA: 0x18FCFB0
	public void set_characterSpacing(float value) { }

	// RVA: 0x18FD010 Offset: 0x18FD111 VA: 0x18FD010
	public float get_wordSpacing() { }

	// RVA: 0x18FD020 Offset: 0x18FD121 VA: 0x18FD020
	public void set_wordSpacing(float value) { }

	// RVA: 0x18FD080 Offset: 0x18FD181 VA: 0x18FD080
	public float get_lineSpacing() { }

	// RVA: 0x18FD090 Offset: 0x18FD191 VA: 0x18FD090
	public void set_lineSpacing(float value) { }

	// RVA: 0x18FD0F0 Offset: 0x18FD1F1 VA: 0x18FD0F0
	public float get_lineSpacingAdjustment() { }

	// RVA: 0x18FD100 Offset: 0x18FD201 VA: 0x18FD100
	public void set_lineSpacingAdjustment(float value) { }

	// RVA: 0x18FD160 Offset: 0x18FD261 VA: 0x18FD160
	public float get_paragraphSpacing() { }

	// RVA: 0x18FD170 Offset: 0x18FD271 VA: 0x18FD170
	public void set_paragraphSpacing(float value) { }

	// RVA: 0x18FD1D0 Offset: 0x18FD2D1 VA: 0x18FD1D0
	public float get_characterWidthAdjustment() { }

	// RVA: 0x18FD1E0 Offset: 0x18FD2E1 VA: 0x18FD1E0
	public void set_characterWidthAdjustment(float value) { }

	// RVA: 0x18FD240 Offset: 0x18FD341 VA: 0x18FD240
	public bool get_enableWordWrapping() { }

	// RVA: 0x18FD250 Offset: 0x18FD351 VA: 0x18FD250
	public void set_enableWordWrapping(bool value) { }

	// RVA: 0x18FD2C0 Offset: 0x18FD3C1 VA: 0x18FD2C0
	public float get_wordWrappingRatios() { }

	// RVA: 0x18FD2D0 Offset: 0x18FD3D1 VA: 0x18FD2D0
	public void set_wordWrappingRatios(float value) { }

	// RVA: 0x18FD330 Offset: 0x18FD431 VA: 0x18FD330
	public TextOverflowModes get_overflowMode() { }

	// RVA: 0x18FD340 Offset: 0x18FD441 VA: 0x18FD340
	public void set_overflowMode(TextOverflowModes value) { }

	// RVA: 0x18FD3A0 Offset: 0x18FD4A1 VA: 0x18FD3A0
	public bool get_isTextOverflowing() { }

	// RVA: 0x18FD3B0 Offset: 0x18FD4B1 VA: 0x18FD3B0
	public int get_firstOverflowCharacterIndex() { }

	// RVA: 0x18FD3C0 Offset: 0x18FD4C1 VA: 0x18FD3C0
	public TMP_Text get_linkedTextComponent() { }

	// RVA: 0x18FD3D0 Offset: 0x18FD4D1 VA: 0x18FD3D0
	public void set_linkedTextComponent(TMP_Text value) { }

	// RVA: 0x18FD730 Offset: 0x18FD831 VA: 0x18FD730
	public bool get_isTextTruncated() { }

	// RVA: 0x18FD740 Offset: 0x18FD841 VA: 0x18FD740
	public bool get_enableKerning() { }

	// RVA: 0x18FD750 Offset: 0x18FD851 VA: 0x18FD750
	public void set_enableKerning(bool value) { }

	// RVA: 0x18FD7C0 Offset: 0x18FD8C1 VA: 0x18FD7C0
	public bool get_extraPadding() { }

	// RVA: 0x18FD7D0 Offset: 0x18FD8D1 VA: 0x18FD7D0
	public void set_extraPadding(bool value) { }

	// RVA: 0x18FD840 Offset: 0x18FD941 VA: 0x18FD840
	public bool get_richText() { }

	// RVA: 0x18FD850 Offset: 0x18FD951 VA: 0x18FD850
	public void set_richText(bool value) { }

	// RVA: 0x18FD8C0 Offset: 0x18FD9C1 VA: 0x18FD8C0
	public bool get_parseCtrlCharacters() { }

	// RVA: 0x18FD8D0 Offset: 0x18FD9D1 VA: 0x18FD8D0
	public void set_parseCtrlCharacters(bool value) { }

	// RVA: 0x18FD940 Offset: 0x18FDA41 VA: 0x18FD940
	public bool get_isOverlay() { }

	// RVA: 0x18FD950 Offset: 0x18FDA51 VA: 0x18FD950
	public void set_isOverlay(bool value) { }

	// RVA: 0x18FD9C0 Offset: 0x18FDAC1 VA: 0x18FD9C0
	public bool get_isOrthographic() { }

	// RVA: 0x18FD9D0 Offset: 0x18FDAD1 VA: 0x18FD9D0
	public void set_isOrthographic(bool value) { }

	// RVA: 0x18FDA10 Offset: 0x18FDB11 VA: 0x18FDA10
	public bool get_enableCulling() { }

	// RVA: 0x18FDA20 Offset: 0x18FDB21 VA: 0x18FDA20
	public void set_enableCulling(bool value) { }

	// RVA: 0x18FDA70 Offset: 0x18FDB71 VA: 0x18FDA70
	public bool get_ignoreVisibility() { }

	// RVA: 0x18FDA80 Offset: 0x18FDB81 VA: 0x18FDA80
	public void set_ignoreVisibility(bool value) { }

	// RVA: 0x18FDAB0 Offset: 0x18FDBB1 VA: 0x18FDAB0
	public TextureMappingOptions get_horizontalMapping() { }

	// RVA: 0x18FDAC0 Offset: 0x18FDBC1 VA: 0x18FDAC0
	public void set_horizontalMapping(TextureMappingOptions value) { }

	// RVA: 0x18FDAF0 Offset: 0x18FDBF1 VA: 0x18FDAF0
	public TextureMappingOptions get_verticalMapping() { }

	// RVA: 0x18FDB00 Offset: 0x18FDC01 VA: 0x18FDB00
	public void set_verticalMapping(TextureMappingOptions value) { }

	// RVA: 0x18FDB30 Offset: 0x18FDC31 VA: 0x18FDB30
	public float get_mappingUvLineOffset() { }

	// RVA: 0x18FDB40 Offset: 0x18FDC41 VA: 0x18FDB40
	public void set_mappingUvLineOffset(float value) { }

	// RVA: 0x18FDB70 Offset: 0x18FDC71 VA: 0x18FDB70
	public TextRenderFlags get_renderMode() { }

	// RVA: 0x18FDB80 Offset: 0x18FDC81 VA: 0x18FDB80
	public void set_renderMode(TextRenderFlags value) { }

	// RVA: 0x18FDBA0 Offset: 0x18FDCA1 VA: 0x18FDBA0
	public VertexSortingOrder get_geometrySortingOrder() { }

	// RVA: 0x18FDBB0 Offset: 0x18FDCB1 VA: 0x18FDBB0
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	// RVA: 0x18FDBD0 Offset: 0x18FDCD1 VA: 0x18FDBD0
	public bool get_isTextObjectScaleStatic() { }

	// RVA: 0x18FDBE0 Offset: 0x18FDCE1 VA: 0x18FDBE0
	public void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x18FDC90 Offset: 0x18FDD91 VA: 0x18FDC90
	public bool get_vertexBufferAutoSizeReduction() { }

	// RVA: 0x18FDCA0 Offset: 0x18FDDA1 VA: 0x18FDCA0
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	// RVA: 0x18FDCC0 Offset: 0x18FDDC1 VA: 0x18FDCC0
	public int get_firstVisibleCharacter() { }

	// RVA: 0x18FDCD0 Offset: 0x18FDDD1 VA: 0x18FDCD0
	public void set_firstVisibleCharacter(int value) { }

	// RVA: 0x18FDD00 Offset: 0x18FDE01 VA: 0x18FDD00
	public int get_maxVisibleCharacters() { }

	// RVA: 0x18FDD10 Offset: 0x18FDE11 VA: 0x18FDD10
	public void set_maxVisibleCharacters(int value) { }

	// RVA: 0x18FDD40 Offset: 0x18FDE41 VA: 0x18FDD40
	public int get_maxVisibleWords() { }

	// RVA: 0x18FDD50 Offset: 0x18FDE51 VA: 0x18FDD50
	public void set_maxVisibleWords(int value) { }

	// RVA: 0x18FDD80 Offset: 0x18FDE81 VA: 0x18FDD80
	public int get_maxVisibleLines() { }

	// RVA: 0x18FDD90 Offset: 0x18FDE91 VA: 0x18FDD90
	public void set_maxVisibleLines(int value) { }

	// RVA: 0x18FDDC0 Offset: 0x18FDEC1 VA: 0x18FDDC0
	public bool get_useMaxVisibleDescender() { }

	// RVA: 0x18FDDD0 Offset: 0x18FDED1 VA: 0x18FDDD0
	public void set_useMaxVisibleDescender(bool value) { }

	// RVA: 0x18FDE10 Offset: 0x18FDF11 VA: 0x18FDE10
	public int get_pageToDisplay() { }

	// RVA: 0x18FDE20 Offset: 0x18FDF21 VA: 0x18FDE20
	public void set_pageToDisplay(int value) { }

	// RVA: 0x18FDE50 Offset: 0x18FDF51 VA: 0x18FDE50 Slot: 73
	public virtual Vector4 get_margin() { }

	// RVA: 0x18FDE70 Offset: 0x18FDF71 VA: 0x18FDE70 Slot: 74
	public virtual void set_margin(Vector4 value) { }

	// RVA: 0x18FDF20 Offset: 0x18FE021 VA: 0x18FDF20
	public TMP_TextInfo get_textInfo() { }

	// RVA: 0x18FDF30 Offset: 0x18FE031 VA: 0x18FDF30
	public bool get_havePropertiesChanged() { }

	// RVA: 0x18F9B20 Offset: 0x18F9C21 VA: 0x18F9B20
	public void set_havePropertiesChanged(bool value) { }

	// RVA: 0x18FDF40 Offset: 0x18FE041 VA: 0x18FDF40
	public bool get_isUsingLegacyAnimationComponent() { }

	// RVA: 0x18FDF50 Offset: 0x18FE051 VA: 0x18FDF50
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	// RVA: 0x18FAC70 Offset: 0x18FAD71 VA: 0x18FAC70
	public Transform get_transform() { }

	// RVA: 0x18FAD30 Offset: 0x18FAE31 VA: 0x18FAD30
	public RectTransform get_rectTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x4E960 Offset: 0x4EA61 VA: 0x4E960
	// RVA: 0x18FDF60 Offset: 0x18FE061 VA: 0x18FDF60 Slot: 75
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGeneratedAttribute] // RVA: 0x4E970 Offset: 0x4EA71 VA: 0x4E970
	// RVA: 0x18FDF70 Offset: 0x18FE071 VA: 0x18FDF70 Slot: 76
	public virtual void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x18FDF80 Offset: 0x18FE081 VA: 0x18FDF80 Slot: 77
	public virtual Mesh get_mesh() { }

	// RVA: 0x18FDF90 Offset: 0x18FE091 VA: 0x18FDF90
	public bool get_isVolumetricText() { }

	// RVA: 0x18FDFA0 Offset: 0x18FE0A1 VA: 0x18FDFA0
	public void set_isVolumetricText(bool value) { }

	// RVA: 0x18FE020 Offset: 0x18FE121 VA: 0x18FE020
	public Bounds get_bounds() { }

	// RVA: 0x18FE0E0 Offset: 0x18FE1E1 VA: 0x18FE0E0
	public Bounds get_textBounds() { }

	[CompilerGeneratedAttribute] // RVA: 0x4E980 Offset: 0x4EA81 VA: 0x4E980
	// RVA: 0x18FE340 Offset: 0x18FE441 VA: 0x18FE340
	public static void add_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4E990 Offset: 0x4EA91 VA: 0x4E990
	// RVA: 0x18FE440 Offset: 0x18FE541 VA: 0x18FE440
	public static void remove_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4E9A0 Offset: 0x4EAA1 VA: 0x4E9A0
	// RVA: 0x18FE540 Offset: 0x18FE641 VA: 0x18FE540
	public static void add_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4E9B0 Offset: 0x4EAB1 VA: 0x4E9B0
	// RVA: 0x18FE640 Offset: 0x18FE741 VA: 0x18FE640
	public static void remove_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4E9C0 Offset: 0x4EAC1 VA: 0x4E9C0
	// RVA: 0x18FE740 Offset: 0x18FE841 VA: 0x18FE740 Slot: 78
	public virtual void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x4E9D0 Offset: 0x4EAD1 VA: 0x4E9D0
	// RVA: 0x18FE7F0 Offset: 0x18FE8F1 VA: 0x18FE7F0 Slot: 79
	public virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x18FE8A0 Offset: 0x18FE9A1 VA: 0x18FE8A0
	protected TMP_SpriteAnimator get_spriteAnimator() { }

	// RVA: 0x18FE9C0 Offset: 0x18FEAC1 VA: 0x18FE9C0 Slot: 80
	public float get_flexibleHeight() { }

	// RVA: 0x18FE9D0 Offset: 0x18FEAD1 VA: 0x18FE9D0 Slot: 81
	public float get_flexibleWidth() { }

	// RVA: 0x18FE9E0 Offset: 0x18FEAE1 VA: 0x18FE9E0 Slot: 82
	public float get_minWidth() { }

	// RVA: 0x18FE9F0 Offset: 0x18FEAF1 VA: 0x18FE9F0 Slot: 83
	public float get_minHeight() { }

	// RVA: 0x18FEA00 Offset: 0x18FEB01 VA: 0x18FEA00
	public float get_maxWidth() { }

	// RVA: 0x18FEA10 Offset: 0x18FEB11 VA: 0x18FEA10
	public float get_maxHeight() { }

	// RVA: 0x18FEA20 Offset: 0x18FEB21 VA: 0x18FEA20
	protected LayoutElement get_layoutElement() { }

	// RVA: 0x18FEAE0 Offset: 0x18FEBE1 VA: 0x18FEAE0 Slot: 84
	public virtual float get_preferredWidth() { }

	// RVA: 0x18FEC60 Offset: 0x18FED61 VA: 0x18FEC60 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x18FEE30 Offset: 0x18FEF31 VA: 0x18FEE30 Slot: 86
	public virtual float get_renderedWidth() { }

	// RVA: 0x18FEED0 Offset: 0x18FEFD1 VA: 0x18FEED0 Slot: 87
	public virtual float get_renderedHeight() { }

	// RVA: 0x18FEF70 Offset: 0x18FF071 VA: 0x18FEF70 Slot: 88
	public int get_layoutPriority() { }

	// RVA: 0x18FEF80 Offset: 0x18FF081 VA: 0x18FEF80 Slot: 89
	protected virtual void LoadFontAsset() { }

	// RVA: 0x18FEF90 Offset: 0x18FF091 VA: 0x18FEF90 Slot: 90
	protected virtual void SetSharedMaterial(Material mat) { }

	// RVA: 0x18FEFA0 Offset: 0x18FF0A1 VA: 0x18FEFA0 Slot: 91
	protected virtual Material GetMaterial(Material mat) { }

	// RVA: 0x18FEFB0 Offset: 0x18FF0B1 VA: 0x18FEFB0 Slot: 92
	protected virtual void SetFontBaseMaterial(Material mat) { }

	// RVA: 0x18FEFC0 Offset: 0x18FF0C1 VA: 0x18FEFC0 Slot: 93
	protected virtual Material[] GetSharedMaterials() { }

	// RVA: 0x18FEFD0 Offset: 0x18FF0D1 VA: 0x18FEFD0 Slot: 94
	protected virtual void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x18FEFE0 Offset: 0x18FF0E1 VA: 0x18FEFE0 Slot: 95
	protected virtual Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x18FEFF0 Offset: 0x18FF0F1 VA: 0x18FEFF0 Slot: 96
	protected virtual Material CreateMaterialInstance(Material source) { }

	// RVA: 0x18FF0B0 Offset: 0x18FF1B1 VA: 0x18FF0B0
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	// RVA: 0x18FF1A0 Offset: 0x18FF2A1 VA: 0x18FF1A0
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	// RVA: 0x18FF1B0 Offset: 0x18FF2B1 VA: 0x18FF1B0
	protected void SetTextSortingOrder(int[] order) { }

	// RVA: 0x18FF1C0 Offset: 0x18FF2C1 VA: 0x18FF1C0 Slot: 97
	protected virtual void SetFaceColor(Color32 color) { }

	// RVA: 0x18FF1D0 Offset: 0x18FF2D1 VA: 0x18FF1D0 Slot: 98
	protected virtual void SetOutlineColor(Color32 color) { }

	// RVA: 0x18FF1E0 Offset: 0x18FF2E1 VA: 0x18FF1E0 Slot: 99
	protected virtual void SetOutlineThickness(float thickness) { }

	// RVA: 0x18FF1F0 Offset: 0x18FF2F1 VA: 0x18FF1F0 Slot: 100
	protected virtual void SetShaderDepth() { }

	// RVA: 0x18FF200 Offset: 0x18FF301 VA: 0x18FF200 Slot: 101
	protected virtual void SetCulling() { }

	// RVA: 0x18FF210 Offset: 0x18FF311 VA: 0x18FF210 Slot: 102
	internal virtual void UpdateCulling() { }

	// RVA: 0x18FF220 Offset: 0x18FF321 VA: 0x18FF220 Slot: 103
	protected virtual float GetPaddingForMaterial() { }

	// RVA: 0x18FF360 Offset: 0x18FF461 VA: 0x18FF360 Slot: 104
	protected virtual float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x18FF480 Offset: 0x18FF581 VA: 0x18FF480 Slot: 105
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x18FF490 Offset: 0x18FF591 VA: 0x18FF490 Slot: 106
	public virtual void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x18FF4A0 Offset: 0x18FF5A1 VA: 0x18FF4A0 Slot: 107
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x18FF4B0 Offset: 0x18FF5B1 VA: 0x18FF4B0 Slot: 108
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x18FF4C0 Offset: 0x18FF5C1 VA: 0x18FF4C0 Slot: 109
	public virtual void UpdateVertexData() { }

	// RVA: 0x18FF4D0 Offset: 0x18FF5D1 VA: 0x18FF4D0 Slot: 110
	public virtual void SetVertices(Vector3[] vertices) { }

	// RVA: 0x18FF4E0 Offset: 0x18FF5E1 VA: 0x18FF4E0 Slot: 111
	public virtual void UpdateMeshPadding() { }

	// RVA: 0x18FF4F0 Offset: 0x18FF5F1 VA: 0x18FF4F0 Slot: 47
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x18FF590 Offset: 0x18FF691 VA: 0x18FF590 Slot: 49
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x18FF5F0 Offset: 0x18FF6F1 VA: 0x18FF5F0 Slot: 112
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x18FF600 Offset: 0x18FF701 VA: 0x18FF600 Slot: 113
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x18FF610 Offset: 0x18FF711 VA: 0x18FF610
	protected void ParseInputText() { }

	// RVA: 0x18FF720 Offset: 0x18FF821 VA: 0x18FF720
	private void PopulateTextBackingArray(string sourceText) { }

	// RVA: 0x19002F0 Offset: 0x19003F1 VA: 0x19002F0
	private void PopulateTextBackingArray(string sourceText, int start, int length) { }

	// RVA: 0x1900400 Offset: 0x1900501 VA: 0x1900400
	private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length) { }

	// RVA: 0x1900540 Offset: 0x1900641 VA: 0x1900540
	private void PopulateTextBackingArray(char[] sourceText, int start, int length) { }

	// RVA: 0x18FF740 Offset: 0x18FF841 VA: 0x18FF740
	private void PopulateTextProcessingArray() { }

	// RVA: 0x1901900 Offset: 0x1901A01 VA: 0x1901900
	private void SetTextInternal(string sourceText) { }

	// RVA: 0x1901950 Offset: 0x1901A51 VA: 0x1901950
	public void SetText(string sourceText, bool syncTextInputBox = True) { }

	// RVA: 0x19019E0 Offset: 0x1901AE1 VA: 0x19019E0
	public void SetText(string sourceText, float arg0) { }

	// RVA: 0x1901CD0 Offset: 0x1901DD1 VA: 0x1901CD0
	public void SetText(string sourceText, float arg0, float arg1) { }

	// RVA: 0x1901CF0 Offset: 0x1901DF1 VA: 0x1901CF0
	public void SetText(string sourceText, float arg0, float arg1, float arg2) { }

	// RVA: 0x1901D10 Offset: 0x1901E11 VA: 0x1901D10
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3) { }

	// RVA: 0x1901D30 Offset: 0x1901E31 VA: 0x1901D30
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	// RVA: 0x1901D40 Offset: 0x1901E41 VA: 0x1901D40
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	// RVA: 0x1901D50 Offset: 0x1901E51 VA: 0x1901D50
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	// RVA: 0x1901A00 Offset: 0x1901B01 VA: 0x1901A00
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	// RVA: 0x1902090 Offset: 0x1902191 VA: 0x1902090
	public void SetText(StringBuilder sourceText) { }

	// RVA: 0x1902120 Offset: 0x1902221 VA: 0x1902120
	private void SetText(StringBuilder sourceText, int start, int length) { }

	// RVA: 0x1902180 Offset: 0x1902281 VA: 0x1902180
	public void SetText(char[] sourceText) { }

	// RVA: 0x1902260 Offset: 0x1902361 VA: 0x1902260
	public void SetText(char[] sourceText, int start, int length) { }

	// RVA: 0x19022C0 Offset: 0x19023C1 VA: 0x19022C0
	public void SetCharArray(char[] sourceText) { }

	// RVA: 0x1902200 Offset: 0x1902301 VA: 0x1902200
	public void SetCharArray(char[] sourceText, int start, int length) { }

	// RVA: 0x18FC3B0 Offset: 0x18FC4B1 VA: 0x18FC3B0
	private TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x1900D50 Offset: 0x1900E51 VA: 0x1900D50
	private bool ReplaceOpeningStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x19027A0 Offset: 0x19028A1 VA: 0x19027A0
	private bool ReplaceOpeningStyleTag(ref int[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1901160 Offset: 0x1901261 VA: 0x1901160
	private void ReplaceClosingStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1902BB0 Offset: 0x1902CB1 VA: 0x1902BB0
	private void ReplaceClosingStyleTag(ref int[] sourceText, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1900680 Offset: 0x1900781 VA: 0x1900680
	private bool InsertOpeningStyleTag(TMP_Style style, int srcIndex, ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1901540 Offset: 0x1901641 VA: 0x1901540
	private void InsertClosingStyleTag(ref TMP_Text.UnicodeChar[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1902670 Offset: 0x1902771 VA: 0x1902670
	private int GetMarkupTagHashCode(int[] tagDefinition, int readIndex) { }

	// RVA: 0x1900C30 Offset: 0x1900D31 VA: 0x1900C30
	private int GetMarkupTagHashCode(TMP_Text.TextBackingContainer tagDefinition, int readIndex) { }

	// RVA: 0x1902F90 Offset: 0x1903091 VA: 0x1902F90
	private int GetStyleHashCode(ref int[] text, int index, out int closeIndex) { }

	// RVA: 0x1902340 Offset: 0x1902441 VA: 0x1902340
	private int GetStyleHashCode(ref TMP_Text.TextBackingContainer text, int index, out int closeIndex) { }

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2023D30 Offset: 0x2023E31 VA: 0x2023D30
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x2023D80 Offset: 0x2023E81 VA: 0x2023D80
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2023DD0 Offset: 0x2023ED1 VA: 0x2023DD0
	|-TMP_Text.ResizeInternalArray<object>
	|
	|-RVA: 0x2023E10 Offset: 0x2023F11 VA: 0x2023E10
	|-TMP_Text.ResizeInternalArray<TMP_Text.UnicodeChar>
	*/

	// RVA: 0x1901D60 Offset: 0x1901E61 VA: 0x1901D60
	private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex) { }

	// RVA: 0x19030A0 Offset: 0x19031A1 VA: 0x19030A0
	private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex) { }

	// RVA: 0x18FB9B0 Offset: 0x18FBAB1 VA: 0x18FB9B0
	private string InternalTextBackingArrayToString() { }

	// RVA: 0x19031E0 Offset: 0x19032E1 VA: 0x19031E0 Slot: 114
	internal virtual int SetArraySizes(TMP_Text.UnicodeChar[] unicodeChars) { }

	// RVA: 0x19031F0 Offset: 0x19032F1 VA: 0x19031F0
	public Vector2 GetPreferredValues() { }

	// RVA: 0x1903240 Offset: 0x1903341 VA: 0x1903240
	public Vector2 GetPreferredValues(float width, float height) { }

	// RVA: 0x1903490 Offset: 0x1903591 VA: 0x1903490
	public Vector2 GetPreferredValues(string text) { }

	// RVA: 0x1903660 Offset: 0x1903761 VA: 0x1903660
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	// RVA: 0x18FEB10 Offset: 0x18FEC11 VA: 0x18FEB10
	protected float GetPreferredWidth() { }

	// RVA: 0x1903370 Offset: 0x1903471 VA: 0x1903370
	private float GetPreferredWidth(Vector2 margin) { }

	// RVA: 0x18FEC90 Offset: 0x18FED91 VA: 0x18FEC90
	protected float GetPreferredHeight() { }

	// RVA: 0x19033E0 Offset: 0x19034E1 VA: 0x19033E0
	private float GetPreferredHeight(Vector2 margin) { }

	// RVA: 0x19037E0 Offset: 0x19038E1 VA: 0x19037E0
	public Vector2 GetRenderedValues() { }

	// RVA: 0x1903830 Offset: 0x1903931 VA: 0x1903830
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	// RVA: 0x18FEE80 Offset: 0x18FEF81 VA: 0x18FEE80
	private float GetRenderedWidth() { }

	// RVA: 0x1903BD0 Offset: 0x1903CD1 VA: 0x1903BD0
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	// RVA: 0x18FEF20 Offset: 0x18FF021 VA: 0x18FEF20
	private float GetRenderedHeight() { }

	// RVA: 0x1903C20 Offset: 0x1903D21 VA: 0x1903C20
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	// RVA: 0x1903C70 Offset: 0x1903D71 VA: 0x1903C70 Slot: 115
	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, bool isWordWrappingEnabled) { }

	// RVA: 0x190CF60 Offset: 0x190D061 VA: 0x190CF60 Slot: 116
	protected virtual Bounds GetCompoundBounds() { }

	// RVA: 0x190CF70 Offset: 0x190D071 VA: 0x190CF70 Slot: 117
	internal virtual Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x18FE140 Offset: 0x18FE241 VA: 0x18FE140
	protected Bounds GetTextBounds() { }

	// RVA: 0x1903880 Offset: 0x1903981 VA: 0x1903880
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	// RVA: 0x190CF80 Offset: 0x190D081 VA: 0x190CF80
	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x190D160 Offset: 0x190D261 VA: 0x190D160
	protected void ResizeLineExtents(int size) { }

	// RVA: 0x190D370 Offset: 0x190D471 VA: 0x190D370 Slot: 118
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x190D380 Offset: 0x190D481 VA: 0x190D380 Slot: 119
	public virtual void ComputeMarginSize() { }

	// RVA: 0x190D390 Offset: 0x190D491 VA: 0x190D390
	protected void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float glyphAdjustment, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	// RVA: 0x190CB20 Offset: 0x190CC21 VA: 0x190CB20
	protected void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	// RVA: 0x190C610 Offset: 0x190C711 VA: 0x190C610
	protected int RestoreWordWrappingState(ref WordWrapState state) { }

	// RVA: 0x190D9E0 Offset: 0x190DAE1 VA: 0x190D9E0 Slot: 120
	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	// RVA: 0x190E3F0 Offset: 0x190E4F1 VA: 0x190E3F0 Slot: 121
	protected virtual void SaveSpriteVertexInfo(Color32 vertexColor) { }

	// RVA: 0x190EAB0 Offset: 0x190EBB1 VA: 0x190EAB0 Slot: 122
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4) { }

	// RVA: 0x190F0D0 Offset: 0x190F1D1 VA: 0x190F0D0 Slot: 123
	protected virtual void FillCharacterVertexBuffers(int i, int index_X4, bool isVolumetric) { }

	// RVA: 0x190FAF0 Offset: 0x190FBF1 VA: 0x190FAF0 Slot: 124
	protected virtual void FillSpriteVertexBuffers(int i, int index_X4) { }

	// RVA: 0x1910110 Offset: 0x1910211 VA: 0x1910110 Slot: 125
	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	// RVA: 0x19110E0 Offset: 0x19111E1 VA: 0x19110E0 Slot: 126
	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	// RVA: 0x1911590 Offset: 0x1911691 VA: 0x1911590
	protected void LoadDefaultSettings() { }

	// RVA: 0x19117F0 Offset: 0x19118F1 VA: 0x19117F0
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x1911820 Offset: 0x1911921 VA: 0x1911820
	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x1910F00 Offset: 0x1911001 VA: 0x1910F00
	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x1911A90 Offset: 0x1911B91 VA: 0x1911A90
	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	// RVA: 0x1911B10 Offset: 0x1911C11 VA: 0x1911B10
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	// RVA: 0x1911B90 Offset: 0x1911C91 VA: 0x1911B90
	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	// RVA: 0x1911FB0 Offset: 0x19120B1 VA: 0x1911FB0 Slot: 127
	protected virtual void SetActiveSubMeshes(bool state) { }

	// RVA: 0x1911FC0 Offset: 0x19120C1 VA: 0x1911FC0 Slot: 128
	protected virtual void DestroySubMeshObjects() { }

	// RVA: 0x1911FD0 Offset: 0x19120D1 VA: 0x1911FD0 Slot: 129
	public virtual void ClearMesh() { }

	// RVA: 0x1911FE0 Offset: 0x19120E1 VA: 0x1911FE0 Slot: 130
	public virtual void ClearMesh(bool uploadGeometry) { }

	// RVA: 0x1911FF0 Offset: 0x19120F1 VA: 0x1911FF0 Slot: 131
	public virtual string GetParsedText() { }

	// RVA: 0x18FD630 Offset: 0x18FD731 VA: 0x18FD630
	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	// RVA: 0x18FD4F0 Offset: 0x18FD5F1 VA: 0x18FD4F0
	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	// RVA: 0x1911070 Offset: 0x1911171 VA: 0x1911070
	protected Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0x19120F0 Offset: 0x19121F1 VA: 0x19120F0
	protected float PackUV(float x, float y) { }

	// RVA: 0x1912160 Offset: 0x1912261 VA: 0x1912160 Slot: 132
	internal virtual void InternalUpdate() { }

	// RVA: 0x1912170 Offset: 0x1912271 VA: 0x1912170
	protected int HexToInt(char hex) { }

	// RVA: 0x19121A0 Offset: 0x19122A1 VA: 0x19121A0
	protected int GetUTF16(string text, int i) { }

	// RVA: 0x1902460 Offset: 0x1902561 VA: 0x1902460
	protected int GetUTF16(int[] text, int i) { }

	// RVA: 0x1912250 Offset: 0x1912351 VA: 0x1912250
	internal int GetUTF16(uint[] text, int i) { }

	// RVA: 0x1912310 Offset: 0x1912411 VA: 0x1912310
	protected int GetUTF16(StringBuilder text, int i) { }

	// RVA: 0x1900A40 Offset: 0x1900B41 VA: 0x1900A40
	private int GetUTF16(TMP_Text.TextBackingContainer text, int i) { }

	// RVA: 0x19123C0 Offset: 0x19124C1 VA: 0x19123C0
	protected int GetUTF32(string text, int i) { }

	// RVA: 0x1902520 Offset: 0x1902621 VA: 0x1902520
	protected int GetUTF32(int[] text, int i) { }

	// RVA: 0x1912500 Offset: 0x1912601 VA: 0x1912500
	internal int GetUTF32(uint[] text, int i) { }

	// RVA: 0x1912650 Offset: 0x1912751 VA: 0x1912650
	protected int GetUTF32(StringBuilder text, int i) { }

	// RVA: 0x1900AF0 Offset: 0x1900BF1 VA: 0x1900AF0
	private int GetUTF32(TMP_Text.TextBackingContainer text, int i) { }

	// RVA: 0x1912790 Offset: 0x1912891 VA: 0x1912790
	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0x1912BC0 Offset: 0x1912CC1 VA: 0x1912BC0
	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0x1912E40 Offset: 0x1912F41 VA: 0x1912E40
	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x19130C0 Offset: 0x19131C1 VA: 0x19130C0
	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x1912F00 Offset: 0x1913001 VA: 0x1912F00
	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0x1906000 Offset: 0x1906101 VA: 0x1906000
	internal bool ValidateHtmlTag(TMP_Text.UnicodeChar[] chars, int startIndex, out int endIndex) { }

	// RVA: 0x19130F0 Offset: 0x19131F1 VA: 0x19130F0
	protected void .ctor() { }

	// RVA: 0x1913C20 Offset: 0x1913D21 VA: 0x1913C20
	private static void .cctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_TextElement // TypeDefIndex: 7456
{
	// Fields
	[SerializeField] // RVA: 0x4E450 Offset: 0x4E551 VA: 0x4E450
	protected TextElementType m_ElementType; // 0x10
	[SerializeField] // RVA: 0x4E460 Offset: 0x4E561 VA: 0x4E460
	internal uint m_Unicode; // 0x14
	internal TMP_Asset m_TextAsset; // 0x18
	internal Glyph m_Glyph; // 0x20
	[SerializeField] // RVA: 0x4E470 Offset: 0x4E571 VA: 0x4E470
	internal uint m_GlyphIndex; // 0x28
	[SerializeField] // RVA: 0x4E480 Offset: 0x4E581 VA: 0x4E480
	internal float m_Scale; // 0x2C

	// Properties
	public TextElementType elementType { get; }
	public uint unicode { get; set; }
	public TMP_Asset textAsset { get; set; }
	public Glyph glyph { get; set; }
	public uint glyphIndex { get; set; }
	public float scale { get; set; }

	// Methods

	// RVA: 0x197F3A0 Offset: 0x197F4A1 VA: 0x197F3A0
	public TextElementType get_elementType() { }

	// RVA: 0x197F3B0 Offset: 0x197F4B1 VA: 0x197F3B0
	public uint get_unicode() { }

	// RVA: 0x197F3C0 Offset: 0x197F4C1 VA: 0x197F3C0
	public void set_unicode(uint value) { }

	// RVA: 0x197F3D0 Offset: 0x197F4D1 VA: 0x197F3D0
	public TMP_Asset get_textAsset() { }

	// RVA: 0x197F3E0 Offset: 0x197F4E1 VA: 0x197F3E0
	public void set_textAsset(TMP_Asset value) { }

	// RVA: 0x197F3F0 Offset: 0x197F4F1 VA: 0x197F3F0
	public Glyph get_glyph() { }

	// RVA: 0x197F400 Offset: 0x197F501 VA: 0x197F400
	public void set_glyph(Glyph value) { }

	// RVA: 0x197F410 Offset: 0x197F511 VA: 0x197F410
	public uint get_glyphIndex() { }

	// RVA: 0x197F420 Offset: 0x197F521 VA: 0x197F420
	public void set_glyphIndex(uint value) { }

	// RVA: 0x197F430 Offset: 0x197F531 VA: 0x197F430
	public float get_scale() { }

	// RVA: 0x197F440 Offset: 0x197F541 VA: 0x197F440
	public void set_scale(float value) { }

	// RVA: 0x197F450 Offset: 0x197F551 VA: 0x197F450
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_TextElement_Legacy // TypeDefIndex: 7457
{
	// Fields
	public int id; // 0x10
	public float x; // 0x14
	public float y; // 0x18
	public float width; // 0x1C
	public float height; // 0x20
	public float xOffset; // 0x24
	public float yOffset; // 0x28
	public float xAdvance; // 0x2C
	public float scale; // 0x30

	// Methods

	// RVA: 0x197F460 Offset: 0x197F561 VA: 0x197F460
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_TextInfo // TypeDefIndex: 7458
{
	// Fields
	internal static Vector2 k_InfinityVectorPositive; // 0x0
	internal static Vector2 k_InfinityVectorNegative; // 0x8
	public TMP_Text textComponent; // 0x10
	public int characterCount; // 0x18
	public int spriteCount; // 0x1C
	public int spaceCount; // 0x20
	public int wordCount; // 0x24
	public int linkCount; // 0x28
	public int lineCount; // 0x2C
	public int pageCount; // 0x30
	public int materialCount; // 0x34
	public TMP_CharacterInfo[] characterInfo; // 0x38
	public TMP_WordInfo[] wordInfo; // 0x40
	public TMP_LinkInfo[] linkInfo; // 0x48
	public TMP_LineInfo[] lineInfo; // 0x50
	public TMP_PageInfo[] pageInfo; // 0x58
	public TMP_MeshInfo[] meshInfo; // 0x60
	private TMP_MeshInfo[] m_CachedMeshInfo; // 0x68

	// Methods

	// RVA: 0x197F470 Offset: 0x197F571 VA: 0x197F470
	public void .ctor() { }

	// RVA: 0x197F5E0 Offset: 0x197F6E1 VA: 0x197F5E0
	internal void .ctor(int characterCount) { }

	// RVA: 0x197F760 Offset: 0x197F861 VA: 0x197F760
	public void .ctor(TMP_Text textComponent) { }

	// RVA: 0x197F940 Offset: 0x197FA41 VA: 0x197F940
	public void Clear() { }

	// RVA: 0x197F9B0 Offset: 0x197FAB1 VA: 0x197F9B0
	internal void ClearAllData() { }

	// RVA: 0x197FB30 Offset: 0x197FC31 VA: 0x197FB30
	public void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x197FBB0 Offset: 0x197FCB1 VA: 0x197FBB0
	public void ClearAllMeshInfo() { }

	// RVA: 0x197FC30 Offset: 0x197FD31 VA: 0x197FC30
	public void ResetVertexLayout(bool isVolumetric) { }

	// RVA: 0x197FCC0 Offset: 0x197FDC1 VA: 0x197FCC0
	public void ClearUnusedVertices(MaterialReference[] materials) { }

	// RVA: 0x197FD40 Offset: 0x197FE41 VA: 0x197FD40
	public void ClearLineInfo() { }

	// RVA: 0x197FFA0 Offset: 0x19800A1 VA: 0x197FFA0
	internal void ClearPageInfo() { }

	// RVA: 0x19800F0 Offset: 0x19801F1 VA: 0x19800F0
	public TMP_MeshInfo[] CopyMeshInfoVertexData() { }

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2023E50 Offset: 0x2023F51 VA: 0x2023E50
	|-TMP_TextInfo.Resize<object>
	|-TMP_TextInfo.Resize<TMP_SubMesh>
	|-TMP_TextInfo.Resize<TMP_SubMeshUI>
	|
	|-RVA: 0x2023EA0 Offset: 0x2023FA1 VA: 0x2023EA0
	|-TMP_TextInfo.Resize<TMP_LinkInfo>
	|
	|-RVA: 0x2023EF0 Offset: 0x2023FF1 VA: 0x2023EF0
	|-TMP_TextInfo.Resize<TMP_WordInfo>
	*/

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2023F40 Offset: 0x2024041 VA: 0x2023F40
	|-TMP_TextInfo.Resize<Material>
	|-TMP_TextInfo.Resize<object>
	|
	|-RVA: 0x2023FC0 Offset: 0x20240C1 VA: 0x2023FC0
	|-TMP_TextInfo.Resize<TMP_CharacterInfo>
	|
	|-RVA: 0x2024040 Offset: 0x2024141 VA: 0x2024040
	|-TMP_TextInfo.Resize<TMP_MeshInfo>
	|
	|-RVA: 0x20240C0 Offset: 0x20241C1 VA: 0x20240C0
	|-TMP_TextInfo.Resize<TMP_PageInfo>
	*/

	// RVA: 0x19804F0 Offset: 0x19805F1 VA: 0x19804F0
	private static void .cctor() { }
}

// Namespace: TMPro
public class TMP_TextParsingUtilities // TypeDefIndex: 7459
{
	// Fields
	private static readonly TMP_TextParsingUtilities s_Instance; // 0x0
	private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Properties
	public static TMP_TextParsingUtilities instance { get; }

	// Methods

	// RVA: 0x1980560 Offset: 0x1980661 VA: 0x1980560
	private static void .cctor() { }

	// RVA: 0x19805E0 Offset: 0x19806E1 VA: 0x19805E0
	public static TMP_TextParsingUtilities get_instance() { }

	// RVA: 0x1980650 Offset: 0x1980751 VA: 0x1980650
	public static int GetHashCode(string s) { }

	// RVA: 0x19807F0 Offset: 0x19808F1 VA: 0x19807F0
	public static int GetHashCodeCaseSensitive(string s) { }

	// RVA: 0x1980860 Offset: 0x1980961 VA: 0x1980860
	public static char ToLowerASCIIFast(char c) { }

	// RVA: 0x1980770 Offset: 0x1980871 VA: 0x1980770
	public static char ToUpperASCIIFast(char c) { }

	// RVA: 0x19808E0 Offset: 0x19809E1 VA: 0x19808E0
	public static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x1980960 Offset: 0x1980A61 VA: 0x1980960
	public static uint ToLowerASCIIFast(uint c) { }

	// RVA: 0x19809E0 Offset: 0x1980AE1 VA: 0x19809E0
	public static bool IsHighSurrogate(uint c) { }

	// RVA: 0x1980A00 Offset: 0x1980B01 VA: 0x1980A00
	public static bool IsLowSurrogate(uint c) { }

	// RVA: 0x1980A20 Offset: 0x1980B21 VA: 0x1980A20
	internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	// RVA: 0x19805D0 Offset: 0x19806D1 VA: 0x19805D0
	public void .ctor() { }
}

// Namespace: TMPro
public struct TMP_FontStyleStack // TypeDefIndex: 7460
{
	// Fields
	public byte bold; // 0x0
	public byte italic; // 0x1
	public byte underline; // 0x2
	public byte strikethrough; // 0x3
	public byte highlight; // 0x4
	public byte superscript; // 0x5
	public byte subscript; // 0x6
	public byte uppercase; // 0x7
	public byte lowercase; // 0x8
	public byte smallcaps; // 0x9

	// Methods

	// RVA: 0x1AABFB0 Offset: 0x1AAC0B1 VA: 0x1AABFB0
	public void Clear() { }

	// RVA: 0x1AABFC0 Offset: 0x1AAC0C1 VA: 0x1AABFC0
	public byte Add(FontStyles style) { }

	// RVA: 0x1AAC0E0 Offset: 0x1AAC1E1 VA: 0x1AAC0E0
	public byte Remove(FontStyles style) { }
}

// Namespace: TMPro
[DebuggerDisplayAttribute] // RVA: 0x4D080 Offset: 0x4D181 VA: 0x4D080
public struct TMP_TextProcessingStack<T> // TypeDefIndex: 7461
{
	// Fields
	public T[] itemStack; // 0x0
	public int index; // 0x0
	private T m_DefaultItem; // 0x0
	private int m_Capacity; // 0x0
	private int m_RolloverSize; // 0x0
	private int m_Count; // 0x0
	private const int k_DefaultCapacity = 4;

	// Properties
	public int Count { get; }
	public T current { get; }
	public int rolloverSize { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3F80 Offset: 0x34B4081 VA: 0x34B3F80
	|-TMP_TextProcessingStack<Color32>..ctor
	|
	|-RVA: 0x34B4610 Offset: 0x34B4711 VA: 0x34B4610
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x34B54E0 Offset: 0x34B55E1 VA: 0x34B54E0
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>..ctor
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x34B4E50 Offset: 0x34B4F51 VA: 0x34B4E50
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x34B5B70 Offset: 0x34B5C71 VA: 0x34B5B70
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x34B6580 Offset: 0x34B6681 VA: 0x34B6580
	|-TMP_TextProcessingStack<object>..ctor
	|-TMP_TextProcessingStack<TMP_ColorGradient>..ctor
	|
	|-RVA: 0x34B6C40 Offset: 0x34B6D41 VA: 0x34B6C40
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x34B72C0 Offset: 0x34B73C1 VA: 0x34B72C0
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B3FC0 Offset: 0x34B40C1 VA: 0x34B3FC0
	|-TMP_TextProcessingStack<Color32>..ctor
	|
	|-RVA: 0x34B5520 Offset: 0x34B5621 VA: 0x34B5520
	|-TMP_TextProcessingStack<FontWeight>..ctor
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x34B4650 Offset: 0x34B4751 VA: 0x34B4650
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x34B4E90 Offset: 0x34B4F91 VA: 0x34B4E90
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x34B5BC0 Offset: 0x34B5CC1 VA: 0x34B5BC0
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x34B65C0 Offset: 0x34B66C1 VA: 0x34B65C0
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x34B6C80 Offset: 0x34B6D81 VA: 0x34B6C80
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x34B7310 Offset: 0x34B7411 VA: 0x34B7310
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int rolloverSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B4040 Offset: 0x34B4141 VA: 0x34B4040
	|-TMP_TextProcessingStack<Color32>..ctor
	|
	|-RVA: 0x34B46D0 Offset: 0x34B47D1 VA: 0x34B46D0
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x34B4F10 Offset: 0x34B5011 VA: 0x34B4F10
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x34B55A0 Offset: 0x34B56A1 VA: 0x34B55A0
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x34B5C50 Offset: 0x34B5D51 VA: 0x34B5C50
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x34B6640 Offset: 0x34B6741 VA: 0x34B6640
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x34B6D00 Offset: 0x34B6E01 VA: 0x34B6D00
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x34B73A0 Offset: 0x34B74A1 VA: 0x34B73A0
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B40C0 Offset: 0x34B41C1 VA: 0x34B40C0
	|-TMP_TextProcessingStack<Color32>.get_Count
	|
	|-RVA: 0x34B4760 Offset: 0x34B4861 VA: 0x34B4760
	|-TMP_TextProcessingStack<HighlightState>.get_Count
	|
	|-RVA: 0x34B4F90 Offset: 0x34B5091 VA: 0x34B4F90
	|-TMP_TextProcessingStack<int>.get_Count
	|
	|-RVA: 0x34B5620 Offset: 0x34B5721 VA: 0x34B5620
	|-TMP_TextProcessingStack<Int32Enum>.get_Count
	|
	|-RVA: 0x34B5CE0 Offset: 0x34B5DE1 VA: 0x34B5CE0
	|-TMP_TextProcessingStack<MaterialReference>.get_Count
	|
	|-RVA: 0x34B66D0 Offset: 0x34B67D1 VA: 0x34B66D0
	|-TMP_TextProcessingStack<object>.get_Count
	|
	|-RVA: 0x34B6D80 Offset: 0x34B6E81 VA: 0x34B6D80
	|-TMP_TextProcessingStack<float>.get_Count
	|
	|-RVA: 0x34B7440 Offset: 0x34B7541 VA: 0x34B7440
	|-TMP_TextProcessingStack<WordWrapState>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B40D0 Offset: 0x34B41D1 VA: 0x34B40D0
	|-TMP_TextProcessingStack<Color32>.get_current
	|
	|-RVA: 0x34B4770 Offset: 0x34B4871 VA: 0x34B4770
	|-TMP_TextProcessingStack<HighlightState>.get_current
	|
	|-RVA: 0x34B4FA0 Offset: 0x34B50A1 VA: 0x34B4FA0
	|-TMP_TextProcessingStack<int>.get_current
	|
	|-RVA: 0x34B5630 Offset: 0x34B5731 VA: 0x34B5630
	|-TMP_TextProcessingStack<Int32Enum>.get_current
	|
	|-RVA: 0x34B5CF0 Offset: 0x34B5DF1 VA: 0x34B5CF0
	|-TMP_TextProcessingStack<MaterialReference>.get_current
	|
	|-RVA: 0x34B66E0 Offset: 0x34B67E1 VA: 0x34B66E0
	|-TMP_TextProcessingStack<object>.get_current
	|
	|-RVA: 0x34B6D90 Offset: 0x34B6E91 VA: 0x34B6D90
	|-TMP_TextProcessingStack<float>.get_current
	|
	|-RVA: 0x34B7450 Offset: 0x34B7551 VA: 0x34B7450
	|-TMP_TextProcessingStack<WordWrapState>.get_current
	*/

	// RVA: -1 Offset: -1
	public int get_rolloverSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B4120 Offset: 0x34B4221 VA: 0x34B4120
	|-TMP_TextProcessingStack<Color32>.get_rolloverSize
	|
	|-RVA: 0x34B47D0 Offset: 0x34B48D1 VA: 0x34B47D0
	|-TMP_TextProcessingStack<HighlightState>.get_rolloverSize
	|
	|-RVA: 0x34B4FF0 Offset: 0x34B50F1 VA: 0x34B4FF0
	|-TMP_TextProcessingStack<int>.get_rolloverSize
	|
	|-RVA: 0x34B5680 Offset: 0x34B5781 VA: 0x34B5680
	|-TMP_TextProcessingStack<Int32Enum>.get_rolloverSize
	|
	|-RVA: 0x34B5D60 Offset: 0x34B5E61 VA: 0x34B5D60
	|-TMP_TextProcessingStack<MaterialReference>.get_rolloverSize
	|
	|-RVA: 0x34B6730 Offset: 0x34B6831 VA: 0x34B6730
	|-TMP_TextProcessingStack<object>.get_rolloverSize
	|
	|-RVA: 0x34B6DE0 Offset: 0x34B6EE1 VA: 0x34B6DE0
	|-TMP_TextProcessingStack<float>.get_rolloverSize
	|
	|-RVA: 0x34B74B0 Offset: 0x34B75B1 VA: 0x34B74B0
	|-TMP_TextProcessingStack<WordWrapState>.get_rolloverSize
	*/

	// RVA: -1 Offset: -1
	public void set_rolloverSize(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B4130 Offset: 0x34B4231 VA: 0x34B4130
	|-TMP_TextProcessingStack<Color32>.set_rolloverSize
	|
	|-RVA: 0x34B47E0 Offset: 0x34B48E1 VA: 0x34B47E0
	|-TMP_TextProcessingStack<HighlightState>.set_rolloverSize
	|
	|-RVA: 0x34B5000 Offset: 0x34B5101 VA: 0x34B5000
	|-TMP_TextProcessingStack<int>.set_rolloverSize
	|
	|-RVA: 0x34B5690 Offset: 0x34B5791 VA: 0x34B5690
	|-TMP_TextProcessingStack<Int32Enum>.set_rolloverSize
	|
	|-RVA: 0x34B5D70 Offset: 0x34B5E71 VA: 0x34B5D70
	|-TMP_TextProcessingStack<MaterialReference>.set_rolloverSize
	|
	|-RVA: 0x34B6740 Offset: 0x34B6841 VA: 0x34B6740
	|-TMP_TextProcessingStack<object>.set_rolloverSize
	|
	|-RVA: 0x34B6DF0 Offset: 0x34B6EF1 VA: 0x34B6DF0
	|-TMP_TextProcessingStack<float>.set_rolloverSize
	|
	|-RVA: 0x34B74C0 Offset: 0x34B75C1 VA: 0x34B74C0
	|-TMP_TextProcessingStack<WordWrapState>.set_rolloverSize
	*/

	// RVA: -1 Offset: -1
	internal static void SetDefault(TMP_TextProcessingStack<T>[] stack, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B4140 Offset: 0x34B4241 VA: 0x34B4140
	|-TMP_TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x34B47F0 Offset: 0x34B48F1 VA: 0x34B47F0
	|-TMP_TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x34B5010 Offset: 0x34B5111 VA: 0x34B5010
	|-TMP_TextProcessingStack<int>.SetDefault
	|
	|-RVA: 0x34B56A0 Offset: 0x34B57A1 VA: 0x34B56A0
	|-TMP_TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x34B5D80 Offset: 0x34B5E81 VA: 0x34B5D80
	|-TMP_TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x34B6750 Offset: 0x34B6851 VA: 0x34B6750
	|-TMP_TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x34B6E00 Offset: 0x34B6F01 VA: 0x34B6E00
	|-TMP_TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x34B74D0 Offset: 0x34B75D1 VA: 0x34B74D0
	|-TMP_TextProcessingStack<WordWrapState>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B41F0 Offset: 0x34B42F1 VA: 0x34B41F0
	|-TMP_TextProcessingStack<Color32>.Clear
	|
	|-RVA: 0x34B48D0 Offset: 0x34B49D1 VA: 0x34B48D0
	|-TMP_TextProcessingStack<HighlightState>.Clear
	|
	|-RVA: 0x34B50C0 Offset: 0x34B51C1 VA: 0x34B50C0
	|-TMP_TextProcessingStack<int>.Clear
	|
	|-RVA: 0x34B5750 Offset: 0x34B5851 VA: 0x34B5750
	|-TMP_TextProcessingStack<Int32Enum>.Clear
	|
	|-RVA: 0x34B5E90 Offset: 0x34B5F91 VA: 0x34B5E90
	|-TMP_TextProcessingStack<MaterialReference>.Clear
	|
	|-RVA: 0x34B6800 Offset: 0x34B6901 VA: 0x34B6800
	|-TMP_TextProcessingStack<object>.Clear
	|
	|-RVA: 0x34B6EB0 Offset: 0x34B6FB1 VA: 0x34B6EB0
	|-TMP_TextProcessingStack<float>.Clear
	|
	|-RVA: 0x34B75C0 Offset: 0x34B76C1 VA: 0x34B75C0
	|-TMP_TextProcessingStack<WordWrapState>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B4200 Offset: 0x34B4301 VA: 0x34B4200
	|-TMP_TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x34B5760 Offset: 0x34B5861 VA: 0x34B5760
	|-TMP_TextProcessingStack<FontWeight>.SetDefault
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.SetDefault
	|-TMP_TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x34B48E0 Offset: 0x34B49E1 VA: 0x34B48E0
	|-TMP_TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x34B50D0 Offset: 0x34B51D1 VA: 0x34B50D0
	|-TMP_TextProcessingStack<int>.SetDefault
	|
	|-RVA: 0x34B5EA0 Offset: 0x34B5FA1 VA: 0x34B5EA0
	|-TMP_TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x34B6810 Offset: 0x34B6911 VA: 0x34B6810
	|-TMP_TextProcessingStack<object>.SetDefault
	|-TMP_TextProcessingStack<TMP_ColorGradient>.SetDefault
	|
	|-RVA: 0x34B6EC0 Offset: 0x34B6FC1 VA: 0x34B6EC0
	|-TMP_TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x34B75D0 Offset: 0x34B76D1 VA: 0x34B75D0
	|-TMP_TextProcessingStack<WordWrapState>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B42B0 Offset: 0x34B43B1 VA: 0x34B42B0
	|-TMP_TextProcessingStack<Color32>.Add
	|
	|-RVA: 0x34B5810 Offset: 0x34B5911 VA: 0x34B5810
	|-TMP_TextProcessingStack<FontWeight>.Add
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.Add
	|-TMP_TextProcessingStack<Int32Enum>.Add
	|
	|-RVA: 0x34B49C0 Offset: 0x34B4AC1 VA: 0x34B49C0
	|-TMP_TextProcessingStack<HighlightState>.Add
	|
	|-RVA: 0x34B5180 Offset: 0x34B5281 VA: 0x34B5180
	|-TMP_TextProcessingStack<int>.Add
	|
	|-RVA: 0x34B5FB0 Offset: 0x34B60B1 VA: 0x34B5FB0
	|-TMP_TextProcessingStack<MaterialReference>.Add
	|
	|-RVA: 0x34B68C0 Offset: 0x34B69C1 VA: 0x34B68C0
	|-TMP_TextProcessingStack<object>.Add
	|-TMP_TextProcessingStack<TMP_ColorGradient>.Add
	|
	|-RVA: 0x34B6F70 Offset: 0x34B7071 VA: 0x34B6F70
	|-TMP_TextProcessingStack<float>.Add
	|
	|-RVA: 0x34B76C0 Offset: 0x34B77C1 VA: 0x34B76C0
	|-TMP_TextProcessingStack<WordWrapState>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B4300 Offset: 0x34B4401 VA: 0x34B4300
	|-TMP_TextProcessingStack<Color32>.Remove
	|
	|-RVA: 0x34B5860 Offset: 0x34B5961 VA: 0x34B5860
	|-TMP_TextProcessingStack<FontWeight>.Remove
	|-TMP_TextProcessingStack<HorizontalAlignmentOptions>.Remove
	|-TMP_TextProcessingStack<Int32Enum>.Remove
	|
	|-RVA: 0x34B4A40 Offset: 0x34B4B41 VA: 0x34B4A40
	|-TMP_TextProcessingStack<HighlightState>.Remove
	|
	|-RVA: 0x34B51D0 Offset: 0x34B52D1 VA: 0x34B51D0
	|-TMP_TextProcessingStack<int>.Remove
	|
	|-RVA: 0x34B6060 Offset: 0x34B6161 VA: 0x34B6060
	|-TMP_TextProcessingStack<MaterialReference>.Remove
	|
	|-RVA: 0x34B6920 Offset: 0x34B6A21 VA: 0x34B6920
	|-TMP_TextProcessingStack<object>.Remove
	|-TMP_TextProcessingStack<TMP_ColorGradient>.Remove
	|
	|-RVA: 0x34B6FC0 Offset: 0x34B70C1 VA: 0x34B6FC0
	|-TMP_TextProcessingStack<float>.Remove
	|
	|-RVA: 0x34B7760 Offset: 0x34B7861 VA: 0x34B7760
	|-TMP_TextProcessingStack<WordWrapState>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B4370 Offset: 0x34B4471 VA: 0x34B4370
	|-TMP_TextProcessingStack<Color32>.Push
	|
	|-RVA: 0x34B4AC0 Offset: 0x34B4BC1 VA: 0x34B4AC0
	|-TMP_TextProcessingStack<HighlightState>.Push
	|
	|-RVA: 0x34B5240 Offset: 0x34B5341 VA: 0x34B5240
	|-TMP_TextProcessingStack<int>.Push
	|
	|-RVA: 0x34B58D0 Offset: 0x34B59D1 VA: 0x34B58D0
	|-TMP_TextProcessingStack<Int32Enum>.Push
	|
	|-RVA: 0x34B60F0 Offset: 0x34B61F1 VA: 0x34B60F0
	|-TMP_TextProcessingStack<MaterialReference>.Push
	|
	|-RVA: 0x34B6990 Offset: 0x34B6A91 VA: 0x34B6990
	|-TMP_TextProcessingStack<object>.Push
	|
	|-RVA: 0x34B7030 Offset: 0x34B7131 VA: 0x34B7030
	|-TMP_TextProcessingStack<float>.Push
	|
	|-RVA: 0x34B77E0 Offset: 0x34B78E1 VA: 0x34B77E0
	|-TMP_TextProcessingStack<WordWrapState>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B4480 Offset: 0x34B4581 VA: 0x34B4480
	|-TMP_TextProcessingStack<Color32>.Pop
	|
	|-RVA: 0x34B4BF0 Offset: 0x34B4CF1 VA: 0x34B4BF0
	|-TMP_TextProcessingStack<HighlightState>.Pop
	|
	|-RVA: 0x34B5350 Offset: 0x34B5451 VA: 0x34B5350
	|-TMP_TextProcessingStack<int>.Pop
	|
	|-RVA: 0x34B59E0 Offset: 0x34B5AE1 VA: 0x34B59E0
	|-TMP_TextProcessingStack<Int32Enum>.Pop
	|
	|-RVA: 0x34B6250 Offset: 0x34B6351 VA: 0x34B6250
	|-TMP_TextProcessingStack<MaterialReference>.Pop
	|
	|-RVA: 0x34B6AA0 Offset: 0x34B6BA1 VA: 0x34B6AA0
	|-TMP_TextProcessingStack<object>.Pop
	|
	|-RVA: 0x34B7140 Offset: 0x34B7241 VA: 0x34B7140
	|-TMP_TextProcessingStack<float>.Pop
	|
	|-RVA: 0x34B7930 Offset: 0x34B7A31 VA: 0x34B7930
	|-TMP_TextProcessingStack<WordWrapState>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B4520 Offset: 0x34B4621 VA: 0x34B4520
	|-TMP_TextProcessingStack<Color32>.Peek
	|
	|-RVA: 0x34B5A80 Offset: 0x34B5B81 VA: 0x34B5A80
	|-TMP_TextProcessingStack<FontWeight>.Peek
	|-TMP_TextProcessingStack<Int32Enum>.Peek
	|
	|-RVA: 0x34B4D20 Offset: 0x34B4E21 VA: 0x34B4D20
	|-TMP_TextProcessingStack<HighlightState>.Peek
	|
	|-RVA: 0x34B53F0 Offset: 0x34B54F1 VA: 0x34B53F0
	|-TMP_TextProcessingStack<int>.Peek
	|
	|-RVA: 0x34B6410 Offset: 0x34B6511 VA: 0x34B6410
	|-TMP_TextProcessingStack<MaterialReference>.Peek
	|
	|-RVA: 0x34B6B50 Offset: 0x34B6C51 VA: 0x34B6B50
	|-TMP_TextProcessingStack<object>.Peek
	|
	|-RVA: 0x34B71D0 Offset: 0x34B72D1 VA: 0x34B71D0
	|-TMP_TextProcessingStack<float>.Peek
	|
	|-RVA: 0x34B7AB0 Offset: 0x34B7BB1 VA: 0x34B7AB0
	|-TMP_TextProcessingStack<WordWrapState>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B4570 Offset: 0x34B4671 VA: 0x34B4570
	|-TMP_TextProcessingStack<Color32>.CurrentItem
	|
	|-RVA: 0x34B4D90 Offset: 0x34B4E91 VA: 0x34B4D90
	|-TMP_TextProcessingStack<HighlightState>.CurrentItem
	|
	|-RVA: 0x34B5440 Offset: 0x34B5541 VA: 0x34B5440
	|-TMP_TextProcessingStack<int>.CurrentItem
	|
	|-RVA: 0x34B5AD0 Offset: 0x34B5BD1 VA: 0x34B5AD0
	|-TMP_TextProcessingStack<Int32Enum>.CurrentItem
	|
	|-RVA: 0x34B64A0 Offset: 0x34B65A1 VA: 0x34B64A0
	|-TMP_TextProcessingStack<MaterialReference>.CurrentItem
	|
	|-RVA: 0x34B6BA0 Offset: 0x34B6CA1 VA: 0x34B6BA0
	|-TMP_TextProcessingStack<object>.CurrentItem
	|
	|-RVA: 0x34B7220 Offset: 0x34B7321 VA: 0x34B7220
	|-TMP_TextProcessingStack<float>.CurrentItem
	|
	|-RVA: 0x34B7B20 Offset: 0x34B7C21 VA: 0x34B7B20
	|-TMP_TextProcessingStack<WordWrapState>.CurrentItem
	*/

	// RVA: -1 Offset: -1
	public T PreviousItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x34B45C0 Offset: 0x34B46C1 VA: 0x34B45C0
	|-TMP_TextProcessingStack<Color32>.PreviousItem
	|
	|-RVA: 0x34B4DF0 Offset: 0x34B4EF1 VA: 0x34B4DF0
	|-TMP_TextProcessingStack<HighlightState>.PreviousItem
	|
	|-RVA: 0x34B5490 Offset: 0x34B5591 VA: 0x34B5490
	|-TMP_TextProcessingStack<int>.PreviousItem
	|
	|-RVA: 0x34B5B20 Offset: 0x34B5C21 VA: 0x34B5B20
	|-TMP_TextProcessingStack<Int32Enum>.PreviousItem
	|
	|-RVA: 0x34B6510 Offset: 0x34B6611 VA: 0x34B6510
	|-TMP_TextProcessingStack<MaterialReference>.PreviousItem
	|
	|-RVA: 0x34B6BF0 Offset: 0x34B6CF1 VA: 0x34B6BF0
	|-TMP_TextProcessingStack<object>.PreviousItem
	|
	|-RVA: 0x34B7270 Offset: 0x34B7371 VA: 0x34B7270
	|-TMP_TextProcessingStack<float>.PreviousItem
	|
	|-RVA: 0x34B7B80 Offset: 0x34B7C81 VA: 0x34B7B80
	|-TMP_TextProcessingStack<WordWrapState>.PreviousItem
	*/
}

// Namespace: TMPro
public static class TMP_TextUtilities // TypeDefIndex: 7465
{
	// Fields
	private static Vector3[] m_rectWorldCorners; // 0x0
	private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Methods

	// RVA: 0x1980A40 Offset: 0x1980B41 VA: 0x1980A40
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera) { }

	// RVA: 0x19813F0 Offset: 0x19814F1 VA: 0x19813F0
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor) { }

	// RVA: 0x19815D0 Offset: 0x19816D1 VA: 0x19815D0
	public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1981770 Offset: 0x1981871 VA: 0x1981770
	public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly) { }

	// RVA: 0x1981F90 Offset: 0x1982091 VA: 0x1981F90
	public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera) { }

	// RVA: 0x1982140 Offset: 0x1982241 VA: 0x1982140
	public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x1980BA0 Offset: 0x1980CA1 VA: 0x1980BA0
	public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x1982400 Offset: 0x1982501 VA: 0x1982400
	public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1982B20 Offset: 0x1982C21 VA: 0x1982B20
	public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x19839D0 Offset: 0x1983AD1 VA: 0x19839D0
	public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1983B50 Offset: 0x1983C51 VA: 0x1983B50
	public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1984000 Offset: 0x1984101 VA: 0x1984000
	public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1981E00 Offset: 0x1981F01 VA: 0x1981E00
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x1981230 Offset: 0x1981331 VA: 0x1981230
	public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x1984EC0 Offset: 0x1984FC1 VA: 0x1984EC0
	private static bool IntersectLinePlane(TMP_TextUtilities.LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint) { }

	// RVA: 0x1981EC0 Offset: 0x1981FC1 VA: 0x1981EC0
	public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x1985010 Offset: 0x1985111 VA: 0x1985010
	public static char ToLowerFast(char c) { }

	// RVA: 0x1985090 Offset: 0x1985191 VA: 0x1985090
	public static char ToUpperFast(char c) { }

	// RVA: 0x1985110 Offset: 0x1985211 VA: 0x1985110
	internal static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x1985190 Offset: 0x1985291 VA: 0x1985190
	public static int GetHashCode(string s) { }

	// RVA: 0x19852B0 Offset: 0x19853B1 VA: 0x19852B0
	public static int GetSimpleHashCode(string s) { }

	// RVA: 0x1985320 Offset: 0x1985421 VA: 0x1985320
	public static uint GetSimpleHashCodeLowercase(string s) { }

	// RVA: 0x1985440 Offset: 0x1985541 VA: 0x1985440
	public static int HexToInt(char hex) { }

	// RVA: 0x1985470 Offset: 0x1985571 VA: 0x1985470
	public static int StringHexToInt(string s) { }

	// RVA: 0x1985580 Offset: 0x1985681 VA: 0x1985580
	private static void .cctor() { }
}

// Namespace: TMPro
public class TMP_UpdateManager // TypeDefIndex: 7466
{
	// Fields
	private static TMP_UpdateManager s_Instance; // 0x0
	private readonly HashSet<int> m_LayoutQueueLookup; // 0x10
	private readonly List<TMP_Text> m_LayoutRebuildQueue; // 0x18
	private readonly HashSet<int> m_GraphicQueueLookup; // 0x20
	private readonly List<TMP_Text> m_GraphicRebuildQueue; // 0x28
	private readonly HashSet<int> m_InternalUpdateLookup; // 0x30
	private readonly List<TMP_Text> m_InternalUpdateQueue; // 0x38
	private readonly HashSet<int> m_CullingUpdateLookup; // 0x40
	private readonly List<TMP_Text> m_CullingUpdateQueue; // 0x48
	private static ProfilerMarker k_RegisterTextObjectForUpdateMarker; // 0x8
	private static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker; // 0x10
	private static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker; // 0x18
	private static ProfilerMarker k_UnregisterTextObjectForUpdateMarker; // 0x20
	private static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker; // 0x28

	// Properties
	private static TMP_UpdateManager instance { get; }

	// Methods

	// RVA: 0x1985600 Offset: 0x1985701 VA: 0x1985600
	private static TMP_UpdateManager get_instance() { }

	// RVA: 0x19856E0 Offset: 0x19857E1 VA: 0x19856E0
	private void .ctor() { }

	// RVA: 0x19858F0 Offset: 0x19859F1 VA: 0x19858F0
	internal static void RegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x1985960 Offset: 0x1985A61 VA: 0x1985960
	private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x1985A30 Offset: 0x1985B31 VA: 0x1985A30
	public static void RegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x1985AA0 Offset: 0x1985BA1 VA: 0x1985AA0
	private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x1985B70 Offset: 0x1985C71 VA: 0x1985B70
	public static void RegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x1985BE0 Offset: 0x1985CE1 VA: 0x1985BE0
	private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x1985CB0 Offset: 0x1985DB1 VA: 0x1985CB0
	public static void RegisterTextElementForCullingUpdate(TMP_Text element) { }

	// RVA: 0x1985D20 Offset: 0x1985E21 VA: 0x1985D20
	private void InternalRegisterTextElementForCullingUpdate(TMP_Text element) { }

	// RVA: 0x1985DF0 Offset: 0x1985EF1 VA: 0x1985DF0
	private void OnCameraPreCull() { }

	// RVA: 0x1985E00 Offset: 0x1985F01 VA: 0x1985E00
	private void DoRebuilds() { }

	// RVA: 0x1986080 Offset: 0x1986181 VA: 0x1986080
	internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x1986200 Offset: 0x1986301 VA: 0x1986200
	public static void UnRegisterTextElementForRebuild(TMP_Text element) { }

	// RVA: 0x19863B0 Offset: 0x19864B1 VA: 0x19863B0
	private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x1986450 Offset: 0x1986551 VA: 0x1986450
	private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x1986160 Offset: 0x1986261 VA: 0x1986160
	private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x19864F0 Offset: 0x19865F1 VA: 0x19864F0
	private static void .cctor() { }
}

// Namespace: TMPro
public class TMP_UpdateRegistry // TypeDefIndex: 7467
{
	// Fields
	private static TMP_UpdateRegistry s_Instance; // 0x0
	private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
	private HashSet<int> m_LayoutQueueLookup; // 0x18
	private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
	private HashSet<int> m_GraphicQueueLookup; // 0x28

	// Properties
	public static TMP_UpdateRegistry instance { get; }

	// Methods

	// RVA: 0x1986660 Offset: 0x1986761 VA: 0x1986660
	public static TMP_UpdateRegistry get_instance() { }

	// RVA: 0x1986700 Offset: 0x1986801 VA: 0x1986700
	protected void .ctor() { }

	// RVA: 0x1986880 Offset: 0x1986981 VA: 0x1986880
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1986910 Offset: 0x1986A11 VA: 0x1986910
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1986A30 Offset: 0x1986B31 VA: 0x1986A30
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1986AC0 Offset: 0x1986BC1 VA: 0x1986AC0
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1986BE0 Offset: 0x1986CE1 VA: 0x1986BE0
	private void PerformUpdateForCanvasRendererObjects() { }

	// RVA: 0x1986F40 Offset: 0x1987041 VA: 0x1986F40
	private void PerformUpdateForMeshRendererObjects() { }

	// RVA: 0x1986FC0 Offset: 0x19870C1 VA: 0x1986FC0
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x19870F0 Offset: 0x19871F1 VA: 0x19870F0
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1987240 Offset: 0x1987341 VA: 0x1987240
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }
}

// Namespace: TMPro
public static class TMP_Math // TypeDefIndex: 7472
{
	// Fields
	public const float FLOAT_MAX = 32767;
	public const float FLOAT_MIN = -32767;
	public const int INT_MAX = 2147483647;
	public const int INT_MIN = -2147483647;
	public const float FLOAT_UNSET = -32767;
	public const int INT_UNSET = -32767;
	public static Vector2 MAX_16BIT; // 0x0
	public static Vector2 MIN_16BIT; // 0x8

	// Methods

	// RVA: 0x18F1550 Offset: 0x18F1651 VA: 0x18F1550
	public static bool Approximately(float a, float b) { }

	// RVA: 0x18F1590 Offset: 0x18F1691 VA: 0x18F1590
	public static int Mod(int a, int b) { }

	// RVA: 0x18F15B0 Offset: 0x18F16B1 VA: 0x18F15B0
	private static void .cctor() { }
}

// Namespace: TMPro
public enum TMP_VertexDataUpdateFlags // TypeDefIndex: 7473
{
	// Fields
	public int value__; // 0x0
	public const TMP_VertexDataUpdateFlags None = 0;
	public const TMP_VertexDataUpdateFlags Vertices = 1;
	public const TMP_VertexDataUpdateFlags Uv0 = 2;
	public const TMP_VertexDataUpdateFlags Uv2 = 4;
	public const TMP_VertexDataUpdateFlags Uv4 = 8;
	public const TMP_VertexDataUpdateFlags Colors32 = 16;
	public const TMP_VertexDataUpdateFlags All = 255;
}

// Namespace: TMPro
public struct TMP_PageInfo // TypeDefIndex: 7475
{
	// Fields
	public int firstCharacterIndex; // 0x0
	public int lastCharacterIndex; // 0x4
	public float ascender; // 0x8
	public float baseLine; // 0xC
	public float descender; // 0x10
}

// Namespace: TMPro
public struct TMP_LinkInfo // TypeDefIndex: 7476
{
	// Fields
	public TMP_Text textComponent; // 0x0
	public int hashCode; // 0x8
	public int linkIdFirstCharacterIndex; // 0xC
	public int linkIdLength; // 0x10
	public int linkTextfirstCharacterIndex; // 0x14
	public int linkTextLength; // 0x18
	internal char[] linkID; // 0x20

	// Methods

	// RVA: 0x1ABB650 Offset: 0x1ABB751 VA: 0x1ABB650
	internal void SetLinkID(char[] text, int startIndex, int length) { }

	// RVA: 0x1ABB750 Offset: 0x1ABB851 VA: 0x1ABB750
	public string GetLinkText() { }

	// RVA: 0x1ABB830 Offset: 0x1ABB931 VA: 0x1ABB830
	public string GetLinkID() { }
}

// Namespace: TMPro
public struct TMP_WordInfo // TypeDefIndex: 7477
{
	// Fields
	public TMP_Text textComponent; // 0x0
	public int firstCharacterIndex; // 0x8
	public int lastCharacterIndex; // 0xC
	public int characterCount; // 0x10

	// Methods

	// RVA: 0x1987430 Offset: 0x1987531 VA: 0x1987430
	public string GetWord() { }
}

// Namespace: TMPro
public struct TMP_SpriteInfo // TypeDefIndex: 7478
{
	// Fields
	public int spriteIndex; // 0x0
	public int characterIndex; // 0x4
	public int vertexIndex; // 0x8
}

