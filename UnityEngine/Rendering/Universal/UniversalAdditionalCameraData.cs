// Namespace: UnityEngine.Rendering.Universal
[MovedFromAttribute] // RVA: 0x47FC10 Offset: 0x47FD11 VA: 0x47FC10
[ImageEffectAllowedInSceneView] // RVA: 0x47FC10 Offset: 0x47FD11 VA: 0x47FC10
[RequireComponent] // RVA: 0x47FC10 Offset: 0x47FD11 VA: 0x47FC10
[DisallowMultipleComponent] // RVA: 0x47FC10 Offset: 0x47FD11 VA: 0x47FC10
public class UniversalAdditionalCameraData : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 5351
{
	// Fields
	[SerializeField] // RVA: 0x482C10 Offset: 0x482D11 VA: 0x482C10
	[FormerlySerializedAsAttribute] // RVA: 0x482C10 Offset: 0x482D11 VA: 0x482C10
	private bool m_RenderShadows; // 0x18
	[SerializeField] // RVA: 0x482C60 Offset: 0x482D61 VA: 0x482C60
	private CameraOverrideOption m_RequiresDepthTextureOption; // 0x1C
	[SerializeField] // RVA: 0x482C70 Offset: 0x482D71 VA: 0x482C70
	private CameraOverrideOption m_RequiresOpaqueTextureOption; // 0x20
	[SerializeField] // RVA: 0x482C80 Offset: 0x482D81 VA: 0x482C80
	private CameraRenderType m_CameraType; // 0x24
	[SerializeField] // RVA: 0x482C90 Offset: 0x482D91 VA: 0x482C90
	private List<Camera> m_Cameras; // 0x28
	[SerializeField] // RVA: 0x482CA0 Offset: 0x482DA1 VA: 0x482CA0
	private int m_RendererIndex; // 0x30
	[SerializeField] // RVA: 0x482CB0 Offset: 0x482DB1 VA: 0x482CB0
	private LayerMask m_VolumeLayerMask; // 0x34
	[SerializeField] // RVA: 0x482CC0 Offset: 0x482DC1 VA: 0x482CC0
	private Transform m_VolumeTrigger; // 0x38
	[SerializeField] // RVA: 0x482CD0 Offset: 0x482DD1 VA: 0x482CD0
	private bool m_RenderPostProcessing; // 0x40
	[SerializeField] // RVA: 0x482CE0 Offset: 0x482DE1 VA: 0x482CE0
	private AntialiasingMode m_Antialiasing; // 0x44
	[SerializeField] // RVA: 0x482CF0 Offset: 0x482DF1 VA: 0x482CF0
	private AntialiasingQuality m_AntialiasingQuality; // 0x48
	[SerializeField] // RVA: 0x482D00 Offset: 0x482E01 VA: 0x482D00
	private bool m_StopNaN; // 0x4C
	[SerializeField] // RVA: 0x482D10 Offset: 0x482E11 VA: 0x482D10
	private bool m_Dithering; // 0x4D
	[SerializeField] // RVA: 0x482D20 Offset: 0x482E21 VA: 0x482D20
	private bool m_ClearDepth; // 0x4E
	[SerializeField] // RVA: 0x482D30 Offset: 0x482E31 VA: 0x482D30
	private bool m_AllowXRRendering; // 0x4F
	[SerializeField] // RVA: 0x482D40 Offset: 0x482E41 VA: 0x482D40
	private bool m_IsAutoReduction; // 0x50
	[SerializeField] // RVA: 0x482D50 Offset: 0x482E51 VA: 0x482D50
	[FormerlySerializedAsAttribute] // RVA: 0x482D50 Offset: 0x482E51 VA: 0x482D50
	private bool m_RequiresDepthTexture; // 0x51
	[SerializeField] // RVA: 0x482DA0 Offset: 0x482EA1 VA: 0x482DA0
	[FormerlySerializedAsAttribute] // RVA: 0x482DA0 Offset: 0x482EA1 VA: 0x482DA0
	private bool m_RequiresColorTexture; // 0x52
	[SerializeField] // RVA: 0x482DF0 Offset: 0x482EF1 VA: 0x482DF0
	[HideInInspector] // RVA: 0x482DF0 Offset: 0x482EF1 VA: 0x482DF0
	private float m_Version; // 0x54
	private static UniversalAdditionalCameraData s_DefaultAdditionalCameraData; // 0x0
	private CustomCameraRenderingFlag m_CustomRenderingFlag; // 0x58

