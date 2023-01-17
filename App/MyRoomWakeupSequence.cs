// Namespace: App
internal class MyRoomWakeupSequence : SingletonProcInst<MyRoomWakeupSequence> // TypeDefIndex: 11385
{
	// Fields
	public bool IsRecallSelect; // 0x72
	public string RecallPID; // 0x78
	public RelianceData.Level RecallLevel; // 0x80
	public GameSound.WakeupVoicePattern RecallPattern; // 0x84
	private Unit m_wakeupUnit; // 0x88
	private RelianceData.Level m_level; // 0x90
	private GameSound.WakeupVoicePattern m_pattern; // 0x94
	private string m_pid; // 0x98
	private GameObject m_eventRoot; // 0xA0
	private GameObject m_cameraRoot; // 0xA8
	private GameObject m_cameraRootParent; // 0xB0
	private GameObject m_cameraData; // 0xB8
	private GameObject m_cameraData2; // 0xC0
	private Character m_character; // 0xC8
	private HubLookAtController m_lookAt; // 0xD0
	private Vector3 m_CharacterPosition; // 0xD8
	private Quaternion m_CharacterRotation; // 0xE4
	private PlayableAsset m_timelineObject; // 0xF8
	private PlayableDirector m_playableDirector; // 0x100
	private ResourceHandle m_playableAssetHandle; // 0x108
	private ResourceHandle[] m_aocHandle; // 0x110
	private List<ResourceHandle> m_effectHandle; // 0x118
	private AnimatorOverrideController[] m_aocList; // 0x120
	private string m_currentAnimName; // 0x128
	private List<string> m_eventVoiceList; // 0x130
	private GameObject m_eventCanvas; // 0x138
	private GameObject m_eventCanvasForeground; // 0x140
	private GameObject m_eventCanvasBackground; // 0x148
	private GameObject m_caption; // 0x150
	private GameObject m_env; // 0x158
	private bool m_isFastWakeup; // 0x160
	private bool m_isLoading; // 0x161
	private TextMeshProUGUI m_captionText; // 0x168
	[CompilerGeneratedAttribute] // RVA: 0x297BF0 Offset: 0x297CF1 VA: 0x297BF0
	private string <PlayableAssetPath>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x297C00 Offset: 0x297D01 VA: 0x297C00
	private double <EnterStartTime>k__BackingField; // 0x178
	[CompilerGeneratedAttribute] // RVA: 0x297C10 Offset: 0x297D11 VA: 0x297C10
	private double <EnterEndTime>k__BackingField; // 0x180
	[CompilerGeneratedAttribute] // RVA: 0x297C20 Offset: 0x297D21 VA: 0x297C20
	private double <WakeupStartTime>k__BackingField; // 0x188
	[CompilerGeneratedAttribute] // RVA: 0x297C30 Offset: 0x297D31 VA: 0x297C30
	private double <WakeupEndTime>k__BackingField; // 0x190
	[CompilerGeneratedAttribute] // RVA: 0x297C40 Offset: 0x297D41 VA: 0x297C40
	private double <BeforeStartTime>k__BackingField; // 0x198
	[CompilerGeneratedAttribute] // RVA: 0x297C50 Offset: 0x297D51 VA: 0x297C50
	private double <BeforeEndTime>k__BackingField; // 0x1A0
	[CompilerGeneratedAttribute] // RVA: 0x297C60 Offset: 0x297D61 VA: 0x297C60
	private double <AfterStartTime>k__BackingField; // 0x1A8
	[CompilerGeneratedAttribute] // RVA: 0x297C70 Offset: 0x297D71 VA: 0x297C70
	private double <AfterEndTime>k__BackingField; // 0x1B0
	[CompilerGeneratedAttribute] // RVA: 0x297C80 Offset: 0x297D81 VA: 0x297C80
	private float <SaveZoomParam>k__BackingField; // 0x1B8
	private string FlagName; // 0x1C0
	private string eventWalkin; // 0x1C8
	private GameMessage message; // 0x1D0

