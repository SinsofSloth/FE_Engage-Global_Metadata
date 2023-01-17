// Namespace: App
public class BattleCalculator : IDisposable // TypeDefIndex: 9482
{
	// Fields
	private BattleCalculator.Mode m_Mode; // 0x10
	private BattleInfo m_Info; // 0x18
	private BattleCalculator.FlagField m_Flag; // 0x20
	private BattleSceneList m_SceneList; // 0x28
	private BattleCalculator.OrderList m_Orders; // 0x30
	private int m_NextOrderIndex; // 0x38
	private SkillData m_EquipSkill; // 0x40
	private List<BattleInfoSide> m_ChainOffenses; // 0x48
	private List<BattleInfoSide> m_ChainDefenses; // 0x50
	private BattleCalculator.HitSkillPool m_HitSkillPool; // 0x58
	private HashSet<int> m_CommitSkillUnits; // 0x60
	private static readonly string[] CannonConditions; // 0x0
	private static readonly string[] DanceConditions; // 0x8

	// Properties
	public BattleInfo Info { get; }
	public BattleSceneList SceneList { get; }
	private BattleScene.Result SceneResult { get; set; }

	// Methods

	// RVA: 0x2906710 Offset: 0x2906811 VA: 0x2906710
	public void .ctor(BattleInfo info) { }

	// RVA: 0x2906900 Offset: 0x2906A01 VA: 0x2906900 Slot: 4
	public void Dispose() { }

	// RVA: 0x2906910 Offset: 0x2906A11 VA: 0x2906910
	public BattleCalculator.Mode GetMode() { }

	// RVA: 0x2906920 Offset: 0x2906A21 VA: 0x2906920
	public BattleCalculator CalcBattle() { }

	// RVA: 0x2906DF0 Offset: 0x2906EF1 VA: 0x2906DF0
	public void Dump() { }

	// RVA: 0x2906E00 Offset: 0x2906F01 VA: 0x2906E00
	private bool TryAddSkillScene(BattleScene.Kind kind, BattleSide.Type side, SkillData skill) { }

	// RVA: 0x2906E90 Offset: 0x2906F91 VA: 0x2906E90
	private void CalcEngageStart(BattleSide.Type side) { }

	// RVA: 0x2907020 Offset: 0x2907121 VA: 0x2907020
	private void CalcInvokeSkill(BattleSide.Type side) { }

	// RVA: 0x2907180 Offset: 0x2907281 VA: 0x2907180
	private void CalcEngageEnd(BattleSide.Type side) { }

	// RVA: 0x2907220 Offset: 0x2907321 VA: 0x2907220
	private void CalcDetailSkill() { }

	// RVA: 0x2906950 Offset: 0x2906A51 VA: 0x2906950
	private void CalcBranch() { }

	// RVA: 0x2908B70 Offset: 0x2908C71 VA: 0x2908B70
	private bool IsLateOrder() { }

	// RVA: 0x2908C40 Offset: 0x2908D41 VA: 0x2908C40
	private void SeparatorTotalOrder() { }

	// RVA: 0x29086F0 Offset: 0x29087F1 VA: 0x29086F0
	private void CalcNormalBattle() { }

	// RVA: 0x2908090 Offset: 0x2908191 VA: 0x2908090
	private void CalcDestroy() { }

	// RVA: 0x2909740 Offset: 0x2909841 VA: 0x2909740
	private void AddSkillSceneResult(BattleScene.Result result) { }

	// RVA: 0x2908ED0 Offset: 0x2908FD1 VA: 0x2908ED0
	private bool CalcDestroyAttack(BattleSide.Type side) { }

	// RVA: 0x290A6B0 Offset: 0x290A7B1 VA: 0x290A6B0
	public BattleCalculator CalcWarmup() { }

	// RVA: 0x290A730 Offset: 0x290A831 VA: 0x290A730
	public BattleCalculator CalcSimulation() { }

	// RVA: 0x290A7C0 Offset: 0x290A8C1 VA: 0x290A7C0
	public BattleCalculator CalcJobIntro() { }

	// RVA: 0x290A7D0 Offset: 0x290A8D1 VA: 0x290A7D0
	public BattleCalculator CalcClassChange() { }

	// RVA: 0x290A7E0 Offset: 0x290A8E1 VA: 0x290A7E0
	public int GetHp(BattleSide.Type side) { }

	// RVA: 0x290A850 Offset: 0x290A951 VA: 0x290A850
	public BattleInfoSide.BitFieldStatus GetStatus(BattleSide.Type side) { }

	// RVA: 0x290A8C0 Offset: 0x290A9C1 VA: 0x290A8C0
	public BattleInfo get_Info() { }

	// RVA: 0x290A8D0 Offset: 0x290A9D1 VA: 0x290A8D0
	public BattleSceneList get_SceneList() { }

