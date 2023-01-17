// Namespace: 
public sealed class WeaponShopTopMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11262
{
	// Methods

	// RVA: 0x1DBCAA0 Offset: 0x1DBCBA1 VA: 0x1DBCAA0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1DBC840 Offset: 0x1DBC941 VA: 0x1DBC840 Slot: 13
	public virtual void Invoke(WeaponShopTopMenu.Result2 result) { }

	// RVA: 0x1DBCAC0 Offset: 0x1DBCBC1 VA: 0x1DBCAC0 Slot: 14
	public virtual IAsyncResult BeginInvoke(WeaponShopTopMenu.Result2 result, AsyncCallback callback, object object) { }

	// RVA: 0x1DBCB50 Offset: 0x1DBCC51 VA: 0x1DBCB50 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class WeaponShopTopMenu.SellMenuItem : BasicMenuItem // TypeDefIndex: 11264
{
	// Fields
	public WeaponShopTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1DBCB60 Offset: 0x1DBCC61 VA: 0x1DBCB60
	public void .ctor(WeaponShopTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1DBCC10 Offset: 0x1DBCD11 VA: 0x1DBCC10 Slot: 18
	public override BasicMenu.Result ACall() { }
}

