// Namespace: 
[FlagsAttribute] // RVA: 0x2763D0 Offset: 0x2764D1 VA: 0x2763D0
public enum PersonData.Flags // TypeDefIndex: 9990
{
	// Fields
	public int value__; // 0x0
	public const PersonData.Flags CandidateForFriend = 1;
	public const PersonData.Flags BelongName = 2;
	public const PersonData.Flags Talent = 4;
	public const PersonData.Flags IgnoreJobSkillRemove = 8;
	public const PersonData.Flags DarkWarp = 16;
	public const PersonData.Flags DressReverse = 32;
	public const PersonData.Flags SimpleUI = 64;
	public const PersonData.Flags DerivedHero = 128;
	public const PersonData.Flags SummonWarp = 256;
}

// Namespace: 
public sealed class PersonData.FlagField : BitFieldTemplate32<PersonData.Flags> // TypeDefIndex: 9991
{
	// Methods

	// RVA: 0x1F1C840 Offset: 0x1F1C941 VA: 0x1F1C840
	public void .ctor(int f) { }

	// RVA: 0x1F1C8A0 Offset: 0x1F1C9A1 VA: 0x1F1C8A0
	public void .ctor(PersonData.Flags f) { }

	// RVA: 0x1F1C900 Offset: 0x1F1CA01 VA: 0x1F1C900 Slot: 5
	protected override int ToInt(PersonData.Flags value) { }
}

// Namespace: 
public enum PersonData.Country // TypeDefIndex: 9992
{
	// Fields
	public int value__; // 0x0
	public const PersonData.Country Free = 0;
	public const PersonData.Country Lithos = 1;
	public const PersonData.Country Filene = 2;
	public const PersonData.Country Brodia = 3;
	public const PersonData.Country Ircion = 4;
	public const PersonData.Country Solum = 5;
	public const PersonData.Country Gradlon = 6;
}

// Namespace: 
public enum PersonData.Timing // TypeDefIndex: 9993
{
	// Fields
	public int value__; // 0x0
	public const PersonData.Timing None = 0;
	public const PersonData.Timing Begin = 1;
	public const PersonData.Timing End = 2;
	public const PersonData.Timing Chapter = 3;
	public const PersonData.Timing Eternal = 4;
}

// Namespace: 
public enum PersonData.Colors // TypeDefIndex: 9994
{
	// Fields
	public int value__; // 0x0
	public const PersonData.Colors None = 0;
	public const PersonData.Colors Red = 1;
	public const PersonData.Colors Green = 2;
	public const PersonData.Colors Blue = 3;
}

// Namespace: 
public enum PersonData.Ranks // TypeDefIndex: 9995
{
	// Fields
	public int value__; // 0x0
	public const PersonData.Ranks None = 0;
	public const PersonData.Ranks Rank1 = 1;
	public const PersonData.Ranks Rank2 = 2;
	public const PersonData.Ranks Rank3 = 3;
}

