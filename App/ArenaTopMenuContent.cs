// Namespace: App
public class ArenaTopMenuContent : BasicMenuContent // TypeDefIndex: 10928
{
	// Fields
	private const string PrefabPath = "UI/Hub/Arena/Prefabs/TopMenuRoot";
	[HeaderAttribute] // RVA: 0x295E80 Offset: 0x295F81 VA: 0x295E80
	public GameObject LastCountRoot; // 0xE8
	public TextMeshProUGUI LastCount; // 0xF0
	[HeaderAttribute] // RVA: 0x295EC0 Offset: 0x295FC1 VA: 0x295EC0
	public GameObject GodBondHelpRoot; // 0xF8

	// Methods

	// RVA: 0x2609000 Offset: 0x2609101 VA: 0x2609000
	public static void LoadPrefabAsync() { }

	// RVA: 0x2609080 Offset: 0x2609181 VA: 0x2609080
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2609100 Offset: 0x2609201 VA: 0x2609100
	public static void UnloadPrefab() { }

	// RVA: 0x2608C30 Offset: 0x2608D31 VA: 0x2608C30
	public static ArenaTopMenuContent Create() { }

	// RVA: 0x2609180 Offset: 0x2609281 VA: 0x2609180 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2609190 Offset: 0x2609291 VA: 0x2609190 Slot: 21
	public override float CalcW() { }

	// RVA: 0x2609200 Offset: 0x2609301 VA: 0x2609200 Slot: 22
	public override float CalcH() { }

	// RVA: 0x2608CE0 Offset: 0x2608DE1 VA: 0x2608CE0
	public void SetState(int lastTrainCount, bool showCount) { }

	// RVA: 0x2608EA0 Offset: 0x2608FA1 VA: 0x2608EA0
	public void ToggleNormal(bool show) { }

	// RVA: 0x2609270 Offset: 0x2609371 VA: 0x2609270
	public void .ctor() { }
}

