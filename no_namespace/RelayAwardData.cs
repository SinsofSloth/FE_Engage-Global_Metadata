// Namespace: 
public enum RelayAwardData.Kinds // TypeDefIndex: 10020
{
	// Fields
	public int value__; // 0x0
	public const RelayAwardData.Kinds Kill = 0;
	public const RelayAwardData.Kinds Damaged = 1;
	public const RelayAwardData.Kinds Heal = 2;
	public const RelayAwardData.Kinds Break = 3;
	public const RelayAwardData.Kinds Engage = 4;
	public const RelayAwardData.Kinds UseItem = 5;
	public const RelayAwardData.Kinds Poison = 6;
	public const RelayAwardData.Kinds Move = 7;
	public const RelayAwardData.Kinds Skill = 8;
	public const RelayAwardData.Kinds Damaged0 = 9;
	public const RelayAwardData.Kinds Critical = 10;
	public const RelayAwardData.Kinds Efficacy = 11;
	public const RelayAwardData.Kinds EngageAttack = 12;
	public const RelayAwardData.Kinds ChainGuard = 13;
	public const RelayAwardData.Kinds Blow = 14;
	public const RelayAwardData.Kinds DirectAttack = 15;
	public const RelayAwardData.Kinds IndirectAttack = 16;
	public const RelayAwardData.Kinds Attack = 17;
	public const RelayAwardData.Kinds ChainAttack = 18;
	public const RelayAwardData.Kinds MixedLeast = 19;
	public const RelayAwardData.Kinds MoveLeast = 20;
	public const RelayAwardData.Kinds DamageLeast = 21;
	public const RelayAwardData.Kinds Fixed = 22;
	public const RelayAwardData.Kinds Healed = 23;
	public const RelayAwardData.Kinds Skilled = 24;
	public const RelayAwardData.Kinds Num = 25;
}

// Namespace: 
public enum RelayAwardData.CompareOp // TypeDefIndex: 10021
{
	// Fields
	public int value__; // 0x0
	public const RelayAwardData.CompareOp Greater = 0;
	public const RelayAwardData.CompareOp Less = 1;
	public const RelayAwardData.CompareOp Zero = 2;
	public const RelayAwardData.CompareOp MixedLess = 3;
	public const RelayAwardData.CompareOp AttackGreaterKillLess = 4;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x276400 Offset: 0x276501 VA: 0x276400
public enum RelayAwardData.Flags // TypeDefIndex: 10022
{
	// Fields
	public int value__; // 0x0
	public const RelayAwardData.Flags Mixed = 1;
	public const RelayAwardData.Flags ShowCount = 2;
	public const RelayAwardData.Flags Negative = 4;
	public const RelayAwardData.Flags AttackPlus = 8;
	public const RelayAwardData.Flags AttackMinus = 16;
}

// Namespace: 
public sealed class RelayAwardData.FlagField : BitFieldTemplate32<RelayAwardData.Flags> // TypeDefIndex: 10023
{
	// Methods

	// RVA: 0x1F3DA20 Offset: 0x1F3DB21 VA: 0x1F3DA20
	public void .ctor(int f) { }

	// RVA: 0x1F3DA80 Offset: 0x1F3DB81 VA: 0x1F3DA80
	public void .ctor(RelayAwardData.Flags f) { }

	// RVA: 0x1F3DAE0 Offset: 0x1F3DBE1 VA: 0x1F3DAE0 Slot: 5
	protected override int ToInt(RelayAwardData.Flags value) { }
}

// Namespace: 
private struct RelayAwardData.Info // TypeDefIndex: 10024
{
	// Fields
	public string raid; // 0x0
	public UnitRecord.Kinds recordKind; // 0x8
	public RelayAwardData.CompareOp compareOp; // 0xC

	// Methods

	// RVA: 0x1F3DAF0 Offset: 0x1F3DBF1 VA: 0x1F3DAF0
	public void .ctor(string raid, UnitRecord.Kinds kind, RelayAwardData.CompareOp comp) { }
}

