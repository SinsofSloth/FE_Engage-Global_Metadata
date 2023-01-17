// Namespace: 
[Serializable]
public class InteractionTrigger.Range // TypeDefIndex: 14423
{
	// Fields
	[HideInInspector] // RVA: 0x2A3810 Offset: 0x2A3911 VA: 0x2A3810
	public string name; // 0x10
	[HideInInspector] // RVA: 0x2A3820 Offset: 0x2A3921 VA: 0x2A3820
	public bool show; // 0x18
	[TooltipAttribute] // RVA: 0x2A3830 Offset: 0x2A3931 VA: 0x2A3830
	public InteractionTrigger.CharacterPosition characterPosition; // 0x20
	[TooltipAttribute] // RVA: 0x2A3870 Offset: 0x2A3971 VA: 0x2A3870
	public InteractionTrigger.CameraPosition cameraPosition; // 0x28
	[TooltipAttribute] // RVA: 0x2A38B0 Offset: 0x2A39B1 VA: 0x2A38B0
	public InteractionTrigger.Range.Interaction[] interactions; // 0x30

	// Methods

	// RVA: 0x22221D0 Offset: 0x22222D1 VA: 0x22221D0
	public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError) { }

	// RVA: 0x2222280 Offset: 0x2222381 VA: 0x2222280
	public void .ctor() { }
}

