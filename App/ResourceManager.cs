// Namespace: App
public class ResourceManager // TypeDefIndex: 13919
{
	// Fields
	private const int EntryCount = 4096;
	private const int GlobalCount = 1024;
	private static object s_LockObject; // 0x0
	private static Stack<ResourceHandle> s_GlobalHandles; // 0x8
	private static Stack<Stack<ResourceHandle>> s_GlobalStacks; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x29CBD0 Offset: 0x29CCD1 VA: 0x29CBD0
	private static readonly Dictionary<string, Stack<ResourceHandle>> <s_Globals>k__BackingField; // 0x18
	private static Stack<LinkedList<AsyncOperationHandle>> s_LinkedStack; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29CBE0 Offset: 0x29CCE1 VA: 0x29CBE0
	private static readonly Dictionary<string, AsyncOperationHandle> <s_Entries>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x29CBF0 Offset: 0x29CCF1 VA: 0x29CBF0
	private static readonly Dictionary<string, int> <s_Counters>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x29CC00 Offset: 0x29CD01 VA: 0x29CC00
	private static readonly Queue<AsyncOperationHandle> <s_Releases>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x29CC10 Offset: 0x29CD11 VA: 0x29CC10
	private static readonly Dictionary<string, bool> <s_Files>k__BackingField; // 0x40
	private static bool s_IsInitialized; // 0x48

	// Properties
	private static Dictionary<string, Stack<ResourceHandle>> s_Globals { get; }
	private static Dictionary<string, AsyncOperationHandle> s_Entries { get; }
	private static Dictionary<string, int> s_Counters { get; }
	private static Queue<AsyncOperationHandle> s_Releases { get; }
	private static Dictionary<string, bool> s_Files { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CD950 Offset: 0x2CDA51 VA: 0x2CD950
	// RVA: 0x24CE440 Offset: 0x24CE541 VA: 0x24CE440
	private static Dictionary<string, Stack<ResourceHandle>> get_s_Globals() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD960 Offset: 0x2CDA61 VA: 0x2CD960
	// RVA: 0x24CE4B0 Offset: 0x24CE5B1 VA: 0x24CE4B0
	private static Dictionary<string, AsyncOperationHandle> get_s_Entries() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD970 Offset: 0x2CDA71 VA: 0x2CD970
	// RVA: 0x24CE520 Offset: 0x24CE621 VA: 0x24CE520
	private static Dictionary<string, int> get_s_Counters() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD980 Offset: 0x2CDA81 VA: 0x2CD980
	// RVA: 0x24CE590 Offset: 0x24CE691 VA: 0x24CE590
	private static Queue<AsyncOperationHandle> get_s_Releases() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD990 Offset: 0x2CDA91 VA: 0x2CD990
	// RVA: 0x24CE600 Offset: 0x24CE701 VA: 0x24CE600
	private static Dictionary<string, bool> get_s_Files() { }

	// RVA: 0x24CE670 Offset: 0x24CE771 VA: 0x24CE670
	public static bool IsInitialized() { }

	// RVA: 0x24CE6E0 Offset: 0x24CE7E1 VA: 0x24CE6E0
	private static void LogException(AsyncOperationHandle op, Exception ex) { }

	// RVA: 0x24CE6F0 Offset: 0x24CE7F1 VA: 0x24CE6F0
	private static bool TryAddFile(string key, bool isScene) { }

	// RVA: 0x24CE880 Offset: 0x24CE981 VA: 0x24CE880
	private static void EntryFileTable() { }

	// RVA: 0x24CF2F0 Offset: 0x24CF3F1 VA: 0x24CF2F0
	public static void Initialize() { }

	// RVA: 0x24CF5D0 Offset: 0x24CF6D1 VA: 0x24CF5D0
	public static void Release() { }

	// RVA: 0x24CD9C0 Offset: 0x24CDAC1 VA: 0x24CD9C0
	public static void Add(string path, AsyncOperationHandle handle) { }

	// RVA: 0x24CE030 Offset: 0x24CE131 VA: 0x24CE030
	public static void Remove(string path) { }

	// RVA: 0x24CDE70 Offset: 0x24CDF71 VA: 0x24CDE70
	public static void Release(AsyncOperationHandle handle) { }

	// RVA: 0x24CF770 Offset: 0x24CF871 VA: 0x24CF770
	public static void Update() { }

	// RVA: 0x24CFDB0 Offset: 0x24CFEB1 VA: 0x24CFDB0
	public static bool IsLoading() { }

	// RVA: 0x24B88A0 Offset: 0x24B89A1 VA: 0x24B88A0
	public static bool IsLoading(string path) { }

	// RVA: -1 Offset: -1
	public static void LoadGlobalAsync<T>(string path, Action<T> completed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2017250 Offset: 0x2017351 VA: 0x2017250
	|-ResourceManager.LoadGlobalAsync<AnimatorOverrideController>
	|-ResourceManager.LoadGlobalAsync<GameObject>
	|-ResourceManager.LoadGlobalAsync<object>
	|-ResourceManager.LoadGlobalAsync<Sprite>
	|-ResourceManager.LoadGlobalAsync<SpriteAtlas>
	|-ResourceManager.LoadGlobalAsync<Texture2D>
	*/

	// RVA: 0x24B8B30 Offset: 0x24B8C31 VA: 0x24B8B30
	public static void ReleaseGlobal(string path) { }

	// RVA: -1 Offset: -1
	public static bool TryLoadGlobalAsync<T>(string path, Action<T> completed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2017510 Offset: 0x2017611 VA: 0x2017510
	|-ResourceManager.TryLoadGlobalAsync<GameObject>
	|-ResourceManager.TryLoadGlobalAsync<object>
	|-ResourceManager.TryLoadGlobalAsync<Sprite>
	*/

	// RVA: 0x24BDC70 Offset: 0x24BDD71 VA: 0x24BDC70
	public static bool TryReleaseGlobal(string path) { }

	// RVA: -1 Offset: -1
	public static T GetAsset<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2016FE0 Offset: 0x20170E1 VA: 0x2016FE0
	|-ResourceManager.GetAsset<AnimatorOverrideController>
	|-ResourceManager.GetAsset<GameObject>
	|-ResourceManager.GetAsset<object>
	|-ResourceManager.GetAsset<PlayableAsset>
	|-ResourceManager.GetAsset<Sprite>
	|-ResourceManager.GetAsset<SpriteAtlas>
	|-ResourceManager.GetAsset<Texture2D>
	*/

	// RVA: 0x24B84A0 Offset: 0x24B85A1 VA: 0x24B84A0
	public static GameObject Instantiate(string path, GameObject parent) { }

	// RVA: 0x24D02E0 Offset: 0x24D03E1 VA: 0x24D02E0
	public static GameObject Instantiate(string path, Transform parent) { }

	// RVA: 0x24D0500 Offset: 0x24D0601 VA: 0x24D0500
	public static bool FileExists(string path) { }

	// RVA: 0x24D0690 Offset: 0x24D0791 VA: 0x24D0690
	public void .ctor() { }

	// RVA: 0x24D06A0 Offset: 0x24D07A1 VA: 0x24D06A0
	private static void .cctor() { }
}

