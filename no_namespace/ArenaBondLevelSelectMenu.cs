// Namespace: 
public sealed class ArenaBondLevelSelectMenu.DecideEventHandler : MulticastDelegate // TypeDefIndex: 10946
{
	// Methods

	// RVA: 0x1F63DC0 Offset: 0x1F63EC1 VA: 0x1F63DC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F62F10 Offset: 0x1F63011 VA: 0x1F62F10 Slot: 13
	public virtual void Invoke(GodUnit god, RingCleaningSequence.GodType type, bool start, int getExp, int useCount) { }

	// RVA: 0x1F63DE0 Offset: 0x1F63EE1 VA: 0x1F63DE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(GodUnit god, RingCleaningSequence.GodType type, bool start, int getExp, int useCount, AsyncCallback callback, object object) { }

	// RVA: 0x1F63EF0 Offset: 0x1F63FF1 VA: 0x1F63EF0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ArenaBondLevelSelectMenu.ChangeGodEventHandle : MulticastDelegate // TypeDefIndex: 10948
{
	// Methods

	// RVA: 0x1F63CC0 Offset: 0x1F63DC1 VA: 0x1F63CC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F63A90 Offset: 0x1F63B91 VA: 0x1F63A90 Slot: 13
	public virtual void Invoke() { }

	// RVA: 0x1F63CE0 Offset: 0x1F63DE1 VA: 0x1F63CE0 Slot: 14
	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	// RVA: 0x1F63D10 Offset: 0x1F63E11 VA: 0x1F63D10 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class ArenaBondLevelSelectMenu.ConfirmDialog.ConfirmDialogItemYes : BasicDialogItemYes // TypeDefIndex: 10950
{
	// Fields
	public Action m_DecideAction; // 0x70

	// Methods

	// RVA: 0x1DC0C30 Offset: 0x1DC0D31 VA: 0x1DC0C30
	public void .ctor(Action decideAction) { }

	// RVA: 0x1DC0CE0 Offset: 0x1DC0DE1 VA: 0x1DC0CE0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class ArenaBondLevelSelectMenu.ConfirmDialog : YesNoDialog // TypeDefIndex: 10952
{
	// Fields
	public Action m_DecideAction; // 0xD8

	// Methods

	// RVA: 0x1F63D20 Offset: 0x1F63E21 VA: 0x1F63D20
	private void .ctor(List<BasicMenuItem> menuItemList, Action decideAction) { }

	// RVA: 0x1F62AE0 Offset: 0x1F62BE1 VA: 0x1F62AE0
	public static void CreateBind(ProcInst super, Unit unit, GodUnit god, RingCleaningSequence.GodType godType, int fromLv, int toLv, int useCount, Action decideAction) { }
}

