// Namespace: App
public class UnitInfoWindowCharaModel // TypeDefIndex: 11874
{
	// Fields
	private static readonly string PrefabPath; // 0x0
	private static readonly int AnimHashIsCharaOnly; // 0x8
	private static readonly int AnimHashIsStandBy; // 0xC
	private static readonly int AnimHashIsTransition; // 0x10
	private static readonly int AnimHashIsTransparent; // 0x14
	private static readonly int AnimHashBasicFace; // 0x18
	private static readonly int AnimHashBasicBody; // 0x1C
	private static readonly int AnimHashRingSelectFace; // 0x20
	private static readonly int AnimHashRingSelectBody; // 0x24
	private static readonly int AnimHashFortuneTellingBodyIdle; // 0x28
	private static readonly int AnimHashFortuneTellingFaceGood; // 0x2C
	private static readonly int AnimHashFortuneTellingBodyGood; // 0x30
	private static readonly int AnimHashFortuneTellingFaceBad; // 0x34
	private static readonly int AnimHashFortuneTellingBodyBad; // 0x38
	private int m_AnimHashFortuneTellingFace; // 0x10
	private static readonly int AnimHashStandByFace; // 0x3C
	private static readonly int AnimHashStandByFacePain; // 0x40
	private static readonly int AnimHashStandByBodyNoWeapon; // 0x44
	private static readonly int[] StandByAnimeHashTable; // 0x48
	private UnitInfoWindowCharaModel.ReservedCharaVoice m_ReservedCharaVoice; // 0x18
	private TResourceHandle<GameObject> m_PrefabHandle; // 0x20
	private GameObject m_GameObject; // 0x28
	private GameObject m_CameraObject; // 0x30
	private RenderTexture m_RenderTexture; // 0x38
	private CustomOffscreenCamera m_OffscreenCamera; // 0x40
	private UnitInfoWindowCharaUpdater m_CharaUpdater; // 0x48
	private Animator m_Animator; // 0x50
	private bool m_IsValid; // 0x58
	private bool m_IsCharaStandBy; // 0x59
	private bool m_IsReverse; // 0x5A
	private bool m_IsReverseRotation; // 0x5B
	private Unit m_Unit; // 0x60
	private GodUnit m_God; // 0x68
	private Unit m_NextLoadUnit; // 0x70
	private GodUnit m_NextLoadGod; // 0x78
	private CharacterFactoryAsync.onLoad m_NextCallback; // 0x80
	private IDisposable m_LoadProcess; // 0x88
	private Character m_Chara; // 0x90
	private UnitItem m_CreateReserveUnitItem; // 0x98
	private bool m_IsEfficacy; // 0xA0
	private Transform m_LookAtTransform; // 0xA8
	private const float c_LookSpeed = 0.2;
	private Action m_OnSetupDoneCallback; // 0xB0
	private GameParam.Holder m_DelayFrameCount; // 0xB8

	// Properties
	public RenderTexture RenderTexture { get; }
	public Camera FaceCameraComponent { get; }
	public GameObject GameObject { get; }

	// Methods

	// RVA: 0x2430040 Offset: 0x2430141 VA: 0x2430040
	public void SetOnSetupDoneCallback(Action callback) { }

	// RVA: 0x2430050 Offset: 0x2430151 VA: 0x2430050
	public void .ctor(bool isDuplicateRenderTexture, bool isReverse) { }

	// RVA: 0x2430180 Offset: 0x2430281 VA: 0x2430180
	public void CreateAsync(bool isDuplicateRenderTexture, bool isReverse) { }

	// RVA: 0x2430330 Offset: 0x2430431 VA: 0x2430330
	public bool IsCreating() { }

	// RVA: 0x2430360 Offset: 0x2430461 VA: 0x2430360
	public void Destroy() { }

	// RVA: 0x2430620 Offset: 0x2430721 VA: 0x2430620
	public bool IsLoadingModel() { }

	// RVA: 0x24306D0 Offset: 0x24307D1 VA: 0x24306D0
	public void SetUnit(Unit unit, int x, int z, bool bRelax = False, bool bReverseRotation = True, bool isDelayLoad = True) { }

	// RVA: 0x2430840 Offset: 0x2430941 VA: 0x2430840
	public void ForcedSetUnit(Unit unit, bool bRelax = False, bool bReverseRotation = True, bool isDelayLoad = True) { }

	// RVA: 0x2430870 Offset: 0x2430971 VA: 0x2430870
	public void SetUnitHub(Unit unit, bool bRelax = False, bool bReverseRotation = True, bool isDelayLoad = True) { }

