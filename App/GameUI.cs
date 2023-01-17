// Namespace: App
public class GameUI : SingletonMonoBehaviour<GameUI> // TypeDefIndex: 8967
{
	// Fields
	public const string UnknownName = "Unknown";

	// Methods

	// RVA: 0x28CDDD0 Offset: 0x28CDED1 VA: 0x28CDDD0
	public static GameObject GetRoot() { }

	// RVA: 0x28CDE50 Offset: 0x28CDF51 VA: 0x28CDE50
	public static GameObject GetCanvas(GameUI.Priority priority = 0) { }

	// RVA: 0x28CE060 Offset: 0x28CE161 VA: 0x28CE060
	public static GameObject GetCanvas(string name, GameUI.Priority priority = 0) { }

	// RVA: 0x28CDF10 Offset: 0x28CE011 VA: 0x28CDF10
	private static GameObject TryCreateCanvas(GameObject parent, string name, GameUI.Priority priority) { }

	// RVA: 0x28CE190 Offset: 0x28CE291 VA: 0x28CE190
	private static void TrySetSortOrder(GameObject go, GameUI.Priority priority) { }

	// RVA: 0x28CE210 Offset: 0x28CE311 VA: 0x28CE210
	public void .ctor() { }
}

