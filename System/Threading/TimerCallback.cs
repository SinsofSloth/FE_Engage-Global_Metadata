// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x473710 Offset: 0x473811 VA: 0x473710
public sealed class TimerCallback : MulticastDelegate // TypeDefIndex: 813
{
	// Methods

	// RVA: 0x1B24560 Offset: 0x1B24661 VA: 0x1B24560
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1B24580 Offset: 0x1B24681 VA: 0x1B24580 Slot: 13
	public virtual void Invoke(object state) { }

	// RVA: 0x1B248E0 Offset: 0x1B249E1 VA: 0x1B248E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(object state, AsyncCallback callback, object object) { }

	// RVA: 0x1B24910 Offset: 0x1B24A11 VA: 0x1B24910 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

