// Namespace: 
private class RingInfo.RingInfoWindowRingModel // TypeDefIndex: 11831
{
	// Fields
	private int m_Index; // 0x10
	private readonly string PrefabPath; // 0x18
	private TResourceHandle<GameObject> m_PrefabHandle; // 0x20
	private GameObject m_GameObject; // 0x28
	private GameObject m_CameraObject; // 0x30
	private Camera m_Camera; // 0x38
	private Animator m_Animator; // 0x40

	// Properties
	public GameObject PrefabObject { get; }
	public GameObject RingModelRoot { get; }

	// Methods

	// RVA: 0x1F4C180 Offset: 0x1F4C281 VA: 0x1F4C180
	public void .ctor(int index) { }

	// RVA: 0x1F4C200 Offset: 0x1F4C301 VA: 0x1F4C200
	public void CreateAsync() { }

	// RVA: 0x1F4C320 Offset: 0x1F4C421 VA: 0x1F4C320
	public bool IsCreating() { }

	// RVA: 0x1F4C350 Offset: 0x1F4C451 VA: 0x1F4C350
	public void Destroy() { }

	// RVA: 0x1F4C420 Offset: 0x1F4C521 VA: 0x1F4C420
	private void CreateImpl() { }

	// RVA: 0x1F4C560 Offset: 0x1F4C661 VA: 0x1F4C560
	private bool Setup() { }

	// RVA: 0x1F4C830 Offset: 0x1F4C931 VA: 0x1F4C830
	public RenderTexture GetRenderTexture() { }

	// RVA: 0x1F4C8C0 Offset: 0x1F4C9C1 VA: 0x1F4C8C0
	public GameObject get_PrefabObject() { }

	// RVA: 0x1F4C8D0 Offset: 0x1F4C9D1 VA: 0x1F4C8D0
	public GameObject get_RingModelRoot() { }

	// RVA: 0x1F4C940 Offset: 0x1F4CA41 VA: 0x1F4C940
	public void SetAnimatorEnable(bool value) { }

	// RVA: 0x1F4C9D0 Offset: 0x1F4CAD1 VA: 0x1F4C9D0
	public float GetDirtyTextureValue(int dirty) { }

	// RVA: 0x1F4CA50 Offset: 0x1F4CB51 VA: 0x1F4CA50
	public void PlayDecisionAnim() { }

	// RVA: 0x1F4C7E0 Offset: 0x1F4C8E1 VA: 0x1F4C7E0
	private Vector3 GetModelPosition() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6BE0 Offset: 0x2C6CE1 VA: 0x2C6BE0
	// RVA: 0x1F4CAB0 Offset: 0x1F4CBB1 VA: 0x1F4CAB0
	private void <CreateAsync>b__8_0(GameObject _) { }
}

