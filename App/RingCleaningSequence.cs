// Namespace: App
public class RingCleaningSequence : SingletonProcInst<RingCleaningSequence> // TypeDefIndex: 11768
{
	// Fields
	private ResourceHandle m_SceneResourceHandle; // 0x78
	private List<GameObject> m_DisableList; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x299050 Offset: 0x299151 VA: 0x299050
	private readonly string <SceneName>k__BackingField; // 0x88
	private const string InfoPrefab = "UI/Hub/GodRoom/Prefabs/RingCleaningRoot";
	private const string FinishTelopPrefab = "UI/Hub/Telop/RingCleaning/Prefabs/RingCleaningFinish";
	[CompilerGeneratedAttribute] // RVA: 0x299060 Offset: 0x299161 VA: 0x299060
	private string <EngageZonePrefab>k__BackingField; // 0x90
	private RingCleaningRingController m_RingController; // 0x98
	private FaceImagesController m_FaceImage; // 0xA0
	private Camera m_Camera; // 0xA8
	private GameObject m_Info; // 0xB0
	private RingCleaningRoot m_InfoRoot; // 0xB8
	private RingCleaningCloth m_Cloth; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x299070 Offset: 0x299171 VA: 0x299070
	private bool <IsPlayableTelop>k__BackingField; // 0xC8
	private GameObject m_TelopObject; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x299080 Offset: 0x299181 VA: 0x299080
	private static GodUnit <SelectedGodUnit>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x299090 Offset: 0x299191 VA: 0x299090
	private static RingCleaningSequence.GodType <SelectedGodType>k__BackingField; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x2990A0 Offset: 0x2991A1 VA: 0x2990A0
	private static Unit <SelectedUnit>k__BackingField; // 0x10
	private const int WeakNotHitValue = 5;
	private const int WeakHitValue = 15;
	private const int StrongNotHitValue = 15;
	private const int StrongHitValue = 70;

