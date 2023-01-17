// Namespace: 
private class ScriptBattle.ScriptCombatSequence : ProcInst // TypeDefIndex: 10232
{
	// Fields
	private PersonData m_PersonA; // 0x70
	private PersonData m_PersonB; // 0x78
	private Unit m_UnitA; // 0x80
	private Unit m_UnitB; // 0x88
	private List<Unit> m_Temporary; // 0x90
	private BattleInfo m_Info; // 0x98
	private BattleInfo m_SimInfo; // 0xA0
	private BattleCalculator m_Calculator; // 0xA8
	private BattleCalculator m_SimCalculator; // 0xB0

	// Methods

	// RVA: 0x2035050 Offset: 0x2035151 VA: 0x2035050
	private void .ctor(PersonData personA, PersonData personB) { }

	// RVA: 0x2035110 Offset: 0x2035211 VA: 0x2035110 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x2035530 Offset: 0x2035631 VA: 0x2035530 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2035630 Offset: 0x2035731 VA: 0x2035630
	private void BattleStart() { }

	// RVA: 0x20352F0 Offset: 0x20353F1 VA: 0x20352F0
	private Unit TryGetUnitOrCreate(PersonData person) { }

	// RVA: 0x2035640 Offset: 0x2035741 VA: 0x2035640
	public static void CreateBind(ProcInst super, PersonData personA, PersonData personB) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD820 Offset: 0x2BD921 VA: 0x2BD820
	// RVA: 0x20353B0 Offset: 0x20354B1 VA: 0x20353B0
	private void <OnCreate>g___|1_0(BattleInfo info, bool isSimulation) { }
}

