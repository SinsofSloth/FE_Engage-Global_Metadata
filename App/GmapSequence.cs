// Namespace: App
public class GmapSequence : ProcSceneSequence<GmapSequence> // TypeDefIndex: 10337
{
	// Fields
	private GmapSpot m_NowSpot; // 0x88
	private GmapSpot m_ChangingSpot; // 0x90
	private GameObject m_ChangingPath; // 0x98
	private GmapSpot m_DisposSpot; // 0xA0
	private GmapCamera m_GmapCamera; // 0xA8
	private GmapCinemachineController m_PathController; // 0xB0
	private GameObject m_VirtualSphere; // 0xB8
	private GmapWholeMapController m_WholeMap; // 0xC0
	private GmapMapInfoContent m_MapInfo; // 0xC8
	private EncountIconRoot m_EncountIconRoot; // 0xD0
	private bool m_IsMoveForward; // 0xD8
	private GmapSpot m_NextSpot; // 0xE0
	private GmapSpot m_PrevSpot; // 0xE8
	private GameObject m_Paths; // 0xF0
	private GmapPathCollection m_PathCollection; // 0xF8
	private List<GmapSpot> m_AutoMoveRoutes; // 0x100
	private List<GmapSpot> m_AppearedSpotList; // 0x108
	private bool m_IsAppearedEncount; // 0x110
	private GameObject m_EffectParent; // 0x118
	private readonly string AppearLineEffectPath; // 0x120
	private readonly string AppearSymbolEffectPath; // 0x128
	private readonly string AppearSpotEffectPath; // 0x130
	private GameObject m_AppearLineEffect; // 0x138
	private bool m_IsInitialized; // 0x140
	private bool m_IsSkipping; // 0x141
	private GmapCinemaScope m_CinemaScope; // 0x148
	private TResourceHandle<GameObject> m_DlcPathHandle; // 0x150
	private TResourceHandle<GameObject> m_DlcSpotHandle; // 0x158
	private GameObject m_DlcPath; // 0x160
	private GameObject m_DlcSpot; // 0x168
	private static readonly float PathLengthMainToGod; // 0x0
	private static readonly float PathLengthGodToMain; // 0x4
	private bool m_IsEncountAppearOfMain; // 0x170
	private bool m_IsEncountAppearOfGod; // 0x171
	private bool m_IsEncountAppearOfEvil; // 0x172
	[CompilerGeneratedAttribute] // RVA: 0x28DDB0 Offset: 0x28DEB1 VA: 0x28DDB0
	private static bool <IsMoveFast>k__BackingField; // 0x8

	// Properties
	protected override LoadingManager.Modes LoadingMode { get; }
	public GmapSpot NowSpot { get; set; }
	private string GmapSpotIdFromData { get; set; }
	public static bool IsMoveFast { get; set; }
	protected override int Version { get; }

	// Methods

	// RVA: 0x2CE5E00 Offset: 0x2CE5F01 VA: 0x2CE5E00 Slot: 26
	protected override LoadingManager.Modes get_LoadingMode() { }

	// RVA: 0x2CE5E10 Offset: 0x2CE5F11 VA: 0x2CE5E10
	public GmapSpot get_NowSpot() { }

	// RVA: 0x2CE5E20 Offset: 0x2CE5F21 VA: 0x2CE5E20
	public void set_NowSpot(GmapSpot value) { }

	// RVA: 0x2CE5E30 Offset: 0x2CE5F31 VA: 0x2CE5E30
	private string get_GmapSpotIdFromData() { }

