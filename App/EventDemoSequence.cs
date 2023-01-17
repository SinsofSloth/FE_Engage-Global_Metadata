// Namespace: App
public class EventDemoSequence : ProcSceneSequence<EventDemoSequence> // TypeDefIndex: 10226
{
	// Fields
	private const string CameraGroupName = "Cameras";
	private const string CurrentCameraName = "CurrentCamera";
	private const float LightDefaultRotateOffsetX = 40;
	private const float LightDefaultRotateOffsetY = 40;
	private const float LightDefaultRotateOffsetZ = 0;
	private const string LightGroupName = "Lights";
	private const string CurrentLightName = "CurrentLight";
	private const string UseSceneName = "PuppetDemo";
	private const string UseLayerName = "Puppet";
	private string m_demoName; // 0x88
	private string m_messFileName; // 0x90
	private int m_curMessLabelIndex; // 0x98
	private string m_curMessLabel; // 0xA0
	private EventDemoSequence.CmdInfo[] m_cmdInfosExecBefore; // 0xA8
	private EventDemoSequence.CmdInfo[] m_cmdInfosExecAfter; // 0xB0
	private int m_curCmdInfoIndex; // 0xB8
	private EventDemoSequence.EventCmdSeq m_eventCmdSeq; // 0xBC
	private Dictionary<string, string> m_eventCmdTextExecBefore; // 0xC0
	private Dictionary<string, string> m_eventCmdTextExecAfter; // 0xC8
	private Dictionary<string, EventDemoSequence.CmdFunc> m_funcDictionary; // 0xD0
	private bool m_isPuppetTalkPause; // 0xD8
	private bool m_isFadeOutInStart; // 0xD9
	private IDisposable m_DoLaterSetCamera; // 0xE0
	private EventDemoSequence.LightSetupInfo m_lightSetupInfo; // 0xE8
	private ResourceHandle m_cubeMaterialHandle; // 0xF0
	private List<string> m_messLoadedList; // 0xF8
	private Dictionary<string, EventDemoSequence.CharacterWork> m_characterWorkDictionary; // 0x100
	private Dictionary<string, EventDemoSequence.SplitViewWork> m_splitViewWorkDictionary; // 0x108
	private Dictionary<string, EventDemoSequence.EffectWork> m_effectWorkDictionary; // 0x110
	private ResourceObject m_telopEffectResourceObject; // 0x118
	private EventPictureController m_PictureController; // 0x120

	// Methods

	// RVA: 0x27EC9A0 Offset: 0x27ECAA1 VA: 0x27EC9A0
	private EventDemoSequence.CmdInfo[] AnalysisCmdText(string cmdTexts) { }

	// RVA: 0x27ECB00 Offset: 0x27ECC01 VA: 0x27ECB00
	private EventDemoSequence.CmdInfo GetCmdInfoFromCmdLines(string cmdLine) { }

	// RVA: 0x27ECFE0 Offset: 0x27ED0E1 VA: 0x27ECFE0
	private EventDemoSequence.EventCmdResult ExecEventCmd(EventDemoSequence.CmdInfo[] cmdInfos, int cmdInfoIndex) { }

