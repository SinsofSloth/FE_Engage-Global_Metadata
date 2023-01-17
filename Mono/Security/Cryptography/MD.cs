// Namespace: Mono.Security.Cryptography
internal abstract class MD2 : HashAlgorithm // TypeDefIndex: 62
{
	// Methods

	// RVA: 0x3422BD0 Offset: 0x3422CD1 VA: 0x3422BD0
	protected void .ctor() { }

	// RVA: 0x3422C00 Offset: 0x3422D01 VA: 0x3422C00
	public static MD2 Create() { }
}

// Namespace: Mono.Security.Cryptography
internal abstract class MD4 : HashAlgorithm // TypeDefIndex: 64
{
	// Methods

	// RVA: 0x3423400 Offset: 0x3423501 VA: 0x3423400
	protected void .ctor() { }

	// RVA: 0x3423430 Offset: 0x3423531 VA: 0x3423430
	public static MD4 Create() { }
}

// Namespace: Mono.Security.Cryptography
public class MD2Managed : MD2 // TypeDefIndex: 1570
{
	// Fields
	private byte[] state; // 0x28
	private byte[] checksum; // 0x30
	private byte[] buffer; // 0x38
	private int count; // 0x40
	private byte[] x; // 0x48
	private static readonly byte[] PI_SUBST; // 0x0

	// Methods

	// RVA: 0x1BCA680 Offset: 0x1BCA781 VA: 0x1BCA680
	private byte[] Padding(int nLength) { }

	// RVA: 0x1BCA5A0 Offset: 0x1BCA6A1 VA: 0x1BCA5A0
	public void .ctor() { }

	// RVA: 0x1BCA730 Offset: 0x1BCA831 VA: 0x1BCA730 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1BCA7A0 Offset: 0x1BCA8A1 VA: 0x1BCA7A0 Slot: 17
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1BCAB10 Offset: 0x1BCAC11 VA: 0x1BCAB10 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1BCA890 Offset: 0x1BCA991 VA: 0x1BCA890
	private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) { }

	// RVA: 0x1BCACA0 Offset: 0x1BCADA1 VA: 0x1BCACA0
	private static void .cctor() { }
}

// Namespace: Mono.Security.Cryptography
public class MD4Managed : MD4 // TypeDefIndex: 1572
{
	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x1BCAD70 Offset: 0x1BCAE71 VA: 0x1BCAD70
	public void .ctor() { }

	// RVA: 0x1BCAE80 Offset: 0x1BCAF81 VA: 0x1BCAE80 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1BCAF60 Offset: 0x1BCB061 VA: 0x1BCAF60 Slot: 17
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1BCB710 Offset: 0x1BCB811 VA: 0x1BCB710 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1BCB950 Offset: 0x1BCBA51 VA: 0x1BCB950
	private byte[] Padding(int nLength) { }

	// RVA: 0x1BCB9E0 Offset: 0x1BCBAE1 VA: 0x1BCB9E0
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x1BCB9F0 Offset: 0x1BCBAF1 VA: 0x1BCB9F0
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x1BCBA10 Offset: 0x1BCBB11 VA: 0x1BCBA10
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x1BCBA20 Offset: 0x1BCBB21 VA: 0x1BCBA20
	private uint ROL(uint x, byte n) { }

	// RVA: 0x1BCBA30 Offset: 0x1BCBB31 VA: 0x1BCBA30
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1BCBA60 Offset: 0x1BCBB61 VA: 0x1BCBA60
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1BCBAA0 Offset: 0x1BCBBA1 VA: 0x1BCBAA0
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x1BCB860 Offset: 0x1BCB961 VA: 0x1BCB860
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x1BCBAE0 Offset: 0x1BCBBE1 VA: 0x1BCBAE0
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x1BCB0A0 Offset: 0x1BCB1A1 VA: 0x1BCB0A0
	private void MD4Transform(uint[] state, byte[] block, int index) { }
}

