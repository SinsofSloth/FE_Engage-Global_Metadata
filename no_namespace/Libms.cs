// Namespace: 
public sealed class Libms.LMSFreePtr : MulticastDelegate // TypeDefIndex: 15040
{
	// Methods

	// RVA: 0x2230E90 Offset: 0x2230F91 VA: 0x2230E90
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2230EB0 Offset: 0x2230FB1 VA: 0x2230EB0 Slot: 13
	public virtual void Invoke(IntPtr ptr) { }

	// RVA: 0x22310E0 Offset: 0x22311E1 VA: 0x22310E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(IntPtr ptr, AsyncCallback callback, object object) { }

	// RVA: 0x2231170 Offset: 0x2231271 VA: 0x2231170 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

