// Namespace: 
public class SaveDataMenu.ConfirmDialog.YesItem : BasicDialogItemYes // TypeDefIndex: 12633
{
	// Fields
	protected GameSaveDataHeaderReader.Handle m_DestSaveDataHeaderHandle; // 0x70

	// Methods

	// RVA: 0x21F81D0 Offset: 0x21F82D1 VA: 0x21F81D0
	public void .ctor(GameSaveDataHeaderReader.Handle destSaveDataHeaderHandle, string text) { }
}

// Namespace: 
public class SaveDataMenu.ConfirmDialog.NoItem : BasicDialogItemNo // TypeDefIndex: 12634
{
	// Methods

	// RVA: 0x21F8110 Offset: 0x21F8211 VA: 0x21F8110
	public void .ctor(string text) { }
}

// Namespace: 
protected class SaveDataMenu.ConfirmDialog : YesNoDialog // TypeDefIndex: 12635
{
	// Fields
	protected GameSaveDataHeaderReader.Handle m_SaveDataHeaderHandle; // 0xD8

	// Methods

	// RVA: 0x2032580 Offset: 0x2032681 VA: 0x2032580
	public void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent dialogContent, GameSaveDataHeaderReader.Handle saveDataHeaderHandle) { }

	// RVA: 0x20326D0 Offset: 0x20327D1 VA: 0x20326D0
	public static void CreateBind(ProcInst super, string message, BasicDialogItemYes yesItem, GameSaveDataHeaderReader.Handle saveDataHedaerHandle) { }
}

// Namespace: 
private class SaveDataMenu.CancelConfirmDialog.YesDialogItem : SaveDataMenu.ConfirmDialog.YesItem // TypeDefIndex: 12636
{
	// Methods

	// RVA: 0x21F8120 Offset: 0x21F8221 VA: 0x21F8120
	public void .ctor(GameSaveDataHeaderReader.Handle saveDataHeaderHandle) { }

	// RVA: 0x21F8210 Offset: 0x21F8311 VA: 0x21F8210 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
protected class SaveDataMenu.CancelConfirmDialog.NoDialogItem : SaveDataMenu.ConfirmDialog.NoItem // TypeDefIndex: 12637
{
	// Methods

	// RVA: 0x21F8080 Offset: 0x21F8181 VA: 0x21F8080
	public void .ctor() { }
}

// Namespace: 
private class SaveDataMenu.CancelConfirmDialog : SaveDataMenu.ConfirmDialog // TypeDefIndex: 12638
{
	// Methods

	// RVA: 0x2032540 Offset: 0x2032641 VA: 0x2032540
	private void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent dialogContent, GameSaveDataHeaderReader.Handle saveDataHeaderHandle) { }

	// RVA: 0x20325C0 Offset: 0x20326C1 VA: 0x20325C0
	public static void CreateBind(ProcInst super, GameSaveDataHeaderReader.Handle saveDataHeaderHandle) { }
}

// Namespace: 
private class SaveDataMenu.LoadConfirmDialog.YesDialogItem : SaveDataMenu.ConfirmDialog.YesItem // TypeDefIndex: 12639
{
	// Methods

	// RVA: 0x21F8850 Offset: 0x21F8951 VA: 0x21F8850
	public void .ctor(GameSaveDataHeaderReader.Handle saveDataHeaderHandle) { }

	// RVA: 0x21F8900 Offset: 0x21F8A01 VA: 0x21F8900 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class SaveDataMenu.LoadConfirmDialog.NoDialogItem : SaveDataMenu.ConfirmDialog.NoItem // TypeDefIndex: 12640
{
	// Methods

	// RVA: 0x21F87C0 Offset: 0x21F88C1 VA: 0x21F87C0
	public void .ctor() { }
}

// Namespace: 
private class SaveDataMenu.LoadConfirmDialog : SaveDataMenu.ConfirmDialog // TypeDefIndex: 12641
{
	// Methods

	// RVA: 0x2032B70 Offset: 0x2032C71 VA: 0x2032B70
	private void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent dialogContent, GameSaveDataHeaderReader.Handle saveDataHeaderHandle) { }

	// RVA: 0x2032BB0 Offset: 0x2032CB1 VA: 0x2032BB0
	public static void CreateBind(ProcInst super, GameSaveDataHeaderReader.Handle saveDataHeaderHandle) { }
}