	// RVA: 0x24308A0 Offset: 0x24309A1 VA: 0x24308A0
	public void SetUnitRelay(PersonData person, JobData job, UnitEdit edit) { }

	// RVA: 0x2430710 Offset: 0x2430811 VA: 0x2430710
	private void SetUnitImpl(Unit unit, bool bRelax, bool bReverseRotation, bool isDelayLoad, bool isChanged, bool isHub) { }

	// RVA: 0x2430FC0 Offset: 0x24310C1 VA: 0x2430FC0
	public void Tick() { }

	// RVA: 0x2430FD0 Offset: 0x24310D1 VA: 0x2430FD0
	private void UpdateMotion() { }

	// RVA: 0x2431140 Offset: 0x2431241 VA: 0x2431140
	private void UpdateVisible() { }

	// RVA: 0x2431320 Offset: 0x2431421 VA: 0x2431320
	private void CreateImpl(bool isDuplicateRenderTexture, bool isReverse) { }

	// RVA: 0x2430490 Offset: 0x2430591 VA: 0x2430490
	private void DeleteCharaModel() { }

	// RVA: 0x2430E00 Offset: 0x2430F01 VA: 0x2430E00
	private void DeleteCharaModel(Character chara) { }

	// RVA: 0x2430EC0 Offset: 0x2430FC1 VA: 0x2430EC0
	private void CreateCharaModel(bool bRelax, bool isHub) { }

	// RVA: 0x2431B40 Offset: 0x2431C41 VA: 0x2431B40
	private void UpdateCharacterAnimation(Character chara, bool bRelax, bool isHub = False, UnitItem unitItem) { }

	// RVA: 0x2432BB0 Offset: 0x2432CB1 VA: 0x2432BB0
	public void SetGod(GodUnit god, bool bRelax, bool bReverseRotation = True, bool isDelayLoad = False) { }

	// RVA: 0x2433060 Offset: 0x2433161 VA: 0x2433060
	public void CharaOnlyOn() { }

	// RVA: 0x2433200 Offset: 0x2433301 VA: 0x2433200
	public void CharaOnlyOff() { }

	// RVA: 0x24332F0 Offset: 0x24333F1 VA: 0x24332F0
	public bool IsCharaOnlyTransition() { }

	// RVA: 0x24333E0 Offset: 0x24334E1 VA: 0x24333E0
	public void SetCreateReserveUnitItem(UnitItem unitItem, bool isOverride) { }

	// RVA: 0x2431EB0 Offset: 0x2431FB1 VA: 0x2431EB0
	public void UpdateStandByAnime(UnitItem unitItem, bool isWeaponShop = False) { }

	// RVA: 0x24335B0 Offset: 0x24336B1 VA: 0x24335B0
	public void SetEfficacyAttack(bool isEfficacy) { }

	// RVA: 0x24336B0 Offset: 0x24337B1 VA: 0x24336B0
	public void SetRelaxAnime(float transitionDuration) { }

	// RVA: 0x2433780 Offset: 0x2433881 VA: 0x2433780
	public void SetStatusAnime(float transitionDuration) { }

	// RVA: 0x2433850 Offset: 0x2433951 VA: 0x2433850
	public void SetFortuneTellingGoodAnime(bool isAllowUnitNull) { }

	// RVA: 0x2433920 Offset: 0x2433A21 VA: 0x2433920
	public void SetFortuneTellingBadAnime(bool isAllowUnitNull) { }

	// RVA: 0x24339F0 Offset: 0x2433AF1 VA: 0x24339F0
	public void SetWeaponShopChara() { }

	// RVA: 0x2433B40 Offset: 0x2433C41 VA: 0x2433B40
	public void SetSummonChara() { }

	// RVA: 0x2433CC0 Offset: 0x2433DC1 VA: 0x2433CC0
	public void UpdateGodSelectNormalFaceAnime() { }

	// RVA: 0x2433480 Offset: 0x2433581 VA: 0x2433480
	public void ShowWeapon(ItemData item) { }

	// RVA: 0x2432AC0 Offset: 0x2432BC1 VA: 0x2432AC0
	public void HideWeapon() { }

	// RVA: 0x2433D80 Offset: 0x2433E81 VA: 0x2433D80
	public void TransparentOn() { }

	// RVA: 0x2433E70 Offset: 0x2433F71 VA: 0x2433E70
	public void TransparentOff() { }

	// RVA: 0x2433F60 Offset: 0x2434061 VA: 0x2433F60
	public void Activate() { }

	// RVA: 0x2434100 Offset: 0x2434201 VA: 0x2434100
	public void Deactivate(bool bClearStandBy = True) { }

