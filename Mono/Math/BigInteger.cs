// Namespace: Mono.Math
public class BigInteger // TypeDefIndex: 1582
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	[CLSCompliantAttribute] // RVA: 0x85C50 Offset: 0x85D51 VA: 0x85C50
	// RVA: 0x1BC3720 Offset: 0x1BC3821 VA: 0x1BC3720
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1BC37B0 Offset: 0x1BC38B1 VA: 0x1BC37B0
	public void .ctor(BigInteger bi) { }

	[CLSCompliantAttribute] // RVA: 0x85C70 Offset: 0x85D71 VA: 0x85C70
	// RVA: 0x1BC3860 Offset: 0x1BC3961 VA: 0x1BC3860
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x1BC3960 Offset: 0x1BC3A61 VA: 0x1BC3960
	public void .ctor(byte[] inData) { }

	[CLSCompliantAttribute] // RVA: 0x85C90 Offset: 0x85D91 VA: 0x85C90
	// RVA: 0x1BC3C90 Offset: 0x1BC3D91 VA: 0x1BC3C90
	public void .ctor(uint ui) { }

	[CLSCompliantAttribute] // RVA: 0x85CB0 Offset: 0x85DB1 VA: 0x85CB0
	// RVA: 0x1BC3D30 Offset: 0x1BC3E31 VA: 0x1BC3D30
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x1BC3E00 Offset: 0x1BC3F01 VA: 0x1BC3E00
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x1BC3F20 Offset: 0x1BC4021 VA: 0x1BC3F20
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0x85CD0 Offset: 0x85DD1 VA: 0x85CD0
	// RVA: 0x1BC45A0 Offset: 0x1BC46A1 VA: 0x1BC45A0
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x1BC46A0 Offset: 0x1BC47A1 VA: 0x1BC46A0
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1BC4D00 Offset: 0x1BC4E01 VA: 0x1BC4D00
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1BC4D30 Offset: 0x1BC4E31 VA: 0x1BC4D30
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1BC5270 Offset: 0x1BC5371 VA: 0x1BC5270
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1BC54E0 Offset: 0x1BC55E1 VA: 0x1BC54E0
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1BC5740 Offset: 0x1BC5841 VA: 0x1BC5740
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1BC5820 Offset: 0x1BC5921 VA: 0x1BC5820
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1BC5A40 Offset: 0x1BC5B41 VA: 0x1BC5A40
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1BC5AB0 Offset: 0x1BC5BB1 VA: 0x1BC5AB0
	public int BitCount() { }

	// RVA: 0x1BC5B60 Offset: 0x1BC5C61 VA: 0x1BC5B60
	public bool TestBit(int bitNum) { }

	[CLSCompliantAttribute] // RVA: 0x85CF0 Offset: 0x85DF1 VA: 0x85CF0
	// RVA: 0x1BC5C00 Offset: 0x1BC5D01 VA: 0x1BC5C00
	public void SetBit(uint bitNum) { }

	[CLSCompliantAttribute] // RVA: 0x85D10 Offset: 0x85E11 VA: 0x85D10
	// RVA: 0x1BC5C60 Offset: 0x1BC5D61 VA: 0x1BC5C60
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1BC5CC0 Offset: 0x1BC5DC1 VA: 0x1BC5CC0
	public int LowestSetBit() { }

	// RVA: 0x1BC5DC0 Offset: 0x1BC5EC1 VA: 0x1BC5DC0
	public byte[] GetBytes() { }

	[CLSCompliantAttribute] // RVA: 0x85D30 Offset: 0x85E31 VA: 0x85D30
	// RVA: 0x1BC4170 Offset: 0x1BC4271 VA: 0x1BC4170
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliantAttribute] // RVA: 0x85D50 Offset: 0x85E51 VA: 0x85D50
	// RVA: 0x1BC5FD0 Offset: 0x1BC60D1 VA: 0x1BC5FD0
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x1BC6060 Offset: 0x1BC6161 VA: 0x1BC6060
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1BC6170 Offset: 0x1BC6271 VA: 0x1BC6170
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1BC6280 Offset: 0x1BC6381 VA: 0x1BC6280
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1BC62A0 Offset: 0x1BC63A1 VA: 0x1BC62A0
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1BC62C0 Offset: 0x1BC63C1 VA: 0x1BC62C0
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1BC62E0 Offset: 0x1BC63E1 VA: 0x1BC62E0
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliantAttribute] // RVA: 0x85D70 Offset: 0x85E71 VA: 0x85D70
	// RVA: 0x1BC6300 Offset: 0x1BC6401 VA: 0x1BC6300
	public string ToString(uint radix) { }

	[CLSCompliantAttribute] // RVA: 0x85D90 Offset: 0x85E91 VA: 0x85D90
	// RVA: 0x1BC6360 Offset: 0x1BC6461 VA: 0x1BC6360
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1BC3C30 Offset: 0x1BC3D31 VA: 0x1BC3C30
	private void Normalize() { }

	// RVA: 0x1BC6770 Offset: 0x1BC6871 VA: 0x1BC6770 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1BC67E0 Offset: 0x1BC68E1 VA: 0x1BC67E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BC6840 Offset: 0x1BC6941 VA: 0x1BC6840 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1BC6A30 Offset: 0x1BC6B31 VA: 0x1BC6A30
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x1BC7110 Offset: 0x1BC7211 VA: 0x1BC7110
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x1BC7190 Offset: 0x1BC7291 VA: 0x1BC7190
	public void Incr2() { }

	// RVA: 0x1BC7260 Offset: 0x1BC7361 VA: 0x1BC7260
	private static void .cctor() { }
}

