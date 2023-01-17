// Namespace: App
public class MapSequenceTargetSelect : SingletonProcInst<MapSequenceTargetSelect> // TypeDefIndex: 12453
{
	// Fields
	private MapTarget.Data m_TargetData; // 0x78
	private int m_ItemIndex; // 0x80
	private BattleInfo m_BattleInfo; // 0x88
	private BattleCalculator m_BattleCalc; // 0x90
	private GameObject m_EngageLinkInfo; // 0x98
	private SkillArray m_MaskSkill; // 0xA0

	// Properties
	protected override string GlobalAssetPath { get; }

	// Methods

	// RVA: 0x270C0B0 Offset: 0x270C1B1 VA: 0x270C0B0 Slot: 19
	protected override string get_GlobalAssetPath() { }

	// RVA: 0x270C100 Offset: 0x270C201 VA: 0x270C100
	private void .ctor() { }

	// RVA: 0x270C330 Offset: 0x270C431 VA: 0x270C330 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x270C4E0 Offset: 0x270C5E1 VA: 0x270C4E0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x270C630 Offset: 0x270C731 VA: 0x270C630
	private void WaitForLoad() { }

	// RVA: 0x270C750 Offset: 0x270C851 VA: 0x270C750
	private bool IsCursorSelectedCommand() { }

	// RVA: 0x270CA50 Offset: 0x270CB51 VA: 0x270CA50
	private void Init() { }

	// RVA: 0x270E380 Offset: 0x270E481 VA: 0x270E380
	private void SyncHpGaugeFlash(GameObject gameObject) { }

	// RVA: 0x270DCA0 Offset: 0x270DDA1 VA: 0x270DCA0
	private void SetMapCursorPositon() { }

	// RVA: 0x270DDE0 Offset: 0x270DEE1 VA: 0x270DDE0
	private void SetHpForecast() { }

	// RVA: 0x270E600 Offset: 0x270E701 VA: 0x270E600
	private bool TryChangeEngage() { }

	// RVA: 0x270EBC0 Offset: 0x270ECC1 VA: 0x270EBC0
	private void Tick() { }

	// RVA: 0x2710080 Offset: 0x2710181 VA: 0x2710080
	private bool TryChangeWeapon() { }

	// RVA: 0x2711D30 Offset: 0x2711E31 VA: 0x2711D30
	private void CharaOnlyOn(Unit targetUnit, UnitItem targetItem) { }

	// RVA: 0x2712000 Offset: 0x2712101 VA: 0x2712000
	private void WindowOut() { }

	// RVA: 0x27120E0 Offset: 0x27121E1 VA: 0x27120E0
	private void PostWindowOut() { }

	// RVA: 0x27121D0 Offset: 0x27122D1 VA: 0x27121D0
	private void SetMapMind() { }

	// RVA: 0x27123B0 Offset: 0x27124B1 VA: 0x27123B0
	private void SetMapMind(MapMind.Type mind, int itemIndex, int targetIndex) { }

	// RVA: 0x2712530 Offset: 0x2712631 VA: 0x2712530
	private void SetMapMind(int targetX, int targetZ) { }

	// RVA: 0x270F720 Offset: 0x270F821 VA: 0x270F720
	private void Decide() { }

	// RVA: 0x2713C10 Offset: 0x2713D11 VA: 0x2713C10
	private void SetItemSelectedForDecide() { }

	// RVA: 0x2713D10 Offset: 0x2713E11 VA: 0x2713D10
	private void SetMapCursorDisplayForDecide() { }

	// RVA: 0x2713E30 Offset: 0x2713F31 VA: 0x2713E30
	private void SetCircleAnimeForDecide() { }

	// RVA: 0x2713F90 Offset: 0x2714091 VA: 0x2713F90
	private void ItemEquip(Unit unit, UnitItem unitItem) { }

	// RVA: 0x2712EC0 Offset: 0x2712FC1 VA: 0x2712EC0
	private void DecideNormal() { }

	// RVA: 0x27126D0 Offset: 0x27127D1 VA: 0x27126D0
	private void DecideDesignate() { }

	// RVA: 0x27140C0 Offset: 0x27141C1 VA: 0x27140C0
	private MapSequenceHuman.Label GetBackToItemSelectMenu(MapMind.Type mindType) { }

	// RVA: 0x270F9F0 Offset: 0x270FAF1 VA: 0x270F9F0
	private void Cancel() { }

	// RVA: 0x2714110 Offset: 0x2714211 VA: 0x2714110
	private void SetItemSelectedForCancel() { }

	// RVA: 0x2714210 Offset: 0x2714311 VA: 0x2714210
	private void SetMapCursorPosForCancel() { }

