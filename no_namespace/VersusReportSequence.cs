// Namespace: 
private enum VersusReportSequence.Label // TypeDefIndex: 13742
{
	// Fields
	public int value__; // 0x0
	public const VersusReportSequence.Label TypeMenu = 0;
	public const VersusReportSequence.Label Reason = 1;
	public const VersusReportSequence.Label End = 2;
}

// Namespace: 
private class VersusReportSequence.ConfirmDialog.ConfirmDialogItemYes : BasicDialogItemYes // TypeDefIndex: 13743
{
	// Fields
	private Action m_Action; // 0x70

	// Methods

	// RVA: 0x2D6B640 Offset: 0x2D6B741 VA: 0x2D6B640
	public void .ctor(string text, Action action) { }

	// RVA: 0x2D6B680 Offset: 0x2D6B781 VA: 0x2D6B680 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class VersusReportSequence.ConfirmDialog.ConfirmDialogItemNo : BasicDialogItemNo // TypeDefIndex: 13744
{
	// Fields
	private Action m_Action; // 0x70

	// Methods

	// RVA: 0x2D6B5D0 Offset: 0x2D6B6D1 VA: 0x2D6B5D0
	public void .ctor(Action action) { }

	// RVA: 0x2D6B610 Offset: 0x2D6B711 VA: 0x2D6B610 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class VersusReportSequence.ConfirmDialog : YesNoDialog // TypeDefIndex: 13745
{
	// Fields
	private Action m_CancelCallback; // 0xD8

	// Methods

	// RVA: 0x1EE2E20 Offset: 0x1EE2F21 VA: 0x1EE2E20
	private void .ctor(List<BasicMenuItem> menuItemList, Action cancelCallback) { }

	// RVA: 0x1EE2EF0 Offset: 0x1EE2FF1 VA: 0x1EE2EF0
	public static void CreateBind(ProcInst super, Action decideCallback, Action cancelCallback) { }

	// RVA: 0x1EE3100 Offset: 0x1EE3201 VA: 0x1EE3100 Slot: 51
	protected override BasicMenu.Result BCall() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279270 Offset: 0x279371 VA: 0x279270
[Serializable]
private sealed class VersusReportSequence.<>c // TypeDefIndex: 13746
{
	// Fields
	public static readonly VersusReportSequence.<>c <>9; // 0x0
	public static Action <>9__17_0; // 0x8

	// Methods

	// RVA: 0x1EE2D90 Offset: 0x1EE2E91 VA: 0x1EE2D90
	private static void .cctor() { }

	// RVA: 0x1EE2E00 Offset: 0x1EE2F01 VA: 0x1EE2E00
	public void .ctor() { }

	// RVA: 0x1EE2E10 Offset: 0x1EE2F11 VA: 0x1EE2E10
	internal void <OpenConfirmDialog>b__17_0() { }
}

