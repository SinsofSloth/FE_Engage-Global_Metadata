// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474060 Offset: 0x474161 VA: 0x474060
public abstract class RC2 : SymmetricAlgorithm // TypeDefIndex: 936
{
	// Fields
	protected int EffectiveKeySizeValue; // 0x44
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public virtual int EffectiveKeySize { get; }
	public override int KeySize { get; set; }

	// Methods

	// RVA: 0x3B67E00 Offset: 0x3B67F01 VA: 0x3B67E00
	protected void .ctor() { }

	// RVA: 0x3B67EB0 Offset: 0x3B67FB1 VA: 0x3B67EB0 Slot: 26
	public virtual int get_EffectiveKeySize() { }

	// RVA: 0x3B67ED0 Offset: 0x3B67FD1 VA: 0x3B67ED0 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x3B67EE0 Offset: 0x3B67FE1 VA: 0x3B67EE0 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x3B67F60 Offset: 0x3B68061 VA: 0x3B67F60
	public static RC2 Create() { }

	// RVA: 0x3B68130 Offset: 0x3B68231 VA: 0x3B68130
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474080 Offset: 0x474181 VA: 0x474080
public sealed class RC2CryptoServiceProvider : RC2 // TypeDefIndex: 937
{
	// Fields
	private bool m_use40bitSalt; // 0x48
	private static KeySizes[] s_legalKeySizes; // 0x0

	// Properties
	public override int EffectiveKeySize { get; }

	// Methods

	// RVA: 0x3B67FC0 Offset: 0x3B680C1 VA: 0x3B67FC0
	public void .ctor() { }

	// RVA: 0x3B682B0 Offset: 0x3B683B1 VA: 0x3B682B0 Slot: 26
	public override int get_EffectiveKeySize() { }

	// RVA: 0x3B682C0 Offset: 0x3B683C1 VA: 0x3B682C0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x3B68910 Offset: 0x3B68A11 VA: 0x3B68910 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x3B689E0 Offset: 0x3B68AE1 VA: 0x3B689E0 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x3B68A70 Offset: 0x3B68B71 VA: 0x3B68A70 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x3B68AF0 Offset: 0x3B68BF1 VA: 0x3B68AF0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
internal class RC2Transform : SymmetricTransform // TypeDefIndex: 970
{
	// Fields
	private ushort R0; // 0x58
	private ushort R1; // 0x5A
	private ushort R2; // 0x5C
	private ushort R3; // 0x5E
	private ushort[] K; // 0x60
	private int j; // 0x68
	private static readonly byte[] pitable; // 0x0

	// Methods

	// RVA: 0x3B68390 Offset: 0x3B68491 VA: 0x3B68390
	public void .ctor(RC2 rc2Algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x3B68BF0 Offset: 0x3B68CF1 VA: 0x3B68BF0 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x3B698A0 Offset: 0x3B699A1 VA: 0x3B698A0
	private static void .cctor() { }
}

