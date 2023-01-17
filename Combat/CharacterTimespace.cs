// Namespace: Combat
[DisallowMultipleComponent] // RVA: 0x274070 Offset: 0x274171 VA: 0x274070
public sealed class CharacterTimespace : MonoBehaviour // TypeDefIndex: 8650
{
	// Fields
	private Character _cp; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x283100 Offset: 0x283201 VA: 0x283100
	private float <PlaybackRate>k__BackingField; // 0x20
	public float DefaultPlayBackRate; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x283110 Offset: 0x283211 VA: 0x283110
	private float <PerAnimationPlaybackRate>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x283120 Offset: 0x283221 VA: 0x283120
	private float <SignalWorldTimeScale>k__BackingField; // 0x2C
	private bool m_bImpactAdjustReserved; // 0x30
	private bool m_bImpactAdjust命中信号実行; // 0x31
	private bool m_bImpactAdjust連続実行防止; // 0x32
	private float m_ImpactAdjustWorldTime; // 0x34
	private bool IsStartCalled; // 0x38

	// Properties
	private Character CP { get; }
	public float PlaybackRate { get; set; }
	public float DeltaTime { get; }
	public float SmoothDeltaTime { get; }
	public float PerAnimationPlaybackRate { get; set; }
	public float SignalWorldTimeScale { get; set; }
	private float MotionSpeed { get; }

	// Methods

	// RVA: 0x29BEFB0 Offset: 0x29BF0B1 VA: 0x29BEFB0
	private Character get_CP() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB960 Offset: 0x2ABA61 VA: 0x2AB960
	// RVA: 0x29BF070 Offset: 0x29BF171 VA: 0x29BF070
	public float get_PlaybackRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB970 Offset: 0x2ABA71 VA: 0x2AB970
	// RVA: 0x29BF080 Offset: 0x29BF181 VA: 0x29BF080
	private void set_PlaybackRate(float value) { }

	// RVA: 0x29B2060 Offset: 0x29B2161 VA: 0x29B2060
	public float get_DeltaTime() { }

	// RVA: 0x29B3E20 Offset: 0x29B3F21 VA: 0x29B3E20
	public float get_SmoothDeltaTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB980 Offset: 0x2ABA81 VA: 0x2AB980
	// RVA: 0x29BF090 Offset: 0x29BF191 VA: 0x29BF090
	public float get_PerAnimationPlaybackRate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB990 Offset: 0x2ABA91 VA: 0x2AB990
	// RVA: 0x29BF0A0 Offset: 0x29BF1A1 VA: 0x29BF0A0
	public void set_PerAnimationPlaybackRate(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB9A0 Offset: 0x2ABAA1 VA: 0x2AB9A0
	// RVA: 0x29BF0B0 Offset: 0x29BF1B1 VA: 0x29BF0B0
	public float get_SignalWorldTimeScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB9B0 Offset: 0x2ABAB1 VA: 0x2AB9B0
	// RVA: 0x29BF0C0 Offset: 0x29BF1C1 VA: 0x29BF0C0
	private void set_SignalWorldTimeScale(float value) { }

	// RVA: 0x29BF0D0 Offset: 0x29BF1D1 VA: 0x29BF0D0
	private float get_MotionSpeed() { }

	// RVA: 0x29BF0E0 Offset: 0x29BF1E1 VA: 0x29BF0E0
	public void ResetPerPlay() { }

	// RVA: 0x29BF0F0 Offset: 0x29BF1F1 VA: 0x29BF0F0
	public void SetImpactAdjust(bool 命中先行呼び出しする) { }

	// RVA: 0x29BF140 Offset: 0x29BF241 VA: 0x29BF140
	public void SetImpactAdjust(float time = 0) { }

	// RVA: 0x29BF160 Offset: 0x29BF261 VA: 0x29BF160
	private void RegisterSignalObservers() { }

	// RVA: 0x29BF2C0 Offset: 0x29BF3C1 VA: 0x29BF2C0
	private void MyStart() { }

	// RVA: 0x29BF2D0 Offset: 0x29BF3D1 VA: 0x29BF2D0
	public void Update() { }

	// RVA: 0x29BF720 Offset: 0x29BF821 VA: 0x29BF720
	public static float CalcTimespanInRealtime(AnimationEvent[] events, float heavinessRate, float agilityRate, float startTime, float endTime) { }

	// RVA: 0x29BF730 Offset: 0x29BF831 VA: 0x29BF730
	public float CalcTimespanInRealtime(float startTime, float endTime) { }

	// RVA: 0x29BF7B0 Offset: 0x29BF8B1 VA: 0x29BF7B0
	public float CalcTimespanInRealtime(PrefetchedSignal store, float startTime, float endTime) { }

	// RVA: 0x29BF820 Offset: 0x29BF921 VA: 0x29BF820
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB9C0 Offset: 0x2ABAC1 VA: 0x2AB9C0
	// RVA: 0x29BF840 Offset: 0x29BF941 VA: 0x29BF840
	private void <RegisterSignalObservers>b__30_0(Character chr) { }

	[CompilerGeneratedAttribute] // RVA: 0x2AB9D0 Offset: 0x2ABAD1 VA: 0x2AB9D0
	// RVA: 0x29BF960 Offset: 0x29BFA61 VA: 0x29BF960
	internal static bool <RegisterSignalObservers>g__WithSEGroup|30_1(int hash) { }
}

