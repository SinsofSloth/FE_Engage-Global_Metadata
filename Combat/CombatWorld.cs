// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x274390 Offset: 0x274491 VA: 0x274390
[RequireComponent] // RVA: 0x274390 Offset: 0x274491 VA: 0x274390
public sealed class CombatWorld : MonoBehaviour // TypeDefIndex: 8717
{
	// Fields
	private static CombatWorld s_this; // 0x0
	private bool m_bRunning; // 0x18
	private Character[] chrs; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x283EE0 Offset: 0x283FE1 VA: 0x283EE0
	private Character[] <ChainAttackers>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x283EF0 Offset: 0x283FF1 VA: 0x283EF0
	private Character[] <CharaDragonic>k__BackingField; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x283F00 Offset: 0x284001 VA: 0x283F00
	private CombatRecord <Record>k__BackingField; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x283F10 Offset: 0x284011 VA: 0x283F10
	private EffectCatalog <EffectCatalog>k__BackingField; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x283F20 Offset: 0x284021 VA: 0x283F20
	private FSMBuilder <FSMBuilder>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x283F30 Offset: 0x284031 VA: 0x283F30
	private float <CombatTime>k__BackingField; // 0x50
	private CombatTimespace _Timespace; // 0x58
	private CombatStaging _Staging; // 0x60
	private CombatObservable _Observable; // 0x68
	private CombatConfig _Config; // 0x70
	private CombatSkip _Skip; // 0x78
	private CombatInput _Input; // 0x80
	private IDisposable m_InitProcess; // 0x88

	// Properties
	public static CombatWorld Instance { get; }
	public static bool IsRunning { get; }
	public Character[] Characters { get; }
	public Character[] ChainAttackers { get; set; }
	public Character[] CharaDragonic { get; set; }
	public CombatRecord Record { get; set; }
	public EffectCatalog EffectCatalog { get; set; }
	public FSMBuilder FSMBuilder { get; set; }
	public float CombatTime { get; set; }
	public CombatTimespace Timespace { get; }
	public CombatStaging Staging { get; }
	public CombatObservable Observable { get; }
	public CombatConfig Config { get; }
	public CombatSkip Skip { get; }
	public CombatInput Input { get; }

	// Methods

	// RVA: 0x2568850 Offset: 0x2568951 VA: 0x2568850
	public static CombatWorld get_Instance() { }

	// RVA: 0x2576D70 Offset: 0x2576E71 VA: 0x2576D70
	private void Awake() { }

	// RVA: 0x2576EC0 Offset: 0x2576FC1 VA: 0x2576EC0
	private void OnDestroy() { }

	// RVA: 0x256F9F0 Offset: 0x256FAF1 VA: 0x256F9F0
	public static bool get_IsRunning() { }

