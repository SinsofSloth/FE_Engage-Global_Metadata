// Namespace: App
public class HubSequence : ProcSceneSequence<HubSequence> // TypeDefIndex: 10808
{
	// Fields
	private string m_ScriptFuncName; // 0x88
	private string m_FastTravelID; // 0x90
	private HubAccess m_TalkAccess; // 0x98
	private bool m_IsBackgroundBind; // 0xA0
	private bool m_IsKeyHelp; // 0xA1
	private bool m_IsCave; // 0xA2
	public string m_SceneName; // 0xA8
	public string m_StartName; // 0xB0
	private GameObject m_HubRoot; // 0xB8
	private GameObject m_HubEnv; // 0xC0
	private HubLocatorGroup m_HubLocatorGroup; // 0xC8
	private HubPlayerController m_HubPlayerController; // 0xD0
	private HubCamera m_HubCamera; // 0xD8
	private GameObject m_ButtonNavi; // 0xE0
	private GameObject m_DragonRideNode; // 0xE8
	private GameObject m_DragonRideEnv; // 0xF0
	private GameObject m_FishingNode; // 0xF8
	private GameObject m_Hologram; // 0x100
	private GameObject m_HubEffect; // 0x108
	private GameObject m_LensFlare; // 0x110
	private GameObject m_MyRoomAccObject; // 0x118
	private ResourceHandle m_MyRoomAcc; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x295140 Offset: 0x295241 VA: 0x295140
	private GameObject <MainCamera>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x295150 Offset: 0x295251 VA: 0x295150
	private HubMiniMap <MiniMap>k__BackingField; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x295160 Offset: 0x295261 VA: 0x295160
	private HubSequence.AreaString <NowArea>k__BackingField; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x295170 Offset: 0x295271 VA: 0x295170
	private HubFastTravel <FastTravel>k__BackingField; // 0x140
	[CompilerGeneratedAttribute] // RVA: 0x295180 Offset: 0x295281 VA: 0x295180
	private bool <ForceNonstopBGM>k__BackingField; // 0x148
	[CompilerGeneratedAttribute] // RVA: 0x295190 Offset: 0x295291 VA: 0x295190
	private List<HubAccessManager> <AccessData>k__BackingField; // 0x150
	private bool m_IsShutdown; // 0x158
	[CompilerGeneratedAttribute] // RVA: 0x2951A0 Offset: 0x2952A1 VA: 0x2951A0
	private bool <IsEnterEvent>k__BackingField; // 0x159
	private int m_numPieceOfBond; // 0x15C
	private List<GameObject> EndRollDisableList; // 0x160
	private string ArgConfirmMid; // 0x168
	private string ArgScriptName; // 0x170
	private string[] SolanelBgmList; // 0x178

	// Properties
	protected override LoadingManager.Modes LoadingMode { get; }
	public HubCamera Camera { get; }
	public HubPlayerController Player { get; }
	public GameObject Root { get; }
	public HubLocatorGroup LocatorGroup { get; }
	public GameObject MainCamera { get; set; }
	public HubMiniMap MiniMap { get; set; }
	public GameObject EnvRoot { get; }
	public HubSequence.AreaString NowArea { get; set; }
	public HubFastTravel FastTravel { get; set; }
	public bool ForceNonstopBGM { get; set; }
	public List<HubAccessManager> AccessData { get; set; }
	public HubAccessManager CurrentAccessData { get; }
	public HubAccessManager SolanelAccessData { get; }
	public bool IsEnterEvent { get; set; }
	public bool IsMain { get; }
	protected override int Version { get; }

	// Methods

	// RVA: 0x28C32F0 Offset: 0x28C33F1 VA: 0x28C32F0 Slot: 26
	protected override LoadingManager.Modes get_LoadingMode() { }

	// RVA: 0x28C3300 Offset: 0x28C3401 VA: 0x28C3300
	public HubCamera get_Camera() { }

	// RVA: 0x28C3310 Offset: 0x28C3411 VA: 0x28C3310
	public HubPlayerController get_Player() { }

	// RVA: 0x28C3320 Offset: 0x28C3421 VA: 0x28C3320
	public GameObject get_Root() { }

