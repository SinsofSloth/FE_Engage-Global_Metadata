// Namespace: 
private class VersusSequence.VersusCasualMenu.SelectMapMenuItem : BasicMenuItem // TypeDefIndex: 13646
{
	// Fields
	private int m_MapNumber; // 0x64

	// Methods

	// RVA: 0x2D6BC20 Offset: 0x2D6BD21 VA: 0x2D6BC20
	public void .ctor(int mapNumber) { }

	// RVA: 0x2D6BD10 Offset: 0x2D6BE11 VA: 0x2D6BD10 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D6BE20 Offset: 0x2D6BF21 VA: 0x2D6BE20 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
public class VersusSequence.VersusCasualMenu : BasicMenu // TypeDefIndex: 13647
{
	// Fields
	private const int c_MapMax = 6;
	private static VersusMapMenuContent m_MenuContent; // 0x0
	private static int m_InitialSelected; // 0x8

	// Methods

	// RVA: 0x1EE5170 Offset: 0x1EE5271 VA: 0x1EE5170
	public static void InitializedSelected() { }

	// RVA: 0x1EE51E0 Offset: 0x1EE52E1 VA: 0x1EE51E0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1EE5400 Offset: 0x1EE5501 VA: 0x1EE5400
	protected void .ctor(List<BasicMenuItem> menuItemList, VersusMapMenuContent menuContent) { }

	// RVA: 0x1EE5500 Offset: 0x1EE5601 VA: 0x1EE5500 Slot: 30
	public override string GetName() { }

	// RVA: 0x1EE5550 Offset: 0x1EE5651 VA: 0x1EE5550 Slot: 63
	protected override string GetTutorial() { }

	// RVA: 0x1EE55A0 Offset: 0x1EE56A1 VA: 0x1EE55A0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x1EE55C0 Offset: 0x1EE56C1 VA: 0x1EE55C0
	private static void .cctor() { }
}

// Namespace: 
private class VersusSequence.DebugPersistentMenu : DebugMenu // TypeDefIndex: 13648
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29C880 Offset: 0x29C981 VA: 0x29C880
	private static bool <IsInitCasual>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x29C890 Offset: 0x29C991 VA: 0x29C890
	private static bool <IsSelectReplay>k__BackingField; // 0x1
	[CompilerGeneratedAttribute] // RVA: 0x29C8A0 Offset: 0x29C9A1 VA: 0x29C8A0
	private static bool <IsNotDeleteReplay>k__BackingField; // 0x2
	[CompilerGeneratedAttribute] // RVA: 0x29C8B0 Offset: 0x29C9B1 VA: 0x29C8B0
	private static bool <IsLocalAirportMode>k__BackingField; // 0x3
	[CompilerGeneratedAttribute] // RVA: 0x29C8C0 Offset: 0x29C9C1 VA: 0x29C8C0
	private static bool <IsReportedEdit>k__BackingField; // 0x4
	[CompilerGeneratedAttribute] // RVA: 0x29C8D0 Offset: 0x29C9D1 VA: 0x29C8D0
	private static bool <IsDuplicate>k__BackingField; // 0x5

