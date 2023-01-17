// Namespace: App
public abstract class FishingBattleRader : MonoBehaviour // TypeDefIndex: 10574
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x2911A0 Offset: 0x2912A1 VA: 0x2911A0
	private bool <IsEscape>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x2911B0 Offset: 0x2912B1 VA: 0x2911B0
	private bool <IsDefeat>k__BackingField; // 0x19
	private const string cEffectRootPath = "Effects/Field/Hub/Fishing/Prefabs/";
	private const string cEffectRaderBubble = "Eff_FishShadow_Bubble";
	private GameObject m_FishShadowObj; // 0x20
	private GameObject m_FishBubbleEffect; // 0x28
	private RectTransform m_FishShadowTrans; // 0x30
	private Animator m_FishAnime; // 0x38
	private bool m_IsCounterShadow; // 0x40
	private GameObject m_Area; // 0x48
	private GameObject m_HPGauge; // 0x50
	private GameObject m_DangerLine; // 0x58
	private float m_ShadowScale; // 0x60
	public GameObject m_HPGaugeHpMove; // 0x68
	public GameObject m_HPGaugeHpNow; // 0x70
	public Color m_DamageColor; // 0x78
	public Color m_HealColor; // 0x88
	private GameObject m_StickObj; // 0x98
	private GameObject m_ButtonObj; // 0xA0
	private RectTransform m_RepeatGauge; // 0xA8
	private FishingConfig_Battle m_Config; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x2911C0 Offset: 0x2912C1 VA: 0x2911C0
	private float <ShadowDistance>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x2911D0 Offset: 0x2912D1 VA: 0x2911D0
	private float <ShadowDir>k__BackingField; // 0xBC
	public InterpolatorFloat m_PositionInterp; // 0xC0
	private int m_ShakeCount; // 0xC8
	private float[] cShakeDiffArray; // 0xD0
	private float m_MaxHPWidth; // 0xD8
	private float m_NowHPWidth; // 0xDC
	private float m_MovingHPWidth; // 0xE0
	private float m_HPMoveWaitTimer; // 0xE4
	private bool m_IsForceCounter; // 0xE8
	private bool m_IsLethal; // 0xE9
	private float m_LethalTimer; // 0xEC
	private bool m_IsLethalButtonAppear; // 0xF0
	private bool m_IsFirstAttack; // 0xF1

	// Properties
	public bool IsEscape { get; set; }
	public bool IsDefeat { get; set; }
	public float ShadowDistance { get; set; }
	public float ShadowDir { get; set; }
	private bool IsShake { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BF480 Offset: 0x2BF581 VA: 0x2BF480
	// RVA: 0x2A24150 Offset: 0x2A24251 VA: 0x2A24150
	public bool get_IsEscape() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF490 Offset: 0x2BF591 VA: 0x2BF490
	// RVA: 0x2A24160 Offset: 0x2A24261 VA: 0x2A24160
	private void set_IsEscape(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF4A0 Offset: 0x2BF5A1 VA: 0x2BF4A0
	// RVA: 0x2A24170 Offset: 0x2A24271 VA: 0x2A24170
	public bool get_IsDefeat() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF4B0 Offset: 0x2BF5B1 VA: 0x2BF4B0
	// RVA: 0x2A24180 Offset: 0x2A24281 VA: 0x2A24180
	private void set_IsDefeat(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF4C0 Offset: 0x2BF5C1 VA: 0x2BF4C0
	// RVA: 0x2A24190 Offset: 0x2A24291 VA: 0x2A24190
	public float get_ShadowDistance() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF4D0 Offset: 0x2BF5D1 VA: 0x2BF4D0
	// RVA: 0x2A241A0 Offset: 0x2A242A1 VA: 0x2A241A0
	public void set_ShadowDistance(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF4E0 Offset: 0x2BF5E1 VA: 0x2BF4E0
	// RVA: 0x2A241B0 Offset: 0x2A242B1 VA: 0x2A241B0
	public float get_ShadowDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BF4F0 Offset: 0x2BF5F1 VA: 0x2BF4F0
	// RVA: 0x2A241C0 Offset: 0x2A242C1 VA: 0x2A241C0
	public void set_ShadowDir(float value) { }

	// RVA: 0x2A241D0 Offset: 0x2A242D1 VA: 0x2A241D0
	private bool get_IsShake() { }

	// RVA: 0x2A241E0 Offset: 0x2A242E1 VA: 0x2A241E0
	public void .ctor() { }

	// RVA: 0x2A242D0 Offset: 0x2A243D1 VA: 0x2A242D0
	public void Init(int sizeID, float shadowScale, FishingConfig_Battle config) { }

	// RVA: 0x2A249D0 Offset: 0x2A24AD1 VA: 0x2A249D0
	public void Finalize() { }

	// RVA: 0x2A24A40 Offset: 0x2A24B41 VA: 0x2A24A40
	public void ResetRadar() { }

	// RVA: 0x2A24F30 Offset: 0x2A25031 VA: 0x2A24F30
	public void Tick(FishingFish fish) { }

	// RVA: 0x2A24D00 Offset: 0x2A24E01 VA: 0x2A24D00
	public void SetActiveDangerLine(bool set) { }

	// RVA: 0x2A24FC0 Offset: 0x2A250C1 VA: 0x2A24FC0
	private void UpdateFishShadow(FishingFish fish) { }

	// RVA: 0x2A258E0 Offset: 0x2A259E1 VA: 0x2A258E0
	public void RecoveryLethal() { }

	// RVA: 0x2A259A0 Offset: 0x2A25AA1 VA: 0x2A259A0
	public void DamageShake() { }

	// RVA: 0x2A259B0 Offset: 0x2A25AB1 VA: 0x2A259B0
	public void DamageRed() { }

	// RVA: 0x2A25A10 Offset: 0x2A25B11 VA: 0x2A25A10
	public Vector2 GetCounterVec() { }

	// RVA: 0x2A25360 Offset: 0x2A25461 VA: 0x2A25360
	private void UpdateStickDir() { }

	// RVA: 0x2A24EB0 Offset: 0x2A24FB1 VA: 0x2A24EB0
	private void SetHPGaugeWidth(GameObject gaugeObj, float width) { }

	// RVA: 0x2A24DB0 Offset: 0x2A24EB1 VA: 0x2A24DB0
	private void SetHPGaugeColor(GameObject gaugeObj, Color setColor) { }

	// RVA: 0x2A25A80 Offset: 0x2A25B81 VA: 0x2A25A80
	public void FirstAttack(float hpRate) { }

	// RVA: 0x2A255F0 Offset: 0x2A256F1 VA: 0x2A255F0
	private void UpdateHP(float percent) { }

	// RVA: 0x2A255E0 Offset: 0x2A256E1 VA: 0x2A255E0
	private void UpdateLethalHP(float percent) { }

	// RVA: 0x2A25AB0 Offset: 0x2A25BB1 VA: 0x2A25AB0
	public void SetLethal(bool set) { }

	// RVA: 0x2A24990 Offset: 0x2A24A91 VA: 0x2A24990
	public void SetActiveArea(bool set) { }

	// RVA: 0x2A25BD0 Offset: 0x2A25CD1 VA: 0x2A25BD0
	public void SetStickObj(GameObject obj) { }

	// RVA: 0x2A24DA0 Offset: 0x2A24EA1 VA: 0x2A24DA0
	public void SetActiveStick(bool set) { }

	// RVA: 0x2A25BE0 Offset: 0x2A25CE1 VA: 0x2A25BE0
	public bool IsActiveStick() { }

	// RVA: 0x2A25BF0 Offset: 0x2A25CF1 VA: 0x2A25BF0
	public void SetButtonObj(GameObject obj) { }

	// RVA: 0x2A24CF0 Offset: 0x2A24DF1 VA: 0x2A24CF0
	public void SetActiveButton(bool set) { }

	// RVA: 0x2A25C00 Offset: 0x2A25D01 VA: 0x2A25C00
	public bool IsActiveButton() { }
}

