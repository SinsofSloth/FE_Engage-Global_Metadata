// Namespace: App
public class HubAccessoryRoom : ProcSceneSequence<HubAccessoryRoom> // TypeDefIndex: 10656
{
	// Fields
	private List<GameObject> _DisableList; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x293340 Offset: 0x293441 VA: 0x293340
	private readonly string <ReturnSceneName>k__BackingField; // 0x90
	private HubAccessoryRoom.Shop m_Shop; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x293350 Offset: 0x293451 VA: 0x293350
	private HubAccessoryRoomCamera <CameraPos>k__BackingField; // 0xA0
	private int m_LastResultHash; // 0xA8
	private Character m_Character; // 0xB0
	private CharacterAppearance m_LoadingAppearance; // 0xB8
	private Character m_LoadingChara; // 0xC0
	private string m_LastPID; // 0xC8

	// Properties
	public override string SceneName { get; }
	private string ReturnSceneName { get; }
	private HubAccessoryRoomCamera CameraPos { get; set; }

	// Methods

	// RVA: 0x26738B0 Offset: 0x26739B1 VA: 0x26738B0 Slot: 22
	public override string get_SceneName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C03A0 Offset: 0x2C04A1 VA: 0x2C03A0
	// RVA: 0x2673900 Offset: 0x2673A01 VA: 0x2673900
	private string get_ReturnSceneName() { }

	// RVA: 0x2673910 Offset: 0x2673A11 VA: 0x2673910
	public static void SetUnit(Unit baseUnit, AccessoryData accessoryData, bool isDelayLoad = True, bool isAmiibo = False) { }

	// RVA: 0x2673DE0 Offset: 0x2673EE1 VA: 0x2673DE0
	public static void SetViewMode(HubAccessoryRoom.ViewMode position) { }

	// RVA: 0x2673EC0 Offset: 0x2673FC1 VA: 0x2673EC0
	public void .ctor(HubAccessoryRoom.Shop shop) { }

	// RVA: 0x2673FA0 Offset: 0x26740A1 VA: 0x2673FA0
	private void AdditiveScene() { }

	// RVA: 0x2674180 Offset: 0x2674281 VA: 0x2674180
	private void OpenTitle() { }

	// RVA: 0x2674360 Offset: 0x2674461 VA: 0x2674360
	private void Init() { }

	// RVA: 0x26744F0 Offset: 0x26745F1 VA: 0x26744F0
	private void UnAdditiveScene() { }

	// RVA: 0x2674560 Offset: 0x2674661 VA: 0x2674560
	private void Exit() { }

	// RVA: 0x2674950 Offset: 0x2674A51 VA: 0x2674950
	private void ExitOther() { }

	// RVA: 0x26749F0 Offset: 0x2674AF1 VA: 0x26749F0
	private void ExitAfter() { }

	// RVA: 0x2674A80 Offset: 0x2674B81 VA: 0x2674A80
	private bool IsCharacterLoading() { }

	// RVA: 0x2674B80 Offset: 0x2674C81 VA: 0x2674B80
	private void Main() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C03B0 Offset: 0x2C04B1 VA: 0x2C03B0
	// RVA: 0x2674BA0 Offset: 0x2674CA1 VA: 0x2674BA0
	private HubAccessoryRoomCamera get_CameraPos() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C03C0 Offset: 0x2C04C1 VA: 0x2C03C0
	// RVA: 0x2674BB0 Offset: 0x2674CB1 VA: 0x2674BB0
	private void set_CameraPos(HubAccessoryRoomCamera value) { }

	// RVA: 0x2673B00 Offset: 0x2673C01 VA: 0x2673B00
	private void SetUnitCore(Unit unit, Nullable<AccessoryData.Kinds> target, bool isDelayLoad) { }

	// RVA: 0x2674D30 Offset: 0x2674E31 VA: 0x2674D30
	private void LoadCharacter(CharacterAppearance appearance, string pid) { }

	// RVA: 0x2674BC0 Offset: 0x2674CC1 VA: 0x2674BC0
	private void DestroyCurrentChar() { }

	// RVA: 0x2673EB0 Offset: 0x2673FB1 VA: 0x2673EB0
	private void SetViewModeCore(HubAccessoryRoom.ViewMode mode) { }

	// RVA: 0x2674E70 Offset: 0x2674F71 VA: 0x2674E70 Slot: 15
	protected override void OnShutdown() { }

	// RVA: 0x2674EE0 Offset: 0x2674FE1 VA: 0x2674EE0
	public static void CreateBind(ProcInst super, HubAccessoryRoom.Shop shop = 0) { }
}

