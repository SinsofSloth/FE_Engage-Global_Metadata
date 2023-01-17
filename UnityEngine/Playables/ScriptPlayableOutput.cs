// Namespace: UnityEngine.Playables
[RequiredByNativeCodeAttribute] // RVA: 0x441450 Offset: 0x441551 VA: 0x441450
public struct ScriptPlayableOutput : IPlayableOutput // TypeDefIndex: 4002
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

	// Properties
	public static ScriptPlayableOutput Null { get; }

	// Methods

	// RVA: 0x31E3A00 Offset: 0x31E3B01 VA: 0x31E3A00
	public static ScriptPlayableOutput Create(PlayableGraph graph, string name) { }

	// RVA: 0x31E3B90 Offset: 0x31E3C91 VA: 0x31E3B90
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x31E3B00 Offset: 0x31E3C01 VA: 0x31E3B00
	public static ScriptPlayableOutput get_Null() { }

	// RVA: 0x31E3C50 Offset: 0x31E3D51 VA: 0x31E3C50 Slot: 4
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x31E3AC0 Offset: 0x31E3BC1 VA: 0x31E3AC0
	public static PlayableOutput op_Implicit(ScriptPlayableOutput output) { }
}

