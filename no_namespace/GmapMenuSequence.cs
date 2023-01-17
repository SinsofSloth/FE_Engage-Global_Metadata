// Namespace: 
public enum GmapMenuSequence.Label // TypeDefIndex: 10274
{
	// Fields
	public int value__; // 0x0
	public const GmapMenuSequence.Label TopMenu = 0;
	public const GmapMenuSequence.Label EnterChapter = 1;
	public const GmapMenuSequence.Label Inventory = 2;
	public const GmapMenuSequence.Label RingSelect = 3;
	public const GmapMenuSequence.Label Ranking = 4;
	public const GmapMenuSequence.Label MaterialList = 5;
	public const GmapMenuSequence.Label SaveData = 6;
	public const GmapMenuSequence.Label GoToSolanel = 7;
	public const GmapMenuSequence.Label End = 8;
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.GmapMenuMenuItem : MapBasicMenuItem // TypeDefIndex: 10275
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x1DCA750 Offset: 0x1DCA851 VA: 0x1DCA750 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x1DCA790 Offset: 0x1DCA891 VA: 0x1DCA790 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x1DCA090 Offset: 0x1DCA191 VA: 0x1DCA090 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1DCA3F0 Offset: 0x1DCA4F1 VA: 0x1DCA3F0
	public void SetHelpVisible(bool active) { }

	// RVA: 0x1DCA140 Offset: 0x1DCA241 VA: 0x1DCA140
	protected void SaveMenuSelect() { }

	// RVA: 0x1DCA7D0 Offset: 0x1DCA8D1 VA: 0x1DCA7D0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x1DCA820 Offset: 0x1DCA921 VA: 0x1DCA820 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x1DCA930 Offset: 0x1DCAA31 VA: 0x1DCA930 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x1DC9AD0 Offset: 0x1DC9BD1 VA: 0x1DC9AD0
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.EnterChapterItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10276
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x28DD80 Offset: 0x28DE81 VA: 0x28DD80
	private static EnterChapterYesNoDialog.Type <Type>k__BackingField; // 0x0

