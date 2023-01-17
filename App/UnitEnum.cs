// Namespace: App
internal struct UnitEnum // TypeDefIndex: 13531
{
	// Fields
	private static readonly UnitEnum s_OnMapForce; // 0x0
	private static readonly UnitEnum s_UsedForce; // 0x8
	private static readonly UnitEnum s_F1stForce; // 0x10
	private static readonly UnitEnum s_F2ndForce; // 0x18
	private static readonly UnitEnum s_F3rdForce; // 0x20
	private static readonly UnitEnum s_SortieForce; // 0x28
	private static readonly UnitEnum s_AbsentForce; // 0x30
	private static readonly UnitEnum s_DeadForce; // 0x38
	private static readonly UnitEnum s_LostForce; // 0x40
	private static readonly UnitEnum s_Temporary; // 0x48
	private static readonly UnitEnum s_SamePlayerForce; // 0x50
	private static readonly UnitEnum s_F1and2Force; // 0x58
	private static readonly UnitEnum s_F2and3Force; // 0x60
	private static readonly UnitEnum s_F1and3Force; // 0x68
	private static readonly UnitEnum s_NullForce; // 0x70
	private static readonly UnitEnum.TargetEnumerator s_TargetEnumerator; // 0x78
	private static readonly UnitEnum[] s_ForceMask; // 0xB8
	private Force.Type[] m_Types; // 0x0

	// Methods

	// RVA: 0x23E5D10 Offset: 0x23E5E11 VA: 0x23E5D10
	public static UnitEnum GetEnumerator(Force.Type[] types) { }

	// RVA: 0x23E5D40 Offset: 0x23E5E41 VA: 0x23E5D40
	public static UnitEnum GetOnMapForce() { }

	// RVA: 0x23E5DB0 Offset: 0x23E5EB1 VA: 0x23E5DB0
	public static UnitEnum GetEnemy(Force.Type force) { }

	// RVA: 0x23E6080 Offset: 0x23E6181 VA: 0x23E6080
	public static UnitEnum GetAlly(Force.Type force) { }

	// RVA: 0x23E6320 Offset: 0x23E6421 VA: 0x23E6320
	public static UnitEnum GetMask(uint mask) { }

	// RVA: 0x23E6420 Offset: 0x23E6521 VA: 0x23E6420
	public static UnitEnum GetOnSortieForce() { }

	// RVA: 0x23E6490 Offset: 0x23E6591 VA: 0x23E6490
	public static UnitEnum GetUsedForce() { }

	// RVA: 0x23E6500 Offset: 0x23E6601 VA: 0x23E6500
	public static UnitEnum GetSelfForce() { }

	// RVA: 0x23E6770 Offset: 0x23E6871 VA: 0x23E6770
	public static UnitEnum GetSamePlayerForce() { }

	// RVA: 0x23E67E0 Offset: 0x23E68E1 VA: 0x23E67E0
	public static UnitEnum Get(Force.Type type) { }

	// RVA: 0x23E6A00 Offset: 0x23E6B01 VA: 0x23E6A00
	public static UnitEnum.TargetEnumerator GetTarget(Unit unit, int near, int far) { }

	// RVA: 0x23E6C00 Offset: 0x23E6D01 VA: 0x23E6C00
	public static UnitEnum.TargetEnumerator GetTarget(Unit unit, SkillData skill) { }

	// RVA: 0x23E6E00 Offset: 0x23E6F01 VA: 0x23E6E00
	public static UnitEnum.TargetEnumerator GetTarget(Unit unit, int x, int z, int near, int far) { }

	// RVA: 0x23E7000 Offset: 0x23E7101 VA: 0x23E7000
	private void .ctor(Force.Type[] types) { }

	// RVA: 0x23E7010 Offset: 0x23E7111 VA: 0x23E7010
	public UnitEnum.Enumerator GetEnumerator() { }

	// RVA: 0x23E7030 Offset: 0x23E7131 VA: 0x23E7030
	private static void .cctor() { }
}

