// Namespace: App
internal class HubPlayTalkAfter : SingletonProcInst<HubPlayTalkAfter> // TypeDefIndex: 10772
{
	// Fields
	private const string cMenuPartsPath = "UI/Hub/Fishing/Prefabs/TopMenuRoot";
	private const string cFishingTextureAtlasPath = "UI/Hub/Fishing/Textures/Fishing";
	private const string MuscleMainPID = "PID_アルフレッド";
	private const string FleaMarketMainPID = "PID_ミスティラ";
	private const string FishingMainPID = "PID_ディアマンド";
	private const string DragonRideMainPID = "PID_アイビー";
	[CompilerGeneratedAttribute] // RVA: 0x295010 Offset: 0x295111 VA: 0x295010
	private GameObject <CurrentPersonLocator>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x295020 Offset: 0x295121 VA: 0x295020
	private HubUnitController <ChangeUnit>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x295030 Offset: 0x295131 VA: 0x295030
	private HubAccess <Access>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x295040 Offset: 0x295141 VA: 0x295040
	private bool <CanAdd>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x295050 Offset: 0x295151 VA: 0x295050
	private int <Value>k__BackingField; // 0x94
	[CompilerGeneratedAttribute] // RVA: 0x295060 Offset: 0x295161 VA: 0x295060
	private Unit <TargetUnit>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x295070 Offset: 0x295171 VA: 0x295070
	private RelianceData.Level <Level>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x295080 Offset: 0x295181 VA: 0x295080
	private string <Other>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x295090 Offset: 0x295191 VA: 0x295090
	private string <ChangePersonPID>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x2950A0 Offset: 0x2951A1 VA: 0x2950A0
	private bool <IsChangePerson>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x2950B0 Offset: 0x2951B1 VA: 0x2950B0
	private int <PrevGodLevel>k__BackingField; // 0xBC
	private ReliancePopUpController m_ReliancePopUp; // 0xC0

	// Properties
	private static bool IsExistGift { get; }
	public GameObject CurrentPersonLocator { get; set; }
	public HubUnitController ChangeUnit { get; set; }
	public HubAccess Access { get; set; }
	public bool CanAdd { get; set; }
	public int Value { get; set; }
	public Unit TargetUnit { get; set; }
	public RelianceData.Level Level { get; set; }
	public string Other { get; set; }
	public string ChangePersonPID { get; set; }
	public bool IsChangePerson { get; set; }
	public int PrevGodLevel { get; set; }

	// Methods

