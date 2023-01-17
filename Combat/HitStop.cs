// Namespace: Combat
public sealed class HitStop : IDisposable // TypeDefIndex: 8858
{
	// Fields
	private AnimationCurve m_HitStopSpeedCurve; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x284A40 Offset: 0x284B41 VA: 0x284A40
	private float <RemainingTime>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x284A50 Offset: 0x284B51 VA: 0x284A50
	private float <Speed>k__BackingField; // 0x1C
	private float m_NormalizedScale; // 0x20
	private float m_LastSpeed; // 0x24
	private bool m_bHitStopEndCalled; // 0x28
	private float m_HitStopStart; // 0x2C

	// Properties
	public float RemainingTime { get; set; }
	public bool IsRunning { get; }
	public float Speed { get; set; }
	public float NormalizedTime { get; }

	// Methods

	// RVA: 0x2667710 Offset: 0x2667811 VA: 0x2667710
	public void .ctor(AnimationCurve hitStopSpeedCurve) { }

	// RVA: 0x2667780 Offset: 0x2667881 VA: 0x2667780 Slot: 4
	public void Dispose() { }

	// RVA: 0x2667760 Offset: 0x2667861 VA: 0x2667760
	private void Reset() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD740 Offset: 0x2AD841 VA: 0x2AD740
	// RVA: 0x26677A0 Offset: 0x26678A1 VA: 0x26677A0
	public float get_RemainingTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD750 Offset: 0x2AD851 VA: 0x2AD750
	// RVA: 0x26677B0 Offset: 0x26678B1 VA: 0x26677B0
	private void set_RemainingTime(float value) { }

	// RVA: 0x26677C0 Offset: 0x26678C1 VA: 0x26677C0
	public bool get_IsRunning() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD760 Offset: 0x2AD861 VA: 0x2AD760
	// RVA: 0x26677D0 Offset: 0x26678D1 VA: 0x26677D0
	public float get_Speed() { }

	[CompilerGeneratedAttribute] // RVA: 0x2AD770 Offset: 0x2AD871 VA: 0x2AD770
	// RVA: 0x26677E0 Offset: 0x26678E1 VA: 0x26677E0
	private void set_Speed(float value) { }

	// RVA: 0x26677F0 Offset: 0x26678F1 VA: 0x26677F0
	public float get_NormalizedTime() { }

	// RVA: 0x2667810 Offset: 0x2667911 VA: 0x2667810
	public void Start(float time) { }

	// RVA: 0x2667970 Offset: 0x2667A71 VA: 0x2667970
	public void Update() { }

	// RVA: 0x2667A40 Offset: 0x2667B41 VA: 0x2667A40
	private void Resume() { }
}

