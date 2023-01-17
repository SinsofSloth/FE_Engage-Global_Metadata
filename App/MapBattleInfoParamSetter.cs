// Namespace: App
public class MapBattleInfoParamSetter : MonoBehaviour // TypeDefIndex: 12475
{
	// Fields
	private readonly int ParamClamp; // 0x18
	public GameObject m_InfoRoot; // 0x20
	[HeaderAttribute] // RVA: 0x299FF0 Offset: 0x29A0F1 VA: 0x299FF0
	public GameObject m_CharaNameRoot; // 0x28
	public TextMeshProUGUI m_CharaName; // 0x30
	public GameObject m_GodNameRoot; // 0x38
	public TextMeshProUGUI m_GodName; // 0x40
	[HeaderAttribute] // RVA: 0x29A030 Offset: 0x29A131 VA: 0x29A030
	public Image m_NameOnlyCharaNameRoot; // 0x48
	public TextMeshProUGUI m_NameOnlyCharaName; // 0x50
	public GameObject m_NameOnlyGodNameRoot; // 0x58
	public TextMeshProUGUI m_NameOnlyGodName; // 0x60
	[HeaderAttribute] // RVA: 0x29A070 Offset: 0x29A171 VA: 0x29A070
	public int m_MaxHpGaugeWidth; // 0x68
	public int m_MinHpGaugeWidth; // 0x6C
	public int m_HpGaugeMax; // 0x70
	public GameObject m_HpRoot; // 0x78
	public GameObject m_HpGaugeRoot; // 0x80
	public TextMeshProUGUI m_NowHp; // 0x88
	public GameObject m_AfterHpRoot; // 0x90
	public TextMeshProUGUI m_AfterHp; // 0x98
	public GameObject m_AfterHpHealRoot; // 0xA0
	public TextMeshProUGUI m_AfterHpHeal; // 0xA8
	public GameObject m_HpGaugeAfter; // 0xB0
	public GameObject m_HpGaugeAdd; // 0xB8
	public Material m_DamageMaterial; // 0xC0
	public Material m_HealMaterial; // 0xC8
	public Material m_EngageMaterial; // 0xD0
	public GameObject m_HpStockRoot; // 0xD8
	public Image[] m_HpStock; // 0xE0
	public Sprite[] m_HpStockSprites; // 0xE8
	public GameObject m_HpStockAdd; // 0xF0
	[SpaceAttribute] // RVA: 0x29A0B0 Offset: 0x29A1B1 VA: 0x29A0B0
	public float m_DamageSpace; // 0xF8
	[HeaderAttribute] // RVA: 0x29A0C0 Offset: 0x29A1C1 VA: 0x29A0C0
	public GameObject m_StatusRoot; // 0x100
	[SpaceAttribute] // RVA: 0x29A100 Offset: 0x29A201 VA: 0x29A100
	public HelpItemFixedText m_BtlAtkHelp; // 0x108
	public TextMeshProUGUI m_BtlAtkTitle; // 0x110
	public TextMeshProUGUI m_BtlAtk; // 0x118
	public TextMeshProUGUI m_BtlHit; // 0x120
	public TextMeshProUGUI m_BtlCrit; // 0x128
	[SpaceAttribute] // RVA: 0x29A110 Offset: 0x29A211 VA: 0x29A110
	public TextMeshProUGUI m_ChainBtlAtk; // 0x130
	public GameObject m_ChainBtlHitRoot; // 0x138
	public TextMeshProUGUI m_ChainBtlHit; // 0x140
	public GameObject m_ChainBtlCritRoot; // 0x148
	public TextMeshProUGUI m_ChainBtlCrit; // 0x150
	[HeaderAttribute] // RVA: 0x29A120 Offset: 0x29A221 VA: 0x29A120
	public GameObject m_WeaponRoot; // 0x158
	[SpaceAttribute] // RVA: 0x29A160 Offset: 0x29A261 VA: 0x29A160
	public GameObject m_WeaponIconRoot; // 0x160
	public Image m_WeaponIcon; // 0x168
	public Image m_WeaponArrow; // 0x170
	public TextMeshProUGUI m_WeaponName; // 0x178
	public GameObject m_WeaponNothing; // 0x180
	public TextMeshProUGUI m_WeaponEndurance; // 0x188
	public GameObject m_WeaponChangeL; // 0x190
	public GameObject m_WeaponChangeR; // 0x198
	[HeaderAttribute] // RVA: 0x29A170 Offset: 0x29A271 VA: 0x29A170
	public GameObject m_ItemListRoot; // 0x1A0
	[HeaderAttribute] // RVA: 0x29A1B0 Offset: 0x29A2B1 VA: 0x29A1B0
	public GameObject m_SpaceRoot; // 0x1A8
	[HeaderAttribute] // RVA: 0x29A1F0 Offset: 0x29A2F1 VA: 0x29A1F0
	public List<ForceTextureSetter> m_forceTexture; // 0x1B0
	[CompilerGeneratedAttribute] // RVA: 0x29A230 Offset: 0x29A331 VA: 0x29A230
	private BattleSide.Type <SideType>k__BackingField; // 0x1B8
	[CompilerGeneratedAttribute] // RVA: 0x29A240 Offset: 0x29A341 VA: 0x29A240
	private BattleInfo <BattleInfo>k__BackingField; // 0x1C0
	[CompilerGeneratedAttribute] // RVA: 0x29A250 Offset: 0x29A351 VA: 0x29A250
	private BattleSceneList <BattleSceneList>k__BackingField; // 0x1C8
	[CompilerGeneratedAttribute] // RVA: 0x29A260 Offset: 0x29A361 VA: 0x29A260
	private BattleInfoSide <Side>k__BackingField; // 0x1D0
	[CompilerGeneratedAttribute] // RVA: 0x29A270 Offset: 0x29A371 VA: 0x29A270
	private BattleInfoSide <ReverseSide>k__BackingField; // 0x1D8

