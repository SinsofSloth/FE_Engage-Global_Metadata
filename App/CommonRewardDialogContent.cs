// Namespace: App
internal class CommonRewardDialogContent : GameMessageContent // TypeDefIndex: 12590
{
	// Fields
	private const string PrefabPath = "UI/Network/Relay/Prefabs/WdwDialogRelayResultData";

	// Methods

	// RVA: 0x257B600 Offset: 0x257B701 VA: 0x257B600
	public static void LoadPrefabAsync() { }

	// RVA: 0x257B6A0 Offset: 0x257B7A1 VA: 0x257B6A0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x257B720 Offset: 0x257B821 VA: 0x257B720
	public static void UnloadPrefab() { }

	// RVA: 0x257B7A0 Offset: 0x257B8A1 VA: 0x257B7A0
	public static CommonRewardDialogContent CreateRelay(List<RelayCompletionAwardData.CalcResult.Item> mainItemParamList, List<RelayCompletionAwardData.CalcResult.Item> subItemParamList) { }

	// RVA: 0x257B030 Offset: 0x257B131 VA: 0x257B030
	public static CommonRewardDialogContent CreateSubOnly(string titleText, Dictionary<ItemData, int> subItemParamList, int money = 0) { }

	// RVA: 0x257BC60 Offset: 0x257BD61 VA: 0x257BC60
	private static void SetItem(GameObject root, ItemData item, int count) { }

	// RVA: 0x257C150 Offset: 0x257C251 VA: 0x257C150
	public void .ctor() { }
}

