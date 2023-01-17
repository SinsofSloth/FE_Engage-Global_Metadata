// Namespace: App
public class UnitInfo : SingletonProcInst<UnitInfo> // TypeDefIndex: 11846
{
	// Fields
	private const int InvalidUnitXZ = -2147483648;
	public const float c_TransitionDuration = 0.4;
	private Stack<UnitInfo.Mode> m_ModeStack; // 0x78
	private UnitInfo.Window[] m_Windows; // 0x80
	private static bool m_bUpdateSight; // 0x0
	private static GameObject m_LookAtObj; // 0x8

	// Methods

	// RVA: 0x23EE030 Offset: 0x23EE131 VA: 0x23EE030
	private void .ctor() { }

	// RVA: 0x23EE0C0 Offset: 0x23EE1C1 VA: 0x23EE0C0
	private void Construct(Unit leftUnit, Unit rightUnit) { }

	// RVA: 0x23EE2B0 Offset: 0x23EE3B1 VA: 0x23EE2B0 Slot: 10
	protected override void OnDispose() { }

	// RVA: 0x23EE410 Offset: 0x23EE511 VA: 0x23EE410
	private void PrepareCharaModel() { }

	// RVA: 0x23EE480 Offset: 0x23EE581 VA: 0x23EE480
	private bool IsPreparingCharaModel() { }

	// RVA: 0x23EE510 Offset: 0x23EE611 VA: 0x23EE510
	private void PrepareWindow() { }

	// RVA: 0x23EE580 Offset: 0x23EE681 VA: 0x23EE580
	private bool IsPreparingWindow() { }

	// RVA: 0x23EE610 Offset: 0x23EE711 VA: 0x23EE610
	private void Postprepare() { }

	// RVA: 0x23EE680 Offset: 0x23EE781 VA: 0x23EE680
	private void Tick() { }

	// RVA: 0x23EEBA0 Offset: 0x23EECA1 VA: 0x23EEBA0
	public static void CreateAsync(ProcInst super) { }

	// RVA: 0x23EED80 Offset: 0x23EEE81 VA: 0x23EED80
	public static void CreateBindAsync(ProcInst super) { }

	// RVA: 0x23EECF0 Offset: 0x23EEDF1 VA: 0x23EECF0
	private static void CreateImpl(ProcInst super, UnitInfo p) { }

	// RVA: 0x23EEED0 Offset: 0x23EEFD1 VA: 0x23EEED0
	private static void CreateBindImpl(ProcInst super, UnitInfo p) { }

	// RVA: 0x23EEF60 Offset: 0x23EF061 VA: 0x23EEF60
	private static ProcDesc[] CreateDescs(UnitInfo p) { }

	// RVA: 0x23EF330 Offset: 0x23EF431 VA: 0x23EF330
	public static GameObject GetCurrentWindowObject() { }

	// RVA: 0x23EF400 Offset: 0x23EF501 VA: 0x23EF400
	public static void SetUnit(UnitInfo.Side side, Unit unit, bool bRelax = False, bool bReverseRotation = True, bool isDelayLoad = True, Action onSetupDoneCallback) { }

	// RVA: 0x23EF530 Offset: 0x23EF631 VA: 0x23EF530
	public static void SetUnitBattleInfo(UnitInfo.Side side, Unit unit, UnitItem unitItem) { }

	// RVA: 0x23EF680 Offset: 0x23EF781 VA: 0x23EF680
	public static void SetOverrideCreateReserveUnitItem(UnitInfo.Side side, UnitItem unitItem) { }

	// RVA: 0x23EF780 Offset: 0x23EF881 VA: 0x23EF780
	public static void SetUnitHub(UnitInfo.Side side, Unit unit, bool bRelax = False, bool bReverseRotation = True, bool isDelayLoad = True) { }

	// RVA: 0x23EF8A0 Offset: 0x23EF9A1 VA: 0x23EF8A0
	public static void SetUnitRelay(UnitInfo.Side side, PersonData person, JobData job, UnitEdit edit) { }

	// RVA: 0x23EF9B0 Offset: 0x23EFAB1 VA: 0x23EF9B0
	public static void ResetUnit(UnitInfo.Side side, UnitItem unitItem, bool bRelax = False, bool bReverseRotation = True, bool isDelayLoad = True) { }

	// RVA: 0x23EFB00 Offset: 0x23EFC01 VA: 0x23EFB00
	public static void ResetUnit() { }

	// RVA: 0x23EFC20 Offset: 0x23EFD21 VA: 0x23EFC20
	public static void AddCharaRot(UnitInfo.Side side, Quaternion quaternion) { }

	// RVA: 0x23EFD40 Offset: 0x23EFE41 VA: 0x23EFD40
	public static void SetLeftCameraAdjustY() { }

	// RVA: 0x23EFE10 Offset: 0x23EFF11 VA: 0x23EFE10
	public static void PlayCharaVoice(UnitInfo.Side side, string personSwitchName, string engageSwitchName, string eventName) { }

