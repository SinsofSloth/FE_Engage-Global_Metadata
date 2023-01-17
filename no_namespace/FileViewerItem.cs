// Namespace: 
private class FileViewerItem.PathItem : StringItem // TypeDefIndex: 8940
{
	// Fields
	private string m_Path; // 0x30
	private Func<DebugMenu, string, MenuItem.Result> m_Func; // 0x38

	// Methods

	// RVA: 0x22DB2E0 Offset: 0x22DB3E1 VA: 0x22DB2E0
	public void .ctor(string path, string name, Func<DebugMenu, string, MenuItem.Result> func) { }

	// RVA: 0x22DB420 Offset: 0x22DB521 VA: 0x22DB420
	protected string GetFullPath() { }

	// RVA: 0x22DB730 Offset: 0x22DB831 VA: 0x22DB730
	protected Func<DebugMenu, string, MenuItem.Result> GetFunc() { }

	// RVA: 0x22DB610 Offset: 0x22DB711 VA: 0x22DB610
	protected MenuItem.Result DoFunc() { }
}

// Namespace: 
private class FileViewerItem.FileItem : FileViewerItem.PathItem // TypeDefIndex: 8942
{
	// Methods

	// RVA: 0x22DB520 Offset: 0x22DB621 VA: 0x22DB520
	public void .ctor(string path, string name, Func<DebugMenu, string, MenuItem.Result> func) { }

	// RVA: 0x22DB580 Offset: 0x22DB681 VA: 0x22DB580 Slot: 12
	public override MenuItem.Result ACall() { }

	// RVA: 0x22DB6A0 Offset: 0x22DB7A1 VA: 0x22DB6A0 Slot: 14
	public override MenuItem.Result XCall() { }
}

