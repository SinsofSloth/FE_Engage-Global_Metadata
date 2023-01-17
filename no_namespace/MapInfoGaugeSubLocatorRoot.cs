// Namespace: 
public enum MapInfoGaugeSubLocatorRoot.Parts // TypeDefIndex: 7626
{
	// Fields
	public int value__; // 0x0
	public const MapInfoGaugeSubLocatorRoot.Parts Weapon = 0;
	public const MapInfoGaugeSubLocatorRoot.Parts Break = 1;
	public const MapInfoGaugeSubLocatorRoot.Parts Rod = 2;
	public const MapInfoGaugeSubLocatorRoot.Parts Balloon = 3;
	public const MapInfoGaugeSubLocatorRoot.Parts FadeBalloon = 4;
	public const MapInfoGaugeSubLocatorRoot.Parts RelayExit = 5;
	public const MapInfoGaugeSubLocatorRoot.Parts SkillEffect = 6;
	public const MapInfoGaugeSubLocatorRoot.Parts FadeSkillEffect = 7;
	public const MapInfoGaugeSubLocatorRoot.Parts DropItem = 8;
	public const MapInfoGaugeSubLocatorRoot.Parts GodFace = 9;
	public const MapInfoGaugeSubLocatorRoot.Parts EngageCount = 10;
	public const MapInfoGaugeSubLocatorRoot.Parts ShineEngageCount = 11;
	public const MapInfoGaugeSubLocatorRoot.Parts CountMaxEffect = 12;
	public const MapInfoGaugeSubLocatorRoot.Parts HpGaugeBase = 13;
	public const MapInfoGaugeSubLocatorRoot.Parts HpGaugeFront = 14;
	public const MapInfoGaugeSubLocatorRoot.Parts HpGaugeDamage = 15;
	public const MapInfoGaugeSubLocatorRoot.Parts HpGaugeShineDamage = 16;
	public const MapInfoGaugeSubLocatorRoot.Parts HpGaugeFrame = 17;
	public const MapInfoGaugeSubLocatorRoot.Parts HpStock0 = 18;
	public const MapInfoGaugeSubLocatorRoot.Parts HpStock1 = 19;
	public const MapInfoGaugeSubLocatorRoot.Parts HpStock2 = 20;
	public const MapInfoGaugeSubLocatorRoot.Parts Num = 21;
}

