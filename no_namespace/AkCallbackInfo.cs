// Namespace: 
public class AkCallbackInfo : IDisposable // TypeDefIndex: 7834
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public IntPtr pCookie { get; }
	public ulong gameObjID { get; }

	// Methods

	// RVA: 0x2ED41C0 Offset: 0x2ED42C1 VA: 0x2ED41C0
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x2ED4200 Offset: 0x2ED4301 VA: 0x2ED4200
	internal static IntPtr getCPtr(AkCallbackInfo obj) { }

	// RVA: 0x2ED4260 Offset: 0x2ED4361 VA: 0x2ED4260 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x2ED4290 Offset: 0x2ED4391 VA: 0x2ED4290 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2ED4300 Offset: 0x2ED4401 VA: 0x2ED4300 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x2ED4490 Offset: 0x2ED4591 VA: 0x2ED4490
	public IntPtr get_pCookie() { }

	// RVA: 0x2ED4500 Offset: 0x2ED4601 VA: 0x2ED4500
	public ulong get_gameObjID() { }

	// RVA: 0x2ED4570 Offset: 0x2ED4671 VA: 0x2ED4570
	public void .ctor() { }
}

