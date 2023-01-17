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

