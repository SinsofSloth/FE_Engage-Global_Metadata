// Namespace: 
public sealed class SysthesisRingConfirmDialog.DecideEventHandler : MulticastDelegate // TypeDefIndex: 11239
{
	// Methods

	// RVA: 0x2056220 Offset: 0x2056321 VA: 0x2056220
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2056240 Offset: 0x2056341 VA: 0x2056240 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x2056450 Offset: 0x2056551 VA: 0x2056450 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x2056480 Offset: 0x2056581 VA: 0x2056480 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class SysthesisRingConfirmDialog.YesDialogItem : BasicDialogItemYes // TypeDefIndex: 11240
{
	// Fields
	private SysthesisRingConfirmDialog.DecideEventHandler m_DecideEventHandler; // 0x70

	// Methods

	// RVA: 0x2056490 Offset: 0x2056591 VA: 0x2056490
	public void .ctor(SysthesisRingConfirmDialog.DecideEventHandler decideEventHandler) { }

	// RVA: 0x2056540 Offset: 0x2056641 VA: 0x2056540 Slot: 18
	public override BasicMenu.Result ACall() { }
}

