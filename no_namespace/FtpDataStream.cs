// Namespace: 
private sealed class FtpDataStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 2546
{
	// Methods

	// RVA: 0x1917F70 Offset: 0x1918071 VA: 0x1917F70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1917F90 Offset: 0x1918091 VA: 0x1917F90 Slot: 13
	public virtual int Invoke(byte[] buffer, int offset, int size) { }

	// RVA: 0x1918330 Offset: 0x1918431 VA: 0x1918330 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, AsyncCallback callback, object object) { }

	// RVA: 0x19183E0 Offset: 0x19184E1 VA: 0x19183E0 Slot: 15
	public virtual int EndInvoke(IAsyncResult result) { }
}

