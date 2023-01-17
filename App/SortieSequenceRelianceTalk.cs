// Namespace: App
public class SortieSequenceRelianceTalk : CommonRelianceTalkSequence // TypeDefIndex: 13359
{
	// Fields
	private Unit m_UnitA; // 0x80
	private string m_AsciiNameA; // 0x88
	private Unit m_UnitB; // 0x90
	private string m_AsciiNameB; // 0x98

	// Methods

	// RVA: 0x2161C50 Offset: 0x2161D51 VA: 0x2161C50
	public static void CreateBind(ProcInst super, Unit unitA, Unit unitB) { }

	// RVA: 0x2161FD0 Offset: 0x21620D1 VA: 0x2161FD0
	private void .ctor(Unit unitA, Unit unitB) { }

	// RVA: 0x2162060 Offset: 0x2162161 VA: 0x2162060 Slot: 18
	protected override string CreateMessFileName(bool isReverse) { }

	// RVA: 0x2162140 Offset: 0x2162241 VA: 0x2162140
	private string CreateMessFileName(string asciiNameA, string asciiNameB) { }

	// RVA: 0x21621C0 Offset: 0x21622C1 VA: 0x21621C0 Slot: 19
	protected override string CreateMid() { }

	// RVA: 0x21622D0 Offset: 0x21623D1 VA: 0x21622D0
	private string GetRelianceLevelText(RelianceData.Level relianceLevel) { }

	// RVA: 0x2162370 Offset: 0x2162471 VA: 0x2162370 Slot: 20
	protected override void LevelUp() { }
}

