// Namespace: App
public class MapSequenceBattleAction : SingletonProcInst<MapSequenceBattleAction> // TypeDefIndex: 12396
{
	// Fields
	private BattleCalculator m_Calculator; // 0x78
	private BattleCalculator m_SimCalculator; // 0x80
	private UnitSignal m_Signal; // 0x88
	private int m_SceneIndex; // 0x90
	private int m_BattleCount; // 0x94
	private int m_AttackCount; // 0x98
	private float m_InfoWait; // 0x9C
	private BattleSide.Type m_AttackSide; // 0xA0
	private const int WaitFrame = 4;

	// Properties
	protected override bool CanWaitSkip { get; }
	private int BattleCount { get; }
	public int SceneIndex { get; }
	private BattleSceneList SceneList { get; }
	private BattleScene CurrentScene { get; }

	// Methods

	// RVA: 0x1D81F80 Offset: 0x1D82081 VA: 0x1D81F80 Slot: 4
	protected override bool get_CanWaitSkip() { }

	// RVA: 0x1D81F90 Offset: 0x1D82091 VA: 0x1D81F90
	private void .ctor(BattleCalculator calculator, BattleCalculator simCalculator, int battleCount) { }

	// RVA: 0x1D82060 Offset: 0x1D82161 VA: 0x1D82060 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x1D821C0 Offset: 0x1D822C1 VA: 0x1D821C0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x1D82270 Offset: 0x1D82371 VA: 0x1D82270
	private int get_BattleCount() { }

	// RVA: 0x1D82280 Offset: 0x1D82381 VA: 0x1D82280
	public int get_SceneIndex() { }

	// RVA: 0x1D82290 Offset: 0x1D82391 VA: 0x1D82290
	private BattleSceneList get_SceneList() { }

	// RVA: 0x1D822A0 Offset: 0x1D823A1 VA: 0x1D822A0
	private BattleScene get_CurrentScene() { }

	// RVA: 0x1D82310 Offset: 0x1D82411 VA: 0x1D82310
	private void NextScene() { }

	// RVA: 0x1D82320 Offset: 0x1D82421 VA: 0x1D82320
	private bool IsShowInfo() { }

	// RVA: 0x1D82360 Offset: 0x1D82461 VA: 0x1D82360
	private void ShowInfo() { }

	// RVA: 0x1D82400 Offset: 0x1D82501 VA: 0x1D82400
	private void OutInfo() { }

	// RVA: 0x1D824A0 Offset: 0x1D825A1 VA: 0x1D824A0
	private void HideInfo() { }

	// RVA: 0x1D82540 Offset: 0x1D82641 VA: 0x1D82540
	private void WaitInfo() { }

	// RVA: 0x1D82350 Offset: 0x1D82451 VA: 0x1D82350
	private bool IsMultiBattle() { }

	// RVA: 0x1D826D0 Offset: 0x1D827D1 VA: 0x1D826D0
	private bool IsCannonBattle() { }

	// RVA: 0x1D826E0 Offset: 0x1D827E1 VA: 0x1D826E0
	private bool IsFullBullet() { }

	// RVA: 0x1D826F0 Offset: 0x1D827F1 VA: 0x1D826F0
	private bool IsRodBattle() { }

	// RVA: 0x1D82700 Offset: 0x1D82801 VA: 0x1D82700
	private bool IsTalk() { }

	// RVA: 0x1D82750 Offset: 0x1D82851 VA: 0x1D82750
	private void BattleTalk() { }

	// RVA: 0x1D827B0 Offset: 0x1D828B1 VA: 0x1D827B0
	private void PlayAction(BattleInfoSide current, UnitSequence.Action action) { }

	// RVA: 0x1D82870 Offset: 0x1D82971 VA: 0x1D82870
	private void PlayAnimation(BattleInfoSide current, UnitAnim.Types type) { }

	// RVA: 0x1D82920 Offset: 0x1D82A21 VA: 0x1D82920
	private void PlayRotation(BattleInfoSide current, BattleInfoSide target) { }