	// Properties
	public static EnterChapterYesNoDialog.Type Type { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BD8E0 Offset: 0x2BD9E1 VA: 0x2BD8E0
	// RVA: 0x1DC99C0 Offset: 0x1DC9AC1 VA: 0x1DC99C0
	public static EnterChapterYesNoDialog.Type get_Type() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD8F0 Offset: 0x2BD9F1 VA: 0x2BD8F0
	// RVA: 0x1DC9A10 Offset: 0x1DC9B11 VA: 0x1DC9A10
	private static void set_Type(EnterChapterYesNoDialog.Type value) { }

	// RVA: 0x1DC9A70 Offset: 0x1DC9B71 VA: 0x1DC9A70
	public void .ctor(EnterChapterYesNoDialog.Type type) { }

	// RVA: 0x1DC9AE0 Offset: 0x1DC9BE1 VA: 0x1DC9AE0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1DC9CB0 Offset: 0x1DC9DB1 VA: 0x1DC9CB0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x1DC9E80 Offset: 0x1DC9F81 VA: 0x1DC9E80 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x1DC9F20 Offset: 0x1DCA021 VA: 0x1DC9F20 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1DC9F30 Offset: 0x1DCA031 VA: 0x1DC9F30 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.InventoryItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10277
{
	// Methods

	// RVA: 0x1DCB120 Offset: 0x1DCB221 VA: 0x1DCB120 Slot: 4
	public override string GetName() { }

	// RVA: 0x1DCB1A0 Offset: 0x1DCB2A1 VA: 0x1DCB1A0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x1DCB220 Offset: 0x1DCB321 VA: 0x1DCB220 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1DCB230 Offset: 0x1DCB331 VA: 0x1DCB230 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1DCB430 Offset: 0x1DCB531 VA: 0x1DCB430
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.GodItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10278
{
	// Methods

	// RVA: 0x1DCAE00 Offset: 0x1DCAF01 VA: 0x1DCAE00 Slot: 4
	public override string GetName() { }

	// RVA: 0x1DCAE80 Offset: 0x1DCAF81 VA: 0x1DCAE80 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x1DCAF00 Offset: 0x1DCB001 VA: 0x1DCAF00 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1DCAF10 Offset: 0x1DCB011 VA: 0x1DCAF10 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1DCB110 Offset: 0x1DCB211 VA: 0x1DCB110
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.SubFriendMenu.RelianceItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10279
{
	// Methods

	// RVA: 0x2D739B0 Offset: 0x2D73AB1 VA: 0x2D739B0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D73A30 Offset: 0x2D73B31 VA: 0x2D73A30 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2D73AB0 Offset: 0x2D73BB1 VA: 0x2D73AB0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D73AC0 Offset: 0x2D73BC1 VA: 0x2D73AC0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D73CE0 Offset: 0x2D73DE1 VA: 0x2D73CE0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D73CF0 Offset: 0x2D73DF1 VA: 0x2D73CF0
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.SubFriendMenu.KizunaItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10280
{
	// Methods

	// RVA: 0x2D73400 Offset: 0x2D73501 VA: 0x2D73400 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D73480 Offset: 0x2D73581 VA: 0x2D73480 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2D73500 Offset: 0x2D73601 VA: 0x2D73500 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D73510 Offset: 0x2D73611 VA: 0x2D73510 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D73730 Offset: 0x2D73831 VA: 0x2D73730 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D73740 Offset: 0x2D73841 VA: 0x2D73740
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.SubFriendMenu.NotebookItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10281
{
	// Methods

	// RVA: 0x2D73750 Offset: 0x2D73851 VA: 0x2D73750 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D737D0 Offset: 0x2D738D1 VA: 0x2D737D0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2D73850 Offset: 0x2D73951 VA: 0x2D73850 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D73860 Offset: 0x2D73961 VA: 0x2D73860 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D73990 Offset: 0x2D73A91 VA: 0x2D73990 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D739A0 Offset: 0x2D73AA1 VA: 0x2D739A0
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.SubFriendMenu.RingbookItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10282
{
	// Methods

	// RVA: 0x2D73D00 Offset: 0x2D73E01 VA: 0x2D73D00 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D73D80 Offset: 0x2D73E81 VA: 0x2D73D80 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2D73E00 Offset: 0x2D73F01 VA: 0x2D73E00 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D73E30 Offset: 0x2D73F31 VA: 0x2D73E30 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D73F60 Offset: 0x2D74061 VA: 0x2D73F60 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D73F70 Offset: 0x2D74071 VA: 0x2D73F70
	public void .ctor() { }
}

// Namespace: 
public class GmapMenuSequence.GmapMenu.SubFriendMenu : BasicMenu // TypeDefIndex: 10283
{
	// Methods

	// RVA: 0x1DCC370 Offset: 0x1DCC471 VA: 0x1DCC370
	protected void .ctor(List<BasicMenuItem> menuItemList, SortieSubMenuContent menuContent) { }

	// RVA: 0x1DCC380 Offset: 0x1DCC481 VA: 0x1DCC380 Slot: 30
	public override string GetName() { }

	// RVA: 0x1DCA4F0 Offset: 0x1DCA5F1 VA: 0x1DCA4F0
	public static void CreateBind(BasicMenu super, BasicMenuItem parentMenuItem) { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.FriendItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10284
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x1DCA1D0 Offset: 0x1DCA2D1 VA: 0x1DCA1D0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x1DCA220 Offset: 0x1DCA321 VA: 0x1DCA220 Slot: 4
	public override string GetName() { }

	// RVA: 0x1DCA2A0 Offset: 0x1DCA3A1 VA: 0x1DCA2A0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x1DCA320 Offset: 0x1DCA421 VA: 0x1DCA320 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x1DCA330 Offset: 0x1DCA431 VA: 0x1DCA330 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1DCA740 Offset: 0x1DCA841 VA: 0x1DCA740
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.SaveItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10285
{
	// Methods

	// RVA: 0x1DCBD30 Offset: 0x1DCBE31 VA: 0x1DCBD30 Slot: 4
	public override string GetName() { }

	// RVA: 0x1DCBDB0 Offset: 0x1DCBEB1 VA: 0x1DCBDB0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x1DCBE30 Offset: 0x1DCBF31 VA: 0x1DCBE30 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1DCBE40 Offset: 0x1DCBF41 VA: 0x1DCBE40 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1DCBFA0 Offset: 0x1DCC0A1 VA: 0x1DCBFA0
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.SubSystemMenu.TutorialItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10286
{
	// Methods

	// RVA: 0x2D747E0 Offset: 0x2D748E1 VA: 0x2D747E0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D74860 Offset: 0x2D74961 VA: 0x2D74860 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2D748E0 Offset: 0x2D749E1 VA: 0x2D748E0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D748F0 Offset: 0x2D749F1 VA: 0x2D748F0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D74A20 Offset: 0x2D74B21 VA: 0x2D74A20 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D74A30 Offset: 0x2D74B31 VA: 0x2D74A30
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.SubSystemMenu.ConfigItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10287
{
	// Methods

	// RVA: 0x2D74400 Offset: 0x2D74501 VA: 0x2D74400 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D74480 Offset: 0x2D74581 VA: 0x2D74480 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2D74500 Offset: 0x2D74601 VA: 0x2D74500 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D74510 Offset: 0x2D74611 VA: 0x2D74510 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D74640 Offset: 0x2D74741 VA: 0x2D74640 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D74650 Offset: 0x2D74751 VA: 0x2D74650
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.SubSystemMenu.ResetItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10288
{
	// Methods

	// RVA: 0x2D74660 Offset: 0x2D74761 VA: 0x2D74660 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D746E0 Offset: 0x2D747E1 VA: 0x2D746E0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2D74760 Offset: 0x2D74861 VA: 0x2D74760 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D74770 Offset: 0x2D74871 VA: 0x2D74770 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D747C0 Offset: 0x2D748C1 VA: 0x2D747C0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D747D0 Offset: 0x2D748D1 VA: 0x2D747D0
	public void .ctor() { }
}

// Namespace: 
public class GmapMenuSequence.GmapMenu.SubSystemMenu : BasicMenu // TypeDefIndex: 10289
{
	// Methods

	// RVA: 0x1DCC430 Offset: 0x1DCC531 VA: 0x1DCC430
	protected void .ctor(List<BasicMenuItem> menuItemList, SortieSubMenuContent menuContent) { }

	// RVA: 0x1DCC440 Offset: 0x1DCC541 VA: 0x1DCC440 Slot: 30
	public override string GetName() { }

	// RVA: 0x1DCC490 Offset: 0x1DCC591 VA: 0x1DCC490
	public static void CreateBind(BasicMenu super, BasicMenuItem parentMenuItem) { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.SystemItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10290
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x1DCC6B0 Offset: 0x1DCC7B1 VA: 0x1DCC6B0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x1DCC700 Offset: 0x1DCC801 VA: 0x1DCC700 Slot: 4
	public override string GetName() { }

	// RVA: 0x1DCC780 Offset: 0x1DCC881 VA: 0x1DCC780 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x1DCC800 Offset: 0x1DCC901 VA: 0x1DCC800 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x1DCC810 Offset: 0x1DCC911 VA: 0x1DCC810 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1DCC8D0 Offset: 0x1DCC9D1 VA: 0x1DCC8D0
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.SubShopMenu.WeaponShopMenuItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10291
{
	// Methods

	// RVA: 0x2D741C0 Offset: 0x2D742C1 VA: 0x2D741C0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D74240 Offset: 0x2D74341 VA: 0x2D74240 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2D742C0 Offset: 0x2D743C1 VA: 0x2D742C0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D74370 Offset: 0x2D74471 VA: 0x2D74370 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D743E0 Offset: 0x2D744E1 VA: 0x2D743E0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D743F0 Offset: 0x2D744F1 VA: 0x2D743F0
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.SubShopMenu.ItemShopMenuItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10292
{
	// Methods

	// RVA: 0x2D73F80 Offset: 0x2D74081 VA: 0x2D73F80 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D74000 Offset: 0x2D74101 VA: 0x2D74000 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2D74080 Offset: 0x2D74181 VA: 0x2D74080 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D74130 Offset: 0x2D74231 VA: 0x2D74130 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D741A0 Offset: 0x2D742A1 VA: 0x2D741A0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D741B0 Offset: 0x2D742B1 VA: 0x2D741B0
	public void .ctor() { }
}

// Namespace: 
public class GmapMenuSequence.GmapMenu.SubShopMenu : BasicMenu // TypeDefIndex: 10293
{
	// Methods

	// RVA: 0x1DCC3D0 Offset: 0x1DCC4D1 VA: 0x1DCC3D0
	protected void .ctor(List<BasicMenuItem> menuItemList, SortieSubMenuContent menuContent) { }

	// RVA: 0x1DCC3E0 Offset: 0x1DCC4E1 VA: 0x1DCC3E0 Slot: 30
	public override string GetName() { }

	// RVA: 0x1DCC180 Offset: 0x1DCC281 VA: 0x1DCC180
	public static void CreateBind(BasicMenu super, BasicMenuItem parentMenuItem) { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.ShopItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10294
{
	// Methods

	// RVA: 0x1DCBFB0 Offset: 0x1DCC0B1 VA: 0x1DCBFB0 Slot: 4
	public override string GetName() { }

	// RVA: 0x1DCC030 Offset: 0x1DCC131 VA: 0x1DCC030 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x1DCC0B0 Offset: 0x1DCC1B1 VA: 0x1DCC0B0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1DCC0C0 Offset: 0x1DCC1C1 VA: 0x1DCC0C0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1DCC360 Offset: 0x1DCC461 VA: 0x1DCC360
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.RankingItem.JumpToRankingSequence : ProcInst // TypeDefIndex: 10295
{
	// Fields
	private Action m_JumpFunc; // 0x70

	// Methods

	// RVA: 0x2D73180 Offset: 0x2D73281 VA: 0x2D73180
	private void .ctor(Action jumpFunc) { }

	// RVA: 0x2D731C0 Offset: 0x2D732C1 VA: 0x2D731C0
	private void JumpToRanking() { }

	// RVA: 0x2D731E0 Offset: 0x2D732E1 VA: 0x2D731E0
	public static void CreateBind(ProcInst super, Action jumpFunc) { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.RankingItem.ConfirmSequence.YesMenuItem : BasicDialogItemYes // TypeDefIndex: 10296
{
	// Fields
	private NetEnableSequence.ResultFunction m_ResultFunc; // 0x70

	// Methods

	// RVA: 0x2D72F10 Offset: 0x2D73011 VA: 0x2D72F10
	public void .ctor(NetEnableSequence.ResultFunction resultFunc) { }

	// RVA: 0x2D7F190 Offset: 0x2D7F291 VA: 0x2D7F190 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D7F210 Offset: 0x2D7F311 VA: 0x2D7F210 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.RankingItem.ConfirmSequence.NoMenuItem : BasicDialogItemNo // TypeDefIndex: 10297
{
	// Methods

	// RVA: 0x2D7F110 Offset: 0x2D7F211 VA: 0x2D7F110 Slot: 4
	public override string GetName() { }

	// RVA: 0x2D72F50 Offset: 0x2D73051 VA: 0x2D72F50
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.RankingItem.ConfirmSequence : ProcInst // TypeDefIndex: 10298
{
	// Fields
	private NetEnableSequence.ResultFunction m_ResultFunc; // 0x70

	// Methods

	// RVA: 0x2D72DC0 Offset: 0x2D72EC1 VA: 0x2D72DC0
	private void .ctor(NetEnableSequence.ResultFunction resultFunc) { }

	// RVA: 0x2D72E00 Offset: 0x2D72F01 VA: 0x2D72E00
	private void Confirm() { }

	// RVA: 0x2D72F60 Offset: 0x2D73061 VA: 0x2D72F60
	public static void CreateBind(ProcInst super, NetEnableSequence.ResultFunction resultFunc) { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.RankingItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10299
{
	// Methods

	// RVA: 0x1DCB760 Offset: 0x1DCB861 VA: 0x1DCB760 Slot: 4
	public override string GetName() { }

	// RVA: 0x1DCB7E0 Offset: 0x1DCB8E1 VA: 0x1DCB7E0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x1DCB860 Offset: 0x1DCB961 VA: 0x1DCB860 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1DCB910 Offset: 0x1DCBA11 VA: 0x1DCB910 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1DCBA70 Offset: 0x1DCBB71 VA: 0x1DCBA70
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD900 Offset: 0x2BDA01 VA: 0x2BD900
	// RVA: 0x1DCBA80 Offset: 0x1DCBB81 VA: 0x1DCBA80
	private void <ACall>b__3_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD910 Offset: 0x2BDA11 VA: 0x2BD910
	// RVA: 0x1DCBBD0 Offset: 0x1DCBCD1 VA: 0x1DCBBD0
	private void <ACall>b__3_1(bool isEnable) { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.MaterialListItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10300
{
	// Methods

	// RVA: 0x1DCB440 Offset: 0x1DCB541 VA: 0x1DCB440 Slot: 4
	public override string GetName() { }

	// RVA: 0x1DCB4C0 Offset: 0x1DCB5C1 VA: 0x1DCB4C0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x1DCB540 Offset: 0x1DCB641 VA: 0x1DCB540 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1DCB550 Offset: 0x1DCB651 VA: 0x1DCB550 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1DCB750 Offset: 0x1DCB851 VA: 0x1DCB750
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu.GoToSolanelItem : GmapMenuSequence.GmapMenu.GmapMenuMenuItem // TypeDefIndex: 10301
{
	// Methods

	// RVA: 0x1DCAA40 Offset: 0x1DCAB41 VA: 0x1DCAA40 Slot: 4
	public override string GetName() { }

	// RVA: 0x1DCAB60 Offset: 0x1DCAC61 VA: 0x1DCAB60 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x1DCAC80 Offset: 0x1DCAD81 VA: 0x1DCAC80 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x1DCAC90 Offset: 0x1DCAD91 VA: 0x1DCAC90 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x1DCADF0 Offset: 0x1DCAEF1 VA: 0x1DCADF0
	public void .ctor() { }
}

// Namespace: 
private class GmapMenuSequence.GmapMenu : BasicMenu // TypeDefIndex: 10302
{
	// Properties
	public static EnterChapterYesNoDialog.Type EnterChapterType { get; }

	// Methods

	// RVA: 0x22EE5B0 Offset: 0x22EE6B1 VA: 0x22EE5B0
	public static EnterChapterYesNoDialog.Type get_EnterChapterType() { }

	// RVA: 0x22EE600 Offset: 0x22EE701 VA: 0x22EE600
	protected void .ctor(List<BasicMenuItem> menuItemList, BasicMenuContent menuContent) { }

	// RVA: 0x22EE610 Offset: 0x22EE711 VA: 0x22EE610 Slot: 30
	public override string GetName() { }

	// RVA: 0x22EE660 Offset: 0x22EE761 VA: 0x22EE660
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x22EEA30 Offset: 0x22EEB31 VA: 0x22EEA30
	private static void AddStartChapterItem(List<BasicMenuItem> menuItemList) { }

	// RVA: 0x22EEC90 Offset: 0x22EED91 VA: 0x22EEC90 Slot: 28
	protected override void OnResume() { }

	// RVA: 0x22EED30 Offset: 0x22EEE31 VA: 0x22EED30 Slot: 51
	protected override BasicMenu.Result BCall() { }
}

// Namespace: 
private enum GmapMenuSequence.GoToMapSequence.Label // TypeDefIndex: 10303
{
	// Fields
	public int value__; // 0x0
	public const GmapMenuSequence.GoToMapSequence.Label MoveToSolanel = 0;
	public const GmapMenuSequence.GoToMapSequence.Label MoveToGmap = 1;
	public const GmapMenuSequence.GoToMapSequence.Label End = 2;
}

// Namespace: 
private class GmapMenuSequence.GoToMapSequence : ProcInst // TypeDefIndex: 10304
{
	// Methods

	// RVA: 0x22EEE60 Offset: 0x22EEF61 VA: 0x22EEE60
	private void OpenDialog() { }

	// RVA: 0x22EF000 Offset: 0x22EF101 VA: 0x22EF000
	private void MoveSolanel() { }

	// RVA: 0x22EF1E0 Offset: 0x22EF2E1 VA: 0x22EF1E0
	private void MoveGmap() { }

	// RVA: 0x22EF390 Offset: 0x22EF491 VA: 0x22EF390
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x22EF840 Offset: 0x22EF941 VA: 0x22EF840
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD920 Offset: 0x2BDA21 VA: 0x2BD920
	// RVA: 0x22EF850 Offset: 0x22EF951 VA: 0x22EF850
	private void <OpenDialog>b__1_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD930 Offset: 0x2BDA31 VA: 0x2BD930
	// RVA: 0x22EF950 Offset: 0x22EFA51 VA: 0x22EF950
	private void <OpenDialog>b__1_1(GmapMode.Mode mode) { }
}

