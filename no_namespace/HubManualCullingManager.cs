// Namespace: 
[Serializable]
public class HubManualCullingManager.CullingGroup // TypeDefIndex: 10692
{
	// Fields
	public string m_Name; // 0x10
	public GameObject[] m_CullTargets; // 0x18
	private List<Renderer> m_Renderers; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x294C50 Offset: 0x294D51 VA: 0x294C50
	private bool <IsCulling>k__BackingField; // 0x28

	// Properties
	public bool IsCulling { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C09D0 Offset: 0x2C0AD1 VA: 0x2C09D0
	// RVA: 0x1FB0680 Offset: 0x1FB0781 VA: 0x1FB0680
	public bool get_IsCulling() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C09E0 Offset: 0x2C0AE1 VA: 0x2C09E0
	// RVA: 0x1FB0690 Offset: 0x1FB0791 VA: 0x1FB0690
	private void set_IsCulling(bool value) { }

	// RVA: 0x1FB06A0 Offset: 0x1FB07A1 VA: 0x1FB06A0
	public void ChangeCullingState(bool isNextCulling, bool force) { }

	// RVA: 0x1FB07E0 Offset: 0x1FB08E1 VA: 0x1FB07E0
	public void CollectRenderers() { }

	// RVA: 0x1FB09B0 Offset: 0x1FB0AB1 VA: 0x1FB09B0
	public void .ctor() { }
}