	// RVA: 0x28C3330 Offset: 0x28C3431 VA: 0x28C3330
	public HubLocatorGroup get_LocatorGroup() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1170 Offset: 0x2C1271 VA: 0x2C1170
	// RVA: 0x28C3340 Offset: 0x28C3441 VA: 0x28C3340
	public GameObject get_MainCamera() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1180 Offset: 0x2C1281 VA: 0x2C1180
	// RVA: 0x28C3350 Offset: 0x28C3451 VA: 0x28C3350
	public void set_MainCamera(GameObject value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1190 Offset: 0x2C1291 VA: 0x2C1190
	// RVA: 0x28C3360 Offset: 0x28C3461 VA: 0x28C3360
	public HubMiniMap get_MiniMap() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C11A0 Offset: 0x2C12A1 VA: 0x2C11A0
	// RVA: 0x28C3370 Offset: 0x28C3471 VA: 0x28C3370
	public void set_MiniMap(HubMiniMap value) { }

	// RVA: 0x28C3380 Offset: 0x28C3481 VA: 0x28C3380
	public GameObject get_EnvRoot() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C11B0 Offset: 0x2C12B1 VA: 0x2C11B0
	// RVA: 0x28C3390 Offset: 0x28C3491 VA: 0x28C3390
	public HubSequence.AreaString get_NowArea() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C11C0 Offset: 0x2C12C1 VA: 0x2C11C0
	// RVA: 0x28C33A0 Offset: 0x28C34A1 VA: 0x28C33A0
	public void set_NowArea(HubSequence.AreaString value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C11D0 Offset: 0x2C12D1 VA: 0x2C11D0
	// RVA: 0x28C33B0 Offset: 0x28C34B1 VA: 0x28C33B0
	public HubFastTravel get_FastTravel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C11E0 Offset: 0x2C12E1 VA: 0x2C11E0
	// RVA: 0x28C33C0 Offset: 0x28C34C1 VA: 0x28C33C0
	public void set_FastTravel(HubFastTravel value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C11F0 Offset: 0x2C12F1 VA: 0x2C11F0
	// RVA: 0x28C33D0 Offset: 0x28C34D1 VA: 0x28C33D0
	public bool get_ForceNonstopBGM() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1200 Offset: 0x2C1301 VA: 0x2C1200
	// RVA: 0x28C33E0 Offset: 0x28C34E1 VA: 0x28C33E0
	public void set_ForceNonstopBGM(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1210 Offset: 0x2C1311 VA: 0x2C1210
	// RVA: 0x28C33F0 Offset: 0x28C34F1 VA: 0x28C33F0
	public List<HubAccessManager> get_AccessData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1220 Offset: 0x2C1321 VA: 0x2C1220
	// RVA: 0x28C3400 Offset: 0x28C3501 VA: 0x28C3400
	public void set_AccessData(List<HubAccessManager> value) { }

	// RVA: 0x28C3410 Offset: 0x28C3511 VA: 0x28C3410
	public HubAccessManager get_CurrentAccessData() { }

	// RVA: 0x28C34F0 Offset: 0x28C35F1 VA: 0x28C34F0
	public HubAccessManager get_SolanelAccessData() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1230 Offset: 0x2C1331 VA: 0x2C1230
	// RVA: 0x28C35F0 Offset: 0x28C36F1 VA: 0x28C35F0
	public bool get_IsEnterEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C1240 Offset: 0x2C1341 VA: 0x2C1240
	// RVA: 0x28C3600 Offset: 0x28C3701 VA: 0x28C3600
	public void set_IsEnterEvent(bool value) { }

	// RVA: 0x28BE7A0 Offset: 0x28BE8A1 VA: 0x28BE7A0
	public bool get_IsMain() { }

	// RVA: 0x28C3610 Offset: 0x28C3711 VA: 0x28C3610 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x28C37B0 Offset: 0x28C38B1 VA: 0x28C37B0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x28C3820 Offset: 0x28C3921 VA: 0x28C3820
	private void Init() { }

	// RVA: 0x28C3D20 Offset: 0x28C3E21 VA: 0x28C3D20
	private bool IsResourceLoading() { }

	// RVA: 0x28C3DA0 Offset: 0x28C3EA1 VA: 0x28C3DA0
	private void InitAfterLoadScene() { }

	// RVA: 0x28C43F0 Offset: 0x28C44F1 VA: 0x28C43F0
	private void Unload() { }

	// RVA: 0x28C4600 Offset: 0x28C4701 VA: 0x28C4600
	private void Terminate() { }

	// RVA: 0x28C48F0 Offset: 0x28C49F1 VA: 0x28C48F0
	private void LoadHubScene() { }

	// RVA: 0x28C4A00 Offset: 0x28C4B01 VA: 0x28C4A00
	private void SetupDispos(string sceneName, HubUtil.TimezoneType timezoneType) { }

	// RVA: 0x28C4AB0 Offset: 0x28C4BB1 VA: 0x28C4AB0
	public void ResetDispos() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C1250 Offset: 0x2C1351 VA: 0x2C1250
	// RVA: 0x28C4B80 Offset: 0x28C4C81 VA: 0x28C4B80
	public IEnumerator SetupDispos() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C12C0 Offset: 0x2C13C1 VA: 0x2C12C0
	// RVA: 0x28C4C00 Offset: 0x28C4D01 VA: 0x28C4C00
	private IEnumerator SetupEnv() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C1330 Offset: 0x2C1431 VA: 0x2C1330
	// RVA: 0x28C4C80 Offset: 0x28C4D81 VA: 0x28C4C80
	private IEnumerator SetupPlayer() { }

	// RVA: 0x28C4D00 Offset: 0x28C4E01 VA: 0x28C4D00
	private void OpeningEvent() { }

	// RVA: 0x28C4D60 Offset: 0x28C4E61 VA: 0x28C4D60
	private void MapOpeningEvent() { }

	// RVA: 0x28C4DC0 Offset: 0x28C4EC1 VA: 0x28C4DC0
	private void PrepareEvent() { }

	// RVA: 0x28C4E20 Offset: 0x28C4F21 VA: 0x28C4E20
	private void KizunaExit() { }

	// RVA: 0x28C4EE0 Offset: 0x28C4FE1 VA: 0x28C4EE0
	private void KizunaExitTutorial() { }

	// RVA: 0x28C4F80 Offset: 0x28C5081 VA: 0x28C4F80
	private void MapEndingEvent() { }

	// RVA: 0x28C4FA0 Offset: 0x28C50A1 VA: 0x28C4FA0
	private void EndingEvent() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C13A0 Offset: 0x2C14A1 VA: 0x2C13A0
	// RVA: 0x28C4FC0 Offset: 0x28C50C1 VA: 0x28C4FC0
	public IEnumerator SetupAccess() { }

	// RVA: 0x28C5040 Offset: 0x28C5141 VA: 0x28C5040
	public void LoadAPlusGift(string aplusName) { }

	// RVA: 0x28C5350 Offset: 0x28C5451 VA: 0x28C5350
	private void InitAfterLoadChara() { }

	// RVA: 0x28C65C0 Offset: 0x28C66C1 VA: 0x28C65C0
	private void ArrangePlayerStartPosition() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C1410 Offset: 0x2C1511 VA: 0x2C1410
	// RVA: 0x28C67D0 Offset: 0x28C68D1 VA: 0x28C67D0
	private IEnumerator LoadMinimap() { }

	// RVA: 0x28C6850 Offset: 0x28C6951 VA: 0x28C6850
	private void CleanupUnitImpl() { }

	// RVA: 0x28C6860 Offset: 0x28C6961 VA: 0x28C6860
	public void CallShop(string shopType, HubAccess access) { }

	// RVA: 0x28C6940 Offset: 0x28C6A41 VA: 0x28C6940
	public static void CleanupUnit() { }

	// RVA: 0x28C6AB0 Offset: 0x28C6BB1 VA: 0x28C6AB0
	private void CreateDragonRideSequence() { }

	// RVA: 0x28C6AC0 Offset: 0x28C6BC1 VA: 0x28C6AC0
	private void CreateFishingSequence() { }

	// RVA: 0x28C6AD0 Offset: 0x28C6BD1 VA: 0x28C6AD0
	private void CreateMuscleExerciseSequence() { }

	// RVA: 0x28C6AF0 Offset: 0x28C6BF1 VA: 0x28C6AF0
	private void CreateFortuneTelling() { }

	// RVA: 0x28C6B00 Offset: 0x28C6C01 VA: 0x28C6B00
	private void EntrySignboard() { }

	// RVA: 0x28C6B10 Offset: 0x28C6C11 VA: 0x28C6B10
	private void CreateSignboard() { }

	// RVA: 0x28C6B20 Offset: 0x28C6C21 VA: 0x28C6B20
	private void ExitSignboard() { }

	// RVA: 0x28C6B40 Offset: 0x28C6C41 VA: 0x28C6B40
	private void CreateRestPlace() { }

	// RVA: 0x28C6B50 Offset: 0x28C6C51 VA: 0x28C6B50
	private void CreateChest() { }

	// RVA: 0x28C6B60 Offset: 0x28C6C61 VA: 0x28C6B60
	private void ConfirmEndRoll() { }

	// RVA: 0x28C6C60 Offset: 0x28C6D61 VA: 0x28C6C60
	private void EnterEndRoll() { }

	// RVA: 0x28C6CF0 Offset: 0x28C6DF1 VA: 0x28C6CF0
	private void CreateEndRoll() { }

	// RVA: 0x28C6EA0 Offset: 0x28C6FA1 VA: 0x28C6EA0
	private void ExitEndRoll() { }

	// RVA: 0x28C7040 Offset: 0x28C7141 VA: 0x28C7040
	private void CallFleaMarketUnmanned() { }

	// RVA: 0x28C70D0 Offset: 0x28C71D1 VA: 0x28C70D0
	private void CreateFleaMarket() { }

	// RVA: 0x28C7140 Offset: 0x28C7241 VA: 0x28C7140
	private void CreateJukebox() { }

	// RVA: 0x28C7150 Offset: 0x28C7251 VA: 0x28C7150
	private void OpenCheckAnimal() { }

	// RVA: 0x28C7280 Offset: 0x28C7381 VA: 0x28C7280
	private void CreateAnimal() { }

	// RVA: 0x28C7290 Offset: 0x28C7391 VA: 0x28C7290
	private void CreatePhotoMenu() { }

	// RVA: 0x28C72A0 Offset: 0x28C73A1 VA: 0x28C72A0
	private void CreateWellMenu() { }

	// RVA: 0x28C72B0 Offset: 0x28C73B1 VA: 0x28C72B0
	private void CreatePool() { }

	// RVA: 0x28C72C0 Offset: 0x28C73C1 VA: 0x28C72C0
	private void CreateFruit() { }

	// RVA: 0x28C72D0 Offset: 0x28C73D1 VA: 0x28C72D0
	private void CreateHorse() { }

	// RVA: 0x28C72E0 Offset: 0x28C73E1 VA: 0x28C72E0
	private void EntryAmiibo() { }

	// RVA: 0x28C72F0 Offset: 0x28C73F1 VA: 0x28C72F0
	private void CreateAmiibo() { }

	// RVA: 0x28C7300 Offset: 0x28C7401 VA: 0x28C7300
	private void ExitAmiibo() { }

	// RVA: 0x28C7320 Offset: 0x28C7421 VA: 0x28C7320
	private void OpenCheckCapeTower() { }

	// RVA: 0x28C7480 Offset: 0x28C7581 VA: 0x28C7480
	private void OpenCapeDoor() { }

	// RVA: 0x28C7600 Offset: 0x28C7701 VA: 0x28C7600
	private void CreateCapeTower() { }

	// RVA: 0x28C7650 Offset: 0x28C7751 VA: 0x28C7650
	private void CloseCapeTower() { }

	// RVA: 0x28C7910 Offset: 0x28C7A11 VA: 0x28C7910
	private void FinalCapeTower() { }

	// RVA: 0x28C7BD0 Offset: 0x28C7CD1 VA: 0x28C7BD0
	public void CallScript(string confirmMid, string scriptName) { }

	// RVA: 0x28C7C70 Offset: 0x28C7D71 VA: 0x28C7C70
	private void EntryCallScript() { }

	// RVA: 0x28C7C80 Offset: 0x28C7D81 VA: 0x28C7C80
	private void MainCallScript() { }

	// RVA: 0x28C7E60 Offset: 0x28C7F61 VA: 0x28C7E60
	private void ExitCallScript() { }

	// RVA: 0x28C7E80 Offset: 0x28C7F81 VA: 0x28C7E80
	private void EntryKizunaExit() { }

	// RVA: 0x28C7E90 Offset: 0x28C7F91 VA: 0x28C7E90
	private void MainKizunaExit() { }

	// RVA: 0x28C7EA0 Offset: 0x28C7FA1 VA: 0x28C7EA0
	private void ExitKizunaExit() { }

	// RVA: 0x28C7EC0 Offset: 0x28C7FC1 VA: 0x28C7EC0
	public static Vector3 GetSunPosition() { }

	// RVA: 0x28C8080 Offset: 0x28C8181 VA: 0x28C8080
	public void EnableDragonRideGroup() { }

	// RVA: 0x28C81B0 Offset: 0x28C82B1 VA: 0x28C81B0
	public void DisableDragonRideGroup() { }

	// RVA: 0x28C82A0 Offset: 0x28C83A1 VA: 0x28C82A0
	public void EnableFishingGroup() { }

	// RVA: 0x28C82F0 Offset: 0x28C83F1 VA: 0x28C82F0
	public void DisableFishingGroup() { }

	// RVA: 0x28C7640 Offset: 0x28C7741 VA: 0x28C7640
	public void DisableGroup() { }

	// RVA: 0x28C7900 Offset: 0x28C7A01 VA: 0x28C7900
	public void EnableGroup() { }

	// RVA: 0x28C81A0 Offset: 0x28C82A1 VA: 0x28C81A0
	public void DisableRoot() { }

	// RVA: 0x28C8290 Offset: 0x28C8391 VA: 0x28C8290
	public void EnableRoot() { }

	// RVA: 0x28C8340 Offset: 0x28C8441 VA: 0x28C8340
	private void LoadScript() { }

	// RVA: 0x28C8570 Offset: 0x28C8671 VA: 0x28C8570
	private void UnloadScript() { }

	// RVA: 0x28C8660 Offset: 0x28C8761 VA: 0x28C8660
	private void EntryScript() { }

	// RVA: 0x28C8670 Offset: 0x28C8771 VA: 0x28C8670
	private void StartScript() { }

	// RVA: 0x28C86F0 Offset: 0x28C87F1 VA: 0x28C86F0
	private void ExitScript() { }

	// RVA: 0x28B4AF0 Offset: 0x28B4BF1 VA: 0x28B4AF0
	public void StartBind(ProcInst _this, string eventName) { }

	// RVA: 0x28C8710 Offset: 0x28C8811 VA: 0x28C8710
	public void StartEvent(string scriptName, HubAccess access) { }

	// RVA: 0x28C8D90 Offset: 0x28C8E91 VA: 0x28C8D90
	private void AccessMascot() { }

	// RVA: 0x28C8DA0 Offset: 0x28C8EA1 VA: 0x28C8DA0
	private void EntryArena() { }

	// RVA: 0x28C8DB0 Offset: 0x28C8EB1 VA: 0x28C8DB0
	private void StartArena() { }

	// RVA: 0x28C8DC0 Offset: 0x28C8EC1 VA: 0x28C8DC0
	private void ExitArena() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C1480 Offset: 0x2C1581 VA: 0x2C1480
	// RVA: 0x28C8DE0 Offset: 0x28C8EE1 VA: 0x28C8DE0
	private IEnumerator StartPedestal() { }

	// RVA: 0x28C8E60 Offset: 0x28C8F61 VA: 0x28C8E60
	private void AccessPedestal() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C14F0 Offset: 0x2C15F1 VA: 0x2C14F0
	// RVA: 0x28C8E70 Offset: 0x28C8F71 VA: 0x28C8E70
	private IEnumerator EndPedestal() { }

	// RVA: 0x28C8EF0 Offset: 0x28C8FF1 VA: 0x28C8EF0
	public static void NextMap(string sceneName, string startName) { }

	// RVA: 0x28C9040 Offset: 0x28C9141 VA: 0x28C9040
	public static void NextChapter(string overwriteChapter) { }

	// RVA: 0x28C9250 Offset: 0x28C9351 VA: 0x28C9250
	public static void NextGmap() { }

	// RVA: 0x28C94E0 Offset: 0x28C95E1 VA: 0x28C94E0
	public static bool IsExit() { }

	// RVA: 0x28C9180 Offset: 0x28C9281 VA: 0x28C9180
	public static void Exit() { }

	// RVA: 0x28C8F70 Offset: 0x28C9071 VA: 0x28C8F70
	public static void Exit(MainSequence.Label label) { }

	// RVA: 0x28C92E0 Offset: 0x28C93E1 VA: 0x28C92E0
	private static bool CanMoveGmap() { }

	// RVA: 0x28AE760 Offset: 0x28AE861 VA: 0x28AE760
	public static HubPlayerController GetPlayerController() { }

	// RVA: 0x28C95D0 Offset: 0x28C96D1 VA: 0x28C95D0
	private void SaveDataLoad() { }

	// RVA: 0x28C96B0 Offset: 0x28C97B1 VA: 0x28C96B0
	private void SaveDataLoadResult() { }

	// RVA: 0x28C9880 Offset: 0x28C9981 VA: 0x28C9880
	private void SaveDataRelease() { }

	// RVA: 0x28C9950 Offset: 0x28C9A51 VA: 0x28C9950
	private void SaveDataNormalize() { }

	// RVA: 0x28C9960 Offset: 0x28C9A61 VA: 0x28C9960 Slot: 18
	protected override int get_Version() { }

	// RVA: 0x28C9970 Offset: 0x28C9A71 VA: 0x28C9970 Slot: 20
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x28C9980 Offset: 0x28C9A81 VA: 0x28C9980 Slot: 21
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x28C9990 Offset: 0x28C9A91 VA: 0x28C9990 Slot: 15
	protected override void OnShutdown() { }

	// RVA: 0x28C9A10 Offset: 0x28C9B11 VA: 0x28C9A10
	private void Tick() { }

	// RVA: 0x28CA030 Offset: 0x28CA131 VA: 0x28CA030
	private string GetCurrentKeyHelpName() { }

	// RVA: 0x28CA0F0 Offset: 0x28CA1F1 VA: 0x28CA0F0
	private void Persistent() { }

	// RVA: 0x28CA4B0 Offset: 0x28CA5B1 VA: 0x28CA4B0
	public void SetPlayerAnim(string name) { }

	// RVA: 0x28CA530 Offset: 0x28CA631 VA: 0x28CA530
	public void StartFastTravel() { }

	// RVA: 0x28CA540 Offset: 0x28CA641 VA: 0x28CA540
	public void CallFastTravel() { }

	// RVA: 0x28CA780 Offset: 0x28CA881 VA: 0x28CA780
	public void EndFastTravel() { }

	// RVA: 0x28CA7C0 Offset: 0x28CA8C1 VA: 0x28CA7C0
	public void RunFastTravel(string ID) { }

	// RVA: 0x28CA850 Offset: 0x28CA951 VA: 0x28CA850
	public void StartAccessAnimal(HubAccess access) { }

	// RVA: 0x28CA900 Offset: 0x28CAA01 VA: 0x28CA900
	public void StartTalk(HubAccess access) { }

	// RVA: 0x28CA9B0 Offset: 0x28CAAB1 VA: 0x28CA9B0
	private void Talk() { }

	// RVA: 0x28CAA50 Offset: 0x28CAB51 VA: 0x28CAA50
	private void BeginSilentEnv() { }

	// RVA: 0x28CAAC0 Offset: 0x28CABC1 VA: 0x28CAAC0
	private void EndSilentEnv() { }

	// RVA: 0x28CAB30 Offset: 0x28CAC31 VA: 0x28CAB30
	private void GameCleaerEvent() { }

	// RVA: 0x28CABE0 Offset: 0x28CACE1 VA: 0x28CABE0
	private void ContentsEvent() { }

	// RVA: 0x28CAC90 Offset: 0x28CAD91 VA: 0x28CAC90
	private void RelayTicketEvent() { }

	// RVA: 0x28CAD40 Offset: 0x28CAE41 VA: 0x28CAD40
	private void SkillOpenEvent() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C1560 Offset: 0x2C1661 VA: 0x2C1560
	// RVA: 0x28CADF0 Offset: 0x28CAEF1 VA: 0x28CADF0
	private IEnumerator EnterEvent() { }

	// RVA: 0x28CAE70 Offset: 0x28CAF71 VA: 0x28CAE70
	private void PostEnterEvent() { }

	// RVA: 0x28B9AE0 Offset: 0x28B9BE1 VA: 0x28B9AE0
	public void PlayBgm(GameSound.FadeSpeedType fadeSpeedType = 5) { }

	// RVA: 0x28B8C70 Offset: 0x28B8D71 VA: 0x28B8C70
	public void PauseBgm(GameSound.FadeSpeedType fadeSpeedType = 3) { }

	// RVA: 0x28CB4D0 Offset: 0x28CB5D1 VA: 0x28CB4D0
	private string GetBgmEventName() { }

	// RVA: 0x28CB2E0 Offset: 0x28CB3E1 VA: 0x28CB2E0
	private GameSound.Handle TryGetCurrentBgmHandle() { }

	// RVA: 0x28CAF90 Offset: 0x28CB091 VA: 0x28CAF90
	private void PlayBgm_Kizuna(GameSound.FadeSpeedType fadeSpeedType) { }

	// RVA: 0x28CB080 Offset: 0x28CB181 VA: 0x28CB080
	private void PlayBgm_Hub(GameSound.FadeSpeedType fadeSpeedType) { }

	// RVA: 0x28C7510 Offset: 0x28C7611 VA: 0x28C7510
	public void StopBgm(bool playMovie = False) { }

	// RVA: 0x28CB660 Offset: 0x28CB761 VA: 0x28CB660
	private void StopBgm_Kizuna() { }

	// RVA: 0x28CB710 Offset: 0x28CB811 VA: 0x28CB710
	private void StopBgm_Hub() { }

	// RVA: 0x28CB820 Offset: 0x28CB921 VA: 0x28CB820
	private void PlayerBeginAccess() { }

	// RVA: 0x28CB830 Offset: 0x28CB931 VA: 0x28CB830
	private void PlayerEndAccess() { }

	// RVA: 0x28C6A30 Offset: 0x28C6B31 VA: 0x28C6A30
	private static bool IsExistInstance() { }

	// RVA: 0x28CB850 Offset: 0x28CB951 VA: 0x28CB850
	public GameObject GetCharaLocatorsRoot() { }

	// RVA: 0x28C3C80 Offset: 0x28C3D81 VA: 0x28C3C80
	private void InitSceneInfo() { }

	// RVA: 0x28CB860 Offset: 0x28CB961 VA: 0x28CB860
	private void Report() { }

	// RVA: 0x28CB870 Offset: 0x28CB971 VA: 0x28CB870
	public static void CreateSolanelBind(ProcInst super) { }

	// RVA: 0x28CB8D0 Offset: 0x28CB9D1 VA: 0x28CB8D0
	public static void CreateKizunaBind(ProcInst super) { }

	// RVA: -1 Offset: -1
	protected static void CreateBind<T>(ProcInst super) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B8490 Offset: 0x22B8591 VA: 0x22B8490
	|-HubSequence.CreateBind<HubSequence>
	|-HubSequence.CreateBind<object>
	*/

	// RVA: 0x28CB930 Offset: 0x28CBA31 VA: 0x28CB930
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C15D0 Offset: 0x2C16D1 VA: 0x2C15D0
	// RVA: 0x28CBC60 Offset: 0x28CBD61 VA: 0x28CBC60
	private void <MainCallScript>b__138_0() { }
}

