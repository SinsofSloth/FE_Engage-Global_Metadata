// Namespace: App
public class GameConfig : SingletonClass<GameConfig> // TypeDefIndex: 13573
{
	// Fields
	public const float ValumeMax = 1;
	public const float ValumeMin = 0;
	[CompilerGeneratedAttribute] // RVA: 0x29C460 Offset: 0x29C561 VA: 0x29C460
	private GameConfig.Modes <Mode>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x29C470 Offset: 0x29C571 VA: 0x29C470
	private float <MapGridAlpha>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x29C480 Offset: 0x29C581 VA: 0x29C480
	private GameConfig.StickTriggerMarginType <StickTriggerMargin>k__BackingField; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x29C490 Offset: 0x29C591 VA: 0x29C490
	private GameConfig.AllInfoSwitch <AllInfoSwitchType>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x29C4A0 Offset: 0x29C5A1 VA: 0x29C4A0
	private GameConfig.AnimeType <BattleSceneType>k__BackingField; // 0x2C
	[CompilerGeneratedAttribute] // RVA: 0x29C4B0 Offset: 0x29C5B1 VA: 0x29C4B0
	private GameConfig.AnimeType <SupportSceneType>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x29C4C0 Offset: 0x29C5C1 VA: 0x29C4C0
	private GameConfig.UnitInfoType <MapInfoUnitPage>k__BackingField; // 0x34
	[CompilerGeneratedAttribute] // RVA: 0x29C4D0 Offset: 0x29C5D1 VA: 0x29C4D0
	private GameConfig.OperationType <MapUnitOperation>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x29C4E0 Offset: 0x29C5E1 VA: 0x29C4E0
	private bool <BattleCameraReverseHorizontal>k__BackingField; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x29C4F0 Offset: 0x29C5F1 VA: 0x29C4F0
	private bool <BattleCameraReverseVertical>k__BackingField; // 0x3D
	[CompilerGeneratedAttribute] // RVA: 0x29C500 Offset: 0x29C601 VA: 0x29C500
	private bool <HubCameraReverseHorizontal>k__BackingField; // 0x3E
	[CompilerGeneratedAttribute] // RVA: 0x29C510 Offset: 0x29C611 VA: 0x29C510
	private bool <HubCameraReverseVertical>k__BackingField; // 0x3F
	[CompilerGeneratedAttribute] // RVA: 0x29C520 Offset: 0x29C621 VA: 0x29C520
	private GameConfig.SpeedType <GameSpeed>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x29C530 Offset: 0x29C631 VA: 0x29C530
	private GameConfig.MinimapType <MapMinimap>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x29C540 Offset: 0x29C641 VA: 0x29C540
	private GameConfig.Toggle <MapUnitGauge>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x29C550 Offset: 0x29C651 VA: 0x29C550
	private GameConfig.EngageAnimeType <EngageAnim>k__BackingField; // 0x4C
	[CompilerGeneratedAttribute] // RVA: 0x29C560 Offset: 0x29C661 VA: 0x29C560
	private GameConfig.Toggle <AISkip>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x29C570 Offset: 0x29C671 VA: 0x29C570
	private GameConfig.Toggle <TutorialShow>k__BackingField; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x29C580 Offset: 0x29C681 VA: 0x29C580
	private TalkSequence.PlayMode <TalkPlayMode>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x29C590 Offset: 0x29C691 VA: 0x29C590
	private float <VolumeBgm>k__BackingField; // 0x5C
	[CompilerGeneratedAttribute] // RVA: 0x29C5A0 Offset: 0x29C6A1 VA: 0x29C5A0
	private float <VolumeSe>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x29C5B0 Offset: 0x29C6B1 VA: 0x29C5B0
	private float <VolumeEnv>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x29C5C0 Offset: 0x29C6C1 VA: 0x29C5C0
	private float <VolumeVoice>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x29C5D0 Offset: 0x29C6D1 VA: 0x29C5D0
	private string <FieldBGMPlayer>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x29C5E0 Offset: 0x29C6E1 VA: 0x29C5E0
	private string <FieldBGMEnemy>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x29C5F0 Offset: 0x29C6F1 VA: 0x29C5F0
	private bool <IsEnableNetwork>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x29C600 Offset: 0x29C701 VA: 0x29C600
	private GameConfig.DragonRideOperationType <DragonRideOperation>k__BackingField; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x29C610 Offset: 0x29C711 VA: 0x29C610
	private GameConfig.AllInfo <AllInfoType>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x29C620 Offset: 0x29C721 VA: 0x29C620
	private GameConfig.MapCursorMoveTyep <MapCursorMove>k__BackingField; // 0x8C

