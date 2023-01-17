// Namespace: UnityEngine.UI
public static class DefaultControls // TypeDefIndex: 4257
{
	// Fields
	private static DefaultControls.IFactoryControls m_CurrentFactory; // 0x0
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Vector2 s_ImageElementSize; // 0x18
	private static Color s_DefaultSelectableColor; // 0x20
	private static Color s_PanelColor; // 0x30
	private static Color s_TextColor; // 0x40

	// Properties
	public static DefaultControls.IFactoryControls factory { get; }

	// Methods

	// RVA: 0x1A43D40 Offset: 0x1A43E41 VA: 0x1A43D40
	public static DefaultControls.IFactoryControls get_factory() { }

	// RVA: 0x1A43DB0 Offset: 0x1A43EB1 VA: 0x1A43DB0
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x1A43F40 Offset: 0x1A44041 VA: 0x1A43F40
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x1A441A0 Offset: 0x1A442A1 VA: 0x1A441A0
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0x1A44230 Offset: 0x1A44331 VA: 0x1A44230
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x1A440A0 Offset: 0x1A441A1 VA: 0x1A440A0
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x1A442C0 Offset: 0x1A443C1 VA: 0x1A442C0
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x1A443B0 Offset: 0x1A444B1 VA: 0x1A443B0
	public static GameObject CreatePanel(DefaultControls.Resources resources) { }

	// RVA: 0x1A44600 Offset: 0x1A44701 VA: 0x1A44600
	public static GameObject CreateButton(DefaultControls.Resources resources) { }

	// RVA: 0x1A44A70 Offset: 0x1A44B71 VA: 0x1A44A70
	public static GameObject CreateText(DefaultControls.Resources resources) { }

	// RVA: 0x1A44C90 Offset: 0x1A44D91 VA: 0x1A44C90
	public static GameObject CreateImage(DefaultControls.Resources resources) { }

	// RVA: 0x1A44DF0 Offset: 0x1A44EF1 VA: 0x1A44DF0
	public static GameObject CreateRawImage(DefaultControls.Resources resources) { }

	// RVA: 0x1A44F50 Offset: 0x1A45051 VA: 0x1A44F50
	public static GameObject CreateSlider(DefaultControls.Resources resources) { }

	// RVA: 0x1A456A0 Offset: 0x1A457A1 VA: 0x1A456A0
	public static GameObject CreateScrollbar(DefaultControls.Resources resources) { }

	// RVA: 0x1A45B60 Offset: 0x1A45C61 VA: 0x1A45B60
	public static GameObject CreateToggle(DefaultControls.Resources resources) { }

	// RVA: 0x1A461A0 Offset: 0x1A462A1 VA: 0x1A461A0
	public static GameObject CreateInputField(DefaultControls.Resources resources) { }

	// RVA: 0x1A467F0 Offset: 0x1A468F1 VA: 0x1A467F0
	public static GameObject CreateDropdown(DefaultControls.Resources resources) { }

	// RVA: 0x1A47C50 Offset: 0x1A47D51 VA: 0x1A47C50
	public static GameObject CreateScrollView(DefaultControls.Resources resources) { }

	// RVA: 0x1A48390 Offset: 0x1A48491 VA: 0x1A48390
	private static void .cctor() { }
}

