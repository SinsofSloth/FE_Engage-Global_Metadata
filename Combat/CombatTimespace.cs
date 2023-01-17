// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x274300 Offset: 0x274401 VA: 0x274300
public sealed class CombatTimespace : MonoBehaviour // TypeDefIndex: 8712
{
	// Fields
	private static float s_time; // 0x0
	private const string EditorPrefsName = "Iron19.CombatTimespace.DebugTimeScale";
	private ReactiveProperty<float> rxDebugTimeScale; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x283D50 Offset: 0x283E51 VA: 0x283D50
	private HitStop <HitStop>k__BackingField; // 0x20
	[HeaderAttribute] // RVA: 0x283D60 Offset: 0x283E61 VA: 0x283D60
	public AnimationCurve HitStopSpeedCurve; // 0x28
	[HeaderAttribute] // RVA: 0x283DA0 Offset: 0x283EA1 VA: 0x283DA0
	public AnimationCurve EvasionSpeedCurve; // 0x30
	[HeaderAttribute] // RVA: 0x283DE0 Offset: 0x283EE1 VA: 0x283DE0
	public float SkillDisplayFreezeDuration; // 0x38
	[HideInInspector] // RVA: 0x283E20 Offset: 0x283F21 VA: 0x283E20
	public float BossKilledHitStopTime; // 0x3C
	[HideInInspector] // RVA: 0x283E30 Offset: 0x283F31 VA: 0x283E30
	public float BossKilledTimeScale; // 0x40
	[HideInInspector] // RVA: 0x283E40 Offset: 0x283F41 VA: 0x283E40
	public float BossKilledTimeScaleDuration; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x283E50 Offset: 0x283F51 VA: 0x283E50
	private EvasionSpeed <EvasionSpeed>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x283E60 Offset: 0x283F61 VA: 0x283E60
	private float <PresentationTimeScale>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x283E70 Offset: 0x283F71 VA: 0x283E70
	private float <SkillDisplayTimeScale>k__BackingField; // 0x54
	[CompilerGeneratedAttribute] // RVA: 0x283E80 Offset: 0x283F81 VA: 0x283E80
	private float <UserFastForwardTimeScale>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x283E90 Offset: 0x283F91 VA: 0x283E90
	private float <FinalTimeScale>k__BackingField; // 0x5C
	private bool isCombatSkipped; // 0x60

	// Properties
	public static float SmoothDeltaTime { get; }
	public static float Time { get; }
	public float debugTimeScale { get; set; }
	public HitStop HitStop { get; set; }
	public EvasionSpeed EvasionSpeed { get; set; }
	public float PresentationTimeScale { get; set; }
	public float SkillDisplayTimeScale { get; set; }
	public float UserFastForwardTimeScale { get; set; }
	public float FinalTimeScale { get; set; }
	public static float DebugTimeScale { get; set; }

	// Methods

	// RVA: 0x2575530 Offset: 0x2575631 VA: 0x2575530
	public static float get_SmoothDeltaTime() { }

	// RVA: 0x2575580 Offset: 0x2575681 VA: 0x2575580
	public static float get_Time() { }

	// RVA: 0x25755F0 Offset: 0x25756F1 VA: 0x25755F0
	public float get_debugTimeScale() { }

	// RVA: 0x2575640 Offset: 0x2575741 VA: 0x2575640
	private void set_debugTimeScale(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC230 Offset: 0x2AC331 VA: 0x2AC230
	// RVA: 0x25756B0 Offset: 0x25757B1 VA: 0x25756B0
	public HitStop get_HitStop() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC240 Offset: 0x2AC341 VA: 0x2AC240
	// RVA: 0x25756C0 Offset: 0x25757C1 VA: 0x25756C0
	private void set_HitStop(HitStop value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC250 Offset: 0x2AC351 VA: 0x2AC250
	// RVA: 0x25756D0 Offset: 0x25757D1 VA: 0x25756D0
	public EvasionSpeed get_EvasionSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC260 Offset: 0x2AC361 VA: 0x2AC260
	// RVA: 0x25756E0 Offset: 0x25757E1 VA: 0x25756E0
	private void set_EvasionSpeed(EvasionSpeed value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC270 Offset: 0x2AC371 VA: 0x2AC270
	// RVA: 0x25756F0 Offset: 0x25757F1 VA: 0x25756F0
	public float get_PresentationTimeScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC280 Offset: 0x2AC381 VA: 0x2AC280
	// RVA: 0x2575700 Offset: 0x2575801 VA: 0x2575700
	public void set_PresentationTimeScale(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC290 Offset: 0x2AC391 VA: 0x2AC290
	// RVA: 0x2575710 Offset: 0x2575811 VA: 0x2575710
	public float get_SkillDisplayTimeScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC2A0 Offset: 0x2AC3A1 VA: 0x2AC2A0
	// RVA: 0x2575720 Offset: 0x2575821 VA: 0x2575720
	public void set_SkillDisplayTimeScale(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC2B0 Offset: 0x2AC3B1 VA: 0x2AC2B0
	// RVA: 0x2575730 Offset: 0x2575831 VA: 0x2575730
	public float get_UserFastForwardTimeScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC2C0 Offset: 0x2AC3C1 VA: 0x2AC2C0
	// RVA: 0x2575740 Offset: 0x2575841 VA: 0x2575740
	public void set_UserFastForwardTimeScale(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC2D0 Offset: 0x2AC3D1 VA: 0x2AC2D0
	// RVA: 0x2575750 Offset: 0x2575851 VA: 0x2575750
	public float get_FinalTimeScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AC2E0 Offset: 0x2AC3E1 VA: 0x2AC2E0
	// RVA: 0x2575760 Offset: 0x2575861 VA: 0x2575760
	private void set_FinalTimeScale(float value) { }

	// RVA: 0x2575770 Offset: 0x2575871 VA: 0x2575770
	public void MultiplyToWorldTimeScale(float scale) { }

	// RVA: 0x2575780 Offset: 0x2575881 VA: 0x2575780
	public IDisposable MultiplyToWorldTimeScale(float scale, float durationInScaledTime) { }

	// RVA: 0x25758A0 Offset: 0x25759A1 VA: 0x25758A0
	private void Reset() { }

	// RVA: 0x2572180 Offset: 0x2572281 VA: 0x2572180
	public void ResetWorldAndUserTimeScale() { }

	// RVA: 0x25758C0 Offset: 0x25759C1 VA: 0x25758C0
	private void Start() { }

	// RVA: 0x25759F0 Offset: 0x2575AF1 VA: 0x25759F0
	private void InternalGUI() { }

	// RVA: 0x2575B50 Offset: 0x2575C51 VA: 0x2575B50
	private void OnDestroy() { }

	// RVA: 0x2575BE0 Offset: 0x2575CE1 VA: 0x2575BE0
	private void Update() { }

	// RVA: 0x2575D30 Offset: 0x2575E31 VA: 0x2575D30
	private static float GetCharactersTotalTimeScale() { }

	// RVA: 0x2572010 Offset: 0x2572111 VA: 0x2572010
	public static void SimulatePhysics(float totalTime, float deltaTime = 0.05) { }

	// RVA: 0x2575E80 Offset: 0x2575F81 VA: 0x2575E80
	public static float get_DebugTimeScale() { }

	// RVA: 0x2575E90 Offset: 0x2575F91 VA: 0x2575E90
	public static void set_DebugTimeScale(float value) { }

	// RVA: 0x2575EA0 Offset: 0x2575FA1 VA: 0x2575EA0
	public void .ctor() { }
}