	// RVA: 0x29070D0 Offset: 0x29071D1 VA: 0x29070D0
	private BattleScene.Result CalcActiveSkill(SkillData.Timings timing, BattleSide.Type side) { }

	// RVA: 0x290AB10 Offset: 0x290AC11 VA: 0x290AB10
	private bool CanAttack(BattleInfoSide side) { }

	// RVA: 0x29074C0 Offset: 0x29075C1 VA: 0x29074C0
	private void AddSkillScene(SkillData skill, SkillData.Actions action, BattleInfoSide current) { }

	// RVA: 0x290ACB0 Offset: 0x290ADB1 VA: 0x290ACB0
	private BattleScene.Result GetBreaked(BattleInfoSide target) { }

	// RVA: 0x290ADC0 Offset: 0x290AEC1 VA: 0x290ADC0
	private BattleScene.Result AddGiveScene(SkillData give, BattleInfoSide current, BattleInfoSide target, BattleScene.Kind kind) { }

	// RVA: 0x290AFB0 Offset: 0x290B0B1 VA: 0x290AFB0
	private static SkillData FindIgnoreSkill(BattleInfoSide target, SkillData skill) { }

	// RVA: 0x290B1E0 Offset: 0x290B2E1 VA: 0x290B1E0
	private BattleScene.Result AddGiveScene(SkillData give, BattleInfoSide current, BattleInfoSide target) { }

	// RVA: 0x290B890 Offset: 0x290B991 VA: 0x290B890
	private BattleScene.Result AddGivesScene(SkillData skill, BattleInfoSide current, BattleInfoSide target) { }

	// RVA: 0x2907690 Offset: 0x2907791 VA: 0x2907690
	private BattleScene.Result AddGivesScene(SkillData skill, SkillData.Actions action, BattleInfoSide current) { }

	// RVA: 0x290BA50 Offset: 0x290BB51 VA: 0x290BA50
	private BattleScene.Result CalcHitSkill(BattleInfoSide current, UnitItem unitItem) { }

	// RVA: 0x290A8E0 Offset: 0x290A9E1 VA: 0x290A8E0
	private BattleScene.Result CalcActiveSkill(SkillData.Timings timing, SkillData.Actions action, BattleInfoSide current) { }

	// RVA: 0x290BCF0 Offset: 0x290BDF1 VA: 0x290BCF0
	private bool CanOrederSkill(SkillData skill, BattleInfoSide current) { }

	// RVA: 0x290BC60 Offset: 0x290BD61 VA: 0x290BC60
	private BattleScene.Result CalcActiveSkill(SkillData skill, SkillData.Actions action, BattleInfoSide current) { }