	// Properties
	public string VoiceID { get; }
	public Character Character { get; }
	public RelianceData.Level Level { get; }
	public GameSound.WakeupVoicePattern Pattern { get; }
	public string FootstepID { get; }
	public MyRoomFadeRender FadeRender { get; }
	public GameObject EventCanvas { get; }
	public GameObject EventCanvasForeground { get; }
	public GameObject EventCanvasBackground { get; }
	public GameObject CameraRoot { get; }
	public GameObject CameraRootParent { get; }
	public GameObject CameraData { get; }
	public GameObject CameraData2 { get; }
	public Vector3 CharacterPosition { get; }
	public Quaternion CharacterRotation { get; }
	public double Time { get; }
	private string PlayableAssetPath { get; set; }
	private double EnterStartTime { get; set; }
	private double EnterEndTime { get; set; }
	private double WakeupStartTime { get; set; }
	private double WakeupEndTime { get; set; }
	private double BeforeStartTime { get; set; }
	private double BeforeEndTime { get; set; }
	private double AfterStartTime { get; set; }
	private double AfterEndTime { get; set; }
	private HubPlayerController Player { get; }
	private float SaveZoomParam { get; set; }

	// Methods

	// RVA: 0x28400B0 Offset: 0x28401B1 VA: 0x28400B0
	public string get_VoiceID() { }

	// RVA: 0x2846A30 Offset: 0x2846B31 VA: 0x2846A30
	public Character get_Character() { }

	// RVA: 0x2846A40 Offset: 0x2846B41 VA: 0x2846A40
	public RelianceData.Level get_Level() { }

	// RVA: 0x2846A50 Offset: 0x2846B51 VA: 0x2846A50
	public GameSound.WakeupVoicePattern get_Pattern() { }

	// RVA: 0x2846A60 Offset: 0x2846B61 VA: 0x2846A60
	public string get_FootstepID() { }

	// RVA: 0x282D7F0 Offset: 0x282D8F1 VA: 0x282D7F0
	public MyRoomFadeRender get_FadeRender() { }

	// RVA: 0x2846A90 Offset: 0x2846B91 VA: 0x2846A90
	public GameObject get_EventCanvas() { }

	// RVA: 0x2846AA0 Offset: 0x2846BA1 VA: 0x2846AA0
	public GameObject get_EventCanvasForeground() { }

	// RVA: 0x2846AB0 Offset: 0x2846BB1 VA: 0x2846AB0
	public GameObject get_EventCanvasBackground() { }

	// RVA: 0x2846AC0 Offset: 0x2846BC1 VA: 0x2846AC0
	public GameObject get_CameraRoot() { }

	// RVA: 0x2846AD0 Offset: 0x2846BD1 VA: 0x2846AD0
	public GameObject get_CameraRootParent() { }

	// RVA: 0x2846AE0 Offset: 0x2846BE1 VA: 0x2846AE0
	public GameObject get_CameraData() { }

	// RVA: 0x2846AF0 Offset: 0x2846BF1 VA: 0x2846AF0
	public GameObject get_CameraData2() { }

	// RVA: 0x2846B00 Offset: 0x2846C01 VA: 0x2846B00
	public Vector3 get_CharacterPosition() { }

	// RVA: 0x2846B10 Offset: 0x2846C11 VA: 0x2846B10
	public Quaternion get_CharacterRotation() { }

