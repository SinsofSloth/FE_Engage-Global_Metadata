// Namespace: App
public class GodRoomUnitSelectMenuContent : BasicMenuContent // TypeDefIndex: 10998
{
	// Fields
	private const string PrefabPath = "UI/Hub/GodRoom/Prefabs/UnitSelectRoot";
	public ShopUnitSelectStatus m_statusWindow; // 0xE8
	public GodRoomGodInfoSetter m_godInfo; // 0xF0
	private List<GodUnit> m_GodListActive; // 0xF8

	// Methods

	// RVA: 0x27B01D0 Offset: 0x27B02D1 VA: 0x27B01D0
	public List<GodUnit> GetGodListActive() { }

	// RVA: 0x27B01E0 Offset: 0x27B02E1 VA: 0x27B01E0 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x27B02A0 Offset: 0x27B03A1 VA: 0x27B02A0
	public static void LoadPrefabAsync() { }

	// RVA: 0x27B0340 Offset: 0x27B0441 VA: 0x27B0340
	public static bool IsLoadingPrefab() { }

	// RVA: 0x27B03C0 Offset: 0x27B04C1 VA: 0x27B03C0
	public static void UnloadPrefab() { }

	// RVA: 0x27AF660 Offset: 0x27AF761 VA: 0x27AF660
	public static GodRoomUnitSelectMenuContent Create() { }

	// RVA: 0x27B0440 Offset: 0x27B0541 VA: 0x27B0440
	public static void Destroy(GodRoomUnitSelectMenuContent content) { }

	// RVA: 0x27B04C0 Offset: 0x27B05C1 VA: 0x27B04C0 Slot: 21
	public override float CalcW() { }

	// RVA: 0x27B0530 Offset: 0x27B0631 VA: 0x27B0530 Slot: 22
	public override float CalcH() { }

	// RVA: 0x27AFBF0 Offset: 0x27AFCF1 VA: 0x27AFBF0
	public void OpenStatus() { }

	// RVA: 0x27B00D0 Offset: 0x27B01D1 VA: 0x27B00D0
	public void CloseStatus() { }

	// RVA: 0x27AFE60 Offset: 0x27AFF61 VA: 0x27AFE60
	public void SetUnitStatus(Unit unit) { }

	// RVA: 0x27AFA50 Offset: 0x27AFB51 VA: 0x27AFA50
	public void OnHelp(ProcInst parent) { }

	// RVA: 0x27AFF00 Offset: 0x27B0001 VA: 0x27AFF00
	public void UpdateGodInfo(Unit unit) { }

	// RVA: 0x27B05A0 Offset: 0x27B06A1 VA: 0x27B05A0
	public void .ctor() { }
}