	// RVA: 0x23EFF20 Offset: 0x23F0021 VA: 0x23EFF20
	public static void ReserveCharaVoice(UnitInfo.Side side, string personSwitchName, string engageSwitchName, string eventName) { }

	// RVA: 0x23F0030 Offset: 0x23F0131 VA: 0x23F0030
	public static void PlayReservedCharaVoice(UnitInfo.Side side) { }

	// RVA: 0x23F0120 Offset: 0x23F0221 VA: 0x23F0120
	public static void SetWeaponShopChara(UnitInfo.Side side) { }

	// RVA: 0x23F0210 Offset: 0x23F0311 VA: 0x23F0210
	public static void SetSummonChara() { }

	// RVA: 0x23F02F0 Offset: 0x23F03F1 VA: 0x23F02F0
	public static void SetGod(UnitInfo.Side side, GodUnit god, bool bRelax = False, bool bReverseRotation = True, Action onSetupDoneCallback) { }

	// RVA: 0x23F0410 Offset: 0x23F0511 VA: 0x23F0410
	public static void SetRightForRingCleaning(GodUnit god, RingCleaningSequence.GodType type, bool bRelax = False) { }

	// RVA: 0x23F0490 Offset: 0x23F0591 VA: 0x23F0490
	public static void SetEfficacyAttack(UnitInfo.Side side, bool isEfficacy) { }

	// RVA: 0x23F0580 Offset: 0x23F0681 VA: 0x23F0580
	public static void SetRelaxAnime(UnitInfo.Side side, float transitionDuration = 0) { }

	// RVA: 0x23F0680 Offset: 0x23F0781 VA: 0x23F0680
	public static void SetStatusAnime(UnitInfo.Side side, float transitionDuration = 0) { }

	// RVA: 0x23F0780 Offset: 0x23F0881 VA: 0x23F0780
	public static void SetFortuneTellingGoodAnime(UnitInfo.Side side, bool isAllowUnitNull = False) { }

	// RVA: 0x23F0870 Offset: 0x23F0971 VA: 0x23F0870
	public static void SetFortuneTellingBadAnime(UnitInfo.Side side, bool isAllowUnitNull = False) { }

	// RVA: 0x23F0960 Offset: 0x23F0A61 VA: 0x23F0960
	public static void SetSelectGodNormalFace(UnitInfo.Side side) { }

	// RVA: 0x23F0A50 Offset: 0x23F0B51 VA: 0x23F0A50
	public static void UpdateCurrentUnit(UnitInfo.Side side) { }

	// RVA: 0x23F0B40 Offset: 0x23F0C41 VA: 0x23F0B40
	public static Unit GetUnit(UnitInfo.Side side) { }

	// RVA: 0x23F0C20 Offset: 0x23F0D21 VA: 0x23F0C20
	public static GodUnit GetGod(UnitInfo.Side side) { }

	// RVA: 0x23F0D00 Offset: 0x23F0E01 VA: 0x23F0D00
	public static RenderTexture GetRenderTexture(UnitInfo.Side side) { }

	// RVA: 0x23F0DF0 Offset: 0x23F0EF1 VA: 0x23F0DF0
	public static Camera GetFaceCameraComponent(UnitInfo.Side side) { }

	// RVA: 0x23F0EE0 Offset: 0x23F0FE1 VA: 0x23F0EE0
	public static bool IsHide() { }

	// RVA: 0x23F0FD0 Offset: 0x23F10D1 VA: 0x23F0FD0
	public static void PushMode(UnitInfo.Mode mode) { }

	// RVA: 0x23F1110 Offset: 0x23F1211 VA: 0x23F1110
	public static void PushModeSimple() { }

	// RVA: 0x23F1180 Offset: 0x23F1281 VA: 0x23F1180
	public static void PushModeHide() { }

	// RVA: 0x23F11F0 Offset: 0x23F12F1 VA: 0x23F11F0
	public static void PushModeModelOnly() { }

	// RVA: 0x23F1260 Offset: 0x23F1361 VA: 0x23F1260
	public static void PopMode() { }

	// RVA: 0x23F13A0 Offset: 0x23F14A1 VA: 0x23F13A0
	public static void SetMode(UnitInfo.Mode mode) { }

	// RVA: 0x23F1590 Offset: 0x23F1691 VA: 0x23F1590
	public static void SetModeIfHide(UnitInfo.Mode mode) { }

	// RVA: 0x23F1740 Offset: 0x23F1841 VA: 0x23F1740
	public static void SetCurrentModeToGameUserData() { }

	// RVA: 0x23F1850 Offset: 0x23F1951 VA: 0x23F1850
	public static void PushModeFromGameUserData() { }

	// RVA: 0x23F1900 Offset: 0x23F1A01 VA: 0x23F1900
	public static void SetModeFromGameUserDataIfHide() { }

	// RVA: 0x23F19B0 Offset: 0x23F1AB1 VA: 0x23F19B0
	public static void SetVisible(bool isVisible) { }

	// RVA: 0x23F1B20 Offset: 0x23F1C21 VA: 0x23F1B20
	public static void SetVisible(UnitInfo.Side side, bool isVisible) { }

