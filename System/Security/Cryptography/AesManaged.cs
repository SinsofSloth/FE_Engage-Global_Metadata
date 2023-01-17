// Namespace: System.Security.Cryptography
public sealed class AesManaged : Aes // TypeDefIndex: 2719
{
	// Fields
	private RijndaelManaged m_rijndael; // 0x48

	// Properties
	public override int FeedbackSize { get; }
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x2E473F0 Offset: 0x2E474F1 VA: 0x2E473F0
	public void .ctor() { }

	// RVA: 0x2E47550 Offset: 0x2E47651 VA: 0x2E47550 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x2E47560 Offset: 0x2E47661 VA: 0x2E47560 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x2E47570 Offset: 0x2E47671 VA: 0x2E47570 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x2E47580 Offset: 0x2E47681 VA: 0x2E47580 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x2E47590 Offset: 0x2E47691 VA: 0x2E47590 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x2E475A0 Offset: 0x2E476A1 VA: 0x2E475A0 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x2E475C0 Offset: 0x2E476C1 VA: 0x2E475C0 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x2E475E0 Offset: 0x2E476E1 VA: 0x2E475E0 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x2E47600 Offset: 0x2E47701 VA: 0x2E47600 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x2E47690 Offset: 0x2E47791 VA: 0x2E47690 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x2E476B0 Offset: 0x2E477B1 VA: 0x2E476B0 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x2E476D0 Offset: 0x2E477D1 VA: 0x2E476D0 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x2E476F0 Offset: 0x2E477F1 VA: 0x2E476F0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2E47850 Offset: 0x2E47951 VA: 0x2E47850 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x2E47870 Offset: 0x2E47971 VA: 0x2E47870 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2E479D0 Offset: 0x2E47AD1 VA: 0x2E479D0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2E47AE0 Offset: 0x2E47BE1 VA: 0x2E47AE0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x2E47B00 Offset: 0x2E47C01 VA: 0x2E47B00 Slot: 24
	public override void GenerateKey() { }
}

