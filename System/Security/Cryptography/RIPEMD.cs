// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474100 Offset: 0x474201 VA: 0x474100
public abstract class RIPEMD160 : HashAlgorithm // TypeDefIndex: 942
{
	// Methods

	// RVA: 0x3B69C30 Offset: 0x3B69D31 VA: 0x3B69C30
	protected void .ctor() { }

	// RVA: 0x3B69C60 Offset: 0x3B69D61 VA: 0x3B69C60
	public static RIPEMD160 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474120 Offset: 0x474221 VA: 0x474120
public class RIPEMD160Managed : RIPEMD160 // TypeDefIndex: 943
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateMD160; // 0x38
	private uint[] _blockDWords; // 0x40

	// Methods

	// RVA: 0x3B69CC0 Offset: 0x3B69DC1 VA: 0x3B69CC0
	public void .ctor() { }

	// RVA: 0x3B69EA0 Offset: 0x3B69FA1 VA: 0x3B69EA0 Slot: 16
	public override void Initialize() { }

	// RVA: 0x3B69EF0 Offset: 0x3B69FF1 VA: 0x3B69EF0 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x3B6A0A0 Offset: 0x3B6A1A1 VA: 0x3B6A0A0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x3B69DF0 Offset: 0x3B69EF1 VA: 0x3B69DF0
	private void InitializeState() { }

	// RVA: 0x3B69F00 Offset: 0x3B6A001 VA: 0x3B69F00
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x3B6A0B0 Offset: 0x3B6A1B1 VA: 0x3B6A0B0
	private byte[] _EndHash() { }

	// RVA: 0x3B6A270 Offset: 0x3B6A371 VA: 0x3B6A270
	private static void MDTransform(uint* blockDWords, uint* state, byte* block) { }

	// RVA: 0x3B6B8B0 Offset: 0x3B6B9B1 VA: 0x3B6B8B0
	private static uint F(uint x, uint y, uint z) { }

	// RVA: 0x3B6B8C0 Offset: 0x3B6B9C1 VA: 0x3B6B8C0
	private static uint G(uint x, uint y, uint z) { }

	// RVA: 0x3B6B8D0 Offset: 0x3B6B9D1 VA: 0x3B6B8D0
	private static uint H(uint x, uint y, uint z) { }

	// RVA: 0x3B6B8E0 Offset: 0x3B6B9E1 VA: 0x3B6B8E0
	private static uint I(uint x, uint y, uint z) { }

	// RVA: 0x3B6B8F0 Offset: 0x3B6B9F1 VA: 0x3B6B8F0
	private static uint J(uint x, uint y, uint z) { }
}

