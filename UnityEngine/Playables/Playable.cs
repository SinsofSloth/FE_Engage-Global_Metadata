// Namespace: UnityEngine.Playables
[RequiredByNativeCodeAttribute] // RVA: 0x441160 Offset: 0x441261 VA: 0x441160
public struct Playable : IPlayable, IEquatable<Playable> // TypeDefIndex: 3985
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly Playable m_NullPlayable; // 0x0

	// Properties
	public static Playable Null { get; }

	// Methods

	// RVA: 0x348FBE0 Offset: 0x348FCE1 VA: 0x348FBE0
	public static Playable get_Null() { }

	// RVA: 0x348FC50 Offset: 0x348FD51 VA: 0x348FC50
	public static Playable Create(PlayableGraph graph, int inputCount = 0) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x4545B0 Offset: 0x4546B1 VA: 0x4545B0
	// RVA: 0x348FD60 Offset: 0x348FE61 VA: 0x348FD60
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x348FD70 Offset: 0x348FE71 VA: 0x348FD70 Slot: 4
	public PlayableHandle GetHandle() { }

	// RVA: 0x348FD80 Offset: 0x348FE81 VA: 0x348FD80
	public Type GetPlayableType() { }

	// RVA: 0x348FEC0 Offset: 0x348FFC1 VA: 0x348FEC0 Slot: 5
	public bool Equals(Playable other) { }

	// RVA: 0x348FFA0 Offset: 0x34900A1 VA: 0x348FFA0
	private static void .cctor() { }
}

