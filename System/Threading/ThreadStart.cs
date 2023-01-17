// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x473590 Offset: 0x473691 VA: 0x473590
public sealed class ThreadStart : MulticastDelegate // TypeDefIndex: 796
{
	// Methods

	// RVA: 0x1B13C40 Offset: 0x1B13D41 VA: 0x1B13C40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1B14940 Offset: 0x1B14A41 VA: 0x1B14940 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1B16C70 Offset: 0x1B16D71 VA: 0x1B16C70 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1B16CA0 Offset: 0x1B16DA1 VA: 0x1B16CA0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

