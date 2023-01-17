// Namespace: App
public abstract class HubManualCullingManager : MonoBehaviour // TypeDefIndex: 10693
{
	// Fields
	public HubManualCullingManager.CullingGroup[] m_CullGroups; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x294C30 Offset: 0x294D31 VA: 0x294C30
	private List<HubManualCulling> <StayCullings>k__BackingField; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x294C40 Offset: 0x294D41 VA: 0x294C40
	private HubManualCulling <ActiveManualCulling>k__BackingField; // 0x28
	private Stack<HubManualCulling> m_ManualCullingStack; // 0x30
	private bool m_Enable; // 0x38

	// Properties
	public List<HubManualCulling> StayCullings { get; set; }
	public HubManualCulling ActiveManualCulling { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C0990 Offset: 0x2C0A91 VA: 0x2C0990
	// RVA: 0x2BE11C0 Offset: 0x2BE12C1 VA: 0x2BE11C0
	public List<HubManualCulling> get_StayCullings() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C09A0 Offset: 0x2C0AA1 VA: 0x2C09A0
	// RVA: 0x2BE11D0 Offset: 0x2BE12D1 VA: 0x2BE11D0
	private void set_StayCullings(List<HubManualCulling> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C09B0 Offset: 0x2C0AB1 VA: 0x2C09B0
	// RVA: 0x2BE11E0 Offset: 0x2BE12E1 VA: 0x2BE11E0
	public HubManualCulling get_ActiveManualCulling() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C09C0 Offset: 0x2C0AC1 VA: 0x2C09C0
	// RVA: 0x2BE11F0 Offset: 0x2BE12F1 VA: 0x2BE11F0
	private void set_ActiveManualCulling(HubManualCulling value) { }

	// RVA: 0x2BE1200 Offset: 0x2BE1301 VA: 0x2BE1200
	private void Start() { }

	// RVA: 0x2BE1270 Offset: 0x2BE1371 VA: 0x2BE1270
	public void Enter(HubManualCulling cull) { }

	// RVA: 0x2BE1450 Offset: 0x2BE1551 VA: 0x2BE1450
	public void Leave(HubManualCulling cull) { }

	// RVA: 0x2BE1540 Offset: 0x2BE1641 VA: 0x2BE1540
	public void Clear() { }

	// RVA: 0x2BE1380 Offset: 0x2BE1481 VA: 0x2BE1380
	private void UpdateVisibility() { }

	// RVA: 0x2BE15A0 Offset: 0x2BE16A1 VA: 0x2BE15A0
	private void UpdateVisibility(HubManualCulling nextManualCulling) { }

	// RVA: 0x2BE17A0 Offset: 0x2BE18A1 VA: 0x2BE17A0
	public void EnableCulling() { }

	// RVA: 0x2BE17B0 Offset: 0x2BE18B1 VA: 0x2BE17B0
	public void DisableCulling() { }

	// RVA: 0x2BE17C0 Offset: 0x2BE18C1 VA: 0x2BE17C0
	public void Push(string cullingName) { }

	// RVA: 0x2BE1950 Offset: 0x2BE1A51 VA: 0x2BE1950
	public void Push(GameObject gameObject) { }

	// RVA: 0x2BE19F0 Offset: 0x2BE1AF1 VA: 0x2BE19F0
	public void Push(HubManualCulling culling) { }

	// RVA: 0x2BE1A60 Offset: 0x2BE1B61 VA: 0x2BE1A60
	public void Pop() { }

	// RVA: 0x2BE1AE0 Offset: 0x2BE1BE1 VA: 0x2BE1AE0
	protected void .ctor() { }
}