	// Properties
	private string SceneName { get; }
	private string ReturnSceneName { get; }
	private string EngageZonePrefab { get; set; }
	private bool IsPlayableTelop { get; set; }
	public static GodUnit SelectedGodUnit { get; set; }
	public static RingCleaningSequence.GodType SelectedGodType { get; set; }
	public static Unit SelectedUnit { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C65F0 Offset: 0x2C66F1 VA: 0x2C65F0
	// RVA: 0x267DF40 Offset: 0x267E041 VA: 0x267DF40
	private string get_SceneName() { }

	// RVA: 0x267DF50 Offset: 0x267E051 VA: 0x267DF50
	private string get_ReturnSceneName() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6600 Offset: 0x2C6701 VA: 0x2C6600
	// RVA: 0x267DFC0 Offset: 0x267E0C1 VA: 0x267DFC0
	private string get_EngageZonePrefab() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6610 Offset: 0x2C6711 VA: 0x2C6610
	// RVA: 0x267DFD0 Offset: 0x267E0D1 VA: 0x267DFD0
	private void set_EngageZonePrefab(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6620 Offset: 0x2C6721 VA: 0x2C6620
	// RVA: 0x267DFE0 Offset: 0x267E0E1 VA: 0x267DFE0
	private bool get_IsPlayableTelop() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6630 Offset: 0x2C6731 VA: 0x2C6630
	// RVA: 0x267DFF0 Offset: 0x267E0F1 VA: 0x267DFF0
	private void set_IsPlayableTelop(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6640 Offset: 0x2C6741 VA: 0x2C6640
	// RVA: 0x267E000 Offset: 0x267E101 VA: 0x267E000
	public static GodUnit get_SelectedGodUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6650 Offset: 0x2C6751 VA: 0x2C6650
	// RVA: 0x267E050 Offset: 0x267E151 VA: 0x267E050
	public static void set_SelectedGodUnit(GodUnit value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6660 Offset: 0x2C6761 VA: 0x2C6660
	// RVA: 0x267E0B0 Offset: 0x267E1B1 VA: 0x267E0B0
	public static RingCleaningSequence.GodType get_SelectedGodType() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6670 Offset: 0x2C6771 VA: 0x2C6670
	// RVA: 0x267E100 Offset: 0x267E201 VA: 0x267E100
	public static void set_SelectedGodType(RingCleaningSequence.GodType value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6680 Offset: 0x2C6781 VA: 0x2C6680
	// RVA: 0x267E160 Offset: 0x267E261 VA: 0x267E160
	public static Unit get_SelectedUnit() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6690 Offset: 0x2C6791 VA: 0x2C6690
	// RVA: 0x267E1B0 Offset: 0x267E2B1 VA: 0x267E1B0
	public static void set_SelectedUnit(Unit value) { }

	// RVA: 0x267E210 Offset: 0x267E311 VA: 0x267E210
	public void .ctor() { }

	// RVA: 0x267E370 Offset: 0x267E471 VA: 0x267E370
	private void Init() { }

	// RVA: 0x267EAC0 Offset: 0x267EBC1 VA: 0x267EAC0
	private void LoadScene() { }

	// RVA: 0x267EAE0 Offset: 0x267EBE1 VA: 0x267EAE0
	private void LoadPrefabs() { }

	// RVA: 0x267EC40 Offset: 0x267ED41 VA: 0x267EC40
	private bool IsLoadingPrefabs() { }

	// RVA: 0x267ED60 Offset: 0x267EE61 VA: 0x267ED60
	private void CreateObjectFromPrefab() { }

	// RVA: 0x267F150 Offset: 0x267F251 VA: 0x267F150
	private void InitAfterLoadedScene() { }

	// RVA: 0x267F2D0 Offset: 0x267F3D1 VA: 0x267F2D0
	private void InstantiateEngageZone() { }

	// RVA: 0x267F390 Offset: 0x267F491 VA: 0x267F390
	private bool IsLoadingKeyHelp() { }

	// RVA: 0x267F3A0 Offset: 0x267F4A1 VA: 0x267F3A0
	private bool IsCreatingCharacter() { }

	// RVA: 0x267F3D0 Offset: 0x267F4D1 VA: 0x267F3D0
	private void AdjustFaceCamera() { }

	// RVA: 0x267F3E0 Offset: 0x267F4E1 VA: 0x267F3E0
	private void PersistentTick() { }

	// RVA: 0x267F530 Offset: 0x267F631 VA: 0x267F530
	private void StartTick() { }

	// RVA: 0x267F840 Offset: 0x267F941 VA: 0x267F840
	private void Tick() { }

	// RVA: 0x2680310 Offset: 0x2680411 VA: 0x2680310
	private void CleanRing(RingCleaningSequence.Strength strength, RingCleaningSequence.HitResult hitResult) { }

	// RVA: 0x26803F0 Offset: 0x26804F1 VA: 0x26803F0
	private void CleanRingWeak(RingCleaningSequence.HitResult hitResult) { }

	// RVA: 0x2680850 Offset: 0x2680951 VA: 0x2680850
	private void CleanRingStrong(RingCleaningSequence.HitResult hitResult) { }

	// RVA: 0x2680EC0 Offset: 0x2680FC1 VA: 0x2680EC0
	private void CompleteCleaning(RingCleaningSequence.Strength strength) { }

	// RVA: 0x26814B0 Offset: 0x26815B1 VA: 0x26814B0
	private string GetSelectedGodUnitGid() { }

	// RVA: 0x2681590 Offset: 0x2681691 VA: 0x2681590
	private void CleaningAction() { }

	// RVA: 0x26815A0 Offset: 0x26816A1 VA: 0x26815A0
	private void StrongCleaningAction() { }

	// RVA: 0x2680DC0 Offset: 0x2680EC1 VA: 0x2680DC0
	private int DecreaseDirty(int decrease) { }

	// RVA: 0x26810C0 Offset: 0x26811C1 VA: 0x26810C0
	private void AddBondExp(bool isFinish, RingCleaningSequence.Strength strength) { }

	[IteratorStateMachineAttribute] // RVA: 0x2C66A0 Offset: 0x2C67A1 VA: 0x2C66A0
	// RVA: 0x26816F0 Offset: 0x26817F1 VA: 0x26816F0
	private IEnumerator ResetRotation() { }

	[IteratorStateMachineAttribute] // RVA: 0x2C6710 Offset: 0x2C6811 VA: 0x2C6710
	// RVA: 0x2681770 Offset: 0x2681871 VA: 0x2681770
	private IEnumerator PlayTelop() { }

	// RVA: 0x26817F0 Offset: 0x26818F1 VA: 0x26817F0
	private void End() { }

	// RVA: 0x2681870 Offset: 0x2681971 VA: 0x2681870
	private void UnloadScene() { }

	// RVA: 0x2681880 Offset: 0x2681981 VA: 0x2681880
	private void Final() { }

	// RVA: 0x267EA10 Offset: 0x267EB11 VA: 0x267EA10
	private void BackgroundUnbind() { }

	// RVA: 0x2681DD0 Offset: 0x2681ED1 VA: 0x2681DD0
	private void BackgroundBind() { }

	// RVA: 0x2680CE0 Offset: 0x2680DE1 VA: 0x2680CE0
	private void PlayGlitterEffect(RingCleaningSequence.Strength strength, RingCleaningSequence.HitResult hitResult) { }

	// RVA: 0x2680D90 Offset: 0x2680E91 VA: 0x2680D90
	private int GetCleaningValue(RingCleaningSequence.Strength strength, bool isHit) { }

	// RVA: 0x2681E70 Offset: 0x2681F71 VA: 0x2681E70
	public static int GetMultiChangeIndex(RingCleaningSequence.GodType type) { }

	// RVA: 0x267C6E0 Offset: 0x267C7E1 VA: 0x267C6E0
	public static void CreateBind(ProcInst super) { }

	// RVA: 0x2681E80 Offset: 0x2681F81 VA: 0x2681E80
	public static void ForEachCanCleanGodUnit(Action<GodUnit> func) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6780 Offset: 0x2C6881 VA: 0x2C6780
	// RVA: 0x26820F0 Offset: 0x26821F1 VA: 0x26820F0
	private void <Tick>b__57_0() { }
}