	// RVA: 0x27ED060 Offset: 0x27ED161 VA: 0x27ED060
	private EventDemoSequence.EventCmdResult ExecEventCmdImpl(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27ED0C0 Offset: 0x27ED1C1 VA: 0x27ED0C0
	private EventDemoSequence.EventCmdResult FuncLabel(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27ED0D0 Offset: 0x27ED1D1 VA: 0x27ED0D0
	private EventDemoSequence.EventCmdResult FuncJump(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27ED220 Offset: 0x27ED321 VA: 0x27ED220
	private EventDemoSequence.EventCmdResult FuncWait(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27ED3A0 Offset: 0x27ED4A1 VA: 0x27ED3A0
	private EventDemoSequence.EventCmdResult FuncVariant(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27ED6D0 Offset: 0x27ED7D1 VA: 0x27ED6D0
	private void SetBackGround(string skyBoxMaterialName) { }

	// RVA: 0x27ED840 Offset: 0x27ED941 VA: 0x27ED840
	private string GetSkyBoxMaterialNameAuto(string baseName) { }

	// RVA: 0x27EDA90 Offset: 0x27EDB91 VA: 0x27EDA90
	private EventDemoSequence.EventCmdResult FuncSetBackGround(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27EDB00 Offset: 0x27EDC01 VA: 0x27EDB00
	private EventDemoSequence.EventCmdResult FuncSetBackGroundAuto(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27EDB80 Offset: 0x27EDC81 VA: 0x27EDB80
	private void DisableCameras() { }

	// RVA: 0x27EDCA0 Offset: 0x27EDDA1 VA: 0x27EDCA0
	private Camera CreateCurrentCamera(string srcCameraName, bool isCharaCameraTargetHeroFemale, bool isSplitViewCamera) { }

	// RVA: 0x27EDD20 Offset: 0x27EDE21 VA: 0x27EDD20
	private Camera CreateCamera(string cameraName, string srcCameraName, bool isCharaCameraTargetHeroFemale, bool isSplitViewCamera) { }

	// RVA: 0x27EE2D0 Offset: 0x27EE3D1 VA: 0x27EE2D0
	private Camera GetSrcCamera(string srcCameraName, bool isWarning) { }

	// RVA: 0x27EE430 Offset: 0x27EE531 VA: 0x27EE430
	private GameObject CreateParentObjectOfCamera(Camera camera) { }

	// RVA: 0x27EE6C0 Offset: 0x27EE7C1 VA: 0x27EE6C0
	private void SetCameraForChara(Camera camera, Character character) { }

	// RVA: 0x27EE880 Offset: 0x27EE981 VA: 0x27EE880
	private GameObject GetCharacterCameraAdjustObject(Character character) { }

	// RVA: 0x27EE8F0 Offset: 0x27EE9F1 VA: 0x27EE8F0
	private void InitCharacterCameraAdjustTransform(Character character) { }

	// RVA: 0x27EEB70 Offset: 0x27EEC71 VA: 0x27EEB70
	private void SetCameraForScene(Camera camera) { }

	// RVA: 0x27EEC00 Offset: 0x27EED01 VA: 0x27EEC00
	private EventDemoSequence.EventCmdResult FuncCameraSetCharaCamera(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27EEEF0 Offset: 0x27EEFF1 VA: 0x27EEEF0
	private EventDemoSequence.EventCmdResult SetCharaCameraNoDelay(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27EFA30 Offset: 0x27EFB31 VA: 0x27EFA30
	private EventDemoSequence.EventCmdResult FuncCameraSetSceneCamera(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27EFD10 Offset: 0x27EFE11 VA: 0x27EFD10
	private EventDemoSequence.EventCmdResult SetSceneCameraNoDelay(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27EFF20 Offset: 0x27F0021 VA: 0x27EFF20
	private EventDemoSequence.SplitViewWork GetSplitViewWork(string splitViewName, bool isWarning) { }

	// RVA: 0x27EFFD0 Offset: 0x27F00D1 VA: 0x27EFFD0
	private EventDemoSequence.EventCmdResult FuncSplitViewBeginSplitViewCameraOnly(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F00E0 Offset: 0x27F01E1 VA: 0x27F00E0
	private EventDemoSequence.EventCmdResult FuncSplitViewEndSplitViewCameraOnly(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F02F0 Offset: 0x27F03F1 VA: 0x27F02F0
	private EventDemoSequence.EventCmdResult FuncSplitViewCreate(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F0490 Offset: 0x27F0591 VA: 0x27F0490
	private EventDemoSequence.EventCmdResult FuncSplitViewSetCharaCamera(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F08F0 Offset: 0x27F09F1 VA: 0x27F08F0
	private EventDemoSequence.EventCmdResult FuncSplitViewSetSceneCamera(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F0B40 Offset: 0x27F0C41 VA: 0x27F0B40
	private EventDemoSequence.EventCmdResult FuncSplitViewSetActive(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F0CC0 Offset: 0x27F0DC1 VA: 0x27F0CC0
	private EventDemoSequence.EventCmdResult FuncSplitViewPlayAnim(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F0E70 Offset: 0x27F0F71 VA: 0x27F0E70
	private EventDemoSequence.EventCmdResult FuncSplitViewWaitAnimEnd(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F1020 Offset: 0x27F1121 VA: 0x27F1020
	private void DisableLights() { }

	// RVA: 0x27EF670 Offset: 0x27EF771 VA: 0x27EF670
	private void SetupLight(EventDemoSequence.LightSetupInfo lightSetupInfo) { }

	// RVA: 0x27F1140 Offset: 0x27F1241 VA: 0x27F1140
	private EventDemoSequence.EventCmdResult FuncLightSetup(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F1570 Offset: 0x27F1671 VA: 0x27F1570
	private EventDemoSequence.EventCmdResult FuncLightSetupAuto(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F1460 Offset: 0x27F1561 VA: 0x27F1460
	private void SetLightCommon(string lightName, Vector3 rotOffset) { }

	// RVA: 0x27F17C0 Offset: 0x27F18C1 VA: 0x27F17C0
	private EventDemoSequence.EventCmdResult FuncFadeIn(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F1A10 Offset: 0x27F1B11 VA: 0x27F1A10
	private EventDemoSequence.EventCmdResult FuncFadeOut(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F1A50 Offset: 0x27F1B51 VA: 0x27F1A50
	private EventDemoSequence.EventCmdResult FuncWhiteFadeIn(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F1A90 Offset: 0x27F1B91 VA: 0x27F1A90
	private EventDemoSequence.EventCmdResult FuncWhiteFadeOut(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F1800 Offset: 0x27F1901 VA: 0x27F1800
	private EventDemoSequence.EventCmdResult FadeInOutImpl(EventDemoSequence.CmdInfo cmdInfo, Color color, bool isFadeIn) { }

	// RVA: 0x27EF500 Offset: 0x27EF601 VA: 0x27EF500
	private EventDemoSequence.CharacterWork GetCharacterWork(string pid, bool isWarning = False) { }

	// RVA: 0x27EF320 Offset: 0x27EF421 VA: 0x27EF320
	private CharacterAppearance GetCharacterAppearance(string pid, bool isWarning) { }

	// RVA: 0x27F1AD0 Offset: 0x27F1BD1 VA: 0x27F1AD0
	private GameObject GetCharacterLocator(string pid, bool isWarning) { }

	// RVA: 0x27EF3E0 Offset: 0x27EF4E1 VA: 0x27EF3E0
	public Character GetCharacter(string pid, bool isWarning) { }

	// RVA: 0x27F1BF0 Offset: 0x27F1CF1 VA: 0x27F1BF0
	private GameObject FindCharacterLocator(string posString) { }

	// RVA: 0x27F1FF0 Offset: 0x27F20F1 VA: 0x27F1FF0
	private void PlayCharacterAnim(Character character, string facialAnimName, string bodyAnimName, float transitionDuration) { }

	// RVA: 0x27F20F0 Offset: 0x27F21F1 VA: 0x27F20F0
	private AssetTable.Result GetAssetTable(string pid, EventDemoSequence.ClothType clothType) { }

	// RVA: 0x27F2240 Offset: 0x27F2341 VA: 0x27F2240
	private EventDemoSequence.EventCmdResult FuncCharacterCreate(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F28E0 Offset: 0x27F29E1 VA: 0x27F28E0
	private EventDemoSequence.EventCmdResult FuncCharacterDelete(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F2A60 Offset: 0x27F2B61 VA: 0x27F2A60
	private EventDemoSequence.EventCmdResult FuncCharacterAdjustPos(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F30D0 Offset: 0x27F31D1 VA: 0x27F30D0
	private EventDemoSequence.EventCmdResult FuncCharacterShowHide(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F33E0 Offset: 0x27F34E1 VA: 0x27F33E0
	private EventDemoSequence.EventCmdResult FuncCharacterSetAnimator(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F37D0 Offset: 0x27F38D1 VA: 0x27F37D0
	private EventDemoSequence.EventCmdResult FuncCharacterPlayMotion(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F3E20 Offset: 0x27F3F21 VA: 0x27F3E20
	private EventDemoSequence.EventCmdResult FuncCharacterWaitMotion(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F40D0 Offset: 0x27F41D1 VA: 0x27F40D0
	private void SetCharacterAngle(Character characterSelf, Character characterEyeTarget, Character characterHeadTarget) { }

	// RVA: 0x27F4410 Offset: 0x27F4511 VA: 0x27F4410
	private EventDemoSequence.EventCmdResult FuncCharacterSetAngle(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F4800 Offset: 0x27F4901 VA: 0x27F4800
	private EventDemoSequence.EventCmdResult SetCharacterAngle(string selfPid, string eyeTargetPid, string headTargetPid) { }

	// RVA: 0x27F4AC0 Offset: 0x27F4BC1 VA: 0x27F4AC0
	private EventDemoSequence.EventCmdResult FuncCharacterResetAngle(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F4D70 Offset: 0x27F4E71 VA: 0x27F4D70
	private EventDemoSequence.EventCmdResult FuncCharacterSetRotate(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F5370 Offset: 0x27F5471 VA: 0x27F5370
	private void SetCharacterRotate(Character character, EventDemoSequence.CharacterWork characterWork, float rotateY, float sec) { }

	// RVA: 0x27F5450 Offset: 0x27F5551 VA: 0x27F5450
	private EventDemoSequence.EventCmdResult FuncCharacterEquipWeapon(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F5920 Offset: 0x27F5A21 VA: 0x27F5920
	private EventDemoSequence.EventCmdResult FuncCharacterEquipNoWeapon(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F5B40 Offset: 0x27F5C41 VA: 0x27F5B40
	private EventDemoSequence.EventCmdResult FuncCharacterEquipFishingRod(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F5F00 Offset: 0x27F6001 VA: 0x27F5F00
	private EventDemoSequence.EventCmdResult FuncCharacterEquipNoFishingRod(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F6130 Offset: 0x27F6231 VA: 0x27F6130
	private EventDemoSequence.EffectWork GetEffectWork(string effectName, bool isWarning = False) { }

	// RVA: 0x27F61E0 Offset: 0x27F62E1 VA: 0x27F61E0
	private EventDemoSequence.EventCmdResult FuncCreateEffect(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F6310 Offset: 0x27F6411 VA: 0x27F6310
	private EventDemoSequence.EventCmdResult FuncDeleteEffect(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F6410 Offset: 0x27F6511 VA: 0x27F6410
	private void DeleteTelopEffect() { }

	// RVA: 0x27F64C0 Offset: 0x27F65C1 VA: 0x27F64C0
	private EventDemoSequence.EventCmdResult FuncCreateTelopEffect(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F6640 Offset: 0x27F6741 VA: 0x27F6640
	private EventDemoSequence.EventCmdResult FuncDeleteTelopEffect(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F66E0 Offset: 0x27F67E1 VA: 0x27F66E0
	private EventDemoSequence.EventCmdResult FuncPausePuppetTalk(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F67A0 Offset: 0x27F68A1 VA: 0x27F67A0
	private EventDemoSequence.EventCmdResult FuncMessageLoad(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F68C0 Offset: 0x27F69C1 VA: 0x27F68C0
	private EventDemoSequence.EventCmdResult FuncTalkFaceBegin(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F6900 Offset: 0x27F6A01 VA: 0x27F6900
	private EventDemoSequence.EventCmdResult FuncPictureShow(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F6C20 Offset: 0x27F6D21 VA: 0x27F6C20
	private EventDemoSequence.EventCmdResult FuncPictureHide(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F6D90 Offset: 0x27F6E91 VA: 0x27F6D90
	private EventDemoSequence.EventCmdResult FuncChapterTitleShow(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F6EB0 Offset: 0x27F6FB1 VA: 0x27F6EB0
	private EventDemoSequence.EventCmdResult FuncSoundEvent(EventDemoSequence.CmdInfo cmdInfo) { }

	// RVA: 0x27F6F40 Offset: 0x27F7041 VA: 0x27F6F40
	private void SetupCommnads() { }

	// RVA: 0x27F80C0 Offset: 0x27F81C1 VA: 0x27F80C0
	public void .ctor(string messFileNameWithoutExt, string demoName) { }

	// RVA: 0x27EE0D0 Offset: 0x27EE1D1 VA: 0x27EE0D0
	private static GameObject FindGameObject(string name) { }

	// RVA: -1 Offset: -1
	private static void ForEachComponents<T>(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22B22C0 Offset: 0x22B23C1 VA: 0x22B22C0
	|-EventDemoSequence.ForEachComponents<Camera>
	|-EventDemoSequence.ForEachComponents<Light>
	|-EventDemoSequence.ForEachComponents<object>
	*/

	// RVA: 0x27F83C0 Offset: 0x27F84C1 VA: 0x27F83C0 Slot: 9
	protected override void OnCreate() { }

	// RVA: 0x27F8480 Offset: 0x27F8581 VA: 0x27F8480 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x27ED360 Offset: 0x27ED461 VA: 0x27ED360
	private bool IsSkip() { }

	// RVA: 0x27EE260 Offset: 0x27EE361 VA: 0x27EE260
	private bool IsHeroFemale() { }

	// RVA: 0x27EF5B0 Offset: 0x27EF6B1 VA: 0x27EF5B0
	private bool IsPidHero(string pid) { }

	// RVA: 0x27F8710 Offset: 0x27F8811 VA: 0x27F8710
	private bool IsLoading() { }

	// RVA: 0x27F8D70 Offset: 0x27F8E71 VA: 0x27F8D70
	private void PushFade() { }

	// RVA: 0x27F8E40 Offset: 0x27F8F41 VA: 0x27F8E40
	private void PopFade() { }

	// RVA: 0x27F8EC0 Offset: 0x27F8FC1 VA: 0x27F8EC0
	private void Init() { }

	// RVA: 0x27F9040 Offset: 0x27F9141 VA: 0x27F9040
	private void End() { }

	// RVA: 0x27F9170 Offset: 0x27F9271 VA: 0x27F9170
	private void LoadEventCmd() { }

	// RVA: 0x27F9300 Offset: 0x27F9401 VA: 0x27F9300
	private void UnloadEventCmd() { }

	// RVA: 0x27F9370 Offset: 0x27F9471 VA: 0x27F9370
	private void LoadDemoScene() { }

	// RVA: 0x27F9400 Offset: 0x27F9501 VA: 0x27F9400
	private void UnloadDemoScene() { }

	// RVA: 0x27F94B0 Offset: 0x27F95B1 VA: 0x27F94B0
	private void InitAfterLoadScene() { }

	// RVA: 0x27F9590 Offset: 0x27F9691 VA: 0x27F9590
	private void Tick() { }

	// RVA: 0x27F9690 Offset: 0x27F9791 VA: 0x27F9690
	private bool TickImpl(string label) { }

	// RVA: 0x27F99C0 Offset: 0x27F9AC1 VA: 0x27F99C0
	private void Persistent() { }

	// RVA: 0x27F9C20 Offset: 0x27F9D21 VA: 0x27F9C20 Slot: 15
	protected override void OnShutdown() { }

	// RVA: 0x27F9C60 Offset: 0x27F9D61 VA: 0x27F9C60
	public static void CreateBind(ProcInst super, string messFileNameWithoutExt, string demoName) { }
}

