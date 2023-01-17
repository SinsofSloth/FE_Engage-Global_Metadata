// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x4741A0 Offset: 0x4742A1 VA: 0x4741A0
public abstract class SHA1 : HashAlgorithm // TypeDefIndex: 947
{
	// Methods

	// RVA: 0x3608E30 Offset: 0x3608F31 VA: 0x3608E30
	protected void .ctor() { }

	// RVA: 0x3608E60 Offset: 0x3608F61 VA: 0x3608E60
	public static SHA1 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x4741C0 Offset: 0x4742C1 VA: 0x4741C0
public class SHA1Managed : SHA1 // TypeDefIndex: 948
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA1; // 0x38
	private uint[] _expandedBuffer; // 0x40

	// Methods

	// RVA: 0x360A940 Offset: 0x360AA41 VA: 0x360A940
	public void .ctor() { }

	// RVA: 0x360AB20 Offset: 0x360AC21 VA: 0x360AB20 Slot: 16
	public override void Initialize() { }

	// RVA: 0x360AB70 Offset: 0x360AC71 VA: 0x360AB70 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x360AD20 Offset: 0x360AE21 VA: 0x360AD20 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x360AA70 Offset: 0x360AB71 VA: 0x360AA70
	private void InitializeState() { }

	// RVA: 0x360AB80 Offset: 0x360AC81 VA: 0x360AB80
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x360AD30 Offset: 0x360AE31 VA: 0x360AD30
	private byte[] _EndHash() { }

	// RVA: 0x360AF00 Offset: 0x360B001 VA: 0x360AF00
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x360B980 Offset: 0x360BA81 VA: 0x360B980
	private static void SHAExpand(uint* x) { }
}

// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x4741E0 Offset: 0x4742E1 VA: 0x4741E0
public abstract class SHA256 : HashAlgorithm // TypeDefIndex: 949
{
	// Methods

	// RVA: 0x360B9C0 Offset: 0x360BAC1 VA: 0x360B9C0
	protected void .ctor() { }

	// RVA: 0x360B9F0 Offset: 0x360BAF1 VA: 0x360B9F0
	public static SHA256 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474200 Offset: 0x474301 VA: 0x474200
public class SHA256Managed : SHA256 // TypeDefIndex: 950
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA256; // 0x38
	private uint[] _W; // 0x40
	private static readonly uint[] _K; // 0x0

	// Methods

	// RVA: 0x360BA50 Offset: 0x360BB51 VA: 0x360BA50
	public void .ctor() { }

	// RVA: 0x360BC80 Offset: 0x360BD81 VA: 0x360BC80 Slot: 16
	public override void Initialize() { }

	// RVA: 0x360BCD0 Offset: 0x360BDD1 VA: 0x360BCD0 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x360BEE0 Offset: 0x360BFE1 VA: 0x360BEE0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x360BB80 Offset: 0x360BC81 VA: 0x360BB80
	private void InitializeState() { }

	// RVA: 0x360BCE0 Offset: 0x360BDE1 VA: 0x360BCE0
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x360BEF0 Offset: 0x360BFF1 VA: 0x360BEF0
	private byte[] _EndHash() { }

	// RVA: 0x360C0C0 Offset: 0x360C1C1 VA: 0x360C0C0
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x360CCC0 Offset: 0x360CDC1 VA: 0x360CCC0
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x360CC20 Offset: 0x360CD21 VA: 0x360CC20
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x360CCA0 Offset: 0x360CDA1 VA: 0x360CCA0
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x360CCD0 Offset: 0x360CDD1 VA: 0x360CCD0
	private static uint sigma_0(uint x) { }

	// RVA: 0x360CD40 Offset: 0x360CE41 VA: 0x360CD40
	private static uint sigma_1(uint x) { }

	// RVA: 0x360CC30 Offset: 0x360CD31 VA: 0x360CC30
	private static uint Sigma_0(uint x) { }

	// RVA: 0x360CBB0 Offset: 0x360CCB1 VA: 0x360CBB0
	private static uint Sigma_1(uint x) { }

	// RVA: 0x360CA60 Offset: 0x360CB61 VA: 0x360CA60
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x360CDB0 Offset: 0x360CEB1 VA: 0x360CDB0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474220 Offset: 0x474321 VA: 0x474220
public abstract class SHA384 : HashAlgorithm // TypeDefIndex: 951
{
	// Methods

	// RVA: 0x360CE50 Offset: 0x360CF51 VA: 0x360CE50
	protected void .ctor() { }

	// RVA: 0x360CE80 Offset: 0x360CF81 VA: 0x360CE80
	public static SHA384 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474240 Offset: 0x474341 VA: 0x474240
public class SHA384Managed : SHA384 // TypeDefIndex: 952
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA384; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x360CEE0 Offset: 0x360CFE1 VA: 0x360CEE0
	public void .ctor() { }

	// RVA: 0x360D150 Offset: 0x360D251 VA: 0x360D150 Slot: 16
	public override void Initialize() { }

	// RVA: 0x360D1A0 Offset: 0x360D2A1 VA: 0x360D1A0 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x360D3B0 Offset: 0x360D4B1 VA: 0x360D3B0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x360D010 Offset: 0x360D111 VA: 0x360D010
	private void InitializeState() { }

