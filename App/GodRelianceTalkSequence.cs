// Namespace: App
public class GodRelianceTalkSequence : CommonRelianceTalkSequence // TypeDefIndex: 12998
{
	// Fields
	private Unit m_Unit; // 0x80
	private string m_UnitAsciiName; // 0x88
	private GodUnit m_God; // 0x90
	private string m_GodAsciiName; // 0x98
	private GodData.RelianceLevel m_RelianceLevel; // 0xA0

	// Methods

	// RVA: 0x27A96D0 Offset: 0x27A97D1 VA: 0x27A96D0
	public static void CreateBind(ProcInst super, Unit unit, GodUnit god) { }

	// RVA: 0x27A9770 Offset: 0x27A9871 VA: 0x27A9770
	protected void .ctor(Unit unit, GodUnit god) { }

	// RVA: 0x27A9950 Offset: 0x27A9A51 VA: 0x27A9950 Slot: 18
	protected override string CreateMessFileName(bool isReverse) { }

	// RVA: 0x27A9A30 Offset: 0x27A9B31 VA: 0x27A9A30
	private string CreateMessFileName(string asciiNameA, string asciiNameB) { }

	// RVA: 0x27A9AB0 Offset: 0x27A9BB1 VA: 0x27A9AB0 Slot: 19
	protected override string CreateMid() { }

	// RVA: 0x27A9BA0 Offset: 0x27A9CA1 VA: 0x27A9BA0
	private string GetRelianceLevelText(GodData.RelianceLevel relianceLevel) { }

	// RVA: 0x27A9C40 Offset: 0x27A9D41 VA: 0x27A9C40 Slot: 20
	protected override void LevelUp() { }
}

