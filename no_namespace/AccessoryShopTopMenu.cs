// Namespace: 
public enum AccessoryShopTopMenu.Result2 // TypeDefIndex: 10917
{
	// Fields
	public int value__; // 0x0
	public const AccessoryShopTopMenu.Result2 Buy = 0;
	public const AccessoryShopTopMenu.Result2 Change = 1;
	public const AccessoryShopTopMenu.Result2 End = 2;
}

// Namespace: 
public sealed class AccessoryShopTopMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 10918
{
	// Methods

	// RVA: 0x24AC090 Offset: 0x24AC191 VA: 0x24AC090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x24ABD50 Offset: 0x24ABE51 VA: 0x24ABD50 Slot: 13
	public virtual void Invoke(AccessoryShopTopMenu.Result2 result) { }

	// RVA: 0x24AC0B0 Offset: 0x24AC1B1 VA: 0x24AC0B0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AccessoryShopTopMenu.Result2 result, AsyncCallback callback, object object) { }

	// RVA: 0x24AC140 Offset: 0x24AC241 VA: 0x24AC140 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class AccessoryShopTopMenu.BuyMenuItem : BasicMenuItem // TypeDefIndex: 10919
{
	// Fields
	public AccessoryShopTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x24ABC70 Offset: 0x24ABD71 VA: 0x24ABC70
	public void .ctor(AccessoryShopTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x24ABD20 Offset: 0x24ABE21 VA: 0x24ABD20 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class AccessoryShopTopMenu.ChangeMenuItem : BasicMenuItem // TypeDefIndex: 10920
{
	// Fields
	public AccessoryShopTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x24ABFB0 Offset: 0x24AC0B1 VA: 0x24ABFB0
	public void .ctor(AccessoryShopTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x24AC060 Offset: 0x24AC161 VA: 0x24AC060 Slot: 18
	public override BasicMenu.Result ACall() { }
}

