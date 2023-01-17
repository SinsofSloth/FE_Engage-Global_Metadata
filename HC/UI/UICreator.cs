// Namespace: HC.UI
public static class UICreator // TypeDefIndex: 8373
{
	// Fields
	private const string kUILayerName = "UI";
	private const string kFontPath = "Arial.ttf";
	private static UICreator.UIResources s_StandardResources; // 0x0
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Vector2 s_ImageElementSize; // 0x18
	private static Color s_DefaultSelectableColor; // 0x20
	private static Color s_PanelColor; // 0x30
	private static Color s_TextColor; // 0x40
	private static int s_LoadCount; // 0x50
	private static int s_LoadedCount; // 0x54

	// Methods

	// RVA: 0x2888090 Offset: 0x2888191 VA: 0x2888090
	public static void PreloadResources() { }

	// RVA: 0x2888240 Offset: 0x2888341 VA: 0x2888240
	public static void LoadSpriteResource(string propertyName, string resourcePath) { }

	// RVA: 0x2888250 Offset: 0x2888351 VA: 0x2888250
	public static bool IsLoaded() { }

	// RVA: 0x28882C0 Offset: 0x28883C1 VA: 0x28882C0
	private static UICreator.UIResources GetStandardResources() { }

	// RVA: 0x2888330 Offset: 0x2888431 VA: 0x2888330
	private static GameObject CreateUIElementRoot(string name, Vector2 size) { }

	// RVA: 0x28883E0 Offset: 0x28884E1 VA: 0x28883E0
	private static GameObject CreateUIObject(string name, GameObject parent) { }

	// RVA: 0x28885B0 Offset: 0x28886B1 VA: 0x28885B0
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0x2888640 Offset: 0x2888741 VA: 0x2888640
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x28884B0 Offset: 0x28885B1 VA: 0x28884B0
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x28886D0 Offset: 0x28887D1 VA: 0x28886D0
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x28887C0 Offset: 0x28888C1 VA: 0x28887C0
	public static Canvas CreateCanvas(GameObject parent, string name = "Canvas", string eventSystemName = "EventSystem") { }

	// RVA: 0x2888A40 Offset: 0x2888B41 VA: 0x2888A40
	public static EventSystem CreateEventSystem(GameObject parent, string name = "EventSystem") { }

	// RVA: 0x2888C20 Offset: 0x2888D21 VA: 0x2888C20
	public static Image CreatePanel(GameObject parent, string name = "Panel") { }

	// RVA: 0x2888EA0 Offset: 0x2888FA1 VA: 0x2888EA0
	public static Button CreateButton(GameObject parent, string name = "Button", string defaultLabel = "Button") { }

	// RVA: 0x28892A0 Offset: 0x28893A1 VA: 0x28892A0
	public static Text CreateText(GameObject parent, string name = "Text", string defaultLabel = "Text") { }

	// RVA: 0x28894F0 Offset: 0x28895F1 VA: 0x28894F0
	public static Image CreateImage(GameObject parent, string name = "Image") { }

	// RVA: 0x2889650 Offset: 0x2889751 VA: 0x2889650
	public static RawImage CreateRawImage(GameObject parent, string name = "RawImage") { }

	// RVA: 0x28897B0 Offset: 0x28898B1 VA: 0x28897B0
	public static Slider CreateSlider(GameObject parent, string name = "Slider") { }

	// RVA: 0x2889D60 Offset: 0x2889E61 VA: 0x2889D60
	public static Scrollbar CreateScrollbar(GameObject parent, string name = "Scrollbar") { }

	// RVA: 0x288A130 Offset: 0x288A231 VA: 0x288A130
	public static Toggle CreateToggle(GameObject parent, string name = "Toggle", string defaultLabel = "Toggle", bool isOn = True) { }

	// RVA: 0x288A690 Offset: 0x288A791 VA: 0x288A690
	public static InputField CreateInputField(GameObject parent, string name = "InputField", string defaultPlaceholder = "Enter text...") { }

	// RVA: 0x288AC00 Offset: 0x288AD01 VA: 0x288AC00
	public static Dropdown CreateDropdown(GameObject parent, string name = "Dropdown", string defaultLabel = "Option A") { }

	// RVA: 0x288B9B0 Offset: 0x288BAB1 VA: 0x288B9B0
	public static ScrollRect CreateScrollView(GameObject parent, string name = "Scroll View", UICreator.LayoutGroupType layoutGroupType = 2) { }

	// RVA: 0x288BFF0 Offset: 0x288C0F1 VA: 0x288BFF0
	private static void .cctor() { }
}

