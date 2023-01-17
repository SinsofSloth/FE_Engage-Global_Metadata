// Namespace: App
public class PhotographDisposManager // TypeDefIndex: 11468
{
	// Fields
	private static readonly string s_ActiveEffectPath; // 0x0
	private static readonly string s_InactiveEffectPath; // 0x8
	private static readonly string[] s_AnimeControllerPathList; // 0x10
	private List<PhotographDisposInfo> m_DisposInfoList; // 0x10
	private PhotographDisposInfo m_CurrentDisposInfo; // 0x18
	private bool m_IsRecordDispos; // 0x20
	private string m_CharacteIdOld; // 0x28
	private PhotographPauseData m_PauseDataOld; // 0x30
	private List<GameObject> m_DisposEffectList; // 0x38
	private AccessoryData m_BodyAccDataOld; // 0x40
	private AccessoryData m_FaceAccDataOld; // 0x48
	private ItemData m_WeaponDataOld; // 0x50

	// Properties
	public List<PhotographDisposInfo> DisposInfoList { get; }
	public PhotographDisposInfo CurrentDisposInfo { get; }
	public int CurrentDisposIdx { get; }
	private GameObject CurrentDisposEffect { get; }

	// Methods

	// RVA: 0x2A2D220 Offset: 0x2A2D321 VA: 0x2A2D220
	public List<PhotographDisposInfo> get_DisposInfoList() { }

	// RVA: 0x2A2D230 Offset: 0x2A2D331 VA: 0x2A2D230
	public PhotographDisposInfo get_CurrentDisposInfo() { }

	// RVA: 0x2A2D240 Offset: 0x2A2D341 VA: 0x2A2D240
	public int get_CurrentDisposIdx() { }

	// RVA: 0x2A2D2A0 Offset: 0x2A2D3A1 VA: 0x2A2D2A0
	private GameObject get_CurrentDisposEffect() { }

	// RVA: 0x2A2D340 Offset: 0x2A2D441 VA: 0x2A2D340
	public void SetUp(PhotographSpotData selectSpot, GameObject currentSpot) { }

	// RVA: 0x2A2D8F0 Offset: 0x2A2D9F1 VA: 0x2A2D8F0
	public bool IsLoadingCharacter() { }

	// RVA: 0x2A2DA50 Offset: 0x2A2DB51 VA: 0x2A2DA50
	public void RandomDispos() { }

	// RVA: 0x2A2DD80 Offset: 0x2A2DE81 VA: 0x2A2DD80
	public void ChangeAcc(bool isBody, bool isNext) { }

	// RVA: 0x2A2DEC0 Offset: 0x2A2DFC1 VA: 0x2A2DEC0
	public void ChangeAcc(AccessoryData bodyAcc, AccessoryData faceAcc) { }

	// RVA: 0x2A2DB10 Offset: 0x2A2DC11 VA: 0x2A2DB10
	public void EditDispos(string characterId, PhotographPauseData pauseData, ItemData weaponData, AccessoryData bodyAcc, AccessoryData faceAcc, bool isRandom = False) { }

	// RVA: 0x2A2DEE0 Offset: 0x2A2DFE1 VA: 0x2A2DEE0
	public void DecisionDispos() { }

	// RVA: 0x2A2E080 Offset: 0x2A2E181 VA: 0x2A2E080
	public void CancelDispos() { }

	// RVA: 0x2A2E2B0 Offset: 0x2A2E3B1 VA: 0x2A2E2B0
	public void DisposEffectFadeIn(bool isOnlyCurrentDispos) { }

	// RVA: 0x2A2E460 Offset: 0x2A2E561 VA: 0x2A2E460
	public void DisposEffectFadeOut() { }

	// RVA: 0x2A2E570 Offset: 0x2A2E671 VA: 0x2A2E570
	public void ChangeDispos(bool isTrigger, bool isNext) { }

	// RVA: 0x2A2E980 Offset: 0x2A2EA81 VA: 0x2A2E980
	public void ChangeIsLookAtCamera() { }

	// RVA: 0x2A28810 Offset: 0x2A28911 VA: 0x2A28810
	public void ResetLookAtRate() { }

	// RVA: 0x2A2EA90 Offset: 0x2A2EB91 VA: 0x2A2EA90
	public void End() { }

	// RVA: 0x2A2EB90 Offset: 0x2A2EC91 VA: 0x2A2EB90
	public static void LoadResource() { }

	// RVA: 0x2A2EFC0 Offset: 0x2A2F0C1 VA: 0x2A2EFC0
	public static bool IsLoadingResource() { }

	// RVA: 0x2A2F180 Offset: 0x2A2F281 VA: 0x2A2F180
	public static void UnloadResource() { }

	// RVA: 0x2A2F2C0 Offset: 0x2A2F3C1 VA: 0x2A2F2C0
	public void .ctor() { }

	// RVA: 0x2A2F3A0 Offset: 0x2A2F4A1 VA: 0x2A2F3A0
	private static void .cctor() { }
}

