// Namespace: 
private class ArenaExpUnitSelectMenuItem.ConfirmDialog.ConfirmDialogItemYes : BasicDialogItemYes // TypeDefIndex: 10970
{
	// Fields
	public Action m_DecideAction; // 0x70

	// Methods

	// RVA: 0x1DC0DA0 Offset: 0x1DC0EA1 VA: 0x1DC0DA0
	public void .ctor(Action decideAction) { }

	// RVA: 0x1DC0E50 Offset: 0x1DC0F51 VA: 0x1DC0E50 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class ArenaExpUnitSelectMenuItem.ConfirmDialog.ConfirmDialogItemNo : BasicDialogItemNo // TypeDefIndex: 10971
{
	// Methods

	// RVA: 0x1DC0D10 Offset: 0x1DC0E11 VA: 0x1DC0D10
	public void .ctor() { }
}

// Namespace: 
private class ArenaExpUnitSelectMenuItem.ConfirmDialog : YesNoDialog // TypeDefIndex: 10972
{
	// Fields
	public Action m_DecideAction; // 0xD8

	// Methods

	// RVA: 0x1F66FD0 Offset: 0x1F670D1 VA: 0x1F66FD0
	private void .ctor(List<BasicMenuItem> menuItemList, Action decideAction) { }

	// RVA: 0x1F67070 Offset: 0x1F67171 VA: 0x1F67070
	public static void CreateBind(ProcInst super, Unit unit, Action decideAction) { }
}

