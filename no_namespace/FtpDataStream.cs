// Namespace: 
private sealed class FtpDataStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 2545
{
	// Methods

	// RVA: 0x1918410 Offset: 0x1918511 VA: 0x1918410
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1918430 Offset: 0x1918531 VA: 0x1918430 Slot: 13
	public virtual void Invoke(byte[] buffer, int offset, int size) { }

	// RVA: 0x19187D0 Offset: 0x19188D1 VA: 0x19187D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int size, AsyncCallback callback, object object) { }

	// RVA: 0x1918880 Offset: 0x1918981 VA: 0x1918880 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

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