// Namespace: 
public class SaveDataMenu.SaveConfirmDialog.YesDialogItem : SaveDataMenu.ConfirmDialog.YesItem // TypeDefIndex: 12642
{
	// Methods

	// RVA: 0x21F8A30 Offset: 0x21F8B31 VA: 0x21F8A30
	public void .ctor(GameSaveDataHeaderReader.Handle saveDataHeaderHandle) { }

	// RVA: 0x21F8AE0 Offset: 0x21F8BE1 VA: 0x21F8AE0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
public class SaveDataMenu.SaveConfirmDialog.NoDialogItem : SaveDataMenu.ConfirmDialog.NoItem // TypeDefIndex: 12643
{
	// Methods

	// RVA: 0x21F89A0 Offset: 0x21F8AA1 VA: 0x21F89A0
	public void .ctor() { }
}

// Namespace: 
private class SaveDataMenu.SaveConfirmDialog : SaveDataMenu.ConfirmDialog // TypeDefIndex: 12644
{
	// Methods

	// RVA: 0x2034FD0 Offset: 0x20350D1 VA: 0x2034FD0
	private void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent dialogContent, GameSaveDataHeaderReader.Handle saveDataHeaderHandle) { }

	// RVA: 0x2033370 Offset: 0x2033471 VA: 0x2033370
	public static void CreateBind(ProcInst super, GameSaveDataHeaderReader.Handle saveDataHeaderHandle, bool isSaveCompleteData) { }
}

// Namespace: 
public class SaveDataMenu.SuspendConfirmDialog.YesDialogItem : SaveDataMenu.ConfirmDialog.YesItem // TypeDefIndex: 12645
{
	// Methods

	// RVA: 0x21F8CE0 Offset: 0x21F8DE1 VA: 0x21F8CE0
	public void .ctor(GameSaveDataHeaderReader.Handle saveDataHeaderHandle) { }

	// RVA: 0x21F8D90 Offset: 0x21F8E91 VA: 0x21F8D90 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
public class SaveDataMenu.SuspendConfirmDialog.NoDialogItem : SaveDataMenu.ConfirmDialog.NoItem // TypeDefIndex: 12646
{
	// Methods

	// RVA: 0x21F8C50 Offset: 0x21F8D51 VA: 0x21F8C50
	public void .ctor() { }
}

// Namespace: 
private class SaveDataMenu.SuspendConfirmDialog : SaveDataMenu.ConfirmDialog // TypeDefIndex: 12647
{
	// Methods

	// RVA: 0x2035010 Offset: 0x2035111 VA: 0x2035010
	private void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent dialogContent, GameSaveDataHeaderReader.Handle saveDataHeaderHandle) { }

	// RVA: 0x20334B0 Offset: 0x20335B1 VA: 0x20334B0
	public static void CreateBind(ProcInst super, GameSaveDataHeaderReader.Handle saveDataHeaderHandle) { }
}

// Namespace: 
private class SaveDataMenu.CopyConfirmDialog.YesDialogItem : SaveDataMenu.ConfirmDialog.YesItem // TypeDefIndex: 12648
{
	// Fields
	protected GameSaveDataHeaderReader.Handle m_SrcSaveDataHeaderHandle; // 0x78

	// Methods

	// RVA: 0x21F82B0 Offset: 0x21F83B1 VA: 0x21F82B0
	public void .ctor(GameSaveDataHeaderReader.Handle destSaveDataHeaderHandle, GameSaveDataHeaderReader.Handle srcSaveDataHeaderHandle) { }

	// RVA: 0x21F8370 Offset: 0x21F8471 VA: 0x21F8370 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class SaveDataMenu.CopyConfirmDialog.NoDialogItem : SaveDataMenu.ConfirmDialog.NoItem // TypeDefIndex: 12649
{
	// Methods

	// RVA: 0x21F8220 Offset: 0x21F8321 VA: 0x21F8220
	public void .ctor() { }
}

// Namespace: 
private class SaveDataMenu.CopyConfirmDialog : SaveDataMenu.ConfirmDialog // TypeDefIndex: 12650
{
	// Fields
	protected GameSaveDataHeaderReader.Handle m_SrcSaveDataHeaderHandle; // 0xE0

	// Methods