	// Properties
	public float version { get; }
	internal static UniversalAdditionalCameraData defaultAdditionalCameraData { get; }
	public bool renderShadows { get; set; }
	public CameraOverrideOption requiresDepthOption { get; set; }
	public CameraOverrideOption requiresColorOption { get; set; }
	public CameraRenderType renderType { get; set; }
	public List<Camera> cameraStack { get; }
	public bool clearDepth { get; }
	public bool requiresDepthTexture { get; set; }
	public bool requiresColorTexture { get; set; }
	public ScriptableRenderer scriptableRenderer { get; }
	public LayerMask volumeLayerMask { get; set; }
	public Transform volumeTrigger { get; set; }
	public bool renderPostProcessing { get; set; }
	public AntialiasingMode antialiasing { get; set; }
	public AntialiasingQuality antialiasingQuality { get; set; }
	public bool stopNaN { get; set; }
	public bool dithering { get; set; }
	public bool allowXRRendering { get; set; }
	public bool isAutoReduction { get; set; }
	public bool customFlagRenderingMaster { get; set; }
	public CustomCameraRenderingFlag customRenderingFlag { get; set; }

	// Methods

	// RVA: 0x2F90940 Offset: 0x2F90A41 VA: 0x2F90940
	public float get_version() { }

	// RVA: 0x2F90950 Offset: 0x2F90A51 VA: 0x2F90950
	internal static UniversalAdditionalCameraData get_defaultAdditionalCameraData() { }

	// RVA: 0x2F90B30 Offset: 0x2F90C31 VA: 0x2F90B30
	public bool get_renderShadows() { }

	// RVA: 0x2F90B40 Offset: 0x2F90C41 VA: 0x2F90B40
	public void set_renderShadows(bool value) { }

	// RVA: 0x2F90B50 Offset: 0x2F90C51 VA: 0x2F90B50
	public CameraOverrideOption get_requiresDepthOption() { }

	// RVA: 0x2F90B60 Offset: 0x2F90C61 VA: 0x2F90B60
	public void set_requiresDepthOption(CameraOverrideOption value) { }

	// RVA: 0x2F90B70 Offset: 0x2F90C71 VA: 0x2F90B70
	public CameraOverrideOption get_requiresColorOption() { }

	// RVA: 0x2F90B80 Offset: 0x2F90C81 VA: 0x2F90B80
	public void set_requiresColorOption(CameraOverrideOption value) { }

	// RVA: 0x2F90B90 Offset: 0x2F90C91 VA: 0x2F90B90
	public CameraRenderType get_renderType() { }

	// RVA: 0x2F90BA0 Offset: 0x2F90CA1 VA: 0x2F90BA0
	public void set_renderType(CameraRenderType value) { }

	// RVA: 0x2F90BB0 Offset: 0x2F90CB1 VA: 0x2F90BB0
	public List<Camera> get_cameraStack() { }

	// RVA: 0x2F90E20 Offset: 0x2F90F21 VA: 0x2F90E20
	internal void UpdateCameraStack() { }

	// RVA: 0x2F91210 Offset: 0x2F91311 VA: 0x2F91210
	public bool get_clearDepth() { }

	// RVA: 0x2F91220 Offset: 0x2F91321 VA: 0x2F91220
	public bool get_requiresDepthTexture() { }

	// RVA: 0x2F91390 Offset: 0x2F91491 VA: 0x2F91390
	public void set_requiresDepthTexture(bool value) { }

	// RVA: 0x2F913A0 Offset: 0x2F914A1 VA: 0x2F913A0
	public bool get_requiresColorTexture() { }

	// RVA: 0x2F91480 Offset: 0x2F91581 VA: 0x2F91480
	public void set_requiresColorTexture(bool value) { }

