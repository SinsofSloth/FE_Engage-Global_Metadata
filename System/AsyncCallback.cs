// Namespace: System
[ComVisibleAttribute] // RVA: 0x46FD20 Offset: 0x46FE21 VA: 0x46FD20
[Serializable]
public sealed class AsyncCallback : MulticastDelegate // TypeDefIndex: 172
{
	// Methods

	// RVA: 0x3569290 Offset: 0x3569391 VA: 0x3569290
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35692B0 Offset: 0x35693B1 VA: 0x35692B0 Slot: 13
	public virtual void Invoke(IAsyncResult ar) { }

	// RVA: 0x3569610 Offset: 0x3569711 VA: 0x3569610 Slot: 14
	public virtual IAsyncResult BeginInvoke(IAsyncResult ar, AsyncCallback callback, object object) { }

	// RVA: 0x3569640 Offset: 0x3569741 VA: 0x3569640 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

