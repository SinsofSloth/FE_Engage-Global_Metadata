// Namespace: 
private abstract class SortieTopMenu.SortieTopMenuItemBase : MapBasicMenuItem // TypeDefIndex: 13260
{
	// Methods

	// RVA: 0x20462E0 Offset: 0x20463E1 VA: 0x20462E0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x20464C0 Offset: 0x20465C1 VA: 0x20464C0 Slot: 24
	public override BasicMenu.Result PlusCall() { }

	// RVA: 0x20466A0 Offset: 0x20467A1 VA: 0x20466A0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x20467C0 Offset: 0x20468C1 VA: 0x20467C0 Slot: 13
	public override void OnDeselect() { }

	// RVA: 0x20466D0 Offset: 0x20467D1 VA: 0x20466D0
	public void HelpOn() { }

	// RVA: 0x2046620 Offset: 0x2046721 VA: 0x2046620
	protected BasicMenu.Result GoToBattle() { }

	// RVA: 0x2043AC0 Offset: 0x2043BC1 VA: 0x2043AC0
	protected BasicMenu.Result BackTo(bool isCancel) { }

	// RVA: 0x20440B0 Offset: 0x20441B1 VA: 0x20440B0
	protected void SaveMenuSelect() { }

	// RVA: 0x2043BD0 Offset: 0x2043CD1 VA: 0x2043BD0
	protected void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.SelectionUnitMenuItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13261
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x2045800 Offset: 0x2045901 VA: 0x2045800 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x2045850 Offset: 0x2045951 VA: 0x2045850 Slot: 4
	public override string GetName() { }

	// RVA: 0x20458D0 Offset: 0x20459D1 VA: 0x20458D0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x20459A0 Offset: 0x2045AA1 VA: 0x20459A0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x2045B40 Offset: 0x2045C41 VA: 0x2045B40 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2045CA0 Offset: 0x2045DA1 VA: 0x2045CA0
	public void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.PositionChangeMenuItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13262
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x2044A00 Offset: 0x2044B01 VA: 0x2044A00 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x2044A50 Offset: 0x2044B51 VA: 0x2044A50 Slot: 4
	public override string GetName() { }

	// RVA: 0x2044AD0 Offset: 0x2044BD1 VA: 0x2044AD0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2044B50 Offset: 0x2044C51 VA: 0x2044B50 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x2044B60 Offset: 0x2044C61 VA: 0x2044B60 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2044CC0 Offset: 0x2044DC1 VA: 0x2044CC0
	public void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.ShopMenuItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13263
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x2045CB0 Offset: 0x2045DB1 VA: 0x2045CB0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x2045D00 Offset: 0x2045E01 VA: 0x2045D00 Slot: 4
	public override string GetName() { }

	// RVA: 0x2045D80 Offset: 0x2045E81 VA: 0x2045D80 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2045EC0 Offset: 0x2045FC1 VA: 0x2045EC0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x2046130 Offset: 0x2046231 VA: 0x2046130 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x20462D0 Offset: 0x20463D1 VA: 0x20462D0
	public void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.FriendMenuItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13264
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x2043BE0 Offset: 0x2043CE1 VA: 0x2043BE0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x2043C30 Offset: 0x2043D31 VA: 0x2043C30 Slot: 4
	public override string GetName() { }

	// RVA: 0x2043CB0 Offset: 0x2043DB1 VA: 0x2043CB0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2043D30 Offset: 0x2043E31 VA: 0x2043D30 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x2043F20 Offset: 0x2044021 VA: 0x2043F20 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2044390 Offset: 0x2044491 VA: 0x2044390
	public void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.SubFriendMenu.RelianceItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13265
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21F9990 Offset: 0x21F9A91 VA: 0x21F9990 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21F99E0 Offset: 0x21F9AE1 VA: 0x21F99E0 Slot: 4
	public override string GetName() { }

	// RVA: 0x21F9A60 Offset: 0x21F9B61 VA: 0x21F9A60 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21F9AE0 Offset: 0x21F9BE1 VA: 0x21F9AE0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21F9AF0 Offset: 0x21F9BF1 VA: 0x21F9AF0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21F9CB0 Offset: 0x21F9DB1 VA: 0x21F9CB0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21F9E30 Offset: 0x21F9F31 VA: 0x21F9E30 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21F9E40 Offset: 0x21F9F41 VA: 0x21F9E40
	public void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.SubFriendMenu.KizunaItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13266
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21F9130 Offset: 0x21F9231 VA: 0x21F9130 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21F9180 Offset: 0x21F9281 VA: 0x21F9180 Slot: 4
	public override string GetName() { }

