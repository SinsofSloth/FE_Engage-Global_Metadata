// Namespace: App
internal class RelayMessageMenuContent : BasicMenuContent // TypeDefIndex: 12886
{
	// Fields
	private const string PrefabPath = "UI/Network/Relay/Prefabs/RelayMessageMenuRoot";
	public RelayMessageMenuContent.KindIcon[] m_KindIcon; // 0xE8
	private List<RelayMessageMenuContent.KindIcon> m_ActiveKindIcon; // 0xF0

	// Methods

	// RVA: 0x24BA590 Offset: 0x24BA691 VA: 0x24BA590
	public static void LoadPrefabAsync() { }

	// RVA: 0x24BA610 Offset: 0x24BA711 VA: 0x24BA610
	public static bool IsLoadingPrefab() { }

	// RVA: 0x24BA690 Offset: 0x24BA791 VA: 0x24BA690
	public static void UnloadPrefab() { }

	// RVA: 0x24B8F20 Offset: 0x24B9021 VA: 0x24B8F20
	public static RelayMessageMenuContent Create(RelayStampData.Kinds kind) { }

	// RVA: 0x24BABC0 Offset: 0x24BACC1 VA: 0x24BABC0 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x24BABE0 Offset: 0x24BACE1 VA: 0x24BABE0 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x24BA710 Offset: 0x24BA811 VA: 0x24BA710
	public void Setup(RelayStampData.Kinds kind) { }

	// RVA: 0x24B9D70 Offset: 0x24B9E71 VA: 0x24B9D70
	public RelayStampData.Kinds SetToPrevKind(RelayStampData.Kinds now) { }

	// RVA: 0x24BA370 Offset: 0x24BA471 VA: 0x24BA370
	public RelayStampData.Kinds SetToNextKind(RelayStampData.Kinds now) { }

	// RVA: 0x24B9D00 Offset: 0x24B9E01 VA: 0x24B9D00
	public bool IsFirstKind(RelayStampData.Kinds kind) { }

	// RVA: 0x24BA2E0 Offset: 0x24BA3E1 VA: 0x24BA2E0
	public bool IsLastKind(RelayStampData.Kinds kind) { }

	// RVA: 0x24BACA0 Offset: 0x24BADA1 VA: 0x24BACA0
	public void .ctor() { }
}

