// Namespace: 
public enum RefreshConfirmDialog.Result2 // TypeDefIndex: 11679
{
	// Fields
	public int value__; // 0x0
	public const RefreshConfirmDialog.Result2 Ok = 0;
	public const RefreshConfirmDialog.Result2 OkWithoutDemo = 1;
	public const RefreshConfirmDialog.Result2 Cancel = 2;
}

// Namespace: 
public sealed class RefreshConfirmDialog.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11680
{
	// Methods

	// RVA: 0x1F373B0 Offset: 0x1F374B1 VA: 0x1F373B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F373D0 Offset: 0x1F374D1 VA: 0x1F373D0 Slot: 13
	public virtual void Invoke(RefreshConfirmDialog.Result2 result) { }

	// RVA: 0x1F37630 Offset: 0x1F37731 VA: 0x1F37630 Slot: 14
	public virtual IAsyncResult BeginInvoke(RefreshConfirmDialog.Result2 result, AsyncCallback callback, object object) { }

	// RVA: 0x1F376C0 Offset: 0x1F377C1 VA: 0x1F376C0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class RefreshConfirmDialog.DialogMenuItem : BasicDialogItem // TypeDefIndex: 11681
{
	// Fields
	private RefreshConfirmDialog.Result2 m_Result; // 0x70
	private RefreshConfirmDialog.DecideEventHandler m_DecideEventHandler; // 0x78

	// Methods

	// RVA: 0x1F376D0 Offset: 0x1F377D1 VA: 0x1F376D0
	public void .ctor(string message, RefreshConfirmDialog.Result2 result, RefreshConfirmDialog.DecideEventHandler decideEventHandler) { }

	// RVA: 0x1F37720 Offset: 0x1F37821 VA: 0x1F37720 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1F37760 Offset: 0x1F37861 VA: 0x1F37760 Slot: 19
	public override BasicMenu.Result BCall() { }
}

