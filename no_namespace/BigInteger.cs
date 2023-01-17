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
internal sealed class BigInteger.ModulusRing // TypeDefIndex: 77
{
	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0x35E4F10 Offset: 0x35E5011 VA: 0x35E4F10
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x35E5250 Offset: 0x35E5351 VA: 0x35E5250
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x35E5730 Offset: 0x35E5831 VA: 0x35E5730
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x35E5040 Offset: 0x35E5141 VA: 0x35E5040
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x35E5920 Offset: 0x35E5A21 VA: 0x35E5920
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	// RVA: 0x35E5A50 Offset: 0x35E5B51 VA: 0x35E5A50
	public BigInteger Pow(uint b, BigInteger exp) { }
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
public enum BigInteger.Sign // TypeDefIndex: 1579
{
	// Fields
	public int value__; // 0x0
	public const BigInteger.Sign Negative = -1;
	public const BigInteger.Sign Zero = 0;
	public const BigInteger.Sign Positive = 1;
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

// Namespace: 
private sealed class BigInteger.Kernel // TypeDefIndex: 1581
{
	// Methods

	// RVA: 0x1BC4350 Offset: 0x1BC4451 VA: 0x1BC4350
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x1BDD270 Offset: 0x1BDD371 VA: 0x1BDD270
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x1BDD380 Offset: 0x1BDD481 VA: 0x1BDD380
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1BC4200 Offset: 0x1BC4301 VA: 0x1BC4200
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1BC66B0 Offset: 0x1BC67B1 VA: 0x1BC66B0
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x1BC4620 Offset: 0x1BC4721 VA: 0x1BC4620
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x1BDD540 Offset: 0x1BDD641 VA: 0x1BDD540
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x1BC46D0 Offset: 0x1BC47D1 VA: 0x1BC46D0
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1BC5280 Offset: 0x1BC5381 VA: 0x1BC5280
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x1BC54F0 Offset: 0x1BC55F1 VA: 0x1BC54F0
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x1BC5150 Offset: 0x1BC5251 VA: 0x1BC5150
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x1BDD780 Offset: 0x1BDD881 VA: 0x1BDD780
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x1BDD8E0 Offset: 0x1BDD9E1 VA: 0x1BDD8E0
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x1BC6A40 Offset: 0x1BC6B41 VA: 0x1BC6A40
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }
}

