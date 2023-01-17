// Namespace: 
private sealed class Console.WindowsConsole.WindowsCancelHandler : MulticastDelegate // TypeDefIndex: 352
{
	// Methods

	// RVA: 0x1C0F260 Offset: 0x1C0F361 VA: 0x1C0F260
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C0F280 Offset: 0x1C0F381 VA: 0x1C0F280 Slot: 13
	public virtual bool Invoke(int keyCode) { }

	// RVA: 0x1C0F4B0 Offset: 0x1C0F5B1 VA: 0x1C0F4B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int keyCode, AsyncCallback callback, object object) { }

	// RVA: 0x1C0F540 Offset: 0x1C0F641 VA: 0x1C0F540 Slot: 15
	public virtual bool EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class Console.InternalCancelHandler : MulticastDelegate // TypeDefIndex: 354
{
	// Methods

	// RVA: 0x35E65B0 Offset: 0x35E66B1 VA: 0x35E65B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x35E65D0 Offset: 0x35E66D1 VA: 0x35E65D0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x35E67E0 Offset: 0x35E68E1 VA: 0x35E67E0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x35E6810 Offset: 0x35E6911 VA: 0x35E6810 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