// Namespace: 
public class MapInfoGaugeSubLocatorRoot : MonoBehaviour // TypeDefIndex: 7628
{
	// Fields
	private const int HpStockMax = 3;
	private GameObject[] m_OnMapStatuses; // 0x18
	private Image[] m_Images; // 0x20
	private Vector3 m_BaseBalloonPos; // 0x28
	private Color m_BaseColor; // 0x34
	private Vector3 m_UnitScreenPosLocalScale; // 0x44
	private Vector3 m_ScreenHalf; // 0x50
	private List<MapUIGauge.IconIndex> m_StateList; // 0x60
	private List<MapUIGauge.IconIndex> m_BalloonList; // 0x68
	private int m_HpBeforeBattle; // 0x70
	private int m_HpAfterBattle; // 0x74
	private bool m_IsBreakAfterBattle; // 0x78
	private bool m_IsSuppressForHpStock; // 0x79
	private bool m_IsComplete; // 0x7A
	[SpaceAttribute] // RVA: 0x27B100 Offset: 0x27B201 VA: 0x27B100
	[HeaderAttribute] // RVA: 0x27B100 Offset: 0x27B201 VA: 0x27B100
	[SerializeField] // RVA: 0x27B100 Offset: 0x27B201 VA: 0x27B100
	private Transform m_Weapon; // 0x80
	[SerializeField] // RVA: 0x27B160 Offset: 0x27B261 VA: 0x27B160
	private Transform m_Break; // 0x88
	[SerializeField] // RVA: 0x27B170 Offset: 0x27B271 VA: 0x27B170
	private Transform m_Rod; // 0x90
	[SerializeField] // RVA: 0x27B180 Offset: 0x27B281 VA: 0x27B180
	[SpaceAttribute] // RVA: 0x27B180 Offset: 0x27B281 VA: 0x27B180
	private Transform m_Balloon; // 0x98
	[SerializeField] // RVA: 0x27B1C0 Offset: 0x27B2C1 VA: 0x27B1C0
	private Transform m_FadeBalloon; // 0xA0
	[SerializeField] // RVA: 0x27B1D0 Offset: 0x27B2D1 VA: 0x27B1D0
	[SpaceAttribute] // RVA: 0x27B1D0 Offset: 0x27B2D1 VA: 0x27B1D0
	private Transform m_RelayExit; // 0xA8
	[SpaceAttribute] // RVA: 0x27B210 Offset: 0x27B311 VA: 0x27B210
	[SerializeField] // RVA: 0x27B210 Offset: 0x27B311 VA: 0x27B210
	private Transform m_SkillEffect; // 0xB0
	[SerializeField] // RVA: 0x27B250 Offset: 0x27B351 VA: 0x27B250
	private Transform m_FadeSkillEffect; // 0xB8
	[SerializeField] // RVA: 0x27B260 Offset: 0x27B361 VA: 0x27B260
	private Transform m_DropItem; // 0xC0
	[SerializeField] // RVA: 0x27B270 Offset: 0x27B371 VA: 0x27B270
	[SpaceAttribute] // RVA: 0x27B270 Offset: 0x27B371 VA: 0x27B270
	private Transform m_GodFace; // 0xC8
	[SerializeField] // RVA: 0x27B2B0 Offset: 0x27B3B1 VA: 0x27B2B0
	private Transform m_EngageCount; // 0xD0
	[SerializeField] // RVA: 0x27B2C0 Offset: 0x27B3C1 VA: 0x27B2C0
	private Transform m_ShineEngageCount; // 0xD8
	[SerializeField] // RVA: 0x27B2D0 Offset: 0x27B3D1 VA: 0x27B2D0
	private RectTransform m_EngageCountMaxEffect; // 0xE0
	[SerializeField] // RVA: 0x27B2E0 Offset: 0x27B3E1 VA: 0x27B2E0
	private Transform m_ChargeEffect; // 0xE8
	[SerializeField] // RVA: 0x27B2F0 Offset: 0x27B3F1 VA: 0x27B2F0
	private Transform m_RecoveryEffect; // 0xF0
	[SpaceAttribute] // RVA: 0x27B300 Offset: 0x27B401 VA: 0x27B300
	[SerializeField] // RVA: 0x27B300 Offset: 0x27B401 VA: 0x27B300
	private GameObject m_EngageCountCharge; // 0xF8
	[SerializeField] // RVA: 0x27B340 Offset: 0x27B441 VA: 0x27B340
	private GameObject m_EngageCountFull; // 0x100
	[SerializeField] // RVA: 0x27B350 Offset: 0x27B451 VA: 0x27B350
	private GameObject m_TurnRecovery; // 0x108
	[SerializeField] // RVA: 0x27B360 Offset: 0x27B461 VA: 0x27B360
	[SpaceAttribute] // RVA: 0x27B360 Offset: 0x27B461 VA: 0x27B360
	private Transform m_HpGaugeBase; // 0x110
	[SerializeField] // RVA: 0x27B3A0 Offset: 0x27B4A1 VA: 0x27B3A0
	private Transform m_HpGaugeFront; // 0x118
	[SerializeField] // RVA: 0x27B3B0 Offset: 0x27B4B1 VA: 0x27B3B0
	private Transform m_HpGaugeDamage; // 0x120
	[SerializeField] // RVA: 0x27B3C0 Offset: 0x27B4C1 VA: 0x27B3C0
	private Transform m_HpGaugeShineDamage; // 0x128
	[SerializeField] // RVA: 0x27B3D0 Offset: 0x27B4D1 VA: 0x27B3D0
	private Transform m_HpGaugeFrame; // 0x130
	[SerializeField] // RVA: 0x27B3E0 Offset: 0x27B4E1 VA: 0x27B3E0
	[SpaceAttribute] // RVA: 0x27B3E0 Offset: 0x27B4E1 VA: 0x27B3E0
	private Transform m_HpStock0; // 0x138
	[SerializeField] // RVA: 0x27B420 Offset: 0x27B521 VA: 0x27B420
	private Transform m_HpStock1; // 0x140
	[SerializeField] // RVA: 0x27B430 Offset: 0x27B531 VA: 0x27B430
	private Transform m_HpStock2; // 0x148
	[SerializeField] // RVA: 0x27B440 Offset: 0x27B541 VA: 0x27B440
	private Transform m_HpStockEffect; // 0x150
	[SerializeField] // RVA: 0x27B450 Offset: 0x27B551 VA: 0x27B450
	[SpaceAttribute] // RVA: 0x27B450 Offset: 0x27B551 VA: 0x27B450
	private GameObject m_RedStockBreakEffect; // 0x158
	[SerializeField] // RVA: 0x27B490 Offset: 0x27B591 VA: 0x27B490
	private GameObject m_RedStockCreateEffect; // 0x160
	[SerializeField] // RVA: 0x27B4A0 Offset: 0x27B5A1 VA: 0x27B4A0
	[SpaceAttribute] // RVA: 0x27B4A0 Offset: 0x27B5A1 VA: 0x27B4A0
	private GameObject m_BlueStockBreakEffect; // 0x168
	[SerializeField] // RVA: 0x27B4E0 Offset: 0x27B5E1 VA: 0x27B4E0
	private GameObject m_BlueStockCreateEffect; // 0x170
	[SerializeField] // RVA: 0x27B4F0 Offset: 0x27B5F1 VA: 0x27B4F0
	[SpaceAttribute] // RVA: 0x27B4F0 Offset: 0x27B5F1 VA: 0x27B4F0
	private Transform m_LeftTop; // 0x178
	[SerializeField] // RVA: 0x27B530 Offset: 0x27B631 VA: 0x27B530
	private Transform m_RightBottom; // 0x180
	private Vector3 m_RodBasePos; // 0x188
	private Vector3 m_RodLocalOffset; // 0x194
	private Vector2 m_OrigCountMaxScale; // 0x1A0
	private Vector3 m_EngageTurnRecoveryEffectOffset; // 0x1A8
	private Flipbook m_EngageTurnFlipbook; // 0x1B8
	private Flipbook m_HpStockFlipbook; // 0x1C0

