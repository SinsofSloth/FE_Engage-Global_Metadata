// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1BC50 Offset: 0x1BD51 VA: 0x1BC50
[Serializable]
public class CinemachineImpulseDefinition // TypeDefIndex: 5882
{
	// Fields
	[TooltipAttribute] // RVA: 0x229B0 Offset: 0x22AB1 VA: 0x229B0
	[CinemachineImpulseChannelPropertyAttribute] // RVA: 0x229B0 Offset: 0x22AB1 VA: 0x229B0
	public int m_ImpulseChannel; // 0x10
	[TooltipAttribute] // RVA: 0x22A00 Offset: 0x22B01 VA: 0x22A00
	[CinemachineEmbeddedAssetPropertyAttribute] // RVA: 0x22A00 Offset: 0x22B01 VA: 0x22A00
	[HeaderAttribute] // RVA: 0x22A00 Offset: 0x22B01 VA: 0x22A00
	public SignalSourceAsset m_RawSignal; // 0x18
	[TooltipAttribute] // RVA: 0x22A80 Offset: 0x22B81 VA: 0x22A80
	public float m_AmplitudeGain; // 0x20
	[TooltipAttribute] // RVA: 0x22AC0 Offset: 0x22BC1 VA: 0x22AC0
	public float m_FrequencyGain; // 0x24
	[TooltipAttribute] // RVA: 0x22B00 Offset: 0x22C01 VA: 0x22B00
	public CinemachineImpulseDefinition.RepeatMode m_RepeatMode; // 0x28
	[TooltipAttribute] // RVA: 0x22B40 Offset: 0x22C41 VA: 0x22B40
	public bool m_Randomize; // 0x2C
	[CinemachineImpulseEnvelopePropertyAttribute] // RVA: 0x22B80 Offset: 0x22C81 VA: 0x22B80
	[TooltipAttribute] // RVA: 0x22B80 Offset: 0x22C81 VA: 0x22B80
	public CinemachineImpulseManager.EnvelopeDefinition m_TimeEnvelope; // 0x30
	[TooltipAttribute] // RVA: 0x22BD0 Offset: 0x22CD1 VA: 0x22BD0
	[HeaderAttribute] // RVA: 0x22BD0 Offset: 0x22CD1 VA: 0x22BD0
	public float m_ImpactRadius; // 0x50
	[TooltipAttribute] // RVA: 0x22C30 Offset: 0x22D31 VA: 0x22C30
	public CinemachineImpulseManager.ImpulseEvent.DirectionMode m_DirectionMode; // 0x54
	[TooltipAttribute] // RVA: 0x22C70 Offset: 0x22D71 VA: 0x22C70
	public CinemachineImpulseManager.ImpulseEvent.DissipationMode m_DissipationMode; // 0x58
	[TooltipAttribute] // RVA: 0x22CB0 Offset: 0x22DB1 VA: 0x22CB0
	public float m_DissipationDistance; // 0x5C
	[TooltipAttribute] // RVA: 0x22CF0 Offset: 0x22DF1 VA: 0x22CF0
	public float m_PropagationSpeed; // 0x60

	// Methods

	// RVA: 0x1B9FC20 Offset: 0x1B9FD21 VA: 0x1B9FC20
	public void OnValidate() { }

	// RVA: 0x1B9FC90 Offset: 0x1B9FD91 VA: 0x1B9FC90
	public void CreateEvent(Vector3 position, Vector3 velocity) { }

	// RVA: 0x1B9FCA0 Offset: 0x1B9FDA1 VA: 0x1B9FCA0
	public CinemachineImpulseManager.ImpulseEvent CreateAndReturnEvent(Vector3 position, Vector3 velocity) { }

	// RVA: 0x1BA01E0 Offset: 0x1BA02E1 VA: 0x1BA01E0
	public void .ctor() { }
}

