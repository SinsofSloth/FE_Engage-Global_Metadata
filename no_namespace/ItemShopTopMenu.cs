// Namespace: 
public sealed class ItemShopTopMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11028
{
	// Methods

	// RVA: 0x222A730 Offset: 0x222A831 VA: 0x222A730
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x222A4D0 Offset: 0x222A5D1 VA: 0x222A4D0 Slot: 13
	public virtual void Invoke(ItemShopTopMenu.Result2 result) { }

	// RVA: 0x222A750 Offset: 0x222A851 VA: 0x222A750 Slot: 14
	public virtual IAsyncResult BeginInvoke(ItemShopTopMenu.Result2 result, AsyncCallback callback, object object) { }

	// RVA: 0x222A7E0 Offset: 0x222A8E1 VA: 0x222A7E0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class ItemShopTopMenu.SellMenuItem : BasicMenuItem // TypeDefIndex: 11030
{
	// Fields
	public ItemShopTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x222A7F0 Offset: 0x222A8F1 VA: 0x222A7F0
	public void .ctor(ItemShopTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x222A830 Offset: 0x222A931 VA: 0x222A830 Slot: 4
	public override string GetName() { }

	// RVA: 0x222A8B0 Offset: 0x222A9B1 VA: 0x222A8B0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

