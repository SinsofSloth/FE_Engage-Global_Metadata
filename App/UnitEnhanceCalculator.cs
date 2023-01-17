// Namespace: App
public class UnitEnhanceCalculator // TypeDefIndex: 13523
{
	// Fields
	private const int Version = 1;
	private const int MinValue = -20;
	private const int MaxValue = 20;
	private UnitEnhanceValues m_Values; // 0x10
	private UnitEnhanceValues m_Temps; // 0x18

	// Methods

	// RVA: 0x23DDB40 Offset: 0x23DDC41 VA: 0x23DDB40
	public void .ctor() { }

	// RVA: 0x23DDEB0 Offset: 0x23DDFB1 VA: 0x23DDEB0
	public void Commit1st(Unit unit, UnitItem equipped) { }

	// RVA: 0x23E01D0 Offset: 0x23E02D1 VA: 0x23E01D0
	public void Commit2nd(Unit unit) { }

	// RVA: 0x23E1100 Offset: 0x23E1201 VA: 0x23E1100
	public void Clear() { }

	// RVA: 0x23E12F0 Offset: 0x23E13F1 VA: 0x23E12F0
	public void Copy(UnitEnhanceCalculator enhance) { }

	// RVA: 0x23E14E0 Offset: 0x23E15E1 VA: 0x23E14E0
	public int Calculate(int index, int value) { }

	// RVA: 0x23E1560 Offset: 0x23E1661 VA: 0x23E1560
	private void AddImpl(CapabilitySbyte capability, bool isNotEnhance) { }

	// RVA: 0x23E1A90 Offset: 0x23E1B91 VA: 0x23E1A90
	private void MergeImpl(UnitEnhanceValues values, bool isNotEnhance) { }

	// RVA: 0x23E1C30 Offset: 0x23E1D31 VA: 0x23E1C30
	private bool AddImpl(Unit unit, SkillArray skills, SkillData.Flags mask, bool isNotEnhance) { }

	// RVA: 0x23E2740 Offset: 0x23E2841 VA: 0x23E2740
	public void Serialize(Stream stream) { }

	// RVA: 0x23E2930 Offset: 0x23E2A31 VA: 0x23E2930
	public void Deserialize(Stream stream) { }
}