	// RVA: 0x28B7AA0 Offset: 0x28B7BA1 VA: 0x28B7AA0
	private static bool get_IsExistGift() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0E70 Offset: 0x2C0F71 VA: 0x2C0E70
	// RVA: 0x28B7BC0 Offset: 0x28B7CC1 VA: 0x28B7BC0
	public GameObject get_CurrentPersonLocator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0E80 Offset: 0x2C0F81 VA: 0x2C0E80
	// RVA: 0x28B7BD0 Offset: 0x28B7CD1 VA: 0x28B7BD0
	public void set_CurrentPersonLocator(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0E90 Offset: 0x2C0F91 VA: 0x2C0E90
	// RVA: 0x28B7BE0 Offset: 0x28B7CE1 VA: 0x28B7BE0
	public HubUnitController get_ChangeUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0EA0 Offset: 0x2C0FA1 VA: 0x2C0EA0
	// RVA: 0x28B7BF0 Offset: 0x28B7CF1 VA: 0x28B7BF0
	public void set_ChangeUnit(HubUnitController value) { }

	// RVA: 0x28B7C00 Offset: 0x28B7D01 VA: 0x28B7C00
	private void EndExercise() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0EB0 Offset: 0x2C0FB1 VA: 0x2C0EB0
	// RVA: 0x28B7D20 Offset: 0x28B7E21 VA: 0x28B7D20
	public HubAccess get_Access() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0EC0 Offset: 0x2C0FC1 VA: 0x2C0EC0
	// RVA: 0x28B7D30 Offset: 0x28B7E31 VA: 0x28B7D30
	public void set_Access(HubAccess value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0ED0 Offset: 0x2C0FD1 VA: 0x2C0ED0
	// RVA: 0x28B7D40 Offset: 0x28B7E41 VA: 0x28B7D40
	public bool get_CanAdd() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0EE0 Offset: 0x2C0FE1 VA: 0x2C0EE0
	// RVA: 0x28B7D50 Offset: 0x28B7E51 VA: 0x28B7D50
	public void set_CanAdd(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0EF0 Offset: 0x2C0FF1 VA: 0x2C0EF0
	// RVA: 0x28B7D60 Offset: 0x28B7E61 VA: 0x28B7D60
	public int get_Value() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0F00 Offset: 0x2C1001 VA: 0x2C0F00
	// RVA: 0x28B7D70 Offset: 0x28B7E71 VA: 0x28B7D70
	public void set_Value(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0F10 Offset: 0x2C1011 VA: 0x2C0F10
	// RVA: 0x28B7D80 Offset: 0x28B7E81 VA: 0x28B7D80
	public Unit get_TargetUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0F20 Offset: 0x2C1021 VA: 0x2C0F20
	// RVA: 0x28B7D90 Offset: 0x28B7E91 VA: 0x28B7D90
	public void set_TargetUnit(Unit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0F30 Offset: 0x2C1031 VA: 0x2C0F30
	// RVA: 0x28B7DA0 Offset: 0x28B7EA1 VA: 0x28B7DA0
	public RelianceData.Level get_Level() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0F40 Offset: 0x2C1041 VA: 0x2C0F40
	// RVA: 0x28B7DB0 Offset: 0x28B7EB1 VA: 0x28B7DB0
	public void set_Level(RelianceData.Level value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0F50 Offset: 0x2C1051 VA: 0x2C0F50
	// RVA: 0x28B7DC0 Offset: 0x28B7EC1 VA: 0x28B7DC0
	public string get_Other() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0F60 Offset: 0x2C1061 VA: 0x2C0F60
	// RVA: 0x28B7DD0 Offset: 0x28B7ED1 VA: 0x28B7DD0
	public void set_Other(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0F70 Offset: 0x2C1071 VA: 0x2C0F70
	// RVA: 0x28B7DE0 Offset: 0x28B7EE1 VA: 0x28B7DE0
	public string get_ChangePersonPID() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0F80 Offset: 0x2C1081 VA: 0x2C0F80
	// RVA: 0x28B7DF0 Offset: 0x28B7EF1 VA: 0x28B7DF0
	public void set_ChangePersonPID(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0F90 Offset: 0x2C1091 VA: 0x2C0F90
	// RVA: 0x28B7E00 Offset: 0x28B7F01 VA: 0x28B7E00
	public bool get_IsChangePerson() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0FA0 Offset: 0x2C10A1 VA: 0x2C0FA0
	// RVA: 0x28B7E10 Offset: 0x28B7F11 VA: 0x28B7E10
	public void set_IsChangePerson(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0FB0 Offset: 0x2C10B1 VA: 0x2C0FB0
	// RVA: 0x28B7E20 Offset: 0x28B7F21 VA: 0x28B7E20
	public int get_PrevGodLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0FC0 Offset: 0x2C10C1 VA: 0x2C0FC0
	// RVA: 0x28B7E30 Offset: 0x28B7F31 VA: 0x28B7E30
	public void set_PrevGodLevel(int value) { }

	// RVA: 0x28B7E40 Offset: 0x28B7F41 VA: 0x28B7E40
	public void .ctor(HubAccess access) { }

	// RVA: 0x28B7F10 Offset: 0x28B8011 VA: 0x28B7F10
	private GodUnit TryGetGodUnit(string gid) { }

	// RVA: 0x28B7F20 Offset: 0x28B8021 VA: 0x28B7F20
	private void CreateBindSelectMenu() { }

	// RVA: 0x28B7FA0 Offset: 0x28B80A1 VA: 0x28B7FA0
	private void CreateBindSelectGift() { }

	// RVA: 0x28B8030 Offset: 0x28B8131 VA: 0x28B8030
	private string GetGiftMessage() { }

	// RVA: 0x28B8230 Offset: 0x28B8331 VA: 0x28B8230
	private void StartReactionGift() { }

	// RVA: 0x28B8340 Offset: 0x28B8441 VA: 0x28B8340
	private void EndReactionGift() { }

	// RVA: 0x28B83F0 Offset: 0x28B84F1 VA: 0x28B83F0
	private void Init() { }

	// RVA: 0x28B8760 Offset: 0x28B8861 VA: 0x28B8760
	private void ExitPhase1() { }

	// RVA: 0x28B87E0 Offset: 0x28B88E1 VA: 0x28B87E0
	private void ExitPhase2() { }

	// RVA: 0x28B8B60 Offset: 0x28B8C61 VA: 0x28B8B60
	private void StartReliance() { }

	// RVA: 0x28B8DA0 Offset: 0x28B8EA1 VA: 0x28B8DA0
	private void MainReliance() { }

	// RVA: 0x28B9250 Offset: 0x28B9351 VA: 0x28B9250
	private void ExitReliance() { }

	// RVA: 0x28B9310 Offset: 0x28B9411 VA: 0x28B9310
	private void UpdateAchive(Unit a, Unit b, RelianceData.Level level) { }

	// RVA: 0x28B9480 Offset: 0x28B9581 VA: 0x28B9480
	private void LevelUpReliance() { }

	// RVA: 0x28B98D0 Offset: 0x28B99D1 VA: 0x28B98D0
	private void EndReliance() { }

	// RVA: 0x28B9BA0 Offset: 0x28B9CA1 VA: 0x28B9BA0
	private void EndRelianceAfter() { }

	// RVA: 0x28B8E30 Offset: 0x28B8F31 VA: 0x28B8E30
	public void StartReliance_God(string gid) { }

	// RVA: 0x28B8FE0 Offset: 0x28B90E1 VA: 0x28B8FE0
	private void StartReliance_Unit(string pid, string other) { }

	// RVA: 0x28B9D70 Offset: 0x28B9E71 VA: 0x28B9D70
	private void StartDragonRide() { }

	// RVA: 0x28B9D80 Offset: 0x28B9E81 VA: 0x28B9D80
	private void CreateFleaMarket() { }

	// RVA: 0x28B9DF0 Offset: 0x28B9EF1 VA: 0x28B9DF0
	private void CreateFortuneTelling() { }

	// RVA: 0x28B2980 Offset: 0x28B2A81 VA: 0x28B2980
	public static ProcInst CreateBind(ProcInst super, HubAccess access) { }
}

