// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x4742C0 Offset: 0x4743C1 VA: 0x4742C0
public abstract class SymmetricAlgorithm : IDisposable // TypeDefIndex: 962
{
	// Fields
	protected int BlockSizeValue; // 0x10
	protected int FeedbackSizeValue; // 0x14
	protected byte[] IVValue; // 0x18
	protected byte[] KeyValue; // 0x20
	protected KeySizes[] LegalBlockSizesValue; // 0x28
	protected KeySizes[] LegalKeySizesValue; // 0x30
	protected int KeySizeValue; // 0x38
	protected CipherMode ModeValue; // 0x3C
	protected PaddingMode PaddingValue; // 0x40

	// Properties
	public virtual int BlockSize { get; set; }
	public virtual int FeedbackSize { get; }
	public virtual byte[] IV { get; set; }
	public virtual byte[] Key { get; set; }
	public virtual KeySizes[] LegalKeySizes { get; }
	public virtual int KeySize { get; set; }
	public virtual CipherMode Mode { get; set; }
	public virtual PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x365AD60 Offset: 0x365AE61 VA: 0x365AD60
	protected void .ctor() { }

	// RVA: 0x365AD90 Offset: 0x365AE91 VA: 0x365AD90 Slot: 4
	public void Dispose() { }

	// RVA: 0x365AE10 Offset: 0x365AF11 VA: 0x365AE10
	public void Clear() { }

	// RVA: 0x365AEB0 Offset: 0x365AFB1 VA: 0x365AEB0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x365AF30 Offset: 0x365B031 VA: 0x365AF30 Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x365AF40 Offset: 0x365B041 VA: 0x365AF40 Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x365B050 Offset: 0x365B151 VA: 0x365B050 Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x365B060 Offset: 0x365B161 VA: 0x365B060 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x365B110 Offset: 0x365B211 VA: 0x365B110 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x365B260 Offset: 0x365B361 VA: 0x365B260 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x365B310 Offset: 0x365B411 VA: 0x365B310 Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x365B5A0 Offset: 0x365B6A1 VA: 0x365B5A0 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x365B620 Offset: 0x365B721 VA: 0x365B620 Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x365B630 Offset: 0x365B731 VA: 0x365B630 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0x365B730 Offset: 0x365B831 VA: 0x365B730 Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x365B740 Offset: 0x365B841 VA: 0x365B740 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x365B7C0 Offset: 0x365B8C1 VA: 0x365B7C0 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x365B7D0 Offset: 0x365B8D1 VA: 0x365B7D0 Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x365B4D0 Offset: 0x365B5D1 VA: 0x365B4D0
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x365B850 Offset: 0x365B951 VA: 0x365B850
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x365B8E0 Offset: 0x365B9E1 VA: 0x365B8E0 Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: 0x365B940 Offset: 0x365BA41 VA: 0x365B940 Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV();
}

