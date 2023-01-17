// Namespace: App
public abstract class HubCullingPlayerCollider : MonoBehaviour // TypeDefIndex: 10670
{
	// Fields
	public static readonly string kHubCullingTag; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x294360 Offset: 0x294461 VA: 0x294360
	private HubManualCullingManager <ManualCullingManager>k__BackingField; // 0x18
	private Queue<Collider> m_EnterColliders; // 0x20
	private Queue<Collider> m_ExitColliders; // 0x28

	// Properties
	public HubManualCullingManager ManualCullingManager { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C0770 Offset: 0x2C0871 VA: 0x2C0770
	// RVA: 0x305A610 Offset: 0x305A711 VA: 0x305A610
	public HubManualCullingManager get_ManualCullingManager() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C0780 Offset: 0x2C0881 VA: 0x2C0780
	// RVA: 0x305A620 Offset: 0x305A721 VA: 0x305A620
	private void set_ManualCullingManager(HubManualCullingManager value) { }

	// RVA: 0x305A630 Offset: 0x305A731 VA: 0x305A630
	private void Start() { }

	// RVA: 0x305A6A0 Offset: 0x305A7A1 VA: 0x305A6A0
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x305A780 Offset: 0x305A881 VA: 0x305A780
	private void CallTriggerEnter(Collider other) { }

	// RVA: 0x305A9A0 Offset: 0x305AAA1 VA: 0x305A9A0
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x305AA80 Offset: 0x305AB81 VA: 0x305AA80
	private void CallTriggerExit(Collider other) { }

	// RVA: 0x305ACA0 Offset: 0x305ADA1 VA: 0x305ACA0
	private void Update() { }

	// RVA: 0x305ACB0 Offset: 0x305ADB1 VA: 0x305ACB0
	public void Polling() { }

	// RVA: 0x305AD70 Offset: 0x305AE71 VA: 0x305AD70
	public void DisableCulling() { }

	// RVA: 0x305AD90 Offset: 0x305AE91 VA: 0x305AD90
	public void EnableCulling() { }

	// RVA: 0x305ADB0 Offset: 0x305AEB1 VA: 0x305ADB0
	public void ClearCulling() { }

	// RVA: 0x305ADD0 Offset: 0x305AED1 VA: 0x305ADD0
	protected void .ctor() { }

	// RVA: 0x305AE80 Offset: 0x305AF81 VA: 0x305AE80
	private static void .cctor() { }
}

