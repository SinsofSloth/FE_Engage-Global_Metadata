// Namespace: Combat
public class EngageSequence : ProcInst // TypeDefIndex: 8741
{
	// Fields
	private EngageSequence.Cast m_Master; // 0x70
	private EngageSequence.Cast m_Grandew; // 0x78
	[TupleElementNamesAttribute] // RVA: 0x284080 Offset: 0x284181 VA: 0x284080
	private ValueTuple<PreloadAnims, int> m_EngageType; // 0x80
	private GameObject m_CamGO; // 0x90
	private bool m_bSetupDone; // 0x98
	private bool m_bSkipped; // 0x99

	// Methods

	// RVA: 0x2604150 Offset: 0x2604251 VA: 0x2604150
	public static EngageSequence.Mode GetMode() { }

	// RVA: 0x26041F0 Offset: 0x26042F1 VA: 0x26041F0
	public static bool IsExist() { }

	// RVA: 0x2604270 Offset: 0x2604371 VA: 0x2604270
	public static void CreateBind(ProcInst super, Unit unit1, Unit unit2) { }

	// RVA: 0x2604B50 Offset: 0x2604C51 VA: 0x2604B50
	private void CreteaCombatBorders() { }

	// RVA: 0x2604BF0 Offset: 0x2604CF1 VA: 0x2604BF0
	private void DeleteCombatBorders() { }

	// RVA: 0x2604C90 Offset: 0x2604D91 VA: 0x2604C90
	private bool IsSetupDone() { }

	[IteratorStateMachineAttribute] // RVA: 0x2AC5C0 Offset: 0x2AC6C1 VA: 0x2AC5C0
	// RVA: 0x2604CA0 Offset: 0x2604DA1 VA: 0x2604CA0
	private IEnumerator WaitFinish() { }

	// RVA: 0x2604930 Offset: 0x2604A31 VA: 0x2604930
	public void .ctor(Unit unit1, Unit unit2) { }

	[IteratorStateMachineAttribute] // RVA: 0x2AC630 Offset: 0x2AC731 VA: 0x2AC630
	// RVA: 0x2604D20 Offset: 0x2604E21 VA: 0x2604D20
	private IEnumerator LoadAndSetupAndRun() { }

	// RVA: 0x2604DA0 Offset: 0x2604EA1 VA: 0x2604DA0
	private float CalcHeightOffset(Character c, Character g) { }

	[IteratorStateMachineAttribute] // RVA: 0x2AC6A0 Offset: 0x2AC7A1 VA: 0x2AC6A0
	// RVA: 0x2604ED0 Offset: 0x2604FD1 VA: 0x2604ED0
	private IEnumerator Exit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC710 Offset: 0x2AC811 VA: 0x2AC710
	// RVA: 0x2604F50 Offset: 0x2605051 VA: 0x2604F50
	private void <LoadAndSetupAndRun>g__func|16_0(Character a) { }
}