	// RVA: 0x2909780 Offset: 0x2909881 VA: 0x2909780
	private BattleScene.Result CalcHitSkill(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x290BEC0 Offset: 0x290BFC1 VA: 0x290BEC0
	private void CalcHitSkill(BattleInfoSide current, SkillData.Actions action, SkillData skill) { }

	// RVA: 0x290BFD0 Offset: 0x290C0D1 VA: 0x290BFD0
	private void CalcResultSkill(BattleInfoSide current) { }

	// RVA: 0x290C220 Offset: 0x290C321 VA: 0x290C220
	private void CalcResultSkill() { }

	// RVA: 0x290C330 Offset: 0x290C431 VA: 0x290C330
	private static void AddDebugIndent(string name) { }

	// RVA: 0x290C340 Offset: 0x290C441 VA: 0x290C340
	private static void DecDebugIndent() { }

	// RVA: 0x290C350 Offset: 0x290C451 VA: 0x290C350
	private List<BattleInfoSide> CalcChainAttackSides(BattleInfoSide current) { }

	// RVA: 0x290C4F0 Offset: 0x290C5F1 VA: 0x290C4F0
	private BattleSide.Type CalcChainGuardSide(BattleInfoSide reverse) { }

	// RVA: 0x290C740 Offset: 0x290C841 VA: 0x290C740
	private bool CanChainAttack(BattleSide.Type side) { }

	// RVA: 0x290C7C0 Offset: 0x290C8C1 VA: 0x290C7C0
	private bool CalcChainAttack(BattleSide.Type side) { }

	// RVA: 0x2908D50 Offset: 0x2908E51 VA: 0x2908D50
	private bool CalcOrders(BattleCalculator.OrderList orders) { }

	// RVA: 0x290D1E0 Offset: 0x290D2E1 VA: 0x290D1E0
	private bool CalcInterruptOrder(BattleSide.Type side) { }

	// RVA: 0x290D660 Offset: 0x290D761 VA: 0x290D660
	private bool CalcInterrupt(BattleSide.Type side) { }

	// RVA: 0x290D870 Offset: 0x290D971 VA: 0x290D870
	private void AddEngageCount(BattleInfoSide current) { }

	// RVA: 0x290DB00 Offset: 0x290DC01 VA: 0x290DB00
	private void AddEngageCount(BattleSide.Type side) { }

	// RVA: 0x290CB80 Offset: 0x290CC81 VA: 0x290CB80
	private bool CalcOrders(BattleSide.Type side) { }

	// RVA: 0x290DC80 Offset: 0x290DD81 VA: 0x290DC80
	private void CalcAssistSkill(BattleSide.Type side) { }

	// RVA: 0x290D350 Offset: 0x290D451 VA: 0x290D350
	private bool CalcOrder(BattleSide.Type side) { }

	// RVA: 0x290DE90 Offset: 0x290DF91 VA: 0x290DE90
	private bool CalcAction(BattleSide.Type side) { }

	// RVA: 0x290F120 Offset: 0x290F221 VA: 0x290F120
	private static int GetCommandValue(string key, BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x290F1F0 Offset: 0x290F2F1 VA: 0x290F1F0
	private static int GetChainGuardDamage(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x290F400 Offset: 0x290F501 VA: 0x290F400
	private bool RandomCheckHit(int ratio) { }

	// RVA: 0x290E190 Offset: 0x290E291 VA: 0x290E190
	private bool CalcAttack(BattleSide.Type sideType) { }

	// RVA: 0x290FBC0 Offset: 0x290FCC1 VA: 0x290FBC0
	private bool CanEnter(BattleInfoSide side, int x, int z) { }

	// RVA: 0x290FCE0 Offset: 0x290FDE1 VA: 0x290FCE0
	private bool CanBlow(BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x290F4D0 Offset: 0x290F5D1 VA: 0x290F4D0
	private BattleScene.Result CalcAttackHit(BattleInfoSide current, BattleInfoSide reverse, out int critical) { }

	// RVA: 0x290FE50 Offset: 0x290FF51 VA: 0x290FE50
	private bool TryAddDeadScene(BattleInfoSide side, BattleScene.Result result = 0) { }

	// RVA: 0x290F970 Offset: 0x290FA71 VA: 0x290F970
	private bool CalcAttackPost(BattleSide.Type sideType, int damage, BattleScene.Result result) { }

	// RVA: 0x2909760 Offset: 0x2909861 VA: 0x2909760
	private BattleScene.Result get_SceneResult() { }

	// RVA: 0x2909770 Offset: 0x2909871 VA: 0x2909770
	private void set_SceneResult(BattleScene.Result value) { }

	// RVA: 0x2908580 Offset: 0x2908681 VA: 0x2908580
	private void CalcRod() { }

	// RVA: 0x2910010 Offset: 0x2910111 VA: 0x2910010
	private void CalcRodOrder(BattleSide.Type side) { }

	// RVA: 0x2910190 Offset: 0x2910291 VA: 0x2910190
	private void CalcRodAction(BattleSide.Type side) { }

	// RVA: 0x2910310 Offset: 0x2910411 VA: 0x2910310
	private void CalcRodAttack(BattleSide.Type side) { }

	// RVA: 0x2907940 Offset: 0x2907A41 VA: 0x2907940
	private void CalcDance() { }

	// RVA: 0x29112D0 Offset: 0x29113D1 VA: 0x29112D0
	private void CalcDanceOrder() { }

	// RVA: 0x2911440 Offset: 0x2911541 VA: 0x2911440
	private void CalcDanceAction() { }

	// RVA: 0x29115B0 Offset: 0x29116B1 VA: 0x29115B0
	private void CalcDanceAttack() { }

	// RVA: 0x2907AB0 Offset: 0x2907BB1 VA: 0x2907AB0
	private void CalcEnchant() { }

	// RVA: 0x2910F40 Offset: 0x2911041 VA: 0x2910F40
	private void CalcRodHit(BattleInfoSide current, BattleInfoSide reverse, UnitItem unitItem, ItemData item) { }

	// RVA: 0x2906D30 Offset: 0x2906E31 VA: 0x2906D30
	private void CalcResult() { }

	// RVA: 0x2912300 Offset: 0x2912401 VA: 0x2912300
	private bool CanBattleRecord(BattleInfoSide side) { }

	// RVA: 0x2912530 Offset: 0x2912631 VA: 0x2912530
	private void CalcRecord() { }

	// RVA: 0x29137D0 Offset: 0x29138D1 VA: 0x29137D0
	private BattleInfoSide GetSide(Force.Type force) { }

	// RVA: 0x2913900 Offset: 0x2913A01 VA: 0x2913900
	private void CalcAchieve() { }

	// RVA: 0x29121D0 Offset: 0x29122D1 VA: 0x29121D0
	private void CalcExpendCount() { }

	// RVA: 0x2914510 Offset: 0x2914611 VA: 0x2914510
	private bool IsChainAttackDead() { }

	// RVA: 0x2914670 Offset: 0x2914771 VA: 0x2914670
	private void CalcExp(BattleCalculator.FuncExp1 func, BattleInfoSide current) { }

	// RVA: 0x29146A0 Offset: 0x29147A1 VA: 0x29146A0
	private void CalcExp(BattleCalculator.FuncExp2 func, BattleInfoSide current, BattleInfoSide reverse) { }

	// RVA: 0x2911760 Offset: 0x2911861 VA: 0x2911760
	private void CalcResultGain() { }

	// RVA: 0x2911D90 Offset: 0x2911E91 VA: 0x2911D90
	private void CalcExpCount() { }

	// RVA: 0x29146E0 Offset: 0x29147E1 VA: 0x29146E0
	private void CommitHP(BattleInfoSide side, int hp) { }

	// RVA: 0x2914710 Offset: 0x2914811 VA: 0x2914710
	private void CommitEngageCount(BattleInfoSide side, int count) { }

	// RVA: 0x2914750 Offset: 0x2914851 VA: 0x2914750
	public void UpdateScene() { }

	// RVA: 0x2914860 Offset: 0x2914961 VA: 0x2914860
	public void UpdateScene(int index, bool isEngaeCount = True) { }

	// RVA: 0x2914940 Offset: 0x2914A41 VA: 0x2914940
	public void UpdateScene(BattleScene scene, bool isEngaeCount = True) { }

	// RVA: 0x2914CA0 Offset: 0x2914DA1 VA: 0x2914CA0
	private void CommitUnit() { }

	// RVA: 0x29151A0 Offset: 0x29152A1 VA: 0x29151A0
	private void CommitSkill() { }

	// RVA: 0x2915650 Offset: 0x2915751 VA: 0x2915650
	private void CommitDestroy() { }

	// RVA: 0x2915690 Offset: 0x2915791 VA: 0x2915690
	public void CommitBattle() { }

	// RVA: 0x2915510 Offset: 0x2915611 VA: 0x2915510
	private void MapHistoryCommitSkill(Unit unit) { }

	// RVA: 0x2915870 Offset: 0x2915971 VA: 0x2915870
	public bool IsTraining() { }

	// RVA: 0x2912490 Offset: 0x2912591 VA: 0x2912490
	public bool IsRod() { }

	// RVA: 0x29158E0 Offset: 0x29159E1 VA: 0x29158E0
	public Unit GetUnit(int index) { }

	// RVA: 0x2906FB0 Offset: 0x29070B1 VA: 0x2906FB0
	public Unit GetUnit(BattleSide.Type side) { }

	// RVA: 0x2915950 Offset: 0x2915A51 VA: 0x2915950
	public BattleInfoSide GetSide(int index) { }

	// RVA: 0x290C2D0 Offset: 0x290C3D1 VA: 0x290C2D0
	public BattleInfoSide GetSide(BattleSide.Type side) { }

	// RVA: 0x2913430 Offset: 0x2913531 VA: 0x2913430
	public BattleSide.Type GetDeadSide() { }

	// RVA: 0x29159B0 Offset: 0x2915AB1 VA: 0x29159B0
	public Unit GetDeadUnit() { }

	// RVA: 0x2914300 Offset: 0x2914401 VA: 0x2914300
	private int GetExpendCount(BattleInfoSide side) { }

	// RVA: 0x2915A40 Offset: 0x2915B41 VA: 0x2915A40
	public bool CanSkyBattle() { }

	// RVA: 0x2915DB0 Offset: 0x2915EB1 VA: 0x2915DB0
	public bool IsMultiBattle() { }

	// RVA: 0x2915E20 Offset: 0x2915F21 VA: 0x2915E20
	public bool IsCannonBattle() { }

	// RVA: 0x2915E90 Offset: 0x2915F91 VA: 0x2915E90
	public bool IsFireCannon() { }

	// RVA: 0x2915F00 Offset: 0x2916001 VA: 0x2915F00
	public bool IsFullBullet() { }

	// RVA: 0x2915F70 Offset: 0x2916071 VA: 0x2915F70
	public bool IsLastBossDie() { }

	// RVA: 0x2916140 Offset: 0x2916241 VA: 0x2916140
	public bool IsBattleGrow() { }

	// RVA: 0x2916330 Offset: 0x2916431 VA: 0x2916330
	public bool IsCombatDie() { }

	// RVA: 0x2916400 Offset: 0x2916501 VA: 0x2916400
	public bool IsCombatGrow() { }

	// RVA: 0x2916510 Offset: 0x2916611 VA: 0x2916510
	public string[] GetAssetConditions(BattleSide.Type sideType) { }

	// RVA: 0x2916660 Offset: 0x2916761 VA: 0x2916660
	private static void .cctor() { }
}

