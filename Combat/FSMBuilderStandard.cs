// Namespace: Combat
internal class FSMBuilderStandard : FSMBuilder // TypeDefIndex: 8494
{
	// Fields
	private SyncToken[] chainSync; // 0x10
	private const float ChainAttackTime = 1;

	// Methods

	// RVA: 0x2A116A0 Offset: 0x2A117A1 VA: 0x2A116A0 Slot: 7
	protected override void BuildEnd() { }

	// RVA: 0x2A11A10 Offset: 0x2A11B11 VA: 0x2A11A10
	private static void BuildEnd_BothAlive() { }

	// RVA: 0x2A11BD0 Offset: 0x2A11CD1 VA: 0x2A11BD0
	private static void BuildEnd_PlayerKilled() { }

	// RVA: 0x2A120B0 Offset: 0x2A121B1 VA: 0x2A120B0
	private static void BuildEnd_EnemyBossKilled() { }

	// RVA: 0x2A11E70 Offset: 0x2A11F71 VA: 0x2A11E70
	private static void BuildEnd_EnemyKilled() { }

	// RVA: 0x2A0F730 Offset: 0x2A0F831 VA: 0x2A0F730 Slot: 6
	protected override void BuildMain() { }

	// RVA: 0x2A128C0 Offset: 0x2A129C1 VA: 0x2A128C0
	private static void BuildStandardPhase(Phase phase) { }

	// RVA: 0x2A12AC0 Offset: 0x2A12BC1 VA: 0x2A12AC0 Slot: 5
	protected override void BuildStart() { }

	// RVA: 0x2A130D0 Offset: 0x2A131D1 VA: 0x2A130D0
	private static void Start_Training() { }

	// RVA: 0x2A131E0 Offset: 0x2A132E1 VA: 0x2A131E0
	private static void Start_Talk() { }

	// RVA: 0x2A136F0 Offset: 0x2A137F1 VA: 0x2A136F0
	private static void Start_Default() { }

	// RVA: 0x2A14140 Offset: 0x2A14241 VA: 0x2A14140
	private static void AppendStartAnim(bool runStart, float startTime) { }

	// RVA: 0x2A13D20 Offset: 0x2A13E21 VA: 0x2A13D20
	private static bool AppendDragonStone() { }

	// RVA: 0x2A13470 Offset: 0x2A13571 VA: 0x2A13470
	private static void Start_WithDive() { }

	// RVA: 0x2A14670 Offset: 0x2A14771 VA: 0x2A14670
	private void AllocChainSync() { }

	// RVA: 0x2A120C0 Offset: 0x2A121C1 VA: 0x2A120C0
	private void BuildChainAttackPhase(Phase phase, int chainNum) { }

	// RVA: 0x2A147F0 Offset: 0x2A148F1 VA: 0x2A147F0
	private void BuildChainFSM(Phase phase, Character chain, int chainNum) { }

	// RVA: 0x2A0DE40 Offset: 0x2A0DF41 VA: 0x2A0DE40
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A89E0 Offset: 0x2A8AE1 VA: 0x2A89E0
	// RVA: 0x2A13870 Offset: 0x2A13971 VA: 0x2A13870
	internal static void <Start_Training>g__AddFsm|8_0(int side, float start, ref FSMBuilderStandard.<>c__DisplayClass8_0 ) { }
}

