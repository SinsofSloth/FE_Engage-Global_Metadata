// Namespace: UnityEngine.Animations
[NativeHeaderAttribute] // RVA: 0x35830 Offset: 0x35931 VA: 0x35830
[RequiredByNativeCodeAttribute] // RVA: 0x35830 Offset: 0x35931 VA: 0x35830
[NativeHeaderAttribute] // RVA: 0x35830 Offset: 0x35931 VA: 0x35830
[NativeHeaderAttribute] // RVA: 0x35830 Offset: 0x35931 VA: 0x35830
[StaticAccessorAttribute] // RVA: 0x35830 Offset: 0x35931 VA: 0x35830
internal struct AnimationRemoveScalePlayable : IPlayable, IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 4130
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x3ED4800 Offset: 0x3ED4901 VA: 0x3ED4800
	public static AnimationRemoveScalePlayable Create(PlayableGraph graph, int inputCount) { }

	// RVA: 0x3ED48B0 Offset: 0x3ED49B1 VA: 0x3ED48B0
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount) { }

	// RVA: 0x3ED4A40 Offset: 0x3ED4B41 VA: 0x3ED4A40
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x3ED4BB0 Offset: 0x3ED4CB1 VA: 0x3ED4BB0 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x3ED4BC0 Offset: 0x3ED4CC1 VA: 0x3ED4BC0
	public static Playable op_Implicit(AnimationRemoveScalePlayable playable) { }

	// RVA: 0x3ED4C00 Offset: 0x3ED4D01 VA: 0x3ED4C00 Slot: 5
	public bool Equals(AnimationRemoveScalePlayable other) { }

	[NativeThrowsAttribute] // RVA: 0x38720 Offset: 0x38821 VA: 0x38720
	// RVA: 0x3ED4B00 Offset: 0x3ED4C01 VA: 0x3ED4B00
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	// RVA: 0x3ED4D20 Offset: 0x3ED4E21 VA: 0x3ED4D20
	private static void .cctor() { }

	// RVA: 0x3ED4CD0 Offset: 0x3ED4DD1 VA: 0x3ED4CD0
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }
}

