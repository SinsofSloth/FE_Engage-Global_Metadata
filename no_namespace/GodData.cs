// Namespace: 
public enum GodData.RelianceLevel // TypeDefIndex: 9904
{
	// Fields
	public int value__; // 0x0
	public const GodData.RelianceLevel D = 0;
	public const GodData.RelianceLevel C = 1;
	public const GodData.RelianceLevel B = 2;
	public const GodData.RelianceLevel A = 3;
	public const GodData.RelianceLevel S = 4;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x2761A0 Offset: 0x2762A1 VA: 0x2761A0
public enum GodData.Flags // TypeDefIndex: 9905
{
	// Fields
	public int value__; // 0x0
	public const GodData.Flags NoAddExp = 1;
	public const GodData.Flags EnableRingList = 2;
	public const GodData.Flags UnitIconDarkness = 4;
	public const GodData.Flags GaugeDarkness = 8;
	public const GodData.Flags OnlyEngageWeapon = 16;
	public const GodData.Flags Armlet = 32;
	public const GodData.Flags Hero = -2147483648;
}

// Namespace: 
public sealed class GodData.FlagField : BitFieldTemplate32<GodData.Flags> // TypeDefIndex: 9906
{
	// Methods

	// RVA: 0x1FA00F0 Offset: 0x1FA01F1 VA: 0x1FA00F0
	public void .ctor(int f) { }

	// RVA: 0x1FA0150 Offset: 0x1FA0251 VA: 0x1FA0150
	public void .ctor(GodData.Flags f) { }

	// RVA: 0x1FA01B0 Offset: 0x1FA02B1 VA: 0x1FA01B0 Slot: 5
	protected override int ToInt(GodData.Flags value) { }
}

// Namespace: 
public enum GodData.AIEngageAttackTypes // TypeDefIndex: 9907
{
	// Fields
	public int value__; // 0x0
	public const GodData.AIEngageAttackTypes None = 0;
	public const GodData.AIEngageAttackTypes Attack = 1;
	public const GodData.AIEngageAttackTypes AttackPierce = 2;
	public const GodData.AIEngageAttackTypes AttackCharge = 3;
	public const GodData.AIEngageAttackTypes Heal = 4;
	public const GodData.AIEngageAttackTypes Dance = 5;
	public const GodData.AIEngageAttackTypes Bless = 6;
	public const GodData.AIEngageAttackTypes AttackWait = 7;
	public const GodData.AIEngageAttackTypes Overlap = 8;
	public const GodData.AIEngageAttackTypes Summon = 9;
}

