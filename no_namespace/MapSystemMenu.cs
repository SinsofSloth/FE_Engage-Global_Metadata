// Namespace: 
public abstract class MapSystemMenu.MapSystemMenuItem : MapBasicMenuItem // TypeDefIndex: 12275
{
	// Methods

	// RVA: 0x213D530 Offset: 0x213D631 VA: 0x213D530 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x213D540 Offset: 0x213D641 VA: 0x213D540 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x213D660 Offset: 0x213D761 VA: 0x213D660 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x213D570 Offset: 0x213D671 VA: 0x213D570
	public void HelpOn() { }

	// RVA: 0x213D520 Offset: 0x213D621 VA: 0x213D520
	protected void .ctor() { }
}

// Namespace: 
private class MapSystemMenu.UnitListItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12276
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x213EF40 Offset: 0x213F041 VA: 0x213EF40 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x213EF90 Offset: 0x213F091 VA: 0x213EF90 Slot: 4
	public override string GetName() { }

	// RVA: 0x213F010 Offset: 0x213F111 VA: 0x213F010 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x213F090 Offset: 0x213F191 VA: 0x213F090 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x213F200 Offset: 0x213F301 VA: 0x213F200 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x213F330 Offset: 0x213F431 VA: 0x213F330
	public void .ctor() { }
}

// Namespace: 
private class MapSystemMenu.RewindMenuItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12277
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x213DB20 Offset: 0x213DC21 VA: 0x213DB20 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x213DB70 Offset: 0x213DC71 VA: 0x213DB70
	public void .ctor() { }

	// RVA: 0x213DB80 Offset: 0x213DC81 VA: 0x213DB80 Slot: 4
	public override string GetName() { }

	// RVA: 0x213DC00 Offset: 0x213DD01 VA: 0x213DC00 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x213DC80 Offset: 0x213DD81 VA: 0x213DC80 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x213DCF0 Offset: 0x213DDF1 VA: 0x213DCF0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MapSystemMenu.OrderItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12278
{
	// Fields
	private SortieTopMenuContent m_SortieTopMenuContent; // 0x68

	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x213D770 Offset: 0x213D871 VA: 0x213D770 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x213D7C0 Offset: 0x213D8C1 VA: 0x213D7C0
	public void .ctor(SortieTopMenuContent sortieTopMenuContent) { }

	// RVA: 0x213D800 Offset: 0x213D901 VA: 0x213D800 Slot: 4
	public override string GetName() { }

	// RVA: 0x213D880 Offset: 0x213D981 VA: 0x213D880 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x213D900 Offset: 0x213DA01 VA: 0x213D900 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x213D9D0 Offset: 0x213DAD1 VA: 0x213D9D0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MapSystemMenu.TemporarySaveItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12279
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x213E660 Offset: 0x213E761 VA: 0x213E660 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x213E6B0 Offset: 0x213E7B1 VA: 0x213E6B0 Slot: 4
	public override string GetName() { }

	// RVA: 0x213E840 Offset: 0x213E941 VA: 0x213E840 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x213E9D0 Offset: 0x213EAD1 VA: 0x213E9D0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x213EC20 Offset: 0x213ED21 VA: 0x213EC20 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x213ECD0 Offset: 0x213EDD1 VA: 0x213ECD0
	public void .ctor() { }
}

// Namespace: 
private class MapSystemMenu.FriendMenuItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12280
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x213CDA0 Offset: 0x213CEA1 VA: 0x213CDA0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x213CDF0 Offset: 0x213CEF1 VA: 0x213CDF0 Slot: 4
	public override string GetName() { }

	// RVA: 0x213CE70 Offset: 0x213CF71 VA: 0x213CE70 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x213CEF0 Offset: 0x213CFF1 VA: 0x213CEF0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x213D0E0 Offset: 0x213D1E1 VA: 0x213D0E0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x213D510 Offset: 0x213D611 VA: 0x213D510
	public void .ctor() { }
}