	// Properties
	public bool IsSuppressHpStock { get; set; }
	public bool IsComplete { get; set; }

	// Methods

	// RVA: 0x2484130 Offset: 0x2484231 VA: 0x2484130
	private void Awake() { }

	// RVA: 0x2484230 Offset: 0x2484331 VA: 0x2484230
	private void GetGameObject() { }

	// RVA: 0x24848A0 Offset: 0x24849A1 VA: 0x24848A0
	private void GetImage() { }

	// RVA: 0x24820D0 Offset: 0x24821D1 VA: 0x24820D0
	public void SetIcon(Unit unit) { }

	// RVA: 0x2484F20 Offset: 0x2485021 VA: 0x2484F20
	private bool CanSetWholeIcon() { }

	// RVA: 0x2484FE0 Offset: 0x24850E1 VA: 0x2484FE0
	private void SetBaseColor(Unit unit) { }

	// RVA: 0x24850F0 Offset: 0x24851F1 VA: 0x24850F0
	private void SetWeaponIcon(Unit unit) { }

	// RVA: 0x2488450 Offset: 0x2488551 VA: 0x2488450
	private int GetWeaponIndex(Unit unit, UnitItem item) { }

	// RVA: 0x2485270 Offset: 0x2485371 VA: 0x2485270
	private void SetBreakIcon(Unit unit) { }