	// RVA: 0x1D82A80 Offset: 0x1D82B81 VA: 0x1D82A80
	private void PlayRotationAndAction(BattleInfoSide current, BattleInfoSide target, UnitSequence.Action action) { }

	// RVA: 0x1D82B40 Offset: 0x1D82C41 VA: 0x1D82B40
	private void PlayCannonRotation(BattleInfoSide current, BattleInfoSide target) { }

	// RVA: 0x1D82CD0 Offset: 0x1D82DD1 VA: 0x1D82CD0
	private void PlayCannonShoot(BattleInfoSide current) { }

	// RVA: 0x1D82DD0 Offset: 0x1D82ED1 VA: 0x1D82DD0
	private void StopCannonShoot(BattleInfoSide current) { }

	// RVA: 0x1D82EB0 Offset: 0x1D82FB1 VA: 0x1D82EB0
	private void PlayEngageAttackSkill() { }

	// RVA: 0x1D830A0 Offset: 0x1D831A1 VA: 0x1D830A0
	private void PlayEngageShootSkill(BattleInfoSide current) { }

	// RVA: 0x1D832A0 Offset: 0x1D833A1 VA: 0x1D832A0
	private BattleInfoSide GetSide(BattleSide.Type type) { }

	// RVA: 0x1D83010 Offset: 0x1D83111 VA: 0x1D83010
	private Unit GetUnit(BattleSide.Type type) { }

	// RVA: 0x1D83330 Offset: 0x1D83431 VA: 0x1D83330
	private void UpdateScene(int index) { }

	// RVA: 0x1D833F0 Offset: 0x1D834F1 VA: 0x1D833F0
	private void SkipScene() { }

	// RVA: 0x1D834C0 Offset: 0x1D835C1 VA: 0x1D834C0
	private UnitAnim.Types GetAttackMotion(UnitItem unitItem) { }

	// RVA: 0x1D83560 Offset: 0x1D83661 VA: 0x1D83560
	private bool IsEngageAttackAction(BattleScene scene) { }

	// RVA: 0x1D83600 Offset: 0x1D83701 VA: 0x1D83600
	private UnitAnim.Types GetAttackMotion(BattleScene scene) { }

	// RVA: 0x1D83860 Offset: 0x1D83961 VA: 0x1D83860
	private void WaitSkipSignal(UnitSignal signal) { }

	// RVA: 0x1D83870 Offset: 0x1D83971 VA: 0x1D83870
	private void ShootSignal(UnitSignal signal) { }

	// RVA: 0x1D82110 Offset: 0x1D82211 VA: 0x1D82110
	private void ClearSignal() { }

	// RVA: 0x1D838B0 Offset: 0x1D839B1 VA: 0x1D838B0
	private void TryFocusAttack() { }

	// RVA: 0x1D839C0 Offset: 0x1D83AC1 VA: 0x1D839C0
	private void TryFocusTarget() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C88B0 Offset: 0x2C89B1 VA: 0x2C88B0
	// RVA: 0x1D83C10 Offset: 0x1D83D11 VA: 0x1D83C10
	private IEnumerator Landing() { }

	// RVA: 0x1D82C80 Offset: 0x1D82D81 VA: 0x1D82C80
	private static Quaternion GetRotation(BattleInfoSide current, BattleInfoSide target) { }

	// RVA: 0x1D83C90 Offset: 0x1D83D91 VA: 0x1D83C90
	private EffectData GetHitEffect(BattleScene scene) { }

	// RVA: 0x1D84020 Offset: 0x1D84121 VA: 0x1D84020
	private EffectData GetRodEffect(BattleScene scene) { }

	// RVA: 0x1D84140 Offset: 0x1D84241 VA: 0x1D84140
	private BattleInfoSide GetOffense(BattleScene scene) { }

	// RVA: 0x1D841D0 Offset: 0x1D842D1 VA: 0x1D841D0
	private BattleInfoSide GetDefense(BattleScene scene) { }

	// RVA: 0x1D842C0 Offset: 0x1D843C1 VA: 0x1D842C0
	private void PlayHitEffect(BattleScene scene) { }

	// RVA: 0x1D84750 Offset: 0x1D84851 VA: 0x1D84750
	private void PlayHitSound(BattleScene scene) { }

