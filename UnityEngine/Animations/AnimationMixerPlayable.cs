// Namespace: UnityEngine.Animations
[NativeHeaderAttribute] // RVA: 0x352E0 Offset: 0x353E1 VA: 0x352E0
[StaticAccessorAttribute] // RVA: 0x352E0 Offset: 0x353E1 VA: 0x352E0
[RequiredByNativeCodeAttribute] // RVA: 0x352E0 Offset: 0x353E1 VA: 0x352E0
[NativeHeaderAttribute] // RVA: 0x352E0 Offset: 0x353E1 VA: 0x352E0
[NativeHeaderAttribute] // RVA: 0x352E0 Offset: 0x353E1 VA: 0x352E0
public struct AnimationMixerPlayable : IPlayable, IEquatable<AnimationMixerPlayable> // TypeDefIndex: 4123
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x3ED2BA0 Offset: 0x3ED2CA1 VA: 0x3ED2BA0
	public static AnimationMixerPlayable Create(PlayableGraph graph, int inputCount = 0, bool normalizeWeights = False) { }

	// RVA: 0x3ED2C60 Offset: 0x3ED2D61 VA: 0x3ED2C60
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0, bool normalizeWeights = False) { }

	// RVA: 0x3ED2DF0 Offset: 0x3ED2EF1 VA: 0x3ED2DF0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x3ED2F70 Offset: 0x3ED3071 VA: 0x3ED2F70 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x3ED2F80 Offset: 0x3ED3081 VA: 0x3ED2F80
	public static Playable op_Implicit(AnimationMixerPlayable playable) { }

	// RVA: 0x3ED2FC0 Offset: 0x3ED30C1 VA: 0x3ED2FC0 Slot: 5
	public bool Equals(AnimationMixerPlayable other) { }

	[NativeThrowsAttribute] // RVA: 0x38680 Offset: 0x38781 VA: 0x38680
	// RVA: 0x3ED2EB0 Offset: 0x3ED2FB1 VA: 0x3ED2EB0
	private static bool CreateHandleInternal(PlayableGraph graph, bool normalizeWeights, ref PlayableHandle handle) { }

	// RVA: 0x3ED30B0 Offset: 0x3ED31B1 VA: 0x3ED30B0
	private static void .cctor() { }

	// RVA: 0x3ED3050 Offset: 0x3ED3151 VA: 0x3ED3050
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, bool normalizeWeights, ref PlayableHandle handle) { }
}

