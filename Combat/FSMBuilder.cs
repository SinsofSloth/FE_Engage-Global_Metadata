// Namespace: Combat
public abstract class FSMBuilder // TypeDefIndex: 8470
{
	// Properties
	protected static CombatWorld world { get; }
	protected static CombatRecord record { get; }
	protected static Character[] chrs { get; }
	protected static CameraManager cam { get; }
	protected static CombatStyle style { get; }
	protected static Character anyone { get; }
	protected static Phase FirstAttackPhase { get; }
	protected static Character FirstAttacker { get; }

	// Methods

	// RVA: 0x2A0D690 Offset: 0x2A0D791 VA: 0x2A0D690
	protected static CombatWorld get_world() { }

	// RVA: 0x2A0D6A0 Offset: 0x2A0D7A1 VA: 0x2A0D6A0
	protected static CombatRecord get_record() { }

	// RVA: 0x2A0D6C0 Offset: 0x2A0D7C1 VA: 0x2A0D6C0
	protected static Character[] get_chrs() { }

	// RVA: 0x2A0D6E0 Offset: 0x2A0D7E1 VA: 0x2A0D6E0
	protected static CameraManager get_cam() { }

	// RVA: 0x2A0D760 Offset: 0x2A0D861 VA: 0x2A0D760
	protected static CombatStyle get_style() { }

	// RVA: 0x2A0D7A0 Offset: 0x2A0D8A1 VA: 0x2A0D7A0
	protected static Character get_anyone() { }

	// RVA: 0x2A0D860 Offset: 0x2A0D961 VA: 0x2A0D860
	protected static Phase get_FirstAttackPhase() { }

	// RVA: 0x2A0D9D0 Offset: 0x2A0DAD1 VA: 0x2A0D9D0
	protected static Character get_FirstAttacker() { }

	// RVA: 0x2A0DA40 Offset: 0x2A0DB41 VA: 0x2A0DA40
	public static void PreLoad() { }

	// RVA: 0x2A0DC80 Offset: 0x2A0DD81 VA: 0x2A0DC80
	public static FSMBuilder CreateAndRun() { }

	// RVA: 0x2A0DE50 Offset: 0x2A0DF51 VA: 0x2A0DE50 Slot: 4
	protected virtual void Build() { }

	// RVA: 0x2A0DEA0 Offset: 0x2A0DFA1 VA: 0x2A0DEA0 Slot: 5
	protected virtual void BuildStart() { }

	// RVA: 0x2A0DEB0 Offset: 0x2A0DFB1 VA: 0x2A0DEB0 Slot: 6
	protected virtual void BuildMain() { }

	// RVA: 0x2A0DEC0 Offset: 0x2A0DFC1 VA: 0x2A0DEC0 Slot: 7
	protected virtual void BuildEnd() { }

	// RVA: 0x2A0DED0 Offset: 0x2A0DFD1 VA: 0x2A0DED0 Slot: 8
	public virtual void BuildSkipover() { }

	// RVA: 0x2A0DFF0 Offset: 0x2A0E0F1 VA: 0x2A0DFF0
	public static void RunEternalCombatAppendObserver() { }

	// RVA: 0x2A0E130 Offset: 0x2A0E231 VA: 0x2A0E130
	protected static void FSMAdd_WaitForTransitionCamera(float rate) { }

	// RVA: 0x2A0E2F0 Offset: 0x2A0E3F1 VA: 0x2A0E2F0
	protected static ActionBase ActionWairForTransitionCamera(float rate) { }

	// RVA: 0x2A0E3F0 Offset: 0x2A0E4F1 VA: 0x2A0E3F0
	protected static void FSMAdd_SyncEveryone(bool includeGrandew = False) { }

	// RVA: 0x2A0E8A0 Offset: 0x2A0E9A1 VA: 0x2A0E8A0
	protected void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A8900 Offset: 0x2A8A01 VA: 0x2A8900
	// RVA: 0x2A0E760 Offset: 0x2A0E861 VA: 0x2A0E760
	internal static void <FSMAdd_SyncEveryone>g__add|26_0(int side, SyncToken token) { }
}

