// Namespace: App
public class RingCleaningRingController // TypeDefIndex: 11755
{
	// Fields
	private GodUnit m_GodUnit; // 0x10
	private GameObject m_Ring; // 0x18
	private Material[] m_RingMaterials; // 0x20
	private RingCollider m_RingCollider; // 0x28
	private readonly float InitHeight; // 0x30
	private readonly Vector3 InitRotate; // 0x34
	private readonly float RotateSpeed; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x299040 Offset: 0x299141 VA: 0x299040
	private bool <CanResetRotate>k__BackingField; // 0x44
	private InterpolatorVector3 m_InitRotation; // 0x48
	private InterpolatorInt m_InterDirty; // 0x50
	private RingCleaningRoot m_InfoRoot; // 0x58

	// Properties
	public bool CanResetRotate { get; set; }
	public RingCollider RingCollider { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C65D0 Offset: 0x2C66D1 VA: 0x2C65D0
	// RVA: 0x2679F10 Offset: 0x267A011 VA: 0x2679F10
	public bool get_CanResetRotate() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C65E0 Offset: 0x2C66E1 VA: 0x2C65E0
	// RVA: 0x2679F20 Offset: 0x267A021 VA: 0x2679F20
	private void set_CanResetRotate(bool value) { }

	// RVA: 0x2679F30 Offset: 0x267A031 VA: 0x2679F30
	public void .ctor(GodUnit god) { }

	// RVA: 0x267A040 Offset: 0x267A141 VA: 0x267A040
	public RingCollider get_RingCollider() { }

	// RVA: 0x267A050 Offset: 0x267A151 VA: 0x267A050
	public void LoadAsync() { }

	// RVA: 0x267A0F0 Offset: 0x267A1F1 VA: 0x267A0F0
	public bool IsLoading() { }

	// RVA: 0x267A170 Offset: 0x267A271 VA: 0x267A170
	public void Unload() { }

	// RVA: 0x267A2A0 Offset: 0x267A3A1 VA: 0x267A2A0
	public void Initialize(RingCleaningRoot infoRoot) { }

	// RVA: 0x267A550 Offset: 0x267A651 VA: 0x267A550
	public void UpdateRotate(float rdx, float rdy) { }

	// RVA: 0x267A610 Offset: 0x267A711 VA: 0x267A610
	public void UpdateDirtyTick() { }

	// RVA: 0x267A850 Offset: 0x267A951 VA: 0x267A850
	public void SetMaterialDirty(int dirty) { }

	// RVA: 0x267A870 Offset: 0x267A971 VA: 0x267A870
	public void SetMaterialDirtyImmediately(int dirty) { }

	// RVA: 0x267A890 Offset: 0x267A991 VA: 0x267A890
	public void SetResetRotation() { }

	// RVA: 0x267A920 Offset: 0x267AA21 VA: 0x267A920
	public bool UpdateResetRotation() { }
}

