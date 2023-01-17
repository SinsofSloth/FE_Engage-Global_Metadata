// Namespace: 
[FlagsAttribute] // RVA: 0x2762D0 Offset: 0x2763D1 VA: 0x2762D0
public enum JobData.Flags // TypeDefIndex: 9963
{
	// Fields
	public int value__; // 0x0
	public const JobData.Flags CanCC = 1;
	public const JobData.Flags AnyoneCC = 2;
	public const JobData.Flags FemaleOnly = 4;
	public const JobData.Flags EncountMap = 8;
}

// Namespace: 
public sealed class JobData.FlagField : BitFieldTemplate32<JobData.Flags> // TypeDefIndex: 9964
{
	// Methods

	// RVA: 0x222B7C0 Offset: 0x222B8C1 VA: 0x222B7C0
	public void .ctor(int f) { }

	// RVA: 0x222B820 Offset: 0x222B921 VA: 0x222B820
	public void .ctor(JobData.Flags f) { }

	// RVA: 0x222B880 Offset: 0x222B981 VA: 0x222B880 Slot: 5
	protected override int ToInt(JobData.Flags value) { }
}

// Namespace: 
public enum JobData.Ranks // TypeDefIndex: 9965
{
	// Fields
	public int value__; // 0x0
	public const JobData.Ranks Low = 0;
	public const JobData.Ranks High = 1;
}

// Namespace: 
public enum JobData.MoveTypes // TypeDefIndex: 9966
{
	// Fields
	public int value__; // 0x0
	public const JobData.MoveTypes None = 0;
	public const JobData.MoveTypes Foot = 1;
	public const JobData.MoveTypes Horse = 2;
	public const JobData.MoveTypes Fly = 3;
	public const JobData.MoveTypes Dragon = 4;
	public const JobData.MoveTypes Pad = 5;
	public const JobData.MoveTypes Num = 6;
}

// Namespace: 
public enum JobData.WeaponValues // TypeDefIndex: 9967
{
	// Fields
	public int value__; // 0x0
	public const JobData.WeaponValues None = 0;
	public const JobData.WeaponValues Equippable = 1;
	public const JobData.WeaponValues Selectable1 = 2;
	public const JobData.WeaponValues Selectable2 = 3;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2762E0 Offset: 0x2763E1 VA: 0x2762E0
private struct JobData.<>c__DisplayClass229_0 // TypeDefIndex: 9968
{
	// Fields
	public WeaponMask weaponMask; // 0x0
	public JobData <>4__this; // 0x8
	public WeaponMask originalAptitude; // 0x10
	public int maxLevel; // 0x18
	public List<ItemData.Kinds> resultList; // 0x20
}

