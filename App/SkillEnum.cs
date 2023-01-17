// Namespace: App
public struct SkillEnum : IDisposable // TypeDefIndex: 13481
{
	// Fields
	private SkillArray m_Array; // 0x0
	private SkillData.TimingMasks m_Mask; // 0x8
	private static List<SkillData> s_SkillList; // 0x0

	// Methods

	// RVA: 0x27DAD40 Offset: 0x27DAE41 VA: 0x27DAD40
	private void .ctor(SkillArray array, SkillData.TimingMasks mask) { }

	// RVA: 0x27DAD70 Offset: 0x27DAE71 VA: 0x27DAD70
	public static SkillEnum Get(SkillArray array, SkillData.TimingMasks mask = 1048575) { }

	// RVA: 0x27DADB0 Offset: 0x27DAEB1 VA: 0x27DADB0
	public static SkillEnum Get(Unit unit, SkillData.TimingMasks mask = 1048575) { }

	// RVA: 0x27DADF0 Offset: 0x27DAEF1 VA: 0x27DADF0
	public static SkillEnum Get(SkillArray array, SkillData.Timings timing) { }

	// RVA: 0x27DAE80 Offset: 0x27DAF81 VA: 0x27DAE80
	public static SkillEnum Get(Unit unit, SkillData.Timings timing) { }

	// RVA: 0x27DAF10 Offset: 0x27DB011 VA: 0x27DAF10
	public static SkillEnum GetSupports(SkillArray array) { }

	// RVA: 0x27DB000 Offset: 0x27DB101 VA: 0x27DB000
	public static SkillEnum GetSupports(Unit unit) { }

	// RVA: 0x27DB0F0 Offset: 0x27DB1F1 VA: 0x27DB0F0
	public SkillEnum.Enumerator GetEnumerator() { }

	// RVA: 0x27DB190 Offset: 0x27DB291 VA: 0x27DB190 Slot: 4
	public void Dispose() { }

	// RVA: 0x27DB1A0 Offset: 0x27DB2A1 VA: 0x27DB1A0
	public List<SkillData> GetUnsafeList() { }

	// RVA: 0x27DB390 Offset: 0x27DB491 VA: 0x27DB390
	private static void .cctor() { }
}

