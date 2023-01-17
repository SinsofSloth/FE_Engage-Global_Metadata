// Namespace: 
public sealed class ShopUnitSelectMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11210
{
	// Methods

	// RVA: 0x203AB20 Offset: 0x203AC21 VA: 0x203AB20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x203AB40 Offset: 0x203AC41 VA: 0x203AB40 Slot: 13
	public virtual void Invoke(BasicMenu.Result result, Unit unit, int scrollIndex) { }

	// RVA: 0x203ADD0 Offset: 0x203AED1 VA: 0x203ADD0 Slot: 14
	public virtual IAsyncResult BeginInvoke(BasicMenu.Result result, Unit unit, int scrollIndex, AsyncCallback callback, object object) { }

	// RVA: 0x203AE90 Offset: 0x203AF91 VA: 0x203AE90 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ShopUnitSelectMenu.HelpEventHandler : MulticastDelegate // TypeDefIndex: 11212
{
	// Methods

	// RVA: 0x203AEA0 Offset: 0x203AFA1 VA: 0x203AEA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x203AEC0 Offset: 0x203AFC1 VA: 0x203AEC0 Slot: 13
	public virtual void Invoke(ProcInst parent) { }

	// RVA: 0x203B220 Offset: 0x203B321 VA: 0x203B220 Slot: 14
	public virtual IAsyncResult BeginInvoke(ProcInst parent, AsyncCallback callback, object object) { }

	// RVA: 0x203B250 Offset: 0x203B351 VA: 0x203B250 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

