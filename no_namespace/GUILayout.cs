// Namespace: 
private sealed class GUILayout.LayoutedWindow // TypeDefIndex: 4152
{
	// Fields
	private readonly GUI.WindowFunction m_Func; // 0x10
	private readonly Rect m_ScreenRect; // 0x18
	private readonly GUILayoutOption[] m_Options; // 0x28
	private readonly GUIStyle m_Style; // 0x30

	// Methods

	// RVA: 0x1C65E00 Offset: 0x1C65F01 VA: 0x1C65E00
	internal void .ctor(GUI.WindowFunction f, Rect screenRect, GUIContent content, GUILayoutOption[] options, GUIStyle style) { }

	// RVA: 0x1C65EA0 Offset: 0x1C65FA1 VA: 0x1C65EA0
	public void DoWindow(int windowID) { }
}

// Namespace: 
public class GUILayout.AreaScope : GUI.Scope // TypeDefIndex: 4154
{
	// Methods

	// RVA: 0x1C65D60 Offset: 0x1C65E61 VA: 0x1C65D60
	public void .ctor(Rect screenRect) { }

	// RVA: 0x1C65DB0 Offset: 0x1C65EB1 VA: 0x1C65DB0 Slot: 6
	protected override void CloseScope() { }
}