// Namespace: 
private class MapSystemMenu.SubFriendMenu.RelianceItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12281
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21EB140 Offset: 0x21EB241 VA: 0x21EB140 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21EB190 Offset: 0x21EB291 VA: 0x21EB190 Slot: 4
	public override string GetName() { }

	// RVA: 0x21EB210 Offset: 0x21EB311 VA: 0x21EB210 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21EB290 Offset: 0x21EB391 VA: 0x21EB290 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21EB2A0 Offset: 0x21EB3A1 VA: 0x21EB2A0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21EB460 Offset: 0x21EB561 VA: 0x21EB460 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21EB5E0 Offset: 0x21EB6E1 VA: 0x21EB5E0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21EB5F0 Offset: 0x21EB6F1 VA: 0x21EB5F0
	public void .ctor() { }
}

// Namespace: 
private class MapSystemMenu.SubFriendMenu.KizunaItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12282
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21EA8E0 Offset: 0x21EA9E1 VA: 0x21EA8E0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21EA930 Offset: 0x21EAA31 VA: 0x21EA930 Slot: 4
	public override string GetName() { }

	// RVA: 0x21EA9B0 Offset: 0x21EAAB1 VA: 0x21EA9B0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21EAA30 Offset: 0x21EAB31 VA: 0x21EAA30 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21EAA40 Offset: 0x21EAB41 VA: 0x21EAA40 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21EAC00 Offset: 0x21EAD01 VA: 0x21EAC00 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21EAD80 Offset: 0x21EAE81 VA: 0x21EAD80 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21EAD90 Offset: 0x21EAE91 VA: 0x21EAD90
	public void .ctor() { }
}

// Namespace: 
private class MapSystemMenu.SubFriendMenu.NotebookItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12283
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21EADA0 Offset: 0x21EAEA1 VA: 0x21EADA0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21EADF0 Offset: 0x21EAEF1 VA: 0x21EADF0 Slot: 4
	public override string GetName() { }

	// RVA: 0x21EAE70 Offset: 0x21EAF71 VA: 0x21EAE70 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21EAEF0 Offset: 0x21EAFF1 VA: 0x21EAEF0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21EAF00 Offset: 0x21EB001 VA: 0x21EAF00 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21EB0C0 Offset: 0x21EB1C1 VA: 0x21EB0C0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21EB120 Offset: 0x21EB221 VA: 0x21EB120 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21EB130 Offset: 0x21EB231 VA: 0x21EB130
	public void .ctor() { }
}

// Namespace: 
private class MapSystemMenu.SubFriendMenu.RingListItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12284
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21EB600 Offset: 0x21EB701 VA: 0x21EB600 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21EB650 Offset: 0x21EB751 VA: 0x21EB650 Slot: 4
	public override string GetName() { }

	// RVA: 0x21EB6D0 Offset: 0x21EB7D1 VA: 0x21EB6D0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21EB750 Offset: 0x21EB851 VA: 0x21EB750 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21EB760 Offset: 0x21EB861 VA: 0x21EB760 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21EB790 Offset: 0x21EB891 VA: 0x21EB790 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21EB7F0 Offset: 0x21EB8F1 VA: 0x21EB7F0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21EB800 Offset: 0x21EB901 VA: 0x21EB800
	public void .ctor() { }
}

// Namespace: 
public class MapSystemMenu.SubFriendMenu : BasicMenu // TypeDefIndex: 12285
{
	// Fields
	public static MapSystemMenu m_parentMenu; // 0x0

	// Methods

	// RVA: 0x213DDD0 Offset: 0x213DED1 VA: 0x213DDD0
	protected void .ctor(List<BasicMenuItem> menuItemList, SortieSubMenuContent menuContent) { }

	// RVA: 0x213DDE0 Offset: 0x213DEE1 VA: 0x213DDE0 Slot: 30
	public override string GetName() { }

