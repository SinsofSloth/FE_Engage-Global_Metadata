// Namespace: UnityEngine
public class TextEditor // TypeDefIndex: 4180
{
	// Fields
	public TouchScreenKeyboard keyboardOnScreen; // 0x10
	public int controlID; // 0x18
	public GUIStyle style; // 0x20
	public bool multiline; // 0x28
	public bool hasHorizontalCursorPos; // 0x29
	public bool isPasswordField; // 0x2A
	public Vector2 scrollOffset; // 0x2C
	private GUIContent m_Content; // 0x38
	private int m_CursorIndex; // 0x40
	private int m_SelectIndex; // 0x44
	private bool m_RevealCursor; // 0x48
	private bool m_MouseDragSelectsWholeWords; // 0x49
	private int m_DblClickInitPos; // 0x4C
	private TextEditor.DblClickSnapping m_DblClickSnap; // 0x50
	private bool m_bJustSelected; // 0x51
	private int m_iAltCursorPos; // 0x54

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x541B0 Offset: 0x542B1 VA: 0x541B0
	// RVA: 0x3C8A430 Offset: 0x3C8A531 VA: 0x3C8A430
	public void .ctor() { }
}

