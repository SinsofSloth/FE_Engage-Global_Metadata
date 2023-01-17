// Namespace: Combat
[RequireComponent] // RVA: 0x273A10 Offset: 0x273B11 VA: 0x273A10
[RequireComponent] // RVA: 0x273A10 Offset: 0x273B11 VA: 0x273A10
[RequireComponent] // RVA: 0x273A10 Offset: 0x273B11 VA: 0x273A10
[DisallowMultipleComponent] // RVA: 0x273A10 Offset: 0x273B11 VA: 0x273A10
public sealed class Character : MonoBehaviour // TypeDefIndex: 8570
{
	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x281E50 Offset: 0x281F51 VA: 0x281E50
	private int <Side>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x281E60 Offset: 0x281F61 VA: 0x281E60
	private int <ChainId>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x281E70 Offset: 0x281F71 VA: 0x281E70
	private PrefetchedSignalStore <Prefetched>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x281E80 Offset: 0x281F81 VA: 0x281E80
	private CharacterEffect <Effect>k__BackingField; // 0x28
	private CharacterObservable _observable; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x281E90 Offset: 0x281F91 VA: 0x281E90
	private CharacterIdleSMB <IdleSMB>k__BackingField; // 0x38
	public FSM FSM; // 0x40
	private GrandewBrain m_Brain; // 0x48
	private CharacterGameStatus _gs; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x281EA0 Offset: 0x281FA1 VA: 0x281EA0
	private bool <IsSetupDone>k__BackingField; // 0x58
	private LookAtIK _headLookAtIK; // 0x60
	private LookAtIK _bodyLookAtIK; // 0x68
	private int m_EnemySide; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x281EB0 Offset: 0x281FB1 VA: 0x281EB0
	private float <GroundLevel>k__BackingField; // 0x74
	[CompilerGeneratedAttribute] // RVA: 0x281EC0 Offset: 0x281FC1 VA: 0x281EC0
	private Vector3 <WorldHitDir>k__BackingField; // 0x78
	private FXZ rushDir; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x281ED0 Offset: 0x281FD1 VA: 0x281ED0
	private IDisposable <CombatStartFadeDisposable>k__BackingField; // 0x90
	private Animator _bodyAnimator; // 0x98
	private Animator _rideAnimator; // 0xA0
	private Animator _faceAnimator; // 0xA8
	private int Play直後Idle誤判断防止フレーム数; // 0xB0
	private float 同じアニメ再生時の前回の再生時刻; // 0xB4
	[CompilerGeneratedAttribute] // RVA: 0x281EE0 Offset: 0x281FE1 VA: 0x281EE0
	private bool <ConstantSpeedPlayback>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x281EF0 Offset: 0x281FF1 VA: 0x281EF0
	private int <PlayingHash>k__BackingField; // 0xBC
	[CompilerGeneratedAttribute] // RVA: 0x281F00 Offset: 0x282001 VA: 0x281F00
	private PrefetchedSignal <PlayingStore>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x281F10 Offset: 0x282011 VA: 0x281F10
	private AnimationEvent <PlayingEvent>k__BackingField; // 0xC8
	private FXZ m_PlayEndWorldPos; // 0xD0
	private Iron19CharacterFader _DitherFade; // 0xD8
	private bool cached_DitherFade; // 0xE0
	private Iron19CharacterSuperEngage _MaterialEngage; // 0xE8
	private bool cached_MaterialEngage; // 0xF0
	private CharacterSignal _Signal; // 0xF8
	private CharacterLying _Lying; // 0x100
	private CharacterJoint _Joint; // 0x108
	private bool cached_Joint; // 0x110
	private CharacterProportion _Proportion; // 0x118
	private bool cached_Proportion; // 0x120
	private CharacterConfig _Config; // 0x128
	private bool cached_Config; // 0x130
	private CharacterMove _Move; // 0x138
	private bool cached_Move; // 0x140
	private CharacterTurn _Turn; // 0x148
	private bool cached_Turn; // 0x150
	private CharacterTimespace _Timespace; // 0x158
	private bool cached_Timespace; // 0x160
	private CharacterHUD _HUD; // 0x168
	private bool cached_HUD; // 0x170
	private CharacterSound _Sound; // 0x178
	private bool cached_Sound; // 0x180
	private CharacterBuilder _Builder; // 0x188
	private bool cached_Builder; // 0x190
	private CharacterAura _Aura; // 0x198
	private bool cached_Aura; // 0x1A0
	private CharacterIllusion _Illusion; // 0x1A8
	private bool cached_Illusion; // 0x1B0
	private CharacterIKFoot _IKFoot; // 0x1B8
	private bool cached_IKFoot; // 0x1C0
	private CharacterIKLookAt _IKLookAt; // 0x1C8
	private bool cached_IKLookAt; // 0x1D0
	private CharacterIKAim _IKAim; // 0x1D8
	private bool cached_IKAim; // 0x1E0
	private CharacterWeapon _Weapon; // 0x1E8
	private bool cached_Weapon; // 0x1F0
	private CharacterSignalObserver _SignalObserver; // 0x1F8
	private bool cached_SignalObserver; // 0x200