	// Properties
	public static bool IsInitCasual { get; set; }
	public static bool IsSelectReplay { get; set; }
	public static bool IsNotDeleteReplay { get; set; }
	public static bool IsLocalAirportMode { get; set; }
	public static bool IsReportedEdit { get; set; }
	public static bool IsDuplicate { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CC570 Offset: 0x2CC671 VA: 0x2CC570
	// RVA: 0x1EE3510 Offset: 0x1EE3611 VA: 0x1EE3510
	public static bool get_IsInitCasual() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC580 Offset: 0x2CC681 VA: 0x2CC580
	// RVA: 0x1EE3580 Offset: 0x1EE3681 VA: 0x1EE3580
	public static void set_IsInitCasual(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC590 Offset: 0x2CC691 VA: 0x2CC590
	// RVA: 0x1EE3600 Offset: 0x1EE3701 VA: 0x1EE3600
	public static bool get_IsSelectReplay() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC5A0 Offset: 0x2CC6A1 VA: 0x2CC5A0
	// RVA: 0x1EE3670 Offset: 0x1EE3771 VA: 0x1EE3670
	public static void set_IsSelectReplay(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC5B0 Offset: 0x2CC6B1 VA: 0x2CC5B0
	// RVA: 0x1EE36F0 Offset: 0x1EE37F1 VA: 0x1EE36F0
	public static bool get_IsNotDeleteReplay() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC5C0 Offset: 0x2CC6C1 VA: 0x2CC5C0
	// RVA: 0x1EE3760 Offset: 0x1EE3861 VA: 0x1EE3760
	private static void set_IsNotDeleteReplay(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC5D0 Offset: 0x2CC6D1 VA: 0x2CC5D0
	// RVA: 0x1EE37E0 Offset: 0x1EE38E1 VA: 0x1EE37E0
	public static bool get_IsLocalAirportMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC5E0 Offset: 0x2CC6E1 VA: 0x2CC5E0
	// RVA: 0x1EE3850 Offset: 0x1EE3951 VA: 0x1EE3850
	private static void set_IsLocalAirportMode(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC5F0 Offset: 0x2CC6F1 VA: 0x2CC5F0
	// RVA: 0x1EE38D0 Offset: 0x1EE39D1 VA: 0x1EE38D0
	public static bool get_IsReportedEdit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC600 Offset: 0x2CC701 VA: 0x2CC600
	// RVA: 0x1EE3940 Offset: 0x1EE3A41 VA: 0x1EE3940
	private static void set_IsReportedEdit(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC610 Offset: 0x2CC711 VA: 0x2CC610
	// RVA: 0x1EE39C0 Offset: 0x1EE3AC1 VA: 0x1EE39C0
	public static bool get_IsDuplicate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC620 Offset: 0x2CC721 VA: 0x2CC620
	// RVA: 0x1EE3A30 Offset: 0x1EE3B31 VA: 0x1EE3A30
	private static void set_IsDuplicate(bool value) { }

	// RVA: 0x1EE3AB0 Offset: 0x1EE3BB1 VA: 0x1EE3AB0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1EE3AC0 Offset: 0x1EE3BC1 VA: 0x1EE3AC0
	public void .ctor() { }

	// RVA: 0x1EE3B30 Offset: 0x1EE3C31 VA: 0x1EE3B30
	private static void .cctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279100 Offset: 0x279201 VA: 0x279100
private sealed class VersusSequence.VersusYesNoDialog.YesItem.<>c__DisplayClass3_0 // TypeDefIndex: 13649
{
	// Fields
	public Action decideCallback; // 0x10
	public VersusSequence.VersusYesNoDialog.YesItem <>4__this; // 0x18
	public Action cancelCallback; // 0x20

	// Methods

	// RVA: 0x2D72A50 Offset: 0x2D72B51 VA: 0x2D72A50
	public void .ctor() { }

	// RVA: 0x2D7F090 Offset: 0x2D7F191 VA: 0x2D7F090
	internal BasicMenu.Result <.ctor>b__0() { }

	// RVA: 0x2D7F0D0 Offset: 0x2D7F1D1 VA: 0x2D7F0D0
	internal BasicMenu.Result <.ctor>b__1() { }
}

// Namespace: 
private class VersusSequence.VersusYesNoDialog.YesItem : BasicDialogItemYes // TypeDefIndex: 13650
{
	// Fields
	private readonly string m_Name; // 0x70
	private readonly Func<BasicMenu.Result> m_DecideCallback; // 0x78
	private readonly Func<BasicMenu.Result> m_CancelCallback; // 0x80

	// Methods

	// RVA: 0x2D728D0 Offset: 0x2D729D1 VA: 0x2D728D0
	public void .ctor(string name, Action decideCallback, Action cancelCallback) { }

	// RVA: 0x2D72A60 Offset: 0x2D72B61 VA: 0x2D72A60
	public void .ctor(string name, Func<BasicMenu.Result> decideCallback, Func<BasicMenu.Result> cancelCallback) { }

	// RVA: 0x2D72AD0 Offset: 0x2D72BD1 VA: 0x2D72AD0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D72B40 Offset: 0x2D72C41 VA: 0x2D72B40 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D72BB0 Offset: 0x2D72CB1 VA: 0x2D72BB0 Slot: 4
	public override string GetName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC630 Offset: 0x2CC731 VA: 0x2CC630
	[DebuggerHiddenAttribute] // RVA: 0x2CC630 Offset: 0x2CC731 VA: 0x2CC630
	// RVA: 0x2D72BF0 Offset: 0x2D72CF1 VA: 0x2D72BF0
	private BasicMenu.Result <>n__0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC670 Offset: 0x2CC771 VA: 0x2CC670
	[DebuggerHiddenAttribute] // RVA: 0x2CC670 Offset: 0x2CC771 VA: 0x2CC670
	// RVA: 0x2D72C00 Offset: 0x2D72D01 VA: 0x2D72C00
	private BasicMenu.Result <>n__1() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279110 Offset: 0x279211 VA: 0x279110
private sealed class VersusSequence.VersusYesNoDialog.NoItem.<>c__DisplayClass2_0 // TypeDefIndex: 13651
{
	// Fields
	public Action callback; // 0x10

	// Methods

	// RVA: 0x2D72750 Offset: 0x2D72851 VA: 0x2D72750
	public void .ctor() { }

	// RVA: 0x2D7F060 Offset: 0x2D7F161 VA: 0x2D7F060
	internal BasicMenu.Result <.ctor>b__0() { }
}

// Namespace: 
private class VersusSequence.VersusYesNoDialog.NoItem : BasicDialogItemNo // TypeDefIndex: 13652
{
	// Fields
	private readonly string m_Name; // 0x70
	private readonly Func<BasicMenu.Result> m_CancelCallback; // 0x78

	// Methods

	// RVA: 0x2D72640 Offset: 0x2D72741 VA: 0x2D72640
	public void .ctor(string name, Action callback) { }

	// RVA: 0x2D72760 Offset: 0x2D72861 VA: 0x2D72760
	public void .ctor(string name, Func<BasicMenu.Result> callback) { }

	// RVA: 0x2D727B0 Offset: 0x2D728B1 VA: 0x2D727B0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D72820 Offset: 0x2D72921 VA: 0x2D72820 Slot: 19
	public override BasicMenu.Result BCall() { }

	// RVA: 0x2D72890 Offset: 0x2D72991 VA: 0x2D72890 Slot: 4
	public override string GetName() { }
}

// Namespace: 
private class VersusSequence.VersusYesNoDialog : YesNoDialog // TypeDefIndex: 13653
{
	// Methods

	// RVA: 0x1DB8370 Offset: 0x1DB8471 VA: 0x1DB8370
	private void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent menuContent) { }

	// RVA: 0x1DB8380 Offset: 0x1DB8481 VA: 0x1DB8380
	public static VersusSequence.VersusYesNoDialog CreateBind(ProcInst super, string message, string yesName = "", string noName = "", Action decideCallback, Action cancelCallback) { }

	// RVA: 0x1DB85E0 Offset: 0x1DB86E1 VA: 0x1DB85E0
	public static VersusSequence.VersusYesNoDialog CreateBind(ProcInst super, string message, string yesName = "", string noName = "", Func<BasicMenu.Result> decideCallback, Func<BasicMenu.Result> cancelCallback) { }

	// RVA: 0x1DB8460 Offset: 0x1DB8561 VA: 0x1DB8460
	private static VersusSequence.VersusYesNoDialog CreateBindImpl(ProcInst super, string message, string yesName, string noName, VersusSequence.VersusYesNoDialog.YesItem yesItem, VersusSequence.VersusYesNoDialog.NoItem noItem) { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279120 Offset: 0x279221 VA: 0x279120
[Serializable]
private sealed class VersusSequence.VersusFriendMenu.FriendCasualMenuItem.<>c // TypeDefIndex: 13654
{
	// Fields
	public static readonly VersusSequence.VersusFriendMenu.FriendCasualMenuItem.<>c <>9; // 0x0
	public static Func<BasicMenu.Result> <>9__6_1; // 0x8

	// Methods

	// RVA: 0x2D7E1B0 Offset: 0x2D7E2B1 VA: 0x2D7E1B0
	private static void .cctor() { }

	// RVA: 0x2D7E220 Offset: 0x2D7E321 VA: 0x2D7E220
	public void .ctor() { }

	// RVA: 0x2D7E230 Offset: 0x2D7E331 VA: 0x2D7E230
	internal BasicMenu.Result <StartBattleDialog>b__6_1() { }
}

// Namespace: 
private class VersusSequence.VersusFriendMenu.FriendCasualMenuItem : BasicMenuItem // TypeDefIndex: 13655
{
	// Fields
	private VersusServerCasualMetaData m_MetaData; // 0x68
	private int m_FriendNumber; // 0x70
	private string m_Name; // 0x78

	// Methods

	// RVA: 0x2D6BF90 Offset: 0x2D6C091 VA: 0x2D6BF90
	public void .ctor(VersusServerCasualMetaData metaData, int num) { }

	// RVA: 0x2D6C0A0 Offset: 0x2D6C1A1 VA: 0x2D6C0A0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D6C2F0 Offset: 0x2D6C3F1 VA: 0x2D6C2F0 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2D6C0C0 Offset: 0x2D6C1C1 VA: 0x2D6C0C0
	private BasicMenu.Result StartBattleDialog() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC6B0 Offset: 0x2CC7B1 VA: 0x2CC6B0
	// RVA: 0x2D6C300 Offset: 0x2D6C401 VA: 0x2D6C300
	private BasicMenu.Result <StartBattleDialog>b__6_0() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279130 Offset: 0x279231 VA: 0x279130
[Serializable]
private sealed class VersusSequence.VersusFriendMenu.FriendRankedMenuItem.<>c // TypeDefIndex: 13656
{
	// Fields
	public static readonly VersusSequence.VersusFriendMenu.FriendRankedMenuItem.<>c <>9; // 0x0
	public static Func<BasicMenu.Result> <>9__6_1; // 0x8

	// Methods

	// RVA: 0x2D7E240 Offset: 0x2D7E341 VA: 0x2D7E240
	private static void .cctor() { }

	// RVA: 0x2D7E2B0 Offset: 0x2D7E3B1 VA: 0x2D7E2B0
	public void .ctor() { }

	// RVA: 0x2D7E2C0 Offset: 0x2D7E3C1 VA: 0x2D7E2C0
	internal BasicMenu.Result <StartBattleDialog>b__6_1() { }
}

// Namespace: 
private class VersusSequence.VersusFriendMenu.FriendRankedMenuItem : BasicMenuItem // TypeDefIndex: 13657
{
	// Fields
	private VersusServerRankedMetaData m_MetaData; // 0x68
	private int m_FriendNumber; // 0x70
	private string m_Name; // 0x78

	// Methods

	// RVA: 0x2D6C3D0 Offset: 0x2D6C4D1 VA: 0x2D6C3D0
	public void .ctor(VersusServerRankedMetaData metaData, int num) { }

	// RVA: 0x2D6C4E0 Offset: 0x2D6C5E1 VA: 0x2D6C4E0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D6C730 Offset: 0x2D6C831 VA: 0x2D6C730 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2D6C500 Offset: 0x2D6C601 VA: 0x2D6C500
	private BasicMenu.Result StartBattleDialog() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC6C0 Offset: 0x2CC7C1 VA: 0x2CC6C0
	// RVA: 0x2D6C740 Offset: 0x2D6C841 VA: 0x2D6C740
	private BasicMenu.Result <StartBattleDialog>b__6_0() { }
}

// Namespace: 
public class VersusSequence.VersusFriendMenu : BasicMenu // TypeDefIndex: 13658
{
	// Fields
	private const int c_FriendShowMax = 8;
	private static int m_InitialSelected; // 0x0

	// Methods

	// RVA: 0x1EE55D0 Offset: 0x1EE56D1 VA: 0x1EE55D0
	public static void InitializedSelected() { }

	// RVA: 0x1EE5640 Offset: 0x1EE5741 VA: 0x1EE5640
	public static void CreateBind(ProcInst super, List<VersusServerCasualMetaData> metaDataList) { }

	// RVA: 0x1EE5970 Offset: 0x1EE5A71 VA: 0x1EE5970
	public static void CreateBind(ProcInst super, List<VersusServerRankedMetaData> metaDataList) { }

	// RVA: 0x1EE5870 Offset: 0x1EE5971 VA: 0x1EE5870
	protected void .ctor(List<BasicMenuItem> menuItemList, VersusFriendMenuContent menuContent) { }

	// RVA: 0x1EE5BA0 Offset: 0x1EE5CA1 VA: 0x1EE5BA0 Slot: 30
	public override string GetName() { }

	// RVA: 0x1EE5BF0 Offset: 0x1EE5CF1 VA: 0x1EE5BF0 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x1EE5C10 Offset: 0x1EE5D11 VA: 0x1EE5C10
	private static void .cctor() { }
}

// Namespace: 
public enum VersusSequence.VersusMatchingMenu.Result2 // TypeDefIndex: 13659
{
	// Fields
	public int value__; // 0x0
	public const VersusSequence.VersusMatchingMenu.Result2 Random = 0;
	public const VersusSequence.VersusMatchingMenu.Result2 Friend = 1;
	public const VersusSequence.VersusMatchingMenu.Result2 Code = 2;
	public const VersusSequence.VersusMatchingMenu.Result2 Profile = 3;
	public const VersusSequence.VersusMatchingMenu.Result2 End = 4;
	public const VersusSequence.VersusMatchingMenu.Result2 Top = 0;
}

// Namespace: 
private class VersusSequence.VersusMatchingMenu.RandomMenuItem : BasicMenuItem // TypeDefIndex: 13660
{
	// Methods

	// RVA: 0x2D6D1D0 Offset: 0x2D6D2D1 VA: 0x2D6D1D0
	public void .ctor() { }

	// RVA: 0x2D6D270 Offset: 0x2D6D371 VA: 0x2D6D270 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D6D340 Offset: 0x2D6D441 VA: 0x2D6D340 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
private class VersusSequence.VersusMatchingMenu.FriendMenuItem : BasicMenuItem // TypeDefIndex: 13661
{
	// Methods

	// RVA: 0x2D6CB40 Offset: 0x2D6CC41 VA: 0x2D6CB40
	public void .ctor() { }

	// RVA: 0x2D6CBE0 Offset: 0x2D6CCE1 VA: 0x2D6CBE0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D6CCE0 Offset: 0x2D6CDE1 VA: 0x2D6CCE0 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
private class VersusSequence.VersusMatchingMenu.CodeMenuItem : BasicMenuItem // TypeDefIndex: 13662
{
	// Methods

	// RVA: 0x2D6C810 Offset: 0x2D6C911 VA: 0x2D6C810
	public void .ctor() { }

	// RVA: 0x2D6C8B0 Offset: 0x2D6C9B1 VA: 0x2D6C8B0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D6C980 Offset: 0x2D6CA81 VA: 0x2D6C980 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
private class VersusSequence.VersusMatchingMenu.ProfileMenuItem : BasicMenuItem // TypeDefIndex: 13663
{
	// Methods

	// RVA: 0x2D6CEA0 Offset: 0x2D6CFA1 VA: 0x2D6CEA0
	public void .ctor() { }

	// RVA: 0x2D6CF40 Offset: 0x2D6D041 VA: 0x2D6CF40 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D6D010 Offset: 0x2D6D111 VA: 0x2D6D010 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
public class VersusSequence.VersusMatchingMenu : BasicMenu // TypeDefIndex: 13664
{
	// Fields
	private static VersusTopMenuContent m_MenuContent; // 0x0
	private static int m_InitialSelected; // 0x8

	// Methods

	// RVA: 0x1EE5C20 Offset: 0x1EE5D21 VA: 0x1EE5C20
	public static void InitializedSelected() { }

	// RVA: 0x1EE5C90 Offset: 0x1EE5D91 VA: 0x1EE5C90
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1EE5E90 Offset: 0x1EE5F91 VA: 0x1EE5E90
	protected void .ctor(List<BasicMenuItem> menuItemList, VersusTopMenuContent menuContent) { }

	// RVA: 0x1EE5F90 Offset: 0x1EE6091 VA: 0x1EE5F90 Slot: 30
	public override string GetName() { }

	// RVA: 0x1EE5FE0 Offset: 0x1EE60E1 VA: 0x1EE5FE0 Slot: 63
	protected override string GetTutorial() { }

	// RVA: 0x1EE6060 Offset: 0x1EE6161 VA: 0x1EE6060 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x1EE6110 Offset: 0x1EE6211 VA: 0x1EE6110
	private static void .cctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279140 Offset: 0x279241 VA: 0x279140
[Serializable]
private sealed class VersusSequence.VersusProfileMenu.VersusProfileMenuItem.<>c // TypeDefIndex: 13665
{
	// Fields
	public static readonly VersusSequence.VersusProfileMenu.VersusProfileMenuItem.<>c <>9; // 0x0
	public static Func<BasicMenu.Result> <>9__9_1; // 0x8

	// Methods

	// RVA: 0x2D7E2D0 Offset: 0x2D7E3D1 VA: 0x2D7E2D0
	private static void .cctor() { }

	// RVA: 0x2D7E340 Offset: 0x2D7E441 VA: 0x2D7E340
	public void .ctor() { }

	// RVA: 0x2D7E350 Offset: 0x2D7E451 VA: 0x2D7E350
	internal BasicMenu.Result <OpenDialog>b__9_1() { }
}

// Namespace: 
private class VersusSequence.VersusProfileMenu.VersusProfileMenuItem : BasicMenuItem // TypeDefIndex: 13666
{
	// Fields
	private int m_Index; // 0x64
	private ProfileCard m_Profile; // 0x68
	private bool m_IsEnable; // 0x70
	private string m_Name; // 0x78
	private ulong m_PrincipalID; // 0x80

	// Methods

	// RVA: 0x2D6D500 Offset: 0x2D6D601 VA: 0x2D6D500
	public void .ctor(int index, ProfileCard profile, bool isEnable) { }

	// RVA: 0x2D6D590 Offset: 0x2D6D691 VA: 0x2D6D590 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D6D7F0 Offset: 0x2D6D8F1 VA: 0x2D6D7F0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }

	// RVA: 0x2D6D810 Offset: 0x2D6D911 VA: 0x2D6D810 Slot: 11
	public override void OnBuildMenuItemContent() { }

	// RVA: 0x2D6D5C0 Offset: 0x2D6D6C1 VA: 0x2D6D5C0
	private BasicMenu.Result OpenDialog() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC6D0 Offset: 0x2CC7D1 VA: 0x2CC6D0
	// RVA: 0x2D6D820 Offset: 0x2D6D921 VA: 0x2D6D820
	private BasicMenu.Result <OpenDialog>b__9_0() { }
}

// Namespace: 
public class VersusSequence.VersusProfileMenu : BasicMenu // TypeDefIndex: 13667
{
	// Fields
	private const int c_FriendShowMax = 8;
	private static int s_InitialSelected; // 0x0

	// Methods

	// RVA: 0x1EE6120 Offset: 0x1EE6221 VA: 0x1EE6120
	public static void InitializedSelected() { }

	// RVA: 0x1EE6190 Offset: 0x1EE6291 VA: 0x1EE6190
	public static void CreateBind(ProcInst super, NexVersus.TargetSlotList targetList) { }

	// RVA: 0x1EE6420 Offset: 0x1EE6521 VA: 0x1EE6420
	protected void .ctor(List<BasicMenuItem> menuItemList, VersusProfileMenuContent menuContent) { }

	// RVA: 0x1EE6520 Offset: 0x1EE6621 VA: 0x1EE6520 Slot: 30
	public override string GetName() { }

	// RVA: 0x1EE6570 Offset: 0x1EE6671 VA: 0x1EE6570 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x1EE6590 Offset: 0x1EE6691 VA: 0x1EE6590
	private static void .cctor() { }
}

// Namespace: 
public enum VersusSequence.VersusRankedMenu.Result2 // TypeDefIndex: 13668
{
	// Fields
	public int value__; // 0x0
	public const VersusSequence.VersusRankedMenu.Result2 Start = 0;
	public const VersusSequence.VersusRankedMenu.Result2 MapEdit = 1;
	public const VersusSequence.VersusRankedMenu.Result2 Result = 2;
	public const VersusSequence.VersusRankedMenu.Result2 MockBattle = 3;
	public const VersusSequence.VersusRankedMenu.Result2 End = 4;
	public const VersusSequence.VersusRankedMenu.Result2 Top = 0;
}

// Namespace: 
private class VersusSequence.VersusRankedMenu.StartMenuItem : BasicMenuItem // TypeDefIndex: 13669
{
	// Methods

	// RVA: 0x2D6E210 Offset: 0x2D6E311 VA: 0x2D6E210
	public void .ctor() { }

	// RVA: 0x2D6E2B0 Offset: 0x2D6E3B1 VA: 0x2D6E2B0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D6E3D0 Offset: 0x2D6E4D1 VA: 0x2D6E3D0 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2D6E4E0 Offset: 0x2D6E5E1 VA: 0x2D6E4E0 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }
}

// Namespace: 
private class VersusSequence.VersusRankedMenu.MapEditMenuItem : BasicMenuItem // TypeDefIndex: 13670
{
	// Methods

	// RVA: 0x2D6D930 Offset: 0x2D6DA31 VA: 0x2D6D930
	public void .ctor() { }

	// RVA: 0x2D6D9D0 Offset: 0x2D6DAD1 VA: 0x2D6D9D0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D6DAA0 Offset: 0x2D6DBA1 VA: 0x2D6DAA0 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
private class VersusSequence.VersusRankedMenu.ResultMenuItem : BasicMenuItem // TypeDefIndex: 13671
{
	// Methods

	// RVA: 0x2D6DEE0 Offset: 0x2D6DFE1 VA: 0x2D6DEE0
	public void .ctor() { }

	// RVA: 0x2D6DF80 Offset: 0x2D6E081 VA: 0x2D6DF80 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D6E070 Offset: 0x2D6E171 VA: 0x2D6E070 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2D6E180 Offset: 0x2D6E281 VA: 0x2D6E180 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }
}

// Namespace: 
private class VersusSequence.VersusRankedMenu.MockBattleMenuItem : BasicMenuItem // TypeDefIndex: 13672
{
	// Methods

	// RVA: 0x2D6DBB0 Offset: 0x2D6DCB1 VA: 0x2D6DBB0
	public void .ctor() { }

	// RVA: 0x2D6DC50 Offset: 0x2D6DD51 VA: 0x2D6DC50 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D6DD40 Offset: 0x2D6DE41 VA: 0x2D6DD40 Slot: 12
	public override void OnSelect() { }

	// RVA: 0x2D6DE50 Offset: 0x2D6DF51 VA: 0x2D6DE50 Slot: 8
	public override BasicMenuItem.Attribute BuildAttribute() { }
}

// Namespace: 
public class VersusSequence.VersusRankedMenu : BasicMenu // TypeDefIndex: 13673
{
	// Fields
	private static VersusTopMenuContent m_MenuContent; // 0x0
	private static int m_InitialSelected; // 0x8

	// Methods

	// RVA: 0x1EE65A0 Offset: 0x1EE66A1 VA: 0x1EE65A0
	public static void InitializedSelected() { }

	// RVA: 0x1EE6610 Offset: 0x1EE6711 VA: 0x1EE6610
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1EE6810 Offset: 0x1EE6911 VA: 0x1EE6810
	protected void .ctor(List<BasicMenuItem> menuItemList, VersusTopMenuContent menuContent) { }

	// RVA: 0x1EE6910 Offset: 0x1EE6A11 VA: 0x1EE6910 Slot: 30
	public override string GetName() { }

	// RVA: 0x1EE6960 Offset: 0x1EE6A61 VA: 0x1EE6960 Slot: 63
	protected override string GetTutorial() { }

	// RVA: 0x1EE6A40 Offset: 0x1EE6B41 VA: 0x1EE6A40 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x1EE6A60 Offset: 0x1EE6B61 VA: 0x1EE6A60
	private static void .cctor() { }
}

// Namespace: 
public enum VersusSequence.ResultDialog.SelectMenu // TypeDefIndex: 13674
{
	// Fields
	public int value__; // 0x0
	public const VersusSequence.ResultDialog.SelectMenu Replay = 0;
	public const VersusSequence.ResultDialog.SelectMenu Result = 1;
	public const VersusSequence.ResultDialog.SelectMenu Back = 2;
	public const VersusSequence.ResultDialog.SelectMenu End = 3;
}

// Namespace: 
public sealed class VersusSequence.ResultDialog.DecideEventHandler : MulticastDelegate // TypeDefIndex: 13675
{
	// Methods

	// RVA: 0x2D6BB60 Offset: 0x2D6BC61 VA: 0x2D6BB60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2D6B900 Offset: 0x2D6BA01 VA: 0x2D6B900 Slot: 13
	public virtual void Invoke(VersusSequence.ResultDialog.SelectMenu set) { }

	// RVA: 0x2D6BB80 Offset: 0x2D6BC81 VA: 0x2D6BB80 Slot: 14
	public virtual IAsyncResult BeginInvoke(VersusSequence.ResultDialog.SelectMenu set, AsyncCallback callback, object object) { }

	// RVA: 0x2D6BC10 Offset: 0x2D6BD11 VA: 0x2D6BC10 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class VersusSequence.ResultDialog.AssistItem : BasicDialogItem // TypeDefIndex: 13676
{
	// Fields
	private VersusSequence.ResultDialog.SelectMenu m_SelectId; // 0x70

	// Methods

	// RVA: 0x2D6B7D0 Offset: 0x2D6B8D1 VA: 0x2D6B7D0
	public void .ctor(VersusSequence.ResultDialog.SelectMenu selectId, string messege) { }

	// RVA: 0x2D6B800 Offset: 0x2D6B901 VA: 0x2D6B800 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
public class VersusSequence.ResultDialog : BasicDialog // TypeDefIndex: 13677
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29C8E0 Offset: 0x29C9E1 VA: 0x29C8E0
	private static VersusSequence.ResultDialog.DecideEventHandler <EventHandler>k__BackingField; // 0x0

	// Properties
	private static VersusSequence.ResultDialog.DecideEventHandler EventHandler { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CC6E0 Offset: 0x2CC7E1 VA: 0x2CC6E0
	// RVA: 0x1EE4C70 Offset: 0x1EE4D71 VA: 0x1EE4C70
	private static VersusSequence.ResultDialog.DecideEventHandler get_EventHandler() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC6F0 Offset: 0x2CC7F1 VA: 0x2CC6F0
	// RVA: 0x1EE4CE0 Offset: 0x1EE4DE1 VA: 0x1EE4CE0
	private static void set_EventHandler(VersusSequence.ResultDialog.DecideEventHandler value) { }

	// RVA: 0x1EE4D60 Offset: 0x1EE4E61 VA: 0x1EE4D60
	private void .ctor(List<BasicMenuItem> menuItemList, BasicDialogContent menuContent) { }

	// RVA: 0x1EE4DA0 Offset: 0x1EE4EA1 VA: 0x1EE4DA0
	public static VersusSequence.ResultDialog CreateBind(ProcInst super, VersusSequence.ResultDialog.DecideEventHandler eventHandler) { }

	// RVA: 0x1EE50F0 Offset: 0x1EE51F1 VA: 0x1EE50F0 Slot: 30
	public override string GetName() { }

	// RVA: 0x1EE5140 Offset: 0x1EE5241 VA: 0x1EE5140 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x1EE5160 Offset: 0x1EE5261 VA: 0x1EE5160
	private static void .cctor() { }
}

// Namespace: 
public enum VersusSequence.VersusTopMenu.Result2 // TypeDefIndex: 13678
{
	// Fields
	public int value__; // 0x0
	public const VersusSequence.VersusTopMenu.Result2 Casual = 0;
	public const VersusSequence.VersusTopMenu.Result2 Ranked = 1;
	public const VersusSequence.VersusTopMenu.Result2 End = 2;
	public const VersusSequence.VersusTopMenu.Result2 Top = 0;
}

// Namespace: 
private class VersusSequence.VersusTopMenu.CasualMenuItem : BasicMenuItem // TypeDefIndex: 13679
{
	// Methods

	// RVA: 0x2D72030 Offset: 0x2D72131 VA: 0x2D72030
	public void .ctor() { }

	// RVA: 0x2D720D0 Offset: 0x2D721D1 VA: 0x2D720D0 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D721D0 Offset: 0x2D722D1 VA: 0x2D721D0 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
private class VersusSequence.VersusTopMenu.RankedMenuItem : BasicMenuItem // TypeDefIndex: 13680
{
	// Methods

	// RVA: 0x2D722E0 Offset: 0x2D723E1 VA: 0x2D722E0
	public void .ctor() { }

	// RVA: 0x2D72380 Offset: 0x2D72481 VA: 0x2D72380 Slot: 18
	public override BasicMenu.Result ACall() { }

	// RVA: 0x2D72500 Offset: 0x2D72601 VA: 0x2D72500
	private bool IsValid() { }

	// RVA: 0x2D72530 Offset: 0x2D72631 VA: 0x2D72530 Slot: 12
	public override void OnSelect() { }
}

// Namespace: 
public class VersusSequence.VersusTopMenu : BasicMenu // TypeDefIndex: 13681
{
	// Fields
	private static VersusTopMenuContent m_MenuContent; // 0x0
	private static int m_InitialSelected; // 0x8

	// Methods

	// RVA: 0x1DB7FA0 Offset: 0x1DB80A1 VA: 0x1DB7FA0
	public static void InitializedSelected() { }

	// RVA: 0x1DB8010 Offset: 0x1DB8111 VA: 0x1DB8010
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1DB81A0 Offset: 0x1DB82A1 VA: 0x1DB81A0
	protected void .ctor(List<BasicMenuItem> menuItemList, VersusTopMenuContent menuContent) { }

	// RVA: 0x1DB82A0 Offset: 0x1DB83A1 VA: 0x1DB82A0 Slot: 30
	public override string GetName() { }

	// RVA: 0x1DB82F0 Offset: 0x1DB83F1 VA: 0x1DB82F0 Slot: 63
	protected override string GetTutorial() { }

	// RVA: 0x1DB8340 Offset: 0x1DB8441 VA: 0x1DB8340 Slot: 51
	protected override BasicMenu.Result BCall() { }

	// RVA: 0x1DB8360 Offset: 0x1DB8461 VA: 0x1DB8360
	private static void .cctor() { }
}

// Namespace: 
public class VersusSequence.ProfileUploadSequence : ProcInst // TypeDefIndex: 13682
{
	// Fields
	private ProfileCard m_Profile; // 0x70

	// Methods

	// RVA: 0x1EE47E0 Offset: 0x1EE48E1 VA: 0x1EE47E0
	private void .ctor() { }

	// RVA: 0x1EE4880 Offset: 0x1EE4981 VA: 0x1EE4880
	private void Sanitize() { }

	// RVA: 0x1EE4920 Offset: 0x1EE4A21 VA: 0x1EE4920
	private void Upload() { }

	// RVA: 0x1EE49B0 Offset: 0x1EE4AB1 VA: 0x1EE49B0
	public static void CreateBind(ProcInst super) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC700 Offset: 0x2CC801 VA: 0x2CC700
	// RVA: 0x1EE4BD0 Offset: 0x1EE4CD1 VA: 0x1EE4BD0
	private void <Sanitize>b__2_0(bool isOk) { }
}

// Namespace: 
private enum VersusSequence.ProfileDownloadSequence.Label // TypeDefIndex: 13683
{
	// Fields
	public int value__; // 0x0
	public const VersusSequence.ProfileDownloadSequence.Label Sanitize = 0;
	public const VersusSequence.ProfileDownloadSequence.Label Save = 1;
	public const VersusSequence.ProfileDownloadSequence.Label End = 2;
}

// Namespace: 
private class VersusSequence.ProfileDownloadSequence.DownloadYesNoDialog.YesItem : BasicDialogItemYes // TypeDefIndex: 13684
{
	// Fields
	private Action m_DecideCallback; // 0x70

	// Methods

	// RVA: 0x2D6B780 Offset: 0x2D6B881 VA: 0x2D6B780
	public void .ctor(Action decideCallback) { }

	// RVA: 0x2D7E170 Offset: 0x2D7E271 VA: 0x2D7E170 Slot: 18
	public override BasicMenu.Result ACall() { }
}

// Namespace: 
private class VersusSequence.ProfileDownloadSequence.DownloadYesNoDialog // TypeDefIndex: 13685
{
	// Methods

	// RVA: 0x2D6B6E0 Offset: 0x2D6B7E1 VA: 0x2D6B6E0
	public static void CreateBind(ProcInst super, string mess, Action decideCallback) { }

	// RVA: 0x2D6B7C0 Offset: 0x2D6B8C1 VA: 0x2D6B7C0
	public void .ctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279150 Offset: 0x279251 VA: 0x279150
private sealed class VersusSequence.ProfileDownloadSequence.<>c__DisplayClass7_0 // TypeDefIndex: 13686
{
	// Fields
	public ProfileCard data; // 0x10

	// Methods

	// RVA: 0x2D6B6B0 Offset: 0x2D6B7B1 VA: 0x2D6B6B0
	public void .ctor() { }

	// RVA: 0x2D6B6C0 Offset: 0x2D6B7C1 VA: 0x2D6B6C0
	internal void <Sanitize>b__0(bool isOk) { }
}

// Namespace: 
public class VersusSequence.ProfileDownloadSequence : ProcInst // TypeDefIndex: 13687
{
	// Fields
	private VersusServerReplayMetaData m_ReplayMetaData; // 0x70

	// Methods

	// RVA: 0x1EE3B40 Offset: 0x1EE3C41 VA: 0x1EE3B40
	private void .ctor(VersusServerReplayMetaData replayMetaData) { }

	// RVA: 0x1EE3B80 Offset: 0x1EE3C81 VA: 0x1EE3B80
	private bool TryGetOpponentInfo(out string name, out ulong principalID) { }

	// RVA: 0x1EE3C60 Offset: 0x1EE3D61 VA: 0x1EE3C60
	private void Download() { }

	// RVA: 0x1EE3D60 Offset: 0x1EE3E61 VA: 0x1EE3D60
	private void PostDownload() { }

	// RVA: 0x1EE3E40 Offset: 0x1EE3F41 VA: 0x1EE3E40
	private void Sanitize() { }

	// RVA: 0x1EE3F60 Offset: 0x1EE4061 VA: 0x1EE3F60
	private void OpenDialog() { }

	// RVA: 0x1EE4070 Offset: 0x1EE4171 VA: 0x1EE4070
	private void Save() { }

	// RVA: 0x1EE4210 Offset: 0x1EE4311 VA: 0x1EE4210
	public static void CreateBind(ProcInst super, VersusServerReplayMetaData replayMetaData) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC710 Offset: 0x2CC811 VA: 0x2CC710
	// RVA: 0x1EE4770 Offset: 0x1EE4871 VA: 0x1EE4770
	private void <OpenDialog>b__8_0() { }
}

// Namespace: 
private enum VersusSequence.Label // TypeDefIndex: 13688
{
	// Fields
	public int value__; // 0x0
	public const VersusSequence.Label Top = 0;
	public const VersusSequence.Label Casual = 1;
	public const VersusSequence.Label Ranked = 2;
	public const VersusSequence.Label Matching = 3;
	public const VersusSequence.Label MatchingStart = 4;
	public const VersusSequence.Label NetCasualRandom = 5;
	public const VersusSequence.Label NetCasualFriend = 6;
	public const VersusSequence.Label NetCasualFriendSelect = 7;
	public const VersusSequence.Label NetCasualDataCode = 8;
	public const VersusSequence.Label NetCasualProfile = 9;
	public const VersusSequence.Label NetCasualProfileSelect = 10;
	public const VersusSequence.Label NetCasualUpload = 11;
	public const VersusSequence.Label NetRanked = 12;
	public const VersusSequence.Label NetRankedRandom = 13;
	public const VersusSequence.Label NetRankedFriend = 14;
	public const VersusSequence.Label NetRankedFriendSelect = 15;
	public const VersusSequence.Label NetRankedDataCode = 16;
	public const VersusSequence.Label NetRankedProfile = 17;
	public const VersusSequence.Label MapEdit = 18;
	public const VersusSequence.Label Replay = 19;
	public const VersusSequence.Label Reward = 20;
	public const VersusSequence.Label MockBattle = 21;
	public const VersusSequence.Label NetDownloadCasual = 22;
	public const VersusSequence.Label NetDownloadRanked = 23;
	public const VersusSequence.Label MapSequence = 24;
	public const VersusSequence.Label FadeOutToTop = 25;
	public const VersusSequence.Label FadeOutToCasual = 26;
	public const VersusSequence.Label FadeOutToRanked = 27;
	public const VersusSequence.Label EndCasual = 28;
	public const VersusSequence.Label End = 29;
}

// Namespace: 
private interface VersusSequence.IVersusSequenceBase // TypeDefIndex: 13689
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void JumpTo(VersusSequence.Label label);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract ulong GetMyEditDataId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string GetNowRateName();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetProfileTarget(ProfileCard profile);
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279160 Offset: 0x279261 VA: 0x279160
private sealed class VersusSequence.VersusSequenceBase.<CopyEditDataFromServer>d__42<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13690
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public VersusSequence.VersusSequenceBase<T> <>4__this; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CCB60 Offset: 0x2CCC61 VA: 0x2CCB60
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4A3D0 Offset: 0x2B4A4D1 VA: 0x2B4A3D0
	|-VersusSequence.VersusSequenceBase.<CopyEditDataFromServer>d__42<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCB70 Offset: 0x2CCC71 VA: 0x2CCB70
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4A400 Offset: 0x2B4A501 VA: 0x2B4A400
	|-VersusSequence.VersusSequenceBase.<CopyEditDataFromServer>d__42<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4A410 Offset: 0x2B4A511 VA: 0x2B4A410
	|-VersusSequence.VersusSequenceBase.<CopyEditDataFromServer>d__42<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCB80 Offset: 0x2CCC81 VA: 0x2CCB80
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4A630 Offset: 0x2B4A731 VA: 0x2B4A630
	|-VersusSequence.VersusSequenceBase.<CopyEditDataFromServer>d__42<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCB90 Offset: 0x2CCC91 VA: 0x2CCB90
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4A640 Offset: 0x2B4A741 VA: 0x2B4A640
	|-VersusSequence.VersusSequenceBase.<CopyEditDataFromServer>d__42<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCBA0 Offset: 0x2CCCA1 VA: 0x2CCBA0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4A680 Offset: 0x2B4A781 VA: 0x2B4A680
	|-VersusSequence.VersusSequenceBase.<CopyEditDataFromServer>d__42<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279170 Offset: 0x279271 VA: 0x279170
private sealed class VersusSequence.VersusSequenceBase.<CheckOldEditData>d__44<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13691
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public VersusSequence.VersusSequenceBase<T> <>4__this; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CCBB0 Offset: 0x2CCCB1 VA: 0x2CCBB0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B462B0 Offset: 0x2B463B1 VA: 0x2B462B0
	|-VersusSequence.VersusSequenceBase.<CheckOldEditData>d__44<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCBC0 Offset: 0x2CCCC1 VA: 0x2CCBC0
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B462E0 Offset: 0x2B463E1 VA: 0x2B462E0
	|-VersusSequence.VersusSequenceBase.<CheckOldEditData>d__44<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B462F0 Offset: 0x2B463F1 VA: 0x2B462F0
	|-VersusSequence.VersusSequenceBase.<CheckOldEditData>d__44<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCBD0 Offset: 0x2CCCD1 VA: 0x2CCBD0
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46520 Offset: 0x2B46621 VA: 0x2B46520
	|-VersusSequence.VersusSequenceBase.<CheckOldEditData>d__44<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCBE0 Offset: 0x2CCCE1 VA: 0x2CCBE0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46530 Offset: 0x2B46631 VA: 0x2B46530
	|-VersusSequence.VersusSequenceBase.<CheckOldEditData>d__44<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCBF0 Offset: 0x2CCCF1 VA: 0x2CCBF0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46570 Offset: 0x2B46671 VA: 0x2B46570
	|-VersusSequence.VersusSequenceBase.<CheckOldEditData>d__44<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279180 Offset: 0x279281 VA: 0x279180
private sealed class VersusSequence.VersusSequenceBase.<GetMyCasualData>d__49<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13692
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public VersusSequence.VersusSequenceBase<T> <>4__this; // 0x0
	private Versus.DownloadHistory <history>5__2; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CCC00 Offset: 0x2CCD01 VA: 0x2CCC00
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150810 Offset: 0x3150911 VA: 0x3150810
	|-VersusSequence.VersusSequenceBase.<GetMyCasualData>d__49<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCC10 Offset: 0x2CCD11 VA: 0x2CCC10
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150840 Offset: 0x3150941 VA: 0x3150840
	|-VersusSequence.VersusSequenceBase.<GetMyCasualData>d__49<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150850 Offset: 0x3150951 VA: 0x3150850
	|-VersusSequence.VersusSequenceBase.<GetMyCasualData>d__49<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCC20 Offset: 0x2CCD21 VA: 0x2CCC20
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150A00 Offset: 0x3150B01 VA: 0x3150A00
	|-VersusSequence.VersusSequenceBase.<GetMyCasualData>d__49<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCC30 Offset: 0x2CCD31 VA: 0x2CCC30
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150A10 Offset: 0x3150B11 VA: 0x3150A10
	|-VersusSequence.VersusSequenceBase.<GetMyCasualData>d__49<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCC40 Offset: 0x2CCD41 VA: 0x2CCC40
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150A50 Offset: 0x3150B51 VA: 0x3150A50
	|-VersusSequence.VersusSequenceBase.<GetMyCasualData>d__49<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279190 Offset: 0x279291 VA: 0x279190
private sealed class VersusSequence.VersusSequenceBase.<CheckParentalControl>d__52<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13693
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public VersusSequence.VersusSequenceBase<T> <>4__this; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CCC50 Offset: 0x2CCD51 VA: 0x2CCC50
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46580 Offset: 0x2B46681 VA: 0x2B46580
	|-VersusSequence.VersusSequenceBase.<CheckParentalControl>d__52<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCC60 Offset: 0x2CCD61 VA: 0x2CCC60
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B465B0 Offset: 0x2B466B1 VA: 0x2B465B0
	|-VersusSequence.VersusSequenceBase.<CheckParentalControl>d__52<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B465C0 Offset: 0x2B466C1 VA: 0x2B465C0
	|-VersusSequence.VersusSequenceBase.<CheckParentalControl>d__52<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCC70 Offset: 0x2CCD71 VA: 0x2CCC70
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B466B0 Offset: 0x2B467B1 VA: 0x2B466B0
	|-VersusSequence.VersusSequenceBase.<CheckParentalControl>d__52<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCC80 Offset: 0x2CCD81 VA: 0x2CCC80
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B466C0 Offset: 0x2B467C1 VA: 0x2B466C0
	|-VersusSequence.VersusSequenceBase.<CheckParentalControl>d__52<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCC90 Offset: 0x2CCD91 VA: 0x2CCC90
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B46700 Offset: 0x2B46801 VA: 0x2B46700
	|-VersusSequence.VersusSequenceBase.<CheckParentalControl>d__52<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2791A0 Offset: 0x2792A1 VA: 0x2791A0
private sealed class VersusSequence.VersusSequenceBase.<GetMyEditData>d__53<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13694
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public VersusSequence.VersusSequenceBase<T> <>4__this; // 0x0
	private Versus.DownloadHistory <history>5__2; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CCCA0 Offset: 0x2CCDA1 VA: 0x2CCCA0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150A60 Offset: 0x3150B61 VA: 0x3150A60
	|-VersusSequence.VersusSequenceBase.<GetMyEditData>d__53<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCCB0 Offset: 0x2CCDB1 VA: 0x2CCCB0
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150A90 Offset: 0x3150B91 VA: 0x3150A90
	|-VersusSequence.VersusSequenceBase.<GetMyEditData>d__53<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150AA0 Offset: 0x3150BA1 VA: 0x3150AA0
	|-VersusSequence.VersusSequenceBase.<GetMyEditData>d__53<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCCC0 Offset: 0x2CCDC1 VA: 0x2CCCC0
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150E10 Offset: 0x3150F11 VA: 0x3150E10
	|-VersusSequence.VersusSequenceBase.<GetMyEditData>d__53<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCCD0 Offset: 0x2CCDD1 VA: 0x2CCCD0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150E20 Offset: 0x3150F21 VA: 0x3150E20
	|-VersusSequence.VersusSequenceBase.<GetMyEditData>d__53<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCCE0 Offset: 0x2CCDE1 VA: 0x2CCCE0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x3150E60 Offset: 0x3150F61 VA: 0x3150E60
	|-VersusSequence.VersusSequenceBase.<GetMyEditData>d__53<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2791B0 Offset: 0x2792B1 VA: 0x2791B0
private sealed class VersusSequence.VersusSequenceBase.<>c__DisplayClass74_0<T> // TypeDefIndex: 13695
{
	// Fields
	public VersusSequence.VersusSequenceBase<T> <>4__this; // 0x0
	public string code; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3FF20 Offset: 0x2B40021 VA: 0x2B3FF20
	|-VersusSequence.VersusSequenceBase.<>c__DisplayClass74_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <SearchDataCode>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3FF30 Offset: 0x2B40031 VA: 0x2B3FF30
	|-VersusSequence.VersusSequenceBase.<>c__DisplayClass74_0<object>.<SearchDataCode>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <SearchDataCode>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B3FF40 Offset: 0x2B40041 VA: 0x2B3FF40
	|-VersusSequence.VersusSequenceBase.<>c__DisplayClass74_0<object>.<SearchDataCode>b__1
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2791C0 Offset: 0x2792C1 VA: 0x2791C0
[Serializable]
private sealed class VersusSequence.VersusSequenceBase.<>c<T> // TypeDefIndex: 13696
{
	// Fields
	public static readonly VersusSequence.VersusSequenceBase.<>c<T> <>9; // 0x0
	public static VersusSequence.ResultDialog.DecideEventHandler <>9__99_0; // 0x0
	public static Comparison<Friend> <>9__147_0; // 0x0
	public static ProcBoolMethod <>9__152_0; // 0x0
	public static ProcBoolMethod <>9__152_1; // 0x0
	public static ProcBoolMethod <>9__152_2; // 0x0
	public static ProcBoolMethod <>9__152_3; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B33F40 Offset: 0x2B34041 VA: 0x2B33F40
	|-VersusSequence.VersusSequenceBase.<>c<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B34020 Offset: 0x2B34121 VA: 0x2B34020
	|-VersusSequence.VersusSequenceBase.<>c<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <OpenReplayDialog>b__99_0(VersusSequence.ResultDialog.SelectMenu r) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B34030 Offset: 0x2B34131 VA: 0x2B34030
	|-VersusSequence.VersusSequenceBase.<>c<object>.<OpenReplayDialog>b__99_0
	*/

	// RVA: -1 Offset: -1
	internal int <GetFriendList>b__147_0(Friend x, Friend y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B34060 Offset: 0x2B34161 VA: 0x2B34060
	|-VersusSequence.VersusSequenceBase.<>c<object>.<GetFriendList>b__147_0
	*/

	// RVA: -1 Offset: -1
	internal bool <CreateBind>b__152_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B34180 Offset: 0x2B34281 VA: 0x2B34180
	|-VersusSequence.VersusSequenceBase.<>c<object>.<CreateBind>b__152_0
	*/

	// RVA: -1 Offset: -1
	internal bool <CreateBind>b__152_1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B341F0 Offset: 0x2B342F1 VA: 0x2B341F0
	|-VersusSequence.VersusSequenceBase.<>c<object>.<CreateBind>b__152_1
	*/

	// RVA: -1 Offset: -1
	internal bool <CreateBind>b__152_2() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B34260 Offset: 0x2B34361 VA: 0x2B34260
	|-VersusSequence.VersusSequenceBase.<>c<object>.<CreateBind>b__152_2
	*/

	// RVA: -1 Offset: -1
	internal bool <CreateBind>b__152_3() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B342D0 Offset: 0x2B343D1 VA: 0x2B342D0
	|-VersusSequence.VersusSequenceBase.<>c<object>.<CreateBind>b__152_3
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2791D0 Offset: 0x2792D1 VA: 0x2791D0
private sealed class VersusSequence.VersusSequenceBase.<DownloadRanked>d__112<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13697
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public VersusSequence.VersusSequenceBase<T> <>4__this; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CCCF0 Offset: 0x2CCDF1 VA: 0x2CCCF0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B6B0 Offset: 0x2B4B7B1 VA: 0x2B4B6B0
	|-VersusSequence.VersusSequenceBase.<DownloadRanked>d__112<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCD00 Offset: 0x2CCE01 VA: 0x2CCD00
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B6E0 Offset: 0x2B4B7E1 VA: 0x2B4B6E0
	|-VersusSequence.VersusSequenceBase.<DownloadRanked>d__112<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B6F0 Offset: 0x2B4B7F1 VA: 0x2B4B6F0
	|-VersusSequence.VersusSequenceBase.<DownloadRanked>d__112<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCD10 Offset: 0x2CCE11 VA: 0x2CCD10
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B8E0 Offset: 0x2B4B9E1 VA: 0x2B4B8E0
	|-VersusSequence.VersusSequenceBase.<DownloadRanked>d__112<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCD20 Offset: 0x2CCE21 VA: 0x2CCD20
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B8F0 Offset: 0x2B4B9F1 VA: 0x2B4B8F0
	|-VersusSequence.VersusSequenceBase.<DownloadRanked>d__112<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCD30 Offset: 0x2CCE31 VA: 0x2CCD30
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B930 Offset: 0x2B4BA31 VA: 0x2B4B930
	|-VersusSequence.VersusSequenceBase.<DownloadRanked>d__112<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2791E0 Offset: 0x2792E1 VA: 0x2791E0
private sealed class VersusSequence.VersusSequenceBase.<DownloadMyEditData>d__114<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13698
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public VersusSequence.VersusSequenceBase<T> <>4__this; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CCD40 Offset: 0x2CCE41 VA: 0x2CCD40
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B1C0 Offset: 0x2B4B2C1 VA: 0x2B4B1C0
	|-VersusSequence.VersusSequenceBase.<DownloadMyEditData>d__114<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCD50 Offset: 0x2CCE51 VA: 0x2CCD50
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B1F0 Offset: 0x2B4B2F1 VA: 0x2B4B1F0
	|-VersusSequence.VersusSequenceBase.<DownloadMyEditData>d__114<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B200 Offset: 0x2B4B301 VA: 0x2B4B200
	|-VersusSequence.VersusSequenceBase.<DownloadMyEditData>d__114<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCD60 Offset: 0x2CCE61 VA: 0x2CCD60
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B3B0 Offset: 0x2B4B4B1 VA: 0x2B4B3B0
	|-VersusSequence.VersusSequenceBase.<DownloadMyEditData>d__114<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCD70 Offset: 0x2CCE71 VA: 0x2CCD70
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B3C0 Offset: 0x2B4B4C1 VA: 0x2B4B3C0
	|-VersusSequence.VersusSequenceBase.<DownloadMyEditData>d__114<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCD80 Offset: 0x2CCE81 VA: 0x2CCD80
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B400 Offset: 0x2B4B501 VA: 0x2B4B400
	|-VersusSequence.VersusSequenceBase.<DownloadMyEditData>d__114<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x2791F0 Offset: 0x2792F1 VA: 0x2791F0
private sealed class VersusSequence.VersusSequenceBase.<DownloadMyEditForEditMode>d__116<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13699
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public VersusSequence.VersusSequenceBase<T> <>4__this; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CCD90 Offset: 0x2CCE91 VA: 0x2CCD90
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B410 Offset: 0x2B4B511 VA: 0x2B4B410
	|-VersusSequence.VersusSequenceBase.<DownloadMyEditForEditMode>d__116<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCDA0 Offset: 0x2CCEA1 VA: 0x2CCDA0
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B440 Offset: 0x2B4B541 VA: 0x2B4B440
	|-VersusSequence.VersusSequenceBase.<DownloadMyEditForEditMode>d__116<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B450 Offset: 0x2B4B551 VA: 0x2B4B450
	|-VersusSequence.VersusSequenceBase.<DownloadMyEditForEditMode>d__116<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCDB0 Offset: 0x2CCEB1 VA: 0x2CCDB0
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B650 Offset: 0x2B4B751 VA: 0x2B4B650
	|-VersusSequence.VersusSequenceBase.<DownloadMyEditForEditMode>d__116<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCDC0 Offset: 0x2CCEC1 VA: 0x2CCDC0
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B660 Offset: 0x2B4B761 VA: 0x2B4B660
	|-VersusSequence.VersusSequenceBase.<DownloadMyEditForEditMode>d__116<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCDD0 Offset: 0x2CCED1 VA: 0x2CCDD0
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B4B6A0 Offset: 0x2B4B7A1 VA: 0x2B4B6A0
	|-VersusSequence.VersusSequenceBase.<DownloadMyEditForEditMode>d__116<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279200 Offset: 0x279301 VA: 0x279200
private sealed class VersusSequence.VersusSequenceBase.<CalculateRate>d__127<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13700
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public VersusSequence.VersusSequenceBase<T> <>4__this; // 0x0
	private VersusServerRankedMetaData <playerMeta>5__2; // 0x0
	private VersusServerRankedMetaData <opponentMeta>5__3; // 0x0
	private int <oldPlayerRate>5__4; // 0x0
	private int <oldOpponentRate>5__5; // 0x0
	private int <newPlayerRate>5__6; // 0x0
	private int <newOpponentRate>5__7; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CCDE0 Offset: 0x2CCEE1 VA: 0x2CCDE0
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45980 Offset: 0x2B45A81 VA: 0x2B45980
	|-VersusSequence.VersusSequenceBase.<CalculateRate>d__127<object>..ctor
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCDF0 Offset: 0x2CCEF1 VA: 0x2CCDF0
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B459B0 Offset: 0x2B45AB1 VA: 0x2B459B0
	|-VersusSequence.VersusSequenceBase.<CalculateRate>d__127<object>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B459C0 Offset: 0x2B45AC1 VA: 0x2B459C0
	|-VersusSequence.VersusSequenceBase.<CalculateRate>d__127<object>.MoveNext
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCE00 Offset: 0x2CCF01 VA: 0x2CCE00
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45D40 Offset: 0x2B45E41 VA: 0x2B45D40
	|-VersusSequence.VersusSequenceBase.<CalculateRate>d__127<object>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCE10 Offset: 0x2CCF11 VA: 0x2CCE10
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45D50 Offset: 0x2B45E51 VA: 0x2B45D50
	|-VersusSequence.VersusSequenceBase.<CalculateRate>d__127<object>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHiddenAttribute] // RVA: 0x2CCE20 Offset: 0x2CCF21 VA: 0x2CCE20
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2B45D90 Offset: 0x2B45E91 VA: 0x2B45D90
	|-VersusSequence.VersusSequenceBase.<CalculateRate>d__127<object>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
private abstract class VersusSequence.VersusSequenceBase<T> : SingletonProcInst<T>, VersusSequence.IVersusSequenceBase // TypeDefIndex: 13701
{
	// Fields
	protected bool m_IsStartedCasual; // 0x0
	protected List<VersusServerCasualMetaData> m_SearchCasualResults; // 0x0
	protected List<VersusServerCasualMetaData> m_SearchFriendCasualResults; // 0x0
	protected NexVersus.TargetSlotList m_ProfileCasualResults; // 0x0
	protected bool m_IsStartedRanked; // 0x0
	protected List<VersusServerRankedMetaData> m_SearchRankedResults; // 0x0
	protected List<VersusServerRankedMetaData> m_SearchFriendRankedResults; // 0x0
	protected NexVersus.TargetSlotList m_ProfileRankedResults; // 0x0
	protected ulong m_MyEditDataId; // 0x0
	protected bool m_IsReported; // 0x0
	protected bool m_IsShowReportedWindow; // 0x0
	protected static ushort s_RateDataType; // 0x0
	protected static string m_MyCasualDataCode; // 0x0
	protected VersusServerReplayMetaData m_SelectedReplayMetaData; // 0x0
	private Versus.MapResult m_ReplayResult; // 0x0
	private MenuBg m_Bg; // 0x0
	private VersusMyInfoContent m_MyInfo; // 0x0
	private bool m_IsInitialized; // 0x0
	protected string m_TargetDataCode; // 0x0
	protected ProfileCard m_ProfileTarget; // 0x0
	public const int MaxGettableFriendCount = 100;

	// Properties
	protected static string RateDataTypeName { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected static string get_RateDataTypeName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC85A0 Offset: 0x2FC86A1 VA: 0x2FC85A0
	|-VersusSequence.VersusSequenceBase<object>.get_RateDataTypeName
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override void OnCreate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8730 Offset: 0x2FC8831 VA: 0x2FC8730
	|-VersusSequence.VersusSequenceBase<object>.OnCreate
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceLocal>.OnCreate
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceNet>.OnCreate
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void OnDispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC87C0 Offset: 0x2FC88C1 VA: 0x2FC87C0
	|-VersusSequence.VersusSequenceBase<object>.OnDispose
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceLocal>.OnDispose
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceNet>.OnDispose
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void JumpTo(VersusSequence.Label label) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC87D0 Offset: 0x2FC88D1 VA: 0x2FC87D0
	|-VersusSequence.VersusSequenceBase<object>.JumpTo
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceLocal>.JumpTo
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceNet>.JumpTo
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public ulong GetMyEditDataId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8850 Offset: 0x2FC8951 VA: 0x2FC8850
	|-VersusSequence.VersusSequenceBase<object>.GetMyEditDataId
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceLocal>.GetMyEditDataId
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceNet>.GetMyEditDataId
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public void SetProfileTarget(ProfileCard profile) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8860 Offset: 0x2FC8961 VA: 0x2FC8860
	|-VersusSequence.VersusSequenceBase<object>.SetProfileTarget
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceLocal>.SetProfileTarget
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceNet>.SetProfileTarget
	*/

	// RVA: -1 Offset: -1
	private bool GetReported() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8870 Offset: 0x2FC8971 VA: 0x2FC8870
	|-VersusSequence.VersusSequenceBase<object>.GetReported
	*/

	// RVA: -1 Offset: -1
	private void LoadResources() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8880 Offset: 0x2FC8981 VA: 0x2FC8880
	|-VersusSequence.VersusSequenceBase<object>.LoadResources
	*/

	// RVA: -1 Offset: -1
	private bool IsLoadingResources() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC88C0 Offset: 0x2FC89C1 VA: 0x2FC88C0
	|-VersusSequence.VersusSequenceBase<object>.IsLoadingResources
	*/

	// RVA: -1 Offset: -1
	private void MenuInitialized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8920 Offset: 0x2FC8A21 VA: 0x2FC8920
	|-VersusSequence.VersusSequenceBase<object>.MenuInitialized
	*/

	// RVA: -1 Offset: -1
	private void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8A30 Offset: 0x2FC8B31 VA: 0x2FC8A30
	|-VersusSequence.VersusSequenceBase<object>.Init
	*/

	// RVA: -1 Offset: -1 Slot: 26
	protected abstract void InitImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.InitImpl
	*/

	// RVA: -1 Offset: -1
	private void Final() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8A40 Offset: 0x2FC8B41 VA: 0x2FC8A40
	|-VersusSequence.VersusSequenceBase<object>.Final
	*/

	// RVA: -1 Offset: -1 Slot: 27
	protected abstract void FinalImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.FinalImpl
	*/

	// RVA: -1 Offset: -1 Slot: 28
	protected abstract bool IsFailedJumpToTopImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.IsFailedJumpToTopImpl
	*/

	// RVA: -1 Offset: -1 Slot: 29
	protected abstract bool IsReportedEditMapImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.IsReportedEditMapImpl
	*/

	// RVA: -1 Offset: -1 Slot: 30
	protected abstract void UploadReportDataImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.UploadReportDataImpl
	*/

	// RVA: -1 Offset: -1
	private void StartSequence() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8AD0 Offset: 0x2FC8BD1 VA: 0x2FC8AD0
	|-VersusSequence.VersusSequenceBase<object>.StartSequence
	*/

	// RVA: -1 Offset: -1
	private void EndSequence() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8BD0 Offset: 0x2FC8CD1 VA: 0x2FC8BD0
	|-VersusSequence.VersusSequenceBase<object>.EndSequence
	*/

	// RVA: -1 Offset: -1
	private void OpenTopMenu() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8D90 Offset: 0x2FC8E91 VA: 0x2FC8D90
	|-VersusSequence.VersusSequenceBase<object>.OpenTopMenu
	*/

	// RVA: -1 Offset: -1
	private void OpenCasualMenu() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC8F20 Offset: 0x2FC9021 VA: 0x2FC8F20
	|-VersusSequence.VersusSequenceBase<object>.OpenCasualMenu
	*/

	[IteratorStateMachineAttribute] // RVA: 0x2CC720 Offset: 0x2CC821 VA: 0x2CC720
	// RVA: -1 Offset: -1
	private IEnumerator CopyEditDataFromServer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC9200 Offset: 0x2FC9301 VA: 0x2FC9200
	|-VersusSequence.VersusSequenceBase<object>.CopyEditDataFromServer
	*/

	// RVA: -1 Offset: -1
	private void OpenRankedMenu() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC9280 Offset: 0x2FC9381 VA: 0x2FC9280
	|-VersusSequence.VersusSequenceBase<object>.OpenRankedMenu
	*/

	[IteratorStateMachineAttribute] // RVA: 0x2CC790 Offset: 0x2CC891 VA: 0x2CC790
	// RVA: -1 Offset: -1
	private IEnumerator CheckOldEditData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC9510 Offset: 0x2FC9611 VA: 0x2FC9510
	|-VersusSequence.VersusSequenceBase<object>.CheckOldEditData
	*/

	// RVA: -1 Offset: -1
	private void OpenMatchingMenu() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC9590 Offset: 0x2FC9691 VA: 0x2FC9590
	|-VersusSequence.VersusSequenceBase<object>.OpenMatchingMenu
	*/

	// RVA: -1 Offset: -1
	private void BranchMatching() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC9720 Offset: 0x2FC9821 VA: 0x2FC9720
	|-VersusSequence.VersusSequenceBase<object>.BranchMatching
	*/

	// RVA: -1 Offset: -1
	private void CloseTitleBarAndBg() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC9890 Offset: 0x2FC9991 VA: 0x2FC9890
	|-VersusSequence.VersusSequenceBase<object>.CloseTitleBarAndBg
	*/

	// RVA: -1 Offset: -1
	private void ResetCheckData(Versus.CheckDataType checkDataType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC99B0 Offset: 0x2FC9AB1 VA: 0x2FC99B0
	|-VersusSequence.VersusSequenceBase<object>.ResetCheckData
	*/

	[IteratorStateMachineAttribute] // RVA: 0x2CC800 Offset: 0x2CC901 VA: 0x2CC800
	// RVA: -1 Offset: -1
	private IEnumerator GetMyCasualData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC9A60 Offset: 0x2FC9B61 VA: 0x2FC9A60
	|-VersusSequence.VersusSequenceBase<object>.GetMyCasualData
	*/

	// RVA: -1 Offset: -1 Slot: 31
	protected abstract void GetMyCasualMetaDataImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.GetMyCasualMetaDataImpl
	*/

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract void PostGetMyCasualMetaDataImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.PostGetMyCasualMetaDataImpl
	*/

	[IteratorStateMachineAttribute] // RVA: 0x2CC870 Offset: 0x2CC971 VA: 0x2CC870
	// RVA: -1 Offset: -1
	private IEnumerator CheckParentalControl() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC9AE0 Offset: 0x2FC9BE1 VA: 0x2FC9AE0
	|-VersusSequence.VersusSequenceBase<object>.CheckParentalControl
	*/

	[IteratorStateMachineAttribute] // RVA: 0x2CC8E0 Offset: 0x2CC9E1 VA: 0x2CC8E0
	// RVA: -1 Offset: -1
	private IEnumerator GetMyEditData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC9B60 Offset: 0x2FC9C61 VA: 0x2FC9B60
	|-VersusSequence.VersusSequenceBase<object>.GetMyEditData
	*/

	// RVA: -1 Offset: -1 Slot: 33
	protected abstract void GetEditMetaDataImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.GetEditMetaDataImpl
	*/

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract void PostGetEditMetaDataImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.PostGetEditMetaDataImpl
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected abstract void UpdateRateImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.UpdateRateImpl
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract void SetRankedInfoImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.SetRankedInfoImpl
	*/

	// RVA: -1 Offset: -1
	private void SearchSameRate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC9BE0 Offset: 0x2FC9CE1 VA: 0x2FC9BE0
	|-VersusSequence.VersusSequenceBase<object>.SearchSameRate
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected abstract void SearchSameRateImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.SearchSameRateImpl
	*/

	// RVA: -1 Offset: -1
	private void SearchRankedFriend() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC9CB0 Offset: 0x2FC9DB1 VA: 0x2FC9CB0
	|-VersusSequence.VersusSequenceBase<object>.SearchRankedFriend
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected abstract void SearchRankedFriendImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.SearchRankedFriendImpl
	*/

	// RVA: -1 Offset: -1
	private void PostSearchRankedFriend() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC9E20 Offset: 0x2FC9F21 VA: 0x2FC9E20
	|-VersusSequence.VersusSequenceBase<object>.PostSearchRankedFriend
	*/

	// RVA: -1 Offset: -1
	private void PostSearchSameRate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FC9EA0 Offset: 0x2FC9FA1 VA: 0x2FC9EA0
	|-VersusSequence.VersusSequenceBase<object>.PostSearchSameRate
	*/

	// RVA: -1 Offset: -1 Slot: 39
	protected abstract void ExcludeMySearchRankedData();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.ExcludeMySearchRankedData
	*/

	// RVA: -1 Offset: -1
	private void SearchCasual() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCA210 Offset: 0x2FCA311 VA: 0x2FCA210
	|-VersusSequence.VersusSequenceBase<object>.SearchCasual
	*/

	// RVA: -1 Offset: -1 Slot: 40
	protected abstract void SearchCasualImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.SearchCasualImpl
	*/

	// RVA: -1 Offset: -1
	private void SearchCasualFriend() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCA2E0 Offset: 0x2FCA3E1 VA: 0x2FCA2E0
	|-VersusSequence.VersusSequenceBase<object>.SearchCasualFriend
	*/

	// RVA: -1 Offset: -1 Slot: 41
	protected abstract void SearchCasualFriendImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.SearchCasualFriendImpl
	*/

	// RVA: -1 Offset: -1
	private void PostSearchCasual() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCA450 Offset: 0x2FCA551 VA: 0x2FCA450
	|-VersusSequence.VersusSequenceBase<object>.PostSearchCasual
	*/

	// RVA: -1 Offset: -1 Slot: 42
	protected abstract void ExcludeMySearchCasualData(List<VersusServerCasualMetaData> dataList);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.ExcludeMySearchCasualData
	*/

	// RVA: -1 Offset: -1
	private void PostSearchCasualFriend() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCA750 Offset: 0x2FCA851 VA: 0x2FCA750
	|-VersusSequence.VersusSequenceBase<object>.PostSearchCasualFriend
	*/

	// RVA: -1 Offset: -1
	private void SelectFriendCasual() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCA8C0 Offset: 0x2FCA9C1 VA: 0x2FCA8C0
	|-VersusSequence.VersusSequenceBase<object>.SelectFriendCasual
	*/

	// RVA: -1 Offset: -1
	private void InputDataCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCAAC0 Offset: 0x2FCABC1 VA: 0x2FCAAC0
	|-VersusSequence.VersusSequenceBase<object>.InputDataCode
	*/

	// RVA: -1 Offset: -1
	private void SearchDataCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCAC30 Offset: 0x2FCAD31 VA: 0x2FCAC30
	|-VersusSequence.VersusSequenceBase<object>.SearchDataCode
	*/

	// RVA: -1 Offset: -1
	private void DownloadMetaCasualFromDataCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCB0F0 Offset: 0x2FCB1F1 VA: 0x2FCB0F0
	|-VersusSequence.VersusSequenceBase<object>.DownloadMetaCasualFromDataCode
	*/

	// RVA: -1 Offset: -1 Slot: 43
	protected abstract void DownloadMetaCasualFromDataCodeImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.DownloadMetaCasualFromDataCodeImpl
	*/

	// RVA: -1 Offset: -1
	private void DownloadMetaRankedFromDataCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCB100 Offset: 0x2FCB201 VA: 0x2FCB100
	|-VersusSequence.VersusSequenceBase<object>.DownloadMetaRankedFromDataCode
	*/

	// RVA: -1 Offset: -1 Slot: 44
	protected abstract void DownloadMetaRankedFromDataCodeImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.DownloadMetaRankedFromDataCodeImpl
	*/

	// RVA: -1 Offset: -1
	private void SelectFriendRanked() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCB150 Offset: 0x2FCB251 VA: 0x2FCB150
	|-VersusSequence.VersusSequenceBase<object>.SelectFriendRanked
	*/

	// RVA: -1 Offset: -1
	private void StartBattleDialogCasualDataCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCB390 Offset: 0x2FCB491 VA: 0x2FCB390
	|-VersusSequence.VersusSequenceBase<object>.StartBattleDialogCasualDataCode
	*/

	// RVA: -1 Offset: -1
	private void StartBattleDialogRankedDataCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCB670 Offset: 0x2FCB771 VA: 0x2FCB670
	|-VersusSequence.VersusSequenceBase<object>.StartBattleDialogRankedDataCode
	*/

	// RVA: -1 Offset: -1
	private void CheckProfileCasual() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCB950 Offset: 0x2FCBA51 VA: 0x2FCB950
	|-VersusSequence.VersusSequenceBase<object>.CheckProfileCasual
	*/

	// RVA: -1 Offset: -1 Slot: 45
	protected abstract void CheckAccessibleProfileImpl(Versus.Mode mode, NexVersus.TargetSlotList targetSlotList);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.CheckAccessibleProfileImpl
	*/

	// RVA: -1 Offset: -1
	private void SelectProfileCasual() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCBC20 Offset: 0x2FCBD21 VA: 0x2FCBC20
	|-VersusSequence.VersusSequenceBase<object>.SelectProfileCasual
	*/

	// RVA: -1 Offset: -1
	private void DownloadMetaCasualProfile() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCBD10 Offset: 0x2FCBE11 VA: 0x2FCBD10
	|-VersusSequence.VersusSequenceBase<object>.DownloadMetaCasualProfile
	*/

	// RVA: -1 Offset: -1 Slot: 46
	protected abstract void DownloadMetaProfileImpl(Versus.Mode mode, ProfileCard profile);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.DownloadMetaProfileImpl
	*/

	// RVA: -1 Offset: -1
	private void CheckProfileRanked() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCBD30 Offset: 0x2FCBE31 VA: 0x2FCBD30
	|-VersusSequence.VersusSequenceBase<object>.CheckProfileRanked
	*/

	// RVA: -1 Offset: -1
	private void SelectProfileRanked() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCC000 Offset: 0x2FCC101 VA: 0x2FCC000
	|-VersusSequence.VersusSequenceBase<object>.SelectProfileRanked
	*/

	// RVA: -1 Offset: -1
	private void DownloadMetaRankedProfile() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCC0F0 Offset: 0x2FCC1F1 VA: 0x2FCC0F0
	|-VersusSequence.VersusSequenceBase<object>.DownloadMetaRankedProfile
	*/

	// RVA: -1 Offset: -1
	private void Prepare() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCC110 Offset: 0x2FCC211 VA: 0x2FCC110
	|-VersusSequence.VersusSequenceBase<object>.Prepare
	*/

	// RVA: -1 Offset: -1
	private void ClearReliance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCC420 Offset: 0x2FCC521 VA: 0x2FCC420
	|-VersusSequence.VersusSequenceBase<object>.ClearReliance
	*/

	// RVA: -1 Offset: -1
	private void ClearEnhance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCC430 Offset: 0x2FCC531 VA: 0x2FCC430
	|-VersusSequence.VersusSequenceBase<object>.ClearEnhance
	*/

	// RVA: -1 Offset: -1
	private void DeleteGodLueur() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCC440 Offset: 0x2FCC541 VA: 0x2FCC440
	|-VersusSequence.VersusSequenceBase<object>.DeleteGodLueur
	*/

	// RVA: -1 Offset: -1
	private void PrepareCasual() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCC4B0 Offset: 0x2FCC5B1 VA: 0x2FCC4B0
	|-VersusSequence.VersusSequenceBase<object>.PrepareCasual
	*/

	// RVA: -1 Offset: -1
	private void PrepareRanked() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCC680 Offset: 0x2FCC781 VA: 0x2FCC680
	|-VersusSequence.VersusSequenceBase<object>.PrepareRanked
	*/

	// RVA: -1 Offset: -1
	private void PrepareMapEdit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCC850 Offset: 0x2FCC951 VA: 0x2FCC850
	|-VersusSequence.VersusSequenceBase<object>.PrepareMapEdit
	*/

	// RVA: -1 Offset: -1
	private void SelectReplay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCCA70 Offset: 0x2FCCB71 VA: 0x2FCCA70
	|-VersusSequence.VersusSequenceBase<object>.SelectReplay
	*/

	// RVA: -1 Offset: -1 Slot: 47
	protected abstract void SelectReplayImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.SelectReplayImpl
	*/

	// RVA: -1 Offset: -1
	private void OpenReplayDialog() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCCB40 Offset: 0x2FCCC41 VA: 0x2FCCB40
	|-VersusSequence.VersusSequenceBase<object>.OpenReplayDialog
	*/

	// RVA: -1 Offset: -1
	private void DownloadReplay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCCE70 Offset: 0x2FCCF71 VA: 0x2FCCE70
	|-VersusSequence.VersusSequenceBase<object>.DownloadReplay
	*/

	// RVA: -1 Offset: -1 Slot: 48
	protected abstract void DownloadReplayImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.DownloadReplayImpl
	*/

	// RVA: -1 Offset: -1
	private void PostDownloadReplay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCCE90 Offset: 0x2FCCF91 VA: 0x2FCCE90
	|-VersusSequence.VersusSequenceBase<object>.PostDownloadReplay
	*/

	// RVA: -1 Offset: -1
	private void CheckMockBattleData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCCF70 Offset: 0x2FCD071 VA: 0x2FCCF70
	|-VersusSequence.VersusSequenceBase<object>.CheckMockBattleData
	*/

	// RVA: -1 Offset: -1
	private void PrepareReplay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCD040 Offset: 0x2FCD141 VA: 0x2FCD040
	|-VersusSequence.VersusSequenceBase<object>.PrepareReplay
	*/

	// RVA: -1 Offset: -1
	private void DisableReplayData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCD120 Offset: 0x2FCD221 VA: 0x2FCD120
	|-VersusSequence.VersusSequenceBase<object>.DisableReplayData
	*/

	// RVA: -1 Offset: -1 Slot: 49
	protected abstract void ChangeReplayMetaImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.ChangeReplayMetaImpl
	*/

	// RVA: -1 Offset: -1
	private void ReceiveReward() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCD170 Offset: 0x2FCD271 VA: 0x2FCD170
	|-VersusSequence.VersusSequenceBase<object>.ReceiveReward
	*/

	// RVA: -1 Offset: -1
	private void GetReward(string rewardIid, int count, string resultMess) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCD360 Offset: 0x2FCD461 VA: 0x2FCD360
	|-VersusSequence.VersusSequenceBase<object>.GetReward
	*/

	// RVA: -1 Offset: -1
	private void DownloadCasual() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCD8D0 Offset: 0x2FCD9D1 VA: 0x2FCD8D0
	|-VersusSequence.VersusSequenceBase<object>.DownloadCasual
	*/

	// RVA: -1 Offset: -1 Slot: 50
	protected abstract void DownloadCasualImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.DownloadCasualImpl
	*/

	// RVA: -1 Offset: -1
	private void PostDownloadCasual() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCD8E0 Offset: 0x2FCD9E1 VA: 0x2FCD8E0
	|-VersusSequence.VersusSequenceBase<object>.PostDownloadCasual
	*/

	[IteratorStateMachineAttribute] // RVA: 0x2CC950 Offset: 0x2CCA51 VA: 0x2CC950
	// RVA: -1 Offset: -1
	private IEnumerator DownloadRanked() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCD8F0 Offset: 0x2FCD9F1 VA: 0x2FCD8F0
	|-VersusSequence.VersusSequenceBase<object>.DownloadRanked
	*/

	// RVA: -1 Offset: -1 Slot: 51
	protected abstract void DownloadImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.DownloadImpl
	*/

	[IteratorStateMachineAttribute] // RVA: 0x2CC9C0 Offset: 0x2CCAC1 VA: 0x2CC9C0
	// RVA: -1 Offset: -1
	private IEnumerator DownloadMyEditData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCD970 Offset: 0x2FCDA71 VA: 0x2FCD970
	|-VersusSequence.VersusSequenceBase<object>.DownloadMyEditData
	*/

	// RVA: -1 Offset: -1 Slot: 52
	protected abstract void DownloadMyEditImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.DownloadMyEditImpl
	*/

	[IteratorStateMachineAttribute] // RVA: 0x2CCA30 Offset: 0x2CCB31 VA: 0x2CCA30
	// RVA: -1 Offset: -1
	private IEnumerator DownloadMyEditForEditMode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCD9F0 Offset: 0x2FCDAF1 VA: 0x2FCD9F0
	|-VersusSequence.VersusSequenceBase<object>.DownloadMyEditForEditMode
	*/

	// RVA: -1 Offset: -1
	private void UploadReplay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCDA70 Offset: 0x2FCDB71 VA: 0x2FCDA70
	|-VersusSequence.VersusSequenceBase<object>.UploadReplay
	*/

	// RVA: -1 Offset: -1 Slot: 53
	protected abstract void UploadReplayImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.UploadReplayImpl
	*/

	// RVA: -1 Offset: -1
	private void PostUploadReplay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCDA80 Offset: 0x2FCDB81 VA: 0x2FCDA80
	|-VersusSequence.VersusSequenceBase<object>.PostUploadReplay
	*/

	// RVA: -1 Offset: -1
	private void SerializeCasualDataInit() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCDA90 Offset: 0x2FCDB91 VA: 0x2FCDA90
	|-VersusSequence.VersusSequenceBase<object>.SerializeCasualDataInit
	*/

	// RVA: -1 Offset: -1
	private void BranchEndCasual() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCDB10 Offset: 0x2FCDC11 VA: 0x2FCDB10
	|-VersusSequence.VersusSequenceBase<object>.BranchEndCasual
	*/

	// RVA: -1 Offset: -1
	private void BranchEndRanked() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCDC20 Offset: 0x2FCDD21 VA: 0x2FCDC20
	|-VersusSequence.VersusSequenceBase<object>.BranchEndRanked
	*/

	// RVA: -1 Offset: -1
	private void UploadCasual() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCDDF0 Offset: 0x2FCDEF1 VA: 0x2FCDDF0
	|-VersusSequence.VersusSequenceBase<object>.UploadCasual
	*/

	// RVA: -1 Offset: -1
	private void PostUploadCasual() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCDED0 Offset: 0x2FCDFD1 VA: 0x2FCDED0
	|-VersusSequence.VersusSequenceBase<object>.PostUploadCasual
	*/

	// RVA: -1 Offset: -1 Slot: 54
	protected abstract void UploadCasualImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.UploadCasualImpl
	*/

	// RVA: -1 Offset: -1 Slot: 55
	protected abstract void ChangeCasualImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.ChangeCasualImpl
	*/

	[IteratorStateMachineAttribute] // RVA: 0x2CCAA0 Offset: 0x2CCBA1 VA: 0x2CCAA0
	// RVA: -1 Offset: -1
	private IEnumerator CalculateRate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCDEE0 Offset: 0x2FCDFE1 VA: 0x2FCDEE0
	|-VersusSequence.VersusSequenceBase<object>.CalculateRate
	*/

	// RVA: -1 Offset: -1 Slot: 56
	protected abstract VersusServerRankedMetaData GetDownloadedEditMetaDataImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.GetDownloadedEditMetaDataImpl
	*/

	// RVA: -1 Offset: -1
	private void CheckRateDataType(int oldRate, int newRate, ulong dataId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCDF60 Offset: 0x2FCE061 VA: 0x2FCDF60
	|-VersusSequence.VersusSequenceBase<object>.CheckRateDataType
	*/

	// RVA: -1 Offset: -1 Slot: 57
	protected abstract void ChangeRankedMetaDataImpl(VersusServerRankedMetaData metaData);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.ChangeRankedMetaDataImpl
	*/

	// RVA: -1 Offset: -1 Slot: 58
	protected abstract void ChangeDataTypeImpl(ulong dataId, ushort dataType);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.ChangeDataTypeImpl
	*/

	// RVA: -1 Offset: -1
	private void ShowCasualResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCDFE0 Offset: 0x2FCE0E1 VA: 0x2FCDFE0
	|-VersusSequence.VersusSequenceBase<object>.ShowCasualResult
	*/

	// RVA: -1 Offset: -1
	private void ShowRankedResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCE220 Offset: 0x2FCE321 VA: 0x2FCE220
	|-VersusSequence.VersusSequenceBase<object>.ShowRankedResult
	*/

	// RVA: -1 Offset: -1
	private void DownloadProfile() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCE460 Offset: 0x2FCE561 VA: 0x2FCE460
	|-VersusSequence.VersusSequenceBase<object>.DownloadProfile
	*/

	// RVA: -1 Offset: -1
	private void DownloadProfileForReplay() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCE470 Offset: 0x2FCE571 VA: 0x2FCE470
	|-VersusSequence.VersusSequenceBase<object>.DownloadProfileForReplay
	*/

	// RVA: -1 Offset: -1
	private void UploadProfile() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCE480 Offset: 0x2FCE581 VA: 0x2FCE480
	|-VersusSequence.VersusSequenceBase<object>.UploadProfile
	*/

	// RVA: -1 Offset: -1
	private void UpdateProfile() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCE490 Offset: 0x2FCE591 VA: 0x2FCE490
	|-VersusSequence.VersusSequenceBase<object>.UpdateProfile
	*/

	// RVA: -1 Offset: -1
	private void ResetCachePostDownload() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCE510 Offset: 0x2FCE611 VA: 0x2FCE510
	|-VersusSequence.VersusSequenceBase<object>.ResetCachePostDownload
	*/

	// RVA: -1 Offset: -1
	private static void StopBgm_Hub() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCE5A0 Offset: 0x2FCE6A1 VA: 0x2FCE5A0
	|-VersusSequence.VersusSequenceBase<object>.StopBgm_Hub
	*/

	// RVA: -1 Offset: -1
	private void Save() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCE630 Offset: 0x2FCE731 VA: 0x2FCE630
	|-VersusSequence.VersusSequenceBase<object>.Save
	*/

	// RVA: -1 Offset: -1
	private void Restore() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCE6B0 Offset: 0x2FCE7B1 VA: 0x2FCE6B0
	|-VersusSequence.VersusSequenceBase<object>.Restore
	*/

	// RVA: -1 Offset: -1
	private void OpenInvalidDataDialog() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCE730 Offset: 0x2FCE831 VA: 0x2FCE730
	|-VersusSequence.VersusSequenceBase<object>.OpenInvalidDataDialog
	*/

	// RVA: -1 Offset: -1
	private void AddCounters() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCE7C0 Offset: 0x2FCE8C1 VA: 0x2FCE7C0
	|-VersusSequence.VersusSequenceBase<object>.AddCounters
	*/

	// RVA: -1 Offset: -1
	private void AddCounterDefense() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCE880 Offset: 0x2FCE981 VA: 0x2FCE880
	|-VersusSequence.VersusSequenceBase<object>.AddCounterDefense
	*/

	// RVA: -1 Offset: -1
	private void AddPlayReportStartCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCE890 Offset: 0x2FCE991 VA: 0x2FCE890
	|-VersusSequence.VersusSequenceBase<object>.AddPlayReportStartCount
	*/

	// RVA: -1 Offset: -1
	protected List<ulong> GetFriendList(bool isFilter = True, bool isSort = True, int maxCount = 100) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCE8A0 Offset: 0x2FCE9A1 VA: 0x2FCE8A0
	|-VersusSequence.VersusSequenceBase<object>.GetFriendList
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceNet>.GetFriendList
	*/

	// RVA: -1 Offset: -1
	protected Dictionary<ulong, Friend> GetFriendObjectDict() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCED00 Offset: 0x2FCEE01 VA: 0x2FCED00
	|-VersusSequence.VersusSequenceBase<object>.GetFriendObjectDict
	*/

	// RVA: -1 Offset: -1 Slot: 59
	protected abstract void CheckParentalControlImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.CheckParentalControlImpl
	*/

	// RVA: -1 Offset: -1 Slot: 60
	protected abstract bool IsParentalControlAvailableImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.IsParentalControlAvailableImpl
	*/

	// RVA: -1 Offset: -1 Slot: 61
	protected abstract void EndParentalControlImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.EndParentalControlImpl
	*/

	// RVA: -1 Offset: -1
	protected static void CreateBind(ProcInst super) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FCEEA0 Offset: 0x2FCEFA1 VA: 0x2FCEEA0
	|-VersusSequence.VersusSequenceBase<object>.CreateBind
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceLocal>.CreateBind
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceNet>.CreateBind
	*/

	// RVA: -1 Offset: -1
	protected static string GetDataTypeName(ushort dataType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD4100 Offset: 0x2FD4201 VA: 0x2FD4100
	|-VersusSequence.VersusSequenceBase<object>.GetDataTypeName
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private string App.VersusSequence.IVersusSequenceBase.GetNowRateName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD4250 Offset: 0x2FD4351 VA: 0x2FD4250
	|-VersusSequence.VersusSequenceBase<object>.App.VersusSequence.IVersusSequenceBase.GetNowRateName
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceLocal>.App.VersusSequence.IVersusSequenceBase.GetNowRateName
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceNet>.App.VersusSequence.IVersusSequenceBase.GetNowRateName
	*/

	// RVA: -1 Offset: -1
	private void InitEditData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD4310 Offset: 0x2FD4411 VA: 0x2FD4310
	|-VersusSequence.VersusSequenceBase<object>.InitEditData
	*/

	// RVA: -1 Offset: -1 Slot: 62
	protected abstract void InitEditDataImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.InitEditDataImpl
	*/

	// RVA: -1 Offset: -1
	private void PrepareEditData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD4320 Offset: 0x2FD4421 VA: 0x2FD4320
	|-VersusSequence.VersusSequenceBase<object>.PrepareEditData
	*/

	// RVA: -1 Offset: -1
	private void UploadEditData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD44A0 Offset: 0x2FD45A1 VA: 0x2FD44A0
	|-VersusSequence.VersusSequenceBase<object>.UploadEditData
	*/

	// RVA: -1 Offset: -1 Slot: 63
	protected abstract void UploadEditDataImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.UploadEditDataImpl
	*/

	// RVA: -1 Offset: -1
	private void PostUploadEditData() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD44B0 Offset: 0x2FD45B1 VA: 0x2FD44B0
	|-VersusSequence.VersusSequenceBase<object>.PostUploadEditData
	*/

	// RVA: -1 Offset: -1 Slot: 64
	protected abstract void PostUploadEditDataImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.PostUploadEditDataImpl
	*/

	// RVA: -1 Offset: -1 Slot: 65
	protected abstract bool GetLastUploadedResultImpl();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-VersusSequence.VersusSequenceBase<object>.GetLastUploadedResultImpl
	*/

	// RVA: -1 Offset: -1
	protected static void CreateBindUploadEditData(ProcInst super) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD44C0 Offset: 0x2FD45C1 VA: 0x2FD44C0
	|-VersusSequence.VersusSequenceBase<object>.CreateBindUploadEditData
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceLocal>.CreateBindUploadEditData
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceNet>.CreateBindUploadEditData
	*/

	// RVA: -1 Offset: -1
	protected static void CreateBindUploadCasualData(ProcInst super) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD4810 Offset: 0x2FD4911 VA: 0x2FD4810
	|-VersusSequence.VersusSequenceBase<object>.CreateBindUploadCasualData
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceLocal>.CreateBindUploadCasualData
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceNet>.CreateBindUploadCasualData
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD4A70 Offset: 0x2FD4B71 VA: 0x2FD4A70
	|-VersusSequence.VersusSequenceBase<object>..ctor
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceLocal>..ctor
	|-VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceNet>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD4CC0 Offset: 0x2FD4DC1 VA: 0x2FD4CC0
	|-VersusSequence.VersusSequenceBase<object>..cctor
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2CCB10 Offset: 0x2CCC11 VA: 0x2CCB10
	// RVA: -1 Offset: -1
	private void <StartBattleDialogCasualDataCode>b__80_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD4D40 Offset: 0x2FD4E41 VA: 0x2FD4D40
	|-VersusSequence.VersusSequenceBase<object>.<StartBattleDialogCasualDataCode>b__80_0
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2CCB20 Offset: 0x2CCC21 VA: 0x2CCB20
	// RVA: -1 Offset: -1
	private void <StartBattleDialogCasualDataCode>b__80_1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD4DB0 Offset: 0x2FD4EB1 VA: 0x2FD4DB0
	|-VersusSequence.VersusSequenceBase<object>.<StartBattleDialogCasualDataCode>b__80_1
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2CCB30 Offset: 0x2CCC31 VA: 0x2CCB30
	// RVA: -1 Offset: -1
	private void <StartBattleDialogRankedDataCode>b__81_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD4E20 Offset: 0x2FD4F21 VA: 0x2FD4E20
	|-VersusSequence.VersusSequenceBase<object>.<StartBattleDialogRankedDataCode>b__81_0
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2CCB40 Offset: 0x2CCC41 VA: 0x2CCB40
	// RVA: -1 Offset: -1
	private void <StartBattleDialogRankedDataCode>b__81_1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD4E90 Offset: 0x2FD4F91 VA: 0x2FD4E90
	|-VersusSequence.VersusSequenceBase<object>.<StartBattleDialogRankedDataCode>b__81_1
	*/

	[CompilerGeneratedAttribute] // RVA: 0x2CCB50 Offset: 0x2CCC51 VA: 0x2CCB50
	// RVA: -1 Offset: -1
	internal static void <CreateBindUploadCasualData>g__PrepareCasualData|164_0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2FD4F00 Offset: 0x2FD5001 VA: 0x2FD4F00
	|-VersusSequence.VersusSequenceBase<object>.<CreateBindUploadCasualData>g__PrepareCasualData|164_0
	*/
}

// Namespace: 
private static class VersusSequence.VersusSequenceLocal.LocalRate // TypeDefIndex: 13702
{
	// Methods

	// RVA: 0x2D6E570 Offset: 0x2D6E671 VA: 0x2D6E570
	public static int ParseToNumber(ushort rateDataType) { }

	// RVA: 0x2D6E590 Offset: 0x2D6E691 VA: 0x2D6E590
	public static ushort ParseToDataType(int rateNumber) { }

	// RVA: 0x2D6E5E0 Offset: 0x2D6E6E1 VA: 0x2D6E5E0
	public static ushort ParseToSlotId(int index) { }

	// RVA: 0x2D6E600 Offset: 0x2D6E701 VA: 0x2D6E600
	public static int PerseToSlotIndex(ushort slotId) { }
}

// Namespace: 
private class VersusSequence.VersusSequenceLocal.MetaDataPack // TypeDefIndex: 13703
{
	// Fields
	public string path; // 0x10
	public VersusServerReplayMetaData data; // 0x18

	// Methods

	// RVA: 0x2D6E620 Offset: 0x2D6E721 VA: 0x2D6E620
	public void .ctor(VersusServerReplayMetaData data, string path) { }
}

// Namespace: 
public sealed class VersusSequence.VersusSequenceLocal.SelectReplayMetaMenuItem.ACallback : MulticastDelegate // TypeDefIndex: 13704
{
	// Methods

	// RVA: 0x2D7E360 Offset: 0x2D7E461 VA: 0x2D7E360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2D6EB60 Offset: 0x2D6EC61 VA: 0x2D6EB60 Slot: 13
	public virtual void Invoke(VersusServerReplayMetaData metaData, string metaPath, ushort slotId) { }

	// RVA: 0x2D7E380 Offset: 0x2D7E481 VA: 0x2D7E380 Slot: 14
	public virtual IAsyncResult BeginInvoke(VersusServerReplayMetaData metaData, string metaPath, ushort slotId, AsyncCallback callback, object object) { }

	// RVA: 0x2D7E430 Offset: 0x2D7E531 VA: 0x2D7E430 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private class VersusSequence.VersusSequenceLocal.SelectReplayMetaMenuItem : MenuItem // TypeDefIndex: 13705
{
	// Fields
	private VersusServerReplayMetaData m_MetaData; // 0x20
	private string m_MetaPath; // 0x28
	private ushort m_SlotId; // 0x30
	private VersusSequence.VersusSequenceLocal.SelectReplayMetaMenuItem.ACallback m_ACallback; // 0x38
	private bool m_IsUpload; // 0x40
	private bool m_IsPlay; // 0x41

	// Methods

	// RVA: 0x2D6E670 Offset: 0x2D6E771 VA: 0x2D6E670
	public void .ctor(string path, VersusServerReplayMetaData metaData, ushort slotId, bool isUpload, bool isPlay, VersusSequence.VersusSequenceLocal.SelectReplayMetaMenuItem.ACallback callback) { }

	// RVA: 0x2D6E740 Offset: 0x2D6E841 VA: 0x2D6E740 Slot: 5
	public override string GetName() { }

	// RVA: 0x2D6EAE0 Offset: 0x2D6EBE1 VA: 0x2D6EAE0 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x2D6EB00 Offset: 0x2D6EC01 VA: 0x2D6EB00 Slot: 12
	public override MenuItem.Result ACall() { }

	// RVA: 0x2D6EF00 Offset: 0x2D6F001 VA: 0x2D6EF00 Slot: 13
	public override MenuItem.Result BCall() { }
}

// Namespace: 
private class VersusSequence.VersusSequenceLocal : VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceLocal> // TypeDefIndex: 13706
{
	// Fields
	private string m_RootPath; // 0xF8
	private const int RateTop = 1;
	private const int RateBottom = 5;
	private string m_MyCasualMetaDataPath; // 0x100
	private string m_MyEditDataPath; // 0x108
	private string m_SelectedReplayMetaPath; // 0x110
	private bool m_IsSucceededLastUpload; // 0x118
	private ushort m_LastReplayGetSlot; // 0x11A

	// Methods

	// RVA: 0x1EE6A70 Offset: 0x1EE6B71 VA: 0x1EE6A70 Slot: 26
	protected override void InitImpl() { }

	// RVA: 0x1EE6D90 Offset: 0x1EE6E91 VA: 0x1EE6D90 Slot: 27
	protected override void FinalImpl() { }

	// RVA: 0x1EE6E10 Offset: 0x1EE6F11 VA: 0x1EE6E10 Slot: 28
	protected override bool IsFailedJumpToTopImpl() { }

	// RVA: 0x1EE6F00 Offset: 0x1EE7001 VA: 0x1EE6F00 Slot: 29
	protected override bool IsReportedEditMapImpl() { }

	// RVA: 0x1EE6FC0 Offset: 0x1EE70C1 VA: 0x1EE6FC0 Slot: 30
	protected override void UploadReportDataImpl() { }

	// RVA: 0x1EE6FD0 Offset: 0x1EE70D1 VA: 0x1EE6FD0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1EE7050 Offset: 0x1EE7151 VA: 0x1EE7050
	public static void CreateBindUploadEditData(ProcInst super) { }

	// RVA: 0x1EE70D0 Offset: 0x1EE71D1 VA: 0x1EE70D0
	public static void CreateBindUploadCasualData(ProcInst super) { }

	// RVA: 0x1EE6B40 Offset: 0x1EE6C41 VA: 0x1EE6B40
	private void InitializeLanRootPath() { }

	// RVA: 0x1EE7150 Offset: 0x1EE7251 VA: 0x1EE7150
	private string[] GetRateDirectoriesPaths() { }

	// RVA: 0x1EE7290 Offset: 0x1EE7391 VA: 0x1EE7290
	private string GetRateDirPath(int rate) { }

	// RVA: 0x1EE7390 Offset: 0x1EE7491 VA: 0x1EE7390
	private static string AppendRate(int rate) { }

	// RVA: 0x1EE7430 Offset: 0x1EE7531 VA: 0x1EE7430
	private static string GetDataFileName(VersusServerRankedMetaData metaData, int rate) { }

	// RVA: 0x1EE75B0 Offset: 0x1EE76B1 VA: 0x1EE75B0
	private static string GetDataFileName(string playerName, int rate) { }

	// RVA: 0x1EE7550 Offset: 0x1EE7651 VA: 0x1EE7550
	private static string GetDataFileName(VersusServerRankedMetaData metaData) { }

	// RVA: 0x1EE76D0 Offset: 0x1EE77D1 VA: 0x1EE76D0
	private static string GetDataFileName(string ownerName) { }

	// RVA: 0x1EE7730 Offset: 0x1EE7831 VA: 0x1EE7730
	private static string GetMetaDataFileName(VersusServerRankedMetaData metaData, int rate) { }

	// RVA: 0x1EE77A0 Offset: 0x1EE78A1 VA: 0x1EE77A0
	private static string GetMetaDataFileName(string ownerName, int rate) { }

	// RVA: 0x1EE7810 Offset: 0x1EE7911 VA: 0x1EE7810
	private bool MoveFiles(string playerName, int fromRate, int toRate) { }

	// RVA: 0x1EE79E0 Offset: 0x1EE7AE1 VA: 0x1EE79E0
	private string GetReplayDataPath(string playerName, ushort slotId) { }

	// RVA: 0x1EE7A90 Offset: 0x1EE7B91 VA: 0x1EE7A90
	private string GetReplayMetaPath(string playerName, ushort slotId) { }

	// RVA: 0x1EE7B70 Offset: 0x1EE7C71 VA: 0x1EE7B70
	private string[] GetReplayMetaPaths(string playerName) { }

	// RVA: 0x1EE7CC0 Offset: 0x1EE7DC1 VA: 0x1EE7CC0
	private string GetCasualDirectoryPath() { }

	// RVA: 0x1EE7D20 Offset: 0x1EE7E21 VA: 0x1EE7D20
	private string GetCasualDataPath(string playerName) { }

	// RVA: 0x1EE7DC0 Offset: 0x1EE7EC1 VA: 0x1EE7DC0
	private string GetCasualMetaPath(string playerName) { }

	// RVA: 0x1EE7E90 Offset: 0x1EE7F91 VA: 0x1EE7E90
	private string FindCasualMetaPath(ulong principalID) { }

	// RVA: 0x1EE8250 Offset: 0x1EE8351 VA: 0x1EE8250
	private string GetPath(VersusServerRankedMetaData metaData) { }

	// RVA: 0x1EE8630 Offset: 0x1EE8731 VA: 0x1EE8630
	private string FindRankedMetaPath(ulong principalID) { }

	// RVA: 0x1EE8A40 Offset: 0x1EE8B41 VA: 0x1EE8A40
	private string GetPlayerName(string path) { }

	// RVA: 0x1EE8B20 Offset: 0x1EE8C21 VA: 0x1EE8B20
	private bool TryGetPrincipalId(out ulong principalId) { }

	// RVA: 0x1EE8BD0 Offset: 0x1EE8CD1 VA: 0x1EE8BD0
	private string GetLocalNickName() { }

	// RVA: 0x1EE8C40 Offset: 0x1EE8D41 VA: 0x1EE8C40 Slot: 31
	protected override void GetMyCasualMetaDataImpl() { }

	// RVA: 0x1EE8DE0 Offset: 0x1EE8EE1 VA: 0x1EE8DE0 Slot: 32
	protected override void PostGetMyCasualMetaDataImpl() { }

	// RVA: 0x1EE8DF0 Offset: 0x1EE8EF1 VA: 0x1EE8DF0 Slot: 33
	protected override void GetEditMetaDataImpl() { }

	// RVA: 0x1EE9280 Offset: 0x1EE9381 VA: 0x1EE9280 Slot: 34
	protected override void PostGetEditMetaDataImpl() { }

	// RVA: 0x1EE93B0 Offset: 0x1EE94B1 VA: 0x1EE93B0 Slot: 35
	protected override void UpdateRateImpl() { }

	// RVA: 0x1EE95A0 Offset: 0x1EE96A1 VA: 0x1EE95A0 Slot: 36
	protected override void SetRankedInfoImpl() { }

	// RVA: 0x1EE9710 Offset: 0x1EE9811 VA: 0x1EE9710 Slot: 63
	protected override void UploadEditDataImpl() { }

	// RVA: 0x1EE98B0 Offset: 0x1EE99B1 VA: 0x1EE98B0
	private void LocalUpload(string playerName, VersusServerRankedMetaData metaData, VersusServerRankedData data, ushort rateDataType) { }

	// RVA: 0x1EE9E10 Offset: 0x1EE9F11 VA: 0x1EE9E10 Slot: 64
	protected override void PostUploadEditDataImpl() { }

	// RVA: 0x1EE9E20 Offset: 0x1EE9F21 VA: 0x1EE9E20 Slot: 43
	protected override void DownloadMetaCasualFromDataCodeImpl() { }

	// RVA: 0x1EEA060 Offset: 0x1EEA161 VA: 0x1EEA060 Slot: 44
	protected override void DownloadMetaRankedFromDataCodeImpl() { }

	// RVA: 0x1EEA070 Offset: 0x1EEA171 VA: 0x1EEA070 Slot: 45
	protected override void CheckAccessibleProfileImpl(Versus.Mode mode, NexVersus.TargetSlotList targetSlotList) { }

	// RVA: 0x1EEA230 Offset: 0x1EEA331 VA: 0x1EEA230 Slot: 46
	protected override void DownloadMetaProfileImpl(Versus.Mode mode, ProfileCard profile) { }

	// RVA: 0x1EEA400 Offset: 0x1EEA501 VA: 0x1EEA400 Slot: 50
	protected override void DownloadCasualImpl() { }

	// RVA: 0x1EEA520 Offset: 0x1EEA621 VA: 0x1EEA520 Slot: 53
	protected override void UploadReplayImpl() { }

	// RVA: 0x1EEAA90 Offset: 0x1EEAB91 VA: 0x1EEAA90
	private ushort GetUploadReplaySlot(string opponentName) { }

	// RVA: 0x1EEAD80 Offset: 0x1EEAE81 VA: 0x1EEAD80 Slot: 54
	protected override void UploadCasualImpl() { }

	// RVA: 0x1EEB2E0 Offset: 0x1EEB3E1 VA: 0x1EEB2E0 Slot: 55
	protected override void ChangeCasualImpl() { }

	// RVA: 0x1EEB560 Offset: 0x1EEB661 VA: 0x1EEB560 Slot: 37
	protected override void SearchSameRateImpl() { }

	// RVA: 0x1EEB9A0 Offset: 0x1EEBAA1 VA: 0x1EEB9A0 Slot: 39
	protected override void ExcludeMySearchRankedData() { }

	// RVA: 0x1EEB9B0 Offset: 0x1EEBAB1 VA: 0x1EEB9B0 Slot: 40
	protected override void SearchCasualImpl() { }

	// RVA: 0x1EEB9C0 Offset: 0x1EEBAC1 VA: 0x1EEB9C0
	private void SearchCasualLocal(List<VersusServerCasualMetaData> resultList, bool isMyself = False) { }

	// RVA: 0x1EEBE00 Offset: 0x1EEBF01 VA: 0x1EEBE00 Slot: 41
	protected override void SearchCasualFriendImpl() { }

	// RVA: 0x1EEBE10 Offset: 0x1EEBF11 VA: 0x1EEBE10 Slot: 38
	protected override void SearchRankedFriendImpl() { }

	// RVA: 0x1EEC1B0 Offset: 0x1EEC2B1 VA: 0x1EEC1B0 Slot: 42
	protected override void ExcludeMySearchCasualData(List<VersusServerCasualMetaData> dataList) { }

	// RVA: 0x1EEC1C0 Offset: 0x1EEC2C1 VA: 0x1EEC1C0 Slot: 51
	protected override void DownloadImpl() { }

	// RVA: 0x1EEC3A0 Offset: 0x1EEC4A1 VA: 0x1EEC3A0 Slot: 52
	protected override void DownloadMyEditImpl() { }

	// RVA: 0x1EEC5A0 Offset: 0x1EEC6A1 VA: 0x1EEC5A0 Slot: 47
	protected override void SelectReplayImpl() { }

	// RVA: 0x1EEC750 Offset: 0x1EEC851 VA: 0x1EEC750
	private void MostOldestReplayMetaData(string[] paths, out VersusServerReplayMetaData metaData, out string metaPath) { }

	// RVA: 0x1EEC9F0 Offset: 0x1EECAF1 VA: 0x1EEC9F0 Slot: 48
	protected override void DownloadReplayImpl() { }

	// RVA: 0x1EECB10 Offset: 0x1EECC11 VA: 0x1EECB10 Slot: 49
	protected override void ChangeReplayMetaImpl() { }

	// RVA: 0x1EE8E20 Offset: 0x1EE8F21 VA: 0x1EE8E20
	private ulong SearchMyDataToDataId() { }

	// RVA: 0x1EECD80 Offset: 0x1EECE81 VA: 0x1EECD80 Slot: 65
	protected override bool GetLastUploadedResultImpl() { }

	// RVA: 0x1EECD90 Offset: 0x1EECE91 VA: 0x1EECD90 Slot: 56
	protected override VersusServerRankedMetaData GetDownloadedEditMetaDataImpl() { }

	// RVA: 0x1EECE30 Offset: 0x1EECF31 VA: 0x1EECE30 Slot: 57
	protected override void ChangeRankedMetaDataImpl(VersusServerRankedMetaData metaData) { }

	// RVA: 0x1EED070 Offset: 0x1EED171 VA: 0x1EED070 Slot: 58
	protected override void ChangeDataTypeImpl(ulong dataId, ushort dataType) { }

	// RVA: 0x1EED080 Offset: 0x1EED181 VA: 0x1EED080 Slot: 62
	protected override void InitEditDataImpl() { }

	// RVA: 0x1EED110 Offset: 0x1EED211 VA: 0x1EED110 Slot: 59
	protected override void CheckParentalControlImpl() { }

	// RVA: 0x1EED120 Offset: 0x1EED221 VA: 0x1EED120 Slot: 60
	protected override bool IsParentalControlAvailableImpl() { }

	// RVA: 0x1EED130 Offset: 0x1EED231 VA: 0x1EED130 Slot: 61
	protected override void EndParentalControlImpl() { }

	// RVA: 0x1EED140 Offset: 0x1EED241 VA: 0x1EED140
	private void CreateSelectReplayMetaMenu(string[] metaPaths, VersusSequence.VersusSequenceLocal.SelectReplayMetaMenuItem.ACallback callback) { }

	// RVA: 0x1EED470 Offset: 0x1EED571 VA: 0x1EED470
	private VersusServerReplayMetaData Deserialize(string path) { }

	// RVA: 0x1EED520 Offset: 0x1EED621 VA: 0x1EED520
	public void .ctor() { }
}

// Namespace: 
private enum VersusSequence.VersusSequenceNet.UploadEditMapSequence.Label // TypeDefIndex: 13707
{
	// Fields
	public int value__; // 0x0
	public const VersusSequence.VersusSequenceNet.UploadEditMapSequence.Label Error = 0;
	public const VersusSequence.VersusSequenceNet.UploadEditMapSequence.Label End = 1;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279210 Offset: 0x279311 VA: 0x279210
private sealed class VersusSequence.VersusSequenceNet.UploadEditMapSequence.<UploadEditMap>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13708
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VersusSequence.VersusSequenceNet.UploadEditMapSequence <>4__this; // 0x20
	private VersusServerRankedMetaData <metaData>5__2; // 0x28
	private VersusServerRankedData <data>5__3; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CCF40 Offset: 0x2CD041 VA: 0x2CCF40
	// RVA: 0x2D70870 Offset: 0x2D70971 VA: 0x2D70870
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2CCF50 Offset: 0x2CD051 VA: 0x2CCF50
	// RVA: 0x2D7E7F0 Offset: 0x2D7E8F1 VA: 0x2D7E7F0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2D7E800 Offset: 0x2D7E901 VA: 0x2D7E800 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CCF60 Offset: 0x2CD061 VA: 0x2CCF60
	// RVA: 0x2D7EBC0 Offset: 0x2D7ECC1 VA: 0x2D7EBC0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CCF70 Offset: 0x2CD071 VA: 0x2CCF70
	// RVA: 0x2D7EBD0 Offset: 0x2D7ECD1 VA: 0x2D7EBD0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CCF80 Offset: 0x2CD081 VA: 0x2CCF80
	// RVA: 0x2D7EC10 Offset: 0x2D7ED11 VA: 0x2D7EC10 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279220 Offset: 0x279321 VA: 0x279220
private sealed class VersusSequence.VersusSequenceNet.UploadEditMapSequence.<UploadReplayDatas>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13709
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VersusSequence.VersusSequenceNet.UploadEditMapSequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CCF90 Offset: 0x2CD091 VA: 0x2CCF90
	// RVA: 0x2D70A80 Offset: 0x2D70B81 VA: 0x2D70A80
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2CCFA0 Offset: 0x2CD0A1 VA: 0x2CCFA0
	// RVA: 0x2D7EC20 Offset: 0x2D7ED21 VA: 0x2D7EC20 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2D7EC30 Offset: 0x2D7ED31 VA: 0x2D7EC30 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CCFB0 Offset: 0x2CD0B1 VA: 0x2CCFB0
	// RVA: 0x2D7EDB0 Offset: 0x2D7EEB1 VA: 0x2D7EDB0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CCFC0 Offset: 0x2CD0C1 VA: 0x2CCFC0
	// RVA: 0x2D7EDC0 Offset: 0x2D7EEC1 VA: 0x2D7EDC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CCFD0 Offset: 0x2CD0D1 VA: 0x2CCFD0
	// RVA: 0x2D7EE00 Offset: 0x2D7EF01 VA: 0x2D7EE00 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
private class VersusSequence.VersusSequenceNet.UploadEditMapSequence : ProcInst // TypeDefIndex: 13710
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29C8F0 Offset: 0x29C9F1 VA: 0x29C8F0
	private static NexVersus.Results <Result>k__BackingField; // 0x0
	private bool m_IsNewUpload; // 0x70

	// Properties
	public static NexVersus.Results Result { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CCE40 Offset: 0x2CCF41 VA: 0x2CCE40
	// RVA: 0x2D70710 Offset: 0x2D70811 VA: 0x2D70710
	public static NexVersus.Results get_Result() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CCE50 Offset: 0x2CCF51 VA: 0x2CCE50
	// RVA: 0x2D70760 Offset: 0x2D70861 VA: 0x2D70760
	private static void set_Result(NexVersus.Results value) { }

	// RVA: 0x2D707C0 Offset: 0x2D708C1 VA: 0x2D707C0
	private void .ctor(bool isNewUpload) { }

	[IteratorStateMachineAttribute] // RVA: 0x2CCE60 Offset: 0x2CCF61 VA: 0x2CCE60
	// RVA: 0x2D707F0 Offset: 0x2D708F1 VA: 0x2D707F0
	private IEnumerator UploadEditMap() { }

	// RVA: 0x2D708A0 Offset: 0x2D709A1 VA: 0x2D708A0
	private void PostUploadEditMap() { }

	[IteratorStateMachineAttribute] // RVA: 0x2CCED0 Offset: 0x2CCFD1 VA: 0x2CCED0
	// RVA: 0x2D70A00 Offset: 0x2D70B01 VA: 0x2D70A00
	private IEnumerator UploadReplayDatas() { }

	// RVA: 0x2D70AB0 Offset: 0x2D70BB1 VA: 0x2D70AB0
	private void UploadReplay(ushort slotId) { }

	// RVA: 0x2D70BA0 Offset: 0x2D70CA1 VA: 0x2D70BA0
	private void PostUploadReplay() { }

	// RVA: 0x2D70C90 Offset: 0x2D70D91 VA: 0x2D70C90
	private void SetResult() { }

	// RVA: 0x2D70CF0 Offset: 0x2D70DF1 VA: 0x2D70CF0
	private void PrintError() { }

	// RVA: 0x2D70D00 Offset: 0x2D70E01 VA: 0x2D70D00
	public static void CreateBind(ProcInst super, bool isNewUpload) { }
}

// Namespace: 
private enum VersusSequence.VersusSequenceNet.UploadReplaySequence.Label // TypeDefIndex: 13711
{
	// Fields
	public int value__; // 0x0
	public const VersusSequence.VersusSequenceNet.UploadReplaySequence.Label Error = 0;
	public const VersusSequence.VersusSequenceNet.UploadReplaySequence.Label End = 1;
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279230 Offset: 0x279331 VA: 0x279230
private sealed class VersusSequence.VersusSequenceNet.UploadReplaySequence.<GetReplayMetaDatas>d__11 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13712
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VersusSequence.VersusSequenceNet.UploadReplaySequence <>4__this; // 0x20
	private NexVersus <nex>5__2; // 0x28
	private NexVersus.ReplaySlotMetaResultData <resultData>5__3; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CD070 Offset: 0x2CD171 VA: 0x2CD070
	// RVA: 0x2D71500 Offset: 0x2D71601 VA: 0x2D71500
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD080 Offset: 0x2CD181 VA: 0x2CD080
	// RVA: 0x2D7EE10 Offset: 0x2D7EF11 VA: 0x2D7EE10 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2D7EE20 Offset: 0x2D7EF21 VA: 0x2D7EE20 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD090 Offset: 0x2CD191 VA: 0x2CD090
	// RVA: 0x2D7F000 Offset: 0x2D7F101 VA: 0x2D7F000 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD0A0 Offset: 0x2CD1A1 VA: 0x2CD0A0
	// RVA: 0x2D7F010 Offset: 0x2D7F111 VA: 0x2D7F010 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD0B0 Offset: 0x2CD1B1 VA: 0x2CD0B0
	// RVA: 0x2D7F050 Offset: 0x2D7F151 VA: 0x2D7F050 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
private class VersusSequence.VersusSequenceNet.UploadReplaySequence : ProcInst // TypeDefIndex: 13713
{
	// Fields
	private VersusServerReplayMetaData m_MetaData; // 0x70
	private VersusServerReplayData m_Data; // 0x78
	private ulong m_OpponentPrincipalId; // 0x80
	private VersusServerReplayMetaData m_OpponentMetaData; // 0x88
	private VersusServerReplayMetaData m_TargetMetaData; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x29C900 Offset: 0x29CA01 VA: 0x29C900
	private static NexVersus.Results <Result>k__BackingField; // 0x0

	// Properties
	public static NexVersus.Results Result { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CCFE0 Offset: 0x2CD0E1 VA: 0x2CCFE0
	// RVA: 0x2D71360 Offset: 0x2D71461 VA: 0x2D71360
	public static NexVersus.Results get_Result() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CCFF0 Offset: 0x2CD0F1 VA: 0x2CCFF0
	// RVA: 0x2D713B0 Offset: 0x2D714B1 VA: 0x2D713B0
	private static void set_Result(NexVersus.Results value) { }

	// RVA: 0x2D71410 Offset: 0x2D71511 VA: 0x2D71410
	private void .ctor(ulong opponentPrincipalId, VersusServerReplayMetaData metaData, VersusServerReplayData data) { }

	[IteratorStateMachineAttribute] // RVA: 0x2CD000 Offset: 0x2CD101 VA: 0x2CD000
	// RVA: 0x2D71480 Offset: 0x2D71581 VA: 0x2D71480
	private IEnumerator GetReplayMetaDatas() { }

	// RVA: 0x2D71530 Offset: 0x2D71631 VA: 0x2D71530
	private void ChangeMetaData() { }

	// RVA: 0x2D715D0 Offset: 0x2D716D1 VA: 0x2D715D0
	private void PostChangeMetaData() { }

	// RVA: 0x2D716C0 Offset: 0x2D717C1 VA: 0x2D716C0
	private void ChangeReplayData() { }

	// RVA: 0x2D71750 Offset: 0x2D71851 VA: 0x2D71750
	private void PostChangeReplayData() { }

	// RVA: 0x2D71840 Offset: 0x2D71941 VA: 0x2D71840
	private void PrintError() { }

	// RVA: 0x2D71850 Offset: 0x2D71951 VA: 0x2D71850
	private void SetResult() { }

	// RVA: 0x2D718B0 Offset: 0x2D719B1 VA: 0x2D718B0
	public static void CreateBind(ProcInst super, ulong opponentPrincipalId, VersusServerReplayMetaData metaData, VersusServerReplayData data) { }
}

// Namespace: 
public sealed class VersusSequence.VersusSequenceNet.SelectReplaySequence.Callback : MulticastDelegate // TypeDefIndex: 13714
{
	// Methods

	// RVA: 0x2D7E630 Offset: 0x2D7E731 VA: 0x2D7E630
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x2D6FA80 Offset: 0x2D6FB81 VA: 0x2D6FA80 Slot: 13
	public virtual void Invoke(NexVersus.Results result, VersusServerReplayMetaData metaData) { }

	// RVA: 0x2D7E650 Offset: 0x2D7E751 VA: 0x2D7E650 Slot: 14
	public virtual IAsyncResult BeginInvoke(NexVersus.Results result, VersusServerReplayMetaData metaData, AsyncCallback callback, object object) { }

	// RVA: 0x2D7E6F0 Offset: 0x2D7E7F1 VA: 0x2D7E6F0 Slot: 15
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private enum VersusSequence.VersusSequenceNet.SelectReplaySequence.Label // TypeDefIndex: 13715
{
	// Fields
	public int value__; // 0x0
	public const VersusSequence.VersusSequenceNet.SelectReplaySequence.Label Error = 0;
	public const VersusSequence.VersusSequenceNet.SelectReplaySequence.Label End = 1;
}

// Namespace: 
private class VersusSequence.VersusSequenceNet.SelectReplaySequence.SelectReplayMenuItem : MenuItem // TypeDefIndex: 13716
{
	// Fields
	private VersusServerReplayMetaData m_MetaData; // 0x20
	private VersusSequence.VersusSequenceNet.SelectReplaySequence.Callback m_Callback; // 0x28
	private int m_Index; // 0x30
	private bool m_IsUpload; // 0x34
	private bool m_IsPlay; // 0x35

	// Methods

	// RVA: 0x2D6FEC0 Offset: 0x2D6FFC1 VA: 0x2D6FEC0
	public void .ctor(VersusServerReplayMetaData metaData, int index, bool isUpload, bool isPlay, VersusSequence.VersusSequenceNet.SelectReplaySequence.Callback callback) { }

	// RVA: 0x2D7E700 Offset: 0x2D7E801 VA: 0x2D7E700 Slot: 5
	public override string GetName() { }

	// RVA: 0x2D7E750 Offset: 0x2D7E851 VA: 0x2D7E750 Slot: 22
	public override bool IsEnable() { }

	// RVA: 0x2D7E760 Offset: 0x2D7E861 VA: 0x2D7E760 Slot: 12
	public override MenuItem.Result ACall() { }

	// RVA: 0x2D7E7C0 Offset: 0x2D7E8C1 VA: 0x2D7E7C0 Slot: 13
	public override MenuItem.Result BCall() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279240 Offset: 0x279341 VA: 0x279240
private sealed class VersusSequence.VersusSequenceNet.SelectReplaySequence.<GetReplaySlots>d__5 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13717
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public VersusSequence.VersusSequenceNet.SelectReplaySequence <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x2CD130 Offset: 0x2CD231 VA: 0x2CD130
	// RVA: 0x2D6FA00 Offset: 0x2D6FB01 VA: 0x2D6FA00
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD140 Offset: 0x2CD241 VA: 0x2CD140
	// RVA: 0x2D7E440 Offset: 0x2D7E541 VA: 0x2D7E440 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2D7E450 Offset: 0x2D7E551 VA: 0x2D7E450 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD150 Offset: 0x2CD251 VA: 0x2CD150
	// RVA: 0x2D7E5D0 Offset: 0x2D7E6D1 VA: 0x2D7E5D0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD160 Offset: 0x2CD261 VA: 0x2CD160
	// RVA: 0x2D7E5E0 Offset: 0x2D7E6E1 VA: 0x2D7E5E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x2CD170 Offset: 0x2CD271 VA: 0x2CD170
	// RVA: 0x2D7E620 Offset: 0x2D7E721 VA: 0x2D7E620 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
private class VersusSequence.VersusSequenceNet.SelectReplaySequence : ProcInst // TypeDefIndex: 13718
{
	// Fields
	private VersusSequence.VersusSequenceNet.SelectReplaySequence.Callback m_Callback; // 0x70
	private NexVersus.ReplaySlotMetaResultData m_ResultData; // 0x78

	// Methods

	// RVA: 0x2D6F8F0 Offset: 0x2D6F9F1 VA: 0x2D6F8F0
	private void .ctor(VersusSequence.VersusSequenceNet.SelectReplaySequence.Callback callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x2CD0C0 Offset: 0x2CD1C1 VA: 0x2CD0C0
	// RVA: 0x2D6F980 Offset: 0x2D6FA81 VA: 0x2D6F980
	private IEnumerator GetReplaySlots() { }

	// RVA: 0x2D6FA30 Offset: 0x2D6FB31 VA: 0x2D6FA30
	private void SortMetaData() { }

	// RVA: 0x2D6FCF0 Offset: 0x2D6FDF1 VA: 0x2D6FCF0
	private void Error() { }

	// RVA: 0x2D6FD20 Offset: 0x2D6FE21 VA: 0x2D6FD20
	private void OpenSelectMenu() { }

	// RVA: 0x2D6FF40 Offset: 0x2D70041 VA: 0x2D6FF40
	public static void CreateBind(ProcInst super, VersusSequence.VersusSequenceNet.SelectReplaySequence.Callback callback) { }

	// RVA: 0x2D70400 Offset: 0x2D70501 VA: 0x2D70400
	public static void CreateSelectBind(ProcInst super, VersusSequence.VersusSequenceNet.SelectReplaySequence.Callback callback) { }
}

// Namespace: 
public enum VersusSequence.VersusSequenceNet.DownloadMetaFromDataCodeSequence.DataType // TypeDefIndex: 13719
{
	// Fields
	public int value__; // 0x0
	public const VersusSequence.VersusSequenceNet.DownloadMetaFromDataCodeSequence.DataType Casual = 0;
	public const VersusSequence.VersusSequenceNet.DownloadMetaFromDataCodeSequence.DataType Ranked = 1;
}

// Namespace: 
private class VersusSequence.VersusSequenceNet.DownloadMetaFromDataCodeSequence : ProcInst // TypeDefIndex: 13720
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x29C910 Offset: 0x29CA11 VA: 0x29C910
	private static bool <IsSucceed>k__BackingField; // 0x0
	private ulong m_DataId; // 0x70
	private VersusSequence.VersusSequenceNet.DownloadMetaFromDataCodeSequence.DataType m_DataType; // 0x78

	// Properties
	public static bool IsSucceed { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CD180 Offset: 0x2CD281 VA: 0x2CD180
	// RVA: 0x2D6F0D0 Offset: 0x2D6F1D1 VA: 0x2D6F0D0
	public static bool get_IsSucceed() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CD190 Offset: 0x2CD291 VA: 0x2CD190
	// RVA: 0x2D6F140 Offset: 0x2D6F241 VA: 0x2D6F140
	private static void set_IsSucceed(bool value) { }

	// RVA: 0x2D6F1C0 Offset: 0x2D6F2C1 VA: 0x2D6F1C0
	private void .ctor(ulong dataId, VersusSequence.VersusSequenceNet.DownloadMetaFromDataCodeSequence.DataType dataType) { }

	// RVA: 0x2D6F200 Offset: 0x2D6F301 VA: 0x2D6F200
	private void Download() { }

	// RVA: 0x2D6F2F0 Offset: 0x2D6F3F1 VA: 0x2D6F2F0
	private void SetVersus() { }

	// RVA: 0x2D6F6A0 Offset: 0x2D6F7A1 VA: 0x2D6F6A0
	public static void CreateBind(ProcInst super, ulong dataId, VersusSequence.VersusSequenceNet.DownloadMetaFromDataCodeSequence.DataType dataType) { }

	// RVA: 0x2D6F8E0 Offset: 0x2D6F9E1 VA: 0x2D6F8E0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGeneratedAttribute] // RVA: 0x279250 Offset: 0x279351 VA: 0x279250
[Serializable]
private sealed class VersusSequence.VersusSequenceNet.<>c // TypeDefIndex: 13721
{
	// Fields
	public static readonly VersusSequence.VersusSequenceNet.<>c <>9; // 0x0
	public static NexVersus.CasualMetaDataEndCallback <>9__30_0; // 0x8
	public static NexVersus.RankedMetaDataEndCallback <>9__30_1; // 0x10

	// Methods

	// RVA: 0x2D6EF30 Offset: 0x2D6F031 VA: 0x2D6EF30
	private static void .cctor() { }

	// RVA: 0x2D6EFA0 Offset: 0x2D6F0A1 VA: 0x2D6EFA0
	public void .ctor() { }

	// RVA: 0x2D6EFB0 Offset: 0x2D6F0B1 VA: 0x2D6EFB0
	internal void <DownloadMetaProfileImpl>b__30_0(NexVersus.Results result, VersusServerCasualMetaData metaData, NexVersus.ResultInfo info) { }

	// RVA: 0x2D6F040 Offset: 0x2D6F141 VA: 0x2D6F040
	internal void <DownloadMetaProfileImpl>b__30_1(NexVersus.Results result, VersusServerRankedMetaData metaData, NexVersus.ResultInfo info) { }
}

// Namespace: 
private class VersusSequence.VersusSequenceNet : VersusSequence.VersusSequenceBase<VersusSequence.VersusSequenceNet> // TypeDefIndex: 13722
{
	// Methods

	// RVA: 0x1DB56F0 Offset: 0x1DB57F1 VA: 0x1DB56F0 Slot: 26
	protected override void InitImpl() { }

	// RVA: 0x1DB57B0 Offset: 0x1DB58B1 VA: 0x1DB57B0 Slot: 27
	protected override void FinalImpl() { }

	// RVA: 0x1DB5870 Offset: 0x1DB5971 VA: 0x1DB5870 Slot: 28
	protected override bool IsFailedJumpToTopImpl() { }

	// RVA: 0x1DB5960 Offset: 0x1DB5A61 VA: 0x1DB5960 Slot: 29
	protected override bool IsReportedEditMapImpl() { }

	// RVA: 0x1DB5B30 Offset: 0x1DB5C31 VA: 0x1DB5B30 Slot: 30
	protected override void UploadReportDataImpl() { }

	// RVA: 0x1DB5C60 Offset: 0x1DB5D61 VA: 0x1DB5C60
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x1DB5CE0 Offset: 0x1DB5DE1 VA: 0x1DB5CE0
	public static void CreateBindUploadEditData(ProcInst super) { }

	// RVA: 0x1DB5D60 Offset: 0x1DB5E61 VA: 0x1DB5D60
	public static void CreateBindUploadCasualData(ProcInst super) { }

	// RVA: 0x1DB5DE0 Offset: 0x1DB5EE1 VA: 0x1DB5DE0 Slot: 31
	protected override void GetMyCasualMetaDataImpl() { }

	// RVA: 0x1DB5E70 Offset: 0x1DB5F71 VA: 0x1DB5E70 Slot: 32
	protected override void PostGetMyCasualMetaDataImpl() { }

	// RVA: 0x1DB6020 Offset: 0x1DB6121 VA: 0x1DB6020 Slot: 33
	protected override void GetEditMetaDataImpl() { }

	// RVA: 0x1DB60B0 Offset: 0x1DB61B1 VA: 0x1DB60B0 Slot: 34
	protected override void PostGetEditMetaDataImpl() { }

	// RVA: 0x1DB61D0 Offset: 0x1DB62D1 VA: 0x1DB61D0 Slot: 35
	protected override void UpdateRateImpl() { }

	// RVA: 0x1DB6320 Offset: 0x1DB6421 VA: 0x1DB6320 Slot: 36
	protected override void SetRankedInfoImpl() { }

	// RVA: 0x1DB6450 Offset: 0x1DB6551 VA: 0x1DB6450 Slot: 63
	protected override void UploadEditDataImpl() { }

	// RVA: 0x1DB6460 Offset: 0x1DB6561 VA: 0x1DB6460 Slot: 64
	protected override void PostUploadEditDataImpl() { }

	// RVA: 0x1DB6560 Offset: 0x1DB6661 VA: 0x1DB6560 Slot: 53
	protected override void UploadReplayImpl() { }

	// RVA: 0x1DB6620 Offset: 0x1DB6721 VA: 0x1DB6620 Slot: 54
	protected override void UploadCasualImpl() { }

	// RVA: 0x1DB6730 Offset: 0x1DB6831 VA: 0x1DB6730 Slot: 55
	protected override void ChangeCasualImpl() { }

	// RVA: 0x1DB6830 Offset: 0x1DB6931 VA: 0x1DB6830 Slot: 37
	protected override void SearchSameRateImpl() { }

	// RVA: 0x1DB6900 Offset: 0x1DB6A01 VA: 0x1DB6900 Slot: 38
	protected override void SearchRankedFriendImpl() { }

	// RVA: 0x1DB6A40 Offset: 0x1DB6B41 VA: 0x1DB6A40 Slot: 39
	protected override void ExcludeMySearchRankedData() { }

	// RVA: 0x1DB6B80 Offset: 0x1DB6C81 VA: 0x1DB6B80 Slot: 40
	protected override void SearchCasualImpl() { }

	// RVA: 0x1DB6C10 Offset: 0x1DB6D11 VA: 0x1DB6C10 Slot: 41
	protected override void SearchCasualFriendImpl() { }

	// RVA: 0x1DB6D00 Offset: 0x1DB6E01 VA: 0x1DB6D00 Slot: 42
	protected override void ExcludeMySearchCasualData(List<VersusServerCasualMetaData> dataList) { }

	// RVA: 0x1DB6E30 Offset: 0x1DB6F31 VA: 0x1DB6E30 Slot: 51
	protected override void DownloadImpl() { }

	// RVA: 0x1DB6F30 Offset: 0x1DB7031 VA: 0x1DB6F30 Slot: 52
	protected override void DownloadMyEditImpl() { }

	// RVA: 0x1DB7040 Offset: 0x1DB7141 VA: 0x1DB7040 Slot: 43
	protected override void DownloadMetaCasualFromDataCodeImpl() { }

	// RVA: 0x1DB7110 Offset: 0x1DB7211 VA: 0x1DB7110 Slot: 44
	protected override void DownloadMetaRankedFromDataCodeImpl() { }

	// RVA: 0x1DB71E0 Offset: 0x1DB72E1 VA: 0x1DB71E0 Slot: 45
	protected override void CheckAccessibleProfileImpl(Versus.Mode mode, NexVersus.TargetSlotList targetSlotList) { }

	// RVA: 0x1DB72F0 Offset: 0x1DB73F1 VA: 0x1DB72F0 Slot: 46
	protected override void DownloadMetaProfileImpl(Versus.Mode mode, ProfileCard profile) { }

	// RVA: 0x1DB7670 Offset: 0x1DB7771 VA: 0x1DB7670 Slot: 50
	protected override void DownloadCasualImpl() { }

	// RVA: 0x1DB7770 Offset: 0x1DB7871 VA: 0x1DB7770 Slot: 47
	protected override void SelectReplayImpl() { }

	// RVA: 0x1DB7800 Offset: 0x1DB7901 VA: 0x1DB7800 Slot: 48
	protected override void DownloadReplayImpl() { }

	// RVA: 0x1DB7970 Offset: 0x1DB7A71 VA: 0x1DB7970 Slot: 49
	protected override void ChangeReplayMetaImpl() { }

	// RVA: 0x1DB7A10 Offset: 0x1DB7B11 VA: 0x1DB7A10 Slot: 65
	protected override bool GetLastUploadedResultImpl() { }

	// RVA: 0x1DB7A90 Offset: 0x1DB7B91 VA: 0x1DB7A90 Slot: 56
	protected override VersusServerRankedMetaData GetDownloadedEditMetaDataImpl() { }

	// RVA: 0x1DB7B10 Offset: 0x1DB7C11 VA: 0x1DB7B10 Slot: 57
	protected override void ChangeRankedMetaDataImpl(VersusServerRankedMetaData metaData) { }

	// RVA: 0x1DB7BB0 Offset: 0x1DB7CB1 VA: 0x1DB7BB0 Slot: 58
	protected override void ChangeDataTypeImpl(ulong dataId, ushort dataType) { }

	// RVA: 0x1DB7C50 Offset: 0x1DB7D51 VA: 0x1DB7C50 Slot: 62
	protected override void InitEditDataImpl() { }

	// RVA: 0x1DB7C60 Offset: 0x1DB7D61 VA: 0x1DB7C60 Slot: 59
	protected override void CheckParentalControlImpl() { }

	// RVA: 0x1DB7CD0 Offset: 0x1DB7DD1 VA: 0x1DB7CD0 Slot: 60
	protected override bool IsParentalControlAvailableImpl() { }

	// RVA: 0x1DB7D90 Offset: 0x1DB7E91 VA: 0x1DB7D90 Slot: 61
	protected override void EndParentalControlImpl() { }

	// RVA: 0x1DB7E00 Offset: 0x1DB7F01 VA: 0x1DB7E00
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CCE30 Offset: 0x2CCF31 VA: 0x2CCE30
	// RVA: 0x1DB7E80 Offset: 0x1DB7F81 VA: 0x1DB7E80
	private void <SelectReplayImpl>b__32_0(NexVersus.Results result, VersusServerReplayMetaData metaData) { }
}

