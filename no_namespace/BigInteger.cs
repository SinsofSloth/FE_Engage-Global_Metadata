// Namespace: 
public enum BigInteger.Sign // TypeDefIndex: 76
{
	// Fields
	public int value__; // 0x0
	public const BigInteger.Sign Negative = -1;
	public const BigInteger.Sign Zero = 0;
	public const BigInteger.Sign Positive = 1;
}

// Namespace: 
private sealed class BigInteger.Kernel // TypeDefIndex: 78
{
	// Methods

	// RVA: 0x35E3290 Offset: 0x35E3391 VA: 0x35E3290
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x35E3450 Offset: 0x35E3551 VA: 0x35E3450
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x35E3560 Offset: 0x35E3661 VA: 0x35E3560
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x35E36D0 Offset: 0x35E37D1 VA: 0x35E36D0
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x35E3820 Offset: 0x35E3921 VA: 0x35E3820
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x35E38B0 Offset: 0x35E39B1 VA: 0x35E38B0
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x35E3930 Offset: 0x35E3A31 VA: 0x35E3930
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x35E3AF0 Offset: 0x35E3BF1 VA: 0x35E3AF0
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x35E4020 Offset: 0x35E4121 VA: 0x35E4020
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x35E41F0 Offset: 0x35E42F1 VA: 0x35E41F0
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x35E43B0 Offset: 0x35E44B1 VA: 0x35E43B0
	public static BigInteger MultiplyByDword(BigInteger n, uint f) { }

	// RVA: 0x35E44B0 Offset: 0x35E45B1 VA: 0x35E44B0
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x35E45D0 Offset: 0x35E46D1 VA: 0x35E45D0
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x35E4730 Offset: 0x35E4831 VA: 0x35E4730
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x35E4820 Offset: 0x35E4921 VA: 0x35E4820
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }
}

// Namespace: 
public sealed class BigInteger.ModulusRing // TypeDefIndex: 1580
{
	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0x1C54BC0 Offset: 0x1C54CC1 VA: 0x1C54BC0
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x1C54CF0 Offset: 0x1C54DF1 VA: 0x1C54CF0
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x1C54F80 Offset: 0x1C55081 VA: 0x1C54F80
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x1C55170 Offset: 0x1C55271 VA: 0x1C55170
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x1C55380 Offset: 0x1C55481 VA: 0x1C55380
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	[CLSCompliantAttribute] // RVA: 0x85DB0 Offset: 0x85EB1 VA: 0x85DB0
	// RVA: 0x1C554B0 Offset: 0x1C555B1 VA: 0x1C554B0
	public BigInteger Pow(uint b, BigInteger exp) { }
}