	// RVA: 0x21F9200 Offset: 0x21F9301 VA: 0x21F9200 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21F9280 Offset: 0x21F9381 VA: 0x21F9280 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21F9290 Offset: 0x21F9391 VA: 0x21F9290 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21F9450 Offset: 0x21F9551 VA: 0x21F9450 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21F95D0 Offset: 0x21F96D1 VA: 0x21F95D0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21F95E0 Offset: 0x21F96E1 VA: 0x21F95E0
	public void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.SubFriendMenu.NotebookItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13267
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21F95F0 Offset: 0x21F96F1 VA: 0x21F95F0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21F9640 Offset: 0x21F9741 VA: 0x21F9640 Slot: 4
	public override string GetName() { }

	// RVA: 0x21F96C0 Offset: 0x21F97C1 VA: 0x21F96C0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21F9740 Offset: 0x21F9841 VA: 0x21F9740 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21F9750 Offset: 0x21F9851 VA: 0x21F9750 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21F9910 Offset: 0x21F9A11 VA: 0x21F9910 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21F9970 Offset: 0x21F9A71 VA: 0x21F9970 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21F9980 Offset: 0x21F9A81 VA: 0x21F9980
	public void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.SubFriendMenu.RingListItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13268
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21F9E50 Offset: 0x21F9F51 VA: 0x21F9E50 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21F9EA0 Offset: 0x21F9FA1 VA: 0x21F9EA0 Slot: 4
	public override string GetName() { }

	// RVA: 0x21F9F20 Offset: 0x21FA021 VA: 0x21F9F20 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21F9FA0 Offset: 0x21FA0A1 VA: 0x21F9FA0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21F9FB0 Offset: 0x21FA0B1 VA: 0x21F9FB0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21FA060 Offset: 0x21FA161 VA: 0x21FA060 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21FA0C0 Offset: 0x21FA1C1 VA: 0x21FA0C0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21FA0D0 Offset: 0x21FA1D1 VA: 0x21FA0D0
	public void .ctor() { }
}

// Namespace: 
public class SortieTopMenu.SubFriendMenu : BasicMenu // TypeDefIndex: 13269
{
	// Methods

	// RVA: 0x2046BC0 Offset: 0x2046CC1 VA: 0x2046BC0
	protected void .ctor(List<BasicMenuItem> menuItemList, SortieSubMenuContent menuContent) { }

	// RVA: 0x2046BD0 Offset: 0x2046CD1 VA: 0x2046BD0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2044140 Offset: 0x2044241 VA: 0x2044140
	public static void CreateBind(BasicMenu super, BasicMenuItem parentMenuItem) { }

	// RVA: 0x2046C20 Offset: 0x2046D21 VA: 0x2046C20 Slot: 51
	protected override BasicMenu.Result BCall() { }
}

