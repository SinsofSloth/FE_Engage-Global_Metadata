// Namespace: App
public class FishingGameSequence : ProcSceneSequence<HubSequence> // TypeDefIndex: 10595
{
	// Fields
	private const float FirstAngle = 40;
	private const float FirstDistance = 5;
	private const string cAnime_SelectRod = "EmoThink";
	private const string cAnime_ThrowIn = "FishingCast";
	private const string cAnime_Wait = "FishingWait";
	private const string cAnime_Resist = "FishResist";
	private const string cAnime_ResistL = "FishResistL";
	private const string cAnime_ResistR = "FishResistR";
	private const string cAnime_LethalResist = "FishResist";
	private const string cAnime_Catch = "FishCatch";
	private const string cAnime_Stand = "IdleNormal";
	private const string cAnime_Joy = "EmoJoy";
	private const string cCharaImageRenderPath = "Hub/Prefabs/Fishing/FishingCharaImageRender";
	private const string cUIRootPath = "UI/Hub/Fishing/Prefabs/";
	private const string cUIHitButtonPath = "Hit";
	private const string cUIBattleRadarPath = "FishingBattleRoot";
	private const string cUIBattleStickPath = "Stick";
	private const string cUIBattleButtonPath = "RepeatedHitsNomal";
	private const string cUILethalButtonPath = "LastHit";
	private const string UIMovecircleHelpPath = "Help";
	private const string cResultUIPath = "ResultRoot";
	private const string cEffectRootPath = "Effects/Field/Hub/Fishing/Prefabs/";
	private const string cEffectSplashNormal = "Eff_Splash_00";
	private const string cEffectCounterSplashSmall = "Eff_Splash_A_00";
	private const string cEffectCounterSplashMiddle = "Eff_Splash_A_01";
	private const string cEffectCounterSplashLarge = "Eff_Splash_A_02";
	private const string cEffectLethalSplashSmall = "Eff_Splash_B_00";
	private const string cEffectLethalSplashMiddle = "Eff_Splash_B_01";
	private const string cEffectLethalSplashLarge = "Eff_Splash_B_02";
	private const string cEffectGuideCircle = "Eff_CastPoint_00";
	private const string cEffectCastSplash = "Eff_CastDown_00";
	private const string cEffectRippleSmall = "Eff_RingWater_00";
	private const string cEffectRippleMiddle = "Eff_RingWater_01";
	private const string cEffectRippleLarge = "Eff_RingWater_02";
	private const string cEffectResultGlitter_Small = "Eff_HitGlitter_00";
	private const string cEffectResultGlitter_Middle = "Eff_HitGlitter_01";
	private const string cEffectResultGlitter_Large = "Eff_HitGlitter_02";
	private const string cEffectMissSplash = "Eff_HitMiss_00";
	private const string cEffectRaderBubble = "Eff_FishShadow_Bubble";
	private const string cTelopRootPath = "UI/Hub/Telop/Fishing/Prefabs/";
	private const string cTelopHit = "Hit";
	private const string cTelopPerfect = "Perfect";
	private const string cTelopSuccess = "Success";
	private const string cAssistPopupPath = "UI/Hub/MuscleExercises/Prefabs/Popup_Assist";
	private const string cAssistGlitterPath = "Effects/Field/Hub/MuscleExercises/Prefabs/Eff_AssistGlitter_00";
	private const string cTextureRootPath = "UI/Hub/Fishing/Textures/";
	private const string cAtlasPath = "Fishing";
	private string[] cLoadObjectPath; // 0x88
	private const string cLoadTexturePath = "UI/Hub/Fishing/Textures/Fishing";
	private FishingConfig_Base m_ConfigBase; // 0x90
	private FishingConfig_MoveCircle m_ConfigMoveCircle; // 0x98
	private FishingConfig_ThrowIn m_ConfigThrowIn; // 0xA0
	private FishingConfig_WaitCatch m_ConfigWaitCatch; // 0xA8
	private FishingConfig_WaitCancel m_ConfigWaitCancel; // 0xB0
	private FishingConfig_Battle m_ConfigBattle; // 0xB8
	private FishingConfig_Defeat m_ConfigDefeat; // 0xC0
	private FishingConfig_Result m_ConfigResult; // 0xC8
	private GameObject m_PlayerRoot; // 0xD0
	private HubUnitController m_PlayerController; // 0xD8
	private HubLookAtController m_HubLookComponent; // 0xE0
	private LookAtIK m_PlayerLookAt; // 0xE8
	private Animator m_RodAnimator; // 0xF0
	private Character m_Sola; // 0xF8
	private GameObject m_HubSolaLct; // 0x100
	private bool m_IsSetSolaInvisible; // 0x108
	private string[] RodModelIDs; // 0x110
	private string[] LureModelIDs; // 0x118
	private GameObject m_Talker; // 0x120
	private Character m_TalkerChara; // 0x128
	private float m_TalkerRotTestDir; // 0x130
	private Vector3 m_TalkerResetPos; // 0x134
	private Quaternion m_TalkerResetRot; // 0x140
	private float m_TalkerResetDir; // 0x150
	private float m_Timer; // 0x154
	private Vector3 m_ResetPos; // 0x158
	private Quaternion m_ResetRot; // 0x164
	private float m_ResetDir; // 0x174
	private GameObject m_CameraObj; // 0x178
	private Camera m_CameraComponent; // 0x180
	private GameObject m_DefeatCamera; // 0x188
	private Animation m_DefeatCameraAnim; // 0x190
	private GameObject m_GuideCircleObj; // 0x198
	private GameObject m_GuideEffect; // 0x1A0
	private GameObject m_LureObj; // 0x1A8
	private Transform m_LureTrans; // 0x1B0
	private FishingLure m_LureScript; // 0x1B8
	private GameObject m_LureModel; // 0x1C0
	private Animator m_LureAnime; // 0x1C8
	private GameObject m_Image; // 0x1D0
	private InterpolatorFloat m_Angle; // 0x1D8
	private InterpolatorFloat m_ThrowDistance; // 0x1E0
	private bool m_IsPlayThrowSE; // 0x1E8
	private bool m_IsPlaySinkSE; // 0x1E9
	private bool m_IsThrowInCameraChange; // 0x1EA
	private float m_ResetDistance; // 0x1EC
	private float m_ResetAngle; // 0x1F0
	private bool m_IsStopLure; // 0x1F4
	private float m_PastStickPower; // 0x1F8
	private Vector3 m_lureBasePos; // 0x1FC
	private float m_StickWaitTimer; // 0x208
	private float m_AttackWaitTimer; // 0x20C
	private float m_VoiceIntervalTimer; // 0x210
	private GameObject m_BattleRadarObj; // 0x218
	private FishingBattleRader m_RadarScript; // 0x220
	private GameObject m_HitButtonObj; // 0x228
	private GameObject m_StickObj; // 0x230
	private GameObject m_ButtonObj; // 0x238
	private GameObject m_LethalButtonObj; // 0x240
	private Animator m_LethalButtonAnime; // 0x248
	private bool m_LethalAnimePlayWait; // 0x250
	private bool m_LethalSuccessAnimeWait; // 0x251
	private FishingRadicalParamData.RadicalParam[] m_RadicalParam; // 0x258
	private int m_UseRadicalIndex; // 0x260
	private float m_RadicalTimer; // 0x264
	[CompilerGeneratedAttribute] // RVA: 0x292D70 Offset: 0x292E71 VA: 0x292D70
	private bool <IsPlayDrawSE>k__BackingField; // 0x268
	private float m_AlartSETimer; // 0x26C
	private const float cAlartSec = 0.5;
	private float m_PlayerAnimeTimer; // 0x270
	private FishingGameSequence.FishingAngleState m_PlayerState; // 0x274
	private FishingGameSequence.FishingAngleState m_BattleCameraState; // 0x278
	private float m_BaseCameraAngle; // 0x27C
	private bool m_isRunningReverseLerp; // 0x280
	private static StickType m_RodMenuResult; // 0x0
	private GameObject m_FishObj; // 0x288
	private FishingFish m_FishScript; // 0x290
	private GameObject m_CanvasRoot; // 0x298
	private FishingEventFader m_Fader; // 0x2A0
	private bool m_IsPullStick; // 0x2A8
	private bool m_IsCancelFadeOut; // 0x2A9
	private bool m_IsCancelFadeIn; // 0x2AA
	private bool m_IsSelectRodWait; // 0x2AB
	private FishingGameSequence.AnnounceType m_FailType; // 0x2AC
	private InterpolatorFloat m_ThrowinHeight; // 0x2B0
	private GameObject m_MoveCircleHelp; // 0x2B8
	private GameObject m_RipplesRoot; // 0x2C0
	private FishingGameSequence.Ripple[] m_Ripples; // 0x2C8
	private bool m_EnableRipples; // 0x2D0
	private GameObject m_ImageRenderObj; // 0x2D8
	private FishingCharaImageRender m_ImageRender; // 0x2E0
	private InterpolatorFloat m_LureHeight; // 0x2E8
	private bool m_IsAssitBattleStart; // 0x2F0
	private GameObject m_AssistPopUp; // 0x2F8
	private RectTransform m_AssistRect; // 0x300
	private GameObject m_AssistGlitter; // 0x308
	private float m_AssistDisplayRateX; // 0x310
	private float m_AssistDisplayRateY; // 0x314
	private Vector3 m_AssistDisplayPos; // 0x318
	private float m_DefeatFrame; // 0x324
	private float m_DefeatFadeLength; // 0x328
	private bool m_IsShowSucessTelop; // 0x32C
	private bool m_IsStartDefeatFade; // 0x32D
	private FishingResultUI m_ResultUI; // 0x330
	private GameObject m_ResultGlitter; // 0x338
	private bool m_IsPlayResultVoice; // 0x340
	private bool m_IsGetBonus; // 0x341
	private static bool m_ContinueResult; // 0x4
	private int m_AssistLevel; // 0x344
	private float m_AssistDamage; // 0x348

