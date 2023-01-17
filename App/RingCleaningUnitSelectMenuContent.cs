// Namespace: App
public class RingCleaningUnitSelectMenuContent : BasicMenuContent // TypeDefIndex: 11748
{
	// Fields
	private const string PrefabPath = "UI/Hub/GodRoom/Prefabs/RingCleaningUnitSelectRoot";
	[SerializeField] // RVA: 0x298E90 Offset: 0x298F91 VA: 0x298E90
	[HeaderAttribute] // RVA: 0x298E90 Offset: 0x298F91 VA: 0x298E90
	private MenuBondSetter m_BondSetter; // 0xE8
	[SerializeField] // RVA: 0x298EE0 Offset: 0x298FE1 VA: 0x298EE0
	[HeaderAttribute] // RVA: 0x298EE0 Offset: 0x298FE1 VA: 0x298EE0
	private TextMeshProUGUI m_HelpMessage; // 0xF0
	[SerializeField] // RVA: 0x298F30 Offset: 0x299031 VA: 0x298F30
	[HeaderAttribute] // RVA: 0x298F30 Offset: 0x299031 VA: 0x298F30
	private GodRoomGodInfoSetter m_GodInfo; // 0xF8
	public static readonly int ListGodNum; // 0x0

	// Methods

	// RVA: 0x2683160 Offset: 0x2683261 VA: 0x2683160 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x2683220 Offset: 0x2683321 VA: 0x2683220 Slot: 30
	protected override void Awake() { }

	// RVA: 0x267B710 Offset: 0x267B811 VA: 0x267B710
	public static void LoadPrefabAsync() { }

	// RVA: 0x267B8C0 Offset: 0x267B9C1 VA: 0x267B8C0
	public static bool IsLoadingPrefab() { }

	// RVA: 0x267DD30 Offset: 0x267DE31 VA: 0x267DD30
	public static void UnloadPrefab() { }

	// RVA: 0x2682160 Offset: 0x2682261 VA: 0x2682160
	public static RingCleaningUnitSelectMenuContent Create() { }

	// RVA: 0x26832F0 Offset: 0x26833F1 VA: 0x26832F0
	public static void Destroy(RingCleaningUnitSelectMenuContent content) { }

	// RVA: 0x2683370 Offset: 0x2683471 VA: 0x2683370 Slot: 21
	public override float CalcW() { }

	// RVA: 0x26833E0 Offset: 0x26834E1 VA: 0x26833E0 Slot: 22
	public override float CalcH() { }

	// RVA: 0x26825B0 Offset: 0x26826B1 VA: 0x26825B0
	public void UpdateGodInfo(Unit unit) { }

	// RVA: 0x2683450 Offset: 0x2683551 VA: 0x2683450
	public void .ctor() { }

	// RVA: 0x26834C0 Offset: 0x26835C1 VA: 0x26834C0
	private static void .cctor() { }
}