// Namespace: 
private class SortieTopMenu.GodMenuItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13270
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x20443A0 Offset: 0x20444A1 VA: 0x20443A0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x20443F0 Offset: 0x20444F1 VA: 0x20443F0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2044470 Offset: 0x2044571 VA: 0x2044470 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2044540 Offset: 0x2044641 VA: 0x2044540 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x2044570 Offset: 0x2044671 VA: 0x2044570 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x20446D0 Offset: 0x20447D1 VA: 0x20446D0
	public void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.InventoryMenuItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13271
{
	// Fields
	private SortieTopMenuContent m_SortieTopMenuContent; // 0x68

	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x20446E0 Offset: 0x20447E1 VA: 0x20446E0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x2044730 Offset: 0x2044831 VA: 0x2044730
	public void .ctor(SortieTopMenuContent sortieTopMenuContent) { }

	// RVA: 0x2044770 Offset: 0x2044871 VA: 0x2044770 Slot: 4
	public override string GetName() { }

	// RVA: 0x20447F0 Offset: 0x20448F1 VA: 0x20447F0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2044870 Offset: 0x2044971 VA: 0x2044870 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x20448A0 Offset: 0x20449A1 VA: 0x20448A0 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class SortieTopMenu.RelianceMenuItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13272
{
	// Fields
	private bool m_CanTalk; // 0x64

	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x2044CD0 Offset: 0x2044DD1 VA: 0x2044CD0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x2044D20 Offset: 0x2044E21 VA: 0x2044D20
	public void .ctor() { }

	// RVA: 0x2044D60 Offset: 0x2044E61 VA: 0x2044D60 Slot: 4
	public override string GetName() { }

	// RVA: 0x2044E40 Offset: 0x2044F41 VA: 0x2044E40 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x2044E70 Offset: 0x2044F71 VA: 0x2044E70 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class SortieTopMenu.SaveMenuItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13273
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x20454B0 Offset: 0x20455B1 VA: 0x20454B0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x2045500 Offset: 0x2045601 VA: 0x2045500 Slot: 4
	public override string GetName() { }

	// RVA: 0x2045580 Offset: 0x2045681 VA: 0x2045580 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2045600 Offset: 0x2045701 VA: 0x2045600 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x2045690 Offset: 0x2045791 VA: 0x2045690 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x20457F0 Offset: 0x20458F1 VA: 0x20457F0
	public void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.SystemMenuItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13274
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x2046FF0 Offset: 0x20470F1 VA: 0x2046FF0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x2047040 Offset: 0x2047141 VA: 0x2047040 Slot: 4
	public override string GetName() { }

	// RVA: 0x20470C0 Offset: 0x20471C1 VA: 0x20470C0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2047140 Offset: 0x2047241 VA: 0x2047140 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x2047150 Offset: 0x2047251 VA: 0x2047150 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x20472D0 Offset: 0x20473D1 VA: 0x20472D0
	public void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.SubSystemMenu.TutorialItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13275
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21FA7D0 Offset: 0x21FA8D1 VA: 0x21FA7D0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21FA820 Offset: 0x21FA921 VA: 0x21FA820 Slot: 4
	public override string GetName() { }

	// RVA: 0x21FA8A0 Offset: 0x21FA9A1 VA: 0x21FA8A0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21FA920 Offset: 0x21FAA21 VA: 0x21FA920 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21FA930 Offset: 0x21FAA31 VA: 0x21FA930 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21FA940 Offset: 0x21FAA41 VA: 0x21FA940 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21FA9A0 Offset: 0x21FAAA1 VA: 0x21FA9A0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21FA9B0 Offset: 0x21FAAB1 VA: 0x21FA9B0
	public void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.SubSystemMenu.ConfigItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13276
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21FA0E0 Offset: 0x21FA1E1 VA: 0x21FA0E0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21FA130 Offset: 0x21FA231 VA: 0x21FA130 Slot: 4
	public override string GetName() { }

	// RVA: 0x21FA1B0 Offset: 0x21FA2B1 VA: 0x21FA1B0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21FA230 Offset: 0x21FA331 VA: 0x21FA230 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21FA240 Offset: 0x21FA341 VA: 0x21FA240 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21FA250 Offset: 0x21FA351 VA: 0x21FA250 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21FA2B0 Offset: 0x21FA3B1 VA: 0x21FA2B0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21FA2C0 Offset: 0x21FA3C1 VA: 0x21FA2C0
	public void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.SubSystemMenu.ResetItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13277
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21FA520 Offset: 0x21FA621 VA: 0x21FA520 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21FA570 Offset: 0x21FA671 VA: 0x21FA570 Slot: 4
	public override string GetName() { }

	// RVA: 0x21FA5F0 Offset: 0x21FA6F1 VA: 0x21FA5F0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21FA670 Offset: 0x21FA771 VA: 0x21FA670 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21FA680 Offset: 0x21FA781 VA: 0x21FA680 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21FA760 Offset: 0x21FA861 VA: 0x21FA760 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21FA7B0 Offset: 0x21FA8B1 VA: 0x21FA7B0 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21FA7C0 Offset: 0x21FA8C1 VA: 0x21FA7C0
	public void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.SubSystemMenu.ReportItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13278
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x21FA2D0 Offset: 0x21FA3D1 VA: 0x21FA2D0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x21FA320 Offset: 0x21FA421 VA: 0x21FA320 Slot: 4
	public override string GetName() { }

	// RVA: 0x21FA3A0 Offset: 0x21FA4A1 VA: 0x21FA3A0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x21FA420 Offset: 0x21FA521 VA: 0x21FA420 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x21FA430 Offset: 0x21FA531 VA: 0x21FA430 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x21FA4A0 Offset: 0x21FA5A1 VA: 0x21FA4A0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x21FA500 Offset: 0x21FA601 VA: 0x21FA500 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x21FA510 Offset: 0x21FA611 VA: 0x21FA510
	public void .ctor() { }
}

// Namespace: 
public class SortieTopMenu.SubSystemMenu : BasicMenu // TypeDefIndex: 13279
{
	// Methods

	// RVA: 0x2046CB0 Offset: 0x2046DB1 VA: 0x2046CB0
	protected void .ctor(List<BasicMenuItem> menuItemList, SortieSubMenuContent menuContent) { }

	// RVA: 0x2046CC0 Offset: 0x2046DC1 VA: 0x2046CC0 Slot: 30
	public override string GetName() { }

	// RVA: 0x2046D10 Offset: 0x2046E11 VA: 0x2046D10
	public static void CreateBind(BasicMenu super, BasicMenuItem parentMenuItem) { }

	// RVA: 0x2046F60 Offset: 0x2047061 VA: 0x2046F60 Slot: 51
	protected override BasicMenu.Result BCall() { }
}

// Namespace: 
private class SortieTopMenu.StartMenuItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13280
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x20468D0 Offset: 0x20469D1 VA: 0x20468D0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x2046920 Offset: 0x2046A21 VA: 0x2046920 Slot: 10
	public override void OnBuild() { }

	// RVA: 0x20469C0 Offset: 0x2046AC1 VA: 0x20469C0 Slot: 4
	public override string GetName() { }

	// RVA: 0x2046A40 Offset: 0x2046B41 VA: 0x2046A40 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2046AC0 Offset: 0x2046BC1 VA: 0x2046AC0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x2046AF0 Offset: 0x2046BF1 VA: 0x2046AF0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2046BB0 Offset: 0x2046CB1 VA: 0x2046BB0
	public void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.BackMenuItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13281
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x20431E0 Offset: 0x20432E1 VA: 0x20431E0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x2043230 Offset: 0x2043331 VA: 0x2043230 Slot: 4
	public override string GetName() { }

	// RVA: 0x2043450 Offset: 0x2043551 VA: 0x2043450 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x20438C0 Offset: 0x20439C1 VA: 0x20438C0 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x2043A80 Offset: 0x2043B81 VA: 0x2043A80 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2043BC0 Offset: 0x2043CC1 VA: 0x2043BC0
	public void .ctor() { }
}

