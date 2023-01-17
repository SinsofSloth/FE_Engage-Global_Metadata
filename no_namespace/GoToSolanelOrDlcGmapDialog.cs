// Namespace: 
private class GoToSolanelOrDlcGmapDialog.DialogItem : BasicDialogItem // TypeDefIndex: 14271
{
	// Fields
	private Action m_func; // 0x70

	// Methods

	// RVA: 0x1FA0020 Offset: 0x1FA0121 VA: 0x1FA0020
	public void .ctor(string label, Action func) { }

	// RVA: 0x1FA00C0 Offset: 0x1FA01C1 VA: 0x1FA00C0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class GoToSolanelOrDlcGmapDialog.DialogGmapItem : BasicDialogItem // TypeDefIndex: 14272
{
	// Fields
	private GmapMode.Mode m_Mode; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x29E430 Offset: 0x29E531 VA: 0x29E430
	private static Action<GmapMode.Mode> <s_MoveGmapCallback>k__BackingField; // 0x0

	// Properties
	public static Action<GmapMode.Mode> s_MoveGmapCallback { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CE430 Offset: 0x2CE531 VA: 0x2CE430
	// RVA: 0x1F9FE40 Offset: 0x1F9FF41 VA: 0x1F9FE40
	public static Action<GmapMode.Mode> get_s_MoveGmapCallback() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CE440 Offset: 0x2CE541 VA: 0x2CE440
	// RVA: 0x1F9FE90 Offset: 0x1F9FF91 VA: 0x1F9FE90
	public static void set_s_MoveGmapCallback(Action<GmapMode.Mode> value) { }

	// RVA: 0x1F9FEF0 Offset: 0x1F9FFF1 VA: 0x1F9FEF0
	public void .ctor(string label, GmapMode.Mode mode) { }

	// RVA: 0x1F9FF90 Offset: 0x1FA0091 VA: 0x1F9FF90 Slot: 18
	public override BasicMenu.Result ACall() { }
}

