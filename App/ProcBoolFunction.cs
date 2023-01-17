// Namespace: App
public sealed class ProcBoolFunction : MulticastDelegate // TypeDefIndex: 13863
{
	// Methods

	// RVA: 0x29E15A0 Offset: 0x29E16A1 VA: 0x29E15A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x29E15C0 Offset: 0x29E16C1 VA: 0x29E15C0 Slot: 13
	public virtual bool Invoke(ProcInst inst) { }

	// RVA: 0x29E1920 Offset: 0x29E1A21 VA: 0x29E1920 Slot: 14
	public virtual IAsyncResult BeginInvoke(ProcInst inst, AsyncCallback callback, object object) { }

	// RVA: 0x29E1950 Offset: 0x29E1A51 VA: 0x29E1950 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

