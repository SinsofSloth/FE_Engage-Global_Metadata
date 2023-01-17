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

// Namespace: 
private sealed class FileStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 665
{
	// Methods

	// RVA: 0x35EB7F0 Offset: 0x35EB8F1 VA: 0x35EB7F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35EB810 Offset: 0x35EB911 VA: 0x35EB810 Slot: 13
	public virtual void Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x35EBBB0 Offset: 0x35EBCB1 VA: 0x35EBBB0 Slot: 14
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x35EBC60 Offset: 0x35EBD61 VA: 0x35EBC60 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