	// Properties
	public int Side { get; set; }
	public int ChainId { get; set; }
	public PrefetchedSignalStore Prefetched { get; set; }
	public LaunchBehaviour Launcher { get; }
	public Magic Magic { get; }
	public Throwing Throwing { get; }
	public CharacterEffect Effect { get; set; }
	public CharacterObservable Observable { get; }
	public CharacterIdleSMB IdleSMB { get; set; }
	public CombatWorld World { get; }
	public CombatRecord Record { get; }
	public Phase Phase { get; }
	public CharacterGameStatus GameStatus { get; set; }
	public bool IsSetupDone { get; set; }
	public bool IsVisible { get; set; }
	public LookAtIK LookAtIK_Head { get; }
	public LookAtIK LookAtIK_Body { get; }
	public Character Grandew { get; }
	public Character Master { get; }
	public Character EnemyGrandew { get; }
	public Character Enemy { get; }
	public float GroundLevel { get; set; }
	public FXZ Pos2D { get; }
	public Vector3 Pos3D { get; }
	public FXZ Dir2D { get; }
	public FXZ DirToEnemy2D { get; }
	public float SqDistToEnemy2D { get; }
	public float SqDistToPartner2D { get; }
	public float DistToEnemy2D { get; }
	public Vector3 WorldHitDir { get; set; }
	public FXZ AttackBeatenDir { get; set; }
	public IDisposable CombatStartFadeDisposable { get; set; }
	public bool IsLeftInScreenSpace { get; }
	public Animator BodyAnimator { get; }
	public Animator RideAnimator { get; }
	public Animator FaceAnimator { get; }
	public bool ConstantSpeedPlayback { get; set; }
	public int PlayingHash { get; set; }
	public PrefetchedSignal PlayingStore { get; set; }
	public AnimationEvent PlayingEvent { get; set; }
	public FXZ PlayEndWorldPos { get; }
	public WeaponStyle WeaponStyle { get; }
	public bool IsIdle { get; }
	public bool IsPhysicalAttacking { get; }
	public Iron19CharacterFader DitherFade { get; }
	public Iron19CharacterSuperEngage MaterialEngage { get; }
	public CharacterSignal Signal { get; }
	public CharacterLying Lying { get; }
	public CharacterJoint Joint { get; }
	public CharacterProportion Proportion { get; }
	public CharacterConfig Config { get; }
	public CharacterMove Move { get; }
	public CharacterTurn Turn { get; }
	public CharacterTimespace Timespace { get; }
	public CharacterHUD HUD { get; }
	public CharacterSound Sound { get; }
	public CharacterBuilder Builder { get; }
	public CharacterAura Aura { get; }
	public CharacterIllusion Illusion { get; }
	public CharacterIKFoot IKFoot { get; }
	public CharacterIKLookAt IKLookAt { get; }
	public CharacterIKAim IKAim { get; }
	public CharacterWeapon Weapon { get; }
	public CharacterSignalObserver SignalObserver { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2A9B60 Offset: 0x2A9C61 VA: 0x2A9B60
	// RVA: 0x2E18180 Offset: 0x2E18281 VA: 0x2E18180
	public int get_Side() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9B70 Offset: 0x2A9C71 VA: 0x2A9B70
	// RVA: 0x2E18190 Offset: 0x2E18291 VA: 0x2E18190
	private void set_Side(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9B80 Offset: 0x2A9C81 VA: 0x2A9B80
	// RVA: 0x2E181A0 Offset: 0x2E182A1 VA: 0x2E181A0
	public int get_ChainId() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9B90 Offset: 0x2A9C91 VA: 0x2A9B90
	// RVA: 0x2E181B0 Offset: 0x2E182B1 VA: 0x2E181B0
	private void set_ChainId(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9BA0 Offset: 0x2A9CA1 VA: 0x2A9BA0
	// RVA: 0x2E181C0 Offset: 0x2E182C1 VA: 0x2E181C0
	public PrefetchedSignalStore get_Prefetched() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9BB0 Offset: 0x2A9CB1 VA: 0x2A9BB0
	// RVA: 0x2E181D0 Offset: 0x2E182D1 VA: 0x2E181D0
	private void set_Prefetched(PrefetchedSignalStore value) { }

	// RVA: 0x2E181E0 Offset: 0x2E182E1 VA: 0x2E181E0
	public LaunchBehaviour get_Launcher() { }

	// RVA: 0x2E182F0 Offset: 0x2E183F1 VA: 0x2E182F0
	public Magic get_Magic() { }

	// RVA: 0x2E18400 Offset: 0x2E18501 VA: 0x2E18400
	public Throwing get_Throwing() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9BC0 Offset: 0x2A9CC1 VA: 0x2A9BC0
	// RVA: 0x2E18510 Offset: 0x2E18611 VA: 0x2E18510
	public CharacterEffect get_Effect() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9BD0 Offset: 0x2A9CD1 VA: 0x2A9BD0
	// RVA: 0x2E18520 Offset: 0x2E18621 VA: 0x2E18520
	private void set_Effect(CharacterEffect value) { }

	// RVA: 0x2E18530 Offset: 0x2E18631 VA: 0x2E18530
	public CharacterObservable get_Observable() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9BE0 Offset: 0x2A9CE1 VA: 0x2A9BE0
	// RVA: 0x2E185D0 Offset: 0x2E186D1 VA: 0x2E185D0
	public CharacterIdleSMB get_IdleSMB() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9BF0 Offset: 0x2A9CF1 VA: 0x2A9BF0
	// RVA: 0x2E185E0 Offset: 0x2E186E1 VA: 0x2E185E0
	public void set_IdleSMB(CharacterIdleSMB value) { }

	// RVA: 0x2E185F0 Offset: 0x2E186F1 VA: 0x2E185F0
	public void StartGrandewBrain() { }

	// RVA: 0x2E18660 Offset: 0x2E18761 VA: 0x2E18660
	public void DisposeGrandewBrain() { }

	// RVA: 0x2E186B0 Offset: 0x2E187B1 VA: 0x2E186B0
	public CombatWorld get_World() { }

	// RVA: 0x2E186C0 Offset: 0x2E187C1 VA: 0x2E186C0
	public CombatRecord get_Record() { }

	// RVA: 0x2E18750 Offset: 0x2E18851 VA: 0x2E18750
	public Phase get_Phase() { }

	// RVA: 0x2E188A0 Offset: 0x2E189A1 VA: 0x2E188A0
	public CharacterGameStatus get_GameStatus() { }

	// RVA: 0x2E189B0 Offset: 0x2E18AB1 VA: 0x2E189B0
	public void set_GameStatus(CharacterGameStatus value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9C00 Offset: 0x2A9D01 VA: 0x2A9C00
	// RVA: 0x2E189C0 Offset: 0x2E18AC1 VA: 0x2E189C0
	public bool get_IsSetupDone() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9C10 Offset: 0x2A9D11 VA: 0x2A9C10
	// RVA: 0x2E189D0 Offset: 0x2E18AD1 VA: 0x2E189D0
	private void set_IsSetupDone(bool value) { }

	// RVA: 0x2E189E0 Offset: 0x2E18AE1 VA: 0x2E189E0
	public bool get_IsVisible() { }

	// RVA: 0x2E18A60 Offset: 0x2E18B61 VA: 0x2E18A60
	public void set_IsVisible(bool value) { }

	// RVA: 0x2E18AF0 Offset: 0x2E18BF1 VA: 0x2E18AF0
	public LookAtIK get_LookAtIK_Head() { }

	// RVA: 0x2E18D10 Offset: 0x2E18E11 VA: 0x2E18D10
	public LookAtIK get_LookAtIK_Body() { }

	// RVA: 0x2E18DD0 Offset: 0x2E18ED1 VA: 0x2E18DD0
	public Character get_Grandew() { }

	// RVA: 0x2E18DE0 Offset: 0x2E18EE1 VA: 0x2E18DE0
	public Character get_Master() { }

	// RVA: 0x2E18DF0 Offset: 0x2E18EF1 VA: 0x2E18DF0
	public Character get_EnemyGrandew() { }

	// RVA: 0x2E18E00 Offset: 0x2E18F01 VA: 0x2E18E00
	public Character get_Enemy() { }

	// RVA: 0x2E18EE0 Offset: 0x2E18FE1 VA: 0x2E18EE0
	public void SetEnemyForChainGuard(Character c) { }

	// RVA: 0x2E18F90 Offset: 0x2E19091 VA: 0x2E18F90
	public void SetEnemyToDefault() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9C20 Offset: 0x2A9D21 VA: 0x2A9C20
	// RVA: 0x2E19040 Offset: 0x2E19141 VA: 0x2E19040
	public float get_GroundLevel() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9C30 Offset: 0x2A9D31 VA: 0x2A9C30
	// RVA: 0x2E19050 Offset: 0x2E19151 VA: 0x2E19050
	public void set_GroundLevel(float value) { }

	// RVA: 0x2E19060 Offset: 0x2E19161 VA: 0x2E19060
	public void AdjustGroundLevelTo(int targetSide) { }

	// RVA: 0x2E19130 Offset: 0x2E19231 VA: 0x2E19130
	public FXZ get_Pos2D() { }

	// RVA: 0x2E19180 Offset: 0x2E19281 VA: 0x2E19180
	public Vector3 get_Pos3D() { }

	// RVA: 0x2E19250 Offset: 0x2E19351 VA: 0x2E19250
	public Vector3 ToXHZ(Vector3 pos) { }

	// RVA: 0x2E19310 Offset: 0x2E19411 VA: 0x2E19310
	public Vector4 ToABCD(Vector3 pos) { }

	// RVA: 0x2E19410 Offset: 0x2E19511 VA: 0x2E19410
	public Vector3 TransformToWorld(Vector3 localOffset) { }

	// RVA: 0x2E194F0 Offset: 0x2E195F1 VA: 0x2E194F0
	public FXZ get_Dir2D() { }

	// RVA: 0x2E19550 Offset: 0x2E19651 VA: 0x2E19550
	public FXZ get_DirToEnemy2D() { }

	// RVA: 0x2E196F0 Offset: 0x2E197F1 VA: 0x2E196F0
	public float get_SqDistToEnemy2D() { }

	// RVA: 0x2E19840 Offset: 0x2E19941 VA: 0x2E19840
	public float get_SqDistToPartner2D() { }

	// RVA: 0x2E199C0 Offset: 0x2E19AC1 VA: 0x2E199C0
	public float get_DistToEnemy2D() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9C40 Offset: 0x2A9D41 VA: 0x2A9C40
	// RVA: 0x2E199F0 Offset: 0x2E19AF1 VA: 0x2E199F0
	public Vector3 get_WorldHitDir() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9C50 Offset: 0x2A9D51 VA: 0x2A9C50
	// RVA: 0x2E19A00 Offset: 0x2E19B01 VA: 0x2E19A00
	public void set_WorldHitDir(Vector3 value) { }

	// RVA: 0x2E19A10 Offset: 0x2E19B11 VA: 0x2E19A10
	public FXZ get_AttackBeatenDir() { }

	// RVA: 0x2E19AA0 Offset: 0x2E19BA1 VA: 0x2E19AA0
	public void set_AttackBeatenDir(FXZ value) { }

	// RVA: 0x2E19AB0 Offset: 0x2E19BB1 VA: 0x2E19AB0
	public float GetTall() { }

	// RVA: 0x2E19B30 Offset: 0x2E19C31 VA: 0x2E19B30
	private void OnEnable() { }

	// RVA: 0x2E19BD0 Offset: 0x2E19CD1 VA: 0x2E19BD0
	private void OnDestroy() { }

	// RVA: 0x2E19E50 Offset: 0x2E19F51 VA: 0x2E19E50
	private void Start() { }

	// RVA: 0x2E1A140 Offset: 0x2E1A241 VA: 0x2E1A140
	public void MyUpdate() { }

	// RVA: 0x2E1A160 Offset: 0x2E1A261 VA: 0x2E1A160
	private bool IsAppearedFromBeginning() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9C60 Offset: 0x2A9D61 VA: 0x2A9C60
	// RVA: 0x2E1A2D0 Offset: 0x2E1A3D1 VA: 0x2E1A2D0
	public IDisposable get_CombatStartFadeDisposable() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9C70 Offset: 0x2A9D71 VA: 0x2A9C70
	// RVA: 0x2E1A2E0 Offset: 0x2E1A3E1 VA: 0x2E1A2E0
	private void set_CombatStartFadeDisposable(IDisposable value) { }

	// RVA: 0x2E1A2F0 Offset: 0x2E1A3F1 VA: 0x2E1A2F0
	public void ManualAwakeForCombat(int mySide, int chainId = -1) { }

	// RVA: 0x2E1A680 Offset: 0x2E1A781 VA: 0x2E1A680
	public void SetupForCombat(int mySide = -1) { }

	// RVA: 0x2E1B300 Offset: 0x2E1B401 VA: 0x2E1B300
	private void SetupByRace() { }

	// RVA: 0x2E1C020 Offset: 0x2E1C121 VA: 0x2E1C020
	private void SetCollisionOffset(string name, float moveOffset, float sizeOffset) { }

	// RVA: 0x2E1C110 Offset: 0x2E1C211 VA: 0x2E1C110
	private void SetCollisionOffset(float scale, float moveOffset, float sizeOffset) { }

	// RVA: 0x2E1BBB0 Offset: 0x2E1BCB1 VA: 0x2E1BBB0
	private void AddAndGetRBAndCollider(Transform t) { }

	// RVA: 0x2E1B890 Offset: 0x2E1B991 VA: 0x2E1B890
	private void SetupForGrandew() { }

	// RVA: 0x2E1C710 Offset: 0x2E1C811 VA: 0x2E1C710
	private void HideWholeShadow() { }

	// RVA: 0x2E1C830 Offset: 0x2E1C931 VA: 0x2E1C830
	public void TeardownForCombat() { }

	// RVA: 0x2E1C960 Offset: 0x2E1CA61 VA: 0x2E1C960
	public void SetupForTalk() { }

	// RVA: 0x2E1CB10 Offset: 0x2E1CC11 VA: 0x2E1CB10
	public void SetupForHub() { }

	// RVA: 0x2E1CCF0 Offset: 0x2E1CDF1 VA: 0x2E1CCF0
	public bool get_IsLeftInScreenSpace() { }

	// RVA: 0x2E1AD70 Offset: 0x2E1AE71 VA: 0x2E1AD70
	public Animator get_BodyAnimator() { }

	// RVA: 0x2E1AFD0 Offset: 0x2E1B0D1 VA: 0x2E1AFD0
	public Animator get_RideAnimator() { }

	// RVA: 0x2E1CE10 Offset: 0x2E1CF11 VA: 0x2E1CE10
	public Animator get_FaceAnimator() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9C80 Offset: 0x2A9D81 VA: 0x2A9C80
	// RVA: 0x2E1CF70 Offset: 0x2E1D071 VA: 0x2E1CF70
	public bool get_ConstantSpeedPlayback() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9C90 Offset: 0x2A9D91 VA: 0x2A9C90
	// RVA: 0x2E1CF80 Offset: 0x2E1D081 VA: 0x2E1CF80
	private void set_ConstantSpeedPlayback(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9CA0 Offset: 0x2A9DA1 VA: 0x2A9CA0
	// RVA: 0x2E1CF90 Offset: 0x2E1D091 VA: 0x2E1CF90
	public int get_PlayingHash() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9CB0 Offset: 0x2A9DB1 VA: 0x2A9CB0
	// RVA: 0x2E1CFA0 Offset: 0x2E1D0A1 VA: 0x2E1CFA0
	private void set_PlayingHash(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9CC0 Offset: 0x2A9DC1 VA: 0x2A9CC0
	// RVA: 0x2E1CFB0 Offset: 0x2E1D0B1 VA: 0x2E1CFB0
	public PrefetchedSignal get_PlayingStore() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9CD0 Offset: 0x2A9DD1 VA: 0x2A9CD0
	// RVA: 0x2E1CFC0 Offset: 0x2E1D0C1 VA: 0x2E1CFC0
	private void set_PlayingStore(PrefetchedSignal value) { }

	// RVA: 0x2E1CFD0 Offset: 0x2E1D0D1 VA: 0x2E1CFD0
	public void SetPlayingHashAndStore(int hash) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9CE0 Offset: 0x2A9DE1 VA: 0x2A9CE0
	// RVA: 0x2E1D010 Offset: 0x2E1D111 VA: 0x2E1D010
	public AnimationEvent get_PlayingEvent() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9CF0 Offset: 0x2A9DF1 VA: 0x2A9CF0
	// RVA: 0x2E1D020 Offset: 0x2E1D121 VA: 0x2E1D020
	public void set_PlayingEvent(AnimationEvent value) { }

	// RVA: 0x2E1D030 Offset: 0x2E1D131 VA: 0x2E1D030
	public FXZ get_PlayEndWorldPos() { }

	// RVA: 0x2E1D280 Offset: 0x2E1D381 VA: 0x2E1D280
	public void SetAnimatorParameter(int parameterHash, float value) { }

	// RVA: 0x2E1D3A0 Offset: 0x2E1D4A1 VA: 0x2E1D3A0
	public void SetAnimatorParameter(int parameterHash, bool value) { }

	// RVA: 0x2E1D4C0 Offset: 0x2E1D5C1 VA: 0x2E1D4C0
	public void SetPlayingAnimationTime(float fixedTime) { }

	// RVA: 0x2E1D5E0 Offset: 0x2E1D6E1 VA: 0x2E1D5E0
	public AnimatorStateInfo GetAnimatorStateInfo() { }

	// RVA: 0x2E1D6C0 Offset: 0x2E1D7C1 VA: 0x2E1D6C0
	public float GetPlayingTime() { }

	// RVA: 0x2E1D7C0 Offset: 0x2E1D8C1 VA: 0x2E1D7C0
	public float GetPlaybackRate() { }

	// RVA: 0x2E1D7E0 Offset: 0x2E1D8E1 VA: 0x2E1D7E0
	public void SetPlaybackRate(float value) { }

	// RVA: 0x2E1D8A0 Offset: 0x2E1D9A1 VA: 0x2E1D8A0
	public WeaponStyle get_WeaponStyle() { }

	// RVA: 0x2E1D8F0 Offset: 0x2E1D9F1 VA: 0x2E1D8F0
	public void WillPlay(int hash) { }

	// RVA: 0x2E1D9C0 Offset: 0x2E1DAC1 VA: 0x2E1D9C0
	public void WillNotPlay(int hash) { }

	// RVA: 0x2E1DA80 Offset: 0x2E1DB81 VA: 0x2E1DA80
	public void PlayDyingInstant() { }

	// RVA: 0x2E1DC80 Offset: 0x2E1DD81 VA: 0x2E1DC80
	public void PlayIdleNormalInstant() { }

	// RVA: 0x2E1DDE0 Offset: 0x2E1DEE1 VA: 0x2E1DDE0
	public float Play(string targetName, PlayFlags flags = 0, float transitionDuration = -1, float startTime = -1) { }

	// RVA: 0x2E1DC70 Offset: 0x2E1DD71 VA: 0x2E1DC70
	public void PlayInstant(int hash) { }

	// RVA: 0x2E1DE30 Offset: 0x2E1DF31 VA: 0x2E1DE30
	public float Play(int hash, PlayFlags flags = 0, float transitionDuration = -1, float startTime = -1) { }

	// RVA: 0x2E1D110 Offset: 0x2E1D211 VA: 0x2E1D110
	public bool get_IsIdle() { }

	// RVA: 0x2E1E450 Offset: 0x2E1E551 VA: 0x2E1E450
	public bool get_IsPhysicalAttacking() { }

	// RVA: 0x2E1E470 Offset: 0x2E1E571 VA: 0x2E1E470
	public void PlayFacial(string stateName) { }

	// RVA: 0x2E1CBA0 Offset: 0x2E1CCA1 VA: 0x2E1CBA0
	public void PlayFacial(int stateHash, float fixedTransitionDuration = -1) { }

	// RVA: 0x2E1E4B0 Offset: 0x2E1E5B1 VA: 0x2E1E4B0
	public bool SkipCombat() { }

	// RVA: 0x2E1FB00 Offset: 0x2E1FC01 VA: 0x2E1FB00
	private void Hide() { }

	// RVA: 0x2E1A3B0 Offset: 0x2E1A4B1 VA: 0x2E1A3B0
	public Iron19CharacterFader get_DitherFade() { }

	// RVA: 0x2E20310 Offset: 0x2E20411 VA: 0x2E20310
	public Iron19CharacterSuperEngage get_MaterialEngage() { }

	// RVA: 0x2E203A0 Offset: 0x2E204A1 VA: 0x2E203A0
	public CharacterSignal get_Signal() { }

	// RVA: 0x2E201A0 Offset: 0x2E202A1 VA: 0x2E201A0
	public CharacterLying get_Lying() { }

	// RVA: 0x2E18C80 Offset: 0x2E18D81 VA: 0x2E18C80
	public CharacterJoint get_Joint() { }

	// RVA: 0x2E1E3C0 Offset: 0x2E1E4C1 VA: 0x2E1E3C0
	public CharacterProportion get_Proportion() { }

	// RVA: 0x2E1B600 Offset: 0x2E1B701 VA: 0x2E1B600
	public CharacterConfig get_Config() { }

	// RVA: 0x2E1B170 Offset: 0x2E1B271 VA: 0x2E1B170
	public CharacterMove get_Move() { }

	// RVA: 0x2E1F830 Offset: 0x2E1F931 VA: 0x2E1F830
	public CharacterTurn get_Turn() { }

	// RVA: 0x2E1DBE0 Offset: 0x2E1DCE1 VA: 0x2E1DBE0
	public CharacterTimespace get_Timespace() { }

	// RVA: 0x2E19DC0 Offset: 0x2E19EC1 VA: 0x2E19DC0
	public CharacterHUD get_HUD() { }

	// RVA: 0x2E1C5F0 Offset: 0x2E1C6F1 VA: 0x2E1C5F0
	public CharacterSound get_Sound() { }

	// RVA: 0x2E18260 Offset: 0x2E18361 VA: 0x2E18260
	public CharacterBuilder get_Builder() { }

	// RVA: 0x2E1C680 Offset: 0x2E1C781 VA: 0x2E1C680
	public CharacterAura get_Aura() { }

	// RVA: 0x2E1FA70 Offset: 0x2E1FB71 VA: 0x2E1FA70
	public CharacterIllusion get_Illusion() { }

	// RVA: 0x2E1B200 Offset: 0x2E1B301 VA: 0x2E1B200
	public CharacterIKFoot get_IKFoot() { }

	// RVA: 0x2E1F950 Offset: 0x2E1FA51 VA: 0x2E1F950
	public CharacterIKLookAt get_IKLookAt() { }

	// RVA: 0x2E1F9E0 Offset: 0x2E1FAE1 VA: 0x2E1F9E0
	public CharacterIKAim get_IKAim() { }

	// RVA: 0x2E1F8C0 Offset: 0x2E1F9C1 VA: 0x2E1F8C0
	public CharacterWeapon get_Weapon() { }

	// RVA: 0x2E20460 Offset: 0x2E20561 VA: 0x2E20460
	public CharacterSignalObserver get_SignalObserver() { }

	// RVA: 0x2E1A480 Offset: 0x2E1A581 VA: 0x2E1A480
	public void CallOnSetupDone(Action func) { }

	// RVA: 0x2E19EE0 Offset: 0x2E19FE1 VA: 0x2E19EE0
	public void CallOnSetupDone(MonoBehaviour component, Action myStart, Action myUpdate, Action myLateUpdate) { }

	// RVA: 0x2E204F0 Offset: 0x2E205F1 VA: 0x2E204F0
	private static void registerRegularHanderOnSetupDone(MonoBehaviour component, Action myStart, Action myUpdate, Action myLateUpdate) { }

	// RVA: 0x2E20710 Offset: 0x2E20811 VA: 0x2E20710
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9D00 Offset: 0x2A9E01 VA: 0x2A9D00
	// RVA: 0x2E207A0 Offset: 0x2E208A1 VA: 0x2E207A0
	private void <Start>b__100_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9D10 Offset: 0x2A9E11 VA: 0x2A9D10
	// RVA: 0x2E207C0 Offset: 0x2E208C1 VA: 0x2E207C0
	private void <ManualAwakeForCombat>b__107_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9D20 Offset: 0x2A9E21 VA: 0x2A9D20
	// RVA: 0x2E208D0 Offset: 0x2E209D1 VA: 0x2E208D0
	private bool <ManualAwakeForCombat>b__107_1(float t) { }

	[CompilerGeneratedAttribute] // RVA: 0x2A9D30 Offset: 0x2A9E31 VA: 0x2A9D30
	// RVA: 0x2E1C3A0 Offset: 0x2E1C4A1 VA: 0x2E1C3A0
	private void <SetupForGrandew>g__SetBackwardCancelPositionHigh|113_0() { }
}