	// RVA: 0x2F90D30 Offset: 0x2F90E31 VA: 0x2F90D30
	public ScriptableRenderer get_scriptableRenderer() { }

	// RVA: 0x2F91750 Offset: 0x2F91851 VA: 0x2F91750
	public void SetRenderer(int index) { }

	// RVA: 0x2F91760 Offset: 0x2F91861 VA: 0x2F91760
	public LayerMask get_volumeLayerMask() { }

	// RVA: 0x2F91770 Offset: 0x2F91871 VA: 0x2F91770
	public void set_volumeLayerMask(LayerMask value) { }

	// RVA: 0x2F91780 Offset: 0x2F91881 VA: 0x2F91780
	public Transform get_volumeTrigger() { }

	// RVA: 0x2F91790 Offset: 0x2F91891 VA: 0x2F91790
	public void set_volumeTrigger(Transform value) { }

	// RVA: 0x2F917A0 Offset: 0x2F918A1 VA: 0x2F917A0
	public bool get_renderPostProcessing() { }

	// RVA: 0x2F917B0 Offset: 0x2F918B1 VA: 0x2F917B0
	public void set_renderPostProcessing(bool value) { }

	// RVA: 0x2F917C0 Offset: 0x2F918C1 VA: 0x2F917C0
	public AntialiasingMode get_antialiasing() { }

	// RVA: 0x2F917D0 Offset: 0x2F918D1 VA: 0x2F917D0
	public void set_antialiasing(AntialiasingMode value) { }

	// RVA: 0x2F917E0 Offset: 0x2F918E1 VA: 0x2F917E0
	public AntialiasingQuality get_antialiasingQuality() { }

	// RVA: 0x2F917F0 Offset: 0x2F918F1 VA: 0x2F917F0
	public void set_antialiasingQuality(AntialiasingQuality value) { }

	// RVA: 0x2F91800 Offset: 0x2F91901 VA: 0x2F91800
	public bool get_stopNaN() { }

	// RVA: 0x2F91810 Offset: 0x2F91911 VA: 0x2F91810
	public void set_stopNaN(bool value) { }

	// RVA: 0x2F91820 Offset: 0x2F91921 VA: 0x2F91820
	public bool get_dithering() { }

	// RVA: 0x2F91830 Offset: 0x2F91931 VA: 0x2F91830
	public void set_dithering(bool value) { }

	// RVA: 0x2F91840 Offset: 0x2F91941 VA: 0x2F91840
	public bool get_allowXRRendering() { }

	// RVA: 0x2F91850 Offset: 0x2F91951 VA: 0x2F91850
	public void set_allowXRRendering(bool value) { }

	// RVA: 0x2F91860 Offset: 0x2F91961 VA: 0x2F91860
	public bool get_isAutoReduction() { }

	// RVA: 0x2F91870 Offset: 0x2F91971 VA: 0x2F91870
	public void set_isAutoReduction(bool value) { }

	// RVA: 0x2F91880 Offset: 0x2F91981 VA: 0x2F91880
	public bool get_customFlagRenderingMaster() { }

	// RVA: 0x2F91890 Offset: 0x2F91991 VA: 0x2F91890
	public void set_customFlagRenderingMaster(bool value) { }

	// RVA: 0x2F918A0 Offset: 0x2F919A1 VA: 0x2F918A0
	public CustomCameraRenderingFlag get_customRenderingFlag() { }

	// RVA: 0x2F918B0 Offset: 0x2F919B1 VA: 0x2F918B0
	public void set_customRenderingFlag(CustomCameraRenderingFlag value) { }

	// RVA: 0x2F918C0 Offset: 0x2F919C1 VA: 0x2F918C0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x2F918D0 Offset: 0x2F919D1 VA: 0x2F918D0 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2F918F0 Offset: 0x2F919F1 VA: 0x2F918F0
	public void OnDrawGizmos() { }

	// RVA: 0x2F90A60 Offset: 0x2F90B61 VA: 0x2F90A60
	public void .ctor() { }

	// RVA: 0x2F91AC0 Offset: 0x2F91BC1 VA: 0x2F91AC0
	private static void .cctor() { }
}

