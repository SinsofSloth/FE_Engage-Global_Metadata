// Namespace: App
public class MapSimpleBattle : SingletonClass<MapSimpleBattle> // TypeDefIndex: 12486
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	private static readonly string LeftSideObjName; // 0x8
	private static readonly string RightSideObjName; // 0x10
	private TResourceHandle<GameObject> m_PrefabHandle; // 0x20
	private bool m_IsValid; // 0x28
	private GameObject m_GameObject; // 0x30
	private CombatGaugeController m_GaugeControllerLeft; // 0x38
	private CombatGaugeController m_GaugeControllerRight; // 0x40

	// Methods

	// RVA: 0x271D320 Offset: 0x271D421 VA: 0x271D320
	public bool IsLoading() { }

	// RVA: 0x271D350 Offset: 0x271D451 VA: 0x271D350
	private void GetObject(BattleInfo info, out CombatGaugeController offense, out CombatGaugeController defense) { }

	// RVA: 0x271D4A0 Offset: 0x271D5A1 VA: 0x271D4A0
	public void SetSimpleBattle(BattleCalculator calc) { }

	// RVA: 0x271D6E0 Offset: 0x271D7E1 VA: 0x271D6E0
	public void UpdateValue(BattleInfo info) { }

	// RVA: 0x271D8A0 Offset: 0x271D9A1 VA: 0x271D8A0
	public void SkipGaugeAnime(BattleInfo info) { }

	// RVA: 0x271D990 Offset: 0x271DA91 VA: 0x271D990
	public bool IsMoving() { }

	// RVA: 0x271DA90 Offset: 0x271DB91 VA: 0x271DA90
	public bool IsPlayingAnim() { }

	// RVA: 0x271D630 Offset: 0x271D731 VA: 0x271D630
	public void Activate() { }

	// RVA: 0x271DB90 Offset: 0x271DC91 VA: 0x271DB90
	public void Deactivate() { }

	// RVA: 0x271DC40 Offset: 0x271DD41 VA: 0x271DC40
	public void Out() { }

	// RVA: 0x271DC90 Offset: 0x271DD91 VA: 0x271DC90 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x271DDF0 Offset: 0x271DEF1 VA: 0x271DDF0 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x271DEF0 Offset: 0x271DFF1 VA: 0x271DEF0
	private void CreateObjects() { }

	// RVA: 0x271DE00 Offset: 0x271DF01 VA: 0x271DE00
	private void DestroyObjects() { }

	// RVA: 0x271E140 Offset: 0x271E241 VA: 0x271E140
	public void .ctor() { }

	// RVA: 0x271E1C0 Offset: 0x271E2C1 VA: 0x271E1C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C9620 Offset: 0x2C9721 VA: 0x2C9620
	// RVA: 0x271E290 Offset: 0x271E391 VA: 0x271E290
	private void <OnCreate>b__18_0(GameObject _) { }
}

