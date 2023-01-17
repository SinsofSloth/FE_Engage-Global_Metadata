// Namespace: UnityEngine.Animations
[NativeHeaderAttribute] // RVA: 0x35420 Offset: 0x35521 VA: 0x35420
[NativeHeaderAttribute] // RVA: 0x35420 Offset: 0x35521 VA: 0x35420
[StaticAccessorAttribute] // RVA: 0x35420 Offset: 0x35521 VA: 0x35420
[NativeHeaderAttribute] // RVA: 0x35420 Offset: 0x35521 VA: 0x35420
[RequiredByNativeCodeAttribute] // RVA: 0x35420 Offset: 0x35521 VA: 0x35420
internal struct AnimationOffsetPlayable : IPlayable, IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 4125
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x3ED37C0 Offset: 0x3ED38C1 VA: 0x3ED37C0
	public static AnimationOffsetPlayable Create(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) { }

	// RVA: 0x3ED38D0 Offset: 0x3ED39D1 VA: 0x3ED38D0
	private static PlayableHandle CreateHandle(PlayableGraph graph, Vector3 position, Quaternion rotation, int inputCount) { }

	// RVA: 0x3ED3A30 Offset: 0x3ED3B31 VA: 0x3ED3A30
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x3ED3BC0 Offset: 0x3ED3CC1 VA: 0x3ED3BC0 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x3ED3BD0 Offset: 0x3ED3CD1 VA: 0x3ED3BD0
	public static Playable op_Implicit(AnimationOffsetPlayable playable) { }

	// RVA: 0x3ED3C10 Offset: 0x3ED3D11 VA: 0x3ED3C10 Slot: 5
	public bool Equals(AnimationOffsetPlayable other) { }

	[NativeThrowsAttribute] // RVA: 0x386B0 Offset: 0x387B1 VA: 0x386B0
	// RVA: 0x3ED3AF0 Offset: 0x3ED3BF1 VA: 0x3ED3AF0
	private static bool CreateHandleInternal(PlayableGraph graph, Vector3 position, Quaternion rotation, ref PlayableHandle handle) { }

	// RVA: 0x3ED3D50 Offset: 0x3ED3E51 VA: 0x3ED3D50
	private static void .cctor() { }

	// RVA: 0x3ED3CE0 Offset: 0x3ED3DE1 VA: 0x3ED3CE0
	private static bool CreateHandleInternal_Injected(ref PlayableGraph graph, ref Vector3 position, ref Quaternion rotation, ref PlayableHandle handle) { }
}

