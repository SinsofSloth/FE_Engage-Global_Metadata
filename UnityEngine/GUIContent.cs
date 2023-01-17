// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x529D0 Offset: 0x52AD1 VA: 0x529D0
[RequiredByNativeCodeAttribute] // RVA: 0x529D0 Offset: 0x52AD1 VA: 0x529D0
[Serializable]
public class GUIContent // TypeDefIndex: 4149
{
	// Fields
	[SerializeField] // RVA: 0x533A0 Offset: 0x534A1 VA: 0x533A0
	private string m_Text; // 0x10
	[SerializeField] // RVA: 0x533B0 Offset: 0x534B1 VA: 0x533B0
	private Texture m_Image; // 0x18
	[SerializeField] // RVA: 0x533C0 Offset: 0x534C1 VA: 0x533C0
	private string m_Tooltip; // 0x20
	private static readonly GUIContent s_Text; // 0x0
	private static readonly GUIContent s_Image; // 0x8
	private static readonly GUIContent s_TextImage; // 0x10
	public static GUIContent none; // 0x18

	// Properties
	public string text { get; set; }
	public Texture image { set; }
	public string tooltip { get; set; }

	// Methods

	// RVA: 0x3C79AF0 Offset: 0x3C79BF1 VA: 0x3C79AF0
	public string get_text() { }

	// RVA: 0x3C79B00 Offset: 0x3C79C01 VA: 0x3C79B00
	public void set_text(string value) { }

	// RVA: 0x3C79B10 Offset: 0x3C79C11 VA: 0x3C79B10
	public void set_image(Texture value) { }

	// RVA: 0x3C73DB0 Offset: 0x3C73EB1 VA: 0x3C73DB0
	public string get_tooltip() { }

	// RVA: 0x3C79B20 Offset: 0x3C79C21 VA: 0x3C79B20
	public void set_tooltip(string value) { }

	// RVA: 0x3C79B30 Offset: 0x3C79C31 VA: 0x3C79B30
	public void .ctor() { }

	// RVA: 0x3C79BC0 Offset: 0x3C79CC1 VA: 0x3C79BC0
	public void .ctor(string text) { }

	// RVA: 0x3C79C30 Offset: 0x3C79D31 VA: 0x3C79C30
	public void .ctor(string text, Texture image, string tooltip) { }

	// RVA: 0x3C79D00 Offset: 0x3C79E01 VA: 0x3C79D00
	public void .ctor(GUIContent src) { }

	// RVA: 0x3C71020 Offset: 0x3C71121 VA: 0x3C71020
	internal static GUIContent Temp(string t) { }

	// RVA: 0x3C79DC0 Offset: 0x3C79EC1 VA: 0x3C79DC0
	internal static void ClearStaticCache() { }

	// RVA: 0x3C79ED0 Offset: 0x3C79FD1 VA: 0x3C79ED0
	private static void .cctor() { }
}

