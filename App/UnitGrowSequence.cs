// Namespace: App
public class UnitGrowSequence : ProcInst // TypeDefIndex: 13000
{
	// Fields
	private ViewMode.Mode m_CameraMode; // 0x70
	private Unit m_Unit; // 0x78
	private int m_Exp; // 0x80
	private int m_OldLevel; // 0x84
	private bool m_IsTalk; // 0x88
	private int m_SkillPoint; // 0x8C
	private JobData m_ClassChangeJob; // 0x90
	private ItemData m_ClassChangeItem; // 0x98
	private WeaponMask m_ClassChangeWeaponMask; // 0xA0
	private ItemData m_ClassChangeWeapon; // 0xA8

	// Methods

	// RVA: 0x23E7CE0 Offset: 0x23E7DE1 VA: 0x23E7CE0
	public void setUnitGrowData(BattleInfoSide side, bool isTalk) { }

	// RVA: 0x23E7E00 Offset: 0x23E7F01 VA: 0x23E7E00
	public void setUnitGrowData(Unit unit, int exp) { }

	// RVA: 0x23E7DB0 Offset: 0x23E7EB1 VA: 0x23E7DB0
	public void setUnitGrowData(Unit unit, int exp, int skillPoint, bool isTalk = True) { }

	// RVA: 0x23E7E60 Offset: 0x23E7F61 VA: 0x23E7E60
	public void setUnitClassChange(Unit unit, JobData job, ItemData item) { }

	// RVA: 0x23E7ED0 Offset: 0x23E7FD1 VA: 0x23E7ED0
	public void setUnitClassChange(Unit unit, ClassChange.ChangeJobData data) { }

	// RVA: 0x23E7F30 Offset: 0x23E8031 VA: 0x23E7F30
	public static UnitGrowSequence CreateBind(ProcInst super) { }

	// RVA: 0x23E8580 Offset: 0x23E8681 VA: 0x23E8580
	private void Prepare() { }

	// RVA: 0x23E86D0 Offset: 0x23E87D1 VA: 0x23E86D0
	private void GainExp() { }

	// RVA: 0x23E8730 Offset: 0x23E8831 VA: 0x23E8730
	private void CheckLevelUp() { }

	// RVA: 0x23E87C0 Offset: 0x23E88C1 VA: 0x23E87C0
	private void LevelUp() { }

	// RVA: 0x23E8860 Offset: 0x23E8961 VA: 0x23E8860
	private void CheckClassChange() { }

	// RVA: 0x23E88F0 Offset: 0x23E89F1 VA: 0x23E88F0
	private void ClassChange() { }

	// RVA: 0x23E8EE0 Offset: 0x23E8FE1 VA: 0x23E8EE0
	private void SetWeapon() { }

	// RVA: 0x23E8570 Offset: 0x23E8671 VA: 0x23E8570
	public void .ctor() { }
}