	// RVA: 0x24342F0 Offset: 0x24343F1 VA: 0x24342F0
	public void SetCharaImage(Image imageSimple) { }

	// RVA: 0x24343A0 Offset: 0x24344A1 VA: 0x24343A0
	public RenderTexture get_RenderTexture() { }

	// RVA: 0x24343B0 Offset: 0x24344B1 VA: 0x24343B0
	public Camera get_FaceCameraComponent() { }

	// RVA: 0x2434410 Offset: 0x2434511 VA: 0x2434410
	public Transform GetHeadLocator() { }

	// RVA: 0x24334B0 Offset: 0x24335B1 VA: 0x24334B0
	public void SetHeadLocator(Vector3 pos, float defaultWeight = 0) { }

	// RVA: 0x2434530 Offset: 0x2434631 VA: 0x2434530
	public void SetHeadLocator(Transform loc, float defaultWeight = 0, bool isWeightInterpolated = True) { }

	// RVA: 0x2434870 Offset: 0x2434971 VA: 0x2434870
	public void SetLookAt(Transform transform) { }

	// RVA: 0x2434880 Offset: 0x2434981 VA: 0x2434880
	public void SetLookAtCamera() { }

	// RVA: 0x24348C0 Offset: 0x24349C1 VA: 0x24348C0
	public void SetEyesWeight(float defaultEyesWeight = 0.5) { }

	// RVA: 0x2434A00 Offset: 0x2434B01 VA: 0x2434A00
	public bool IsCharaVisible() { }

	// RVA: 0x2434B80 Offset: 0x2434C81 VA: 0x2434B80
	public void PlayCharaVoice(string personSwitchName, string engageSwitchName, string eventName) { }

	// RVA: 0x2434CC0 Offset: 0x2434DC1 VA: 0x2434CC0
	public void ReserveCharaVoice(string personSwitchName, string engageSwitchName, string eventName) { }

	// RVA: 0x2434D80 Offset: 0x2434E81 VA: 0x2434D80
	public void PlayReservedCharaVoice() { }

	// RVA: 0x2434D90 Offset: 0x2434E91 VA: 0x2434D90
	public void AddCharaRot(Quaternion quaternion) { }

	// RVA: 0x2434EF0 Offset: 0x2434FF1 VA: 0x2434EF0
	public void SetCameraAdjustY() { }

	// RVA: 0x24314A0 Offset: 0x24315A1 VA: 0x24314A0
	private bool Setup(bool isDuplicateRenderTexture, bool isReverse) { }

	// RVA: 0x2434FA0 Offset: 0x24350A1 VA: 0x2434FA0
	private GameObject GetGameObject(string objName) { }

	// RVA: 0x2431870 Offset: 0x2431971 VA: 0x2431870
	private void CreateUnitModel(Unit unit, CharacterFactoryAsync.onLoad callback, bool isHub) { }

	// RVA: 0x2432DA0 Offset: 0x2432EA1 VA: 0x2432DA0
	private void CreateGodModel(GodUnit god, CharacterFactoryAsync.onLoad callback) { }

	// RVA: 0x2430960 Offset: 0x2430A61 VA: 0x2430960
	private void CreateUnitModelRelay(PersonData person, JobData job, UnitEdit edit, CharacterFactoryAsync.onLoad callback) { }

	[IteratorStateMachineAttribute] // RVA: 0x2C6F00 Offset: 0x2C7001 VA: 0x2C6F00
	// RVA: 0x2435070 Offset: 0x2435171 VA: 0x2435070
	private IEnumerator WaitLoading() { }

	// RVA: 0x2430C40 Offset: 0x2430D41 VA: 0x2430C40
	private void HideCharaImage() { }

	// RVA: 0x24350F0 Offset: 0x24351F1 VA: 0x24350F0
	private void OnSetupDone() { }

	// RVA: 0x24352F0 Offset: 0x24353F1 VA: 0x24352F0
	private Character CreateCharaModel(Character chara) { }

	// RVA: 0x24328F0 Offset: 0x24329F1 VA: 0x24328F0
	private bool isPain() { }

	// RVA: 0x2435760 Offset: 0x2435861 VA: 0x2435760
	public GameObject get_GameObject() { }

	// RVA: 0x2435770 Offset: 0x2435871 VA: 0x2435770
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6F70 Offset: 0x2C7071 VA: 0x2C6F70
	// RVA: 0x2435DA0 Offset: 0x2435EA1 VA: 0x2435DA0
	private void <SetUnitRelay>b__53_0(Character chara) { }
}

