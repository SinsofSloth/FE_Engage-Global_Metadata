// Namespace: UnityEngine.Playables
public struct PlayableBinding // TypeDefIndex: 3990
{
	// Fields
	private string m_StreamName; // 0x0
	private Object m_SourceObject; // 0x8
	private Type m_SourceBindingType; // 0x10
	private PlayableBinding.CreateOutputMethod m_CreateOutputMethod; // 0x18
	public static readonly PlayableBinding[] None; // 0x0
	public static readonly double DefaultDuration; // 0x8

	// Properties
	public string streamName { get; }
	public Object sourceObject { get; }

	// Methods

	// RVA: 0x34904A0 Offset: 0x34905A1 VA: 0x34904A0
	public string get_streamName() { }

	// RVA: 0x34904B0 Offset: 0x34905B1 VA: 0x34904B0
	public Object get_sourceObject() { }

	// RVA: 0x34904C0 Offset: 0x34905C1 VA: 0x34904C0
	internal PlayableOutput CreateOutput(PlayableGraph graph) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x4545E0 Offset: 0x4546E1 VA: 0x4545E0
	// RVA: 0x3490610 Offset: 0x3490711 VA: 0x3490610
	internal static PlayableBinding CreateInternal(string name, Object sourceObject, Type sourceType, PlayableBinding.CreateOutputMethod createFunction) { }

	// RVA: 0x34906B0 Offset: 0x34907B1 VA: 0x34906B0
	private static void .cctor() { }
}

