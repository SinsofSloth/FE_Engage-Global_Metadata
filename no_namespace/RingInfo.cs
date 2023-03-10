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

// Namespace: 
private class RingInfo.RingPrefabObject // TypeDefIndex: 11832
{
	// Fields
	private static Dictionary<string, RingInfo.RingPrefabObject> s_RingPrefabObjectDict; // 0x0
	private RingInfo.RingInfoWindowRingModel m_RingInfoWindow; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x2995F0 Offset: 0x2996F1 VA: 0x2995F0
	private bool <m_IsVisibleDirty>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x299600 Offset: 0x299701 VA: 0x299600
	private bool <IsDelete>k__BackingField; // 0x19
	private TResourceHandle<GameObject> m_ResourceHandle; // 0x20
	private GameObject m_RingObject; // 0x28
	private GodUnit m_God; // 0x30
	private Material[] m_Materials; // 0x38
	private RingData m_RingData; // 0x40

	// Properties
	private bool m_IsVisibleDirty { get; set; }
	public bool IsDelete { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x2C6BF0 Offset: 0x2C6CF1 VA: 0x2C6BF0
	// RVA: 0x1F4CAC0 Offset: 0x1F4CBC1 VA: 0x1F4CAC0
	private bool get_m_IsVisibleDirty() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6C00 Offset: 0x2C6D01 VA: 0x2C6C00
	// RVA: 0x1F4CAD0 Offset: 0x1F4CBD1 VA: 0x1F4CAD0
	private void set_m_IsVisibleDirty(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6C10 Offset: 0x2C6D11 VA: 0x2C6C10
	// RVA: 0x1F4CAE0 Offset: 0x1F4CBE1 VA: 0x1F4CAE0
	public bool get_IsDelete() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6C20 Offset: 0x2C6D21 VA: 0x2C6C20
	// RVA: 0x1F4CAF0 Offset: 0x1F4CBF1 VA: 0x1F4CAF0
	private void set_IsDelete(bool value) { }

	// RVA: 0x1F4CB00 Offset: 0x1F4CC01 VA: 0x1F4CB00
	public static RingInfo.RingPrefabObject CreateObject(RingInfo.RingInfoWindowRingModel ringInfoWindow, GodUnit god, RingData ring, bool isPlayAnimation = True, bool isVisibleDirty = False) { }

	// RVA: 0x1F4CBF0 Offset: 0x1F4CCF1 VA: 0x1F4CBF0
	private static RingInfo.RingPrefabObject CreateObjectImpl(GodUnit god, RingInfo.RingInfoWindowRingModel ringInfoWindow, bool isVisibleDirty = False) { }

	// RVA: 0x1F4CF30 Offset: 0x1F4D031 VA: 0x1F4CF30
	public static RingInfo.RingPrefabObject CreateObjectImpl(RingData ringData, RingInfo.RingInfoWindowRingModel ringInfoWindow, bool isPlayAnimation, bool isVisibleDirty = False) { }

	// RVA: 0x1F4D2A0 Offset: 0x1F4D3A1 VA: 0x1F4D2A0
	private static string GetRingPrefabPath(GodUnit god) { }

	// RVA: 0x1F4D120 Offset: 0x1F4D221 VA: 0x1F4D120
	private void .ctor(string prefabPath, RingInfo.RingInfoWindowRingModel ringInfoWindow, GodUnit god, RingData ring, bool isVisibleDirty = False) { }

	// RVA: 0x1F4D380 Offset: 0x1F4D481 VA: 0x1F4D380
	public static void DeleteAll() { }

	// RVA: 0x1F4D570 Offset: 0x1F4D671 VA: 0x1F4D570
	public void Delete() { }

	// RVA: 0x1F4D690 Offset: 0x1F4D791 VA: 0x1F4D690
	public static void UpdateDirtyAll() { }

	// RVA: 0x1F4D850 Offset: 0x1F4D951 VA: 0x1F4D850
	private void UpdateDirty() { }

	// RVA: 0x1F4D970 Offset: 0x1F4DA71 VA: 0x1F4D970
	private void CreateImpl() { }

	// RVA: 0x1F4DFD0 Offset: 0x1F4E0D1 VA: 0x1F4DFD0
	private static string GetGodAsciiName(GameObject ringObject) { }

	// RVA: 0x1F4E0F0 Offset: 0x1F4E1F1 VA: 0x1F4E0F0
	private static void .cctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6C30 Offset: 0x2C6D31 VA: 0x2C6C30
	// RVA: 0x1F4E190 Offset: 0x1F4E291 VA: 0x1F4E190
	private void <.ctor>b__19_0(GameObject _) { }

	[CompilerGeneratedAttribute] // RVA: 0x2C6C40 Offset: 0x2C6D41 VA: 0x2C6C40
	// RVA: 0x1F4E0E0 Offset: 0x1F4E1E1 VA: 0x1F4E0E0
	internal static string <CreateImpl>g__GetAsciiName|24_0(GodData data) { }
}

