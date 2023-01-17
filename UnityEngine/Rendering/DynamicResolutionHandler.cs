// Namespace: UnityEngine.Rendering
public class DynamicResolutionHandler // TypeDefIndex: 4524
{
	// Fields
	private bool m_Enabled; // 0x10
	private float m_MinScreenFraction; // 0x14
	private float m_MaxScreenFraction; // 0x18
	private float m_CurrentFraction; // 0x1C
	private float m_PrevFraction; // 0x20
	private bool m_ForcingRes; // 0x24
	private bool m_CurrentCameraRequest; // 0x25
	private bool m_ForceSoftwareFallback; // 0x26
	private float m_PrevHWScaleWidth; // 0x28
	private float m_PrevHWScaleHeight; // 0x2C
	private Vector2Int m_LastScaledSize; // 0x30
	private DynamicResScalePolicyType m_ScalerType; // 0x38
	private Vector2Int cachedOriginalSize; // 0x3C
	[CompilerGeneratedAttribute] // RVA: 0x3CA10 Offset: 0x3CB11 VA: 0x3CA10
	private DynamicResUpscaleFilter <filter>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x3CA20 Offset: 0x3CB21 VA: 0x3CA20
	private Vector2Int <finalViewport>k__BackingField; // 0x48
	private DynamicResolutionType type; // 0x50
	private PerformDynamicRes m_DynamicResMethod; // 0x58
	private static DynamicResolutionHandler s_Instance; // 0x0

	// Properties
	public DynamicResUpscaleFilter filter { get; set; }
	public Vector2Int finalViewport { get; set; }
	public static DynamicResolutionHandler instance { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x3D640 Offset: 0x3D741 VA: 0x3D640
	// RVA: 0x1A0F590 Offset: 0x1A0F691 VA: 0x1A0F590
	public DynamicResUpscaleFilter get_filter() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D650 Offset: 0x3D751 VA: 0x3D650
	// RVA: 0x1A0F5A0 Offset: 0x1A0F6A1 VA: 0x1A0F5A0
	public void set_filter(DynamicResUpscaleFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x3D660 Offset: 0x3D761 VA: 0x3D660
	// RVA: 0x1A0F5B0 Offset: 0x1A0F6B1 VA: 0x1A0F5B0
	public Vector2Int get_finalViewport() { }

	[CompilerGeneratedAttribute] // RVA: 0x3D670 Offset: 0x3D771 VA: 0x3D670
	// RVA: 0x1A0F5C0 Offset: 0x1A0F6C1 VA: 0x1A0F5C0
	public void set_finalViewport(Vector2Int value) { }

	// RVA: 0x1A0F5D0 Offset: 0x1A0F6D1 VA: 0x1A0F5D0
	public static DynamicResolutionHandler get_instance() { }

	// RVA: 0x1A0F640 Offset: 0x1A0F741 VA: 0x1A0F640
	private void .ctor() { }

	// RVA: 0x1A0F730 Offset: 0x1A0F831 VA: 0x1A0F730
	private static float DefaultDynamicResMethod() { }

	// RVA: 0x1A0F740 Offset: 0x1A0F841 VA: 0x1A0F740
	private void ProcessSettings(GlobalDynamicResolutionSettings settings) { }

	// RVA: 0x1A0F850 Offset: 0x1A0F951 VA: 0x1A0F850
	public static void SetDynamicResScaler(PerformDynamicRes scaler, DynamicResScalePolicyType scalerType = 1) { }

	// RVA: 0x1A0F8E0 Offset: 0x1A0F9E1 VA: 0x1A0F8E0
	public void SetCurrentCameraRequest(bool cameraRequest) { }

	// RVA: 0x1A0F8F0 Offset: 0x1A0F9F1 VA: 0x1A0F8F0
	public void Update(GlobalDynamicResolutionSettings settings, Action OnResolutionChange) { }

	// RVA: 0x1A0FC60 Offset: 0x1A0FD61 VA: 0x1A0FC60
	public bool SoftwareDynamicResIsEnabled() { }

	// RVA: 0x1A0FCB0 Offset: 0x1A0FDB1 VA: 0x1A0FCB0
	public bool HardwareDynamicResIsEnabled() { }

	// RVA: 0x1A0FCE0 Offset: 0x1A0FDE1 VA: 0x1A0FCE0
	public bool RequestsHardwareDynamicResolution() { }

	// RVA: 0x1A0FD00 Offset: 0x1A0FE01 VA: 0x1A0FD00
	public bool DynamicResolutionEnabled() { }

	// RVA: 0x1A0FD30 Offset: 0x1A0FE31 VA: 0x1A0FD30
	public void ForceSoftwareFallback() { }

	// RVA: 0x1A0FD40 Offset: 0x1A0FE41 VA: 0x1A0FD40
	public Vector2Int GetScaledSize(Vector2Int size) { }

	// RVA: 0x1A0FE20 Offset: 0x1A0FF21 VA: 0x1A0FE20
	public float GetCurrentScale() { }

	// RVA: 0x1A0FE40 Offset: 0x1A0FF41 VA: 0x1A0FE40
	public Vector2Int GetLastScaledSize() { }

	// RVA: 0x1A0FE50 Offset: 0x1A0FF51 VA: 0x1A0FE50
	private static void .cctor() { }
}

