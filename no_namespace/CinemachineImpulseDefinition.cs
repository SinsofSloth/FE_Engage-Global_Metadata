// Namespace: 
public enum CinemachineImpulseDefinition.RepeatMode // TypeDefIndex: 5880
{
	// Fields
	public int value__; // 0x0
	public const CinemachineImpulseDefinition.RepeatMode Stretch = 0;
	public const CinemachineImpulseDefinition.RepeatMode Loop = 1;
}

// Namespace: 
private class CinemachineImpulseDefinition.SignalSource : ISignalSource6D // TypeDefIndex: 5881
{
	// Fields
	private CinemachineImpulseDefinition m_Def; // 0x10
	private Vector3 m_Velocity; // 0x18
	private float m_StartTimeOffset; // 0x24

	// Properties
	public float SignalDuration { get; }

	// Methods

	// RVA: 0x1A89E60 Offset: 0x1A89F61 VA: 0x1A89E60
	public void .ctor(CinemachineImpulseDefinition def, Vector3 velocity) { }

	// RVA: 0x1A89F10 Offset: 0x1A8A011 VA: 0x1A89F10 Slot: 4
	public float get_SignalDuration() { }

	// RVA: 0x1A89F30 Offset: 0x1A8A031 VA: 0x1A89F30 Slot: 5
	public void GetSignal(float timeSinceSignalStart, out Vector3 pos, out Quaternion rot) { }
}

