// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x473320 Offset: 0x473421 VA: 0x473320
public sealed class ContextCallback : MulticastDelegate // TypeDefIndex: 757
{
	// Methods

	// RVA: 0x33B3E00 Offset: 0x33B3F01 VA: 0x33B3E00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x33B3E20 Offset: 0x33B3F21 VA: 0x33B3E20 Slot: 13
	public virtual void Invoke(object state) { }

	// RVA: 0x33B4180 Offset: 0x33B4281 VA: 0x33B4180 Slot: 14
	public virtual IAsyncResult BeginInvoke(object state, AsyncCallback callback, object object) { }

	// RVA: 0x33B41B0 Offset: 0x33B42B1 VA: 0x33B41B0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