	// RVA: 0x23F1C60 Offset: 0x23F1D61 VA: 0x23F1C60
	public static void ResetAlpha() { }

	// RVA: 0x23F1E50 Offset: 0x23F1F51 VA: 0x23F1E50
	public static void ToggleVisible() { }

	// RVA: 0x23F1F50 Offset: 0x23F2051 VA: 0x23F1F50
	public static void ToggleVisible(UnitInfo.Side side) { }

	// RVA: 0x23F2040 Offset: 0x23F2141 VA: 0x23F2040
	public static void ToVisible() { }

	// RVA: 0x23F20B0 Offset: 0x23F21B1 VA: 0x23F20B0
	public static void ToVisible(UnitInfo.Side side) { }

	// RVA: 0x23F2120 Offset: 0x23F2221 VA: 0x23F2120
	public static void ToInvisible() { }

	// RVA: 0x23F2190 Offset: 0x23F2291 VA: 0x23F2190
	public static void ToInvisible(UnitInfo.Side side) { }

	// RVA: 0x23F2200 Offset: 0x23F2301 VA: 0x23F2200
	public static bool IsVisible(UnitInfo.Side side) { }

	// RVA: 0x23F22F0 Offset: 0x23F23F1 VA: 0x23F22F0
	public static void CharaOnlyOn(bool isChangeCharaModelAnim = True) { }

	// RVA: 0x23F2400 Offset: 0x23F2501 VA: 0x23F2400
	public static void CharaOnlyOff() { }

	// RVA: 0x23F2500 Offset: 0x23F2601 VA: 0x23F2500
	public static bool IsCharaOnlyTransition() { }

	// RVA: 0x23F2630 Offset: 0x23F2731 VA: 0x23F2630
	public static void InitStandByAnime() { }

	// RVA: 0x23F2740 Offset: 0x23F2841 VA: 0x23F2740
	public static void UpdateOffenseStandByAnime(UnitItem unitItem, bool isWeaponShop = False) { }

	// RVA: 0x23F2830 Offset: 0x23F2931 VA: 0x23F2830
	public static void UpdateDefenseStandByAnime(UnitItem unitItem, bool isWeaponShop = False) { }

	// RVA: 0x23F2920 Offset: 0x23F2A21 VA: 0x23F2920
	public static void HideWeapon() { }

	// RVA: 0x23F2A20 Offset: 0x23F2B21 VA: 0x23F2A20
	public static void TransparentOn(UnitInfo.Side side) { }

	// RVA: 0x23F2B10 Offset: 0x23F2C11 VA: 0x23F2B10
	public static void TransparentOff(UnitInfo.Side side) { }

	// RVA: 0x23F2C00 Offset: 0x23F2D01 VA: 0x23F2C00
	private static Transform GetHeadLocator(UnitInfo.Window window) { }

	// RVA: 0x23EE740 Offset: 0x23EE841 VA: 0x23EE740
	public static void SetSight() { }

	// RVA: 0x23F2C20 Offset: 0x23F2D21 VA: 0x23F2C20
	public static void SetHeadLocator(UnitInfo.Side side, Transform transform, float weight, bool isWeightInterpolated) { }

	// RVA: 0x23F2D20 Offset: 0x23F2E21 VA: 0x23F2D20
	public static void SetLookAt(UnitInfo.Side side, Transform transform) { }

	// RVA: 0x23F2DF0 Offset: 0x23F2EF1 VA: 0x23F2DF0
	public static void SetLookAtCamera(UnitInfo.Side side) { }

	// RVA: 0x23F2EC0 Offset: 0x23F2FC1 VA: 0x23F2EC0
	public static void SetEyesWeight(UnitInfo.Side side, float eyesWeight) { }

	// RVA: 0x23F2FA0 Offset: 0x23F30A1 VA: 0x23F2FA0
	public static bool IsCharaVisible(UnitInfo.Side side) { }

	// RVA: 0x23F3090 Offset: 0x23F3191 VA: 0x23F3090
	public static void SetVisibleOfStatus(UnitInfo.Side side, UnitInfo.Mode mode, bool isVisible) { }

	// RVA: 0x23F31A0 Offset: 0x23F32A1 VA: 0x23F31A0
	public static bool IsVisibleStatus(UnitInfo.Side side, UnitInfo.Mode mode) { }

	// RVA: 0x23F32A0 Offset: 0x23F33A1 VA: 0x23F32A0
	public static void HideCharaImage(UnitInfo.Side side) { }

	// RVA: 0x23F3390 Offset: 0x23F3491 VA: 0x23F3390
	public static void ShowCharaImage(UnitInfo.Side side) { }

	[ConditionalAttribute] // RVA: 0x2C6C50 Offset: 0x2C6D51 VA: 0x2C6C50
	// RVA: 0x23F3480 Offset: 0x23F3581 VA: 0x23F3480
	public static void DumpMode() { }

	// RVA: 0x23F3740 Offset: 0x23F3841 VA: 0x23F3740
	private static void .cctor() { }
}

