// Namespace: 
public enum EnterChapterYesNoDialog.Type // TypeDefIndex: 14262
{
	// Fields
	public int value__; // 0x0
	public const EnterChapterYesNoDialog.Type Main = 0;
	public const EnterChapterYesNoDialog.Type Encount = 1;
	public const EnterChapterYesNoDialog.Type Training = 2;
	public const EnterChapterYesNoDialog.Type Recollection = 3;
	public const EnterChapterYesNoDialog.Type SelectBattle = 4;
}

// Namespace: 
private class EnterChapterYesNoDialog.EnterChapterDialogEncountItemYes : BasicDialogItemYes // TypeDefIndex: 14264
{
	// Fields
	private Action m_Callback; // 0x70

	// Methods

	// RVA: 0x1F04AE0 Offset: 0x1F04BE1 VA: 0x1F04AE0
	public void .ctor(Action callback) { }

	// RVA: 0x1F04B90 Offset: 0x1F04C91 VA: 0x1F04B90
	public void .ctor(string label, Action callback) { }

	// RVA: 0x1F04C30 Offset: 0x1F04D31 VA: 0x1F04C30 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class EnterChapterYesNoDialog.EnterChapterDialogMainItemNo : BasicDialogItemNo // TypeDefIndex: 14266
{
	// Methods

	// RVA: 0x1F04C60 Offset: 0x1F04D61 VA: 0x1F04C60
	public void .ctor() { }
}