	// RVA: 0x282C830 Offset: 0x282C931 VA: 0x282C830
	public double get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C51E0 Offset: 0x2C52E1 VA: 0x2C51E0
	// RVA: 0x2846B20 Offset: 0x2846C21 VA: 0x2846B20
	private string get_PlayableAssetPath() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C51F0 Offset: 0x2C52F1 VA: 0x2C51F0
	// RVA: 0x2846B30 Offset: 0x2846C31 VA: 0x2846B30
	private void set_PlayableAssetPath(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5200 Offset: 0x2C5301 VA: 0x2C5200
	// RVA: 0x2846B40 Offset: 0x2846C41 VA: 0x2846B40
	private double get_EnterStartTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5210 Offset: 0x2C5311 VA: 0x2C5210
	// RVA: 0x2846B50 Offset: 0x2846C51 VA: 0x2846B50
	private void set_EnterStartTime(double value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5220 Offset: 0x2C5321 VA: 0x2C5220
	// RVA: 0x2846B60 Offset: 0x2846C61 VA: 0x2846B60
	private double get_EnterEndTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5230 Offset: 0x2C5331 VA: 0x2C5230
	// RVA: 0x2846B70 Offset: 0x2846C71 VA: 0x2846B70
	private void set_EnterEndTime(double value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5240 Offset: 0x2C5341 VA: 0x2C5240
	// RVA: 0x2846B80 Offset: 0x2846C81 VA: 0x2846B80
	private double get_WakeupStartTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5250 Offset: 0x2C5351 VA: 0x2C5250
	// RVA: 0x2846B90 Offset: 0x2846C91 VA: 0x2846B90
	private void set_WakeupStartTime(double value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5260 Offset: 0x2C5361 VA: 0x2C5260
	// RVA: 0x2846BA0 Offset: 0x2846CA1 VA: 0x2846BA0
	private double get_WakeupEndTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5270 Offset: 0x2C5371 VA: 0x2C5270
	// RVA: 0x2846BB0 Offset: 0x2846CB1 VA: 0x2846BB0
	private void set_WakeupEndTime(double value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5280 Offset: 0x2C5381 VA: 0x2C5280
	// RVA: 0x2846BC0 Offset: 0x2846CC1 VA: 0x2846BC0
	private double get_BeforeStartTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5290 Offset: 0x2C5391 VA: 0x2C5290
	// RVA: 0x2846BD0 Offset: 0x2846CD1 VA: 0x2846BD0
	private void set_BeforeStartTime(double value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C52A0 Offset: 0x2C53A1 VA: 0x2C52A0
	// RVA: 0x2846BE0 Offset: 0x2846CE1 VA: 0x2846BE0
	private double get_BeforeEndTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C52B0 Offset: 0x2C53B1 VA: 0x2C52B0
	// RVA: 0x2846BF0 Offset: 0x2846CF1 VA: 0x2846BF0
	private void set_BeforeEndTime(double value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C52C0 Offset: 0x2C53C1 VA: 0x2C52C0
	// RVA: 0x2846C00 Offset: 0x2846D01 VA: 0x2846C00
	private double get_AfterStartTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C52D0 Offset: 0x2C53D1 VA: 0x2C52D0
	// RVA: 0x2846C10 Offset: 0x2846D11 VA: 0x2846C10
	private void set_AfterStartTime(double value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C52E0 Offset: 0x2C53E1 VA: 0x2C52E0
	// RVA: 0x2846C20 Offset: 0x2846D21 VA: 0x2846C20
	private double get_AfterEndTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C52F0 Offset: 0x2C53F1 VA: 0x2C52F0
	// RVA: 0x2846C30 Offset: 0x2846D31 VA: 0x2846C30
	private void set_AfterEndTime(double value) { }

	// RVA: 0x28404F0 Offset: 0x28405F1 VA: 0x28404F0
	public void AddEventVoice(string eventVoice) { }

	// RVA: 0x2840780 Offset: 0x2840881 VA: 0x2840780
	public void RemoveEventVoice(string eventVoice) { }

	// RVA: 0x2840490 Offset: 0x2840591 VA: 0x2840490
	public bool ContainsEventVoice(string eventVoice) { }

	// RVA: 0x282D2D0 Offset: 0x282D3D1 VA: 0x282D2D0
	public void SwitchLookAtIK(bool lookingCamera) { }

	// RVA: 0x282A240 Offset: 0x282A341 VA: 0x282A240
	public void SetCaption(string mid = "") { }

	// RVA: 0x283A010 Offset: 0x283A111 VA: 0x283A010
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x28468E0 Offset: 0x28469E1 VA: 0x28468E0
	public static void CreateBindRecall(ProcInst super, string pid, GameSound.WakeupVoicePattern pattern, RelianceData.Level level) { }

	// RVA: 0x2847B50 Offset: 0x2847C51 VA: 0x2847B50
	private AnimationClip GetBodyClip(string name) { }

	// RVA: 0x2848050 Offset: 0x2848151 VA: 0x2848050
	private AnimationClip GetFaceClip(string name) { }

	// RVA: 0x28481B0 Offset: 0x28482B1 VA: 0x28481B0
	private HubPlayerController get_Player() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5300 Offset: 0x2C5401 VA: 0x2C5300
	// RVA: 0x2848230 Offset: 0x2848331 VA: 0x2848230
	private float get_SaveZoomParam() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5310 Offset: 0x2C5411 VA: 0x2C5310
	// RVA: 0x2848240 Offset: 0x2848341 VA: 0x2848240
	private void set_SaveZoomParam(float value) { }

	// RVA: 0x2848250 Offset: 0x2848351 VA: 0x2848250
	private void Init() { }

	// RVA: 0x2848890 Offset: 0x2848991 VA: 0x2848890
	private void SwitchEnv() { }

	// RVA: 0x28489F0 Offset: 0x2848AF1 VA: 0x28489F0
	private void ResetEnv() { }

	// RVA: 0x2848B50 Offset: 0x2848C51 VA: 0x2848B50
	private bool IsSelected() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C5320 Offset: 0x2C5421 VA: 0x2C5320
	// RVA: 0x2848B80 Offset: 0x2848C81 VA: 0x2848B80
	private IEnumerator ChangeEnv() { }

	// RVA: 0x2848C00 Offset: 0x2848D01 VA: 0x2848C00
	private bool IsWakeupIgnorePattern(string pid, RelianceData.Level level, GameSound.WakeupVoicePattern pattern) { }

	// RVA: 0x2848D50 Offset: 0x2848E51 VA: 0x2848D50
	private Unit GetWakeupUnit(string pid) { }

	// RVA: 0x2848EB0 Offset: 0x2848FB1 VA: 0x2848EB0
	private void SetAchiveDone(string pid, RelianceData.Level level, GameSound.WakeupVoicePattern pattern) { }

	// RVA: 0x2849090 Offset: 0x2849191 VA: 0x2849090
	private bool SelectRelianceWakeup() { }

	// RVA: 0x28499F0 Offset: 0x2849AF1 VA: 0x28499F0
	private void InitWakeup() { }

	// RVA: 0x284A580 Offset: 0x284A681 VA: 0x284A580
	private bool IsLoadingResources() { }

	// RVA: 0x284A610 Offset: 0x284A711 VA: 0x284A610
	private CharacterAppearance GetCharacterAppearanceRemoveAcc(string pid) { }

	// RVA: 0x2849BA0 Offset: 0x2849CA1 VA: 0x2849BA0
	private void LoadResources() { }

	// RVA: 0x282BE80 Offset: 0x282BF81 VA: 0x282BE80
	public void ProcessFrameFaceAnimation() { }

	// RVA: 0x284A710 Offset: 0x284A811 VA: 0x284A710
	private void BeforeWakeupAction() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C5390 Offset: 0x2C5491 VA: 0x2C5390
	// RVA: 0x284A910 Offset: 0x284AA11 VA: 0x284A910
	private IEnumerator WaitBeforeWakeupAction() { }

	// RVA: 0x284A990 Offset: 0x284AA91 VA: 0x284A990
	private void StartWakeupTimeline() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C5400 Offset: 0x2C5501 VA: 0x2C5400
	// RVA: 0x284B620 Offset: 0x284B721 VA: 0x284B620
	private IEnumerator MainWakeupEnter() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C5470 Offset: 0x2C5571 VA: 0x2C5470
	// RVA: 0x284B6A0 Offset: 0x284B7A1 VA: 0x284B6A0
	private IEnumerator MainWakeup() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C54E0 Offset: 0x2C55E1 VA: 0x2C54E0
	// RVA: 0x284B720 Offset: 0x284B821 VA: 0x284B720
	private IEnumerator MainWakeupBeforeAfter() { }

	// RVA: 0x284B7A0 Offset: 0x284B8A1 VA: 0x284B7A0
	private void ExitWakeup() { }

	// RVA: 0x284C0B0 Offset: 0x284C1B1 VA: 0x284C0B0
	private void ExitWakeupAfter() { }

	// RVA: 0x2846DD0 Offset: 0x2846ED1 VA: 0x2846DD0
	private ProcDesc[] CreateDesc() { }

	// RVA: 0x2846C40 Offset: 0x2846D41 VA: 0x2846C40
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5550 Offset: 0x2C5651 VA: 0x2C5550
	// RVA: 0x284C140 Offset: 0x284C241 VA: 0x284C140
	private void <SwitchEnv>b__119_0(string timezone) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5560 Offset: 0x2C5661 VA: 0x2C5560
	// RVA: 0x284C310 Offset: 0x284C411 VA: 0x284C310
	private void <ResetEnv>b__120_0(string timezone) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C5570 Offset: 0x2C5671 VA: 0x2C5570
	// RVA: 0x284C4E0 Offset: 0x284C5E1 VA: 0x284C4E0
	private bool <CreateDesc>b__143_0() { }
}

