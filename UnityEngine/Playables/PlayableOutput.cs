// Namespace: UnityEngine.Playables
[RequiredByNativeCodeAttribute] // RVA: 0x441390 Offset: 0x441491 VA: 0x441390
public struct PlayableOutput : IPlayableOutput, IEquatable<PlayableOutput> // TypeDefIndex: 3997
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
	private static readonly PlayableOutput m_NullPlayableOutput; // 0x0

	// Properties
	public static PlayableOutput Null { get; }

	// Methods

	// RVA: 0x34905A0 Offset: 0x34906A1 VA: 0x34905A0
	public static PlayableOutput get_Null() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x455520 Offset: 0x455621 VA: 0x455520
	// RVA: 0x3493300 Offset: 0x3493401 VA: 0x3493300
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x3493310 Offset: 0x3493411 VA: 0x3493310 Slot: 4
	public PlayableOutputHandle GetHandle() { }

	// RVA: -1 Offset: -1
	public bool IsPlayableOutputOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x20118D0 Offset: 0x20119D1 VA: 0x20118D0
	|-PlayableOutput.IsPlayableOutputOfType<AudioPlayableOutput>
	*/

	// RVA: 0x3493320 Offset: 0x3493421 VA: 0x3493320 Slot: 5
	public bool Equals(PlayableOutput other) { }

	// RVA: 0x34934A0 Offset: 0x34935A1 VA: 0x34934A0
	private static void .cctor() { }
}

