// Namespace: 
private class MapSequenceEditor.ClearObjectsSequence.ClearObjectsConfirmDialog.YesItem : BasicDialogItemYes // TypeDefIndex: 11982
{
	// Fields
	private Action m_ACallback; // 0x70

	// Methods

	// RVA: 0x2D7CAF0 Offset: 0x2D7CBF1 VA: 0x2D7CAF0
	public void .ctor(Action ACallback) { }

	// RVA: 0x2D7CB30 Offset: 0x2D7CC31 VA: 0x2D7CB30 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x277DE0 Offset: 0x277EE1 VA: 0x277DE0
[Serializable]
private sealed class MapSequenceEditor.ClearObjectsSequence.<>c // TypeDefIndex: 11984
{
	// Fields
	public static readonly MapSequenceEditor.ClearObjectsSequence.<>c <>9; // 0x0
	public static Action <>9__1_0; // 0x8

	// Methods

	// RVA: 0x21E6060 Offset: 0x21E6161 VA: 0x21E6060
	private static void .cctor() { }

	// RVA: 0x21E60D0 Offset: 0x21E61D1 VA: 0x21E60D0
	public void .ctor() { }

	// RVA: 0x21E60E0 Offset: 0x21E61E1 VA: 0x21E60E0
	internal void <ClearObjects>b__1_0() { }
}

// Namespace: 
private enum MapSequenceEditor.SaveSequence.Label // TypeDefIndex: 11986
{
	// Fields
	public int value__; // 0x0
	public const MapSequenceEditor.SaveSequence.Label Save = 0;
	public const MapSequenceEditor.SaveSequence.Label SaveEnd = 1;
	public const MapSequenceEditor.SaveSequence.Label End = 2;
}

// Namespace: 
private class MapSequenceEditor.SaveSequence.UploadConfirmDialog : YesNoDialog // TypeDefIndex: 11988
{
	// Fields
	private Action m_CancelCallback; // 0xD8

	// Methods

	// RVA: 0x21E6770 Offset: 0x21E6871 VA: 0x21E6770
	private void .ctor(List<BasicMenuItem> menuItemList, Action cancelCallback) { }

	// RVA: 0x21E6810 Offset: 0x21E6911 VA: 0x21E6810
	public static void CreateBind(ProcInst super, Action cancelCallback) { }

	// RVA: 0x21E6AA0 Offset: 0x21E6BA1 VA: 0x21E6AA0 Slot: 51
	protected override BasicMenu.Result BCall() { }
}

// Namespace: 
private class MapSequenceEditor.SaveSequence.UploadOverwriteConfirmDialog : YesNoDialog // TypeDefIndex: 11990
{
	// Fields
	private Action m_BCallback; // 0xD8

	// Methods

	// RVA: 0x21E6AD0 Offset: 0x21E6BD1 VA: 0x21E6AD0
	private void .ctor(List<BasicMenuItem> menuItemList, Action action) { }

	// RVA: 0x21E6B70 Offset: 0x21E6C71 VA: 0x21E6B70
	public static void CreateBind(ProcInst super, Action cancelCallback) { }

	// RVA: 0x21E6DB0 Offset: 0x21E6EB1 VA: 0x21E6DB0 Slot: 51
	protected override BasicMenu.Result BCall() { }
}

// Namespace: 
public class MapSequenceEditor.SaveSequence.EndConfirmDialog : YesNoDialog // TypeDefIndex: 11992
{
	// Methods

	// RVA: 0x21E6470 Offset: 0x21E6571 VA: 0x21E6470
	private void .ctor(List<BasicMenuItem> menuItemList) { }

	// RVA: 0x21E64F0 Offset: 0x21E65F1 VA: 0x21E64F0
	public static void CreateBind(ProcInst super, Action decideCallback) { }
}

