// Namespace: 
[FlagsAttribute] // RVA: 0x276080 Offset: 0x276181 VA: 0x276080
public enum TasteData.Flags // TypeDefIndex: 9856
{
	// Fields
	public int value__; // 0x0
	public const TasteData.Flags IsBad = 1;
	public const TasteData.Flags DisableFoodEnhance = 2;
	public const TasteData.Flags IsMakeBento = 4;
}

// Namespace: 
public sealed class TasteData.FlagField : BitFieldTemplate32<TasteData.Flags> // TypeDefIndex: 9857
{
	// Methods

	// RVA: 0x238E5D0 Offset: 0x238E6D1 VA: 0x238E5D0
	public void .ctor(int f) { }

	// RVA: 0x238E630 Offset: 0x238E731 VA: 0x238E630
	public void .ctor(TasteData.Flags f) { }

	// RVA: 0x238E690 Offset: 0x238E791 VA: 0x238E690 Slot: 5
	protected override int ToInt(TasteData.Flags value) { }
}

// Namespace: 
public enum TasteData.TasteGrade // TypeDefIndex: 9858
{
	// Fields
	public int value__; // 0x0
	public const TasteData.TasteGrade SS = 0;
	public const TasteData.TasteGrade S = 1;
	public const TasteData.TasteGrade A = 2;
	public const TasteData.TasteGrade B = 3;
	public const TasteData.TasteGrade C = 4;
	public const TasteData.TasteGrade D = 5;
	public const TasteData.TasteGrade E = 6;
	public const TasteData.TasteGrade F = 7;
	public const TasteData.TasteGrade G = 8;
}

// Namespace: 
public enum TasteData.ConditionType // TypeDefIndex: 9859
{
	// Fields
	public int value__; // 0x0
	public const TasteData.ConditionType None = 0;
	public const TasteData.ConditionType ComeFromBrodia = 1;
	public const TasteData.ConditionType ComeFromFilene = 2;
	public const TasteData.ConditionType ComeFromSolum = 3;
	public const TasteData.ConditionType ComeFromIrcion = 4;
	public const TasteData.ConditionType ComeFromLithos = 5;
	public const TasteData.ConditionType IsMale = 6;
	public const TasteData.ConditionType IsFemale = 7;
	public const TasteData.ConditionType IsAdult = 8;
	public const TasteData.ConditionType IsChild = 9;
	public const TasteData.ConditionType IsLueur = 10;
}

