// Namespace: App
public class DLCManager // TypeDefIndex: 13828
{
	// Fields
	public const string ApplicationId = "0100A6301214E000";
	private static readonly string StreamingAssetsPath; // 0x0
	private static List<DLCManager.MountData> s_MountData; // 0x8
	private static bool s_AwakeChangedEvent; // 0x10
	private static UnityEvent s_ChangedEventListener; // 0x18
	private static bool s_IsInitialized; // 0x20
	private static DLCManager.DLCList[] s_HasList; // 0x28

	// Methods

	// RVA: 0x23C34F0 Offset: 0x23C35F1 VA: 0x23C34F0
	public static void Initialize() { }

	// RVA: 0x23C3B10 Offset: 0x23C3C11 VA: 0x23C3B10
	public static void Release() { }

	// RVA: 0x23C3CD0 Offset: 0x23C3DD1 VA: 0x23C3CD0
	public static void Refresh() { }

	// RVA: 0x23C3F70 Offset: 0x23C4071 VA: 0x23C3F70
	public static void Update() { }

	// RVA: 0x23C35A0 Offset: 0x23C36A1 VA: 0x23C35A0
	private static void MountDLC() { }

	// RVA: 0x23C4270 Offset: 0x23C4371 VA: 0x23C4270
	public static string GetFolderName(DLCManager.Content content) { }

	// RVA: 0x23C41E0 Offset: 0x23C42E1 VA: 0x23C41E0
	public static string GetAssetGroupName(DLCManager.Content content) { }

	// RVA: 0x23C4300 Offset: 0x23C4401 VA: 0x23C4300
	public static DLCManager.Content GetContent(string name) { }

	// RVA: 0x23C43C0 Offset: 0x23C44C1 VA: 0x23C43C0
	public static string GetStreamingAssetsDLCPath(DLCManager.Content content) { }

	// RVA: 0x23C44B0 Offset: 0x23C45B1 VA: 0x23C44B0
	public static bool HasContent(DLCManager.Content content) { }

	// RVA: 0x23C4690 Offset: 0x23C4791 VA: 0x23C4690
	public static bool HasContents(DLCManager.Content[] contents) { }

	// RVA: 0x23C4720 Offset: 0x23C4821 VA: 0x23C4720
	public static bool HasContentError(DLCManager.Content content) { }

	// RVA: 0x23C4860 Offset: 0x23C4961 VA: 0x23C4860
	public static int GetAddOnContentIndex(DLCManager.Content content) { }

	// RVA: 0x23C4100 Offset: 0x23C4201 VA: 0x23C4100
	public static bool TryIndexToContent(int index, out DLCManager.Content content) { }

	// RVA: 0x23C4680 Offset: 0x23C4781 VA: 0x23C4680
	public static bool IsRequiredReleaseVersion(DLCManager.Content content) { }

	// RVA: 0x23C4870 Offset: 0x23C4971 VA: 0x23C4870
	public static DLCManager.Content[] GetAllContents() { }

	// RVA: 0x23C4BC0 Offset: 0x23C4CC1 VA: 0x23C4BC0
	public static void ShowUnacceptableVersion() { }

	// RVA: 0x23C47B0 Offset: 0x23C48B1 VA: 0x23C47B0
	public static void ShowLostError(DLCManager.Content content) { }

	// RVA: 0x23C4BD0 Offset: 0x23C4CD1 VA: 0x23C4BD0
	public static void ShowLostError(DLCManager.Content[] contents) { }

	// RVA: 0x23C4D90 Offset: 0x23C4E91 VA: 0x23C4D90
	public static void ShowShopList(UserHandle userHandle) { }

	// RVA: 0x23C3940 Offset: 0x23C3A41 VA: 0x23C3940
	private static void InitHasList() { }

	// RVA: 0x23C45C0 Offset: 0x23C46C1 VA: 0x23C45C0
	private static DLCManager.DLCList GetHasList(DLCManager.Content content) { }

	// RVA: 0x23C3D40 Offset: 0x23C3E41 VA: 0x23C3D40
	private static void RefreshHasList() { }

	// RVA: 0x23C4E10 Offset: 0x23C4F11 VA: 0x23C4E10
	private static void StartListChangedEvent() { }

	// RVA: 0x23C3FE0 Offset: 0x23C40E1 VA: 0x23C3FE0
	private static bool TryRunListChangedEvent() { }

	// RVA: 0x23C4EC0 Offset: 0x23C4FC1 VA: 0x23C4EC0
	public static void AddChangedEventListener(UnityAction addEvent) { }

	// RVA: 0x23C4F40 Offset: 0x23C5041 VA: 0x23C4F40
	public static void RemoveChangedEventListener(UnityAction removeEvent) { }

	// RVA: 0x23C4FC0 Offset: 0x23C50C1 VA: 0x23C4FC0
	public void .ctor() { }

	// RVA: 0x23C4FD0 Offset: 0x23C50D1 VA: 0x23C4FD0
	private static void .cctor() { }
}

