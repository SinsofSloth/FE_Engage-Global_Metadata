// Namespace: 
[Serializable]
public struct CinemachineImpulseManager.EnvelopeDefinition // TypeDefIndex: 5886
{
	// Fields
	[TooltipAttribute] // RVA: 0x22E10 Offset: 0x22F11 VA: 0x22E10
	public AnimationCurve m_AttackShape; // 0x0
	[TooltipAttribute] // RVA: 0x22E50 Offset: 0x22F51 VA: 0x22E50
	public AnimationCurve m_DecayShape; // 0x8
	[TooltipAttribute] // RVA: 0x22E90 Offset: 0x22F91 VA: 0x22E90
	public float m_AttackTime; // 0x10
	[TooltipAttribute] // RVA: 0x22ED0 Offset: 0x22FD1 VA: 0x22ED0
	public float m_SustainTime; // 0x14
	[TooltipAttribute] // RVA: 0x22F10 Offset: 0x23011 VA: 0x22F10
	public float m_DecayTime; // 0x18
	[TooltipAttribute] // RVA: 0x22F50 Offset: 0x23051 VA: 0x22F50
	public bool m_ScaleWithImpact; // 0x1C
	[TooltipAttribute] // RVA: 0x22F90 Offset: 0x23091 VA: 0x22F90
	public bool m_HoldForever; // 0x1D

	// Properties
	public float Duration { get; }

	// Methods

	// RVA: 0x1A8A0E0 Offset: 0x1A8A1E1 VA: 0x1A8A0E0
	public static CinemachineImpulseManager.EnvelopeDefinition Default() { }

	// RVA: 0x1A8A0B0 Offset: 0x1A8A1B1 VA: 0x1A8A0B0
	public float get_Duration() { }

	// RVA: 0x1A8A110 Offset: 0x1A8A211 VA: 0x1A8A110
	public float GetValueAt(float offset) { }

	// RVA: 0x1A8A2F0 Offset: 0x1A8A3F1 VA: 0x1A8A2F0
	public void ChangeStopTime(float offset, bool forceNoDecay) { }

	// RVA: 0x1A8A330 Offset: 0x1A8A431 VA: 0x1A8A330
	public void Clear() { }

	// RVA: 0x1A8A370 Offset: 0x1A8A471 VA: 0x1A8A370
	public void Validate() { }
}

// Namespace: 
public enum CinemachineImpulseManager.ImpulseEvent.DirectionMode // TypeDefIndex: 5887
{
	// Fields
	public int value__; // 0x0
	public const CinemachineImpulseManager.ImpulseEvent.DirectionMode Fixed = 0;
	public const CinemachineImpulseManager.ImpulseEvent.DirectionMode RotateTowardSource = 1;
}

// Namespace: 
public enum CinemachineImpulseManager.ImpulseEvent.DissipationMode // TypeDefIndex: 5888
{
	// Fields
	public int value__; // 0x0
	public const CinemachineImpulseManager.ImpulseEvent.DissipationMode LinearDecay = 0;
	public const CinemachineImpulseManager.ImpulseEvent.DissipationMode SoftDecay = 1;
	public const CinemachineImpulseManager.ImpulseEvent.DissipationMode ExponentialDecay = 2;
}

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

