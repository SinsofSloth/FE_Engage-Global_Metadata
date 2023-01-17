// Namespace: 
public sealed class ShopSellMenuItem.CancelItemEventHandler : MulticastDelegate // TypeDefIndex: 11197
{
	// Methods

	// RVA: 0x2039640 Offset: 0x2039741 VA: 0x2039640
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2039660 Offset: 0x2039761 VA: 0x2039660 Slot: 13
	public virtual void Invoke(int itemIndex) { }

	// RVA: 0x2039890 Offset: 0x2039991 VA: 0x2039890 Slot: 14
	public virtual IAsyncResult BeginInvoke(int itemIndex, AsyncCallback callback, object object) { }

	// RVA: 0x2039920 Offset: 0x2039A21 VA: 0x2039920 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