	// Properties
	private bool IsPlayDrawSE { get; set; }
	public bool IsAssist { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2BFB30 Offset: 0x2BFC31 VA: 0x2BFB30
	// RVA: 0x2EF9870 Offset: 0x2EF9971 VA: 0x2EF9870
	private bool get_IsPlayDrawSE() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFB40 Offset: 0x2BFC41 VA: 0x2BFB40
	// RVA: 0x2EF9880 Offset: 0x2EF9981 VA: 0x2EF9880
	private void set_IsPlayDrawSE(bool value) { }

	// RVA: 0x2EF9890 Offset: 0x2EF9991 VA: 0x2EF9890
	public bool get_IsAssist() { }

	// RVA: 0x2EF98A0 Offset: 0x2EF99A1 VA: 0x2EF98A0
	private void EnableFishPrefab() { }

	// RVA: 0x2EF9920 Offset: 0x2EF9A21 VA: 0x2EF9920
	private void PauseHubBGM() { }

	// RVA: 0x2EF99A0 Offset: 0x2EF9AA1 VA: 0x2EF99A0
	private void Init() { }

	// RVA: 0x2EFADB0 Offset: 0x2EFAEB1 VA: 0x2EFADB0
	private void SetGuideActive(bool set) { }

	// RVA: 0x2EFAE30 Offset: 0x2EFAF31 VA: 0x2EFAE30
	private void InitImageRender() { }

	// RVA: 0x2EFB120 Offset: 0x2EFB221 VA: 0x2EFB120
	private void InitBattleRadar() { }

	// RVA: 0x2EFB480 Offset: 0x2EFB581 VA: 0x2EFB480
	private void CreateRodAndLureModel() { }

	// RVA: 0x2EFB850 Offset: 0x2EFB951 VA: 0x2EFB850
	private void TryDestoyRodAndLureModel() { }

	// RVA: 0x2EFB9A0 Offset: 0x2EFBAA1 VA: 0x2EFB9A0
	private void DestroyImageRender() { }

	// RVA: 0x2EFBA70 Offset: 0x2EFBB71 VA: 0x2EFBA70
	private void DestroyRadar() { }

	// RVA: 0x2EFBB10 Offset: 0x2EFBC11 VA: 0x2EFBB10
	private void LoadResource() { }

	// RVA: 0x2EFBCC0 Offset: 0x2EFBDC1 VA: 0x2EFBCC0
	private bool IsLoadingResource() { }

	// RVA: 0x2EFBDD0 Offset: 0x2EFBED1 VA: 0x2EFBDD0
	private void UnloadResource() { }

	// RVA: 0x2EFBED0 Offset: 0x2EFBFD1 VA: 0x2EFBED0
	private void UpdateRipples() { }

	// RVA: 0x2EFBF50 Offset: 0x2EFC051 VA: 0x2EFBF50
	private void SetEnablePopRipples(bool set) { }

	// RVA: 0x2EFBF70 Offset: 0x2EFC071 VA: 0x2EFBF70
	private void DestroyAllRippeles() { }

	// RVA: 0x2EFBFE0 Offset: 0x2EFC0E1 VA: 0x2EFBFE0
	private void ReadyFirstRod() { }

	// RVA: 0x2EFC230 Offset: 0x2EFC331 VA: 0x2EFC230
	private void TickSelectRodWait() { }

	// RVA: 0x2EFC2E0 Offset: 0x2EFC3E1 VA: 0x2EFC2E0
	private void CreateTitleBar() { }

	// RVA: 0x2EFC4D0 Offset: 0x2EFC5D1 VA: 0x2EFC4D0
	private void CloseTitleBar() { }

	// RVA: 0x2EFC630 Offset: 0x2EFC731 VA: 0x2EFC630
	private void CreateRodSelectMenu() { }

	// RVA: 0x2EFC870 Offset: 0x2EFC971 VA: 0x2EFC870
	private void TickRodSelectCamera() { }

	// RVA: 0x2EFCD50 Offset: 0x2EFCE51 VA: 0x2EFCD50
	private void CreateAssistMenu() { }

	// RVA: 0x2EFCE20 Offset: 0x2EFCF21 VA: 0x2EFCE20
	private void CallAssistEnhance() { }

	// RVA: 0x2EFCF70 Offset: 0x2EFD071 VA: 0x2EFCF70
	private void TickMoveCircle() { }

	// RVA: 0x2EFDCC0 Offset: 0x2EFDDC1 VA: 0x2EFDCC0
	private void TickThrowIn() { }

	// RVA: 0x2EFE7C0 Offset: 0x2EFE8C1 VA: 0x2EFE7C0
	private void TickWaitCatch() { }

	// RVA: 0x2EFFAF0 Offset: 0x2EFFBF1 VA: 0x2EFFAF0
	private void TickWaitCancel() { }

	// RVA: 0x2EFFFA0 Offset: 0x2F000A1 VA: 0x2EFFFA0
	private void ProcessAnnounceFailed() { }

	// RVA: 0x2F00070 Offset: 0x2F00171 VA: 0x2F00070
	private void TickHitPopup() { }

	// RVA: 0x2F00360 Offset: 0x2F00461 VA: 0x2F00360
	private void TickAssistAttack() { }

	// RVA: 0x2F00470 Offset: 0x2F00571 VA: 0x2F00470
	private void UpdatePlayerAnime() { }

	// RVA: 0x2F00560 Offset: 0x2F00661 VA: 0x2F00560
	private void SetPlayerAnimeState(FishingGameSequence.FishingAngleState setState) { }

	// RVA: 0x2EFADF0 Offset: 0x2EFAEF1 VA: 0x2EFADF0
	private void ResetRadicalParam() { }

	// RVA: 0x2F00580 Offset: 0x2F00681 VA: 0x2F00580
	private void TickBattle() { }

	// RVA: 0x2F019C0 Offset: 0x2F01AC1 VA: 0x2F019C0
	private void TickBattleLethal() { }

	// RVA: 0x2F020E0 Offset: 0x2F021E1 VA: 0x2F020E0
	private bool TickWaitDisableUI() { }

	// RVA: 0x2F02190 Offset: 0x2F02291 VA: 0x2F02190
	private void PhaseBattleFailed() { }

	// RVA: 0x2F02480 Offset: 0x2F02581 VA: 0x2F02480
	private void TickDefeatMovie() { }

	// RVA: 0x2F03220 Offset: 0x2F03321 VA: 0x2F03220
	private void TickResult() { }

	// RVA: 0x2F03800 Offset: 0x2F03901 VA: 0x2F03800
	private void CloseResult() { }

	// RVA: 0x2F03820 Offset: 0x2F03921 VA: 0x2F03820
	public bool IsClosedResult() { }

	// RVA: 0x2F03840 Offset: 0x2F03941 VA: 0x2F03840
	private void ExitResult() { }

	// RVA: 0x2F038E0 Offset: 0x2F039E1 VA: 0x2F038E0
	private void GetPrizeBond() { }

	// RVA: 0x2F03AC0 Offset: 0x2F03BC1 VA: 0x2F03AC0
	private void GetPrizeItem() { }

	// RVA: 0x2F03CE0 Offset: 0x2F03DE1 VA: 0x2F03CE0
	private void DecreasePlayCount() { }

	// RVA: 0x2F03F20 Offset: 0x2F04021 VA: 0x2F03F20
	private void IncreasePlayCounter() { }

	// RVA: 0x2F040D0 Offset: 0x2F041D1 VA: 0x2F040D0
	private void CreateContinueDialog() { }

	// RVA: 0x2F043C0 Offset: 0x2F044C1 VA: 0x2F043C0
	private void InitContinue() { }

	// RVA: 0x2F044A0 Offset: 0x2F045A1 VA: 0x2F044A0
	private void Exit() { }

	// RVA: 0x2F04A30 Offset: 0x2F04B31 VA: 0x2F04A30
	private void PlayDrawSE() { }

	// RVA: 0x2F04B10 Offset: 0x2F04C11 VA: 0x2F04B10
	private void StopDrawSE() { }

	// RVA: 0x2F04BA0 Offset: 0x2F04CA1 VA: 0x2F04BA0
	private void StopAllContinueSE() { }

	// RVA: 0x2EFDB50 Offset: 0x2EFDC51 VA: 0x2EFDB50
	private void JumpThrowIn() { }

	// RVA: 0x2EFE2A0 Offset: 0x2EFE3A1 VA: 0x2EFE2A0
	private void JumpWaitCatch() { }

	// RVA: 0x2EFF600 Offset: 0x2EFF701 VA: 0x2EFF600
	private void JumpHitPopup() { }

	// RVA: 0x2EFF380 Offset: 0x2EFF481 VA: 0x2EFF380
	private void JumpAssistAttack() { }

	// RVA: 0x2F001E0 Offset: 0x2F002E1 VA: 0x2F001E0
	private void JumpBattle() { }

	// RVA: 0x2F01730 Offset: 0x2F01831 VA: 0x2F01730
	private void JumpBattleLethal() { }

	// RVA: 0x2F01D90 Offset: 0x2F01E91 VA: 0x2F01D90
	private void JumpDefeatMovie() { }

	// RVA: 0x2F02910 Offset: 0x2F02A11 VA: 0x2F02910
	private void JumpResult() { }

	// RVA: 0x2F04D30 Offset: 0x2F04E31 VA: 0x2F04D30
	private void JumpMoveCircle() { }

	// RVA: 0x2EFF810 Offset: 0x2EFF911 VA: 0x2EFF810
	private void JumpWaitCancel() { }

	// RVA: 0x2EFFF30 Offset: 0x2F00031 VA: 0x2EFFF30
	private void JumpAnnounceFailed() { }

	// RVA: 0x2EFD910 Offset: 0x2EFDA11 VA: 0x2EFD910
	private void JumpSelectRod() { }

	// RVA: 0x2F051B0 Offset: 0x2F052B1 VA: 0x2F051B0
	private void JumpGetPrize() { }

	// RVA: 0x2F02410 Offset: 0x2F02511 VA: 0x2F02410
	private void JumpCheckContinue() { }

	// RVA: 0x2F01890 Offset: 0x2F01991 VA: 0x2F01890
	private void JumpBattleFailed() { }

	// RVA: 0x2EFC790 Offset: 0x2EFC891 VA: 0x2EFC790
	private void VoiceRodSelect() { }

	// RVA: 0x2F050D0 Offset: 0x2F051D1 VA: 0x2F050D0
	private void VoiceMoveCircle() { }

	// RVA: 0x2EFFA10 Offset: 0x2EFFB11 VA: 0x2EFFA10
	private void VoiceHit() { }

	// RVA: 0x2F01570 Offset: 0x2F01671 VA: 0x2F01570
	private void VoiceAdviceLeft() { }

	// RVA: 0x2F01650 Offset: 0x2F01751 VA: 0x2F01650
	private void VoiceAdviceRight() { }

	// RVA: 0x2F02330 Offset: 0x2F02431 VA: 0x2F02330
	private void VoiceEscape() { }

	// RVA: 0x2F03720 Offset: 0x2F03821 VA: 0x2F03720
	private void VoiceSuccessGiant() { }

	// RVA: 0x2F03640 Offset: 0x2F03741 VA: 0x2F03640
	private void VoiceSuccessMiddle() { }

	// RVA: 0x2F03560 Offset: 0x2F03661 VA: 0x2F03560
	private void VoiceSuccessSmall() { }

	// RVA: 0x2F042E0 Offset: 0x2F043E1 VA: 0x2F042E0
	private void VoiceCheckContinue() { }

	// RVA: 0x2F05220 Offset: 0x2F05321 VA: 0x2F05220
	private void VoiceEndGame() { }

	// RVA: 0x2F05300 Offset: 0x2F05401 VA: 0x2F05300 Slot: 15
	protected override void OnShutdown() { }

	// RVA: 0x2F05370 Offset: 0x2F05471 VA: 0x2F05370
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2F074A0 Offset: 0x2F075A1 VA: 0x2F074A0
	public void .ctor() { }

	// RVA: 0x2F083C0 Offset: 0x2F084C1 VA: 0x2F083C0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFB50 Offset: 0x2BFC51 VA: 0x2BFB50
	// RVA: 0x2F08420 Offset: 0x2F08521 VA: 0x2F08420
	private void <Init>b__170_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2BFB60 Offset: 0x2BFC61 VA: 0x2BFB60
	// RVA: 0x2F08890 Offset: 0x2F08991 VA: 0x2F08890
	private void <CreateAssistMenu>b__190_0(int r) { }
}

