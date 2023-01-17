// Namespace: App
public class DieEvent : ProcBattleCallback // TypeDefIndex: 12399
{
	// Fields
	private Unit m_Unit; // 0x88
	private bool m_IsInCombat; // 0x90

	// Methods

	// RVA: 0x2372500 Offset: 0x2372601 VA: 0x2372500
	protected void .ctor(Unit unit, Action completed) { }

	// RVA: 0x2372680 Offset: 0x2372781 VA: 0x2372680
	private bool IsSkipCancel() { }

	// RVA: 0x2372790 Offset: 0x2372891 VA: 0x2372790 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x23727C0 Offset: 0x23728C1 VA: 0x23727C0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x23727F0 Offset: 0x23728F1 VA: 0x23727F0
	private void DieTalk() { }

	// RVA: 0x2372840 Offset: 0x2372941 VA: 0x2372840
	private void GodTalk() { }

	// RVA: 0x2372890 Offset: 0x2372991 VA: 0x2372890
	private void Event() { }

	// RVA: 0x2372930 Offset: 0x2372A31 VA: 0x2372930
	private void InitDieBgm() { }

	// RVA: 0x23729C0 Offset: 0x2372AC1 VA: 0x23729C0
	private void WaitDieBgmEnd() { }

	// RVA: 0x2372AA0 Offset: 0x2372BA1 VA: 0x2372AA0
	private void PlayDieBgm() { }

	// RVA: 0x2372C70 Offset: 0x2372D71 VA: 0x2372C70
	private void StopDieBgm() { }

	// RVA: 0x2372E20 Offset: 0x2372F21 VA: 0x2372E20
	public static bool IsEnable(BattleCalculator calculator) { }

	// RVA: 0x2372FB0 Offset: 0x23730B1 VA: 0x2372FB0
	public static bool IsImportant(BattleCalculator calculator) { }

	// RVA: 0x2372EF0 Offset: 0x2372FF1 VA: 0x2372EF0
	public static bool IsEnable(Unit unit) { }

	// RVA: 0x2373250 Offset: 0x2373351 VA: 0x2373250
	public static bool TryCreateBind(ProcInst super, BattleCalculator calculator, Action completed) { }

	// RVA: 0x23732C0 Offset: 0x23733C1 VA: 0x23732C0
	public static bool TryCreateBind(ProcInst super, Unit unit, Action completed) { }
}

