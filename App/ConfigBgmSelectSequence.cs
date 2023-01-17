// Namespace: App
internal class ConfigBgmSelectSequence : SingletonProcInst<ConfigBgmSelectSequence> // TypeDefIndex: 9790
{
	// Fields
	private string m_selectBgm; // 0x78
	private Action<string> m_callback; // 0x80

	// Methods

	// RVA: 0x23B36C0 Offset: 0x23B37C1 VA: 0x23B36C0
	public void .ctor(string selectBgm, Action<string> callback) { }

	// RVA: 0x23B3770 Offset: 0x23B3871 VA: 0x23B3770
	private void LoadResources() { }

	// RVA: 0x23B3840 Offset: 0x23B3941 VA: 0x23B3840
	private void UnloadResources() { }

	// RVA: 0x23B3850 Offset: 0x23B3951 VA: 0x23B3850
	private bool IsLoadingResources() { }

	// RVA: 0x23B38C0 Offset: 0x23B39C1 VA: 0x23B38C0
	private void CreateMenu() { }

	// RVA: 0x23B39B0 Offset: 0x23B3AB1 VA: 0x23B39B0
	private void Exit() { }

	// RVA: 0x23B3AE0 Offset: 0x23B3BE1 VA: 0x23B3AE0
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x23B3EB0 Offset: 0x23B3FB1 VA: 0x23B3EB0
	public static void CreateBind(ProcInst super, string selectBgm, Action<string> callback) { }
}

