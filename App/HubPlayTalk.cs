// Namespace: App
internal class HubPlayTalk : ProcInst // TypeDefIndex: 10753
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x294F80 Offset: 0x295081 VA: 0x294F80
	private HubPlayerController <PlayerController>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x294F90 Offset: 0x295091 VA: 0x294F90
	private HubUnitController <Player>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x294FA0 Offset: 0x2950A1 VA: 0x294FA0
	private List<HubUnitController> <Other>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x294FB0 Offset: 0x2950B1 VA: 0x294FB0
	private HubCamera <Camera>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x294FC0 Offset: 0x2950C1 VA: 0x294FC0
	private HubAccess <Access>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x294FD0 Offset: 0x2950D1 VA: 0x294FD0
	private string <MID>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x294FE0 Offset: 0x2950E1 VA: 0x294FE0
	private string <Args>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x294FF0 Offset: 0x2950F1 VA: 0x294FF0
	private bool <PieceOfBond_Tutorial>k__BackingField; // 0xA8
	private const string GiveAccessoryFlag1 = "G_拠点_アクセ屋_DLC特典1受け取り済み";
	private const string GiveAccessoryFlag2 = "G_拠点_アクセ屋_DLC特典2受け取り済み";
	[CompilerGeneratedAttribute] // RVA: 0x295000 Offset: 0x295101 VA: 0x295000
	private string <WellTutorial>k__BackingField; // 0xB0

	// Properties
	private HubPlayerController PlayerController { get; set; }
	private HubUnitController Player { get; set; }
	private List<HubUnitController> Other { get; set; }
	private HubCamera Camera { get; set; }
	private HubAccess Access { get; set; }
	private string MID { get; set; }
	private string Args { get; set; }
	private string FlagName { get; }
	private bool PieceOfBond_Tutorial { get; set; }
	private string WellTutorial { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C0D30 Offset: 0x2C0E31 VA: 0x2C0D30
	// RVA: 0x28B0420 Offset: 0x28B0521 VA: 0x28B0420
	private HubPlayerController get_PlayerController() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0D40 Offset: 0x2C0E41 VA: 0x2C0D40
	// RVA: 0x28B0430 Offset: 0x28B0531 VA: 0x28B0430
	private void set_PlayerController(HubPlayerController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0D50 Offset: 0x2C0E51 VA: 0x2C0D50
	// RVA: 0x28B0440 Offset: 0x28B0541 VA: 0x28B0440
	private HubUnitController get_Player() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0D60 Offset: 0x2C0E61 VA: 0x2C0D60
	// RVA: 0x28B0450 Offset: 0x28B0551 VA: 0x28B0450
	private void set_Player(HubUnitController value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0D70 Offset: 0x2C0E71 VA: 0x2C0D70
	// RVA: 0x28B0460 Offset: 0x28B0561 VA: 0x28B0460
	private List<HubUnitController> get_Other() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0D80 Offset: 0x2C0E81 VA: 0x2C0D80
	// RVA: 0x28B0470 Offset: 0x28B0571 VA: 0x28B0470
	private void set_Other(List<HubUnitController> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0D90 Offset: 0x2C0E91 VA: 0x2C0D90
	// RVA: 0x28B0480 Offset: 0x28B0581 VA: 0x28B0480
	private HubCamera get_Camera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0DA0 Offset: 0x2C0EA1 VA: 0x2C0DA0
	// RVA: 0x28B0490 Offset: 0x28B0591 VA: 0x28B0490
	private void set_Camera(HubCamera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0DB0 Offset: 0x2C0EB1 VA: 0x2C0DB0
	// RVA: 0x28B04A0 Offset: 0x28B05A1 VA: 0x28B04A0
	private HubAccess get_Access() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0DC0 Offset: 0x2C0EC1 VA: 0x2C0DC0
	// RVA: 0x28B04B0 Offset: 0x28B05B1 VA: 0x28B04B0
	private void set_Access(HubAccess value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0DD0 Offset: 0x2C0ED1 VA: 0x2C0DD0
	// RVA: 0x28B04C0 Offset: 0x28B05C1 VA: 0x28B04C0
	private string get_MID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0DE0 Offset: 0x2C0EE1 VA: 0x2C0DE0
	// RVA: 0x28B04D0 Offset: 0x28B05D1 VA: 0x28B04D0
	private void set_MID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0DF0 Offset: 0x2C0EF1 VA: 0x2C0DF0
	// RVA: 0x28B04E0 Offset: 0x28B05E1 VA: 0x28B04E0
	private string get_Args() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0E00 Offset: 0x2C0F01 VA: 0x2C0E00
	// RVA: 0x28B04F0 Offset: 0x28B05F1 VA: 0x28B04F0
	private void set_Args(string value) { }

	// RVA: 0x28B0500 Offset: 0x28B0601 VA: 0x28B0500
	private string get_FlagName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0E10 Offset: 0x2C0F11 VA: 0x2C0E10
	// RVA: 0x28B0560 Offset: 0x28B0661 VA: 0x28B0560
	private bool get_PieceOfBond_Tutorial() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0E20 Offset: 0x2C0F21 VA: 0x2C0E20
	// RVA: 0x28B0570 Offset: 0x28B0671 VA: 0x28B0570
	private void set_PieceOfBond_Tutorial(bool value) { }

	// RVA: 0x28B0580 Offset: 0x28B0681 VA: 0x28B0580
	private void .ctor(HubPlayerController player, HubCamera camera, HubAccess access) { }

	// RVA: 0x28B06E0 Offset: 0x28B07E1 VA: 0x28B06E0
	private void .ctor(HubPlayerController player, HubCamera camera, HubAccess access, string mid, string args) { }

	// RVA: 0x28B0820 Offset: 0x28B0921 VA: 0x28B0820
	private void Init() { }

	// RVA: 0x28B0D20 Offset: 0x28B0E21 VA: 0x28B0D20
	private bool IsPlayerMove() { }

	// RVA: 0x28B0D50 Offset: 0x28B0E51 VA: 0x28B0D50
	private Vector3 GetOtherPosition() { }

	// RVA: 0x28B0F20 Offset: 0x28B1021 VA: 0x28B0F20
	private Vector3 GetOtherHeadPosition() { }

	// RVA: 0x28B10E0 Offset: 0x28B11E1 VA: 0x28B10E0
	private static string GetMessPID(string mid) { }

	// RVA: 0x28B0B30 Offset: 0x28B0C31 VA: 0x28B0B30
	private static List<string> GetMessPIDList(string mid) { }

	// RVA: 0x28B1280 Offset: 0x28B1381 VA: 0x28B1280
	private void SetupNormal() { }

	// RVA: 0x28B1570 Offset: 0x28B1671 VA: 0x28B1570
	private void Tutorial() { }

	// RVA: 0x28B19A0 Offset: 0x28B1AA1 VA: 0x28B19A0
	private void SetupShop() { }

	// RVA: 0x28B1D80 Offset: 0x28B1E81 VA: 0x28B1D80
	private bool IsExistAdditionalStock(string shopType) { }

	// RVA: 0x28B1BC0 Offset: 0x28B1CC1 VA: 0x28B1BC0
	private void SetupShop(string mid) { }

	// RVA: 0x28B1EA0 Offset: 0x28B1FA1 VA: 0x28B1EA0
	private void SetupEvent() { }

	// RVA: 0x28B2050 Offset: 0x28B2151 VA: 0x28B2050
	private void ExecTalk() { }

	// RVA: 0x28B2200 Offset: 0x28B2301 VA: 0x28B2200
	private void ExecTalkPresent() { }

	// RVA: 0x28B25E0 Offset: 0x28B26E1 VA: 0x28B25E0
	private string GetFavoriteItem() { }

	// RVA: 0x28B2860 Offset: 0x28B2961 VA: 0x28B2860
	private void ExecTalkAfter() { }

	// RVA: 0x28B4760 Offset: 0x28B4861 VA: 0x28B4760
	private void TryJoinUnit(string pid) { }

	// RVA: 0x28B4640 Offset: 0x28B4741 VA: 0x28B4640
	private void JoinEvent() { }

	// RVA: 0x28B4830 Offset: 0x28B4931 VA: 0x28B4830
	private void ExecEvent() { }

	// RVA: 0x28B4E10 Offset: 0x28B4F11 VA: 0x28B4E10
	private void ExecEventAfter() { }

	// RVA: 0x28B4EA0 Offset: 0x28B4FA1 VA: 0x28B4EA0
	private void ExecShop() { }

	// RVA: 0x28B5330 Offset: 0x28B5431 VA: 0x28B5330
	private void ReturnTalk() { }

	// RVA: 0x28B5490 Offset: 0x28B5591 VA: 0x28B5490
	private void ReturnTalkEvent() { }

	// RVA: 0x28B56C0 Offset: 0x28B57C1 VA: 0x28B56C0
	private ProcDesc[] CreateDescNormal() { }

	// RVA: 0x28B5D30 Offset: 0x28B5E31 VA: 0x28B5D30
	private ProcDesc[] CreateDescShop() { }

	// RVA: 0x28B61E0 Offset: 0x28B62E1 VA: 0x28B61E0
	private ProcDesc[] CreateDescEvent() { }

	// RVA: 0x28B66C0 Offset: 0x28B67C1 VA: 0x28B66C0
	private ProcDesc[] CreateProcDesc(HubPlayTalk.TalkType talkType) { }

	// RVA: 0x28B66F0 Offset: 0x28B67F1 VA: 0x28B66F0
	public static void CreateBind(ProcInst super, HubPlayTalk.TalkType talkType, HubPlayerController player, HubCamera camera, HubAccess access) { }

	// RVA: 0x28B67D0 Offset: 0x28B68D1 VA: 0x28B67D0
	public static void CreateBind(ProcInst super, HubPlayTalk.TalkType talkType, HubPlayerController player, HubCamera camera, string mid, string script) { }

	// RVA: 0x28B68B0 Offset: 0x28B69B1 VA: 0x28B68B0
	public static void CreateShopBind(ProcInst super, HubPlayTalk.TalkType talkType, HubPlayerController player, HubCamera camera, HubAccess access, string shopType) { }

	// RVA: 0x28B69C0 Offset: 0x28B6AC1 VA: 0x28B69C0
	private void TrySilverCardMessage() { }

	// RVA: 0x28B6CE0 Offset: 0x28B6DE1 VA: 0x28B6CE0
	private void TryGiveAccessory(string[] aidTable, string mid) { }

	// RVA: 0x28B6F30 Offset: 0x28B7031 VA: 0x28B6F30
	private void TryGiveAccessory1() { }

	// RVA: 0x28B6F40 Offset: 0x28B7041 VA: 0x28B6F40
	private void TryGiveAccessory2() { }

	// RVA: 0x28B6F50 Offset: 0x28B7051 VA: 0x28B6F50
	private static bool CanGiveAccessory1() { }

	// RVA: 0x28B6F60 Offset: 0x28B7061 VA: 0x28B6F60
	private static bool CanGiveAccessory2() { }

	// RVA: 0x28B6F70 Offset: 0x28B7071 VA: 0x28B6F70
	private ProcDesc[] CreateDescGiveAccessory() { }

	// RVA: 0x28B73B0 Offset: 0x28B74B1 VA: 0x28B73B0
	public static bool TryCreateGiveAccessoryBind(ProcInst super, HubPlayerController player, HubCamera camera, HubAccess access, string mid) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0E30 Offset: 0x2C0F31 VA: 0x2C0E30
	// RVA: 0x28B74B0 Offset: 0x28B75B1 VA: 0x28B74B0
	private string get_WellTutorial() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0E40 Offset: 0x2C0F41 VA: 0x2C0E40
	// RVA: 0x28B74C0 Offset: 0x28B75C1 VA: 0x28B74C0
	private void set_WellTutorial(string value) { }

	// RVA: 0x28B74D0 Offset: 0x28B75D1 VA: 0x28B74D0
	private void TryWellTutorial() { }

	// RVA: 0x28B7560 Offset: 0x28B7661 VA: 0x28B7560
	private ProcDesc[] CreateDescShopTalk() { }

	// RVA: 0x28B7930 Offset: 0x28B7A31 VA: 0x28B7930
	public static void CreateShopTalkBind(ProcInst super, HubPlayerController player, HubCamera camera, HubAccess access, string mid, string tutorial) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0E50 Offset: 0x2C0F51 VA: 0x2C0E50
	// RVA: 0x28B7A10 Offset: 0x28B7B11 VA: 0x28B7A10
	private void <SetupNormal>b__44_0(HubUnitController o) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0E60 Offset: 0x2C0F61 VA: 0x2C0E60
	// RVA: 0x28B7A50 Offset: 0x28B7B51 VA: 0x28B7A50
	private void <SetupEvent>b__49_0(HubUnitController o) { }
}