	// RVA: 0x1D849A0 Offset: 0x1D84AA1 VA: 0x1D849A0
	private void PlayPopup(BattleScene scene) { }

	// RVA: 0x1D84CD0 Offset: 0x1D84DD1 VA: 0x1D84CD0
	private void PlayDamage(BattleScene scene) { }

	[IteratorStateMachineAttribute] // RVA: 0x2C8920 Offset: 0x2C8A21 VA: 0x2C8920
	// RVA: 0x1D84F00 Offset: 0x1D85001 VA: 0x1D84F00
	private IEnumerator WaitLoading() { }

	// RVA: 0x1D84F80 Offset: 0x1D85081 VA: 0x1D84F80 Slot: 8
	protected override void OnPersistent() { }

	// RVA: 0x1D850F0 Offset: 0x1D851F1 VA: 0x1D850F0
	private void SetModelItem(BattleInfoSide side, UnitItem unitItem) { }

	// RVA: 0x1D85230 Offset: 0x1D85331 VA: 0x1D85230
	private void Begin() { }

	// RVA: 0x1D85640 Offset: 0x1D85741 VA: 0x1D85640
	private void End() { }

	// RVA: 0x1D85C30 Offset: 0x1D85D31 VA: 0x1D85C30
	private void ToPreBgm() { }

	// RVA: 0x1D85CC0 Offset: 0x1D85DC1 VA: 0x1D85CC0
	private void ToMainBgm() { }

	// RVA: 0x1D85D50 Offset: 0x1D85E51 VA: 0x1D85D50
	private void ReturnBgm() { }

	// RVA: 0x1D85DE0 Offset: 0x1D85EE1 VA: 0x1D85DE0
	private void PlaySkill() { }

	// RVA: 0x1D85FF0 Offset: 0x1D860F1 VA: 0x1D85FF0
	private void FocusAttack() { }

	// RVA: 0x1D860F0 Offset: 0x1D861F1 VA: 0x1D860F0
	private void PlayAttack() { }

	// RVA: 0x1D86330 Offset: 0x1D86431 VA: 0x1D86330
	private void StopAttack() { }

	// RVA: 0x1D86440 Offset: 0x1D86541 VA: 0x1D86440
	private void StartSignal() { }

	// RVA: 0x1D86720 Offset: 0x1D86821 VA: 0x1D86720
	private void Impact() { }

	// RVA: 0x1D86DD0 Offset: 0x1D86ED1 VA: 0x1D86DD0
	private void Commit() { }

	// RVA: 0x1D86DE0 Offset: 0x1D86EE1 VA: 0x1D86DE0
	private void Branch() { }

	// RVA: 0x1D87010 Offset: 0x1D87111 VA: 0x1D87010
	private void NextWait() { }

	// RVA: 0x1D87140 Offset: 0x1D87241 VA: 0x1D87140
	private void Wait() { }

	// RVA: 0x1D87190 Offset: 0x1D87291 VA: 0x1D87190
	private void WaitCamera() { }

	// RVA: 0x1D87250 Offset: 0x1D87351 VA: 0x1D87250
	private void TryWhiteOut() { }

	// RVA: 0x1D872F0 Offset: 0x1D873F1 VA: 0x1D872F0
	private static bool HasActor(BattleInfoSide side) { }

	[IteratorStateMachineAttribute] // RVA: 0x2C8990 Offset: 0x2C8A91 VA: 0x2C8990
	// RVA: 0x1D87380 Offset: 0x1D87481 VA: 0x1D87380
	private IEnumerator TryTransOn() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C8A00 Offset: 0x2C8B01 VA: 0x2C8A00
	// RVA: 0x1D87400 Offset: 0x1D87501 VA: 0x1D87400
	private IEnumerator TryTransOff() { }

	// RVA: 0x1D775F0 Offset: 0x1D776F1 VA: 0x1D775F0
	public static void CreateBind(ProcInst super, BattleCalculator calculator, BattleCalculator simCalculator, ProcVoidMethod callback, int battleCount = 0) { }
}

