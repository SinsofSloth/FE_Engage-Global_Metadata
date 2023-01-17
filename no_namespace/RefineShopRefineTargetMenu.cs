// Namespace: 
public sealed class RefineShopRefineTargetMenu.DecideToRefineEventHandler : MulticastDelegate // TypeDefIndex: 11156
{
	// Methods

	// RVA: 0x1F35FA0 Offset: 0x1F360A1 VA: 0x1F35FA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F35FC0 Offset: 0x1F360C1 VA: 0x1F35FC0 Slot: 13
	public virtual void Invoke(int refineLevel, UnitItem refinedUnitItem, int ironNum, int steelNum, int silverNum, int price) { }

	// RVA: 0x1F36260 Offset: 0x1F36361 VA: 0x1F36260 Slot: 14
	public virtual IAsyncResult BeginInvoke(int refineLevel, UnitItem refinedUnitItem, int ironNum, int steelNum, int silverNum, int price, AsyncCallback callback, object object) { }

	// RVA: 0x1F36340 Offset: 0x1F36441 VA: 0x1F36340 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class RefineShopRefineTargetMenu.RequestCloseEventHandler : MulticastDelegate // TypeDefIndex: 11158
{
	// Methods

	// RVA: 0x1F36350 Offset: 0x1F36451 VA: 0x1F36350
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F36370 Offset: 0x1F36471 VA: 0x1F36370 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F36580 Offset: 0x1F36681 VA: 0x1F36580 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F365B0 Offset: 0x1F366B1 VA: 0x1F365B0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

