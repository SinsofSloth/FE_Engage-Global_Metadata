// Namespace: 
public enum MapSequenceEditor.Label // TypeDefIndex: 11981
{
	// Fields
	public int value__; // 0x0
	public const MapSequenceEditor.Label MainMenu = 0;
	public const MapSequenceEditor.Label FreeCursor = 1;
	public const MapSequenceEditor.Label End = 2;
}

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
private class MapSequenceEditor.ClearObjectsSequence.ClearObjectsConfirmDialog : YesNoDialog // TypeDefIndex: 11983
{
	// Methods

	// RVA: 0x21E61C0 Offset: 0x21E62C1 VA: 0x21E61C0
	private void .ctor(List<BasicMenuItem> menuItemList) { }

	// RVA: 0x21E6240 Offset: 0x21E6341 VA: 0x21E6240
	public static void CreateBind(ProcInst super, Action ACallback) { }
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
public class MapSequenceEditor.ClearObjectsSequence : ProcInst // TypeDefIndex: 11985
{
	// Methods

	// RVA: 0x241B4B0 Offset: 0x241B5B1 VA: 0x241B4B0
	private void ClearObjects() { }

	// RVA: 0x241B5C0 Offset: 0x241B6C1 VA: 0x241B5C0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x241B780 Offset: 0x241B881 VA: 0x241B780 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x241B770 Offset: 0x241B871 VA: 0x241B770
	public void .ctor() { }
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
private class MapSequenceEditor.SaveSequence.UploadConfirmDialog.DialogItemNo : BasicDialogItemNo // TypeDefIndex: 11987
{
	// Fields
	private Action ACallback; // 0x70

	// Methods

	// RVA: 0x2D7CBE0 Offset: 0x2D7CCE1 VA: 0x2D7CBE0
	public void .ctor(Action action, string text) { }

	// RVA: 0x2D7CC20 Offset: 0x2D7CD21 VA: 0x2D7CC20 Slot: 18
	public override BasicMenu.Result ACall() { }
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
private class MapSequenceEditor.SaveSequence.UploadOverwriteConfirmDialog.DialogItemNo : BasicDialogItemNo // TypeDefIndex: 11989
{
	// Fields
	private Action ACallback; // 0x70

	// Methods

	// RVA: 0x2D7CC60 Offset: 0x2D7CD61 VA: 0x2D7CC60
	public void .ctor(Action action) { }

	// RVA: 0x2D7CCA0 Offset: 0x2D7CDA1 VA: 0x2D7CCA0 Slot: 18
	public override BasicMenu.Result ACall() { }
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
private class MapSequenceEditor.SaveSequence.EndConfirmDialog.ConfirmYesDialogItem : BasicDialogItemYes // TypeDefIndex: 11991
{
	// Fields
	private Action m_DecideCallback; // 0x70

	// Methods

	// RVA: 0x2D7CB70 Offset: 0x2D7CC71 VA: 0x2D7CB70
	public void .ctor(string text, Action decideCallback) { }

	// RVA: 0x2D7CBB0 Offset: 0x2D7CCB1 VA: 0x2D7CBB0 Slot: 18
	public override BasicMenu.Result ACall() { }
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

// Namespace: 
public class MapSequenceEditor.SaveSequence : ProcInst // TypeDefIndex: 11993
{
	// Fields
	private static bool s_IsEndEdit; // 0x0
	private BasicMenu m_ParentMenu; // 0x70

	// Methods

	// RVA: 0x241B820 Offset: 0x241B921 VA: 0x241B820
	private void OpenThemeMenu() { }

	// RVA: 0x241B910 Offset: 0x241BA11 VA: 0x241B910
	private void SaveMap() { }

	// RVA: 0x241BBE0 Offset: 0x241BCE1 VA: 0x241BBE0
	private bool IsValidSortie() { }

	// RVA: 0x241BC10 Offset: 0x241BD11 VA: 0x241BC10
	private bool IsValidAbsent() { }

	// RVA: 0x241BC40 Offset: 0x241BD41 VA: 0x241BC40
	private bool IsEditRuleCheck() { }

	// RVA: 0x241BC50 Offset: 0x241BD51 VA: 0x241BC50
	private void OpenUploadDialog() { }

	// RVA: 0x241BCE0 Offset: 0x241BDE1 VA: 0x241BCE0
	private void UploadMap() { }

	// RVA: 0x241BDE0 Offset: 0x241BEE1 VA: 0x241BDE0
	private void EndConfirm() { }

	// RVA: 0x241BE70 Offset: 0x241BF71 VA: 0x241BE70
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x241C390 Offset: 0x241C491 VA: 0x241C390 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x241C430 Offset: 0x241C531 VA: 0x241C430 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x241C380 Offset: 0x241C481 VA: 0x241C380
	public void .ctor() { }

	// RVA: 0x241C4E0 Offset: 0x241C5E1 VA: 0x241C4E0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7350 Offset: 0x2C7451 VA: 0x2C7350
	// RVA: 0x241C4F0 Offset: 0x241C5F1 VA: 0x241C4F0
	private void <OpenThemeMenu>b__6_0(ProfileCardThemeOfEditMapData selectedTheme) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7360 Offset: 0x2C7461 VA: 0x2C7360
	// RVA: 0x241C5C0 Offset: 0x241C6C1 VA: 0x241C5C0
	private void <OpenUploadDialog>b__11_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C7370 Offset: 0x2C7471 VA: 0x2C7370
	// RVA: 0x241C630 Offset: 0x241C731 VA: 0x241C630
	private void <EndConfirm>b__13_0() { }
}

