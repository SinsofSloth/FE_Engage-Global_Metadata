// Namespace: 
public class AkSourceSettings : IDisposable // TypeDefIndex: 7899
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint sourceID { get; set; }
	public IntPtr pMediaMemory { get; set; }
	public uint uMediaSize { get; set; }

	// Methods

	// RVA: 0x20D5290 Offset: 0x20D5391 VA: 0x20D5290
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x20D52D0 Offset: 0x20D53D1 VA: 0x20D52D0
	internal static IntPtr getCPtr(AkSourceSettings obj) { }

	// RVA: 0x20D5330 Offset: 0x20D5431 VA: 0x20D5330 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x20D5360 Offset: 0x20D5461 VA: 0x20D5360 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x20D53D0 Offset: 0x20D54D1 VA: 0x20D53D0 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x20D5550 Offset: 0x20D5651 VA: 0x20D5550
	public void set_sourceID(uint value) { }

	// RVA: 0x20D55D0 Offset: 0x20D56D1 VA: 0x20D55D0
	public uint get_sourceID() { }

	// RVA: 0x20D5640 Offset: 0x20D5741 VA: 0x20D5640
	public void set_pMediaMemory(IntPtr value) { }

	// RVA: 0x20D56C0 Offset: 0x20D57C1 VA: 0x20D56C0
	public IntPtr get_pMediaMemory() { }

	// RVA: 0x20D5730 Offset: 0x20D5831 VA: 0x20D5730
	public void set_uMediaSize(uint value) { }

	// RVA: 0x20D57B0 Offset: 0x20D58B1 VA: 0x20D57B0
	public uint get_uMediaSize() { }

	// RVA: 0x20D5820 Offset: 0x20D5921 VA: 0x20D5820
	public void Clear() { }

	// RVA: 0x20D5890 Offset: 0x20D5991 VA: 0x20D5890
	public static int GetSizeOf() { }

	// RVA: 0x20D5900 Offset: 0x20D5A01 VA: 0x20D5900
	public void Clone(AkSourceSettings other) { }

	// RVA: 0x20D59C0 Offset: 0x20D5AC1 VA: 0x20D59C0
	public void .ctor() { }
}

