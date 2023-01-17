// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x473530 Offset: 0x473631 VA: 0x473530
public sealed class WaitCallback : MulticastDelegate // TypeDefIndex: 784
{
	// Methods

	// RVA: 0x34CEF70 Offset: 0x34CF071 VA: 0x34CEF70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x34CEF90 Offset: 0x34CF091 VA: 0x34CEF90 Slot: 13
	public virtual void Invoke(object state) { }

	// RVA: 0x34CF2F0 Offset: 0x34CF3F1 VA: 0x34CF2F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object state, AsyncCallback callback, object object) { }

	// RVA: 0x34CF320 Offset: 0x34CF421 VA: 0x34CF320 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

