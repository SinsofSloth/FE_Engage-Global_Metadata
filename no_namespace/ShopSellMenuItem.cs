// Namespace: 
public sealed class ShopSellMenuItem.DecideItemEventHandler : MulticastDelegate // TypeDefIndex: 11196
{
	// Methods

	// RVA: 0x2039930 Offset: 0x2039A31 VA: 0x2039930
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2039950 Offset: 0x2039A51 VA: 0x2039950 Slot: 13
	public virtual void Invoke(int itemIndex) { }

	// RVA: 0x2039B80 Offset: 0x2039C81 VA: 0x2039B80 Slot: 14
	public virtual IAsyncResult BeginInvoke(int itemIndex, AsyncCallback callback, object object) { }

	// RVA: 0x2039C10 Offset: 0x2039D11 VA: 0x2039C10 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

