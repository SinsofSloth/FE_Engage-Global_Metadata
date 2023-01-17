// Namespace: 
public class CinemachineImpulseManager.ImpulseEvent // TypeDefIndex: 5889
{
	// Fields
	[TooltipAttribute] // RVA: 0x22FD0 Offset: 0x230D1 VA: 0x22FD0
	public float m_StartTime; // 0x10
	[TooltipAttribute] // RVA: 0x23010 Offset: 0x23111 VA: 0x23010
	public CinemachineImpulseManager.EnvelopeDefinition m_Envelope; // 0x18
	[TooltipAttribute] // RVA: 0x23050 Offset: 0x23151 VA: 0x23050
	public ISignalSource6D m_SignalSource; // 0x38
	[TooltipAttribute] // RVA: 0x23090 Offset: 0x23191 VA: 0x23090
	public Vector3 m_Position; // 0x40
	[TooltipAttribute] // RVA: 0x230D0 Offset: 0x231D1 VA: 0x230D0
	public float m_Radius; // 0x4C
	[TooltipAttribute] // RVA: 0x23110 Offset: 0x23211 VA: 0x23110
	public CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode; // 0x50
	[TooltipAttribute] // RVA: 0x23150 Offset: 0x23251 VA: 0x23150
	public int m_Channel; // 0x54
	[TooltipAttribute] // RVA: 0x23190 Offset: 0x23291 VA: 0x23190
	public CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode; // 0x58
	[TooltipAttribute] // RVA: 0x231D0 Offset: 0x232D1 VA: 0x231D0
	public float m_DissipationDistance; // 0x5C
	[TooltipAttribute] // RVA: 0x23210 Offset: 0x23311 VA: 0x23210
	public float m_PropagationSpeed; // 0x60

	// Properties
	public bool Expired { get; }

	// Methods

	// RVA: 0x1A8A3E0 Offset: 0x1A8A4E1 VA: 0x1A8A3E0
	public bool get_Expired() { }

	// RVA: 0x1A8A4D0 Offset: 0x1A8A5D1 VA: 0x1A8A4D0
	public void Cancel(float time, bool forceNoDecay) { }

	// RVA: 0x1A8A520 Offset: 0x1A8A621 VA: 0x1A8A520
	public float DistanceDecay(float distance) { }

	// RVA: 0x1A8A640 Offset: 0x1A8A741 VA: 0x1A8A640
	public bool GetDecayedSignal(Vector3 listenerPosition, bool use2D, out Vector3 pos, out Quaternion rot) { }

	// RVA: 0x1A8AAB0 Offset: 0x1A8ABB1 VA: 0x1A8AAB0
	public void Clear() { }

	// RVA: 0x1A8AB30 Offset: 0x1A8AC31 VA: 0x1A8AB30
	internal void .ctor() { }
}

