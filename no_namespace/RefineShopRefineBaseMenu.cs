// Namespace: 
public sealed class RefineShopRefineBaseMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11145
{
	// Methods

	// RVA: 0x1F34CA0 Offset: 0x1F34DA1 VA: 0x1F34CA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F34CC0 Offset: 0x1F34DC1 VA: 0x1F34CC0 Slot: 13
	public virtual void Invoke(Unit unit, int ownerItemIndex, ItemData.Kinds kind) { }

	// RVA: 0x1F35060 Offset: 0x1F35161 VA: 0x1F35060 Slot: 14
	public virtual IAsyncResult BeginInvoke(Unit unit, int ownerItemIndex, ItemData.Kinds kind, AsyncCallback callback, object object) { }

	// RVA: 0x1F35130 Offset: 0x1F35231 VA: 0x1F35130 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

