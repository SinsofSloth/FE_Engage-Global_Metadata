// Namespace: Combat
public sealed class CombatSequence : SingletonProcInst<CombatSequence> // TypeDefIndex: 8522
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x27FF30 Offset: 0x280031 VA: 0x27FF30
	private BattleCalculator <Calculator>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x27FF40 Offset: 0x280041 VA: 0x27FF40
	private BattleCalculator <SimCalculator>k__BackingField; // 0x80
	private Camera m_MapCamera; // 0x88

	// Properties
	public BattleCalculator Calculator { get; set; }
	public BattleCalculator SimCalculator { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A91A0 Offset: 0x2A92A1 VA: 0x2A91A0
	// RVA: 0x256E280 Offset: 0x256E381 VA: 0x256E280
	public BattleCalculator get_Calculator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A91B0 Offset: 0x2A92B1 VA: 0x2A91B0
	// RVA: 0x256E290 Offset: 0x256E391 VA: 0x256E290
	private void set_Calculator(BattleCalculator value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A91C0 Offset: 0x2A92C1 VA: 0x2A91C0
	// RVA: 0x256E2A0 Offset: 0x256E3A1 VA: 0x256E2A0
	public BattleCalculator get_SimCalculator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A91D0 Offset: 0x2A92D1 VA: 0x2A91D0
	// RVA: 0x256E2B0 Offset: 0x256E3B1 VA: 0x256E2B0
	private void set_SimCalculator(BattleCalculator value) { }

	// RVA: 0x256E2C0 Offset: 0x256E3C1 VA: 0x256E2C0
	public static void CreateBind(ProcInst super, BattleCalculator calculator, BattleCalculator simCalculator, ProcVoidMethod callback) { }

	// RVA: 0x256F300 Offset: 0x256F401 VA: 0x256F300
	public void .ctor(BattleCalculator calculator, BattleCalculator simCalculator) { }

	// RVA: 0x256F3B0 Offset: 0x256F4B1 VA: 0x256F3B0
	private void TimerStart() { }

	// RVA: 0x256F3C0 Offset: 0x256F4C1 VA: 0x256F3C0
	private void TimerStop() { }

	// RVA: 0x256F3D0 Offset: 0x256F4D1 VA: 0x256F3D0
	private void CreateBorder() { }

	// RVA: 0x256F480 Offset: 0x256F581 VA: 0x256F480
	private void DeleteBorder() { }

	// RVA: 0x256F520 Offset: 0x256F621 VA: 0x256F520
	private void LoadVoice() { }

	// RVA: 0x256F550 Offset: 0x256F651 VA: 0x256F550
	private void LoadVoiceImpl(BattleSide.Type battleSideType) { }

	// RVA: 0x256F650 Offset: 0x256F751 VA: 0x256F650
	private void UnloadVoice() { }

	// RVA: 0x256F680 Offset: 0x256F781 VA: 0x256F680
	private void UnloadVoiceImpl(BattleSide.Type battleSideType) { }

	// RVA: 0x256F780 Offset: 0x256F881 VA: 0x256F780
	private void LoadScene() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A91E0 Offset: 0x2A92E1 VA: 0x2A91E0
	// RVA: 0x256F7B0 Offset: 0x256F8B1 VA: 0x256F7B0
	private IEnumerator WaitLoading() { }

	// RVA: 0x256F830 Offset: 0x256F931 VA: 0x256F830
	private void UnloadScene() { }

	// RVA: 0x256F9B0 Offset: 0x256FAB1 VA: 0x256F9B0
	private void Tick() { }

	// RVA: 0x256FA20 Offset: 0x256FB21 VA: 0x256FA20 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x256FAA0 Offset: 0x256FBA1 VA: 0x256FAA0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x256FB10 Offset: 0x256FC11 VA: 0x256FB10 Slot: 8
	protected override void OnPersistent() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A9250 Offset: 0x2A9351 VA: 0x2A9250
	// RVA: 0x256FB20 Offset: 0x256FC21 VA: 0x256FB20
	private IEnumerator BoundToCombatCamera() { }

	[IteratorStateMachineAttribute] // RVA: 0x2A92C0 Offset: 0x2A93C1 VA: 0x2A92C0
	// RVA: 0x256FBA0 Offset: 0x256FCA1 VA: 0x256FBA0
	private IEnumerator ReturnToMapCamera() { }

	// RVA: 0x256FC20 Offset: 0x256FD21 VA: 0x256FC20
	private void ToPreBgm() { }

	// RVA: 0x256FD10 Offset: 0x256FE11 VA: 0x256FD10
	public void ToMainBgm() { }

	// RVA: 0x256FD90 Offset: 0x256FE91 VA: 0x256FD90
	private void ReturnBgm() { }

	// RVA: 0x256FE80 Offset: 0x256FF81 VA: 0x256FE80
	private bool IsComebackWithTransitionCamera() { }

	// RVA: 0x256FF80 Offset: 0x2570081 VA: 0x256FF80
	private void DieTalk() { }

	// RVA: 0x256FFD0 Offset: 0x25700D1 VA: 0x256FFD0
	private void ShowGrowth() { }

	// RVA: 0x25702B0 Offset: 0x25703B1 VA: 0x25702B0
	private void MoveCursor() { }

	// RVA: 0x2570330 Offset: 0x2570431 VA: 0x2570330
	private void BackToGround() { }

	// RVA: 0x2570B00 Offset: 0x2570C01 VA: 0x2570B00
	private void WaitForBackToGround() { }

	// RVA: 0x2570C00 Offset: 0x2570D01 VA: 0x2570C00
	private void BackToGroundFadeIn() { }
}