	// RVA: 0x2488480 Offset: 0x2488581 VA: 0x2488480
	private MapInfoGaugeSubLocatorRoot.BreakEffectKind IsBreak(Unit unit) { }

	// RVA: 0x2485430 Offset: 0x2485531 VA: 0x2485430
	private void SetRodIcon(Unit unit) { }

	// RVA: 0x248A7F0 Offset: 0x248A8F1 VA: 0x248A7F0
	private int GetRodIndex(Unit unit) { }

	// RVA: 0x2485670 Offset: 0x2485771 VA: 0x2485670
	private void SetBalloonIcon(Unit unit) { }

	// RVA: 0x2485B80 Offset: 0x2485C81 VA: 0x2485B80
	private void SetRelayExitIcon(Unit unit) { }

	// RVA: 0x248A8A0 Offset: 0x248A9A1 VA: 0x248A8A0
	private void MakeBalloonList(Unit unit) { }

	// RVA: 0x248B9A0 Offset: 0x248BAA1 VA: 0x248B9A0
	private void CheckEfficary(Unit player, Unit enemy) { }

	// RVA: 0x248BCF0 Offset: 0x248BDF1 VA: 0x248BCF0
	private Unit GetCursorTargetUnit() { }

	// RVA: 0x248C0C0 Offset: 0x248C1C1 VA: 0x248C0C0
	private Unit GetMindUnitOnLateUpdate() { }

	// RVA: 0x2485C00 Offset: 0x2485D01 VA: 0x2485C00
	private void SetStateIcon(Unit unit) { }

	// RVA: 0x248CA00 Offset: 0x248CB01 VA: 0x248CA00
	private void MakeUnitStateList(Unit unit) { }

	// RVA: 0x2485F60 Offset: 0x2486061 VA: 0x2485F60
	private void SetDropItemIcon(Unit unit) { }

	// RVA: 0x2485FD0 Offset: 0x24860D1 VA: 0x2485FD0
	private void SetEngageIcon(Unit unit) { }

	// RVA: 0x248CFF0 Offset: 0x248D0F1 VA: 0x248CFF0
	private bool IsSetEngageIcon(Unit unit) { }

	// RVA: 0x248D0D0 Offset: 0x248D1D1 VA: 0x248D0D0
	private bool IsDarknessEngage(Unit unit) { }

	// RVA: 0x24869C0 Offset: 0x2486AC1 VA: 0x24869C0
	private void SetCountMaxEffect(Unit unit) { }

	// RVA: 0x248D2B0 Offset: 0x248D3B1 VA: 0x248D2B0
	private bool IsSetCountMaxEffect(Unit unit) { }

	// RVA: 0x24865D0 Offset: 0x24866D1 VA: 0x24865D0
	private void SetGodFaceIcon(Unit unit) { }

	// RVA: 0x248D6A0 Offset: 0x248D7A1 VA: 0x248D6A0
	private bool IsSetGodFaceIcon(Unit unit) { }

	// RVA: 0x248D820 Offset: 0x248D921 VA: 0x248D820
	public void PlayEngageEffect(Unit unit, int count) { }

	// RVA: 0x248DA30 Offset: 0x248DB31 VA: 0x248DA30
	public void PlayEngageTurnRecoveryEffect() { }

	// RVA: 0x248DB40 Offset: 0x248DC41 VA: 0x248DB40
	public bool IsPlayingEngageTurnRecoveryEffect() { }

	// RVA: 0x248DBF0 Offset: 0x248DCF1 VA: 0x248DBF0
	public float GetEngageTurnRecoveryEffectRate() { }

	// RVA: 0x248DCA0 Offset: 0x248DDA1 VA: 0x248DCA0
	public void SetUnitScreenPosLocalScale(Vector3 posScale) { }

	// RVA: 0x248DCB0 Offset: 0x248DDB1 VA: 0x248DCB0
	public void SetScreenHalfSize(Vector3 screenHalf) { }