	// Properties
	public GameConfig.Modes Mode { get; set; }
	public float MapGridAlpha { get; set; }
	public GameConfig.StickTriggerMarginType StickTriggerMargin { get; set; }
	public GameConfig.AllInfoSwitch AllInfoSwitchType { get; set; }
	public GameConfig.AnimeType BattleSceneType { get; set; }
	public GameConfig.AnimeType SupportSceneType { get; set; }
	public GameConfig.UnitInfoType MapInfoUnitPage { get; set; }
	public GameConfig.OperationType MapUnitOperation { get; set; }
	public bool BattleCameraReverseHorizontal { get; set; }
	public bool BattleCameraReverseVertical { get; set; }
	public bool HubCameraReverseHorizontal { get; set; }
	public bool HubCameraReverseVertical { get; set; }
	public GameConfig.SpeedType GameSpeed { get; set; }
	public GameConfig.MinimapType MapMinimap { get; set; }
	public GameConfig.Toggle MapUnitGauge { get; set; }
	public GameConfig.EngageAnimeType EngageAnim { get; set; }
	public GameConfig.Toggle AISkip { get; set; }
	public GameConfig.Toggle TutorialShow { get; set; }
	public TalkSequence.PlayMode TalkPlayMode { get; set; }
	public float VolumeBgm { get; set; }
	public float VolumeSe { get; set; }
	public float VolumeEnv { get; set; }
	public float VolumeVoice { get; set; }
	public string FieldBGMPlayer { get; set; }
	public string FieldBGMEnemy { get; set; }
	public bool IsEnableNetwork { get; set; }
	public GameConfig.DragonRideOperationType DragonRideOperation { get; set; }
	public GameConfig.AllInfo AllInfoType { get; set; }
	public GameConfig.MapCursorMoveTyep MapCursorMove { get; set; }
	protected override int Version { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2CBEC0 Offset: 0x2CBFC1 VA: 0x2CBEC0
	// RVA: 0x26A3E50 Offset: 0x26A3F51 VA: 0x26A3E50
	public GameConfig.Modes get_Mode() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBED0 Offset: 0x2CBFD1 VA: 0x2CBED0
	// RVA: 0x26A3E60 Offset: 0x26A3F61 VA: 0x26A3E60
	public void set_Mode(GameConfig.Modes value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBEE0 Offset: 0x2CBFE1 VA: 0x2CBEE0
	// RVA: 0x26A3E70 Offset: 0x26A3F71 VA: 0x26A3E70
	public float get_MapGridAlpha() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBEF0 Offset: 0x2CBFF1 VA: 0x2CBEF0
	// RVA: 0x26A3E80 Offset: 0x26A3F81 VA: 0x26A3E80
	public void set_MapGridAlpha(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBF00 Offset: 0x2CC001 VA: 0x2CBF00
	// RVA: 0x26A3E90 Offset: 0x26A3F91 VA: 0x26A3E90
	public GameConfig.StickTriggerMarginType get_StickTriggerMargin() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBF10 Offset: 0x2CC011 VA: 0x2CBF10
	// RVA: 0x26A3EA0 Offset: 0x26A3FA1 VA: 0x26A3EA0
	public void set_StickTriggerMargin(GameConfig.StickTriggerMarginType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBF20 Offset: 0x2CC021 VA: 0x2CBF20
	// RVA: 0x26A3EB0 Offset: 0x26A3FB1 VA: 0x26A3EB0
	public GameConfig.AllInfoSwitch get_AllInfoSwitchType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBF30 Offset: 0x2CC031 VA: 0x2CBF30
	// RVA: 0x26A3EC0 Offset: 0x26A3FC1 VA: 0x26A3EC0
	public void set_AllInfoSwitchType(GameConfig.AllInfoSwitch value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBF40 Offset: 0x2CC041 VA: 0x2CBF40
	// RVA: 0x26A3ED0 Offset: 0x26A3FD1 VA: 0x26A3ED0
	public GameConfig.AnimeType get_BattleSceneType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBF50 Offset: 0x2CC051 VA: 0x2CBF50
	// RVA: 0x26A3EE0 Offset: 0x26A3FE1 VA: 0x26A3EE0
	public void set_BattleSceneType(GameConfig.AnimeType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBF60 Offset: 0x2CC061 VA: 0x2CBF60
	// RVA: 0x26A3EF0 Offset: 0x26A3FF1 VA: 0x26A3EF0
	public GameConfig.AnimeType get_SupportSceneType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBF70 Offset: 0x2CC071 VA: 0x2CBF70
	// RVA: 0x26A3F00 Offset: 0x26A4001 VA: 0x26A3F00
	public void set_SupportSceneType(GameConfig.AnimeType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBF80 Offset: 0x2CC081 VA: 0x2CBF80
	// RVA: 0x26A3F10 Offset: 0x26A4011 VA: 0x26A3F10
	public GameConfig.UnitInfoType get_MapInfoUnitPage() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBF90 Offset: 0x2CC091 VA: 0x2CBF90
	// RVA: 0x26A3F20 Offset: 0x26A4021 VA: 0x26A3F20
	public void set_MapInfoUnitPage(GameConfig.UnitInfoType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBFA0 Offset: 0x2CC0A1 VA: 0x2CBFA0
	// RVA: 0x26A3F30 Offset: 0x26A4031 VA: 0x26A3F30
	public GameConfig.OperationType get_MapUnitOperation() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBFB0 Offset: 0x2CC0B1 VA: 0x2CBFB0
	// RVA: 0x26A3F40 Offset: 0x26A4041 VA: 0x26A3F40
	public void set_MapUnitOperation(GameConfig.OperationType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBFC0 Offset: 0x2CC0C1 VA: 0x2CBFC0
	// RVA: 0x26A3F50 Offset: 0x26A4051 VA: 0x26A3F50
	public bool get_BattleCameraReverseHorizontal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBFD0 Offset: 0x2CC0D1 VA: 0x2CBFD0
	// RVA: 0x26A3F60 Offset: 0x26A4061 VA: 0x26A3F60
	public void set_BattleCameraReverseHorizontal(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBFE0 Offset: 0x2CC0E1 VA: 0x2CBFE0
	// RVA: 0x26A3F70 Offset: 0x26A4071 VA: 0x26A3F70
	public bool get_BattleCameraReverseVertical() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CBFF0 Offset: 0x2CC0F1 VA: 0x2CBFF0
	// RVA: 0x26A3F80 Offset: 0x26A4081 VA: 0x26A3F80
	public void set_BattleCameraReverseVertical(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC000 Offset: 0x2CC101 VA: 0x2CC000
	// RVA: 0x26A3F90 Offset: 0x26A4091 VA: 0x26A3F90
	public bool get_HubCameraReverseHorizontal() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC010 Offset: 0x2CC111 VA: 0x2CC010
	// RVA: 0x26A3FA0 Offset: 0x26A40A1 VA: 0x26A3FA0
	public void set_HubCameraReverseHorizontal(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC020 Offset: 0x2CC121 VA: 0x2CC020
	// RVA: 0x26A3FB0 Offset: 0x26A40B1 VA: 0x26A3FB0
	public bool get_HubCameraReverseVertical() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC030 Offset: 0x2CC131 VA: 0x2CC030
	// RVA: 0x26A3FC0 Offset: 0x26A40C1 VA: 0x26A3FC0
	public void set_HubCameraReverseVertical(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC040 Offset: 0x2CC141 VA: 0x2CC040
	// RVA: 0x26A3FD0 Offset: 0x26A40D1 VA: 0x26A3FD0
	public GameConfig.SpeedType get_GameSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC050 Offset: 0x2CC151 VA: 0x2CC050
	// RVA: 0x26A3FE0 Offset: 0x26A40E1 VA: 0x26A3FE0
	public void set_GameSpeed(GameConfig.SpeedType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC060 Offset: 0x2CC161 VA: 0x2CC060
	// RVA: 0x26A3FF0 Offset: 0x26A40F1 VA: 0x26A3FF0
	public GameConfig.MinimapType get_MapMinimap() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC070 Offset: 0x2CC171 VA: 0x2CC070
	// RVA: 0x26A4000 Offset: 0x26A4101 VA: 0x26A4000
	public void set_MapMinimap(GameConfig.MinimapType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC080 Offset: 0x2CC181 VA: 0x2CC080
	// RVA: 0x26A4010 Offset: 0x26A4111 VA: 0x26A4010
	public GameConfig.Toggle get_MapUnitGauge() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC090 Offset: 0x2CC191 VA: 0x2CC090
	// RVA: 0x26A4020 Offset: 0x26A4121 VA: 0x26A4020
	public void set_MapUnitGauge(GameConfig.Toggle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC0A0 Offset: 0x2CC1A1 VA: 0x2CC0A0
	// RVA: 0x26A4030 Offset: 0x26A4131 VA: 0x26A4030
	public GameConfig.EngageAnimeType get_EngageAnim() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC0B0 Offset: 0x2CC1B1 VA: 0x2CC0B0
	// RVA: 0x26A4040 Offset: 0x26A4141 VA: 0x26A4040
	public void set_EngageAnim(GameConfig.EngageAnimeType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC0C0 Offset: 0x2CC1C1 VA: 0x2CC0C0
	// RVA: 0x26A4050 Offset: 0x26A4151 VA: 0x26A4050
	public GameConfig.Toggle get_AISkip() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC0D0 Offset: 0x2CC1D1 VA: 0x2CC0D0
	// RVA: 0x26A4060 Offset: 0x26A4161 VA: 0x26A4060
	public void set_AISkip(GameConfig.Toggle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC0E0 Offset: 0x2CC1E1 VA: 0x2CC0E0
	// RVA: 0x26A4070 Offset: 0x26A4171 VA: 0x26A4070
	public GameConfig.Toggle get_TutorialShow() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC0F0 Offset: 0x2CC1F1 VA: 0x2CC0F0
	// RVA: 0x26A4080 Offset: 0x26A4181 VA: 0x26A4080
	public void set_TutorialShow(GameConfig.Toggle value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC100 Offset: 0x2CC201 VA: 0x2CC100
	// RVA: 0x26A4090 Offset: 0x26A4191 VA: 0x26A4090
	public TalkSequence.PlayMode get_TalkPlayMode() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC110 Offset: 0x2CC211 VA: 0x2CC110
	// RVA: 0x26A40A0 Offset: 0x26A41A1 VA: 0x26A40A0
	public void set_TalkPlayMode(TalkSequence.PlayMode value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC120 Offset: 0x2CC221 VA: 0x2CC120
	// RVA: 0x26A40B0 Offset: 0x26A41B1 VA: 0x26A40B0
	public float get_VolumeBgm() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC130 Offset: 0x2CC231 VA: 0x2CC130
	// RVA: 0x26A40C0 Offset: 0x26A41C1 VA: 0x26A40C0
	public void set_VolumeBgm(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC140 Offset: 0x2CC241 VA: 0x2CC140
	// RVA: 0x26A40D0 Offset: 0x26A41D1 VA: 0x26A40D0
	public float get_VolumeSe() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC150 Offset: 0x2CC251 VA: 0x2CC150
	// RVA: 0x26A40E0 Offset: 0x26A41E1 VA: 0x26A40E0
	public void set_VolumeSe(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC160 Offset: 0x2CC261 VA: 0x2CC160
	// RVA: 0x26A40F0 Offset: 0x26A41F1 VA: 0x26A40F0
	public float get_VolumeEnv() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC170 Offset: 0x2CC271 VA: 0x2CC170
	// RVA: 0x26A4100 Offset: 0x26A4201 VA: 0x26A4100
	public void set_VolumeEnv(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC180 Offset: 0x2CC281 VA: 0x2CC180
	// RVA: 0x26A4110 Offset: 0x26A4211 VA: 0x26A4110
	public float get_VolumeVoice() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC190 Offset: 0x2CC291 VA: 0x2CC190
	// RVA: 0x26A4120 Offset: 0x26A4221 VA: 0x26A4120
	public void set_VolumeVoice(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC1A0 Offset: 0x2CC2A1 VA: 0x2CC1A0
	// RVA: 0x26A4130 Offset: 0x26A4231 VA: 0x26A4130
	public string get_FieldBGMPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC1B0 Offset: 0x2CC2B1 VA: 0x2CC1B0
	// RVA: 0x26A4140 Offset: 0x26A4241 VA: 0x26A4140
	public void set_FieldBGMPlayer(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC1C0 Offset: 0x2CC2C1 VA: 0x2CC1C0
	// RVA: 0x26A4150 Offset: 0x26A4251 VA: 0x26A4150
	public string get_FieldBGMEnemy() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC1D0 Offset: 0x2CC2D1 VA: 0x2CC1D0
	// RVA: 0x26A4160 Offset: 0x26A4261 VA: 0x26A4160
	public void set_FieldBGMEnemy(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC1E0 Offset: 0x2CC2E1 VA: 0x2CC1E0
	// RVA: 0x26A4170 Offset: 0x26A4271 VA: 0x26A4170
	public bool get_IsEnableNetwork() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC1F0 Offset: 0x2CC2F1 VA: 0x2CC1F0
	// RVA: 0x26A4180 Offset: 0x26A4281 VA: 0x26A4180
	public void set_IsEnableNetwork(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC200 Offset: 0x2CC301 VA: 0x2CC200
	// RVA: 0x26A4190 Offset: 0x26A4291 VA: 0x26A4190
	public GameConfig.DragonRideOperationType get_DragonRideOperation() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC210 Offset: 0x2CC311 VA: 0x2CC210
	// RVA: 0x26A41A0 Offset: 0x26A42A1 VA: 0x26A41A0
	public void set_DragonRideOperation(GameConfig.DragonRideOperationType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC220 Offset: 0x2CC321 VA: 0x2CC220
	// RVA: 0x26A41B0 Offset: 0x26A42B1 VA: 0x26A41B0
	public GameConfig.AllInfo get_AllInfoType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC230 Offset: 0x2CC331 VA: 0x2CC230
	// RVA: 0x26A41C0 Offset: 0x26A42C1 VA: 0x26A41C0
	public void set_AllInfoType(GameConfig.AllInfo value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC240 Offset: 0x2CC341 VA: 0x2CC240
	// RVA: 0x26A41D0 Offset: 0x26A42D1 VA: 0x26A41D0
	public GameConfig.MapCursorMoveTyep get_MapCursorMove() { }

	[CompilerGeneratedAttribute] // RVA: 0x2CC250 Offset: 0x2CC351 VA: 0x2CC250
	// RVA: 0x26A41E0 Offset: 0x26A42E1 VA: 0x26A41E0
	public void set_MapCursorMove(GameConfig.MapCursorMoveTyep value) { }

	// RVA: 0x26A41F0 Offset: 0x26A42F1 VA: 0x26A41F0 Slot: 5
	protected override void OnCreate() { }

	// RVA: 0x26A4330 Offset: 0x26A4431 VA: 0x26A4330 Slot: 6
	protected override void OnDispose() { }

	// RVA: 0x26A4200 Offset: 0x26A4301 VA: 0x26A4200
	public void Initialize() { }

	// RVA: 0x26A4340 Offset: 0x26A4441 VA: 0x26A4340 Slot: 4
	protected override int get_Version() { }

	// RVA: 0x26A4350 Offset: 0x26A4451 VA: 0x26A4350 Slot: 11
	protected override void OnSerialize(Stream stream) { }

	// RVA: 0x26A4540 Offset: 0x26A4641 VA: 0x26A4540 Slot: 12
	protected override void OnDeserialize(Stream stream, int loadVersion) { }

	// RVA: 0x26A5850 Offset: 0x26A5951 VA: 0x26A5850
	public static bool IsPerformance() { }

	// RVA: 0x26A58F0 Offset: 0x26A59F1 VA: 0x26A58F0
	public static bool IsFast() { }

	// RVA: 0x26A5AB0 Offset: 0x26A5BB1 VA: 0x26A5AB0
	public void .ctor() { }
}

