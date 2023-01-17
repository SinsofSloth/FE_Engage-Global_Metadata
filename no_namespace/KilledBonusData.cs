// Namespace: 
public enum KilledBonusData.Kinds // TypeDefIndex: 9976
{
	// Fields
	public int value__; // 0x0
	public const KilledBonusData.Kinds None = 0;
	public const KilledBonusData.Kinds PieceOfBond = 1;
	public const KilledBonusData.Kinds Exp = 2;
	public const KilledBonusData.Kinds EngageCount = 3;
	public const KilledBonusData.Kinds GodExp = 4;
}

// Namespace: 
[FlagsAttribute] // RVA: 0x276300 Offset: 0x276401 VA: 0x276300
public enum KilledBonusData.Flags // TypeDefIndex: 9977
{
	// Fields
	public int value__; // 0x0
	public const KilledBonusData.Flags God = 1;
}

// Namespace: 
public sealed class KilledBonusData.FlagField : BitFieldTemplate32<KilledBonusData.Flags> // TypeDefIndex: 9978
{
	// Methods

	// RVA: 0x222DB30 Offset: 0x222DC31 VA: 0x222DB30
	public void .ctor(int f) { }

	// RVA: 0x222DB90 Offset: 0x222DC91 VA: 0x222DB90
	public void .ctor(KilledBonusData.Flags f) { }

	// RVA: 0x222DBF0 Offset: 0x222DCF1 VA: 0x222DBF0 Slot: 5
	protected override int ToInt(KilledBonusData.Flags value) { }
}

