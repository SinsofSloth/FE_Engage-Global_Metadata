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