	// RVA: 0x213D250 Offset: 0x213D351 VA: 0x213D250
	public static void CreateBind(BasicMenu super, BasicMenuItem parentMenuItem) { }

	// RVA: 0x213DE30 Offset: 0x213DF31 VA: 0x213DE30 Slot: 51
	protected override BasicMenu.Result BCall() { }
}

// Namespace: 
private class MapSystemMenu.SystemMenuItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12286
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x213E3A0 Offset: 0x213E4A1 VA: 0x213E3A0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x213E3F0 Offset: 0x213E4F1 VA: 0x213E3F0 Slot: 4
	public override string GetName() { }

	// RVA: 0x213E470 Offset: 0x213E571 VA: 0x213E470 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x213E4F0 Offset: 0x213E5F1 VA: 0x213E4F0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x213E500 Offset: 0x213E601 VA: 0x213E500 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x213E650 Offset: 0x213E751 VA: 0x213E650
	public void .ctor() { }
}

// Namespace: 
private class MapSystemMenu.SubSystemMenu.TutorialItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12287
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21EC590 Offset: 0x21EC691 VA: 0x21EC590 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21EC5E0 Offset: 0x21EC6E1 VA: 0x21EC5E0 Slot: 4
	public override string GetName() { }

	// RVA: 0x21EC660 Offset: 0x21EC761 VA: 0x21EC660 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21EC6E0 Offset: 0x21EC7E1 VA: 0x21EC6E0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21EC6F0 Offset: 0x21EC7F1 VA: 0x21EC6F0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21EC700 Offset: 0x21EC801 VA: 0x21EC700 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21EC760 Offset: 0x21EC861 VA: 0x21EC760 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21EC770 Offset: 0x21EC871 VA: 0x21EC770
	public void .ctor() { }
}

// Namespace: 
private class MapSystemMenu.SubSystemMenu.ConfigItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12288
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21EB810 Offset: 0x21EB911 VA: 0x21EB810 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21EB860 Offset: 0x21EB961 VA: 0x21EB860 Slot: 4
	public override string GetName() { }

	// RVA: 0x21EB8E0 Offset: 0x21EB9E1 VA: 0x21EB8E0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21EB960 Offset: 0x21EBA61 VA: 0x21EB960 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21EB970 Offset: 0x21EBA71 VA: 0x21EB970 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21EB980 Offset: 0x21EBA81 VA: 0x21EB980 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21EB9E0 Offset: 0x21EBAE1 VA: 0x21EB9E0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21EB9F0 Offset: 0x21EBAF1 VA: 0x21EB9F0
	public void .ctor() { }
}

// Namespace: 
private class MapSystemMenu.SubSystemMenu.RestartItem.ConfirmDialogItemYes : BasicDialogItemYes // TypeDefIndex: 12289
{
	// Fields
	private GameUserRestartData.Targtes m_Target; // 0x70

	// Methods

	// RVA: 0x2D7CCE0 Offset: 0x2D7CDE1 VA: 0x2D7CCE0
	public void .ctor(GameUserRestartData.Targtes target) { }

	// RVA: 0x2D7CD80 Offset: 0x2D7CE81 VA: 0x2D7CD80 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MapSystemMenu.SubSystemMenu.RestartItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12290
{
	// Fields
	private GameUserRestartData.Targtes m_Target; // 0x64

	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21EBCB0 Offset: 0x21EBDB1 VA: 0x21EBCB0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21EBD00 Offset: 0x21EBE01 VA: 0x21EBD00
	public void .ctor(GameUserRestartData.Targtes target) { }

	// RVA: 0x21EBD30 Offset: 0x21EBE31 VA: 0x21EBD30 Slot: 4
	public override string GetName() { }

	// RVA: 0x21EBDF0 Offset: 0x21EBEF1 VA: 0x21EBDF0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21EBEB0 Offset: 0x21EBFB1 VA: 0x21EBEB0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21EBEC0 Offset: 0x21EBFC1 VA: 0x21EBEC0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21EBFF0 Offset: 0x21EC0F1 VA: 0x21EBFF0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21EC190 Offset: 0x21EC291 VA: 0x21EC190 Slot: 19
	public override BasicMenu.Result BCall() { }
}

// Namespace: 
private class MapSystemMenu.SubSystemMenu.SurrenderItem.ConfirmDialogItemYes : BasicDialogItemYes // TypeDefIndex: 12291
{
	// Methods

