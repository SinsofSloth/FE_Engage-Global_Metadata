// Namespace: System.Runtime.InteropServices
public abstract class SafeHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 1312
{
	// Fields
	protected IntPtr handle; // 0x10
	private int _state; // 0x18
	private bool _ownsHandle; // 0x1C
	private bool _fullyInitialized; // 0x1D
	private const int RefCount_Mask = 2147483644;
	private const int RefCount_One = 4;

	// Properties
	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }

	// Methods

	[ReliabilityContractAttribute] // RVA: 0x47D3E0 Offset: 0x47D4E1 VA: 0x47D3E0
	// RVA: 0x360FEE0 Offset: 0x360FFE1 VA: 0x360FEE0
	protected void .ctor(IntPtr invalidHandleValue, bool ownsHandle) { }

	// RVA: 0x360FF90 Offset: 0x3610091 VA: 0x360FF90 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContractAttribute] // RVA: 0x47D400 Offset: 0x47D501 VA: 0x47D400
	// RVA: 0x3610010 Offset: 0x3610111 VA: 0x3610010
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContractAttribute] // RVA: 0x47D420 Offset: 0x47D521 VA: 0x47D420
	// RVA: 0x3610020 Offset: 0x3610121 VA: 0x3610020
	public IntPtr DangerousGetHandle() { }

	[ReliabilityContractAttribute] // RVA: 0x47D440 Offset: 0x47D541 VA: 0x47D440
	// RVA: 0x3610030 Offset: 0x3610131 VA: 0x3610030
	public bool get_IsClosed() { }

	[ReliabilityContractAttribute] // RVA: 0x47D460 Offset: 0x47D561 VA: 0x47D460
	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsInvalid();

	[ReliabilityContractAttribute] // RVA: 0x47D480 Offset: 0x47D581 VA: 0x47D480
	// RVA: 0x3610040 Offset: 0x3610141 VA: 0x3610040
	public void Close() { }

	[ReliabilityContractAttribute] // RVA: 0x47D4A0 Offset: 0x47D5A1 VA: 0x47D4A0
	// RVA: 0x3610050 Offset: 0x3610151 VA: 0x3610050 Slot: 4
	public void Dispose() { }

	[ReliabilityContractAttribute] // RVA: 0x47D4C0 Offset: 0x47D5C1 VA: 0x47D4C0
	// RVA: 0x3610060 Offset: 0x3610161 VA: 0x3610060 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContractAttribute] // RVA: 0x47D4E0 Offset: 0x47D5E1 VA: 0x47D4E0
	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool ReleaseHandle();

	[ReliabilityContractAttribute] // RVA: 0x47D500 Offset: 0x47D601 VA: 0x47D500
	// RVA: 0x3610150 Offset: 0x3610251 VA: 0x3610150
	public void SetHandleAsInvalid() { }

	[ReliabilityContractAttribute] // RVA: 0x47D520 Offset: 0x47D621 VA: 0x47D520
	// RVA: 0x360FA10 Offset: 0x360FB11 VA: 0x360FA10
	public void DangerousAddRef(ref bool success) { }

	[ReliabilityContractAttribute] // RVA: 0x47D540 Offset: 0x47D641 VA: 0x47D540
	// RVA: 0x360FB40 Offset: 0x360FC41 VA: 0x360FB40
	public void DangerousRelease() { }

	// RVA: 0x3610080 Offset: 0x3610181 VA: 0x3610080
	private void InternalDispose() { }

	// RVA: 0x3610130 Offset: 0x3610231 VA: 0x3610130
	private void InternalFinalize() { }

	// RVA: 0x36101E0 Offset: 0x36102E1 VA: 0x36101E0
	private void DangerousReleaseInternal(bool dispose) { }
}

