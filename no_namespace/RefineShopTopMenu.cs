// Namespace: 
public enum RefineShopTopMenu.Result2 // TypeDefIndex: 11167
{
	// Fields
	public int value__; // 0x0
	public const RefineShopTopMenu.Result2 Refine = 0;
	public const RefineShopTopMenu.Result2 Engrave = 1;
	public const RefineShopTopMenu.Result2 Exchange = 2;
	public const RefineShopTopMenu.Result2 End = 3;
}

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
private class RefineShopTopMenu.RefineShopTopRefineMenuItem : BasicMenuItem // TypeDefIndex: 11169
{
	// Fields
	private RefineShopTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1F372C0 Offset: 0x1F373C1 VA: 0x1F372C0
	public void .ctor(RefineShopTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1F37300 Offset: 0x1F37401 VA: 0x1F37300 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F37380 Offset: 0x1F37481 VA: 0x1F37380 Slot: 18
	public override BasicMenu.Result ACall() { }
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

// Namespace: 
private class RefineShopTopMenu.RefineShopTopExchangeMenuItem : BasicMenuItem // TypeDefIndex: 11171
{
	// Fields
	private RefineShopTopMenu.DecideEventHandler m_DecideEventHandler; // 0x68

	// Methods

	// RVA: 0x1F371D0 Offset: 0x1F372D1 VA: 0x1F371D0
	public void .ctor(RefineShopTopMenu.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1F37210 Offset: 0x1F37311 VA: 0x1F37210 Slot: 4
	public override string GetName() { }

	// RVA: 0x1F37290 Offset: 0x1F37391 VA: 0x1F37290 Slot: 18
	public override BasicMenu.Result ACall() { }
}

