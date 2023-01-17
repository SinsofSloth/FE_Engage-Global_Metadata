// Namespace: 
private class GoToSolanelConfirmDialog.GoToSolanelConfirmDialogItemYes : BasicDialogItemYes // TypeDefIndex: 14268
{
	// Fields
	private Action m_DecideCallback; // 0x70
	private Action m_CancelCallback; // 0x78

	// Methods

	// RVA: 0x1F9FD70 Offset: 0x1F9FE71 VA: 0x1F9FD70
	public void .ctor(Action decideCallback, Action cancelCallback, string text) { }

	// RVA: 0x1F9FDD0 Offset: 0x1F9FED1 VA: 0x1F9FDD0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1F9FE00 Offset: 0x1F9FF01 VA: 0x1F9FE00 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
private class GoToSolanelConfirmDialog.GoToSolanelConfirmDialogItemNo : BasicDialogItemNo // TypeDefIndex: 14269
{
	// Fields
	private Action m_Callback; // 0x70

	// Methods

	// RVA: 0x1F9FCB0 Offset: 0x1F9FDB1 VA: 0x1F9FCB0
	public void .ctor(Action callback, string text) { }

	// RVA: 0x1F9FCF0 Offset: 0x1F9FDF1 VA: 0x1F9FCF0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1F9FD30 Offset: 0x1F9FE31 VA: 0x1F9FD30 Slot: 19
	public override BasicMenu.Result BCall() { }
}

