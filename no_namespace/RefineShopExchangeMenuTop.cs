// Namespace: 
public sealed class RefineShopExchangeMenuTop.CloseEventHandler : MulticastDelegate // TypeDefIndex: 11127
{
	// Methods

	// RVA: 0x1F33ED0 Offset: 0x1F33FD1 VA: 0x1F33ED0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F33EF0 Offset: 0x1F33FF1 VA: 0x1F33EF0 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F34100 Offset: 0x1F34201 VA: 0x1F34100 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F34130 Offset: 0x1F34231 VA: 0x1F34130 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private enum RefineShopExchangeMenuTop.Label // TypeDefIndex: 11128
{
	// Fields
	public int value__; // 0x0
	public const RefineShopExchangeMenuTop.Label Entry = 0;
	public const RefineShopExchangeMenuTop.Label TargetMenu = 1;
	public const RefineShopExchangeMenuTop.Label SourceMenu = 2;
	public const RefineShopExchangeMenuTop.Label CountMenu = 3;
	public const RefineShopExchangeMenuTop.Label End = 4;
}

// Namespace: 
public sealed class RefineShopExchangeMenuTop.ConfirmDialog.YesEventHandler : MulticastDelegate // TypeDefIndex: 11129
{
	// Methods

	// RVA: 0x21F4730 Offset: 0x21F4831 VA: 0x21F4730
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x21F4750 Offset: 0x21F4851 VA: 0x21F4750 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x21F4960 Offset: 0x21F4A61 VA: 0x21F4960 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x21F4990 Offset: 0x21F4A91 VA: 0x21F4990 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class RefineShopExchangeMenuTop.ConfirmDialog.YesMenuItem : BasicDialogItemYes // TypeDefIndex: 11130
{
	// Fields
	private RefineShopExchangeMenuTop.ConfirmDialog.YesEventHandler m_YesEventHandler; // 0x70

	// Methods

	// RVA: 0x21F49A0 Offset: 0x21F4AA1 VA: 0x21F49A0
	public void .ctor(string message, RefineShopExchangeMenuTop.ConfirmDialog.YesEventHandler yesEventHandler) { }

	// RVA: 0x21F49E0 Offset: 0x21F4AE1 VA: 0x21F49E0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
public class RefineShopExchangeMenuTop.ConfirmDialog // TypeDefIndex: 11131
{
	// Fields
	private static StringBuilder m_StringBuilder; // 0x0

	// Methods

	// RVA: 0x1F34140 Offset: 0x1F34241 VA: 0x1F34140
	public static ExchangeYesNoDialog CreateBind(ProcInst super, string sourceMaterialId, string targetMaterialId, int sourceNum, int targetNum, int targetOverflow, RefineShopExchangeMenuTop.ConfirmDialog.YesEventHandler yesEventHandler) { }

	// RVA: 0x1F34720 Offset: 0x1F34821 VA: 0x1F34720
	public void .ctor() { }

	// RVA: 0x1F34730 Offset: 0x1F34831 VA: 0x1F34730
	private static void .cctor() { }
}

