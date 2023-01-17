// Namespace: UnityEngine.Animations
[RequiredByNativeCodeAttribute] // RVA: 0x35220 Offset: 0x35321 VA: 0x35220
[NativeHeaderAttribute] // RVA: 0x35220 Offset: 0x35321 VA: 0x35220
[NativeHeaderAttribute] // RVA: 0x35220 Offset: 0x35321 VA: 0x35220
[NativeHeaderAttribute] // RVA: 0x35220 Offset: 0x35321 VA: 0x35220
[StaticAccessorAttribute] // RVA: 0x35220 Offset: 0x35321 VA: 0x35220
public struct AnimationLayerMixerPlayable : IPlayable, IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 4122
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x3ED23A0 Offset: 0x3ED24A1 VA: 0x3ED23A0
	public static AnimationLayerMixerPlayable Create(PlayableGraph graph, int inputCount = 0) { }

	// RVA: 0x3ED2450 Offset: 0x3ED2551 VA: 0x3ED2450
	private static PlayableHandle CreateHandle(PlayableGraph graph, int inputCount = 0) { }

	// RVA: 0x3ED25E0 Offset: 0x3ED26E1 VA: 0x3ED25E0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x3ED2750 Offset: 0x3ED2851 VA: 0x3ED2750 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x3ED2760 Offset: 0x3ED2861 VA: 0x3ED2760
	public static Playable op_Implicit(AnimationLayerMixerPlayable playable) { }

	// RVA: 0x3ED27A0 Offset: 0x3ED28A1 VA: 0x3ED27A0 Slot: 5
	public bool Equals(AnimationLayerMixerPlayable other) { }

	// RVA: 0x3ED2830 Offset: 0x3ED2931 VA: 0x3ED2830
	public void SetLayerMaskFromAvatarMask(uint layerIndex, AvatarMask mask) { }

	[NativeThrowsAttribute] // RVA: 0x38660 Offset: 0x38761 VA: 0x38660
	// RVA: 0x3ED26A0 Offset: 0x3ED27A1 VA: 0x3ED26A0
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	[NativeThrowsAttribute] // RVA: 0x38670 Offset: 0x38771 VA: 0x38670
	// RVA: 0x3ED2A40 Offset: 0x3ED2B41 VA: 0x3ED2A40
	private static void SetLayerMaskFromAvatarMaskInternal(ref PlayableHandle handle, uint layerIndex, AvatarMask mask) { }

	// RVA: 0x3ED2AF0 Offset: 0x3ED2BF1 VA: 0x3ED2AF0
	private static void .cctor() { }

	// RVA: 0x3ED2AA0 Offset: 0x3ED2BA1 VA: 0x3ED2AA0
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }
}

