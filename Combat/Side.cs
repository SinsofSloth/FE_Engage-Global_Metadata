// Namespace: Combat
public static class Side // TypeDefIndex: 8807
{
	// Fields
	public const int Invalid = -1;
	public const int Player = 0;
	public const int Enemy = 1;
	public const int PGrandew = 2;
	public const int EGrandew = 3;
	public const int PChainAtk = 4;
	public const int EChainAtk = 5;
	public const int PChainGrd1 = 6;
	public const int EChainGrd1 = 7;
	public const int PChainGrd2 = 8;
	public const int EChainGrd2 = 9;
	public const int PChainGrd3 = 10;
	public const int EChainGrd3 = 11;
	public const int PChainGrd4 = 12;
	public const int EChainGrd4 = 13;
	public const int Max = 14;
	public const int Regular = 4;

	// Methods

	// RVA: 0x2341FA0 Offset: 0x23420A1 VA: 0x2341FA0
	public static string ToName(int i) { }

	// RVA: 0x2342550 Offset: 0x2342651 VA: 0x2342550
	public static int FromName(string name) { }

	// RVA: 0x2342940 Offset: 0x2342A41 VA: 0x2342940
	public static bool IsMaster(int i) { }

	// RVA: 0x2342950 Offset: 0x2342A51 VA: 0x2342950
	public static bool IsPairedGrandew(int i) { }

	// RVA: 0x2342960 Offset: 0x2342A61 VA: 0x2342960
	public static bool IsChain(int i) { }

	// RVA: 0x2342970 Offset: 0x2342A71 VA: 0x2342970
	public static bool IsChainAtk(int i) { }

	// RVA: 0x2342980 Offset: 0x2342A81 VA: 0x2342980
	public static bool IsChainGrd(int i) { }

	// RVA: 0x23429A0 Offset: 0x2342AA1 VA: 0x23429A0
	public static bool IsPlayerSide(int i) { }

	// RVA: 0x23429B0 Offset: 0x2342AB1 VA: 0x23429B0
	public static bool IsEnemySide(int i) { }

	// RVA: 0x23429C0 Offset: 0x2342AC1 VA: 0x23429C0
	public static int ToEnemy(int i) { }

	// RVA: 0x23429D0 Offset: 0x2342AD1 VA: 0x23429D0
	public static int ToEnemyGrandew(int i) { }

	// RVA: 0x23429E0 Offset: 0x2342AE1 VA: 0x23429E0
	public static int ToGrandew(int i) { }

	// RVA: 0x2342A00 Offset: 0x2342B01 VA: 0x2342A00
	public static int ToMaster(int i) { }

	// RVA: 0x2342A20 Offset: 0x2342B21 VA: 0x2342A20
	public static int ToPartner(int i) { }

	// RVA: 0x2342A40 Offset: 0x2342B41 VA: 0x2342A40
	public static int ToMirrorSide(int i) { }

	// RVA: 0x2342A60 Offset: 0x2342B61 VA: 0x2342A60
	public static Character ToEnemyChr(int i) { }

	// RVA: 0x2342AC0 Offset: 0x2342BC1 VA: 0x2342AC0
	public static Character ToGrandewChr(int i) { }

	// RVA: 0x2342B50 Offset: 0x2342C51 VA: 0x2342B50
	public static Character ToMasterChr(int i) { }

	// RVA: 0x2342BC0 Offset: 0x2342CC1 VA: 0x2342BC0
	public static Character ToPartnerChr(int i) { }

	// RVA: 0x2342C30 Offset: 0x2342D31 VA: 0x2342C30
	public static Character ToEnemyGrandewChr(int i) { }

	// RVA: 0x2342C90 Offset: 0x2342D91 VA: 0x2342C90
	public static int ConvertFrom(BattleSide.Type sideType, bool isReversed) { }
}