	// RVA: 0x20328B0 Offset: 0x20329B1 VA: 0x20328B0
	private void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent dialogContent, GameSaveDataHeaderReader.Handle destSaveDataHeaderHandle, GameSaveDataHeaderReader.Handle srcSaveDataHeaderHandle) { }

	// RVA: 0x2032900 Offset: 0x2032A01 VA: 0x2032900
	public static void CreateBind(ProcInst super, GameSaveDataHeaderReader.Handle destSaveDataHeaderHandle, GameSaveDataHeaderReader.Handle srcSaveDataHeaderHandle) { }
}

// Namespace: 
private class SaveDataMenu.DeleteConfirmDialog.YesDialogItem : SaveDataMenu.ConfirmDialog.YesItem // TypeDefIndex: 12651
{
	// Methods

	// RVA: 0x21F8600 Offset: 0x21F8701 VA: 0x21F8600
	public void .ctor(GameSaveDataHeaderReader.Handle saveDataHeaderHandle) { }

	// RVA: 0x21F86B0 Offset: 0x21F87B1 VA: 0x21F86B0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class SaveDataMenu.DeleteConfirmDialog.NoDialogItem : SaveDataMenu.ConfirmDialog.NoItem // TypeDefIndex: 12652
{
	// Methods

	// RVA: 0x21F8570 Offset: 0x21F8671 VA: 0x21F8570
	public void .ctor() { }
}

// Namespace: 
private class SaveDataMenu.DeleteConfirmDialog : SaveDataMenu.ConfirmDialog // TypeDefIndex: 12653
{
	// Methods

	// RVA: 0x2032A20 Offset: 0x2032B21 VA: 0x2032A20
	private void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent dialogContent, GameSaveDataHeaderReader.Handle saveDataHeaderHandle) { }

	// RVA: 0x2032A60 Offset: 0x2032B61 VA: 0x2032A60
	public static void CreateBind(ProcInst super, GameSaveDataHeaderReader.Handle saveDataHeaderHandle) { }
}

// Namespace: 
public class SaveDataMenu.MenuItem : BasicMenuItem // TypeDefIndex: 12654
{
	// Fields
	private GameSaveDataHeaderReader.Handle m_SaveDataHeaderHandle; // 0x68
	private bool m_IsSelected; // 0x70

	// Methods

	// RVA: 0x2032E40 Offset: 0x2032F41 VA: 0x2032E40
	public GameSaveDataHeaderReader.Handle GetHeaderHandle() { }

	// RVA: 0x2032E50 Offset: 0x2032F51 VA: 0x2032E50 Slot: 6
	public override float GetHeight() { }

	// RVA: 0x2032E60 Offset: 0x2032F61 VA: 0x2032E60
	public bool IsSelected() { }

	// RVA: 0x2032E70 Offset: 0x2032F71 VA: 0x2032E70
	public void SetSelect(bool enable) { }

	// RVA: 0x2032E80 Offset: 0x2032F81 VA: 0x2032E80 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2033030 Offset: 0x2033131 VA: 0x2033030
	public void .ctor(GameSaveDataHeaderReader.Handle saveDataHeaderhandle) { }

	// RVA: 0x2033070 Offset: 0x2033171 VA: 0x2033070 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x20335C0 Offset: 0x20336C1 VA: 0x20335C0 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
public class SaveDataMenu.MenuContent : BasicMenuContent // TypeDefIndex: 12655
{
	// Methods

	// RVA: 0x2032CB0 Offset: 0x2032DB1 VA: 0x2032CB0 Slot: 4
	public override int GetMenuItemContentMax() { }

	// RVA: 0x2032CC0 Offset: 0x2032DC1 VA: 0x2032CC0 Slot: 21
	public override float CalcW() { }

	// RVA: 0x2032CD0 Offset: 0x2032DD1 VA: 0x2032CD0 Slot: 22
	public override float CalcH() { }

	// RVA: 0x2032CE0 Offset: 0x2032DE1 VA: 0x2032CE0 Slot: 10
	protected override float CalcCursorMovedPosY(int menuItemIndex) { }

