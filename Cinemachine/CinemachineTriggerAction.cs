// Namespace: Cinemachine
[SaveDuringPlayAttribute] // RVA: 0x1BAA0 Offset: 0x1BBA1 VA: 0x1BAA0
[HelpURLAttribute] // RVA: 0x1BAA0 Offset: 0x1BBA1 VA: 0x1BAA0
[DocumentationSortingAttribute] // RVA: 0x1BAA0 Offset: 0x1BBA1 VA: 0x1BAA0
public class CinemachineTriggerAction : MonoBehaviour // TypeDefIndex: 5875
{
	// Fields
	[HeaderAttribute] // RVA: 0x22250 Offset: 0x22351 VA: 0x22250
	[TooltipAttribute] // RVA: 0x22250 Offset: 0x22351 VA: 0x22250
	public LayerMask m_LayerMask; // 0x18
	[TagFieldAttribute] // RVA: 0x222B0 Offset: 0x223B1 VA: 0x222B0
	[TooltipAttribute] // RVA: 0x222B0 Offset: 0x223B1 VA: 0x222B0
	public string m_WithTag; // 0x20
	[TagFieldAttribute] // RVA: 0x22300 Offset: 0x22401 VA: 0x22300
	[TooltipAttribute] // RVA: 0x22300 Offset: 0x22401 VA: 0x22300
	public string m_WithoutTag; // 0x28
	[TooltipAttribute] // RVA: 0x22350 Offset: 0x22451 VA: 0x22350
	[NoSaveDuringPlayAttribute] // RVA: 0x22350 Offset: 0x22451 VA: 0x22350
	public int m_SkipFirst; // 0x30
	[TooltipAttribute] // RVA: 0x223A0 Offset: 0x224A1 VA: 0x223A0
	public bool m_Repeating; // 0x34
	public CinemachineTriggerAction.ActionSettings m_OnObjectEnter; // 0x38
	public CinemachineTriggerAction.ActionSettings m_OnObjectExit; // 0x60
	private HashSet<GameObject> m_ActiveTriggerObjects; // 0x88

	// Methods

	// RVA: 0x1A79E20 Offset: 0x1A79F21 VA: 0x1A79E20
	private bool Filter(GameObject other) { }

	// RVA: 0x1A79ED0 Offset: 0x1A79FD1 VA: 0x1A79ED0
	private void InternalDoTriggerEnter(GameObject other) { }

	// RVA: 0x1A7A490 Offset: 0x1A7A591 VA: 0x1A7A490
	private void InternalDoTriggerExit(GameObject other) { }

	// RVA: 0x1A7A540 Offset: 0x1A7A641 VA: 0x1A7A540
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x1A7A5F0 Offset: 0x1A7A6F1 VA: 0x1A7A5F0
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x1A7A6B0 Offset: 0x1A7A7B1 VA: 0x1A7A6B0
	private void OnCollisionEnter(Collision other) { }

	// RVA: 0x1A7A760 Offset: 0x1A7A861 VA: 0x1A7A760
	private void OnCollisionExit(Collision other) { }

	// RVA: 0x1A7A820 Offset: 0x1A7A921 VA: 0x1A7A820
	private void OnTriggerEnter2D(Collider2D other) { }

	// RVA: 0x1A7A8D0 Offset: 0x1A7A9D1 VA: 0x1A7A8D0
	private void OnTriggerExit2D(Collider2D other) { }

	// RVA: 0x1A7A990 Offset: 0x1A7AA91 VA: 0x1A7A990
	private void OnCollisionEnter2D(Collision2D other) { }

	// RVA: 0x1A7AA40 Offset: 0x1A7AB41 VA: 0x1A7AA40
	private void OnCollisionExit2D(Collision2D other) { }

	// RVA: 0x1A7AB00 Offset: 0x1A7AC01 VA: 0x1A7AB00
	private void OnEnable() { }

	// RVA: 0x1A7AB10 Offset: 0x1A7AC11 VA: 0x1A7AB10
	public void .ctor() { }
}

