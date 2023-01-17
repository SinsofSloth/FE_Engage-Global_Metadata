// Namespace: App
public sealed class WeaponMask : BitFieldTemplate32<WeaponMask.Flag> // TypeDefIndex: 9959
{
	// Properties
	public bool Exist { get; }

	// Methods

	// RVA: 0x26CCA10 Offset: 0x26CCB11 VA: 0x26CCA10
	public void .ctor() { }

	// RVA: 0x26CCA70 Offset: 0x26CCB71 VA: 0x26CCA70
	public void .ctor(int f) { }

	// RVA: 0x26CCAD0 Offset: 0x26CCBD1 VA: 0x26CCAD0
	public void .ctor(WeaponMask.Flag f) { }

	// RVA: 0x26CCB30 Offset: 0x26CCC31 VA: 0x26CCB30 Slot: 5
	protected override int ToInt(WeaponMask.Flag value) { }

	// RVA: 0x26CCB40 Offset: 0x26CCC41 VA: 0x26CCB40
	public bool Test(ItemData item) { }

	// RVA: 0x26CCB60 Offset: 0x26CCC61 VA: 0x26CCB60
	public bool Test(ItemData.Kinds kind) { }

	// RVA: 0x26CCB70 Offset: 0x26CCC71 VA: 0x26CCB70
	public void Set(ItemData.Kinds kind) { }

	// RVA: 0x26CCB90 Offset: 0x26CCC91 VA: 0x26CCB90
	public void Clear(ItemData.Kinds kind) { }

	// RVA: 0x26CCBB0 Offset: 0x26CCCB1 VA: 0x26CCBB0
	public bool CanEquipFromKind(ItemData.Kinds kind) { }

	// RVA: 0x26CCBC0 Offset: 0x26CCCC1 VA: 0x26CCBC0
	public bool get_Exist() { }

	// RVA: 0x26CCBD0 Offset: 0x26CCCD1 VA: 0x26CCBD0
	public ItemData.Kinds GetRandomForArena() { }
}