	// RVA: 0x248DCC0 Offset: 0x248DDC1 VA: 0x248DCC0
	public Vector3 GetEngageCountPos() { }

	// RVA: 0x248DD70 Offset: 0x248DE71 VA: 0x248DD70
	private Vector3 GetHpStockPos(Unit unit) { }

	// RVA: 0x248D1E0 Offset: 0x248D2E1 VA: 0x248D1E0
	private int GetEngageCountEmptyIndex(Unit unit) { }

	// RVA: 0x2486D70 Offset: 0x2486E71 VA: 0x2486D70
	private void SetHpGauge(Unit unit) { }

	// RVA: 0x24871B0 Offset: 0x24872B1 VA: 0x24871B0
	private void SetHpFrame(Unit unit) { }

	// RVA: 0x24873B0 Offset: 0x24874B1 VA: 0x24873B0
	private void SetHpDamage(Unit unit) { }

	// RVA: 0x24878C0 Offset: 0x24879C1 VA: 0x24878C0
	private void SetHpHeal(Unit unit) { }

	// RVA: 0x2487DD0 Offset: 0x2487ED1 VA: 0x2487DD0
	private void SetHpStock(Unit unit) { }

	// RVA: 0x248DDC0 Offset: 0x248DEC1 VA: 0x248DDC0
	public void PlayHpStockBreakEffect(Unit unit) { }

	// RVA: 0x248E0C0 Offset: 0x248E1C1 VA: 0x248E0C0
	public void PlayHpStockCreateEffect(Unit unit) { }

	// RVA: 0x248E3C0 Offset: 0x248E4C1 VA: 0x248E3C0
	public void SetHpStockAlpha(int stock, float alpha) { }

	// RVA: 0x248E460 Offset: 0x248E561 VA: 0x248E460
	public bool IsPlayingHpStockEffect() { }

	// RVA: 0x248E510 Offset: 0x248E611 VA: 0x248E510
	public float GetHpStockEffectRate() { }

	// RVA: 0x2488340 Offset: 0x2488441 VA: 0x2488340
	private void SetActive(MapInfoGaugeSubLocatorRoot.Parts index, bool enable) { }

	// RVA: 0x248E5C0 Offset: 0x248E6C1 VA: 0x248E5C0
	private bool GetConfig(bool enable) { }

	// RVA: 0x248E650 Offset: 0x248E751 VA: 0x248E650
	public Vector3 GetDisplayAreaLeftTop() { }

	// RVA: 0x248E6F0 Offset: 0x248E7F1 VA: 0x248E6F0
	public Vector3 GetDisplayAreaRightBottom() { }

	// RVA: 0x2481CA0 Offset: 0x2481DA1 VA: 0x2481CA0
	public void UpdateEffectPos(Unit unit) { }

	// RVA: 0x2484090 Offset: 0x2484191 VA: 0x2484090
	public void InitHpForecast() { }

	// RVA: 0x24840B0 Offset: 0x24841B1 VA: 0x24840B0
	public void SetHpForecast(int before, int after) { }

	// RVA: 0x24840D0 Offset: 0x24841D1 VA: 0x24840D0
	public void InitBreak() { }

	// RVA: 0x248E790 Offset: 0x248E891 VA: 0x248E790
	public void SetBreak(bool isBreak) { }

	// RVA: 0x248E7A0 Offset: 0x248E8A1 VA: 0x248E7A0
	public bool get_IsSuppressHpStock() { }

	// RVA: 0x248E7B0 Offset: 0x248E8B1 VA: 0x248E7B0
	public void set_IsSuppressHpStock(bool value) { }

	// RVA: 0x248E7C0 Offset: 0x248E8C1 VA: 0x248E7C0
	public bool get_IsComplete() { }

	// RVA: 0x248E7D0 Offset: 0x248E8D1 VA: 0x248E7D0
	public void set_IsComplete(bool value) { }

	// RVA: 0x248E7E0 Offset: 0x248E8E1 VA: 0x248E7E0
	public void .ctor() { }
}

