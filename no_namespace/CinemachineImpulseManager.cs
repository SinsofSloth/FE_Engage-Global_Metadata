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
public enum CinemachineImpulseManager.ImpulseEvent.DissipationMode // TypeDefIndex: 5888
{
	// Fields
	public int value__; // 0x0
	public const CinemachineImpulseManager.ImpulseEvent.DissipationMode LinearDecay = 0;
	public const CinemachineImpulseManager.ImpulseEvent.DissipationMode SoftDecay = 1;
	public const CinemachineImpulseManager.ImpulseEvent.DissipationMode ExponentialDecay = 2;
}

