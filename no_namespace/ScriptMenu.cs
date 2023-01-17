// Namespace: 
private class ScriptMenu.EventMenu : DebugMenu // TypeDefIndex: 10238
{
	// Fields
	private int m_Index; // 0xDC
	private int m_Address; // 0xE0
	protected DynValue m_CancelCall; // 0xE8
	protected DynValue m_CancelJump; // 0xF0

	// Methods

	// RVA: 0x20358A0 Offset: 0x20359A1 VA: 0x20358A0
	public int GetIndex() { }

	// RVA: 0x20358B0 Offset: 0x20359B1 VA: 0x20358B0
	public void .ctor() { }

	// RVA: 0x2035940 Offset: 0x2035A41 VA: 0x2035940
	public void LoadCursor() { }

	// RVA: 0x2035A00 Offset: 0x2035B01 VA: 0x2035A00
	private int ToSelectableIndex(int select) { }

	// RVA: 0x2035AB0 Offset: 0x2035BB1 VA: 0x2035AB0
	public void SaveCursor(bool decide) { }

	// RVA: 0x2035D70 Offset: 0x2035E71 VA: 0x2035D70 Slot: 18
	protected override void OnOpen() { }

	// RVA: 0x2035F50 Offset: 0x2036051 VA: 0x2035F50 Slot: 19
	protected override void OnClose() { }

	// RVA: 0x2035F90 Offset: 0x2036091 VA: 0x2035F90 Slot: 6
	protected override void OnTick() { }

	// RVA: 0x2035FA0 Offset: 0x20360A1 VA: 0x2035FA0 Slot: 22
	protected override MenuItem.Result BCall() { }

	// RVA: 0x2036190 Offset: 0x2036291 VA: 0x2036190 Slot: 23
	protected override MenuItem.Result XCall() { }

	// RVA: 0x20361A0 Offset: 0x20362A1 VA: 0x20361A0
	public void SetCancelCall(DynValue value) { }

	// RVA: 0x20361B0 Offset: 0x20362B1 VA: 0x20361B0
	public void SetCancelJump(DynValue value) { }
}

