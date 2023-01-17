// Namespace: App
public class GX : GUI // TypeDefIndex: 9194
{
	// Fields
	private static readonly Color scrollBaseColor; // 0x0
	private static readonly Color scrollBarColor; // 0x10
	public const float CanvasSizeX = 1920;
	public const float CanvasSizeY = 1080;
	public const float CanvasHalfX = 960;
	public const float CanvasHalfY = 540;

	// Methods

	// RVA: 0x26A0D40 Offset: 0x26A0E41 VA: 0x26A0D40
	public static Vector2 GetAnchorDir(GX.Anchor anchor) { }

	// RVA: 0x26A0D80 Offset: 0x26A0E81 VA: 0x26A0D80
	public static Vector3 GetAnchorPos(GX.Anchor anchor) { }

	// RVA: 0x26A0E80 Offset: 0x26A0F81 VA: 0x26A0E80
	public static Rect GetReduceRect(Rect rect, float size) { }

	// RVA: 0x26A0F20 Offset: 0x26A1021 VA: 0x26A0F20
	public static Rect GetReduceRect(Rect rect, float sizeX, float sizeY) { }

	// RVA: 0x26A0FF0 Offset: 0x26A10F1 VA: 0x26A0FF0
	public static Rect GetLocalRect(Rect rect) { }

	// RVA: 0x26A1050 Offset: 0x26A1151 VA: 0x26A1050
	public static void SetupScreenMatrix(GX.Anchor anchor) { }

	// RVA: 0x26A1120 Offset: 0x26A1221 VA: 0x26A1120
	public static Matrix4x4 GetScreenSpaceMatrix(GX.Anchor anchor) { }

	// RVA: 0x26A1300 Offset: 0x26A1401 VA: 0x26A1300
	public static void DrawRect(Rect rect, Color color) { }

	// RVA: 0x26A13D0 Offset: 0x26A14D1 VA: 0x26A13D0
	public static void DrawRect(float x, float y, float w, float h, Color color) { }

	// RVA: 0x26A1510 Offset: 0x26A1611 VA: 0x26A1510
	public static void DrawText(float x, float y, float w, float h, Color color, string text) { }

	// RVA: 0x26A1790 Offset: 0x26A1891 VA: 0x26A1790
	public static void DrawText(Rect rect, Color color, string text) { }

	// RVA: 0x26A1900 Offset: 0x26A1A01 VA: 0x26A1900
	public static void BeginScreenClip(Rect rect) { }

	// RVA: 0x26A1990 Offset: 0x26A1A91 VA: 0x26A1990
	public static void BeginScreenClip(float x, float y, float width, float height) { }

	// RVA: 0x26A1A40 Offset: 0x26A1B41 VA: 0x26A1A40
	public static void EndScreenClip() { }

	// RVA: 0x26A1AB0 Offset: 0x26A1BB1 VA: 0x26A1AB0
	public static void DrawScrollBar(float x, float y, Color color, float height, float pos, float max) { }

	// RVA: 0x26A1D40 Offset: 0x26A1E41 VA: 0x26A1D40
	public static Vector2 GetTextSize(GUIStyle style, string text) { }

	// RVA: 0x26A1DC0 Offset: 0x26A1EC1 VA: 0x26A1DC0
	public static Vector2 GetTextSize(string text) { }

	// RVA: 0x26A1F00 Offset: 0x26A2001 VA: 0x26A1F00
	public void .ctor() { }

	// RVA: 0x26A1F70 Offset: 0x26A2071 VA: 0x26A1F70
	private static void .cctor() { }
}

