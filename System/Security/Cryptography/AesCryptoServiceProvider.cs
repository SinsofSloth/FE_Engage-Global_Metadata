// Namespace: System.Security.Cryptography
public sealed class AesCryptoServiceProvider : Aes // TypeDefIndex: 2720
{
	// Properties
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override int FeedbackSize { get; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x2E467D0 Offset: 0x2E468D1 VA: 0x2E467D0
	public void .ctor() { }

	// RVA: 0x2E46850 Offset: 0x2E46951 VA: 0x2E46850 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x2E46890 Offset: 0x2E46991 VA: 0x2E46890 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x2E468D0 Offset: 0x2E469D1 VA: 0x2E468D0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2E47110 Offset: 0x2E47211 VA: 0x2E47110 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2E47210 Offset: 0x2E47311 VA: 0x2E47210 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x2E47220 Offset: 0x2E47321 VA: 0x2E47220 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x2E47230 Offset: 0x2E47331 VA: 0x2E47230 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x2E47240 Offset: 0x2E47341 VA: 0x2E47240 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x2E47250 Offset: 0x2E47351 VA: 0x2E47250 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x2E47260 Offset: 0x2E47361 VA: 0x2E47260 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x2E47270 Offset: 0x2E47371 VA: 0x2E47270 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x2E47280 Offset: 0x2E47381 VA: 0x2E47280 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x2E47290 Offset: 0x2E47391 VA: 0x2E47290 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x2E47300 Offset: 0x2E47401 VA: 0x2E47300 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x2E47310 Offset: 0x2E47411 VA: 0x2E47310 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x2E47320 Offset: 0x2E47421 VA: 0x2E47320 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x2E47380 Offset: 0x2E47481 VA: 0x2E47380 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x2E473E0 Offset: 0x2E474E1 VA: 0x2E473E0 Slot: 5
	protected override void Dispose(bool disposing) { }
}