	// RVA: 0x2D7CE10 Offset: 0x2D7CF11 VA: 0x2D7CE10
	public void .ctor(string text) { }

	// RVA: 0x2D7CE20 Offset: 0x2D7CF21 VA: 0x2D7CE20 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class MapSystemMenu.SubSystemMenu.SurrenderItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12292
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21EC1A0 Offset: 0x21EC2A1 VA: 0x21EC1A0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21EC1F0 Offset: 0x21EC2F1 VA: 0x21EC1F0 Slot: 4
	public override string GetName() { }

	// RVA: 0x21EC2D0 Offset: 0x21EC3D1 VA: 0x21EC2D0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21EC3B0 Offset: 0x21EC4B1 VA: 0x21EC3B0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21EC3C0 Offset: 0x21EC4C1 VA: 0x21EC3C0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21EC3D0 Offset: 0x21EC4D1 VA: 0x21EC3D0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21EC570 Offset: 0x21EC671 VA: 0x21EC570 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21EC580 Offset: 0x21EC681 VA: 0x21EC580
	public void .ctor() { }
}

// Namespace: 
private class MapSystemMenu.SubSystemMenu.ResetItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12293
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21EBA00 Offset: 0x21EBB01 VA: 0x21EBA00 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21EBA50 Offset: 0x21EBB51 VA: 0x21EBA50 Slot: 4
	public override string GetName() { }

	// RVA: 0x21EBAD0 Offset: 0x21EBBD1 VA: 0x21EBAD0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21EBB50 Offset: 0x21EBC51 VA: 0x21EBB50 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21EBB60 Offset: 0x21EBC61 VA: 0x21EBB60 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21EBC40 Offset: 0x21EBD41 VA: 0x21EBC40 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21EBC90 Offset: 0x21EBD91 VA: 0x21EBC90 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21EBCA0 Offset: 0x21EBDA1 VA: 0x21EBCA0
	public void .ctor() { }
}

// Namespace: 
public class MapSystemMenu.SubSystemMenu : BasicMenu // TypeDefIndex: 12294
{
	// Fields
	public static MapSystemMenu m_parentMenu; // 0x0

	// Methods

	// RVA: 0x213DEA0 Offset: 0x213DFA1 VA: 0x213DEA0
	protected void .ctor(List<BasicMenuItem> menuItemList, SortieSubMenuContent menuContent) { }

	// RVA: 0x213DEB0 Offset: 0x213DFB1 VA: 0x213DEB0 Slot: 30
	public override string GetName() { }

	// RVA: 0x213DF00 Offset: 0x213E001 VA: 0x213DF00
	public static void CreateBind(BasicMenu super, BasicMenuItem parentMenuItem) { }

	// RVA: 0x213E330 Offset: 0x213E431 VA: 0x213E330 Slot: 51
	protected override BasicMenu.Result BCall() { }
}

// Namespace: 
private class MapSystemMenu.TurnItem : MapSystemMenu.MapSystemMenuItem // TypeDefIndex: 12295
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x213ECE0 Offset: 0x213EDE1 VA: 0x213ECE0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x213ED30 Offset: 0x213EE31 VA: 0x213ED30 Slot: 4
	public override string GetName() { }

	// RVA: 0x213EDB0 Offset: 0x213EEB1 VA: 0x213EDB0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x213EE30 Offset: 0x213EF31 VA: 0x213EE30 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x213EE40 Offset: 0x213EF41 VA: 0x213EE40 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x213EF30 Offset: 0x213F031 VA: 0x213EF30
	public void .ctor() { }
}

