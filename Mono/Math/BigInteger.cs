// Namespace: Mono.Math
internal class BigInteger // TypeDefIndex: 79
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x3500730 Offset: 0x3500831 VA: 0x3500730
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x35007C0 Offset: 0x35008C1 VA: 0x35007C0
	public void .ctor(BigInteger bi) { }

	// RVA: 0x3500870 Offset: 0x3500971 VA: 0x3500870
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x3500970 Offset: 0x3500A71 VA: 0x3500970
	public void .ctor(byte[] inData) { }

	// RVA: 0x3500CA0 Offset: 0x3500DA1 VA: 0x3500CA0
	public void .ctor(uint ui) { }

	// RVA: 0x3500D40 Offset: 0x3500E41 VA: 0x3500D40
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x3500E10 Offset: 0x3500F11 VA: 0x3500E10
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x3500F30 Offset: 0x3501031 VA: 0x3500F30
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x3501210 Offset: 0x3501311 VA: 0x3501210
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x3501220 Offset: 0x3501321 VA: 0x3501220
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x3501260 Offset: 0x3501361 VA: 0x3501260
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x3501290 Offset: 0x3501391 VA: 0x3501290
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x35015A0 Offset: 0x35016A1 VA: 0x35015A0
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x35016B0 Offset: 0x35017B1 VA: 0x35016B0
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x35016C0 Offset: 0x35017C1 VA: 0x35016C0
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x35016D0 Offset: 0x35017D1 VA: 0x35016D0
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x35017B0 Offset: 0x35018B1 VA: 0x35017B0
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x3501BD0 Offset: 0x3501CD1 VA: 0x3501BD0
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x3501C40 Offset: 0x3501D41 VA: 0x3501C40
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x3501F10 Offset: 0x3502011 VA: 0x3501F10
	public void Randomize() { }

	// RVA: 0x3501E60 Offset: 0x3501F61 VA: 0x3501E60
	public int BitCount() { }

	// RVA: 0x3501F80 Offset: 0x3502081 VA: 0x3501F80
	public bool TestBit(uint bitNum) { }

	// RVA: 0x3501FC0 Offset: 0x35020C1 VA: 0x3501FC0
	public bool TestBit(int bitNum) { }

	// RVA: 0x3502060 Offset: 0x3502161 VA: 0x3502060
	public void SetBit(uint bitNum) { }

	// RVA: 0x35020C0 Offset: 0x35021C1 VA: 0x35020C0
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x3502120 Offset: 0x3502221 VA: 0x3502120
	public int LowestSetBit() { }

	// RVA: 0x3502220 Offset: 0x3502321 VA: 0x3502220
	public byte[] GetBytes() { }

	// RVA: 0x3501180 Offset: 0x3501281 VA: 0x3501180
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x3502430 Offset: 0x3502531 VA: 0x3502430
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x35024C0 Offset: 0x35025C1 VA: 0x35024C0
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x35025D0 Offset: 0x35026D1 VA: 0x35025D0
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x35026E0 Offset: 0x35027E1 VA: 0x35026E0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x3502700 Offset: 0x3502801 VA: 0x3502700
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x3502720 Offset: 0x3502821 VA: 0x3502720
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x3502740 Offset: 0x3502841 VA: 0x3502740
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x3502760 Offset: 0x3502861 VA: 0x3502760
	public string ToString(uint radix) { }

	// RVA: 0x35027C0 Offset: 0x35028C1 VA: 0x35027C0
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x3500C40 Offset: 0x3500D41 VA: 0x3500C40
	private void Normalize() { }

	// RVA: 0x3502B10 Offset: 0x3502C11 VA: 0x3502B10
	public void Clear() { }

	// RVA: 0x3502B70 Offset: 0x3502C71 VA: 0x3502B70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3502BE0 Offset: 0x3502CE1 VA: 0x3502BE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3502C40 Offset: 0x3502D41 VA: 0x3502C40 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x3502E30 Offset: 0x3502F31 VA: 0x3502E30
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x3502E40 Offset: 0x3502F41 VA: 0x3502E40
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x3502ED0 Offset: 0x3502FD1 VA: 0x3502ED0
	public bool IsProbablePrime() { }

	// RVA: 0x3503110 Offset: 0x3503211 VA: 0x3503110
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x3503180 Offset: 0x3503281 VA: 0x3503180
	public void Incr2() { }

	// RVA: 0x3503250 Offset: 0x3503351 VA: 0x3503250
	private static void .cctor() { }
}

