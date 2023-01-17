// Namespace: 
public sealed class RefineShopTopMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11168
{
	// Methods

	// RVA: 0x1F36DC0 Offset: 0x1F36EC1 VA: 0x1F36DC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F36DE0 Offset: 0x1F36EE1 VA: 0x1F36DE0 Slot: 13
	public virtual void Invoke(RefineShopTopMenu.Result2 result) { }

	// RVA: 0x1F37040 Offset: 0x1F37141 VA: 0x1F37040 Slot: 14
	public virtual IAsyncResult BeginInvoke(RefineShopTopMenu.Result2 result, AsyncCallback callback, object object) { }

	// RVA: 0x1F370D0 Offset: 0x1F371D1 VA: 0x1F370D0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class RefineShopTopMenu.RefineShopTopEngraveMenuItem : BasicMenuItem // TypeDefIndex: 11170
{
	// Fields
	private RefineShopTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1F370E0 Offset: 0x1F371E1 VA: 0x1F370E0
	public void .ctor(RefineShopTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1F37120 Offset: 0x1F37221 VA: 0x1F37120 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F371A0 Offset: 0x1F372A1 VA: 0x1F371A0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

