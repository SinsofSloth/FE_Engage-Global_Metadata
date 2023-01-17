// Namespace: UnityEngine.Animations
[NativeHeaderAttribute] // RVA: 0x350E0 Offset: 0x351E1 VA: 0x350E0
[StaticAccessorAttribute] // RVA: 0x350E0 Offset: 0x351E1 VA: 0x350E0
[RequiredByNativeCodeAttribute] // RVA: 0x350E0 Offset: 0x351E1 VA: 0x350E0
[NativeHeaderAttribute] // RVA: 0x350E0 Offset: 0x351E1 VA: 0x350E0
public struct AnimationClipPlayable : IPlayable, IEquatable<AnimationClipPlayable> // TypeDefIndex: 4120
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x3ED1B60 Offset: 0x3ED1C61 VA: 0x3ED1B60
	public static AnimationClipPlayable Create(PlayableGraph graph, AnimationClip clip) { }

	// RVA: 0x3ED1BA0 Offset: 0x3ED1CA1 VA: 0x3ED1BA0
	private static PlayableHandle CreateHandle(PlayableGraph graph, AnimationClip clip) { }

	// RVA: 0x3ED1C90 Offset: 0x3ED1D91 VA: 0x3ED1C90
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x3ED1DC0 Offset: 0x3ED1EC1 VA: 0x3ED1DC0 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x3ED1DD0 Offset: 0x3ED1ED1 VA: 0x3ED1DD0
	public static Playable op_Implicit(AnimationClipPlayable playable) { }

	// RVA: 0x3ED1E10 Offset: 0x3ED1F11 VA: 0x3ED1E10 Slot: 5
	public bool Equals(AnimationClipPlayable other) { }

	// RVA: 0x3ED1EA0 Offset: 0x3ED1FA1 VA: 0x3ED1EA0
	public void SetApplyFootIK(bool value) { }

	// RVA: 0x3ED1F40 Offset: 0x3ED2041 VA: 0x3ED1F40
	public void SetApplyPlayableIK(bool value) { }

	// RVA: 0x3ED1FE0 Offset: 0x3ED20E1 VA: 0x3ED1FE0
	internal void SetRemoveStartOffset(bool value) { }

	// RVA: 0x3ED2080 Offset: 0x3ED2181 VA: 0x3ED2080
	internal void SetOverrideLoopTime(bool value) { }

	// RVA: 0x3ED2120 Offset: 0x3ED2221 VA: 0x3ED2120
	internal void SetLoopTime(bool value) { }

	[NativeThrowsAttribute] // RVA: 0x38600 Offset: 0x38701 VA: 0x38600
	// RVA: 0x3ED1D50 Offset: 0x3ED1E51 VA: 0x3ED1D50
	private static bool CreateHandleInternal(PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) { }

	[NativeThrowsAttribute] // RVA: 0x38610 Offset: 0x38711 VA: 0x38610
	// RVA: 0x3ED1EF0 Offset: 0x3ED1FF1 VA: 0x3ED1EF0
	private static void SetApplyFootIKInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrowsAttribute] // RVA: 0x38620 Offset: 0x38721 VA: 0x38620
	// RVA: 0x3ED1F90 Offset: 0x3ED2091 VA: 0x3ED1F90
	private static void SetApplyPlayableIKInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrowsAttribute] // RVA: 0x38630 Offset: 0x38731 VA: 0x38630
	// RVA: 0x3ED2030 Offset: 0x3ED2131 VA: 0x3ED2030
	private static void SetRemoveStartOffsetInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrowsAttribute] // RVA: 0x38640 Offset: 0x38741 VA: 0x38640
	// RVA: 0x3ED20D0 Offset: 0x3ED21D1 VA: 0x3ED20D0
	private static void SetOverrideLoopTimeInternal(ref PlayableHandle handle, bool value) { }

	[NativeThrowsAttribute] // RVA: 0x38650 Offset: 0x38751 VA: 0x38650
	// RVA: 0x3ED2170 Offset: 0x3ED2271 VA: 0x3ED2170
	private static void SetLoopTimeInternal(ref PlayableHandle handle, bool value) { }

	// RVA: 0x3ED21C0 Offset: 0x3ED22C1 VA: 0x3ED21C0
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, AnimationClip clip, ref PlayableHandle handle) { }
}

