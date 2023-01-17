// Namespace: Cinemachine
[DocumentationSortingAttribute] // RVA: 0x1BBA0 Offset: 0x1BCA1 VA: 0x1BBA0
[SaveDuringPlayAttribute] // RVA: 0x1BBA0 Offset: 0x1BCA1 VA: 0x1BBA0
[HelpURLAttribute] // RVA: 0x1BBA0 Offset: 0x1BCA1 VA: 0x1BBA0
public class CinemachineCollisionImpulseSource : CinemachineImpulseSource // TypeDefIndex: 5877
{
	// Fields
	[HeaderAttribute] // RVA: 0x22760 Offset: 0x22861 VA: 0x22760
	[TooltipAttribute] // RVA: 0x22760 Offset: 0x22861 VA: 0x22760
	public LayerMask m_LayerMask; // 0x20
	[TooltipAttribute] // RVA: 0x227C0 Offset: 0x228C1 VA: 0x227C0
	[TagFieldAttribute] // RVA: 0x227C0 Offset: 0x228C1 VA: 0x227C0
	public string m_IgnoreTag; // 0x28
	[TooltipAttribute] // RVA: 0x22810 Offset: 0x22911 VA: 0x22810
	[HeaderAttribute] // RVA: 0x22810 Offset: 0x22911 VA: 0x22810
	public bool m_UseImpactDirection; // 0x30
	[TooltipAttribute] // RVA: 0x22870 Offset: 0x22971 VA: 0x22870
	public bool m_ScaleImpactWithMass; // 0x31
	[TooltipAttribute] // RVA: 0x228B0 Offset: 0x229B1 VA: 0x228B0
	public bool m_ScaleImpactWithSpeed; // 0x32
	private Rigidbody mRigidBody; // 0x38
	private Rigidbody2D mRigidBody2D; // 0x40

	// Methods

	// RVA: 0x1B92190 Offset: 0x1B92291 VA: 0x1B92190
	private void Start() { }

	// RVA: 0x1B92230 Offset: 0x1B92331 VA: 0x1B92230
	private void OnEnable() { }

	// RVA: 0x1B92240 Offset: 0x1B92341 VA: 0x1B92240
	private void OnCollisionEnter(Collision c) { }

	// RVA: 0x1B92410 Offset: 0x1B92511 VA: 0x1B92410
	private void OnTriggerEnter(Collider c) { }

	// RVA: 0x1B92440 Offset: 0x1B92541 VA: 0x1B92440
	private float GetMassAndVelocity(Collider other, ref Vector3 vel) { }

	// RVA: 0x1B92290 Offset: 0x1B92391 VA: 0x1B92290
	private void GenerateImpactEvent(Collider other, Vector3 vel) { }

	// RVA: 0x1B92640 Offset: 0x1B92741 VA: 0x1B92640
	private void OnCollisionEnter2D(Collision2D c) { }

	// RVA: 0x1B92810 Offset: 0x1B92911 VA: 0x1B92810
	private void OnTriggerEnter2D(Collider2D c) { }

	// RVA: 0x1B92840 Offset: 0x1B92941 VA: 0x1B92840
	private float GetMassAndVelocity2D(Collider2D other2d, ref Vector3 vel) { }

	// RVA: 0x1B92690 Offset: 0x1B92791 VA: 0x1B92690
	private void GenerateImpactEvent2D(Collider2D other2d, Vector3 vel) { }

	// RVA: 0x1B92A40 Offset: 0x1B92B41 VA: 0x1B92A40
	public void .ctor() { }
}

