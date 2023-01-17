// Namespace: App
internal class RelayAppearanceSequence : SingletonProcInst<RelayAppearanceSequence> // TypeDefIndex: 12942
{
	// Fields
	private int m_Index; // 0x74
	private Unit m_Unit; // 0x78
	private int[] m_ReplayAppearanceIndexes; // 0x80
	private int[] m_ReplayLeavingIndexes; // 0x88

	// Methods

	// RVA: 0x253B850 Offset: 0x253B951 VA: 0x253B850
	public void .ctor() { }

	// RVA: 0x253B8F0 Offset: 0x253B9F1 VA: 0x253B8F0
	public void .ctor(int[] appearanceIndexes, int[] leavingIndexes) { }

	// RVA: 0x253B9A0 Offset: 0x253BAA1 VA: 0x253B9A0
	private void LeavingBegin() { }

	// RVA: 0x253BBD0 Offset: 0x253BCD1 VA: 0x253BBD0
	private void Leaving() { }

	// RVA: 0x253BD10 Offset: 0x253BE11 VA: 0x253BD10
	private void LeavingNext() { }

	// RVA: 0x253BDF0 Offset: 0x253BEF1 VA: 0x253BDF0
	private void AppearanceBegin() { }

	// RVA: 0x253BF60 Offset: 0x253C061 VA: 0x253BF60
	private void Appearance() { }

	// RVA: 0x253C070 Offset: 0x253C171 VA: 0x253C070
	private void AppearanceNext() { }

	// RVA: 0x253C110 Offset: 0x253C211 VA: 0x253C110
	private void FocusUnit() { }

	// RVA: 0x253BA80 Offset: 0x253BB81 VA: 0x253BA80
	private Unit GetLeavingUnit(int index) { }

	// RVA: 0x253BEA0 Offset: 0x253BFA1 VA: 0x253BEA0
	private Unit GetAppearanceUnit(int index) { }

	// RVA: 0x253C190 Offset: 0x253C291 VA: 0x253C190
	public static void CreateBindTakeOver(ProcInst super) { }

	// RVA: 0x253CA70 Offset: 0x253CB71 VA: 0x253CA70
	public static void CreateBindReplay(ProcInst super) { }

	// RVA: 0x253C3C0 Offset: 0x253C4C1 VA: 0x253C3C0
	private static void CreateBindCommon(RelayAppearanceSequence p, ProcInst super) { }
}

