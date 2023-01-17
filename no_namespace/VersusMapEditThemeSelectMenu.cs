// Namespace: 
public sealed class VersusMapEditThemeSelectMenu.SelectedFunction : MulticastDelegate // TypeDefIndex: 13726
{
	// Methods

	// RVA: 0x1EE25D0 Offset: 0x1EE26D1 VA: 0x1EE25D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EE25F0 Offset: 0x1EE26F1 VA: 0x1EE25F0 Slot: 13
	public virtual void Invoke(ProfileCardThemeOfEditMapData selectedTheme) { }

	// RVA: 0x1EE2950 Offset: 0x1EE2A51 VA: 0x1EE2950 Slot: 14
	public virtual IAsyncResult BeginInvoke(ProfileCardThemeOfEditMapData selectedTheme, AsyncCallback callback, object object) { }

	// RVA: 0x1EE2980 Offset: 0x1EE2A81 VA: 0x1EE2980 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class VersusMapEditThemeSelectMenu.VersusMapEditThemeSelectMenuItem : BasicMenuItem // TypeDefIndex: 13727
{
	// Fields
	private ProfileCardThemeOfEditMapData m_Data; // 0x68
	private bool m_IsChecked; // 0x70
	private VersusMapEditThemeSelectMenu.SelectedFunction m_SelectedFunc; // 0x78

	// Methods

	// RVA: 0x1EE2570 Offset: 0x1EE2671 VA: 0x1EE2570
	public void .ctor(ProfileCardThemeOfEditMapData data, bool isChecked, VersusMapEditThemeSelectMenu.SelectedFunction func) { }

	// RVA: 0x1EE2990 Offset: 0x1EE2A91 VA: 0x1EE2990 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1EE2A40 Offset: 0x1EE2B41 VA: 0x1EE2A40 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x1EE2A50 Offset: 0x1EE2B51 VA: 0x1EE2A50 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x1EE2C90 Offset: 0x1EE2D91 VA: 0x1EE2C90 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1EE2CE0 Offset: 0x1EE2DE1 VA: 0x1EE2CE0 Slot: 14
	public override void OnCursorMoveEnd() { }

	// RVA: 0x1EE2D30 Offset: 0x1EE2E31 VA: 0x1EE2D30 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1EE2D60 Offset: 0x1EE2E61 VA: 0x1EE2D60 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x1EE2D70 Offset: 0x1EE2E71 VA: 0x1EE2D70 Slot: 4
	public override string GetName() { }

	// RVA: 0x1EE2D80 Offset: 0x1EE2E81 VA: 0x1EE2D80
	public bool IsChecked() { }

	// RVA: 0x1EE2A90 Offset: 0x1EE2B91 VA: 0x1EE2A90
	private void SetInitialColor() { }

	// RVA: 0x1EE2BA0 Offset: 0x1EE2CA1 VA: 0x1EE2BA0
	private void UpdateFixedCursor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279260 Offset: 0x279361 VA: 0x279260
private sealed class VersusMapEditThemeSelectMenu.<>c__DisplayClass4_0 // TypeDefIndex: 13728
{
	// Fields
	public List<BasicMenuItem> menuItemList; // 0x10
	public ProfileCardThemeOfEditMapData nowTheme; // 0x18
	public VersusMapEditThemeSelectMenu.SelectedFunction func; // 0x20

	// Methods

	// RVA: 0x1EE24A0 Offset: 0x1EE25A1 VA: 0x1EE24A0
	public void .ctor() { }

	// RVA: 0x1EE24B0 Offset: 0x1EE25B1 VA: 0x1EE24B0
	internal void <CreateBind>b__0(ProfileCardThemeOfEditMapData data) { }
}

