// Namespace: App
[Serializable]
public class CharacterIdSet // TypeDefIndex: 11913
{
	// Fields
	public string Pid; // 0x10
	public string Jid; // 0x18
	public string Sid; // 0x20
	public string Iid; // 0x28
	public int[] Position; // 0x30
	public int Lv; // 0x38
	public float Hp; // 0x3C
	public int Exp; // 0x40
	public bool IsEngage; // 0x44
	public bool IsMale; // 0x45
	[CompilerGeneratedAttribute] // RVA: 0x2999E0 Offset: 0x299AE1 VA: 0x2999E0
	private string[] <JobNameList>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x2999F0 Offset: 0x299AF1 VA: 0x2999F0
	private string[] <WeaponNameList>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x299A00 Offset: 0x299B01 VA: 0x299A00
	private string[] <SkillNameList>k__BackingField; // 0x58

	// Properties
	public string[] JobNameList { get; set; }
	public string[] WeaponNameList { get; set; }
	public string[] SkillNameList { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C70C0 Offset: 0x2C71C1 VA: 0x2C70C0
	// RVA: 0x2B7B280 Offset: 0x2B7B381 VA: 0x2B7B280
	public string[] get_JobNameList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C70D0 Offset: 0x2C71D1 VA: 0x2C70D0
	// RVA: 0x2B7B290 Offset: 0x2B7B391 VA: 0x2B7B290
	public void set_JobNameList(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C70E0 Offset: 0x2C71E1 VA: 0x2C70E0
	// RVA: 0x2B7B2A0 Offset: 0x2B7B3A1 VA: 0x2B7B2A0
	public string[] get_WeaponNameList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C70F0 Offset: 0x2C71F1 VA: 0x2C70F0
	// RVA: 0x2B7B2B0 Offset: 0x2B7B3B1 VA: 0x2B7B2B0
	public void set_WeaponNameList(string[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7100 Offset: 0x2C7201 VA: 0x2C7100
	// RVA: 0x2B7B2C0 Offset: 0x2B7B3C1 VA: 0x2B7B2C0
	public string[] get_SkillNameList() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7110 Offset: 0x2C7211 VA: 0x2C7110
	// RVA: 0x2B7B2D0 Offset: 0x2B7B3D1 VA: 0x2B7B2D0
	public void set_SkillNameList(string[] value) { }

	// RVA: 0x2B7B2E0 Offset: 0x2B7B3E1 VA: 0x2B7B2E0
	public int GetHash() { }

	// RVA: 0x2B7B480 Offset: 0x2B7B581 VA: 0x2B7B480
	public void Validate() { }

	// RVA: 0x2B7B520 Offset: 0x2B7B621 VA: 0x2B7B520
	public void SetupJobAndWeaponList(bool setRandom = False) { }

	// RVA: 0x2B7B8C0 Offset: 0x2B7B9C1 VA: 0x2B7B8C0
	public void SetupWeaponList(bool setRandom = False) { }

	// RVA: 0x2B7C090 Offset: 0x2B7C191 VA: 0x2B7C090
	public void SetupSkillList(bool setRandom = False) { }

	// RVA: 0x2B7C460 Offset: 0x2B7C561 VA: 0x2B7C460 Slot: 3
	public override string ToString() { }

	// RVA: 0x2B7C520 Offset: 0x2B7C621 VA: 0x2B7C520
	public void .ctor() { }
}

