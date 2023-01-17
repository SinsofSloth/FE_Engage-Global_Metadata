// Namespace: Combat
public class ArenaCombatSequence : SingletonProcInst<ArenaCombatSequence> // TypeDefIndex: 8516
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27FED0 Offset: 0x27FFD1 VA: 0x27FED0
	private readonly string <ResultTelopPath>k__BackingField; // 0x78
	private readonly string StartTelopPath; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x27FEE0 Offset: 0x27FFE1 VA: 0x27FEE0
	private readonly BattleCalculator <Calculator>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x27FEF0 Offset: 0x27FFF1 VA: 0x27FEF0
	private readonly BattleCalculator <SimCalculator>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x27FF00 Offset: 0x280001 VA: 0x27FF00
	private readonly int <BondExp>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x27FF10 Offset: 0x280011 VA: 0x27FF10
	private readonly bool <IsEmblemBattle>k__BackingField; // 0x9C
	[CompilerGeneratedAttribute] // RVA: 0x27FF20 Offset: 0x280021 VA: 0x27FF20
	private readonly bool <IsSpecialBattle>k__BackingField; // 0x9D
	private Camera m_RenderCamera; // 0xA0
	private UniversalAdditionalCameraData m_RenderCameraData; // 0xA8
	private readonly int RenderCameraIndex_CharaMap; // 0xB0
	private readonly int RenderCameraIndex_Chara; // 0xB4
	private ReliancePopUpController m_RelianceController; // 0xB8
	private BondPopUpController m_BondController; // 0xC0

	// Properties
	private string ResultTelopPath { get; }
	private BattleCalculator Calculator { get; }
	private BattleCalculator SimCalculator { get; }
	private int BondExp { get; }
	private bool IsEmblemBattle { get; }
	private bool IsSpecialBattle { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A8C00 Offset: 0x2A8D01 VA: 0x2A8C00
	// RVA: 0x2107210 Offset: 0x2107311 VA: 0x2107210
	private string get_ResultTelopPath() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8C10 Offset: 0x2A8D11 VA: 0x2A8C10
	// RVA: 0x2107220 Offset: 0x2107321 VA: 0x2107220
	private BattleCalculator get_Calculator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8C20 Offset: 0x2A8D21 VA: 0x2A8C20
	// RVA: 0x2107230 Offset: 0x2107331 VA: 0x2107230
	private BattleCalculator get_SimCalculator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8C30 Offset: 0x2A8D31 VA: 0x2A8C30
	// RVA: 0x2107240 Offset: 0x2107341 VA: 0x2107240
	private int get_BondExp() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8C40 Offset: 0x2A8D41 VA: 0x2A8C40
	// RVA: 0x2107250 Offset: 0x2107351 VA: 0x2107250
	private bool get_IsEmblemBattle() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8C50 Offset: 0x2A8D51 VA: 0x2A8C50
	// RVA: 0x2107260 Offset: 0x2107361 VA: 0x2107260
	private bool get_IsSpecialBattle() { }

	// RVA: 0x2107270 Offset: 0x2107371 VA: 0x2107270
	public static void CreateBind(ProcInst super, BattleCalculator calculator, BattleCalculator simCalculator, bool isEmblemBattle, bool isSpecial, int bondExp) { }

	// RVA: 0x2107950 Offset: 0x2107A51 VA: 0x2107950
	private void .ctor(BattleCalculator calculator, BattleCalculator simCalculator, bool isEmblemBattle, bool isSpecial, int bondExp) { }

	// RVA: 0x2107B00 Offset: 0x2107C01 VA: 0x2107B00 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x2107B10 Offset: 0x2107C11 VA: 0x2107B10 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2107B20 Offset: 0x2107C21 VA: 0x2107B20 Slot: 8
	protected override void OnPersistent() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A8C60 Offset: 0x2A8D61 VA: 0x2A8C60
	// RVA: 0x2107B30 Offset: 0x2107C31 VA: 0x2107B30
	private IEnumerator Setup() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A8CD0 Offset: 0x2A8DD1 VA: 0x2A8CD0
	// RVA: 0x2107BB0 Offset: 0x2107CB1 VA: 0x2107BB0
	private IEnumerator WaitBegin() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A8D40 Offset: 0x2A8E41 VA: 0x2A8D40
	// RVA: 0x2107C10 Offset: 0x2107D11 VA: 0x2107C10
	private IEnumerator StartFight() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A8DB0 Offset: 0x2A8EB1 VA: 0x2A8DB0
	// RVA: 0x2107C90 Offset: 0x2107D91 VA: 0x2107C90
	private IEnumerator WaitFinish() { }

	// RVA: 0x2107CF0 Offset: 0x2107DF1 VA: 0x2107CF0
	private void Result() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A8E20 Offset: 0x2A8F21 VA: 0x2A8E20
	// RVA: 0x2107D70 Offset: 0x2107E71 VA: 0x2107D70
	private IEnumerator Grow1() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A8E90 Offset: 0x2A8F91 VA: 0x2A8E90
	// RVA: 0x2107DF0 Offset: 0x2107EF1 VA: 0x2107DF0
	private IEnumerator Grow2() { }

	// RVA: 0x2107E70 Offset: 0x2107F71 VA: 0x2107E70
	private void Grow3() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A8F00 Offset: 0x2A9001 VA: 0x2A8F00
	// RVA: 0x2108020 Offset: 0x2108121 VA: 0x2108020
	private IEnumerator Exit() { }
}

