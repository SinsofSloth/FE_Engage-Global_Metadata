// Namespace: 
public class AkSerializedCallbackHeader : IDisposable // TypeDefIndex: 7897
{
	// Fields
	private IntPtr swigCPtr; // 0x10
	protected bool swigCMemOwn; // 0x18

	// Properties
	public IntPtr pPackage { get; }
	public AkSerializedCallbackHeader pNext { get; }
	public AkCallbackType eType { get; }

	// Methods

	// RVA: 0x20B8630 Offset: 0x20B8731 VA: 0x20B8630
	internal void .ctor(IntPtr cPtr, bool cMemoryOwn) { }

	// RVA: 0x20B8670 Offset: 0x20B8771 VA: 0x20B8670
	internal static IntPtr getCPtr(AkSerializedCallbackHeader obj) { }

	// RVA: 0x20B86D0 Offset: 0x20B87D1 VA: 0x20B86D0 Slot: 5
	internal virtual void setCPtr(IntPtr cPtr) { }

	// RVA: 0x20B8700 Offset: 0x20B8801 VA: 0x20B8700 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x20B8770 Offset: 0x20B8871 VA: 0x20B8770 Slot: 6
	public virtual void Dispose() { }

	// RVA: 0x20B8900 Offset: 0x20B8A01 VA: 0x20B8900
	public IntPtr get_pPackage() { }

	// RVA: 0x20B8980 Offset: 0x20B8A81 VA: 0x20B8980
	public AkSerializedCallbackHeader get_pNext() { }

	// RVA: 0x20B8A60 Offset: 0x20B8B61 VA: 0x20B8A60
	public AkCallbackType get_eType() { }

	// RVA: 0x20B8AE0 Offset: 0x20B8BE1 VA: 0x20B8AE0
	public IntPtr GetData() { }

	// RVA: 0x20B8B60 Offset: 0x20B8C61 VA: 0x20B8B60
	public void .ctor() { }
}

