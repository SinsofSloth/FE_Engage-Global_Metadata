// Namespace: System.Security.Cryptography
internal class DESTransform : SymmetricTransform // TypeDefIndex: 967
{
	// Fields
	internal static readonly int KEY_BIT_SIZE; // 0x0
	internal static readonly int KEY_BYTE_SIZE; // 0x4
	internal static readonly int BLOCK_BIT_SIZE; // 0x8
	internal static readonly int BLOCK_BYTE_SIZE; // 0xC
	private byte[] keySchedule; // 0x58
	private byte[] byteBuff; // 0x60
	private uint[] dwordBuff; // 0x68
	private static readonly uint[] spBoxes; // 0x10
	private static readonly byte[] PC1; // 0x18
	private static readonly byte[] leftRotTotal; // 0x20
	private static readonly byte[] PC2; // 0x28
	internal static readonly uint[] ipTab; // 0x30
	internal static readonly uint[] fpTab; // 0x38

	// Methods

	// RVA: 0x37E6550 Offset: 0x37E6651 VA: 0x37E6550
	internal void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x37E6F70 Offset: 0x37E7071 VA: 0x37E6F70
	private uint CipherFunct(uint r, int n) { }

	// RVA: 0x37E71B0 Offset: 0x37E72B1 VA: 0x37E71B0
	internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap) { }

	// RVA: 0x37E7500 Offset: 0x37E7601 VA: 0x37E7500
	private static void BSwap(byte[] byteBuff) { }

	// RVA: 0x37E6BA0 Offset: 0x37E6CA1 VA: 0x37E6BA0
	internal void SetKey(byte[] key) { }

	// RVA: 0x37E7580 Offset: 0x37E7681 VA: 0x37E7580
	public void ProcessBlock(byte[] input, byte[] output) { }

	// RVA: 0x37E7930 Offset: 0x37E7A31 VA: 0x37E7930 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x37E6A90 Offset: 0x37E6B91 VA: 0x37E6A90
	internal static byte[] GetStrongKey() { }

	// RVA: 0x37E79F0 Offset: 0x37E7AF1 VA: 0x37E79F0
	private static void .cctor() { }
}