	// Properties
	private BattleSide.Type SideType { get; set; }
	private BattleInfo BattleInfo { get; set; }
	private BattleSceneList BattleSceneList { get; set; }
	private BattleInfoSide Side { get; set; }
	private BattleInfoSide ReverseSide { get; set; }
	private Unit Unit { get; }
	private UnitItem UnitItem { get; }
	private int MaxHp { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C93F0 Offset: 0x2C94F1 VA: 0x2C93F0
	// RVA: 0x231BEC0 Offset: 0x231BFC1 VA: 0x231BEC0
	private BattleSide.Type get_SideType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9400 Offset: 0x2C9501 VA: 0x2C9400
	// RVA: 0x231BED0 Offset: 0x231BFD1 VA: 0x231BED0
	private void set_SideType(BattleSide.Type value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9410 Offset: 0x2C9511 VA: 0x2C9410
	// RVA: 0x231BEE0 Offset: 0x231BFE1 VA: 0x231BEE0
	private BattleInfo get_BattleInfo() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9420 Offset: 0x2C9521 VA: 0x2C9420
	// RVA: 0x231BEF0 Offset: 0x231BFF1 VA: 0x231BEF0
	private void set_BattleInfo(BattleInfo value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9430 Offset: 0x2C9531 VA: 0x2C9430
	// RVA: 0x231BF00 Offset: 0x231C001 VA: 0x231BF00
	private BattleSceneList get_BattleSceneList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9440 Offset: 0x2C9541 VA: 0x2C9440
	// RVA: 0x231BF10 Offset: 0x231C011 VA: 0x231BF10
	private void set_BattleSceneList(BattleSceneList value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9450 Offset: 0x2C9551 VA: 0x2C9450
	// RVA: 0x231BF20 Offset: 0x231C021 VA: 0x231BF20
	private BattleInfoSide get_Side() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9460 Offset: 0x2C9561 VA: 0x2C9460
	// RVA: 0x231BF30 Offset: 0x231C031 VA: 0x231BF30
	private void set_Side(BattleInfoSide value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9470 Offset: 0x2C9571 VA: 0x2C9470
	// RVA: 0x231BF40 Offset: 0x231C041 VA: 0x231BF40
	private BattleInfoSide get_ReverseSide() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9480 Offset: 0x2C9581 VA: 0x2C9480
	// RVA: 0x231BF50 Offset: 0x231C051 VA: 0x231BF50
	private void set_ReverseSide(BattleInfoSide value) { }

	// RVA: 0x231BF60 Offset: 0x231C061 VA: 0x231BF60
	private Unit get_Unit() { }

	// RVA: 0x231BF80 Offset: 0x231C081 VA: 0x231BF80
	private UnitItem get_UnitItem() { }

	// RVA: 0x231BFA0 Offset: 0x231C0A1 VA: 0x231BFA0
	private int get_MaxHp() { }

	// RVA: 0x231C140 Offset: 0x231C241 VA: 0x231C140
	public void SetWeaponChangeVisible(bool isVisible) { }

	// RVA: 0x231C1D0 Offset: 0x231C2D1 VA: 0x231C1D0
	public void SetBattleInfo(BattleSide.Type sideType, bool bShowWdw, BattleInfo info, BattleSceneList sceneList) { }

	// RVA: 0x231E2B0 Offset: 0x231E3B1 VA: 0x231E2B0
	private void SetBattleInfoForBattle() { }

	// RVA: 0x231C770 Offset: 0x231C871 VA: 0x231C770
	private void SetBattleInfoForTrade() { }

	// RVA: 0x231DC70 Offset: 0x231DD71 VA: 0x231DC70
	private void SetBattleInfoForDestroy() { }

	// RVA: 0x231DEC0 Offset: 0x231DFC1 VA: 0x231DEC0
	private void SetBattleInfoForNoParam(bool isWeapon, bool isGodName) { }

	// RVA: 0x2321D20 Offset: 0x2321E21 VA: 0x2321D20
	private float GetHpGaugeMaxWidth(int maxHp) { }

	// RVA: 0x2321D60 Offset: 0x2321E61 VA: 0x2321D60
	private void TryUpdateDamageGauge(GameObject gaugeObj, int value, int max) { }

	// RVA: 0x2321F10 Offset: 0x2322011 VA: 0x2321F10
	private void TrySetChildImageMaterial(GameObject gameObject, Material mat) { }

	// RVA: 0x2322050 Offset: 0x2322151 VA: 0x2322050
	private void SetUnitName(string unitName) { }

	// RVA: 0x231F7A0 Offset: 0x231F8A1 VA: 0x231F7A0
	private void SetUnitName(Unit unit, bool bWeapon, bool bGod = True) { }

	// RVA: 0x2321910 Offset: 0x2321A11 VA: 0x2321910
	private void ShowDestroyName() { }

	// RVA: 0x2322170 Offset: 0x2322271 VA: 0x2322170
	private void ShowWeapon() { }

	// RVA: 0x2322CE0 Offset: 0x2322DE1 VA: 0x2322CE0
	private void HideWeapon() { }

	// RVA: 0x231FA20 Offset: 0x231FB21 VA: 0x231FA20
	private void ShowHp() { }

	// RVA: 0x2321B60 Offset: 0x2321C61 VA: 0x2321B60
	private void ShowDestroyHp() { }

	// RVA: 0x231FD60 Offset: 0x231FE61 VA: 0x231FD60
	private void HideHp() { }

	// RVA: 0x2322E40 Offset: 0x2322F41 VA: 0x2322E40
	private void SetAfterHpGauge(int hp) { }

	// RVA: 0x2322F10 Offset: 0x2323011 VA: 0x2322F10
	private void SetGaugeSide(GameObject gauge) { }

	// RVA: 0x231FDE0 Offset: 0x231FEE1 VA: 0x231FDE0
	private void SetInitParams(bool bShow) { }

	// RVA: 0x23213C0 Offset: 0x23214C1 VA: 0x23213C0
	private void SetAtkParam(BattleSide.Type sideType, BattleInfo info, BattleSceneList sceneList) { }

	// RVA: 0x2321610 Offset: 0x2321711 VA: 0x2321610
	private void SetChainAtkParam() { }

	// RVA: 0x231F630 Offset: 0x231F731 VA: 0x231F630
	private bool IsShowWeapon() { }

	// RVA: 0x231F960 Offset: 0x231FA61 VA: 0x231F960
	private bool IsShowHP() { }

	// RVA: 0x231E1F0 Offset: 0x231E2F1 VA: 0x231E1F0
	private bool IsFriendCommandSkill() { }

	// RVA: 0x231C740 Offset: 0x231C841 VA: 0x231C740
	private Force.Type GetForceType() { }

	// RVA: 0x2320430 Offset: 0x2320531 VA: 0x2320430
	private void ShowDisorderIcon(Unit unit) { }

	// RVA: 0x23207D0 Offset: 0x23208D1 VA: 0x23207D0
	private void ShowAddHpStock() { }

	// RVA: 0x2322FF0 Offset: 0x23230F1 VA: 0x2322FF0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9490 Offset: 0x2C9591 VA: 0x2C9490
	// RVA: 0x2323020 Offset: 0x2323121 VA: 0x2323020
	private void <SetBattleInfoForBattle>b__81_0(Unit target, int _, int __) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C94A0 Offset: 0x2C95A1 VA: 0x2C94A0
	// RVA: 0x2321730 Offset: 0x2321831 VA: 0x2321730
	internal static void <SetBattleInfoForTrade>g__SetObjectColor|82_0(GameObject parent, string name, ref MapBattleInfoParamSetter.<>c__DisplayClass82_0 ) { }
}

