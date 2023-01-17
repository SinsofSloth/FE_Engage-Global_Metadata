// Namespace: 
public class UnitAI.FlagField : BitField32 // TypeDefIndex: 13498
{
	// Methods

	// RVA: 0x23ABA50 Offset: 0x23ABB51 VA: 0x23ABA50
	public void Set(UnitAI.Flag f) { }

	// RVA: 0x23ABA60 Offset: 0x23ABB61 VA: 0x23ABA60
	public bool Test(UnitAI.Flag f) { }

	// RVA: 0x23ABA70 Offset: 0x23ABB71 VA: 0x23ABA70
	public bool Not(UnitAI.Flag f) { }

	// RVA: 0x23ABA80 Offset: 0x23ABB81 VA: 0x23ABA80
	public void Clear(UnitAI.Flag f) { }

	// RVA: 0x23ABA90 Offset: 0x23ABB91 VA: 0x23ABA90
	public int Mask(UnitAI.Flag f) { }

	// RVA: 0x23ABAA0 Offset: 0x23ABBA1 VA: 0x23ABAA0
	public void .ctor() { }
}

// Namespace: 
public class UnitAI.RandomFlagField : BitField32 // TypeDefIndex: 13500
{
	// Methods

	// RVA: 0x23ABDD0 Offset: 0x23ABED1 VA: 0x23ABDD0
	public void Set(UnitAI.RandomFlag f) { }

	// RVA: 0x23ABDE0 Offset: 0x23ABEE1 VA: 0x23ABDE0
	public bool Test(UnitAI.RandomFlag f) { }

	// RVA: 0x23ABDF0 Offset: 0x23ABEF1 VA: 0x23ABDF0
	public bool Not(UnitAI.RandomFlag f) { }

	// RVA: 0x23ABE00 Offset: 0x23ABF01 VA: 0x23ABE00
	public void .ctor() { }
}

// Namespace: 
public enum UnitAI.MoveLimitRange.LimitType // TypeDefIndex: 13502
{
	// Fields
	public int value__; // 0x0
	public const UnitAI.MoveLimitRange.LimitType None = 0;
	public const UnitAI.MoveLimitRange.LimitType Move = 1;
	public const UnitAI.MoveLimitRange.LimitType Distance = 2;
	public const UnitAI.MoveLimitRange.LimitType Rect = 3;
	public const UnitAI.MoveLimitRange.LimitType InterferenceRodRect = 4;
	public const UnitAI.MoveLimitRange.LimitType Num = 5;
}

// Namespace: 
public enum UnitAI.VersusTypes // TypeDefIndex: 13504
{
	// Fields
	public int value__; // 0x0
	public const UnitAI.VersusTypes NotMove = 0;
	public const UnitAI.VersusTypes Defense = 1;
	public const UnitAI.VersusTypes Rush = 2;
	public const UnitAI.VersusTypes ResponseA = 3;
	public const UnitAI.VersusTypes ResponseB = 4;
	public const UnitAI.VersusTypes ResponseC = 5;
	public const UnitAI.VersusTypes Num = 6;
}