	// RVA: 0x2714430 Offset: 0x2714531 VA: 0x2714430
	private void SetMapCursorDisplayForCancel() { }

	// RVA: 0x2714580 Offset: 0x2714681 VA: 0x2714580
	private void SetCircleAnimeForCancel() { }

	// RVA: 0x27146D0 Offset: 0x27147D1 VA: 0x27146D0
	private void SetMapTerrainInfoForCancel() { }

	// RVA: 0x2715970 Offset: 0x2715A71 VA: 0x2715970
	private void TryBackUnitCommand() { }

	// RVA: 0x2714E90 Offset: 0x2714F91 VA: 0x2714E90
	private void CancelNormal() { }

	// RVA: 0x2714900 Offset: 0x2714A01 VA: 0x2714900
	private void CancelDesignate() { }

	// RVA: 0x270DAC0 Offset: 0x270DBC1 VA: 0x270DAC0
	private bool CanSelectTarget() { }

	// RVA: 0x2715C10 Offset: 0x2715D11 VA: 0x2715C10
	private bool IsAutoEquip() { }

	// RVA: 0x270D7B0 Offset: 0x270D8B1 VA: 0x270D7B0
	private void SetupInitialTarget() { }

	// RVA: 0x2715CE0 Offset: 0x2715DE1 VA: 0x2715CE0
	private bool TrySetTarget(MapTarget.Data data, int itemIndex) { }

	// RVA: 0x270E7E0 Offset: 0x270E8E1 VA: 0x270E7E0
	private void UpdateInfo(Unit target, int itemIndex) { }

	// RVA: 0x2714030 Offset: 0x2714131 VA: 0x2714030
	private void SetItemIndex(int itemIndex) { }

	// RVA: 0x270FC20 Offset: 0x270FD21 VA: 0x270FC20
	private void ChangeToPrevTarget() { }

	// RVA: 0x270FE50 Offset: 0x270FF51 VA: 0x270FE50
	private void ChangeToNextTarget() { }

	// RVA: 0x2715E00 Offset: 0x2715F01 VA: 0x2715E00
	private bool IsItemChangeEnable(int nowIndex, int nextIndex) { }

	// RVA: 0x2715FB0 Offset: 0x27160B1 VA: 0x2715FB0
	private bool CheckItemChange() { }

	// RVA: 0x27105A0 Offset: 0x27106A1 VA: 0x27105A0
	private void ChangeToPrevItem() { }

	// RVA: 0x2710760 Offset: 0x2710861 VA: 0x2710760
	private void ChangeToNextItem() { }

	// RVA: 0x270DF60 Offset: 0x270E061 VA: 0x270DF60
	private void UpdateMapPanelActive() { }

	// RVA: 0x270DA90 Offset: 0x270DB91 VA: 0x270DA90
	private void UpdateSelect() { }

	// RVA: 0x2710920 Offset: 0x2710A21 VA: 0x2710920
	private void UpdateInfo() { }

	// RVA: 0x2716100 Offset: 0x2716201 VA: 0x2716100
	private void UpdateActor() { }

	// RVA: 0x2711F20 Offset: 0x2712021 VA: 0x2711F20
	private MapSequenceTargetSelect.InfoType GetInfoType() { }

	// RVA: 0x270C800 Offset: 0x270C901 VA: 0x270C800
	private bool IsFireCannon() { }

	// RVA: 0x270E2B0 Offset: 0x270E3B1 VA: 0x270E2B0
	private bool IsBattle() { }

	// RVA: 0x270DA00 Offset: 0x270DB01 VA: 0x270DA00
	public UnitItem GetSelectItem() { }

	// RVA: 0x2715B00 Offset: 0x2715C01 VA: 0x2715B00
	private bool IsWeaponSelect() { }

	// RVA: 0x2716250 Offset: 0x2716351 VA: 0x2716250
	public BattleInfo GetBattleInfo() { }

	// RVA: 0x270C2B0 Offset: 0x270C3B1 VA: 0x270C2B0
	public Unit GetUnit() { }

	// RVA: 0x270E5C0 Offset: 0x270E6C1 VA: 0x270E5C0
	public Unit GetTargetUnit() { }

	// RVA: 0x2712360 Offset: 0x2712461 VA: 0x2712360
	public int GetTargetUnitIndex() { }

	// RVA: 0x2716210 Offset: 0x2716311 VA: 0x2716210
	public int GetTargetX() { }

	// RVA: 0x2716230 Offset: 0x2716331 VA: 0x2716230
	public int GetTargetZ() { }

	// RVA: 0x2716260 Offset: 0x2716361 VA: 0x2716260
	public SkillArray GetMaskSkill() { }

	// RVA: 0x2716270 Offset: 0x2716371 VA: 0x2716270
	public static void CreateBind(ProcInst super) { }
}