	// RVA: 0x360D1B0 Offset: 0x360D2B1 VA: 0x360D1B0
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x360D3C0 Offset: 0x360D4C1 VA: 0x360D3C0
	private byte[] _EndHash() { }

	// RVA: 0x360D590 Offset: 0x360D691 VA: 0x360D590
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x360E190 Offset: 0x360E291 VA: 0x360E190
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x360E0F0 Offset: 0x360E1F1 VA: 0x360E0F0
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x360E170 Offset: 0x360E271 VA: 0x360E170
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x360E100 Offset: 0x360E201 VA: 0x360E100
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x360E080 Offset: 0x360E181 VA: 0x360E080
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x360E1A0 Offset: 0x360E2A1 VA: 0x360E1A0
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x360E210 Offset: 0x360E311 VA: 0x360E210
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x360DF30 Offset: 0x360E031 VA: 0x360DF30
	private static void SHA384Expand(ulong* x) { }

	// RVA: 0x360E280 Offset: 0x360E381 VA: 0x360E280
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474260 Offset: 0x474361 VA: 0x474260
public abstract class SHA512 : HashAlgorithm // TypeDefIndex: 953
{
	// Methods

	// RVA: 0x360E320 Offset: 0x360E421 VA: 0x360E320
	protected void .ctor() { }

	// RVA: 0x360E350 Offset: 0x360E451 VA: 0x360E350
	public static SHA512 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x474280 Offset: 0x474381 VA: 0x474280
public class SHA512Managed : SHA512 // TypeDefIndex: 954
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA512; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x360E3B0 Offset: 0x360E4B1 VA: 0x360E3B0
	public void .ctor() { }

	// RVA: 0x360E620 Offset: 0x360E721 VA: 0x360E620 Slot: 16
	public override void Initialize() { }

	// RVA: 0x360E670 Offset: 0x360E771 VA: 0x360E670 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x360E880 Offset: 0x360E981 VA: 0x360E880 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x360E4E0 Offset: 0x360E5E1 VA: 0x360E4E0
	private void InitializeState() { }

	// RVA: 0x360E680 Offset: 0x360E781 VA: 0x360E680
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x360E890 Offset: 0x360E991 VA: 0x360E890
	private byte[] _EndHash() { }

	// RVA: 0x360EA60 Offset: 0x360EB61 VA: 0x360EA60
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x360F660 Offset: 0x360F761 VA: 0x360F660
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x360F5C0 Offset: 0x360F6C1 VA: 0x360F5C0
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x360F640 Offset: 0x360F741 VA: 0x360F640
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x360F5D0 Offset: 0x360F6D1 VA: 0x360F5D0
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x360F550 Offset: 0x360F651 VA: 0x360F550
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x360F670 Offset: 0x360F771 VA: 0x360F670
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x360F6E0 Offset: 0x360F7E1 VA: 0x360F6E0
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x360F400 Offset: 0x360F501 VA: 0x360F400
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x360F750 Offset: 0x360F851 VA: 0x360F750
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
internal class SHA1Internal // TypeDefIndex: 974
{
	// Fields
	private uint[] _H; // 0x10
	private ulong count; // 0x18
	private byte[] _ProcessingBuffer; // 0x20
	private int _ProcessingBufferCount; // 0x28
	private uint[] buff; // 0x30

	// Methods

	// RVA: 0x3608FA0 Offset: 0x36090A1 VA: 0x3608FA0
	public void .ctor() { }

	// RVA: 0x3609110 Offset: 0x3609211 VA: 0x3609110
	public void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x3609230 Offset: 0x3609331 VA: 0x3609230
	public byte[] HashFinal() { }

	// RVA: 0x3609550 Offset: 0x3609651 VA: 0x3609550
	public void Initialize() { }

	// RVA: 0x3609600 Offset: 0x3609701 VA: 0x3609600
	private void ProcessBlock(byte[] inputBuffer, uint inputOffset) { }

	// RVA: 0x3609F20 Offset: 0x360A021 VA: 0x3609F20
	private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset) { }

	// RVA: 0x360A600 Offset: 0x360A701 VA: 0x360A600
	private static void FillBuff(uint[] buff) { }

	// RVA: 0x3609D50 Offset: 0x3609E51 VA: 0x3609D50
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x360A840 Offset: 0x360A941 VA: 0x360A840
	internal void AddLength(ulong length, byte[] buffer, int position) { }
}

// Namespace: System.Security.Cryptography
[ComVisibleAttribute] // RVA: 0x4743C0 Offset: 0x4744C1 VA: 0x4743C0
public sealed class SHA1CryptoServiceProvider : SHA1 // TypeDefIndex: 975
{
	// Fields
	private SHA1Internal sha; // 0x28

	// Methods

	// RVA: 0x3608F20 Offset: 0x3609021 VA: 0x3608F20
	public void .ctor() { }

	// RVA: 0x3609070 Offset: 0x3609171 VA: 0x3609070 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x36090F0 Offset: 0x36091F1 VA: 0x36090F0 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x3609100 Offset: 0x3609201 VA: 0x3609100 Slot: 17
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x3609220 Offset: 0x3609321 VA: 0x3609220 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x3609540 Offset: 0x3609641 VA: 0x3609540 Slot: 16
	public override void Initialize() { }
}

