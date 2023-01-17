// Namespace: App
internal class FileViewerItem : MenuItem // TypeDefIndex: 8943
{
	// Fields
	private string m_Path; // 0x20
	private Func<DebugMenu, string, MenuItem.Result> m_Func; // 0x28

	// Methods

	// RVA: 0x2A219C0 Offset: 0x2A21AC1 VA: 0x2A219C0
	public void .ctor(string path, Func<DebugMenu, string, MenuItem.Result> func) { }

	// RVA: 0x2A21AC0 Offset: 0x2A21BC1 VA: 0x2A21AC0 Slot: 5
	public override string GetName() { }

	// RVA: 0x2A21B10 Offset: 0x2A21C11 VA: 0x2A21B10 Slot: 12
	public override MenuItem.Result ACall() { }

	// RVA: 0x2A21EA0 Offset: 0x2A21FA1 VA: 0x2A21EA0
	private static MenuItem.Result DefaultFunc(DebugMenu menu, string name) { }

	// RVA: 0x2A21B40 Offset: 0x2A21C41 VA: 0x2A21B40
	public static void CreateMenu(ProcInst super, string path, Func<DebugMenu, string, MenuItem.Result> func) { }
}

