// Namespace: Chara
public class UnitInfoSequence : SingletonProcInst<UnitInfoSequence> // TypeDefIndex: 8394
{
	// Fields
	private Unit m_Unit; // 0x78
	private GameObject m_Camera; // 0x80
	private GameObject m_Effect; // 0x88
	private Camera m_MapCamera; // 0x90
	private CharacterGameStatus[] m_Status; // 0x98
	private Character[] m_Chara; // 0xA0

	// Properties
	private int UnitSide { get; }
	public string UnitPID { get; }

	// Methods

	// RVA: 0x2428100 Offset: 0x2428201 VA: 0x2428100
	private int get_UnitSide() { }

	// RVA: 0x2428120 Offset: 0x2428221 VA: 0x2428120
	public static bool IsExist() { }

	// RVA: 0x24281A0 Offset: 0x24282A1 VA: 0x24281A0
	public string get_UnitPID() { }

	// RVA: 0x24281B0 Offset: 0x24282B1 VA: 0x24281B0
	public static void CreateBind(ProcInst super, Unit unit) { }

	// RVA: 0x24287D0 Offset: 0x24288D1 VA: 0x24287D0
	private void .ctor(Unit unit) { }

	// RVA: 0x2428980 Offset: 0x2428A81 VA: 0x2428980
	private void TimerStop() { }

	// RVA: 0x2428990 Offset: 0x2428A91 VA: 0x2428990
	private void TimerStart() { }

	// RVA: 0x24289A0 Offset: 0x2428AA1 VA: 0x24289A0
	private void CreteaCombatBorders() { }

	// RVA: 0x242A280 Offset: 0x242A381 VA: 0x242A280
	private void DeleteCombatBorders() { }

	// RVA: 0x242A320 Offset: 0x242A421 VA: 0x242A320 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x242A3A0 Offset: 0x242A4A1 VA: 0x242A3A0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x242A410 Offset: 0x242A511 VA: 0x242A410 Slot: 8
	protected override void OnPersistent() { }

	// RVA: 0x242A420 Offset: 0x242A521 VA: 0x242A420
	private void Load() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A8160 Offset: 0x2A8261 VA: 0x2A8160
	// RVA: 0x242A640 Offset: 0x242A741 VA: 0x242A640
	private IEnumerator LoadCharacter() { }

	// RVA: 0x242A6C0 Offset: 0x242A7C1 VA: 0x242A6C0
	private void SetupGameStatus() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A81D0 Offset: 0x2A82D1 VA: 0x2A81D0
	// RVA: 0x242A8B0 Offset: 0x242A9B1 VA: 0x242A8B0
	private IEnumerator LoadCharacterImpl(int side, BaseCombatLocation locator) { }

	// RVA: 0x242A950 Offset: 0x242AA51 VA: 0x242A950
	private void Unload() { }

	// RVA: 0x242AAD0 Offset: 0x242ABD1 VA: 0x242AAD0
	private void Tick() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A8240 Offset: 0x2A8341 VA: 0x2A8240
	// RVA: 0x242B730 Offset: 0x242B831 VA: 0x242B730
	private IEnumerator BoundToCombatCamera() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A82B0 Offset: 0x2A83B1 VA: 0x2A82B0
	// RVA: 0x242B7B0 Offset: 0x242B8B1 VA: 0x242B7B0
	private IEnumerator ReturnToMapCamera() { }
}