	// RVA: 0x2CE5EA0 Offset: 0x2CE5FA1 VA: 0x2CE5EA0
	private void set_GmapSpotIdFromData(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD980 Offset: 0x2BDA81 VA: 0x2BD980
	// RVA: 0x2CE5F10 Offset: 0x2CE6011 VA: 0x2CE5F10
	public static bool get_IsMoveFast() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BD990 Offset: 0x2BDA91 VA: 0x2BD990
	// RVA: 0x2CE5F80 Offset: 0x2CE6081 VA: 0x2CE5F80
	private static void set_IsMoveFast(bool value) { }

	// RVA: 0x2CE6000 Offset: 0x2CE6101 VA: 0x2CE6000 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x2CE6490 Offset: 0x2CE6591 VA: 0x2CE6490 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x2CE6560 Offset: 0x2CE6661 VA: 0x2CE6560 Slot: 15
	protected override void OnShutdown() { }

	// RVA: 0x2CE65D0 Offset: 0x2CE66D1 VA: 0x2CE65D0
	private void PersistentTick() { }

	// RVA: 0x2CE65E0 Offset: 0x2CE66E1 VA: 0x2CE65E0
	private void BranchStart() { }

	// RVA: 0x2CE6760 Offset: 0x2CE6861 VA: 0x2CE6760
	private void LoadScript() { }

	// RVA: 0x2CE6840 Offset: 0x2CE6941 VA: 0x2CE6840
	private void UnloadScript() { }

	// RVA: 0x2CE68F0 Offset: 0x2CE69F1 VA: 0x2CE68F0
	private void UnloadResources() { }

	// RVA: 0x2CE69D0 Offset: 0x2CE6AD1 VA: 0x2CE69D0
	private void Final() { }

	// RVA: 0x2CE6D40 Offset: 0x2CE6E41 VA: 0x2CE6D40
	private void Init() { }

	// RVA: 0x2CE7540 Offset: 0x2CE7641 VA: 0x2CE7540
	private void LoadActor() { }

	// RVA: 0x2CE75D0 Offset: 0x2CE76D1 VA: 0x2CE75D0
	private void UnloadUnit() { }

	// RVA: 0x2CE7650 Offset: 0x2CE7751 VA: 0x2CE7650
	private void LoadResources() { }

	// RVA: 0x2CE79A0 Offset: 0x2CE7AA1 VA: 0x2CE79A0
	private bool IsLoadingResources() { }

	// RVA: 0x2CE7C80 Offset: 0x2CE7D81 VA: 0x2CE7C80
	private void CreateObjectFromPrefab() { }

	// RVA: 0x2CE7DE0 Offset: 0x2CE7EE1 VA: 0x2CE7DE0
	private void AttachSpotModels() { }

	// RVA: 0x2CE8FF0 Offset: 0x2CE90F1 VA: 0x2CE8FF0
	private void SetPlayerAndCamera() { }

	// RVA: 0x2CE8AD0 Offset: 0x2CE8BD1 VA: 0x2CE8AD0
	private void SetPlayerAndCameraMainFromGodDLC() { }

	// RVA: 0x2CE8D60 Offset: 0x2CE8E61 VA: 0x2CE8D60
	private void SetPlayerAndCameraGodDLCFromMain() { }

	// RVA: 0x2CE94F0 Offset: 0x2CE95F1 VA: 0x2CE94F0
	private void SetStateM017() { }

	// RVA: 0x2CE9920 Offset: 0x2CE9A21 VA: 0x2CE9920
	private void CheckAppearPath() { }

	[IteratorStateMachineAttribute] // RVA: 0x2BD9A0 Offset: 0x2BDAA1 VA: 0x2BD9A0
	// RVA: 0x2CE9AE0 Offset: 0x2CE9BE1 VA: 0x2CE9AE0
	private IEnumerator AppearPathTick() { }

	// RVA: 0x2CE9B60 Offset: 0x2CE9C61 VA: 0x2CE9B60
	private void WaitCameraMove() { }

	// RVA: 0x2CE9BA0 Offset: 0x2CE9CA1 VA: 0x2CE9BA0
	private void WaitCameraMoveStrictly() { }

	// RVA: 0x2CE9BE0 Offset: 0x2CE9CE1 VA: 0x2CE9BE0
	public void SetPlayerSpot(GmapSpot gmapSpot) { }

	// RVA: 0x2CE9F40 Offset: 0x2CEA041 VA: 0x2CE9F40
	private void InitTick() { }

	[IteratorStateMachineAttribute] // RVA: 0x2BDA10 Offset: 0x2BDB11 VA: 0x2BDA10
	// RVA: 0x2CEA020 Offset: 0x2CEA121 VA: 0x2CEA020
	private IEnumerator GmapHelpEvent() { }

	// RVA: 0x2CEA0A0 Offset: 0x2CEA1A1 VA: 0x2CEA0A0
	private void Tick() { }

	// RVA: 0x2CEB360 Offset: 0x2CEB461 VA: 0x2CEB360
	private void MoveStart() { }

	// RVA: 0x2CEB060 Offset: 0x2CEB161 VA: 0x2CEB060
	private bool StartMoveNewestSpot() { }

	// RVA: 0x2CEBAE0 Offset: 0x2CEBBE1 VA: 0x2CEBAE0
	private bool StartMoveSpotForAutoPlay() { }

	// RVA: 0x2CEB760 Offset: 0x2CEB861 VA: 0x2CEB760
	private bool StartMoveTargetSpot(GmapSpot targetSpot) { }

	// RVA: 0x2CE9FC0 Offset: 0x2CEA0C1 VA: 0x2CE9FC0
	private bool IsAutoMoveMode() { }

	// RVA: 0x2CEADF0 Offset: 0x2CEAEF1 VA: 0x2CEADF0
	private void TryStopAutoMode() { }

	// RVA: 0x2CEC510 Offset: 0x2CEC611 VA: 0x2CEC510
	private void EndAutoMode() { }

	// RVA: 0x2CEC680 Offset: 0x2CEC781 VA: 0x2CEC680
	private void EnterChapter() { }

	// RVA: 0x2CECA80 Offset: 0x2CECB81 VA: 0x2CECA80
	private void EnterEncount() { }

	// RVA: 0x2CED3D0 Offset: 0x2CED4D1 VA: 0x2CED3D0
	private void EnterRecollection() { }

	// RVA: 0x2CED5B0 Offset: 0x2CED6B1 VA: 0x2CED5B0
	public void InitMoving() { }

	// RVA: 0x2CED5C0 Offset: 0x2CED6C1 VA: 0x2CED5C0
	public void Moving() { }

	// RVA: 0x2CEDF00 Offset: 0x2CEE001 VA: 0x2CEDF00
	private void EndMoving() { }

	// RVA: 0x2CEDCA0 Offset: 0x2CEDDA1 VA: 0x2CEDCA0
	private void GetMoveSpeed(out float speed, out bool isFast) { }

	// RVA: 0x2CEC580 Offset: 0x2CEC681 VA: 0x2CEC580
	private void AdjustPlayerUnit() { }

	// RVA: 0x2CEB0F0 Offset: 0x2CEB1F1 VA: 0x2CEB0F0
	private void AutoMoveNext() { }

	// RVA: 0x2CEE7C0 Offset: 0x2CEE8C1 VA: 0x2CEE7C0
	private void EnterFromDlcGod() { }

	// RVA: 0x2CEEAD0 Offset: 0x2CEEBD1 VA: 0x2CEEAD0
	private void MoveFromDlcGod() { }

	// RVA: 0x2CEF290 Offset: 0x2CEF391 VA: 0x2CEF290
	private void MoveEndFromDlcGod() { }

	// RVA: 0x2CEF4C0 Offset: 0x2CEF5C1 VA: 0x2CEF4C0
	private void MovingFade() { }

	// RVA: 0x2CEF940 Offset: 0x2CEFA41 VA: 0x2CEF940
	public void PlayBgm() { }

	// RVA: 0x2CEFA60 Offset: 0x2CEFB61 VA: 0x2CEFA60
	public void StopBgm() { }

	// RVA: 0x2CEFBA0 Offset: 0x2CEFCA1 VA: 0x2CEFBA0
	public void PauseBgm() { }

	// RVA: 0x2CEFCE0 Offset: 0x2CEFDE1 VA: 0x2CEFCE0
	public void ResumeBgm() { }

	// RVA: 0x2CEB520 Offset: 0x2CEB621 VA: 0x2CEB520
	private void KeyHelpHide() { }

	// RVA: 0x2CEE590 Offset: 0x2CEE691 VA: 0x2CEE590
	private void KeyHelpShow() { }

	// RVA: 0x2CEFE20 Offset: 0x2CEFF21 VA: 0x2CEFE20
	private void SaveDataLoad() { }

	// RVA: 0x2CEFF00 Offset: 0x2CF0001 VA: 0x2CEFF00
	private void SaveDataLoadResult() { }

	// RVA: 0x2CF00D0 Offset: 0x2CF01D1 VA: 0x2CF00D0
	private void SaveDataRelease() { }

	// RVA: 0x2CF01A0 Offset: 0x2CF02A1 VA: 0x2CF01A0
	private void SaveDataNormalize() { }

	// RVA: 0x2CF01B0 Offset: 0x2CF02B1 VA: 0x2CF01B0 Slot: 18
	protected override int get_Version() { }

	// RVA: 0x2CF01C0 Offset: 0x2CF02C1 VA: 0x2CF01C0 Slot: 20
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x2CF01D0 Offset: 0x2CF02D1 VA: 0x2CF01D0 Slot: 21
	protected override void OnDeserialize(Stream stream, int version) { }

	// RVA: 0x2CEDD00 Offset: 0x2CEDE01 VA: 0x2CEDD00
	private static bool IsReverseStickL(Vector3 move) { }

	// RVA: 0x2CF01E0 Offset: 0x2CF02E1 VA: 0x2CF01E0
	private static bool IsCheckDispos() { }

	// RVA: 0x2CEBDF0 Offset: 0x2CEBEF1 VA: 0x2CEBDF0
	private static void ShowDialogOpenedM026Spot(ProcInst super) { }

	// RVA: 0x2CF0380 Offset: 0x2CF0481 VA: 0x2CF0380
	public bool IsPlayAppearEncountSound() { }

	// RVA: 0x2CEEAC0 Offset: 0x2CEEBC1 VA: 0x2CEEAC0
	private void CameraTrackingOn() { }

	// RVA: 0x2CE9AD0 Offset: 0x2CE9BD1 VA: 0x2CE9AD0
	private void CameraTrackingOff() { }

	// RVA: 0x2CF03A0 Offset: 0x2CF04A1 VA: 0x2CF03A0
	private void SetUpEncountInfo() { }

	// RVA: 0x2CEAF00 Offset: 0x2CEB001 VA: 0x2CEAF00
	private void GmapMenuCreateBind(ProcInst super) { }

	// RVA: 0x2CF03B0 Offset: 0x2CF04B1 VA: 0x2CF03B0
	public static void CreateBind(ProcInst super) { }

	// RVA: -1 Offset: -1
	protected static void CreateBind<T>(ProcInst super) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B5F90 Offset: 0x22B6091 VA: 0x22B5F90
	|-GmapSequence.CreateBind<GmapSequence>
	|-GmapSequence.CreateBind<object>
	*/

	// RVA: 0x2CF0430 Offset: 0x2CF0531 VA: 0x2CF0430
	public void .ctor() { }

	// RVA: 0x2CF0560 Offset: 0x2CF0661 VA: 0x2CF0560
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDA80 Offset: 0x2BDB81 VA: 0x2BDA80
	// RVA: 0x2CF05D0 Offset: 0x2CF06D1 VA: 0x2CF05D0
	private void <GmapMenuCreateBind>b__117_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDA90 Offset: 0x2BDB91 VA: 0x2BDA90
	// RVA: 0x2CF05E0 Offset: 0x2CF06E1 VA: 0x2CF05E0
	private void <GmapMenuCreateBind>b__117_1() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BDAA0 Offset: 0x2BDBA1 VA: 0x2BDAA0
	// RVA: 0x2CF05F0 Offset: 0x2CF06F1 VA: 0x2CF05F0
	private void <GmapMenuCreateBind>b__117_2() { }
}

