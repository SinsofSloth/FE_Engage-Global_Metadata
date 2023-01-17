// Namespace: App
internal class LevelUpSequnece : ProcInst // TypeDefIndex: 13022
{
	// Fields
	private readonly string ResNameLevelUp; // 0x70
	private readonly string ResNameClassChange; // 0x78
	private Unit m_Unit; // 0x80
	private Unit m_Grow; // 0x88
	private int m_Level; // 0x90
	private bool m_IsClassChange; // 0x94
	private string m_TalkMid; // 0x98
	private LevelUpWindowController m_Window; // 0xA0
	private bool m_IsShowCharaImage; // 0xA8
	private bool m_IsTalk; // 0xA9
	private int m_NowCapabilityIndex; // 0xAC
	private CapabilityDefinition.Type[] m_CapabilityOrder; // 0xB0

	// Methods

	// RVA: 0x1F82B10 Offset: 0x1F82C11 VA: 0x1F82B10
	private void .ctor(Unit unit, int level, bool isShowCharaImage, bool isTalk) { }

	// RVA: 0x1F82C80 Offset: 0x1F82D81 VA: 0x1F82C80
	private void .ctor(Unit unit, Unit grow) { }

	// RVA: 0x1F82DE0 Offset: 0x1F82EE1 VA: 0x1F82DE0 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x1F82DF0 Offset: 0x1F82EF1 VA: 0x1F82DF0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x1F82E00 Offset: 0x1F82F01 VA: 0x1F82E00
	private string GetResName() { }

	// RVA: 0x1F82E20 Offset: 0x1F82F21 VA: 0x1F82E20
	private void Prepare() { }

	// RVA: 0x1F82F60 Offset: 0x1F83061 VA: 0x1F82F60
	private void Reflect() { }

	// RVA: 0x1F83560 Offset: 0x1F83661 VA: 0x1F83560
	private void ReloadActor() { }

	// RVA: 0x1F836B0 Offset: 0x1F837B1 VA: 0x1F836B0
	private void WaitReloadActor() { }

	// RVA: 0x1F83760 Offset: 0x1F83861 VA: 0x1F83760
	private void Effect() { }

	// RVA: 0x1F83820 Offset: 0x1F83921 VA: 0x1F83820
	private bool IsLoadingRes() { }

	// RVA: 0x1F838B0 Offset: 0x1F839B1 VA: 0x1F838B0
	private void Open() { }

	// RVA: 0x1F86C00 Offset: 0x1F86D01 VA: 0x1F86C00
	private void WaitAnime() { }

	// RVA: 0x1F86E20 Offset: 0x1F86F21 VA: 0x1F86E20
	private void CheckParamChange() { }

	// RVA: 0x1F88DC0 Offset: 0x1F88EC1 VA: 0x1F88DC0
	private int GetUpParamCount() { }

	// RVA: 0x1F8A8E0 Offset: 0x1F8A9E1 VA: 0x1F8A8E0
	private int GetLimitParamCount() { }

	// RVA: 0x1F8AA40 Offset: 0x1F8AB41 VA: 0x1F8AA40
	private void CalcTalkMid() { }

	// RVA: 0x1F8ACC0 Offset: 0x1F8ADC1 VA: 0x1F8ACC0
	private void Talk() { }

	// RVA: 0x1F8AD10 Offset: 0x1F8AE11 VA: 0x1F8AD10
	private void KeyWait() { }

	// RVA: 0x1F8AF80 Offset: 0x1F8B081 VA: 0x1F8AF80
	private void Release() { }

	// RVA: 0x1F8B070 Offset: 0x1F8B171 VA: 0x1F8B070
	private void LearnJobSkill() { }

	// RVA: 0x1F8B1C0 Offset: 0x1F8B2C1 VA: 0x1F8B1C0
	public static void CreateBind(ProcInst super, Unit unit, int level = -1, bool isShowCharaImage = False, bool isTalk = True) { }

	// RVA: 0x1F8BB00 Offset: 0x1F8BC01 VA: 0x1F8BB00
	public static void CreateBindClassChange(ProcInst super, Unit beforeUnit, Unit afterUnit) { }

	// RVA: 0x1F8B260 Offset: 0x1F8B361 VA: 0x1F8B260
	private void CreateBindImpl(ProcInst super) { }
}

