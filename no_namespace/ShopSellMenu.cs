// Namespace: 
public enum ShopSellMenu.KindIndicator // TypeDefIndex: 11186
{
	// Fields
	public int value__; // 0x0
	public const ShopSellMenu.KindIndicator None = 0;
	public const ShopSellMenu.KindIndicator First = 1;
	public const ShopSellMenu.KindIndicator Last = 2;
}

// Namespace: 
public sealed class ShopSellMenu.DecideItemEventHandler : MulticastDelegate // TypeDefIndex: 11188
{
	// Methods

	// RVA: 0x2038A80 Offset: 0x2038B81 VA: 0x2038A80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2038AA0 Offset: 0x2038BA1 VA: 0x2038AA0 Slot: 13
	public virtual void Invoke(int itemCount, int totalValue) { }

	// RVA: 0x2038CE0 Offset: 0x2038DE1 VA: 0x2038CE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(int itemCount, int totalValue, AsyncCallback callback, object object) { }

	// RVA: 0x2038D80 Offset: 0x2038E81 VA: 0x2038D80 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ShopSellMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11190
{
	// Methods

	// RVA: 0x2038810 Offset: 0x2038911 VA: 0x2038810
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2038830 Offset: 0x2038931 VA: 0x2038830 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x2038A40 Offset: 0x2038B41 VA: 0x2038A40 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x2038A70 Offset: 0x2038B71 VA: 0x2038A70 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ShopSellMenu.ChangeUnitToPrevEventHandler : MulticastDelegate // TypeDefIndex: 11192
{
	// Methods

	// RVA: 0x20385A0 Offset: 0x20386A1 VA: 0x20385A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x20385C0 Offset: 0x20386C1 VA: 0x20385C0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x20387D0 Offset: 0x20388D1 VA: 0x20387D0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x2038800 Offset: 0x2038901 VA: 0x2038800 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ShopSellMenu.SwitchDetailDisplaywayEventHandler : MulticastDelegate // TypeDefIndex: 11194
{
	// Methods

	// RVA: 0x20393C0 Offset: 0x20394C1 VA: 0x20393C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x20393E0 Offset: 0x20394E1 VA: 0x20393E0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x20395F0 Offset: 0x20396F1 VA: 0x20395F0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x2039620 Offset: 0x2039721 VA: 0x2039620 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

