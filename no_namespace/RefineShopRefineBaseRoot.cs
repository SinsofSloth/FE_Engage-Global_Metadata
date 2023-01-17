// Namespace: 
public sealed class RefineShopRefineBaseRoot.ReturnEventHandler : MulticastDelegate // TypeDefIndex: 11153
{
	// Methods

	// RVA: 0x1F35790 Offset: 0x1F35891 VA: 0x1F35790
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F357B0 Offset: 0x1F358B1 VA: 0x1F357B0 Slot: 13
	public virtual void Invoke(BasicMenu.Result result, Unit unit, int ownerItemIndex, ItemData.Kinds kind) { }

	// RVA: 0x1F35A60 Offset: 0x1F35B61 VA: 0x1F35A60 Slot: 14
	public virtual IAsyncResult BeginInvoke(BasicMenu.Result result, Unit unit, int ownerItemIndex, ItemData.Kinds kind, AsyncCallback callback, object object) { }

	// RVA: 0x1F35B50 Offset: 0x1F35C51 VA: 0x1F35B50 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

