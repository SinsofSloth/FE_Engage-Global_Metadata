// Namespace: App
public sealed class ProcVoidFunction : MulticastDelegate // TypeDefIndex: 13862
{
	// Methods

	// RVA: 0x29E6180 Offset: 0x29E6281 VA: 0x29E6180
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x29E1D10 Offset: 0x29E1E11 VA: 0x29E1D10 Slot: 13
	public virtual void Invoke(ProcInst inst) { }

	// RVA: 0x29E61A0 Offset: 0x29E62A1 VA: 0x29E61A0 Slot: 14
	public virtual IAsyncResult BeginInvoke(ProcInst inst, AsyncCallback callback, object object) { }

	// RVA: 0x29E61D0 Offset: 0x29E62D1 VA: 0x29E61D0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

