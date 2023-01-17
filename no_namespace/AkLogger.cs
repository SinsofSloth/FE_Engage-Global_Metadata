// Namespace: 
[UnmanagedFunctionPointerAttribute] // RVA: 0x271CB0 Offset: 0x271DB1 VA: 0x271CB0
public sealed class AkLogger.ErrorLoggerInteropDelegate : MulticastDelegate // TypeDefIndex: 7948
{
	// Methods

	// RVA: 0x24B36C0 Offset: 0x24B37C1 VA: 0x24B36C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24B36E0 Offset: 0x24B37E1 VA: 0x24B36E0 Slot: 13
	public virtual void Invoke(string message) { }

	// RVA: 0x24B3A40 Offset: 0x24B3B41 VA: 0x24B3A40 Slot: 14
	public virtual IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

	// RVA: 0x24B3A70 Offset: 0x24B3B71 VA: 0x24B3A70 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

