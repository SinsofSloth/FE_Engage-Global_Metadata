// Namespace: 
public class AkDeviceSettings : IDisposable // TypeDefIndex: 7844
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public IntPtr pIOMemory { get; set; }
	public uint uIOMemorySize { get; set; }
	public uint uIOMemoryAlignment { get; set; }
	public uint ePoolAttributes { get; set; }
	public uint uGranularity { get; set; }
	public uint uSchedulerTypeFlags { get; set; }
	public AkThreadProperties threadProperties { get; set; }
	public float fTargetAutoStmBufferLength { get; set; }
	public uint uMaxConcurrentIO { get; set; }
	public bool bUseStreamCache { get; set; }
	public uint uMaxCachePinnedBytes { get; set; }

	// Methods

	// RVA: 0x316EBD0 Offset: 0x316ECD1 VA: 0x316EBD0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x316EC10 Offset: 0x316ED11 VA: 0x316EC10
	internal static IntPtr getCPtr(AkDeviceSettings obj) { }

	// RVA: 0x316EC70 Offset: 0x316ED71 VA: 0x316EC70 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x316ECA0 Offset: 0x316EDA1 VA: 0x316ECA0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x316ED10 Offset: 0x316EE11 VA: 0x316ED10 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x316EEA0 Offset: 0x316EFA1 VA: 0x316EEA0
	public void set_pIOMemory(IntPtr value) { }

	// RVA: 0x316EF20 Offset: 0x316F021 VA: 0x316EF20
	public IntPtr get_pIOMemory() { }

	// RVA: 0x3169780 Offset: 0x3169881 VA: 0x3169780
	public void set_uIOMemorySize(uint value) { }

	// RVA: 0x316EF90 Offset: 0x316F091 VA: 0x316EF90
	public uint get_uIOMemorySize() { }

	// RVA: 0x316F000 Offset: 0x316F101 VA: 0x316F000
	public void set_uIOMemoryAlignment(uint value) { }

	// RVA: 0x316F080 Offset: 0x316F181 VA: 0x316F080
	public uint get_uIOMemoryAlignment() { }

	// RVA: 0x316F0F0 Offset: 0x316F1F1 VA: 0x316F0F0
	public void set_ePoolAttributes(uint value) { }

	// RVA: 0x316F170 Offset: 0x316F271 VA: 0x316F170
	public uint get_ePoolAttributes() { }

	// RVA: 0x316F1E0 Offset: 0x316F2E1 VA: 0x316F1E0
	public void set_uGranularity(uint value) { }

	// RVA: 0x316F260 Offset: 0x316F361 VA: 0x316F260
	public uint get_uGranularity() { }

	// RVA: 0x316F2D0 Offset: 0x316F3D1 VA: 0x316F2D0
	public void set_uSchedulerTypeFlags(uint value) { }

	// RVA: 0x316F350 Offset: 0x316F451 VA: 0x316F350
	public uint get_uSchedulerTypeFlags() { }

	// RVA: 0x316C550 Offset: 0x316C651 VA: 0x316C550
	public void set_threadProperties(AkThreadProperties value) { }

	// RVA: 0x316C1A0 Offset: 0x316C2A1 VA: 0x316C1A0
	public AkThreadProperties get_threadProperties() { }

	// RVA: 0x3169800 Offset: 0x3169901 VA: 0x3169800
	public void set_fTargetAutoStmBufferLength(float value) { }

	// RVA: 0x316F3C0 Offset: 0x316F4C1 VA: 0x316F3C0
	public float get_fTargetAutoStmBufferLength() { }

	// RVA: 0x316F430 Offset: 0x316F531 VA: 0x316F430
	public void set_uMaxConcurrentIO(uint value) { }

	// RVA: 0x316F4B0 Offset: 0x316F5B1 VA: 0x316F4B0
	public uint get_uMaxConcurrentIO() { }

	// RVA: 0x3169880 Offset: 0x3169981 VA: 0x3169880
	public void set_bUseStreamCache(bool value) { }

	// RVA: 0x316F520 Offset: 0x316F621 VA: 0x316F520
	public bool get_bUseStreamCache() { }

	// RVA: 0x3169900 Offset: 0x3169A01 VA: 0x3169900
	public void set_uMaxCachePinnedBytes(uint value) { }

	// RVA: 0x316F590 Offset: 0x316F691 VA: 0x316F590
	public uint get_uMaxCachePinnedBytes() { }
}

