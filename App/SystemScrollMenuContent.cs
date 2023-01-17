// Namespace: App
public class SystemScrollMenuContent : BasicMenuContent // TypeDefIndex: 13438
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	[SerializeField] // RVA: 0x29C0D0 Offset: 0x29C1D1 VA: 0x29C0D0
	private Sprite m_NoneTypeIcon; // 0xE8
	[SerializeField] // RVA: 0x29C0E0 Offset: 0x29C1E1 VA: 0x29C0E0
	private Sprite m_GoldTypeIcon; // 0xF0
	[SerializeField] // RVA: 0x29C0F0 Offset: 0x29C1F1 VA: 0x29C0F0
	private Sprite m_ExpTypeIcon; // 0xF8

	// Methods

	// RVA: 0x2931370 Offset: 0x2931471 VA: 0x2931370
	public static void LoadPrefabAsync() { }

	// RVA: 0x2931410 Offset: 0x2931511 VA: 0x2931410
	public static bool IsLoadingPrefab() { }

	// RVA: 0x29314B0 Offset: 0x29315B1 VA: 0x29314B0
	public static void UnloadPrefab() { }

	// RVA: 0x2931550 Offset: 0x2931651 VA: 0x2931550
	public static SystemScrollMenuContent Create() { }

	// RVA: 0x2931690 Offset: 0x2931791 VA: 0x2931690 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x29316B0 Offset: 0x29317B1 VA: 0x29316B0 Slot: 21
	public override float CalcW() { }

	// RVA: 0x2931710 Offset: 0x2931811 VA: 0x2931710 Slot: 22
	public override float CalcH() { }

	// RVA: 0x2931780 Offset: 0x2931881 VA: 0x2931780 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x2931840 Offset: 0x2931941 VA: 0x2931840
	public Sprite GetEncountIcon(EncountUnitData.RareType rareType) { }

	// RVA: 0x2931870 Offset: 0x2931971 VA: 0x2931870
	public void .ctor() { }

	// RVA: 0x29318E0 Offset: 0x29319E1 VA: 0x29318E0
	private static void .cctor() { }
}

