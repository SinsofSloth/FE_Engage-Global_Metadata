// Namespace: 
public sealed class Warning.Logger : MulticastDelegate // TypeDefIndex: 14313
{
	// Methods

	// RVA: 0x1DBA270 Offset: 0x1DBA371 VA: 0x1DBA270
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1DBA290 Offset: 0x1DBA391 VA: 0x1DBA290 Slot: 13
	public virtual void Invoke(string message) { }

	// RVA: 0x1DBA5F0 Offset: 0x1DBA6F1 VA: 0x1DBA5F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

	// RVA: 0x1DBA620 Offset: 0x1DBA721 VA: 0x1DBA620 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