	// RVA: 0x2577330 Offset: 0x2577431 VA: 0x2577330
	public Character[] get_Characters() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC310 Offset: 0x2AC411 VA: 0x2AC310
	// RVA: 0x2577340 Offset: 0x2577441 VA: 0x2577340
	public Character[] get_ChainAttackers() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC320 Offset: 0x2AC421 VA: 0x2AC320
	// RVA: 0x2577350 Offset: 0x2577451 VA: 0x2577350
	public void set_ChainAttackers(Character[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC330 Offset: 0x2AC431 VA: 0x2AC330
	// RVA: 0x2577360 Offset: 0x2577461 VA: 0x2577360
	public Character[] get_CharaDragonic() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC340 Offset: 0x2AC441 VA: 0x2AC340
	// RVA: 0x2577370 Offset: 0x2577471 VA: 0x2577370
	public void set_CharaDragonic(Character[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC350 Offset: 0x2AC451 VA: 0x2AC350
	// RVA: 0x2577380 Offset: 0x2577481 VA: 0x2577380
	public CombatRecord get_Record() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC360 Offset: 0x2AC461 VA: 0x2AC360
	// RVA: 0x2577390 Offset: 0x2577491 VA: 0x2577390
	private void set_Record(CombatRecord value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC370 Offset: 0x2AC471 VA: 0x2AC370
	// RVA: 0x25773A0 Offset: 0x25774A1 VA: 0x25773A0
	public EffectCatalog get_EffectCatalog() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC380 Offset: 0x2AC481 VA: 0x2AC380
	// RVA: 0x25773B0 Offset: 0x25774B1 VA: 0x25773B0
	private void set_EffectCatalog(EffectCatalog value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC390 Offset: 0x2AC491 VA: 0x2AC390
	// RVA: 0x25773C0 Offset: 0x25774C1 VA: 0x25773C0
	public FSMBuilder get_FSMBuilder() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC3A0 Offset: 0x2AC4A1 VA: 0x2AC3A0
	// RVA: 0x25773D0 Offset: 0x25774D1 VA: 0x25773D0
	private void set_FSMBuilder(FSMBuilder value) { }

	// RVA: 0x2572230 Offset: 0x2572331 VA: 0x2572230
	public static bool IsFromGame() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC3B0 Offset: 0x2AC4B1 VA: 0x2AC3B0
	// RVA: 0x25773E0 Offset: 0x25774E1 VA: 0x25773E0
	public float get_CombatTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC3C0 Offset: 0x2AC4C1 VA: 0x2AC3C0
	// RVA: 0x25773F0 Offset: 0x25774F1 VA: 0x25773F0
	private void set_CombatTime(float value) { }

	// RVA: 0x25720C0 Offset: 0x25721C1 VA: 0x25720C0
	public CombatTimespace get_Timespace() { }

	// RVA: 0x2577400 Offset: 0x2577501 VA: 0x2577400
	public CombatStaging get_Staging() { }

	// RVA: 0x2571B50 Offset: 0x2571C51 VA: 0x2571B50
	public CombatObservable get_Observable() { }

	// RVA: 0x25774C0 Offset: 0x25775C1 VA: 0x25774C0
	public CombatConfig get_Config() { }

	// RVA: 0x2577580 Offset: 0x2577681 VA: 0x2577580
	public CombatSkip get_Skip() { }

	// RVA: 0x2577640 Offset: 0x2577741 VA: 0x2577640
	public CombatInput get_Input() { }

	// RVA: 0x2577700 Offset: 0x2577801 VA: 0x2577700
	public void Run(CombatRecord record) { }

	[IteratorStateMachineAttribute] // RVA: 0x2AC3D0 Offset: 0x2AC4D1 VA: 0x2AC3D0
	// RVA: 0x2577920 Offset: 0x2577A21 VA: 0x2577920
	private IEnumerator InitializeAfterCreateChara() { }

	// RVA: 0x2577840 Offset: 0x2577941 VA: 0x2577840
	public void RegisterHitObserver() { }

	// RVA: 0x2577A80 Offset: 0x2577B81 VA: 0x2577A80
	public void SyncParams() { }

	// RVA: 0x2577BC0 Offset: 0x2577CC1 VA: 0x2577BC0
	private void CreateCharacters() { }

	// RVA: 0x2578210 Offset: 0x2578311 VA: 0x2578210
	private void CreateCharactersImpl(int side, CharacterGameStatus gs, int chainId = -1) { }

	// RVA: 0x2578370 Offset: 0x2578471 VA: 0x2578370
	private bool IsCharacterCreated() { }

	// RVA: 0x25784E0 Offset: 0x25785E1 VA: 0x25784E0
	private void SetupCharacters() { }

	// RVA: 0x25787E0 Offset: 0x25788E1 VA: 0x25787E0
	private void LoadAnimset() { }

	// RVA: 0x2578970 Offset: 0x2578A71 VA: 0x2578970
	private bool IsAnimSetLoading() { }

	// RVA: 0x2578B20 Offset: 0x2578C21 VA: 0x2578B20
	public void FadeInHUD() { }

	// RVA: 0x2578C60 Offset: 0x2578D61 VA: 0x2578C60
	public void FadeOutHUD() { }

	// RVA: 0x2571EC0 Offset: 0x2571FC1 VA: 0x2571EC0
	public void InstantOutHUD() { }

	// RVA: 0x2578DB0 Offset: 0x2578EB1 VA: 0x2578DB0
	public void ForceEnd() { }

	// RVA: 0x2578EA0 Offset: 0x2578FA1 VA: 0x2578EA0
	public void Update() { }

	// RVA: 0x2579160 Offset: 0x2579261 VA: 0x2579160
	public void FinalizeWhenTransCamera() { }

	// RVA: 0x2579240 Offset: 0x2579341 VA: 0x2579240
	public static void CreateInstance(CombatStyle style = 0) { }

	// RVA: 0x256F920 Offset: 0x256FA21 VA: 0x256F920
	public static void DeleteInstance(CombatStyle style = 0) { }

	// RVA: 0x2579400 Offset: 0x2579501 VA: 0x2579400
	public static void CreateCombatEffectInstance仮() { }

	// RVA: 0x2579450 Offset: 0x2579551 VA: 0x2579450
	public static void DeleteCombatEffectInstance仮() { }

	// RVA: 0x2579330 Offset: 0x2579431 VA: 0x2579330
	private static void createInstance(string name) { }

	// RVA: -1 Offset: -1
	private static void deleteInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x229B060 Offset: 0x229B161 VA: 0x229B060
	|-CombatWorld.deleteInstance<CameraManager>
	|-CombatWorld.deleteInstance<CombatWorld>
	|-CombatWorld.deleteInstance<EffectCatalog>
	|-CombatWorld.deleteInstance<object>
	*/

	// RVA: 0x25794A0 Offset: 0x25795A1 VA: 0x25794A0
	public static ValueTuple<Character, Phase> GetChrAndPhase() { }

	// RVA: 0x2579630 Offset: 0x2579731 VA: 0x2579630
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC440 Offset: 0x2AC541 VA: 0x2AC440
	// RVA: 0x25796C0 Offset: 0x25797C1 VA: 0x25796C0
	private void <RegisterHitObserver>b__57_0(AnimationEvent ev) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC450 Offset: 0x2AC551 VA: 0x2AC450
	// RVA: 0x2577B40 Offset: 0x2577C41 VA: 0x2577B40
	private void <SyncParams>g__sync|58_0(int side) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC460 Offset: 0x2AC561 VA: 0x2AC460
	// RVA: 0x2579120 Offset: 0x2579221 VA: 0x2579120
	internal static bool <Update>g__IsIdle|69_0(Character chara) { }
}

