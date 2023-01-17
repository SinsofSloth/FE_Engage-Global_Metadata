// Namespace: UnityEngine.Playables
public struct FrameData // TypeDefIndex: 3978
{
	// Fields
	internal ulong m_FrameID; // 0x0
	internal double m_DeltaTime; // 0x8
	internal float m_Weight; // 0x10
	internal float m_EffectiveWeight; // 0x14
	internal double m_EffectiveParentDelay; // 0x18
	internal float m_EffectiveParentSpeed; // 0x20
	internal float m_EffectiveSpeed; // 0x24
	internal FrameData.Flags m_Flags; // 0x28
	internal PlayableOutput m_Output; // 0x30

	// Properties
	public float deltaTime { get; }
	public float effectiveParentSpeed { get; }
	public float effectiveSpeed { get; }
	public FrameData.EvaluationType evaluationType { get; }
	public bool timeLooped { get; }
	public bool timeHeld { get; }
	public PlayableOutput output { get; }
	public PlayState effectivePlayState { get; }

	// Methods

	// RVA: 0x2F21F00 Offset: 0x2F22001 VA: 0x2F21F00
	private bool HasFlags(FrameData.Flags flag) { }

	// RVA: 0x2F21F10 Offset: 0x2F22011 VA: 0x2F21F10
	public float get_deltaTime() { }

	// RVA: 0x2F21F20 Offset: 0x2F22021 VA: 0x2F21F20
	public float get_effectiveParentSpeed() { }

	// RVA: 0x2F21F30 Offset: 0x2F22031 VA: 0x2F21F30
	public float get_effectiveSpeed() { }

	// RVA: 0x2F21F40 Offset: 0x2F22041 VA: 0x2F21F40
	public FrameData.EvaluationType get_evaluationType() { }

	// RVA: 0x2F21F50 Offset: 0x2F22051 VA: 0x2F21F50
	public bool get_timeLooped() { }

	// RVA: 0x2F21F60 Offset: 0x2F22061 VA: 0x2F21F60
	public bool get_timeHeld() { }

	// RVA: 0x2F21F70 Offset: 0x2F22071 VA: 0x2F21F70
	public PlayableOutput get_output() { }

	// RVA: 0x2F21F80 Offset: 0x2F22081 VA: 0x2F21F80
	public PlayState get_effectivePlayState() { }
}

