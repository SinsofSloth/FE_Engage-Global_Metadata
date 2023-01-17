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
public class GUILayout.HorizontalScope : GUI.Scope // TypeDefIndex: 4153
{
	// Methods

	// RVA: 0x1C65DC0 Offset: 0x1C65EC1 VA: 0x1C65DC0
	public void .ctor(GUILayoutOption[] options) { }

	// RVA: 0x1C65DF0 Offset: 0x1C65EF1 VA: 0x1C65DF0 Slot: 6
	protected override void CloseScope() { }
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

// Namespace: 
public class GUILayout.ScrollViewScope : GUI.Scope // TypeDefIndex: 4155
{
	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x53410 Offset: 0x53511 VA: 0x53410
	[CompilerGeneratedAttribute] // RVA: 0x53410 Offset: 0x53511 VA: 0x53410
	private Vector2 <scrollPosition>k__BackingField; // 0x14
	[DebuggerBrowsableAttribute] // RVA: 0x53450 Offset: 0x53551 VA: 0x53450
	[CompilerGeneratedAttribute] // RVA: 0x53450 Offset: 0x53551 VA: 0x53450
	private bool <handleScrollWheel>k__BackingField; // 0x1C

	// Properties
	public Vector2 scrollPosition { get; set; }
	public bool handleScrollWheel { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x53A50 Offset: 0x53B51 VA: 0x53A50
	// RVA: 0x1C65FA0 Offset: 0x1C660A1 VA: 0x1C65FA0
	public Vector2 get_scrollPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x53A60 Offset: 0x53B61 VA: 0x53A60
	// RVA: 0x1C65FB0 Offset: 0x1C660B1 VA: 0x1C65FB0
	private void set_scrollPosition(Vector2 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x53A70 Offset: 0x53B71 VA: 0x53A70
	// RVA: 0x1C65FC0 Offset: 0x1C660C1 VA: 0x1C65FC0
	public bool get_handleScrollWheel() { }

	[CompilerGeneratedAttribute] // RVA: 0x53A80 Offset: 0x53B81 VA: 0x53A80
	// RVA: 0x1C65FD0 Offset: 0x1C660D1 VA: 0x1C65FD0
	public void set_handleScrollWheel(bool value) { }

	// RVA: 0x1C65FE0 Offset: 0x1C660E1 VA: 0x1C65FE0
	public void .ctor(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUILayoutOption[] options) { }

	// RVA: 0x1C66060 Offset: 0x1C66161 VA: 0x1C66060 Slot: 6
	protected override void CloseScope() { }
}

