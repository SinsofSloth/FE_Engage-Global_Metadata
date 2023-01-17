// Namespace: App
public class SortieSkillEditManager : SingletonClass<SortieSkillEditManager> // TypeDefIndex: 13181
{
	// Fields
	private SkillEditEquipSkillMenu m_EquipSkillMenu; // 0x20
	private SkillEditPoolSkillMenu m_PoolSkillMenu; // 0x28
	private GameObject m_SkillInfo; // 0x30
	private GameObject m_SkillInfoRoot; // 0x38
	private SortieSkillEditManager.Modes m_Mode; // 0x40

	// Properties
	public SkillEditEquipSkillMenu EquipSkillMenu { get; set; }
	public SkillEditPoolSkillMenu PoolSkillMenu { get; set; }
	public GameObject SkillInfo { get; set; }
	public GameObject SkillInfoRoot { get; set; }
	public SortieSkillEditManager.Modes Mode { get; set; }

	// Methods

	// RVA: 0x216E5F0 Offset: 0x216E6F1 VA: 0x216E5F0
	public void .ctor() { }

	// RVA: 0x21645D0 Offset: 0x21646D1 VA: 0x21645D0
	public void Reset() { }

	// RVA: 0x216E6C0 Offset: 0x216E7C1 VA: 0x216E6C0
	public void UpdateMenu() { }

	// RVA: 0x216E720 Offset: 0x216E821 VA: 0x216E720
	public void SetSkillInfo(SkillData skill, bool isInheritance = True) { }

	// RVA: 0x216EB30 Offset: 0x216EC31 VA: 0x216EB30
	public SkillEditEquipSkillMenu get_EquipSkillMenu() { }

	// RVA: 0x216EB40 Offset: 0x216EC41 VA: 0x216EB40
	public void set_EquipSkillMenu(SkillEditEquipSkillMenu value) { }

	// RVA: 0x216EB50 Offset: 0x216EC51 VA: 0x216EB50
	public SkillEditPoolSkillMenu get_PoolSkillMenu() { }

	// RVA: 0x216EB60 Offset: 0x216EC61 VA: 0x216EB60
	public void set_PoolSkillMenu(SkillEditPoolSkillMenu value) { }

	// RVA: 0x216EB70 Offset: 0x216EC71 VA: 0x216EB70
	public GameObject get_SkillInfo() { }

	// RVA: 0x216EB80 Offset: 0x216EC81 VA: 0x216EB80
	public void set_SkillInfo(GameObject value) { }

	// RVA: 0x216EB90 Offset: 0x216EC91 VA: 0x216EB90
	public GameObject get_SkillInfoRoot() { }

	// RVA: 0x216EBA0 Offset: 0x216ECA1 VA: 0x216EBA0
	public void set_SkillInfoRoot(GameObject value) { }

	// RVA: 0x216EBB0 Offset: 0x216ECB1 VA: 0x216EBB0
	public SortieSkillEditManager.Modes get_Mode() { }

	// RVA: 0x216EBC0 Offset: 0x216ECC1 VA: 0x216EBC0
	public void set_Mode(SortieSkillEditManager.Modes value) { }

	// RVA: 0x216EBD0 Offset: 0x216ECD1 VA: 0x216EBD0
	public bool IsTrade() { }

	// RVA: 0x216EBE0 Offset: 0x216ECE1 VA: 0x216EBE0
	public void SetTrade() { }

	// RVA: 0x216EBF0 Offset: 0x216ECF1 VA: 0x216EBF0
	public void ResetMode() { }

	// RVA: 0x216EA00 Offset: 0x216EB01 VA: 0x216EA00
	public bool IsInheritanceSkillDouble(Unit unit, SkillData skill) { }
}

