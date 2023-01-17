// Namespace: App
public class BattleSide // TypeDefIndex: 9530
{
	// Fields
	public const int MainNum = 2;
	public const int ChainOffenseNum = 24;
	public const int ChainDefenseNum = 4;
	public const int Whole = 30;
	public const BattleSide.Type LinkOffense = 2;
	public const BattleSide.Type MainBegin = 0;
	public const BattleSide.Type MainEnd = 1;
	public const BattleSide.Type ChainOffenseMin = 2;
	public const BattleSide.Type ChainOffenseMax = 25;
	public const BattleSide.Type ChainDefenseMin = 26;
	public const BattleSide.Type ChainDefenseMax = 29;
	public const BattleSide.Type SupportBegin = 2;
	public const BattleSide.Type SupportEnd = 29;
	private static readonly BattleSide.Type[] Parents; // 0x0
	private static readonly BattleSide.Type[] Reverses; // 0x8
	private static readonly BattleSide.Type[] Stands; // 0x10

	// Methods

	// RVA: 0x2260720 Offset: 0x2260821 VA: 0x2260720
	public static BattleSide.Type Parent(BattleSide.Type type) { }

	// RVA: 0x22607C0 Offset: 0x22608C1 VA: 0x22607C0
	public static int Parent(int type) { }

	// RVA: 0x2260860 Offset: 0x2260961 VA: 0x2260860
	public static BattleSide.Type Reverse(BattleSide.Type type) { }

	// RVA: 0x2260900 Offset: 0x2260A01 VA: 0x2260900
	public static int Reverse(int type) { }

	// RVA: 0x22609A0 Offset: 0x2260AA1 VA: 0x22609A0
	public static BattleSide.Type Stand(BattleSide.Type type) { }

	// RVA: 0x2260A40 Offset: 0x2260B41 VA: 0x2260A40
	public static BattleSide.Type Chain(BattleSide.Type type, int index) { }

	// RVA: 0x2260A60 Offset: 0x2260B61 VA: 0x2260A60
	public static bool IsOffenseSide(BattleSide.Type type) { }

	// RVA: 0x2260A80 Offset: 0x2260B81 VA: 0x2260A80
	public static bool IsDefenseSide(BattleSide.Type type) { }

	// RVA: 0x2260AA0 Offset: 0x2260BA1 VA: 0x2260AA0
	public static bool IsChainSide(BattleSide.Type type) { }

	// RVA: 0x2260AB0 Offset: 0x2260BB1 VA: 0x2260AB0
	public void .ctor() { }

	// RVA: 0x2260AC0 Offset: 0x2260BC1 VA: 0x2260AC0
	private static void .cctor() { }
}

