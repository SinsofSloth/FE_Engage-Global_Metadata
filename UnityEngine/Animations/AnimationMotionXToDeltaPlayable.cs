// Namespace: UnityEngine.Animations
[NativeHeaderAttribute] // RVA: 0x353A0 Offset: 0x354A1 VA: 0x353A0
[RequiredByNativeCodeAttribute] // RVA: 0x353A0 Offset: 0x354A1 VA: 0x353A0
[StaticAccessorAttribute] // RVA: 0x353A0 Offset: 0x354A1 VA: 0x353A0
internal struct AnimationMotionXToDeltaPlayable : IPlayable, IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 4124
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x3ED3160 Offset: 0x3ED3261 VA: 0x3ED3160
	public static AnimationMotionXToDeltaPlayable Create(PlayableGraph graph) { }

	// RVA: 0x3ED3200 Offset: 0x3ED3301 VA: 0x3ED3200
	private static PlayableHandle CreateHandle(PlayableGraph graph) { }

	// RVA: 0x3ED3380 Offset: 0x3ED3481 VA: 0x3ED3380
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x3ED34F0 Offset: 0x3ED35F1 VA: 0x3ED34F0 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x3ED3500 Offset: 0x3ED3601 VA: 0x3ED3500
	public static Playable op_Implicit(AnimationMotionXToDeltaPlayable playable) { }

	// RVA: 0x3ED3540 Offset: 0x3ED3641 VA: 0x3ED3540 Slot: 5
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x3ED35D0 Offset: 0x3ED36D1 VA: 0x3ED35D0
	public void SetAbsoluteMotion(bool value) { }

	[NativeThrowsAttribute] // RVA: 0x38690 Offset: 0x38791 VA: 0x38690
	// RVA: 0x3ED3440 Offset: 0x3ED3541 VA: 0x3ED3440
	private static bool CreateHandleInternal(PlayableGraph graph, ref PlayableHandle handle) { }

	[NativeThrowsAttribute] // RVA: 0x386A0 Offset: 0x387A1 VA: 0x386A0
	// RVA: 0x3ED3670 Offset: 0x3ED3771 VA: 0x3ED3670
	private static void SetAbsoluteMotionInternal(ref PlayableHandle handle, bool value) { }

	// RVA: 0x3ED3710 Offset: 0x3ED3811 VA: 0x3ED3710
	private static void .cctor() { }

	// RVA: 0x3ED36C0 Offset: 0x3ED37C1 VA: 0x3ED36C0
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref PlayableHandle handle) { }
}

