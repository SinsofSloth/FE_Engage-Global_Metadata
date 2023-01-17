// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474000 Offset: 0x474101 VA: 0x474000
public class MACTripleDES : KeyedHashAlgorithm // TypeDefIndex: 932
{
	// Fields
	private ICryptoTransform m_encryptor; // 0x30
	private CryptoStream _cs; // 0x38
	private TailStream _ts; // 0x40
	private int m_bytesPerBlock; // 0x48
	private TripleDES des; // 0x50

	// Methods

	// RVA: 0x3422320 Offset: 0x3422421 VA: 0x3422320
	public void .ctor() { }

	// RVA: 0x3422480 Offset: 0x3422581 VA: 0x3422480 Slot: 16
	public override void Initialize() { }

	// RVA: 0x3422490 Offset: 0x3422591 VA: 0x3422490 Slot: 17
	protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }

	// RVA: 0x3422610 Offset: 0x3422711 VA: 0x3422610 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x3422770 Offset: 0x3422871 VA: 0x3422770 Slot: 15
	protected override void Dispose(bool disposing) { }
}

