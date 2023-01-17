// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x473550 Offset: 0x473651 VA: 0x473550
public sealed class WaitOrTimerCallback : MulticastDelegate // TypeDefIndex: 785
{
	// Methods

	// RVA: 0x34D0780 Offset: 0x34D0881 VA: 0x34D0780
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x34D07A0 Offset: 0x34D08A1 VA: 0x34D07A0 Slot: 13
	public virtual void Invoke(object state, bool timedOut) { }

	// RVA: 0x34D0B10 Offset: 0x34D0C11 VA: 0x34D0B10 Slot: 14
	public virtual IAsyncResult BeginInvoke(object state, bool timedOut, AsyncCallback callback, object object) { }

	// RVA: 0x34D0BB0 Offset: 0x34D0CB1 VA: 0x34D0BB0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

