// Namespace: App
internal class ProcSceneManager : ProcInst // TypeDefIndex: 14090
{
	// Fields
	private const string Empty = "Empty";
	private static Dictionary<string, ResourceHandle> s_Handles; // 0x0
	private static List<ResourceHandle> s_Releases; // 0x8
	private string m_Name; // 0x70
	private LoadSceneMode m_Mode; // 0x78
	private ResourceHandle m_Empty; // 0x80
	private ResourceHandle m_Handle; // 0x88

	// Methods

	// RVA: 0x29E43D0 Offset: 0x29E44D1 VA: 0x29E43D0
	private void .ctor(string name, LoadSceneMode mode) { }

	// RVA: 0x29E4440 Offset: 0x29E4541 VA: 0x29E4440
	private static bool HasEmptyScene() { }

	// RVA: 0x29E4550 Offset: 0x29E4651 VA: 0x29E4550
	private void UnloadBranch() { }

	// RVA: 0x29E4610 Offset: 0x29E4711 VA: 0x29E4610
	private void UnloadAsync() { }

	// RVA: 0x29E4920 Offset: 0x29E4A21 VA: 0x29E4920
	private void WaitAsync() { }

	// RVA: 0x29E49B0 Offset: 0x29E4AB1 VA: 0x29E49B0
	private void Release() { }

	// RVA: 0x29E4B30 Offset: 0x29E4C31 VA: 0x29E4B30
	private void LoadAsync() { }

	// RVA: 0x29E4BD0 Offset: 0x29E4CD1 VA: 0x29E4BD0
	private void DoneAsync() { }

	// RVA: 0x29E4D40 Offset: 0x29E4E41 VA: 0x29E4D40
	public static void LoadBind(ProcInst super, string name, LoadSceneMode mode = 0) { }

	// RVA: 0x29E5860 Offset: 0x29E5961 VA: 0x29E5860
	public static void UnloadBind(ProcInst super) { }

	// RVA: 0x29E6010 Offset: 0x29E6111 VA: 0x29E6010
	public static void UnloadBind(ProcInst super, string name) { }

	// RVA: 0x29E58F0 Offset: 0x29E59F1 VA: 0x29E58F0
	private static void UnloadBindImpl(ProcInst super, string name, LoadSceneMode mode) { }

	// RVA: 0x29E6090 Offset: 0x29E6191 VA: 0x29E6090
	private static void .cctor() { }
}

