// Namespace: 
public sealed class UnitSelectRingMenu.CloseEventHandler : MulticastDelegate // TypeDefIndex: 13330
{
	// Methods

	// RVA: 0x1ED6E20 Offset: 0x1ED6F21 VA: 0x1ED6E20
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1ED6E40 Offset: 0x1ED6F41 VA: 0x1ED6E40 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1ED7050 Offset: 0x1ED7151 VA: 0x1ED7050 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1ED7080 Offset: 0x1ED7181 VA: 0x1ED7080 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class UnitSelectRingMenu.TakeOffAllRingsMenuItem : BasicMenuItem // TypeDefIndex: 13332
{
	// Methods

	// RVA: 0x1ED7700 Offset: 0x1ED7801 VA: 0x1ED7700
	public void .ctor() { }

	// RVA: 0x1ED7710 Offset: 0x1ED7811 VA: 0x1ED7710 Slot: 4
	public override string GetName() { }

	// RVA: 0x1ED7790 Offset: 0x1ED7891 VA: 0x1ED7790 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1ED7830 Offset: 0x1ED7931 VA: 0x1ED7830 Slot: 18
	public override BasicMenu.Result ACall() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CB730 Offset: 0x2CB831 VA: 0x2CB730
	// RVA: 0x1ED7990 Offset: 0x1ED7A91 VA: 0x1ED7990
	private void <ACall>b__3_0() { }
}

// Namespace: 
private class UnitSelectRingMenu.ConfirmDialog // TypeDefIndex: 13334
{
	// Methods

	// RVA: 0x1ED7090 Offset: 0x1ED7191 VA: 0x1ED7090
	public static BasicDialog CreateBind(ProcInst super, string confirmMessage, string yesMessage, string noMessag, UnitSelectRingMenu.ConfirmDialog.DecideEventHandler yesEventHandler) { }

	// RVA: 0x1ED72C0 Offset: 0x1ED73C1 VA: 0x1ED72C0
	public void .ctor() { }
}

// Namespace: 
private class UnitSelectRingMenu.DialogNoMenuItem : BasicDialogItemNo // TypeDefIndex: 13336
{
	// Methods

	// RVA: 0x1ED72B0 Offset: 0x1ED73B1 VA: 0x1ED72B0
	public void .ctor(string message) { }

	// RVA: 0x1ED72D0 Offset: 0x1ED73D1 VA: 0x1ED72D0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }
}

