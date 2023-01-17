// Namespace: System.Runtime.InteropServices
public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 1317
{
	// Fields
	private bool inited; // 0x1E

	// Methods

	[ReliabilityContractAttribute] // RVA: 0x47D730 Offset: 0x47D831 VA: 0x47D730
	[CLSCompliantAttribute] // RVA: 0x47D730 Offset: 0x47D831 VA: 0x47D730
	// RVA: 0x360F980 Offset: 0x360FA81 VA: 0x360F980
	public void AcquirePointer(ref byte* pointer) { }

	[ReliabilityContractAttribute] // RVA: 0x47D780 Offset: 0x47D881 VA: 0x47D780
	// RVA: 0x360FAE0 Offset: 0x360FBE1 VA: 0x360FAE0
	public void ReleasePointer() { }
}

