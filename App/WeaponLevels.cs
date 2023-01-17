// Namespace: App
[DefaultMemberAttribute] // RVA: 0x279030 Offset: 0x279131 VA: 0x279030
public sealed class WeaponLevels // TypeDefIndex: 13554
{
	// Fields
	private sbyte[] m_Levels; // 0x10

	// Properties
	public sbyte None { get; set; }
	public sbyte Sword { get; set; }
	public sbyte Lance { get; set; }
	public sbyte Axe { get; set; }
	public sbyte Bow { get; set; }
	public sbyte Dagger { get; set; }
	public sbyte Magic { get; set; }
	public sbyte Rod { get; set; }
	public sbyte Fist { get; set; }
	public sbyte Special { get; set; }
	public WeaponLevel.Kind Item { get; set; }

	// Methods

	// RVA: 0x26CBF70 Offset: 0x26CC071 VA: 0x26CBF70
	public sbyte get_None() { }

	// RVA: 0x26CBFE0 Offset: 0x26CC0E1 VA: 0x26CBFE0
	private void set_None(sbyte value) { }

	// RVA: 0x26CC050 Offset: 0x26CC151 VA: 0x26CC050
	public sbyte get_Sword() { }

	// RVA: 0x26CC080 Offset: 0x26CC181 VA: 0x26CC080
	private void set_Sword(sbyte value) { }

	// RVA: 0x26CC0B0 Offset: 0x26CC1B1 VA: 0x26CC0B0
	public sbyte get_Lance() { }

	// RVA: 0x26CC0E0 Offset: 0x26CC1E1 VA: 0x26CC0E0
	private void set_Lance(sbyte value) { }

	// RVA: 0x26CC110 Offset: 0x26CC211 VA: 0x26CC110
	public sbyte get_Axe() { }

	// RVA: 0x26CC140 Offset: 0x26CC241 VA: 0x26CC140
	private void set_Axe(sbyte value) { }

	// RVA: 0x26CC170 Offset: 0x26CC271 VA: 0x26CC170
	public sbyte get_Bow() { }

	// RVA: 0x26CC1A0 Offset: 0x26CC2A1 VA: 0x26CC1A0
	private void set_Bow(sbyte value) { }

	// RVA: 0x26CC1D0 Offset: 0x26CC2D1 VA: 0x26CC1D0
	public sbyte get_Dagger() { }

	// RVA: 0x26CC200 Offset: 0x26CC301 VA: 0x26CC200
	private void set_Dagger(sbyte value) { }

	// RVA: 0x26CC230 Offset: 0x26CC331 VA: 0x26CC230
	public sbyte get_Magic() { }

	// RVA: 0x26CC260 Offset: 0x26CC361 VA: 0x26CC260
	private void set_Magic(sbyte value) { }

	// RVA: 0x26CC290 Offset: 0x26CC391 VA: 0x26CC290
	public sbyte get_Rod() { }

	// RVA: 0x26CC2C0 Offset: 0x26CC3C1 VA: 0x26CC2C0
	private void set_Rod(sbyte value) { }

	// RVA: 0x26CC2F0 Offset: 0x26CC3F1 VA: 0x26CC2F0
	public sbyte get_Fist() { }

	// RVA: 0x26CC320 Offset: 0x26CC421 VA: 0x26CC320
	private void set_Fist(sbyte value) { }

	// RVA: 0x26CC350 Offset: 0x26CC451 VA: 0x26CC350
	public sbyte get_Special() { }

	// RVA: 0x26CC380 Offset: 0x26CC481 VA: 0x26CC380
	private void set_Special(sbyte value) { }

	// RVA: 0x26CC010 Offset: 0x26CC111 VA: 0x26CC010
	private void SetImpl(ItemData.Kinds kind, sbyte value) { }

	// RVA: 0x26CBFA0 Offset: 0x26CC0A1 VA: 0x26CBFA0
	private sbyte GetImpl(ItemData.Kinds kind) { }

	// RVA: 0x26CC3B0 Offset: 0x26CC4B1 VA: 0x26CC3B0
	public WeaponLevel.Kind get_Item(ItemData.Kinds kind) { }

	// RVA: 0x26CC3F0 Offset: 0x26CC4F1 VA: 0x26CC3F0
	public void set_Item(ItemData.Kinds kind, WeaponLevel.Kind value) { }

	// RVA: 0x26CC430 Offset: 0x26CC531 VA: 0x26CC430
	public void Clear() { }

	// RVA: 0x26CC520 Offset: 0x26CC621 VA: 0x26CC520
	public void Copy(WeaponLevels src) { }

	// RVA: 0x26CC6E0 Offset: 0x26CC7E1 VA: 0x26CC6E0
	public void Add(WeaponLevels levels) { }

	// RVA: 0x26CC9A0 Offset: 0x26CCAA1 VA: 0x26CC9A0
	public void .ctor() { }
}

