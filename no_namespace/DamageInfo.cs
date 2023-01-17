// Namespace: 
private class DamageInfo.Info // TypeDefIndex: 11789
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x299270 Offset: 0x299371 VA: 0x299270
	private Unit <Unit>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x299280 Offset: 0x299381 VA: 0x299280
	private SkillData <Skill>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x299290 Offset: 0x299391 VA: 0x299290
	private int <Damage>k__BackingField; // 0x20

	// Properties
	public Unit Unit { get; set; }
	public SkillData Skill { get; set; }
	public int Damage { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C6A30 Offset: 0x2C6B31 VA: 0x2C6A30
	// RVA: 0x1E0DD80 Offset: 0x1E0DE81 VA: 0x1E0DD80
	public Unit get_Unit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6A40 Offset: 0x2C6B41 VA: 0x2C6A40
	// RVA: 0x1E0DD90 Offset: 0x1E0DE91 VA: 0x1E0DD90
	public void set_Unit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6A50 Offset: 0x2C6B51 VA: 0x2C6A50
	// RVA: 0x1E0DDA0 Offset: 0x1E0DEA1 VA: 0x1E0DDA0
	public SkillData get_Skill() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6A60 Offset: 0x2C6B61 VA: 0x2C6A60
	// RVA: 0x1E0DDB0 Offset: 0x1E0DEB1 VA: 0x1E0DDB0
	public void set_Skill(SkillData value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6A70 Offset: 0x2C6B71 VA: 0x2C6A70
	// RVA: 0x1E0DDC0 Offset: 0x1E0DEC1 VA: 0x1E0DDC0
	public int get_Damage() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6A80 Offset: 0x2C6B81 VA: 0x2C6A80
	// RVA: 0x1E0DDD0 Offset: 0x1E0DED1 VA: 0x1E0DDD0
	public void set_Damage(int value) { }

	// RVA: 0x1E0DDE0 Offset: 0x1E0DEE1 VA: 0x1E0DDE0
	public void .ctor() { }
}

// Namespace: 
private class DamageInfo.InfoWindow // TypeDefIndex: 11790
{
	// Fields
	private bool m_IsShow; // 0x10
	private DamageInfo.Info m_Info; // 0x18
	private GameObject m_RootObject; // 0x20
	private Image m_WindowImage; // 0x28
	private UnitIcon m_UnitIcon; // 0x30
	private Image m_SkillIconImage; // 0x38
	private TextMeshProUGUI m_UnitNameText; // 0x40
	private TextMeshProUGUI m_SkillNameText; // 0x48
	private TextMeshProUGUI m_DamageText; // 0x50

	// Methods

	// RVA: 0x1E0DE10 Offset: 0x1E0DF11 VA: 0x1E0DE10
	public bool IsShow() { }

	// RVA: 0x1E0DEC0 Offset: 0x1E0DFC1 VA: 0x1E0DEC0
	public void .ctor(GameObject rootObject) { }

	// RVA: 0x1E0E180 Offset: 0x1E0E281 VA: 0x1E0E180
	public void Tick() { }

	// RVA: 0x1E0E230 Offset: 0x1E0E331 VA: 0x1E0E230
	public void SetInfo(DamageInfo.Info info) { }
}

// Namespace: 
private class DamageInfo.InfoComparer : IComparer<DamageInfo.Info> // TypeDefIndex: 11791
{
	// Methods

	// RVA: 0x1E0DDF0 Offset: 0x1E0DEF1 VA: 0x1E0DDF0 Slot: 4
	public int Compare(DamageInfo.Info a, DamageInfo.Info b) { }

	// RVA: 0x1E0DE00 Offset: 0x1E0DF01 VA: 0x1E0DE00
	public void .ctor() { }
}