	// RVA: 0x2032DD0 Offset: 0x2032ED1 VA: 0x2032DD0
	public void .ctor() { }
}

// Namespace: 
public class SaveDataMenu.MenuItemContent : BasicMenuItemContent // TypeDefIndex: 12656
{
	// Fields
	private GameObject m_WindowObject; // 0x48
	private Image m_SelectedObject; // 0x50
	private TextMeshProUGUI m_DataTypeText; // 0x58
	private TextMeshProUGUI m_ChapterPrefixText; // 0x60
	private TextMeshProUGUI m_ChapterTitleText; // 0x68
	private TextMeshProUGUI m_PlaceText; // 0x70
	private TextMeshProUGUI m_SequenceText; // 0x78
	private TextMeshProUGUI m_HeroNameText; // 0x80
	private TextMeshProUGUI m_PlayTimeText; // 0x88
	private TextMeshProUGUI m_DifficultyText; // 0x90
	private TextMeshProUGUI m_VersionErrorText; // 0x98
	private Image m_DifficultyImage; // 0xA0
	private TextMeshProUGUI m_ModeText; // 0xA8
	private Image m_GameModeImage; // 0xB0
	private Image m_CompleteIconImage; // 0xB8
	private Image m_TemporaryIconImage; // 0xC0
	private Color m_TextCopySrcSelectedColor; // 0xC8
	[SerializeField] // RVA: 0x29B4A0 Offset: 0x29B5A1 VA: 0x29B4A0
	public Color m_DifficultyNormalFrameColor; // 0xD8
	[SerializeField] // RVA: 0x29B4B0 Offset: 0x29B5B1 VA: 0x29B4B0
	public Color m_DifficultyHardFrameColor; // 0xE8
	[SerializeField] // RVA: 0x29B4C0 Offset: 0x29B5C1 VA: 0x29B4C0
	public Color m_DifficultyLunaticFrameColor; // 0xF8
	[SerializeField] // RVA: 0x29B4D0 Offset: 0x29B5D1 VA: 0x29B4D0
	public Color m_GameModeCasualFrameColor; // 0x108
	[SerializeField] // RVA: 0x29B4E0 Offset: 0x29B5E1 VA: 0x29B4E0
	public Color m_GameModeClassicFrameColor; // 0x118

	// Methods

	// RVA: 0x2033750 Offset: 0x2033851 VA: 0x2033750 Slot: 8
	public override void Build(BasicMenuItem menuItem) { }

	// RVA: 0x2034450 Offset: 0x2034551 VA: 0x2034450 Slot: 13
	public override void Disable() { }

	// RVA: 0x20344E0 Offset: 0x20345E1 VA: 0x20344E0 Slot: 11
	public override void BuildTextColor() { }

	// RVA: 0x20346D0 Offset: 0x20347D1 VA: 0x20346D0 Slot: 7
	protected override void UpdateTextColor() { }

	// RVA: 0x2033DD0 Offset: 0x2033ED1 VA: 0x2033DD0
	public void SetupByMenuItem(SaveDataMenu.MenuItem menuItem) { }

	// RVA: 0x2034870 Offset: 0x2034971 VA: 0x2034870
	private string GetDataTypeName(GameSaveDataHeaderReader.Handle saveDataHeaderReader) { }

	// RVA: 0x2034970 Offset: 0x2034A71 VA: 0x2034970
	private void GetPlaceAndSeqenceName(GameSaveDataHeader saveDataHeader, out string placeName, out string sequenceName) { }

	// RVA: 0x2034E70 Offset: 0x2034F71 VA: 0x2034E70
	private string GetPlayTimeString(float playTime) { }

	// RVA: 0x2034F70 Offset: 0x2035071 VA: 0x2034F70
	public void .ctor() { }
}

// Namespace: 
public enum SaveDataMenu.Mode // TypeDefIndex: 12657
{
	// Fields
	public int value__; // 0x0
	public const SaveDataMenu.Mode Load = 0;
	public const SaveDataMenu.Mode Save = 1;
	public const SaveDataMenu.Mode SaveComplete = 2;
	public const SaveDataMenu.Mode Suspend = 3;
	public const SaveDataMenu.Mode Copy = 4;
	public const SaveDataMenu.Mode Delete = 5;
}

// Namespace: 
private enum SaveDataMenu.Sequence // TypeDefIndex: 12658
{
	// Fields
	public int value__; // 0x0
	public const SaveDataMenu.Sequence Select1st = 0;
	public const SaveDataMenu.Sequence Select2nd = 1;
}

