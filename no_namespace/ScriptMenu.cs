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

// Namespace: 
private class ScriptMenu.EventMenuItem : MenuItem // TypeDefIndex: 10239
{
	// Fields
	protected string m_Mid; // 0x20
	protected DynValue m_Function; // 0x28
	protected DynValue m_Args; // 0x30
	protected DynValue m_SelectFunction; // 0x38
	protected DynValue m_SelectArgs; // 0x40
	protected ScriptUtil.MenuCondtion m_Condition; // 0x48

	// Methods

	// RVA: 0x20361C0 Offset: 0x20362C1 VA: 0x20361C0
	public void .ctor() { }

	// RVA: 0x20361D0 Offset: 0x20362D1 VA: 0x20361D0 Slot: 5
	public override string GetName() { }

	// RVA: 0x2036240 Offset: 0x2036341 VA: 0x2036240 Slot: 23
	public override bool IsVisible() { }

	// RVA: 0x2036250 Offset: 0x2036351 VA: 0x2036250 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x2036260 Offset: 0x2036361 VA: 0x2036260
	public void SetMid(string mid) { }

	// RVA: 0x2036270 Offset: 0x2036371 VA: 0x2036270
	public void SetFunc(DynValue func) { }

	// RVA: 0x2036280 Offset: 0x2036381 VA: 0x2036280
	public void SetSelectFunc(DynValue func) { }

	// RVA: 0x2036290 Offset: 0x2036391 VA: 0x2036290
	public void SetArgs(DynValue args) { }

	// RVA: 0x20362A0 Offset: 0x20363A1 VA: 0x20362A0
	public void SetSelectArgs(DynValue args) { }

	// RVA: 0x20362B0 Offset: 0x20363B1 VA: 0x20362B0
	public void SetCondition(ScriptUtil.MenuCondtion condition) { }

	// RVA: 0x20362C0 Offset: 0x20363C1 VA: 0x20362C0
	protected void SaveCursor() { }

	// RVA: 0x2036350 Offset: 0x2036451 VA: 0x2036350 Slot: 12
	public override MenuItem.Result ACall() { }

	// RVA: 0x20364D0 Offset: 0x20365D1 VA: 0x20364D0 Slot: 13
	public override MenuItem.Result BCall() { }

	// RVA: 0x20364E0 Offset: 0x20365E1 VA: 0x20364E0 Slot: 14
	public override MenuItem.Result XCall() { }

	// RVA: 0x20364F0 Offset: 0x20365F1 VA: 0x20364F0 Slot: 69
	public override void OnSelect() { }
}

