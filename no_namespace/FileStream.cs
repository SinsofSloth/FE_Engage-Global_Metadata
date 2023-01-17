// Namespace: 
private sealed class FileStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 664
{
	// Methods

	// RVA: 0x35EB350 Offset: 0x35EB451 VA: 0x35EB350
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35EB370 Offset: 0x35EB471 VA: 0x35EB370 Slot: 13
	public virtual int Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x35EB710 Offset: 0x35EB811 VA: 0x35EB710 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x35EB7C0 Offset: 0x35EB8C1 VA: 0x35EB7C0 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

