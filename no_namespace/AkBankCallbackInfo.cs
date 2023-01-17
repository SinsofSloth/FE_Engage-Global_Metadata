// Namespace: 
public class AkBankCallbackInfo : IDisposable // TypeDefIndex: 7831
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public uint bankID { get; }
	public IntPtr inMemoryBankPtr { get; }
	public AKRESULT loadResult { get; }

	// Methods

	// RVA: 0x2ED2270 Offset: 0x2ED2371 VA: 0x2ED2270
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x2ED22B0 Offset: 0x2ED23B1 VA: 0x2ED22B0
	internal static IntPtr getCPtr(AkBankCallbackInfo obj) { }

	// RVA: 0x2ED2310 Offset: 0x2ED2411 VA: 0x2ED2310 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x2ED2340 Offset: 0x2ED2441 VA: 0x2ED2340 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2ED23B0 Offset: 0x2ED24B1 VA: 0x2ED23B0 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x2ED2540 Offset: 0x2ED2641 VA: 0x2ED2540
	public uint get_bankID() { }

	// RVA: 0x2ED25B0 Offset: 0x2ED26B1 VA: 0x2ED25B0
	public IntPtr get_inMemoryBankPtr() { }

	// RVA: 0x2ED2620 Offset: 0x2ED2721 VA: 0x2ED2620
	public AKRESULT get_loadResult() { }

	// RVA: 0x2ED2690 Offset: 0x2ED2791 VA: 0x2ED2690
	public void .ctor() { }
}

