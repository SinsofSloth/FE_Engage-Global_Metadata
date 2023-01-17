// Namespace: App
public class RingCleaningRoot : MonoBehaviour // TypeDefIndex: 11756
{
	// Fields
	public RingCleaningConditionIcon m_ConditionIcon; // 0x18
	public RingCleaningGaugeController m_GaugeController; // 0x20
	public RingCleaningCloth m_Cloth; // 0x28
	private RingCleaningRingController m_Ring; // 0x30

	// Properties
	public RingCleaningGaugeController GaugeController { get; }
	public RingCleaningConditionIcon ConditionIcon { get; }

	// Methods

	// RVA: 0x267AAB0 Offset: 0x267ABB1 VA: 0x267AAB0
	public RingCleaningGaugeController get_GaugeController() { }

	// RVA: 0x267AAC0 Offset: 0x267ABC1 VA: 0x267AAC0
	public RingCleaningConditionIcon get_ConditionIcon() { }

	// RVA: 0x267AAD0 Offset: 0x267ABD1 VA: 0x267AAD0
	public void Init(GodUnit god, Unit unit, RingCleaningRingController ringController) { }

	// RVA: 0x267AB40 Offset: 0x267AC41 VA: 0x267AB40
	public void UpdateDirty(int newDirty) { }

	// RVA: 0x267ABD0 Offset: 0x267ACD1 VA: 0x267ABD0
	public bool IsFinishCleaning() { }

	// RVA: 0x267A830 Offset: 0x267A931 VA: 0x267A830
	public float GetTextureDirty(int dirty) { }

	// RVA: 0x267ABE0 Offset: 0x267ACE1 VA: 0x267ABE0
	public void .ctor() { }
}

