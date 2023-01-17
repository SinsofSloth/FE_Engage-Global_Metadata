// Namespace: App
[RequireComponent] // RVA: 0x274D00 Offset: 0x274E01 VA: 0x274D00
public class DebugWindow : MonoBehaviour // TypeDefIndex: 8963
{
	// Fields
	private const int DrawSize = 26;
	private const int DigitSize = 16;
	public Font m_Font; // 0x18
	public Material m_Material; // 0x20
	private DebugMesh m_Mesh; // 0x28
	private DebugMenu m_Menu; // 0x30
	private Material m_FontMaterial; // 0x38
	private Material m_HelpMaterial; // 0x40
	private CanvasRenderer m_Renderer; // 0x48
	private Vector2 m_MaskUV; // 0x50
	private int m_FontSize; // 0x58
	private float m_FontScale; // 0x5C
	private FontStyle m_FontStyle; // 0x60
	protected const float ScreenX = 1920;
	protected const float ScreenY = 1080;

	// Properties
	protected DebugMesh Mesh { get; }

	// Methods

	// RVA: 0x2EAA780 Offset: 0x2EAA881 VA: 0x2EAA780
	public void SetMenu(DebugMenu menu) { }

	// RVA: 0x2EAA790 Offset: 0x2EAA891 VA: 0x2EAA790
	protected DebugMesh get_Mesh() { }

	// RVA: 0x2EA4660 Offset: 0x2EA4761 VA: 0x2EA4660
	public float GetTextWidth(string text) { }

	// RVA: 0x2EA4860 Offset: 0x2EA4961 VA: 0x2EA4860
	public float GetTextHeight(string text) { }

	// RVA: 0x2EAA7A0 Offset: 0x2EAA8A1 VA: 0x2EAA7A0
	private void Awake() { }

	// RVA: 0x2EAA840 Offset: 0x2EAA941 VA: 0x2EAA840
	private void Start() { }

	// RVA: 0x2EAAD10 Offset: 0x2EAAE11 VA: 0x2EAAD10
	private void OnDestroy() { }

	// RVA: 0x2EAADB0 Offset: 0x2EAAEB1 VA: 0x2EAADB0
	protected bool TryGetInfo(char ch, out CharacterInfo info) { }

	// RVA: 0x2EAAE10 Offset: 0x2EAAF11 VA: 0x2EAAE10
	protected static float ToScreenX(float x) { }

	// RVA: 0x2EAAE20 Offset: 0x2EAAF21 VA: 0x2EAAE20
	protected static float ToScreenY(float y) { }

	// RVA: 0x2EAAE30 Offset: 0x2EAAF31 VA: 0x2EAAE30
	protected float DrawFont(float x, float y, float h, Color color, char ch, float scale = 1, bool outline = False) { }

	// RVA: 0x2EAB830 Offset: 0x2EAB931 VA: 0x2EAB830
	protected void DrawText(float x, float y, float h, Color color, string text, float scale = 1, bool outline = False) { }

	// RVA: 0x2EAB970 Offset: 0x2EABA71 VA: 0x2EAB970
	protected void DrawRect(float x, float y, float w, float h, Color color) { }

	// RVA: 0x2EABC90 Offset: 0x2EABD91 VA: 0x2EABC90
	protected void DrawRect(Rect rect, Color color) { }

	// RVA: 0x2EABD50 Offset: 0x2EABE51 VA: 0x2EABD50
	protected void DrawScrollBar(float x, float y, Color color, float height, float pos, float max) { }

	// RVA: 0x2EABEE0 Offset: 0x2EABFE1 VA: 0x2EABEE0 Slot: 4
	protected virtual void OnDraw() { }

	// RVA: 0x2EACAE0 Offset: 0x2EACBE1 VA: 0x2EACAE0
	private void LateUpdate() { }

	// RVA: 0x2EAC9D0 Offset: 0x2EACAD1 VA: 0x2EAC9D0
	protected void SetClip(Material material, Rect rect) { }

	// RVA: 0x2EAAC30 Offset: 0x2EAAD31 VA: 0x2EAAC30
	protected void SetClip(Material material, float x, float y, float w, float h) { }

	// RVA: 0x2EAC6D0 Offset: 0x2EAC7D1 VA: 0x2EAC6D0
	protected Rect GetAnchorRect(Rect rect, GX.Anchor anchor) { }

	// RVA: 0x2E9D540 Offset: 0x2E9D641 VA: 0x2E9D540
	public void .ctor() { }
}

