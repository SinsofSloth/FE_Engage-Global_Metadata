// Namespace: System.Security.Cryptography
internal class AesTransform : SymmetricTransform // TypeDefIndex: 2721
{
	// Fields
	private uint[] expandedKey; // 0x58
	private int Nk; // 0x60
	private int Nr; // 0x64
	private static readonly uint[] Rcon; // 0x0
	private static readonly byte[] SBox; // 0x8
	private static readonly byte[] iSBox; // 0x10
	private static readonly uint[] T0; // 0x18
	private static readonly uint[] T1; // 0x20
	private static readonly uint[] T2; // 0x28
	private static readonly uint[] T3; // 0x30
	private static readonly uint[] iT0; // 0x38
	private static readonly uint[] iT1; // 0x40
	private static readonly uint[] iT2; // 0x48
	private static readonly uint[] iT3; // 0x50

	// Methods

	// RVA: 0x2E469D0 Offset: 0x2E46AD1 VA: 0x2E469D0
	public void .ctor(Aes algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x2E47C00 Offset: 0x2E47D01 VA: 0x2E47C00 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x2E47B20 Offset: 0x2E47C21 VA: 0x2E47B20
	private uint SubByte(uint a) { }

	// RVA: 0x2E47C20 Offset: 0x2E47D21 VA: 0x2E47C20
	private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x2E499C0 Offset: 0x2E49AC1 VA: 0x2E499C0
	private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x2E4B760 Offset: 0x2E4B861 VA: 0x2E4B760
	private static void .cctor() { }
}

