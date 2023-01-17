// Namespace: System.Threading
[ComVisibleAttribute] // RVA: 0x473390 Offset: 0x473491 VA: 0x473390
public sealed class ParameterizedThreadStart : MulticastDelegate // TypeDefIndex: 767
{
	// Methods

	// RVA: 0x38197C0 Offset: 0x38198C1 VA: 0x38197C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x38197E0 Offset: 0x38198E1 VA: 0x38197E0 Slot: 13
	public virtual void Invoke(object obj) { }

	// RVA: 0x3819B40 Offset: 0x3819C41 VA: 0x3819B40 Slot: 14
	public virtual IAsyncResult BeginInvoke(object obj, AsyncCallback callback, object object) { }

	// RVA: 0x3819B70 Offset: 0x3819C71 VA: 0x3819B70 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

