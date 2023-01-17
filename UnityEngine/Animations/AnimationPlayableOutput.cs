// Namespace: UnityEngine.Animations
[NativeHeaderAttribute] // RVA: 0x35660 Offset: 0x35761 VA: 0x35660
[NativeHeaderAttribute] // RVA: 0x35660 Offset: 0x35761 VA: 0x35660
[NativeHeaderAttribute] // RVA: 0x35660 Offset: 0x35761 VA: 0x35660
[NativeHeaderAttribute] // RVA: 0x35660 Offset: 0x35761 VA: 0x35660
[NativeHeaderAttribute] // RVA: 0x35660 Offset: 0x35761 VA: 0x35660
[RequiredByNativeCodeAttribute] // RVA: 0x35660 Offset: 0x35761 VA: 0x35660
[StaticAccessorAttribute] // RVA: 0x35660 Offset: 0x35761 VA: 0x35660
public struct AnimationPlayableOutput : IPlayableOutput // TypeDefIndex: 4128
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

	// Properties
	public static AnimationPlayableOutput Null { get; }

	// Methods

	// RVA: 0x3ED3FB0 Offset: 0x3ED40B1 VA: 0x3ED3FB0
	public static AnimationPlayableOutput Create(PlayableGraph graph, string name, Animator target) { }

	// RVA: 0x3ED4300 Offset: 0x3ED4401 VA: 0x3ED4300
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x3ED4270 Offset: 0x3ED4371 VA: 0x3ED4270
	public static AnimationPlayableOutput get_Null() { }

	// RVA: 0x3ED4410 Offset: 0x3ED4511 VA: 0x3ED4410 Slot: 4
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x3ED40D0 Offset: 0x3ED41D1 VA: 0x3ED40D0
	public static PlayableOutput op_Implicit(AnimationPlayableOutput output) { }

	// RVA: 0x3ED4420 Offset: 0x3ED4521 VA: 0x3ED4420
	public static AnimationPlayableOutput op_Explicit(PlayableOutput output) { }

	// RVA: 0x3ED43C0 Offset: 0x3ED44C1 VA: 0x3ED43C0
	public void SetTarget(Animator value) { }

	[NativeThrowsAttribute] // RVA: 0x38710 Offset: 0x38811 VA: 0x38710
	// RVA: 0x3ED4470 Offset: 0x3ED4571 VA: 0x3ED4470
	private static void InternalSetTarget(ref PlayableOutputHandle handle, Animator target) { }
}