// Namespace: 
private class SortieTopMenu.ResetMapMenuItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13282
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x2044FD0 Offset: 0x20450D1 VA: 0x2044FD0 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x2045020 Offset: 0x2045121 VA: 0x2045020
	public void .ctor() { }

	// RVA: 0x2045030 Offset: 0x2045131 VA: 0x2045030 Slot: 4
	public override string GetName() { }

	// RVA: 0x20450B0 Offset: 0x20451B1 VA: 0x20450B0 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2045130 Offset: 0x2045231 VA: 0x2045130 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x2045140 Offset: 0x2045241 VA: 0x2045140 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class SortieTopMenu.SaveMapMenuItem : SortieTopMenu.SortieTopMenuItemBase // TypeDefIndex: 13283
{
	// Properties
	protected override string FlagID { get; }

	// Methods

	// RVA: 0x2045220 Offset: 0x2045321 VA: 0x2045220 Slot: 27
	protected override string get_FlagID() { }

	// RVA: 0x2045270 Offset: 0x2045371 VA: 0x2045270
	public void .ctor() { }

	// RVA: 0x2045280 Offset: 0x2045381 VA: 0x2045280 Slot: 4
	public override string GetName() { }

	// RVA: 0x2045300 Offset: 0x2045401 VA: 0x2045300 Slot: 28
	public override string GetHelpText() { }

	// RVA: 0x2045380 Offset: 0x2045481 VA: 0x2045380 Slot: 29
	protected override BasicMenuItem.Attribute GetMapAttribute() { }

	// RVA: 0x2045390 Offset: 0x2045491 VA: 0x2045390 Slot: 18
	public override BasicMenu.Result ACall() { }
}

