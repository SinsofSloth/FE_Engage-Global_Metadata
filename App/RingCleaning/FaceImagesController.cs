// Namespace: App.RingCleaning
public class FaceImagesController : MonoBehaviour // TypeDefIndex: 14177
{
	// Fields
	private const string PrefabPath = "UI/Hub/GodRoom/Prefabs/FaceImages";
	private GameObject m_UnitModelRoot; // 0x18
	private GameObject m_GodModelRoot; // 0x20
	private Character m_UnitChara; // 0x28
	private Character m_GodChara; // 0x30
	private Vector3 m_GodEffectPos; // 0x38
	private int m_FinishSetupNum; // 0x44
	private bool m_IsSetupLookAt; // 0x48
	private bool m_IsFirstCleaning; // 0x49
	[SerializeField] // RVA: 0x29DB00 Offset: 0x29DC01 VA: 0x29DB00
	private bool m_カメラの高さをキャラクターの頭部に合わせる; // 0x4A
	[SerializeField] // RVA: 0x29DB10 Offset: 0x29DC11 VA: 0x29DB10
	[RangeAttribute] // RVA: 0x29DB10 Offset: 0x29DC11 VA: 0x29DB10
	private float m_カメラの高さ補正値; // 0x4C
	private const string UnitDefaultAnim = "Relax";
	private int m_GodStrongHitIndex; // 0x50
	private readonly string[] GodStrongHitAnim; // 0x58

	// Methods

	// RVA: 0x2A16BE0 Offset: 0x2A16CE1 VA: 0x2A16BE0
	public static void LoadPrefabAsync() { }

	// RVA: 0x2A16C80 Offset: 0x2A16D81 VA: 0x2A16C80
	public static bool IsLoadingPrefab() { }

	// RVA: 0x2A16D00 Offset: 0x2A16E01 VA: 0x2A16D00
	public static void UnloadPrefab() { }

	// RVA: 0x2A16D80 Offset: 0x2A16E81 VA: 0x2A16D80
	public static FaceImagesController Create() { }

	// RVA: 0x2A16E30 Offset: 0x2A16F31 VA: 0x2A16E30
	public static void Destroy(FaceImagesController content) { }

	// RVA: 0x2A16EB0 Offset: 0x2A16FB1 VA: 0x2A16EB0
	private void Start() { }

	// RVA: 0x2A17340 Offset: 0x2A17441 VA: 0x2A17340
	private void AdjustCameraY(Character character, Camera camera, bool isGod) { }

	// RVA: 0x2A17540 Offset: 0x2A17641 VA: 0x2A17540
	public bool IsCreated() { }

	// RVA: 0x2A17600 Offset: 0x2A17701 VA: 0x2A17600
	private bool IsSetupFinished() { }

	// RVA: 0x2A17610 Offset: 0x2A17711 VA: 0x2A17610
	public void AdjustCameraY() { }

	// RVA: 0x2A176E0 Offset: 0x2A177E1 VA: 0x2A176E0
	private void Update() { }

	// RVA: 0x2A17840 Offset: 0x2A17941 VA: 0x2A17840
	public void PlayNoteEffect(RingCleaningSequence.Strength strength) { }

	// RVA: 0x2A17970 Offset: 0x2A17A71 VA: 0x2A17970
	public void PlayFacial(FaceImagesController.PlayPattern pattern = 0, RingCleaningVoiceData voiceData) { }

	// RVA: 0x2A17B40 Offset: 0x2A17C41 VA: 0x2A17B40
	private void PlayFacialUnit(string state, string overwrite) { }

	// RVA: 0x2A17CB0 Offset: 0x2A17DB1 VA: 0x2A17CB0
	private void PlayFacialGod(string state, string changeAnimName, string overwrite) { }

	// RVA: 0x2A17E40 Offset: 0x2A17F41 VA: 0x2A17E40
	private string GetGodStrongHitFaceAnim() { }

	// RVA: 0x2A17770 Offset: 0x2A17871 VA: 0x2A17770
	private void SetupLookAt(Character character, GameObject target) { }

	// RVA: 0x2A17EA0 Offset: 0x2A17FA1 VA: 0x2A17EA0
	public void .ctor() { }
}

