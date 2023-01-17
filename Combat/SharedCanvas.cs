// Namespace: Combat
public class SharedCanvas : MonoBehaviour // TypeDefIndex: 8746
{
	// Fields
	private static SharedCanvas s_this; // 0x0
	private Canvas m_Canvas; // 0x18
	private EditorPrefs_Bool m_bShown; // 0x20

	// Properties
	public static SharedCanvas Instance { get; }
	public static Canvas Canvas { get; }
	public static bool IsShown { get; }

	// Methods

	// RVA: 0x232E760 Offset: 0x232E861 VA: 0x232E760
	public static SharedCanvas get_Instance() { }

	// RVA: 0x232E7B0 Offset: 0x232E8B1 VA: 0x232E7B0
	public static Canvas get_Canvas() { }

	// RVA: 0x232E810 Offset: 0x232E911 VA: 0x232E810
	private Canvas GetCanvas() { }

	// RVA: 0x232E940 Offset: 0x232EA41 VA: 0x232E940
	private void Awake() { }

	// RVA: 0x232EBA0 Offset: 0x232ECA1 VA: 0x232EBA0
	private void OnDestroy() { }

	// RVA: 0x232ECD0 Offset: 0x232EDD1 VA: 0x232ECD0
	public void ForceDestroyCanvas() { }

	// RVA: 0x232E9F0 Offset: 0x232EAF1 VA: 0x232E9F0
	public static bool ReplaceInputModule() { }

	// RVA: 0x232EE10 Offset: 0x232EF11 VA: 0x232EE10
	public static bool get_IsShown() { }

	// RVA: 0x232EF00 Offset: 0x232F001 VA: 0x232EF00
	public void Show(bool v) { }

	// RVA: 0x232EFB0 Offset: 0x232F0B1 VA: 0x232EFB0
	private void Reconnect() { }

	// RVA: 0x232F1B0 Offset: 0x232F2B1 VA: 0x232F1B0
	public void ClearCanvas() { }

	// RVA: 0x232F300 Offset: 0x232F401 VA: 0x232F300
	public static int FromLeft(int margin) { }

	// RVA: 0x232F330 Offset: 0x232F431 VA: 0x232F330
	public static int FromRight(int margin) { }

	// RVA: 0x232F370 Offset: 0x232F471 VA: 0x232F370
	public static int FromTop(int margin) { }

	// RVA: 0x232F3B0 Offset: 0x232F4B1 VA: 0x232F3B0
	public static int FromBottom(int margin) { }

	// RVA: 0x232F3E0 Offset: 0x232F4E1 VA: 0x232F3E0
	public static float X(float value, float div = 32) { }

	// RVA: 0x232F440 Offset: 0x232F541 VA: 0x232F440
	public static float Y(float value, float div = 18) { }

	// RVA: 0x232F4A0 Offset: 0x232F5A1 VA: 0x232F4A0
	public static Vector2 XY(int x, int y) { }

	// RVA: 0x232F550 Offset: 0x232F651 VA: 0x232F550
	public void .ctor() { }
}

